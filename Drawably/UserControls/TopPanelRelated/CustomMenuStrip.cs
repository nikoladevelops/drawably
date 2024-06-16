using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Drawably.UserControls.TopPanelRelated
{
    public class CustomMenuStrip : MenuStrip
    {
        public CustomMenuStrip() 
        {
            this.ForeColor = Color.White;
            this.BackColor = Color.Black;
            this.Renderer = new CustomMenuStripRenderer();
        }
    }
}
