using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;

namespace TaxExtractor
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            cboType.Items.Add(new ComboboxItem() { Value = "I", Text = "Comprobantes de Ingreso" });
            cboType.Items.Add(new ComboboxItem() { Value = "E", Text = "Comprobantes de Egreso" });
            cboType.Items.Add(new ComboboxItem() { Value = "T", Text = "Comprobantes de Traslado" });
            cboType.Items.Add(new ComboboxItem() { Value = "N", Text = "Comprobantes de Nómina" });
            cboType.Items.Add(new ComboboxItem() { Value = "P", Text = "Comprobantes de Pago" });
            cboType.SelectedIndex = 0;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            using (var folderBrowser = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowser.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
                {
                    txtPath.Text = folderBrowser.SelectedPath;
                    LoadFiles(folderBrowser.SelectedPath, Directory.GetFiles(folderBrowser.SelectedPath));
                }
            }
        }

        private void CboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPath.Text))
            {
                LoadFiles(txtPath.Text, Directory.GetFiles(txtPath.Text));
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            using (var saveFile = new SaveFileDialog())
            {
                saveFile.Filter = "Excel Documents (*.xls)|*.xls";
                saveFile.FilterIndex = 1;
                saveFile.FileName = "Tax_Extractor_Export.xls";
                saveFile.RestoreDirectory = true;

                DialogResult result = saveFile.ShowDialog();

                if (result == DialogResult.OK)
                {
                    SaveDetailsList(saveFile.FileName);
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea cerrar la aplicación?", "Cerrar aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void LoadFiles(string selectedPath, string[] files)
        {
            dgvDetailsList.Rows.Clear();

            List<FileInfo> fileInfos = files.Select(x => new FileInfo(x))
                .Where(x => x.Extension == ".xml")
                .ToList();

            if(fileInfos.Count == 0)
            {
                MessageBox.Show("No se encontrarón archivos xml.", "Tax Extractor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ComboboxItem selectedType = ((ComboboxItem)cboType.SelectedItem);
            string selectedTypeValue = selectedType.Value.ToString();
            string selectedTypeText = selectedType.Text.ToString();

            var results = fileInfos.Select(x => new { fileInfo = x, document = XDocument.Load(x.FullName) })
                .Select(x => new { fileInfo = x.fileInfo, receipt = x.document.Descendants("{http://www.sat.gob.mx/cfd/3}Comprobante").FirstOrDefault() })
                .Where(x=> x.receipt.Attribute("TipoDeComprobante").Value == selectedTypeValue)
                .ToList();

            if (results.Count == 0)
            {
                MessageBox.Show($"No se encontrarón {selectedTypeText}.", "Tax Extractor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach(var result in results)
            {
                LoadReceipt(result.fileInfo, result.receipt);
            }
        }

        private void LoadReceipt(FileInfo fileInfo, XElement receipt)
        {
            XElement concepts = receipt.Descendants("{http://www.sat.gob.mx/cfd/3}Conceptos").FirstOrDefault();
            XElement complement = receipt.Descendants("{http://www.sat.gob.mx/cfd/3}Complemento").FirstOrDefault();
            XElement timbre = complement.Descendants("{http://www.sat.gob.mx/TimbreFiscalDigital}TimbreFiscalDigital").FirstOrDefault();

            if (concepts == null || complement == null || timbre == null) return;

            string uuid = timbre.Attribute("UUID").Value ?? string.Empty;
            double amount = 0;
            double tax = 0;

            foreach (XElement concept in concepts.DescendantNodes())
            {
                XElement traslado = concept.Descendants("{http://www.sat.gob.mx/cfd/3}Traslado").FirstOrDefault();
                if (traslado != null)
                {
                    amount += Convert.ToDouble(traslado.Attribute("Base").Value);
                    tax += Convert.ToDouble(traslado.Attribute("Importe").Value);
                }
            }

            if (!string.IsNullOrEmpty(uuid))
            {
                dgvDetailsList.Rows.Add(new string[]{
                        fileInfo.Name,
                        uuid,
                        amount.ToString(),
                        tax.ToString(),
                        (amount + tax).ToString()
                    });
            }
        }

        private void SaveDetailsList(string fileName)
        {
            try
            {
                Excel.Application excel = new Excel.Application();
                //excel.Visible = true;
                Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
                Excel.Worksheet sheet1 = (Excel.Worksheet)workbook.Sheets[1];
                int StartCol = 1;
                int StartRow = 1;
                int j = 0, i = 0;

                //Write Headers
                for (j = 0; j < dgvDetailsList.Columns.Count; j++)
                {
                    Excel.Range myRange = (Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = dgvDetailsList.Columns[j].HeaderText;
                }

                StartRow++;

                //Write datagridview content
                for (i = 0; i < dgvDetailsList.Rows.Count; i++)
                {
                    for (j = 0; j < dgvDetailsList.Columns.Count; j++)
                    {
                        try
                        {
                            Excel.Range myRange = (Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                            myRange.Value2 = dgvDetailsList[j, i].Value == null ? "" : dgvDetailsList[j, i].Value;
                        }
                        catch
                        {
                            // None;
                        }
                    }
                }

                object missingValue = System.Reflection.Missing.Value;
                workbook.SaveAs(fileName, Excel.XlFileFormat.xlWorkbookNormal, missingValue, missingValue, missingValue, missingValue, Excel.XlSaveAsAccessMode.xlExclusive, missingValue, missingValue, missingValue, missingValue, missingValue);
                excel.DisplayAlerts = true;
                workbook.Close(true, missingValue, missingValue);
                excel.Quit();

                releaseObject(sheet1);
                releaseObject(workbook);
                releaseObject(excel);

                MessageBox.Show("El archivo se con los detalles se ha guardado correctamente", "Tax Extractor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Tax Extractor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occurred while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
