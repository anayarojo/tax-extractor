using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxExtractor.UserControls
{
    public partial class MaterialPanel : UserControl
    {
        private bool showTopLine = true;
        private bool showLeftLine = true;
        private bool showRightLine = true;
        private bool showBottomLine = true;

        public MaterialPanel()
        {
            InitializeComponent();
        }

        [Description("Show top line"), Category("Show")]
        public bool ShowTopLine
        {
            get { return showTopLine; }
            set
            {
                showTopLine = value;
                topDivider.Visible = value;
            }
        }

        [Description("Show left line"), Category("Show")]
        public bool ShowLeftLine
        {
            get { return showLeftLine; }
            set
            {
                showLeftLine = value;
                leftDivider.Visible = value;
            }
        }

        [Description("Show right line"), Category("Show")]
        public bool ShowRightLine
        {
            get { return showRightLine; }
            set
            {
                showRightLine = value;
                rightDivider.Visible = value;
            }
        }

        [Description("Show bottom line"), Category("Show")]
        public bool ShowBottomLine
        {
            get { return showBottomLine; }
            set
            {
                showBottomLine = value;
                bottomDivider.Visible = value;
            }
        }
    }
}
