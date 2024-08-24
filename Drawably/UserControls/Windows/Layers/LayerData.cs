using Drawably.Tools.DrawShapesToolRelated.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawably.UserControls.Windows.Layers
{
    /// <summary>
    /// Holds data for a layer.
    /// </summary>
    public class LayerData
    {
        private Bitmap layerImage;
        public LayerData(int newWidth, int newHeight)
        {
            layerImage = new Bitmap(newWidth, newHeight);
            AllLayerShapes = new List<Shape>();

            using (Graphics g = Graphics.FromImage(layerImage))
            {
                g.Clear(Color.Transparent);
            }
        }

        /// <summary>
        /// Holds the Bitmap where everything is drawn
        /// </summary>
        public Bitmap LayerImage { get => layerImage; set => this.layerImage = value; }

        /// <summary>
        /// Holds all shapes for the particular layer
        /// </summary>
        public List<Shape> AllLayerShapes { get; set; }

        /// <summary>
        /// Duplicates the layer data.
        /// </summary>
        /// <returns></returns>
        public LayerData DuplicateLayerData()
        {
            // Create brand new LayerData with the same size.
            LayerData duplicatedLayerData = new LayerData(LayerImage.Width, LayerImage.Height);
            duplicatedLayerData.layerImage = new Bitmap(LayerImage);

            foreach (Shape shape in AllLayerShapes)
            {
                duplicatedLayerData.AllLayerShapes.Add(shape.CopyShape((int)shape.X, (int)shape.Y, shape.Width, shape.Height, shape.BorderSize, shape.IsFilled, shape.BorderColor, shape.FillColor));
            }

            return duplicatedLayerData;
        }

        /// <summary>
        /// Draws all shapes onto LayerImage and returns a brand new Bitmap
        /// </summary>
        /// <returns></returns>
        public Bitmap GetLayerImageWithAllShapesSpawnedOnTop()
        {
            Bitmap appliedShapesBitmap = new Bitmap(layerImage.Width, layerImage.Height);

            DrawLayerDataOnBitmap(appliedShapesBitmap);

            return appliedShapesBitmap;
        }

        private void DrawLayerDataOnBitmap(Bitmap bmp) 
        {
            using (Graphics g = Graphics.FromImage(bmp))
            {
                // Copy everything from this.layerImage and apply it
                g.DrawImage(layerImage, new Point(0, 0));

                // Draw every single shape on top always
                foreach (var shape in AllLayerShapes)
                {
                    shape.DrawShape(g);
                }
            }
        }
    }
}
