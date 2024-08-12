using Drawably.Tools.BrushToolRelated;
using Drawably.UserControls.CanvasRelated;
using Drawably.Utility;
using System.Drawing.Drawing2D;

namespace Drawably.Tools.PenToolRelated
{
    public class BrushTool : Tool
    {
        public BrushOptionsControl BrushControl { get; set; }
        public int Size { get; set; } = 5; // Note: same as in BrushOptionsControl

        private bool isDrawingEnabled;

        private Pen leftPen;
        private Brush leftBrush;

        private Pen rightPen;
        private Brush rightBrush;

        float cacheX;
        float cacheY;

        private Pen penToKeepDrawingWith;
        private Brush brushToApplyFirstDotWith;

        public BrushTool()
        {
            BrushControl = new BrushOptionsControl(this);
            BrushControl.Visible = false;
            Globals.CanvasContainer.PlaceToolControlInsideTopPanel(BrushControl);
        }

        /// <summary>
        /// Creates all necessary tools - pens/brushes etc..
        /// </summary>
        private void CreateNecessaryTools() 
        {
            leftPen = new Pen(Globals.ColorsWindow.LeftColor, Size);
            leftPen.EndCap = LineCap.Round;
            leftPen.StartCap = LineCap.Round;

            leftBrush = new SolidBrush(Globals.ColorsWindow.LeftColor);

            rightPen = new Pen(Globals.ColorsWindow.RightColor, Size);
            rightPen.EndCap = LineCap.Round;
            rightPen.StartCap = LineCap.Round;

            rightBrush = new SolidBrush(Globals.ColorsWindow.RightColor);
        }

        /// <summary>
        /// Keeps drawing lines that are connected with the appropriate pen. Called each time the mouse moves
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="penToUse">The pen to be used - left/right</param>
        private void KeepDrawing(float x, float y)
        {
            canvasGraphics.DrawLine(penToKeepDrawingWith, cacheX, cacheY, x, y);

            // Do the drawing inside the selected layer as well
            selectedLayerGraphics.DrawLine(penToKeepDrawingWith, cacheX, cacheY, x, y);

            cacheX = x;
            cacheY = y;

            Globals.CanvasContainer.RefreshCanvas();
        }

        /// <summary>
        /// When the user stops drawing (mouse up event), disable drawing
        /// </summary>
        private void StopDrawing() 
        {
            isDrawingEnabled = false;
            Globals.CanvasContainer.OnSelectedToolFinishedDrawing();
            canvasGraphics = Globals.CanvasContainer.CanvasGraphics; // important because after refresh we work with brand new merged bitmap
        }

        /// <summary>
        /// Enables drawing with the held mouse button - left/right
        /// </summary>
        private void EnableDrawing(float x, float y) 
        {
            isDrawingEnabled = true;
            cacheX = x;
            cacheY = y;

            // This is so I can place the initial dot when a click occurs
            canvasGraphics.FillEllipse(brushToApplyFirstDotWith, x - Size / 2, y - Size / 2, Size, Size);
            // Do the same on top of the selected layer
            selectedLayerGraphics.FillEllipse(brushToApplyFirstDotWith, x - Size / 2, y - Size / 2, Size, Size);

            Globals.CanvasContainer.RefreshCanvas();
        }

        public override void OnMouseMove(float x, float y)
        {
            if (isDrawingEnabled)
            {
                KeepDrawing(x, y);
            }
        }

        public override void OnMouseLeftClickDown(float x, float y)
        {
            penToKeepDrawingWith = leftPen;
            brushToApplyFirstDotWith = leftBrush;
            EnableDrawing(x,y);
        }

        public override void OnMouseLeftClickUp(float x, float y)
        {
            StopDrawing();
        }

        public override void OnMouseRightClickDown(float x, float y)
        {
            penToKeepDrawingWith = rightPen;
            brushToApplyFirstDotWith = rightBrush;
            EnableDrawing(x,y);
        }

        public override void OnMouseRightClickUp(float x, float y)
        {
            StopDrawing();
        }

        public override void OnLeftColorChangedWhileToolSelected()
        {
            leftBrush.Dispose();
            leftBrush = new SolidBrush(Globals.ColorsWindow.LeftColor);
            leftPen.Color = Globals.ColorsWindow.LeftColor;
        }

        public override void OnRightColorChangedWhileToolSelected()
        {
            rightBrush.Dispose();
            rightBrush = new SolidBrush(Globals.ColorsWindow.RightColor);
            rightPen.Color = Globals.ColorsWindow.RightColor;
        }

        public override void OnToolSelected()
        {
            base.OnToolSelected();
            CreateNecessaryTools();

            BrushControl.Visible = true;
        }

        public override void OnToolUnselected()
        {
            base.OnToolUnselected();

            DisposeOfOldTools();

            BrushControl.Visible = false;
        }

        /// <summary>
        /// Disposes of old tools
        /// </summary>
        private void DisposeOfOldTools() 
        {
            leftPen.Dispose();
            leftBrush.Dispose();

            rightPen.Dispose();
            rightBrush.Dispose();
        }

        /// <summary>
        /// Called by the BrushOptionsControl, whenever the brush size was changed
        /// </summary>
        /// <param name="newBrushSize"></param>
        public void BrushSizeChanged(int newBrushSize) 
        {
            this.Size = newBrushSize;

            DisposeOfOldTools();
            CreateNecessaryTools();
        }
    }
}
