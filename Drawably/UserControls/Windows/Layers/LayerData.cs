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

            using (Graphics g = Graphics.FromImage(layerImage))
            {
                g.Clear(Color.Transparent);
            }
        }

        public Bitmap LayerImage { get => this.layerImage; }
    }
}
