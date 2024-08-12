using Drawably.UserControls.CanvasRelated;
using Drawably.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawably.Tools.ZoomOutToolRelated
{
    internal class ZoomOutTool : Tool
    {
        public ZoomOutTool() : base()
        {
        }

        public override void OnMouseLeftClickDown(float x, float y)
        {
            Globals.CanvasContainer.ZoomOut();
        }
    }
}
