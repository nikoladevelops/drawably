using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawably.UserControls
{
    public class CanvasContainer : TableLayoutPanel
    {

        private const int WM_MOUSEWHEEL = 0x020A;
        private bool isCtrlClicked = false;
        private double zoomFactor = 1.1;

        private Size minimumZoomSize = new Size(32, 32);
        private Size maximumZoomSize = new Size(1508, 1508);

        private bool IsScrollEnabled = true;

        // Background color when mouse enters
        [
           Category("All Custom Props"),
           Description("This is the Canvas. It HAS TO be set in order for everything to work.")
        ]
        public PictureBox Canvas { get; set; }

        public CanvasContainer() 
        {
            this.ColumnCount = 1;
            this.RowCount = 1;

            this.AutoScroll = true;
            this.AutoScrollMinSize = new Size(2200, 2500);

            this.HandleCreated += CanvasContainer_HandleCreated;
        }

        private void CanvasContainer_HandleCreated(object? sender, EventArgs e)
        {
            if (Canvas == null)
            {
                return;
            };
            Canvas.MinimumSize = minimumZoomSize;
            Canvas.MaximumSize = maximumZoomSize;

            // I could've made an additional property for the main form, but I feel like this is good enough. I need the form's KeyPreview to be true in order to always capture events no matter which control is focused. I'm basically using it as a global event catcher instead of playing around with the win32 API, this is easier for setting hotkeys.
            Form form = this.FindForm();
            form.KeyPreview = true;
            form.KeyDown += Form_KeyDown;
            form.KeyUp += Form_KeyUp;
        }

        private void Form_KeyUp(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                isCtrlClicked = false;
                this.IsScrollEnabled = true;
            }
        }

        private void Form_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                isCtrlClicked = true;
                this.IsScrollEnabled = false;
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_MOUSEWHEEL && isCtrlClicked)
            {
                // Prevent the base class from processing the mouse wheel event, this will disable the default scroll behaviour
                int delta = (int)(m.WParam.ToInt64()); // Extract delta value
                if (delta > 0)
                {
                    this.ZoomIn();
                }
                else
                {
                    this.ZoomOut();
                }

                return;
            }

            base.WndProc(ref m);
        }

        private void ZoomIn()
        {
            int newWidth = (int)(Canvas.Width * zoomFactor);
            int newHeight = (int)(Canvas.Height * zoomFactor);

            Canvas.Width = (int)(Canvas.Width * zoomFactor);
            Canvas.Height = (int)(Canvas.Height * zoomFactor);
        }

        private void ZoomOut()
        {
            Canvas.Width = (int)(Canvas.Width / zoomFactor);
            Canvas.Height = (int)(Canvas.Height / zoomFactor);
        }
    }
}
