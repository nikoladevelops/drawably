using Drawably.UserControls;
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

        private Pen pen;
        private Brush brush;

        private Graphics g;
        private PictureBox canvas;

        float cacheX;
        float cacheY;

        public PenTool(CanvasContainer cc)
        {
            pen = new Pen(CurrentColor, Size);
            pen.EndCap = LineCap.Round;
            pen.StartCap = LineCap.Round;

            brush = new SolidBrush(CurrentColor);

            this.g = cc.g;
            this.canvas = cc.Canvas;
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
            g.FillEllipse(brush, x - Size/2, y - Size/2, Size, Size);
            canvas.Invalidate();
        }

        public void OnMouseUp(float x, float y)
        {
            isDrawingEnabled = false;
        }

        // Keeps drawing lines that are connected
        private void KeepDrawing(float x, float y) 
        {
            g.DrawLine(pen, cacheX, cacheY, x, y);

            cacheX = x;
            cacheY = y;

            canvas.Invalidate();
        }
    }
}
