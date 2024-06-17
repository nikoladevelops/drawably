using Drawably.UserControls.CanvasRelated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawably.Tools.ZoomInToolRelated
{
    internal class ZoomInTool : Tool
    {
        public ZoomInTool(CanvasContainer newCanvasContainer) : base(newCanvasContainer)
        {
        }

        public override void OnMouseLeftClickDown(float x, float y)
        {
            this.canvasContainer.ZoomIn();
        }
    }
}
