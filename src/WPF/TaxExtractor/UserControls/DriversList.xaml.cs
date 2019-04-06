using System.Collections.Generic;
using System.IO;
using System.Windows.Controls;
using TaxExtractor.Models;

namespace TaxExtractor.UserControls
{
    /// <summary>
    /// Lógica de interacción para DriversList.xaml
    /// </summary>
    public partial class DriversList : UserControl
    {
        private List<SelectableViewModel> lstDevices = new List<SelectableViewModel>();

        public DriversList()
        {
            InitializeComponent();
            lstDevices.Clear();

            foreach (DriveInfo lObjDriveInfo in DriveInfo.GetDrives())
            {
                lstDevices.Add(new SelectableViewModel()
                {
                    Name = lObjDriveInfo.Name,
                    Parent = lstDevices,
                });
            }

            itemsControl.ItemsSource = null;
            itemsControl.ItemsSource = lstDevices;
        }
    }
}
