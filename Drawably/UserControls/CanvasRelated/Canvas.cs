using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawably.UserControls
{
    public partial class Canvas : UserControl
    {
        /// <summary>
        /// This is for the checkerboard pattern
        /// </summary>
        private Bitmap checkerboard;
        /// <summary>
        /// The size of the checkerboard cells/tiles
        /// </summary>
        private int checkerboardCellSize;
        /// <summary>
        /// This is for the actual displayed image
        /// </summary>
        private Bitmap displayedImage;

        public Canvas()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            this.checkerboardCellSize = 25;

            this.checkerboard = GenerateCheckerboard();
            this.displayedImage = new Bitmap(this.Width, this.Height);
            // TODO
            using (Graphics g = Graphics.FromImage(this.displayedImage))
            {
                g.Clear(Color.Red);
            }


            this.Invalidate();

        }

        public Bitmap DisplayedImage
        {
            get => this.displayedImage;
            set
            {
                this.displayedImage = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// Resizes the canvas to the given width and height. Also ensures the canvas is still at its center point
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public void Resize(int width, int height)
        {
            Point newLocation = new Point();
            newLocation.X = this.Location.X - (width - this.Width) / 2;
            newLocation.Y = this.Location.Y - (height - this.Height) / 2;

            this.Width = width;
            this.Height = height;

            this.Location = newLocation;

            this.Invalidate();

        }

        protected override void OnPaint(PaintEventArgs e)
        {
           // base.OnPaint(e);
            // TODO handle zoom in zoom out inside here
            // TODO when resizing the form, resize all bitmaps/ layers whatever
            // TODO handle drawing cached checkerboard
            // TODO drawing multiple bitmaps, drawing them in OnPaint only if there were any changes
            // TODO adding bitmaps that will be tracked -> should update them/ shouldn't update them -> LayerData
            // 
            // this would increase layers performance..

            checkerboard = GenerateCheckerboard();
            e.Graphics.DrawImage(checkerboard, new Rectangle(0, 0, this.Width, this.Height));
           
            if (displayedImage != null)
            {
                e.Graphics.DrawImage(displayedImage, new Rectangle(0, 0, this.Width, this.Height));
            }
        }

        public Bitmap GenerateCheckerboard()
        {
            int width = this.Width;
            int height = this.Height;

            Bitmap bitmap = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                for (int y = 0; y < height; y += checkerboardCellSize)
                {
                    for (int x = 0; x < width; x += checkerboardCellSize)
                    {
                        Color color = ((x / checkerboardCellSize) % 2 == (y / checkerboardCellSize) % 2) ? Color.White : Color.LightGray;

                        using (Brush brush = new SolidBrush(color))
                        {
                            g.FillRectangle(brush, x, y, checkerboardCellSize, checkerboardCellSize);
                        }
                    }
                }
            }

            return bitmap;
        }
    }
}
