using Drawably.Tools;
using Drawably.Tools.DrawShapesToolRelated.Shapes;
using Drawably.UserControls.TopPanelRelated;
using Drawably.UserControls.Windows;
using Drawably.UserControls.Windows.Colors;
using Drawably.UserControls.Windows.Layers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawably.UserControls.CanvasRelated
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

        // Accessed by other windows, but not really set up from outside/ something like a shortcut
        public PictureBox CanvasPictureBox { get => canvas.CanvasPictureBox; }        
        public Canvas Canvas { get => canvas; }
        public Bitmap SelectedLayerBitmap { get => this.LayersWindow.GetSelectedLayerBitmap; }

        public Bitmap CanvasVisualizedImage { get => (Bitmap)this.canvas.CanvasPictureBox.Image; set => this.canvas.CanvasPictureBox.Image = value; }
        public int GetCanvasBitmapWidth { get => this.canvas.CanvasPictureBox.Image.Width; }
        public int GetCanvasBitmapHeight { get => this.canvas.CanvasPictureBox.Image.Height; }

        // Colors

        public Color CurrentLeftColor { get => this.ColorsWindow.LeftColor; }
        public Color CurrentRightColor { get => this.ColorsWindow.RightColor; }
        //

        [
           Category("All Custom Props"),
           Description("The Layers window is needed in order for everything to work correctly.")
        ]
        public LayersWindow LayersWindow { get; set; }

        [
           Category("All Custom Props"),
           Description("The Colors window is needed in order for everything to work correctly.")
        ]
        public ColorsWindow ColorsWindow { get; set; }

        [
           Category("All Custom Props"),
           Description("The TopPanel window is needed in order for everything to work correctly.")
        ]
        public TopPanel TopPanel { get; set; }

        public Tool? CurrentTool { get; set; }

        public CanvasContainer()
        {
            InitializeComponent();

            AutoScroll = true;
            AutoScrollMinSize = new Size(2200, 2500);


            CanvasPictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Important
            CanvasPictureBox.MinimumSize = minimumZoomSize;
            CanvasPictureBox.MaximumSize = maximumZoomSize;

            canvasWidth = CanvasPictureBox.Width;
            canvasHeight = CanvasPictureBox.Height;

            Bitmap bmp = new Bitmap(CanvasPictureBox.Width, CanvasPictureBox.Height);
            g = Graphics.FromImage(bmp);

            g.Clear(Color.Transparent);
            CanvasPictureBox.Image = bmp;

            HandleCreated += CanvasContainer_HandleCreated;
            
        }

        private void CanvasContainer_HandleCreated(object? sender, EventArgs e)
        {
            // I could've made an additional property for the main form, but I feel like this is good enough. I need the form's KeyPreview to be true in order to always capture events no matter which control is focused. I'm basically using it as a global event catcher instead of playing around with the win32 API, this is easier for setting hotkeys.
            Form form = FindForm();
            form.KeyPreview = true;
            form.KeyDown += Form_KeyDown;
            form.KeyUp += Form_KeyUp;


            originalSize = CanvasPictureBox.Size;

            // Connect event handlers
            CanvasPictureBox.MouseMove += Canvas_MouseMove;
            CanvasPictureBox.MouseDown += Canvas_MouseDown;
            CanvasPictureBox.MouseUp += Canvas_MouseUp;
            CanvasPictureBox.MouseClick += Canvas_MouseClick;

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
            if (CurrentTool == null)
            {
                return;
            }
            // Ensure no other MouseButton besides the tracked ones was pressed
            MouseButtons? typeOfButton = GetTypeOfMouseButtonFromEvent(e);
            if (typeOfButton == null) 
            {
                return;
            }

            Point mousePos = CanvasPictureBox.PointToClient(MousePosition);

            float newX = mousePos.X * (originalSize.Width / canvasWidth);
            float newY = mousePos.Y * (originalSize.Height / canvasHeight);

            if (typeOfButton == MouseButtons.Left)
            {
                CurrentTool.OnMouseLeftClick(newX, newY);
            }
            else if (typeOfButton == MouseButtons.Right) 
            {
                CurrentTool.OnMouseRightClick(newX, newY);
            }
        }

        private void Canvas_MouseUp(object? sender, MouseEventArgs e)
        {
            if (CurrentTool == null)
            {
                return;
            }

            // Ensure no other MouseButton besides the tracked ones was pressed
            MouseButtons? typeOfButton = GetTypeOfMouseButtonFromEvent(e);
            if (typeOfButton == null)
            {
                return;
            }

            Point mousePos = CanvasPictureBox.PointToClient(MousePosition);

            float newX = mousePos.X * (originalSize.Width / canvasWidth);
            float newY = mousePos.Y * (originalSize.Height / canvasHeight);


            if (typeOfButton == MouseButtons.Left)
            {
                CurrentTool.OnMouseLeftClickUp(newX, newY);
            }
            else if (typeOfButton == MouseButtons.Right)
            {
                CurrentTool.OnMouseRightClickUp(newX, newY);
            }
        }

        private void Canvas_MouseDown(object? sender, MouseEventArgs e)
        {
            if (CurrentTool == null)
            {
                return;
            }

            // Ensure no other MouseButton besides the tracked ones was pressed
            MouseButtons? typeOfButton = GetTypeOfMouseButtonFromEvent(e);
            if (typeOfButton == null)
            {
                return;
            }

            Point mousePos = CanvasPictureBox.PointToClient(MousePosition);

            float newX = mousePos.X * (originalSize.Width / canvasWidth);
            float newY = mousePos.Y * (originalSize.Height / canvasHeight);

            if (typeOfButton == MouseButtons.Left)
            {
                CurrentTool.OnMouseLeftClickDown(newX, newY);
            }
            else if (typeOfButton == MouseButtons.Right)
            {
                CurrentTool.OnMouseRightClickDown(newX, newY);
            }
        }

        private void Canvas_MouseMove(object? sender, EventArgs e)
        {
            if (CurrentTool == null)
            {
                return;
            }

            Point mousePos = CanvasPictureBox.PointToClient(MousePosition);

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

            canvas.Size = new Size((int)canvasWidth, (int)canvasHeight);
        }

        private void InitializeComponent()
        {
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
            int x = Math.Max(0, (HorizontalScroll.Maximum - HorizontalScroll.LargeChange) / 2);
            int y = Math.Max(0, (VerticalScroll.Maximum - VerticalScroll.LargeChange) / 2);

            HorizontalScroll.Value = x;
            VerticalScroll.Value = y;
        }

        /// <summary>
        /// Called when a new layer was selected by the user (the user clicks on a layer label, this means seletion of the layer)
        /// </summary>
        public void OnNewLayerSelectedByUserClick() 
        {
            if (this.CurrentTool != null) 
            {
                // Inform the current tool that a new layer has been selected, so it should get the newly selected layer's graphics so that it can draw on the correct layer
                this.CurrentTool.GetNewSelectedLayerGraphics();
            }
        }

        /// <summary>
        /// Called when a new layer was created by the user
        /// </summary>
        public void OnLayerCreated() 
        {
            if (this.CurrentTool != null)
            {
                // BY RULES I MADE, when a new layer is created, it will automatically be marked as selected, so I still need to tell the current tool to get the newly selected layer's graphics
                this.CurrentTool.GetNewSelectedLayerGraphics();
            }
        }

        /// <summary>
        /// Called when the selected layer was deleted
        /// </summary>
        public void OnLayerDeleted() 
        {
            // When a layer is deleted, that means I should update the visualized canvas image so some drawn elements can dissapear because they no longer exist (the layer was deleted)
            this.CanvasVisualizedImage = this.LayersWindow.GetAllLayersMergedBitmap();
            if (this.CurrentTool != null)
            {
                // Because the previous canvas image was replaced by another one (the merged layers Bitmap), I have to tell the current tool to acquire the new canvas graphics object from the newly visualized image
                this.CurrentTool.GetNewCanvasGraphics();
                // BY RULES I MADE, when a layer is deleted, it will automatically mark another layer as selected, so I still need to tell the current tool to get the newly selected layer's graphics
                this.CurrentTool.GetNewSelectedLayerGraphics();
            }
        }

        /// <summary>
        /// Called when the selected layer was duplicated
        /// </summary>
        public void OnLayerDuplicated() 
        {
            // When a layer is duplicated, that means I should update the visualized canvas image (right now it may be pointless, but in the future when adding thing such as layer opacity and other things like that, it may have an effect whether the visualized image was refreshed or not)
            this.CanvasVisualizedImage = this.LayersWindow.GetAllLayersMergedBitmap();

            if (this.CurrentTool != null)
            {
                // Because I updated the visualized image, acquire the new graphics object for that image
                this.CurrentTool.GetNewCanvasGraphics();
                // BY RULES I MADE, when a layer is duplicated, it will automatically mark the duplicated layer as selected, so I still need to tell the current tool to get the newly selected layer's graphics
                this.CurrentTool.GetNewSelectedLayerGraphics();
            }
        }

        /// <summary>
        /// Called when the selected layer was moved up
        /// </summary>
        public void OnMoveLayerUp() 
        {
            // When the selected layer is moved up, this will change the Z index, so I need to visualize that by merging all layers into a Bitmap and then giving this bitmap to the Canvas's visualized image
            this.CanvasVisualizedImage = this.LayersWindow.GetAllLayersMergedBitmap();
            if (this.CurrentTool != null)
            {
                // Because the canvas's visualized image was changed, I have to inform the tool that it needs to get a new canvas graphics so that when the user draws it can be visualized again
                // Note that I don't call GetNewSelectedLayerGraphics, because by RULES, when a layer is moved up, that doesn't deselect it, so the graphics for the selected layer is still same, only the canvas's graphics needs to change because of layer merging
                this.CurrentTool.GetNewCanvasGraphics();
            }
        }

        /// <summary>
        /// Called when the selected layer was moved down
        /// </summary>
        public void OnMoveLayerDown() 
        {
            // When the selected layer is moved down, this will change the Z index, so I need to visualize that by merging all layers into a Bitmap and then giving this bitmap to the Canvas's visualized image
            this.CanvasVisualizedImage = this.LayersWindow.GetAllLayersMergedBitmap();
            if (this.CurrentTool != null)
            {
                // Because the canvas's visualized image was changed, I have to inform the tool that it needs to get a new canvas graphics so that when the user draws it can be visualized again
                // Note that I don't call GetNewSelectedLayerGraphics, because by RULES, when a layer is moved down, that doesn't deselect it, so the graphics for the selected layer is still same, only the canvas's graphics needs to change because of layer merging
                this.CurrentTool.GetNewCanvasGraphics();
            }
        }

        /// <summary>
        /// This method should be called by the CurrentTool ALWAYS when the user has finished drawing on the canvas, so that the layers can be merged correctly and visualized to the canvas based on their Z index. In simple terms -> user always draws on top of every layer by drawing on the visualized canvas, user stops drawing on the canvas -> merge layers and display the merged bitmap so that the Z indexes are correct
        /// </summary>
        public void OnSelectedToolFinishedDrawing() 
        {
            // When user finishes drawing with the tool, I should visualize the image correctly based on the Z indexes of all layers
            this.CanvasVisualizedImage = this.LayersWindow.GetAllLayersMergedBitmap();

            if (this.CurrentTool != null)
            {
                // Again, inform the current tool that because the layers have been merged, the canvas has a brand new bitmap, so the tool has to acquire the brand new graphics object for the canvas
                // Also note that when the user finises drawing, that doesn't mean that he changed the selected layer, that means I shouldn't tell the tool to update the selected layer graphics object, it should only update the canvas graphics object
                this.CurrentTool.GetNewCanvasGraphics();
            }
        }

        /// <summary>
        ///  Called when a layer has switched visibility - visible/hidden
        /// </summary>
        public void OnLayerChangedVisibility() 
        {
            // Because a layer has been hidden/shown I need to update the visualized canvas again
            this.CanvasVisualizedImage = this.LayersWindow.GetAllLayersMergedBitmap();

            if (this.CurrentTool != null) 
            {
                // Because the visualized canvas's image changed, I need to tell the current tool to select the new graphics object
                this.CurrentTool.GetNewCanvasGraphics();

            }
        }

        /// <summary>
        /// Called when a brand new left color was selected from the colors window
        /// </summary>
        public void OnLeftColorChanged() 
        {
            if (this.CurrentTool != null) 
            {
                this.CurrentTool.OnLeftColorChangedWhileToolSelected();
            }
        }

        /// <summary>
        /// Called when a brand new right color was selected from the colors window
        /// </summary>
        public void OnRightColorChanged() 
        {
            if (this.CurrentTool != null)
            {
                this.CurrentTool.OnRightColorChangedWhileToolSelected();
            }
        }

        /// <summary>
        /// May be called by the current tool in order to display additional options for the selected tool. The options get displayed inside the top panel.
        /// </summary>
        /// <param name="control"></param>
        public void PlaceToolControlInsideTopPanel(Control control) 
        {
            if (TopPanel != null) 
            {
                TopPanel.AddToolOptionsControlToTopPanel(control);
            }
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

        /// <summary>
        /// Spawns a brand new shape inside the current selected layer. Called by the DrawSelectedShapeMenu
        /// </summary>
        /// <param name="shapeToSpawn"></param>
        public void SpawnNewShapeInsideSelectedLayer(Shape shapeToSpawn) 
        {
            this.LayersWindow.SpawnNewShapeInsideSelectedLayer(shapeToSpawn);
        }

        /// <summary>
        /// Called when a new shape was successfully added to the currently selected layer
        /// </summary>
        public void OnNewShapeAddedToSelectedLayer() 
        {
            // Because a brand new shape was added to the selected layer, I need to refresh the visualized canvas again by getting the changes (a.k.a get all layers merged yet again)
            this.CanvasVisualizedImage = this.LayersWindow.GetAllLayersMergedBitmap();

            if (this.CurrentTool != null)
            {
                // Because I updated the visualized image, acquire the new graphics object for that image
                this.CurrentTool.GetNewCanvasGraphics();
            }
        }

        /// <summary>
        /// Called by the select shape tool
        /// </summary>
        /// <returns></returns>
        public Shape? GetShapeUnderneathMousePositionOnCurrentLayer(float x, float y) 
        {
            return this.LayersWindow.GetShapeUnderneathMousePosition(x, y);
        }

        /// <summary>
        /// Called by the SelectShapeTool whenever the selected shapes are being moved
        /// </summary>
        public void OnCurrentLayerShapesMoved() 
        {
            // Because shapes were moved, update the visualized canvas
            this.CanvasVisualizedImage = this.LayersWindow.GetAllLayersMergedBitmap();

            if (this.CurrentTool != null)
            {
                // Because I updated the visualized image, acquire the new graphics object for that image
                this.CurrentTool.GetNewCanvasGraphics();

                // Update selected layer graphics
                this.CurrentTool.GetNewSelectedLayerGraphics();
            }
        }

        /// <summary>
        /// Called by select shape tool. Clears all selected shapes
        /// </summary>
        public void DeleteAllSelectedShapesFromCurrentSelectedLayer() 
        {
            this.LayersWindow.DeleteAllSelectedShapesFromCurrentSelectedLayer();
        }

        /// <summary>
        /// Called after the layers window clears all selected shapes
        /// </summary>
        public void OnAllSelectedShapesDeleted() 
        {
            // Because shapes were deleted, update the visualized canvas
            this.CanvasVisualizedImage = this.LayersWindow.GetAllLayersMergedBitmap();

            if (this.CurrentTool != null)
            {
                // Because I updated the visualized image, acquire the new graphics object for that image
                this.CurrentTool.GetNewCanvasGraphics();

                // Update selected layer graphics
                this.CurrentTool.GetNewSelectedLayerGraphics();
            }
        }


        // Rotation

        public void RotateAllSelectedShapesPlus90Degrees() 
        {
            this.LayersWindow.RotateAllSelectedShapesPlus90Degrees();
        }

        public void RotateAllSelectedShapesMinus90Degrees() 
        {
            this.LayersWindow.RotateAllSelectedShapesMinus90Degrees();
        }

        /// <summary>
        ///  After rotation of shapes
        /// </summary>
        public void OnShapesJustRotated() 
        {
            this.CanvasVisualizedImage = this.LayersWindow.GetAllLayersMergedBitmap();

            if (this.CurrentTool != null)
            {
                // Because I updated the visualized image, acquire the new graphics object for that image
                this.CurrentTool.GetNewCanvasGraphics();

                // Update selected layer graphics
                this.CurrentTool.GetNewSelectedLayerGraphics();
            }
        }

        /// <summary>
        /// Export
        /// </summary>
        /// <returns></returns>
        public Bitmap GetFinalImageToExport() 
        {
            return this.CanvasVisualizedImage;
        }
    }
}
