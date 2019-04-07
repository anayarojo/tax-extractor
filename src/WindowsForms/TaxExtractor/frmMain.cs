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
                XElement root = document.Root;
                dgvDetailsList.Rows.Add(fileInfo.Name);
            }
        }
    }
}
