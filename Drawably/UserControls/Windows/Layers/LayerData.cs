using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawably.UserControls.Windows.Layers
{
    public class LayerData
    {
        private PictureBox layerPictureBox;
        public LayerData(PictureBox canvas)
        {
            this.layerPictureBox = new PictureBox();

            layerPictureBox.SizeMode = canvas.SizeMode;
            layerPictureBox.MinimumSize = canvas.MinimumSize;
            layerPictureBox.MaximumSize = canvas.MaximumSize;

            // Create a brand new empty layer, that is the same size as the canvas
            Bitmap bmp = new Bitmap(canvas.Width, canvas.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Transparent);
                this.layerPictureBox.Image = bmp;
            }

        }
        public PictureBox LayerPictureBox { get => layerPictureBox; }
    }
}
