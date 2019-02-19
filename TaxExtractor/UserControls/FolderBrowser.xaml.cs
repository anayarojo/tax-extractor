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

namespace TaxExtractor.UserControls
{
    /// <summary>
    /// Lógica de interacción para FolderBrowser.xaml
    /// </summary>
    public partial class FolderBrowser : UserControl
    {
        public ObservableCollection<DriveInfo> lstDevices = new ObservableCollection<DriveInfo>();
        public ObservableCollection<Models.Item> lstFolders = new ObservableCollection<Models.Item>();
        public ObservableCollection<Models.Item> lstSubfolders = new ObservableCollection<Models.Item>();

        public FolderBrowser()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (DriveInfo lObjDriveInfo in DriveInfo.GetDrives())
            {
                lstDevices.Add(lObjDriveInfo);
            }
            lsvDevices.ItemsSource = null;
            lsvDevices.ItemsSource = lstDevices;
        }
    }
}
