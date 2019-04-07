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

namespace TaxExtractor
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            using (var saveFile = new SaveFileDialog())
            {
                saveFile.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                saveFile.FilterIndex = 1;
                saveFile.RestoreDirectory = true;

                DialogResult result = saveFile.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // TODO: guardar csv de la extracción de los detalles
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
            FileInfo[] fileInfos = files.Select(x => new FileInfo(x)).Where(x => x.Extension == ".xml").ToArray();

            if(fileInfos.Length == 0)
            {
                MessageBox.Show("No se encontraron archivos xml.", "Tax Extractor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach(FileInfo fileInfo in fileInfos)
            {
                XDocument document = XDocument.Load(fileInfo.FullName);
                LoadInvoice(fileInfo.Name, document);   
            }
        }

        private void LoadInvoice(string fileName, XDocument document)
        {
            XElement comprobante = document.Descendants("{http://www.sat.gob.mx/cfd/3}Comprobante").FirstOrDefault();
            XElement conceptos = comprobante.Descendants("{http://www.sat.gob.mx/cfd/3}Conceptos").FirstOrDefault();
            XElement complemento = comprobante.Descendants("{http://www.sat.gob.mx/cfd/3}Complemento").FirstOrDefault();
            XElement timbre = complemento.Descendants("{http://www.sat.gob.mx/TimbreFiscalDigital}TimbreFiscalDigital").FirstOrDefault();

            if (comprobante == null || conceptos == null || complemento == null || timbre == null) return;

            string uuid = timbre.Attribute("UUID").Value ?? string.Empty;
            double amount = 0;
            double tax = 0;
            
            foreach(XElement concepto in conceptos.DescendantNodes())
            {
                XElement traslado = concepto.Descendants("{http://www.sat.gob.mx/cfd/3}Traslado").FirstOrDefault();
                if(traslado != null)
                {
                    amount += Convert.ToDouble(traslado.Attribute("Base").Value);
                    tax += Convert.ToDouble(traslado.Attribute("Importe").Value);
                }
            }


            if (!string.IsNullOrEmpty(uuid))
            {
                dgvDetailsList.Rows.Add(new string[]{
                        fileName,
                        uuid,
                        amount.ToString(),
                        tax.ToString(),
                        (amount + tax).ToString()
                    });
            }
        }
    }
}
