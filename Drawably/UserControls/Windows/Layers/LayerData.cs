using Drawably.Tools.DrawShapesToolRelated.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawably.UserControls.Windows.Layers
{
    public class LayerData
    {
        private Bitmap layerImage;
        public LayerData(int newWidth, int newHeight)
        {
            layerImage = new Bitmap(newWidth, newHeight);
            this.AllLayerShapes = new List<Shape>();

            using (Graphics g = Graphics.FromImage(layerImage))
            {
                g.Clear(Color.Transparent);
            }
        }

        /// <summary>
        /// Holds the Bitmap where everything is drawn
        /// </summary>
        public Bitmap LayerImage { get=>this.layerImage; }// { 
        
        /// <summary>
        /// Draws all shapes onto LayerImage and returns a brand new Bitmap
        /// </summary>
        /// <returns></returns>
        public Bitmap GetLayerImageWithAllShapesSpawnedOnTop() 
        {
            Bitmap appliedShapesBitmap = new Bitmap(this.layerImage.Width, this.layerImage.Height);

            using (Graphics g = Graphics.FromImage(appliedShapesBitmap))
            {
                // Copy everything from this.layerImage and apply it
                g.DrawImage(this.layerImage, new Point(0, 0));

                //// Draw every single shape on top always
                foreach (var shape in AllLayerShapes)
                {
                    shape.DrawShape(g);
                }
            }

            return appliedShapesBitmap;
        }

        /// <summary>
        /// Holds all shapes for the particular layer
        /// </summary>
        public List<Shape> AllLayerShapes { get; set; }
    }
}
