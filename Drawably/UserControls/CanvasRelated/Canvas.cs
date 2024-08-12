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
        /// This is for the checkerboard pattern/
        /// </summary>
        private Bitmap checkerboard;
        /// <summary>
        /// The size of the checkerboard cells/tiles.
        /// </summary>
        private int checkerboardCellSize;
        /// <summary>
        /// This is for the actual displayed image.
        /// </summary>
        private Bitmap displayedImage = null;

        public Canvas()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            this.checkerboardCellSize = 15;

            // I only have this so that the designer doesn't throw an error when trying to paint the canvas.
            checkerboard = GenerateCheckerboard();
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
        /// Ensures the canvas is ready to be used by the user.
        /// </summary>
        public void SetUp(int width, int height) 
        {
            // Important to note that the displayed image has to have the same width/height as the canvas otherwise there will be a mismatch between the mouse coordinates of the canvas and the graphics object retrieved from the image.
            displayedImage = new Bitmap(width, height);
            ResizeCanvas(width, height);
            checkerboard = GenerateCheckerboard();
        }


        /// <summary>
        /// Resizes the canvas to the given width and height. Also ensures the canvas is still at its center point.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public void ResizeCanvas(int width, int height)
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
