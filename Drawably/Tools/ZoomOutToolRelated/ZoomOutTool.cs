using Drawably.UserControls.CanvasRelated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawably.Tools.ZoomOutToolRelated
{
    internal class ZoomOutTool : Tool
    {
        public ZoomOutTool(CanvasContainer newCanvasContainer) : base(newCanvasContainer)
        {
        }

        public override void OnMouseLeftClickDown(float x, float y)
        {
            this.canvasContainer.ZoomOut();
        }
    }
}
