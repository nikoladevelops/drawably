using Drawably.UserControls.CanvasRelated;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawably.Tools
{
    public class PenTool : IToolable
    {
        public Color CurrentColor { get; set; } = Color.Black; // todo when changing color change both the brush and the pen's
        public int Size { get; set; } = 25; // Todo when changing size, change both the brush's size and the pen's size
        private bool isDrawingEnabled;


        private PictureBox canvas;
        private CanvasContainer canvasContainer;

        private Pen pen;
        private Brush brush;

        private Graphics canvasGraphics;
        private Graphics selectedLayerGraphics;
        
        float cacheX;
        float cacheY;

        public PenTool(CanvasContainer newCanvasContainer)
        {
            pen = new Pen(CurrentColor, Size);
            pen.EndCap = LineCap.Round;
            pen.StartCap = LineCap.Round;

            brush = new SolidBrush(CurrentColor);

            this.canvasContainer = newCanvasContainer;
            this.canvas = newCanvasContainer.CanvasPictureBox;
        }
        public void OnMouseMove(float x, float y)
        {
            if (isDrawingEnabled)
            {
                KeepDrawing(x, y);
            }
        }

        public void OnMouseLeftClick(float x, float y)
        {
        }

        public void OnMouseRightClick(float x, float y)
        {
        }

        public void OnMouseDown(float x, float y)
        {
            isDrawingEnabled = true;
            cacheX = x;
            cacheY = y;

            // This is so I can place the initial dot when a click occurs
            canvasGraphics.FillEllipse(brush, x - Size/2, y - Size/2, Size, Size);
            // Do the same on top of the selected layer
            selectedLayerGraphics.FillEllipse(brush, x - Size / 2, y - Size / 2, Size, Size);

            canvas.Invalidate();
        }

        public void OnMouseUp(float x, float y)
        {
            isDrawingEnabled = false;
            canvasContainer.OnSelectedToolFinishedDrawing();

            canvasGraphics = Graphics.FromImage(canvas.Image); // important because after refresh we work with brand new merged bitmap
        }

        // Keeps drawing lines that are connected
        private void KeepDrawing(float x, float y) 
        {
            canvasGraphics.DrawLine(pen, cacheX, cacheY, x, y);
            // Do the drawing inside the selected layer as well
            selectedLayerGraphics.DrawLine(pen, cacheX, cacheY, x, y);

            cacheX = x;
            cacheY = y;

            canvas.Invalidate();
        }

        /// <summary>
        /// When the tool is selected create brand new graphics objects. Canvas graphics is for the visualized canvas. Selected layer graphics is for the selected layer's bitmap
        /// </summary>
        public void OnToolSelected()
        {
            canvasGraphics = Graphics.FromImage(canvas.Image);
            selectedLayerGraphics = Graphics.FromImage(canvasContainer.SelectedLayerBitmap);
        }

        /// <summary>
        /// When a tool is unselected, dispose of previous graphics objects
        /// </summary>
        public void OnToolUnselected()
        {
            canvasGraphics.Dispose();
            selectedLayerGraphics.Dispose();
        }

        /// <summary>
        /// Update the canvas graphics that you draw on. Happens when the canvas container gets updated Bitmap with all merged layers.
        /// </summary>
        public void GetNewCanvasGraphics()
        {
            if (canvasGraphics != null) 
            {
                canvasGraphics.Dispose();
            }
            canvasGraphics = Graphics.FromImage(canvas.Image);
        }

        /// <summary>
        /// Update the selected layer graphics. Happens when a new layer is selected.
        /// </summary>
        public void GetNewSelectedLayerGraphics()
        {
            if (selectedLayerGraphics != null)
            {
                selectedLayerGraphics.Dispose();
            }
            selectedLayerGraphics = Graphics.FromImage(canvasContainer.SelectedLayerBitmap);
        }

        /// <summary>
        ///  When the tool finishes drawing, tell the canvas container to apply the necessary changes (merging all layers -> telling the tool to update the graphics etc..)
        /// </summary>
        public void OnToolFinishedDrawing()
        {
            this.canvasContainer.OnSelectedToolFinishedDrawing();
        }
    }
}
