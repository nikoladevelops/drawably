﻿using Drawably.UserControls.CanvasRelated;
using Drawably.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawably.Tools.DrawShapesToolRelated
{
    public class DrawShapesTool : Tool
    {
        // This is the menu that contains a bunch of shapes, when one of those shapes is clicked, a new menu will open up for drawing that shape
        private DrawShapesOptionsControl DrawShapesOptions;
        public DrawShapesTool() : base()
        {
            this.DrawShapesOptions = new DrawShapesOptionsControl();

            Globals.TopPanel.AddToolOptionsControlToTopPanel(this.DrawShapesOptions);
        }

        public override void OnToolSelected()
        {
            base.OnToolSelected();
            this.DrawShapesOptions.Visible = true;
        }

        public override void OnToolUnselected()
        {
            base.OnToolUnselected();
            this.DrawShapesOptions.Visible = false;
        }
    }
}
