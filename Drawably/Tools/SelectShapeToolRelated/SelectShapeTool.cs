using Drawably.Tools.DrawShapesToolRelated.Shapes;
using Drawably.UserControls.CanvasRelated;
using Drawably.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawably.Tools.SelectShapeToolRelated
{
    public class SelectShapeTool : Tool
    {
        private SelectShapeOptionsControl selectShapeOptions;

        private bool isDragging = false;

        private float cacheX;
        private float cacheY;
        public SelectShapeTool() : base()
        {
            selectShapeOptions = new SelectShapeOptionsControl();
            Globals.CanvasContainer.PlaceToolControlInsideTopPanel(this.selectShapeOptions);
        }

        /// <summary>
        /// Used for selecting a shape in the current layer
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public override void OnMouseLeftClickDown(float x, float y)
        {
            Shape? shape = Globals.CanvasContainer.GetShapeUnderneathMousePositionOnCurrentLayer(x, y);
            this.selectShapeOptions.SelectShape(shape);

            cacheX = x;
            cacheY = y;
            isDragging = true;
        }

        /// <summary>
        /// Used for deselecting a shape in the current layer
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public override void OnMouseRightClickDown(float x, float y)
        {
            Shape? shape = Globals.CanvasContainer.GetShapeUnderneathMousePositionOnCurrentLayer(x, y);
            this.selectShapeOptions.UnselectShape(shape);
        }

        /// <summary>
        /// When the mouse left click is up, stop dragging
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public override void OnMouseLeftClickUp(float x, float y)
        {
            isDragging = false;
        }

        /// <summary>
        /// When the mouse left click is held down and the mouse is moving, keep dragging
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public override void OnMouseMove(float x, float y)
        {
            if (isDragging) 
            {
                this.selectShapeOptions.MoveAllSelectedShapes(x - cacheX, y-cacheY);
                cacheX = x;
                cacheY = y;
            }
        }

        public override void OnToolSelected()
        {
            base.OnToolSelected();
            this.selectShapeOptions.Open();
        }

        public override void OnToolUnselected()
        {
            base.OnToolUnselected();
            this.selectShapeOptions.Close();
        }

    }
}
