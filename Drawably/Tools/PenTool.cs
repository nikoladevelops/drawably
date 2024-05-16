using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawably.Tools
{
    public class PenTool : IToolable
    {
        public Color CurrentColor { get; set; } = Color.Red;
        public int Size { get; set; } = 25;

        public int MyProperty { get; set; }
        public void OnMouseLeftClick(Graphics g, float locationX, float locationY)
        {
            Pen p = new Pen(Color.Red);
            Brush b = new SolidBrush(CurrentColor);
            //g.FillRectangle(b, locationX, locationY, 100, 150);
            g.FillEllipse(Brushes.Black, locationX - this.Size/2, locationY - this.Size/2, Size, Size);
        }

        public void OnMouseRightClick(Graphics g, float locationX, float locationY)
        {
            //g.DrawRectangle(p, new Rectangle(10, 10, 100, 150));
        }
    }
}
