using Drawably.UserControls.CanvasRelated;
using Drawably.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawably.Tools.ZoomInToolRelated
{
    internal class ZoomInTool : Tool
    {
        public ZoomInTool() : base()
        {
        }

        public override void OnMouseLeftClickDown(float x, float y)
        {
            Globals.CanvasContainer.ZoomIn();
        }
    }
}
