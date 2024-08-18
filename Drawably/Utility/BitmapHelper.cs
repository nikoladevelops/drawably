using Drawably.UserControls.Windows.Layers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawably.Utility
{
    public static class BitmapHelper
    {
        /// <summary>
        /// Merges all bitmaps into a single one.
        /// </summary>
        /// <returns>The merged bitmap.</returns>
        public static Bitmap MergeBitmaps(IEnumerable<Bitmap> bitmaps, int width, int height)
        {
            Bitmap mergedBitmap = new Bitmap(width, height);
            foreach (Bitmap bmp in bitmaps)
            {
                using (Graphics g = Graphics.FromImage(mergedBitmap))
                {
                    g.DrawImage(bmp, new Point(0, 0));
                }
            }

            return mergedBitmap;
        }
    }
}
