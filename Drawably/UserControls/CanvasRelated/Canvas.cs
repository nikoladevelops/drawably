using Drawably.Utility;
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
    /// <summary>
    /// Responsible for rendering the image on screen.
    /// </summary>
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

        /// <summary>
        /// This is the region where the rendering of the layers should happen. It should always have the same width and height as the canvas itself.
        /// </summary>
        private Rectangle renderingArea;

        /// <summary>
        /// The OnPaint's custom code responsible for layer rendering will run only when this is set to true, otherwise the base behaviour will run.
        /// </summary>
        bool isReadyToRender;

        public Canvas()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            this.checkerboardCellSize = 15;
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
            isReadyToRender = true;
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

            renderingArea = new Rectangle(0, 0, width, height);

            this.Location = newLocation;

            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Only reason this if check exists is because of the designer throwing errors.
            if (isReadyToRender == false)
            {
                base.OnPaint(e);
                return;
            }

            e.Graphics.DrawImage(checkerboard, renderingArea);

            Globals.LayerRenderer.RenderAllLayers(e.Graphics, renderingArea, this.displayedImage);
        }

        /// <summary>
        /// Generates checkerboard pattern Bitmap.
        /// </summary>
        /// <returns></returns>
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
