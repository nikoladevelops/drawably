using Drawably.UserControls.CanvasRelated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawably.Tools.DrawShapesToolRelated.Shapes
{
    public class CircleShape : Shape
    {
        public CircleShape() : base("Circle")
        {
        }

        public CircleShape(CanvasContainer newCanvasContainer) : base("Circle", newCanvasContainer)
        {
        }

        public override Shape CopyShape(int newX, int newY, int newWidth, int newHeight, int newBorderSize, bool newIsFilled, Color newBorderColor, Color newFillColor)
        {
            CircleShape copyCircle = new CircleShape();
            copyCircle.canvasContainer = this.canvasContainer;
            copyCircle.Name = this.Name;
            copyCircle.X = newX;
            copyCircle.Y = newY;
            copyCircle.Width = newWidth;
            copyCircle.Height = newHeight; // Height is used as diameter for circle
            copyCircle.BorderSize = newBorderSize;
            copyCircle.IsFilled = newIsFilled;
            copyCircle.BorderColor = newBorderColor;
            copyCircle.FillColor = newFillColor;
            return copyCircle;
        }

        public override void DrawShape(Graphics g)
        {
            Pen newPen = new Pen(this.BorderColor, this.BorderSize);

            // Calculate the rectangle that bounds the circle
            Rectangle bounds = new Rectangle((int)this.X, (int)this.Y, this.Width, this.Height);

            // Draw the circle
            g.DrawEllipse(newPen, bounds);

            newPen.Dispose();
            if (this.IsFilled)
            {
                Brush brush = new SolidBrush(this.FillColor);
                g.FillEllipse(brush, bounds);
                brush.Dispose();
            }
        }
    }
}
