﻿using Drawably.Tools;
using Drawably.Tools.DrawShapesToolRelated.Shapes;
using Drawably.UserControls.TopPanelRelated;
using Drawably.UserControls.Windows;
using Drawably.UserControls.Windows.Colors;
using Drawably.UserControls.Windows.Layers;
using Drawably.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawably.UserControls.CanvasRelated
{
    /// <summary>
    /// Holds the canvas and enables scrolling and zooming behaviour.
    /// </summary>
    public partial class CanvasContainer : UserControl
    {
        /// <summary>
        /// The mouse wheel message.
        /// </summary>
        private const int WM_MOUSEWHEEL = 0x020A;

        /// <summary>
        /// Tracks whether the CTRL is pressed.
        /// </summary>
        private bool isCtrlPressed = false;

        /// <summary>
        /// The amount by which the size of the canvas increases/decreases when zoom is applied.
        /// </summary>
        private float zoomFactor = 1.4f;

        /// <summary>
        /// The smallest the canvas can be when zoomed in.
        /// </summary>
        private Size minimumZoomSize;

        /// <summary>
        /// The biggest the canvas can be when zoomed out.
        /// </summary>
        private Size maximumZoomSize;

        /// <summary>
        /// The original size of the canvas, before zoom being applied.
        /// </summary>
        private Size originalSize;

        /// <summary>
        /// Keeps track of the correct canvas width as a floating point number.
        /// </summary>
        private float canvasWidth;

        /// <summary>
        /// Keeps track of the correct canvas height as a floating point number.
        /// </summary>
        private float canvasHeight;

        /// <summary>
        /// Caches originalSize.Width / newWidth when zooming.
        /// </summary>
        private float cacheWidthCalc;

        /// <summary>
        /// Caches originalSize.Height / newHeight when zooming.
        /// </summary>
        private float cacheHeightCalc;

        /// <summary>
        /// Retrieves the graphics object of the currently displayed image.
        /// </summary>
        public Graphics CanvasGraphics { get => Graphics.FromImage(this.canvas.DisplayedImage); }

        /// <summary>
        /// Retrieves the currently displayed image by the canvas.
        /// </summary>
        public Bitmap CanvasDisplayedImage { get => this.canvas.DisplayedImage; set => this.canvas.DisplayedImage = value; }

        public CanvasContainer()
        {
            InitializeComponent();

            AutoScroll = true;
            AutoScrollMinSize = new Size(2200, 2500);
        }

        /// <summary>
        /// Ensures the canvas container is ready to be used by the user.
        /// </summary>
        public void SetUp()
        {
            // Ensure canvas works and set its size
            canvas.SetUp(400, 280);

            // Center the canvas inside the CanvasContainer
            int centerX = (AutoScrollMinSize.Width / 2) - this.canvas.Width/2;
            int centerY = (AutoScrollMinSize.Height / 2) - this.canvas.Height/2;

            this.canvas.Location = new Point(centerX, centerY);

            // I could've made an additional property for the main form, but I feel like this is good enough. I need the form's KeyPreview to be true in order to always capture events no matter which control is focused. I'm basically using it as a global event catcher instead of playing around with the win32 API, this is easier for setting hotkeys.
            Form parentForm = FindForm();
            parentForm.KeyPreview = true;
            parentForm.KeyDown += Form_KeyDown;
            parentForm.KeyUp += Form_KeyUp;

            // Store the original size of the canvas
            originalSize = canvas.Size;

            // Set min/max zoom size
            minimumZoomSize = new Size(32, 32);
            maximumZoomSize = new Size(2500, 2500);

            canvas.MinimumSize = minimumZoomSize;
            canvas.MaximumSize = maximumZoomSize;

            // Store the canvas width and height
            canvasWidth = canvas.Width;
            canvasHeight = canvas.Height;

            // Set these cache variables to 1
            cacheWidthCalc = 1;
            cacheHeightCalc = 1;

            ConnectMouseEvents();
            ScrollToMiddle();
        }

        /// <summary>
        /// Connects all necessary mouse events.
        /// </summary>
        public void ConnectMouseEvents()
        {
            canvas.MouseMove += Canvas_MouseMove;
            canvas.MouseDown += Canvas_MouseDown;
            canvas.MouseUp += Canvas_MouseUp;
            canvas.MouseClick += Canvas_MouseClick;
        }

        /// <summary>
        /// Redraws the canvas.
        /// </summary>
        public void RedrawCanvas() 
        {
            this.canvas.Invalidate();
        }

        /// <summary>
        /// Overriding base behaviour only because there's a bug that automatically sets new incorrect scroll values when zooming in/out.
        /// </summary>
        /// <param name="activeControl"></param>
        /// <returns></returns>
        protected override Point ScrollToControl(Control activeControl)
        {
            return AutoScrollPosition;
        }

        /// <summary>
        /// Scrolls the scroll bars to the middle. Should be called after the form is fully loaded.
        /// </summary>
        public void ScrollToMiddle()
        {
            int x = Math.Max(0, (HorizontalScroll.Maximum - HorizontalScroll.LargeChange) / 2);
            int y = Math.Max(0, (VerticalScroll.Maximum - VerticalScroll.LargeChange) / 2);

            HorizontalScroll.Value = x;
            VerticalScroll.Value = y;
        }

        /// <summary>
        /// Used to track when the CTRL key has been pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                isCtrlPressed = true;
            }
        }

        /// <summary>
        /// Used to track when the CTRL key has been released.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_KeyUp(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                isCtrlPressed = false;
            }
        }

        /// <summary>
        /// Overriding the base mouse wheel behaviour while the CTRL key has been pressed (CTRL + MOUSE WHEEL = ZOOM / ONLY MOUSE WHEEL = SCROLL).
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_MOUSEWHEEL && isCtrlPressed)
            {
                // Prevent the base class from processing the mouse wheel event, this will disable the default scroll behaviour
                int delta = (int)m.WParam.ToInt64(); // Extract delta value
                if (delta > 0)
                {
                    ZoomIn();
                }
                else
                {
                    ZoomOut();
                }

                return;
            }

            base.WndProc(ref m);
        }


        /// <summary>
        /// Zooms in on the canvas (canvas gets bigger).
        /// </summary>
        public void ZoomIn()
        {
            float newWidth = canvasWidth * zoomFactor;
            float newHeight = canvasHeight * zoomFactor;

            if (newWidth > canvas.MaximumSize.Width || newHeight > canvas.MaximumSize.Height)
            {
                return;
            }

            DisplayCanvasAsZoomed(newWidth, newHeight);
        }

        /// <summary>
        /// Zooms out on the canvas (canvas gets smaller).
        /// </summary>
        public void ZoomOut()
        {
            float newWidth = canvasWidth / zoomFactor;
            float newHeight = canvasHeight / zoomFactor;

            if (newWidth < canvas.MinimumSize.Width || newHeight < canvas.MinimumSize.Height)
            {
                return;
            }

            DisplayCanvasAsZoomed(newWidth, newHeight);
        }

        /// <summary>
        /// Displays the canvas as zoomed with the new width and new height.
        /// </summary>
        /// <param name="newWidth"></param>
        /// <param name="newHeight"></param>
        private void DisplayCanvasAsZoomed(float newWidth, float newHeight)
        {
            canvasWidth = newWidth;
            canvasHeight = newHeight;

            canvas.ResizeCanvas((int)canvasWidth, (int)canvasHeight);

            // Important to cache these calculations. Having this we can calculate the offset of the mouse coordinates.
            cacheWidthCalc = originalSize.Width / newWidth;
            cacheHeightCalc = originalSize.Height / newHeight;
        }

        /// <summary>
        /// Will return only a supported mouse button type (as of now -> left mouse button and right mouse button). If another button was pressed, it will return null.
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        private MouseButtons? GetTypeOfMouseButtonFromEvent(MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                case MouseButtons.Right:
                    return e.Button;
                default:
                    // If any other button besides these, was clicked
                    return null;
            }
        }

        private void Canvas_MouseClick(object? sender, MouseEventArgs e)
        {
            if (Globals.ToolsWindow.CurrentTool == null)
            {
                return;
            }
            // Ensure no other MouseButton besides the tracked ones was pressed
            MouseButtons? typeOfButton = GetTypeOfMouseButtonFromEvent(e);
            if (typeOfButton == null)
            {
                return;
            }

            PointF mousePos = ApplyZoomOffsetToPoint(e.Location);

            if (typeOfButton == MouseButtons.Left)
            {
                Globals.ToolsWindow.CurrentTool.OnMouseLeftClick(mousePos.X, mousePos.Y);
            }
            else if (typeOfButton == MouseButtons.Right)
            {
                Globals.ToolsWindow.CurrentTool.OnMouseRightClick(mousePos.X, mousePos.Y);
            }
        }

        private void Canvas_MouseUp(object? sender, MouseEventArgs e)
        {
            if (Globals.ToolsWindow.CurrentTool == null)
            {
                return;
            }

            // Ensure no other MouseButton besides the tracked ones was pressed
            MouseButtons? typeOfButton = GetTypeOfMouseButtonFromEvent(e);
            if (typeOfButton == null)
            {
                return;
            }

            PointF mousePos = ApplyZoomOffsetToPoint(e.Location);

            if (typeOfButton == MouseButtons.Left)
            {
                Globals.ToolsWindow.CurrentTool.OnMouseLeftClickUp(mousePos.X, mousePos.Y);
            }
            else if (typeOfButton == MouseButtons.Right)
            {
                Globals.ToolsWindow.CurrentTool.OnMouseRightClickUp(mousePos.X, mousePos.Y);
            }
        }

        private void Canvas_MouseDown(object? sender, MouseEventArgs e)
        {
            if (Globals.ToolsWindow.CurrentTool == null)
            {
                return;
            }

            // Ensure no other MouseButton besides the tracked ones was pressed
            MouseButtons? typeOfButton = GetTypeOfMouseButtonFromEvent(e);
            if (typeOfButton == null)
            {
                return;
            }

            PointF mousePos = ApplyZoomOffsetToPoint(e.Location);

            if (typeOfButton == MouseButtons.Left)
            {
                Globals.ToolsWindow.CurrentTool.OnMouseLeftClickDown(mousePos.X, mousePos.Y);
            }
            else if (typeOfButton == MouseButtons.Right)
            {
                Globals.ToolsWindow.CurrentTool.OnMouseRightClickDown(mousePos.X, mousePos.Y);
            }
        }

        private void Canvas_MouseMove(object? sender, MouseEventArgs e)
        {
            if (Globals.ToolsWindow.CurrentTool == null)
            {
                return;
            }

            PointF mousePos = ApplyZoomOffsetToPoint(e.Location);
            Globals.ToolsWindow.CurrentTool.OnMouseMove(mousePos.X, mousePos.Y);
        }

        /// <summary>
        /// Applies offset so that the mouse coordinates match the bitmap coordinates (just draw where the mouse is). This offset is applied due to the zooming in/out which resizes the canvas BUT doesn't change the visualized bitmap size.
        /// </summary>
        /// <param name="mousePos"></param>
        /// <returns></returns>
        private PointF ApplyZoomOffsetToPoint(Point mousePos) 
        {
            return new PointF(mousePos.X * cacheWidthCalc, mousePos.Y * cacheHeightCalc);
        }

        /// <summary>
        /// May be called by the current tool in order to display additional options for the selected tool. The options get displayed inside the top panel.
        /// </summary>
        /// <param name="control"></param>
        public void PlaceToolControlInsideTopPanel(Control control)
        {
            Globals.TopPanel.AddToolOptionsControlToTopPanel(control);
        }

        /// <summary>
        /// Places a custom menu inside the MainForm
        /// </summary>
        public void PlaceCustomMenuToMainForm(MenuWindow customMenu)
        {
            this.ParentForm.Controls.Add(customMenu);
            customMenu.Location = new Point(150, 150);
            customMenu.BringToFront();
        }
    }
}
