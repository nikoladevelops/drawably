using Drawably.UserControls.CanvasRelated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawably.Tools.DrawShapesToolRelated
{
    public class DrawShapesTool : Tool
    {
        public DrawShapesTool(CanvasContainer newCanvasContainer) : base(newCanvasContainer)
        {
        }

        public override void OnLeftColorChangedWhileToolSelected()
        {
            throw new NotImplementedException();
        }

        public override void OnRightColorChangedWhileToolSelected()
        {
            throw new NotImplementedException();
        }
    }
}
