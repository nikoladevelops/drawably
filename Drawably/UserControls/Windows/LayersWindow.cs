using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawably.UserControls.Windows
{
    public partial class LayersWindow : MenuWindow
    {
        public LayersWindow()
        {
            InitializeComponent();
            this.MenuText = "Layers";
        }
    }
}
