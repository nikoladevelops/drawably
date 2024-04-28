using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawably.UserControls.CustomMenuStrip
{
    public class CustomMenuStripRenderer : ToolStripProfessionalRenderer
    {
        public CustomMenuStripRenderer() : base(new CustomMenuStripColorTable()) { }
    }
}
