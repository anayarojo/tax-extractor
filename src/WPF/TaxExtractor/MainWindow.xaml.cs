using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Reflection;
using TaxExtractor.UserControls;

namespace TaxExtractor
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Windows.Forms.FolderBrowserDialog mObjInvoicesFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
        System.Windows.Forms.FolderBrowserDialog mObjResultFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
        string mStrInvoicesDirectory = "";
        string mStrResultDirectory = "";

        public MainWindow()
        {
            InitializeComponent();
            mStrInvoicesDirectory = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            mStrResultDirectory = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            txtInvoicesPath.Text = mStrInvoicesDirectory;
            txtResultPath.Text = mStrResultDirectory;

            //FolderBrowser lObjFolderBrowser = new FolderBrowser();
            //grdDialogContent.Children.Add(lObjFolderBrowser);
        }

        private void DialogHost_DialogClosing(object sender, MaterialDesignThemes.Wpf.DialogClosingEventArgs eventArgs)
        {

        }

        private void btnSearchInvoicesPath_Click(object sender, RoutedEventArgs e)
        {
            if(mObjInvoicesFolderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtInvoicesPath.Text = mObjInvoicesFolderBrowserDialog.SelectedPath;
            }
        }

        private void btnSearchResultPath_Click(object sender, RoutedEventArgs e)
        {
            if (mObjResultFolderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtResultPath.Text = mObjResultFolderBrowserDialog.SelectedPath;
            }
        }
    }
}
