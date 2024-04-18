using Drawably.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawably
{
    public partial class MenuWindow : UserControl
    {
        public MenuWindow()
        {
            InitializeComponent();
            this.EnableDrag(topPanel);
        }

        private void dragPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuWindowLoad(object sender, EventArgs e)
        {

        }
    }
}
