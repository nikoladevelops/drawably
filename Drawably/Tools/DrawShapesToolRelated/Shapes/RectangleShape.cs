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

        public override Shape CopyShape(int newX, int newY, int newWidth, int newHeight)
        {
            RectangleShape copyRectangle = new RectangleShape();
            copyRectangle.Name = this.Name;
            copyRectangle.X = newX;
            copyRectangle.Y = newY;
            copyRectangle.Width = newWidth;
            copyRectangle.Height = newHeight;
            return copyRectangle;
        }

        public override void DrawShape(Graphics g)
        {
            Pen newPen = new Pen(Color.Red);
            g.DrawRectangle(newPen, this.X, this.Y, this.Width, this.Height);
        }
    }
}
