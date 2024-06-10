using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawably.UserControls.Windows.Colors
{
    public partial class ColorsWindow : MenuWindow
    {
        public ColorsWindow()
        {
            InitializeComponent();
            this.MenuText = "Colors";
        }
    }
}
