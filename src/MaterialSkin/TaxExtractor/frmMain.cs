using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace TaxExtractor
{
    public partial class frmMain : MaterialForm
    {
        public frmMain()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            lsvDetailsList.Items.Add(new ListViewItem(new string[] { "dsadas", "dsds" }));
            lsvDetailsList.Items.Add(new ListViewItem(new string[] { "dsadadass da s", "ssdaad" }));
            lsvDetailsList.Items.Add(new ListViewItem(new string[] { "dsadadass s", "dsadsa" }));
            lsvDetailsList.Items.Add(new ListViewItem(new string[] { "dsadas da s", "dasda" }));

            FitLisViewColumns();

            // listView1.Items.Add(new{ a = "dsds", b = "dsds", c = "dsdsds", d = "dssdsds", e = "dssdsds" });
            //listView1.Items.Add(new ListViewItem(new string[]{"dsds", "dsds", "dsdsds", "dssdsds", "dssdsds" }));
        }

        private void FitLisViewColumns()
        {
            List<ColumnHeader> columnsList = new List<ColumnHeader>();

            foreach (ColumnHeader column in lsvDetailsList.Columns) columnsList.Add(column);

            int listViewWidth = lsvDetailsList.Width - 20;
            int columnsCount = lsvDetailsList.Columns.Count;
            int columnsTotalWidth = columnsList.Select( x => x.Width).Sum();

            foreach (ColumnHeader column in lsvDetailsList.Columns)
            {
                double oldWidth = Convert.ToDouble(column.Width);
                double widthFactor = oldWidth / columnsTotalWidth;
                double newWidth = listViewWidth * widthFactor;
                column.Width = Convert.ToInt32(newWidth);
            }
        }

        private void LsvDetailsList_Resize(object sender, EventArgs e)
        {
            FitLisViewColumns();
        }
    }
}
