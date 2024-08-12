using Drawably.UserControls.CanvasRelated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawably.Tools.DrawShapesToolRelated.Shapes
{
    internal class NormalTriangleShape : Shape
    {
        public NormalTriangleShape() : base("Normal Triangle")
        {
        }

        public override Shape CopyShape(int newX, int newY, int newWidth, int newHeight, int newBorderSize, bool newIsFilled, Color newBorderColor, Color newFillColor)
        {
            NormalTriangleShape copyTriangle = new NormalTriangleShape();
            copyTriangle.X = newX;
            copyTriangle.Y = newY;
            copyTriangle.Width = newWidth;
            copyTriangle.Height = newHeight;
            copyTriangle.BorderSize = newBorderSize;
            copyTriangle.IsFilled = newIsFilled;
            copyTriangle.BorderColor = newBorderColor;
            copyTriangle.FillColor = newFillColor;
            return copyTriangle;
        }

        public override void DrawShape(Graphics g)
        {
            Pen newPen = new Pen(this.BorderColor, this.BorderSize);

            // Calculate the points of the triangle
            PointF point1 = new PointF(this.X + this.Width / 2, this.Y); // Top middle
            PointF point2 = new PointF(this.X, this.Y + this.Height); // Bottom left
            PointF point3 = new PointF(this.X + this.Width, this.Y + this.Height); // Bottom right

            PointF[] trianglePoints = { point1, point2, point3 };

            // Draw the triangle
            g.DrawPolygon(newPen, trianglePoints);

            newPen.Dispose();
            if (this.IsFilled)
            {
                Brush brush = new SolidBrush(this.FillColor);
                g.FillPolygon(brush, trianglePoints);
                brush.Dispose();
            }
        }
    }
}
