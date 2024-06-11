﻿using Drawably.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawably.UserControls
{
    public class CanvasContainer : UserControl
    {
        private const int WM_MOUSEWHEEL = 0x020A;
        private bool isCtrlClicked = false;

        private float zoomFactor = 1.4f;

        private Size minimumZoomSize = new Size(32, 32);
        private Size maximumZoomSize = new Size(1508, 1508);

        private Size originalSize;

        // It's important to keep separate variables of type double for the width and height of the canvas. This is because when doing operations such as multiplication or division with a real number we get another real number. If I would've used the Canvas.Width and Canvas.Height to store the result of the operations, I would have data loss which brings bugs (it would work perfectly with int numbers but not so well with numbers such as 1.3 1.5 and so on..).
        private float canvasWidth;
        private float canvasHeight;

        private TableLayoutPanel tableLayoutPanel;
        private Canvas canvas;

        public Graphics g;

        [
           Category("All Custom Props"),
           Description("This is the Canvas, where drawing happens")
        ]
        public PictureBox CanvasPictureBox { get => this.canvas.CanvasPictureBox; }

        public IToolable? CurrentTool { get; set; }

        public CanvasContainer()
        {
            this.InitializeComponent();

            this.AutoScroll = true;
            this.AutoScrollMinSize = new Size(2200, 2500);

            this.HandleCreated += CanvasContainer_HandleCreated;
        }

        private void CanvasContainer_HandleCreated(object? sender, EventArgs e)
        {
            CanvasPictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Important
            CanvasPictureBox.MinimumSize = minimumZoomSize;
            CanvasPictureBox.MaximumSize = maximumZoomSize;

            canvasWidth = CanvasPictureBox.Width;
            canvasHeight = CanvasPictureBox.Height;

            // I could've made an additional property for the main form, but I feel like this is good enough. I need the form's KeyPreview to be true in order to always capture events no matter which control is focused. I'm basically using it as a global event catcher instead of playing around with the win32 API, this is easier for setting hotkeys.
            Form form = this.FindForm();
            form.KeyPreview = true;
            form.KeyDown += Form_KeyDown;
            form.KeyUp += Form_KeyUp;


            Bitmap bmp = new Bitmap(this.CanvasPictureBox.Width, this.CanvasPictureBox.Height);
            g = Graphics.FromImage(bmp);

            g.Clear(Color.Transparent);
            this.CanvasPictureBox.Image = bmp;


            //this.CurrentTool = new PenTool(g, this.Canvas);
            originalSize = this.CanvasPictureBox.Size;

            // Connect event handlers
            this.CanvasPictureBox.MouseMove += Canvas_MouseMove;
            this.CanvasPictureBox.MouseDown += Canvas_MouseDown;
            this.CanvasPictureBox.MouseUp += Canvas_MouseUp;
            this.CanvasPictureBox.MouseClick += Canvas_MouseClick;

        }

        private void Canvas_MouseClick(object? sender, MouseEventArgs e)
        {
            if (CurrentTool == null)
            {
                return;
            }

            Point mousePos = this.CanvasPictureBox.PointToClient(Control.MousePosition);

            float newX = mousePos.X * (originalSize.Width / canvasWidth);
            float newY = mousePos.Y * (originalSize.Height / canvasHeight);

            CurrentTool.OnMouseLeftClick(newX, newY);
        }

        private void Canvas_MouseUp(object? sender, MouseEventArgs e)
        {
            if (CurrentTool == null)
            {
                return;
            }

            Point mousePos = this.CanvasPictureBox.PointToClient(Control.MousePosition);

            float newX = mousePos.X * (originalSize.Width / canvasWidth);
            float newY = mousePos.Y * (originalSize.Height / canvasHeight);

            CurrentTool.OnMouseUp(newX, newY);
        }

        private void Canvas_MouseDown(object? sender, MouseEventArgs e)
        {
            if (CurrentTool == null)
            {
                return;
            }

            Point mousePos = this.CanvasPictureBox.PointToClient(Control.MousePosition);

            float newX = mousePos.X * (originalSize.Width / canvasWidth);
            float newY = mousePos.Y * (originalSize.Height / canvasHeight);

            CurrentTool.OnMouseDown(newX, newY);
        }

        private void Canvas_MouseMove(object? sender, EventArgs e)
        {
            if (CurrentTool == null)
            {
                return;
            }

            Point mousePos = this.CanvasPictureBox.PointToClient(Control.MousePosition);

            float newX = mousePos.X * (originalSize.Width / canvasWidth);
            float newY = mousePos.Y * (originalSize.Height / canvasHeight);

            CurrentTool.OnMouseMove(newX, newY);
        }

        private void Form_KeyUp(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                isCtrlClicked = false;
            }
        }

        private void Form_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                isCtrlClicked = true;
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

        // When scrolling up
        private void ZoomIn()
        {
            float newWidth = canvasWidth * zoomFactor;
            float newHeight = canvasHeight * zoomFactor;

            if (newWidth > CanvasPictureBox.MaximumSize.Width || newHeight > CanvasPictureBox.MaximumSize.Height)
            {
                return;
            }

            SetNewCanvasSize(newWidth, newHeight);
        }

        // When scrolling down
        private void ZoomOut()
        {
            float newWidth = canvasWidth / zoomFactor;
            float newHeight = canvasHeight / zoomFactor;

            if (newWidth < CanvasPictureBox.MinimumSize.Width || newHeight < CanvasPictureBox.MinimumSize.Height)
            {
                return;
            }

            SetNewCanvasSize(newWidth, newHeight);
        }

        private void SetNewCanvasSize(float newCanvasWidth, float newCanvasHeight)
        {
            canvasWidth = newCanvasWidth;
            canvasHeight = newCanvasHeight;

            this.canvas.Size = new Size((int)canvasWidth, (int)canvasHeight);
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(CanvasContainer));
            tableLayoutPanel = new TableLayoutPanel();
            canvas = new Canvas();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.BackColor = Color.Transparent;
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(canvas, 0, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Size = new Size(623, 418);
            tableLayoutPanel.TabIndex = 0;
            // 
            // canvas
            // 
            canvas.Anchor = AnchorStyles.None;
            canvas.BackColor = Color.Transparent;
            canvas.BackgroundImage = (Image)resources.GetObject("canvas.BackgroundImage");
            canvas.Location = new Point(87, 95);
            canvas.Name = "canvas";
            canvas.Size = new Size(449, 227);
            canvas.TabIndex = 0;
            // 
            // CanvasContainer
            // 
            BackColor = Color.DarkGray;
            Controls.Add(tableLayoutPanel);
            Name = "CanvasContainer";
            Size = new Size(623, 418);
            tableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        /// <summary>
        /// Scrolls the scroll bars to the middle. Should be called after the form is fully loaded
        /// </summary>
        public void ScrollToMiddle()
        {
            int x = Math.Max(0, (this.HorizontalScroll.Maximum - this.HorizontalScroll.LargeChange) / 2);
            int y = Math.Max(0, (this.VerticalScroll.Maximum - this.VerticalScroll.LargeChange) / 2);

            this.HorizontalScroll.Value = x;
            this.VerticalScroll.Value = y;
        }
    }
}
