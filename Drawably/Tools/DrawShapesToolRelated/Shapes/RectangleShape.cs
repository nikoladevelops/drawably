using Drawably.UserControls.CanvasRelated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawably.Tools.DrawShapesToolRelated.Shapes
{
    public class RectangleShape : Shape
    {
        public RectangleShape():base("Rectangle")
        {
        }

        public RectangleShape(CanvasContainer newCanvasContainer) : base("Rectangle", newCanvasContainer)
        {
        }

        public override Shape CopyShape(int newX, int newY, int newWidth, int newHeight, int newBorderSize, bool newIsFilled)
        {
            RectangleShape copyRectangle = new RectangleShape();
            copyRectangle.canvasContainer = this.canvasContainer;
            copyRectangle.Name = this.Name;
            copyRectangle.X = newX;
            copyRectangle.Y = newY;
            copyRectangle.Width = newWidth;
            copyRectangle.Height = newHeight;
            copyRectangle.BorderSize = newBorderSize;
            copyRectangle.IsFilled = newIsFilled;
            return copyRectangle;
        }

        public override void DrawShape(Graphics g)
        {
            Pen newPen = new Pen(this.canvasContainer.CurrentLeftColor, this.BorderSize);

            g.DrawRectangle(newPen, this.X, this.Y, this.Width, this.Height);

            newPen.Dispose();
            if (this.IsFilled)
            {
                Brush brush = new SolidBrush(this.canvasContainer.CurrentRightColor);
                // Calculate the inner rectangle dimensions
                float halfBorderSize = this.BorderSize / 2.0f;
                float innerX = this.X + halfBorderSize;
                float innerY = this.Y + halfBorderSize;
                float innerWidth = this.Width - this.BorderSize;
                float innerHeight = this.Height - this.BorderSize;

                // Fill the inner rectangle
                g.FillRectangle(brush, innerX, innerY, innerWidth, innerHeight);
                brush.Dispose();
            }
        }
    }
}
