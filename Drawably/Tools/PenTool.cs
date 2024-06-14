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
            canvas.Invalidate();
        }

        public void OnMouseUp(float x, float y)
        {
            isDrawingEnabled = false;
            canvasContainer.UpdateVisualizedCanvasToAllLayersMerged();
            canvasGraphics = Graphics.FromImage(canvas.Image); // important because after refresh we work with brand new merged bitmap
        }

        // Keeps drawing lines that are connected
        private void KeepDrawing(float x, float y) 
        {
            canvasGraphics.DrawLine(pen, cacheX, cacheY, x, y);

            cacheX = x;
            cacheY = y;

            canvas.Invalidate();
        }

        public void OnToolSelected()
        {
            canvasGraphics = Graphics.FromImage(canvas.Image);
            selectedLayerGraphics = Graphics.FromImage(canvasContainer.SelectedLayerBitmap);
        }

        public void OnToolUnselected()
        {
            canvasGraphics.Dispose();
            selectedLayerGraphics.Dispose();
        }

        public void OnNewLayerSelected()
        {
            // TODO THIS
            throw new NotImplementedException();
        }
    }
}
