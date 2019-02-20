using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Lógica de interacción para DriversListView.xaml
    /// </summary>
    public partial class DriversListView : UserControl
    {
        public List<SelectableViewModel> lstDevices = new List<SelectableViewModel>();

        public DriversListView()
        {
            InitializeComponent();
            lstDevices.Clear();

            foreach (DriveInfo lObjDriveInfo in DriveInfo.GetDrives())
            {
                lstDevices.Add(new SelectableViewModel() {
                    Name = lObjDriveInfo.Name,
                    Parent = lstDevices,
                });
            }

            itemControl.ItemsSource = null;
            itemControl.ItemsSource = lstDevices;
        }
    }
}
