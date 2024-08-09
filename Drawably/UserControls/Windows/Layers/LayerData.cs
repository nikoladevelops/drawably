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

                // Draw every single shape on top always
                foreach (var shape in AllLayerShapes)
                {
                    // If the shape has rotation, ensure you rotate it
                    if (shape.Rotation != 0)
                    {
                        Bitmap shapeBitmap = new Bitmap(this.layerImage.Width, this.layerImage.Height);
                        using (Graphics g2 = Graphics.FromImage(shapeBitmap))
                        {
                            shape.DrawShape(g2);

                            // positive rotation
                            if (shape.Rotation > 0)
                            {
                                RotateBitmapPlus90Degrees(shapeBitmap, (int)shape.Rotation / 90);
                            }
                            else // negative rotation
                            {
                                RotateBitmapMinus90Degrees(shapeBitmap, (int)shape.Rotation / 90);
                            }
                        }

                        g.DrawImage(shapeBitmap, new Point(0, 0));

                    }
                    else 
                    {
                        shape.DrawShape(g);
                    }
                }
            }

            return appliedShapesBitmap;
        }

        /// <summary>
        /// Holds all shapes for the particular layer
        /// </summary>
        public List<Shape> AllLayerShapes { get; set; }

        // Rotation

        public static Bitmap RotateBitmapPlus90Degrees(Bitmap originalBitmap, int amountOfTimesToRotate90Degrees)
        {
            amountOfTimesToRotate90Degrees = amountOfTimesToRotate90Degrees % 4; // Normalize rotations to within -3 to 3
            if (amountOfTimesToRotate90Degrees < 0) // Convert negative rotations to positive equivalent
            {
                amountOfTimesToRotate90Degrees += 4;
            }

            Bitmap rotatedBitmap = originalBitmap;
            for (int i = 0; i < amountOfTimesToRotate90Degrees; i++)
            {
                rotatedBitmap = RotateBitmapBy90Degrees(rotatedBitmap, clockwise: true);
            }

            return rotatedBitmap;
        }

        public static Bitmap RotateBitmapMinus90Degrees(Bitmap originalBitmap, int amountOfTimesToRotate90Degrees)
        {
            amountOfTimesToRotate90Degrees = amountOfTimesToRotate90Degrees % 4; // Normalize rotations to within -3 to 3
            if (amountOfTimesToRotate90Degrees < 0) // Convert negative rotations to positive equivalent
            {
                amountOfTimesToRotate90Degrees += 4;
            }

            Bitmap rotatedBitmap = originalBitmap;
            for (int i = 0; i < amountOfTimesToRotate90Degrees; i++)
            {
                rotatedBitmap = RotateBitmapBy90Degrees(rotatedBitmap, clockwise: false);
            }

            return rotatedBitmap;
        }

        private static Bitmap RotateBitmapBy90Degrees(Bitmap originalBitmap, bool clockwise)
        {
            // Create a new bitmap with swapped dimensions
            Bitmap rotatedBitmap = new Bitmap(originalBitmap.Height, originalBitmap.Width);
            using (Graphics g = Graphics.FromImage(rotatedBitmap))
            {
                // Set the rotation point to the center of the image
                g.TranslateTransform((float)originalBitmap.Width / 2, (float)originalBitmap.Height / 2);
                // Rotate the image by 90 degrees in the specified direction
                g.RotateTransform(clockwise ? 90 : -90);
                // Move the image back
                g.TranslateTransform(-(float)originalBitmap.Height / 2, -(float)originalBitmap.Width / 2);
                // Draw the original bitmap on the graphics object
                g.DrawImage(originalBitmap, new Point(0, 0));
            }
            return rotatedBitmap;
        }
    }
}
