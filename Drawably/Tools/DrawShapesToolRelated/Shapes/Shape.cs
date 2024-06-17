using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawably.Tools.DrawShapesToolRelated.Shapes
{
    public abstract class Shape
    {
        public Shape(string newName)
        {
            this.Name = newName;
        }
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        /// <summary>
        /// Creates a copy of the shape, but with populated properties
        /// </summary>
        public abstract Shape CopyShape(int newX, int newY, int newWidth, int newHeight);

        /// <summary>
        /// Draws itself on a graphics object
        /// </summary>
        public abstract void DrawShape(Graphics g);
    }
}
