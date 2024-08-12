using Drawably.UserControls.CanvasRelated;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawably.Tools.DrawShapesToolRelated.Shapes
{
    public class RightArrowShape : Shape
    {
        public RightArrowShape() : base("Right Arrow")
        {
        }

        public override Shape CopyShape(int newX, int newY, int newWidth, int newHeight, int newBorderSize, bool newIsFilled, Color newBorderColor, Color newFillColor)
        {
            RightArrowShape copyArrow = new RightArrowShape();
            copyArrow.X = newX;
            copyArrow.Y = newY;
            copyArrow.Width = newWidth;
            copyArrow.Height = newHeight;
            copyArrow.BorderSize = newBorderSize;
            copyArrow.IsFilled = newIsFilled;
            copyArrow.BorderColor = newBorderColor;
            copyArrow.FillColor = newFillColor;
            return copyArrow;
        }

        public override void DrawShape(Graphics g)
        {
            Pen pen = new Pen(this.BorderColor, this.BorderSize);

            // Calculate rectangle dimensions
            int rectWidth = this.Width - this.Height;
            Rectangle rectangle = new Rectangle((int)this.X, (int)this.Y, rectWidth, this.Height);

            // Draw the rectangle
            g.DrawRectangle(pen, rectangle);
            if (this.IsFilled)
            {
                Brush brush = new SolidBrush(this.FillColor);
                g.FillRectangle(brush, rectangle);
                brush.Dispose();
            }

            // Calculate triangle dimensions
            PointF[] trianglePoints = new PointF[3];
            trianglePoints[0] = new PointF(this.X + rectWidth, this.Y); // Top right of rectangle
            trianglePoints[1] = new PointF(this.X + this.Width, this.Y + this.Height / 2); // Middle of the right side
            trianglePoints[2] = new PointF(this.X + rectWidth, this.Y + this.Height); // Bottom right of rectangle

            // Draw the triangle
            g.DrawPolygon(pen, trianglePoints);
            if (this.IsFilled)
            {
                Brush brush = new SolidBrush(this.FillColor);
                g.FillPolygon(brush, trianglePoints);
                brush.Dispose();
            }

            pen.Dispose();
        }
    }
}
