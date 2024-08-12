using Drawably.UserControls.CanvasRelated;
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
        public float X { get; set; }
        public float Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int BorderSize { get; set; }
        public bool IsFilled { get; set; }

        public float Rotation { get; set; } = 0;

        //
        public Color FillColor { get; set; }
        public Color BorderColor { get; set; }
        //

        // For dragging etc..
        public bool IsSelectedInGroup { get; set; }
        public Rectangle SelectionDimensions 
        { 
            get
            {
                return new Rectangle((int)this.X, (int)this.Y, this.Width, this.Height);
            }
        }

        /// <summary>
        /// Creates a copy of the shape, but with populated properties
        /// </summary>
        public abstract Shape CopyShape(int newX, int newY, int newWidth, int newHeight, int newBorderSize, bool newIsFilled, Color newBorderColor, Color newFillColor);

        /// <summary>
        /// Draws itself on a graphics object
        /// </summary>
        public abstract void DrawShape(Graphics g);

        /// <summary>
        /// Changes the position of the shape
        /// </summary>
        /// <param name="xAmount"></param>
        /// <param name="yAmount"></param>
        public void MoveShapeByAmount(float xAmount, float yAmount) 
        {
            this.X += xAmount;
            this.Y += yAmount;
        }
    }
}
