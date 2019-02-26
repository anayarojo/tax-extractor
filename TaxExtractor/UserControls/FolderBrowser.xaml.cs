using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
using TaxExtractor.Models;

namespace TaxExtractor.UserControls
{
    /// <summary>
    /// Lógica de interacción para FolderBrowser.xaml
    /// </summary>
    public partial class FolderBrowser : UserControl
    {
        public List<FolderBrowserItem> lstDevices = new List<FolderBrowserItem>();
        public List<FolderBrowserItem> lstFolders = new List<FolderBrowserItem>();

        public FolderBrowser()
        {
            InitializeComponent();
            lstDevices.Clear();
            lstFolders.Clear();

            foreach (DriveInfo lObjDriveInfo in DriveInfo.GetDrives())
            {
                lstDevices.Add(new FolderBrowserItem() {
                    Icon = "Harddisk",
                    Name = lObjDriveInfo.Name,
                    Object = lObjDriveInfo
                });
            }

            lsvDevices.ItemsSource = null;
            lsvDevices.ItemsSource = lstDevices;
        }

        private void LsvDevices_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FolderBrowserItem lObjFolderBrowserItem = (FolderBrowserItem)lsvDevices.SelectedItem;
            DriveInfo lObjDriveInfo = (DriveInfo)lObjFolderBrowserItem.Object;
            lstFolders.Clear();

            foreach (DirectoryInfo lObjDirectoryInfo in lObjDriveInfo.RootDirectory.GetDirectories())
            {
                lstFolders.Add(new FolderBrowserItem()
                {
                    Icon = "Folder",
                    Name = lObjDirectoryInfo.Name,
                    Object = lObjDirectoryInfo
                });
            }

            lsvFolders.ItemsSource = null;
            lsvFolders.ItemsSource = lstFolders;
        }

        private void LsvFolders_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            FolderBrowserItem lObjFolderBrowserItem = lsvFolders.SelectedItem as FolderBrowserItem;
            DirectoryInfo lObjSelected = null;

            if (lObjFolderBrowserItem != null)
            {
                lObjSelected = (DirectoryInfo)lObjFolderBrowserItem.Object;
                lstFolders.Clear();

                lstFolders.Add(new FolderBrowserItem()
                {
                    Icon = "Arrow",
                    Name = "Regresar",
                    Object = null
                });

                foreach (DirectoryInfo lObjDirectoryInfo in lObjSelected.GetDirectories())
                {
                    lstFolders.Add(new FolderBrowserItem()
                    {
                        Icon = "Folder",
                        Name = lObjDirectoryInfo.Name,
                        Object = lObjDirectoryInfo
                    });
                }

                lsvFolders.ItemsSource = null;
                lsvFolders.ItemsSource = lstFolders;
            }
        }
    }
}
