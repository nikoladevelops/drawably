using Drawably.Tools;
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
        /// Updates the canvas.
        /// </summary>
        public void RefreshCanvas() 
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
        /// Called when a new layer was selected by the user (the user clicks on a layer label, this means seletion of the layer)
        /// </summary>
        public void OnNewLayerSelectedByUserClick()
        {
            if (Globals.ToolsWindow.CurrentTool != null)
            {
                // Inform the current tool that a new layer has been selected, so it should get the newly selected layer's graphics so that it can draw on the correct layer
                Globals.ToolsWindow.CurrentTool.GetNewSelectedLayerGraphics();
            }
        }

        /// <summary>
        /// Called when a new layer was created by the user
        /// </summary>
        public void OnLayerCreated()
        {
            if (Globals.ToolsWindow.CurrentTool != null)
            {
                // BY RULES I MADE, when a new layer is created, it will automatically be marked as selected, so I still need to tell the current tool to get the newly selected layer's graphics
                Globals.ToolsWindow.CurrentTool.GetNewSelectedLayerGraphics();
            }
        }

        /// <summary>
        /// Called when the selected layer was deleted
        /// </summary>
        public void OnLayerDeleted()
        {
            // When a layer is deleted, that means I should update the visualized canvas image so some drawn elements can dissapear because they no longer exist (the layer was deleted)
            this.CanvasDisplayedImage = Globals.LayersWindow.GetAllLayersMergedBitmap();
            if (Globals.ToolsWindow.CurrentTool != null)
            {
                // Because the previous canvas image was replaced by another one (the merged layers Bitmap), I have to tell the current tool to acquire the new canvas graphics object from the newly visualized image
                Globals.ToolsWindow.CurrentTool.GetNewCanvasGraphics();
                // BY RULES I MADE, when a layer is deleted, it will automatically mark another layer as selected, so I still need to tell the current tool to get the newly selected layer's graphics
                Globals.ToolsWindow.CurrentTool.GetNewSelectedLayerGraphics();
            }
        }

        /// <summary>
        /// Called when the selected layer was duplicated
        /// </summary>
        public void OnLayerDuplicated()
        {
            // When a layer is duplicated, that means I should update the visualized canvas image (right now it may be pointless, but in the future when adding thing such as layer opacity and other things like that, it may have an effect whether the visualized image was refreshed or not)
            this.CanvasDisplayedImage = Globals.LayersWindow.GetAllLayersMergedBitmap();

            if (Globals.ToolsWindow.CurrentTool != null)
            {
                // Because I updated the visualized image, acquire the new graphics object for that image
                Globals.ToolsWindow.CurrentTool.GetNewCanvasGraphics();
                // BY RULES I MADE, when a layer is duplicated, it will automatically mark the duplicated layer as selected, so I still need to tell the current tool to get the newly selected layer's graphics
                Globals.ToolsWindow.CurrentTool.GetNewSelectedLayerGraphics();
            }
        }

        /// <summary>
        /// Called when the selected layer was moved up
        /// </summary>
        public void OnMoveLayerUp()
        {
            // When the selected layer is moved up, this will change the Z index, so I need to visualize that by merging all layers into a Bitmap and then giving this bitmap to the Canvas's visualized image
            this.CanvasDisplayedImage = Globals.LayersWindow.GetAllLayersMergedBitmap();
            if (Globals.ToolsWindow.CurrentTool != null)
            {
                // Because the canvas's visualized image was changed, I have to inform the tool that it needs to get a new canvas graphics so that when the user draws it can be visualized again
                // Note that I don't call GetNewSelectedLayerGraphics, because by RULES, when a layer is moved up, that doesn't deselect it, so the graphics for the selected layer is still same, only the canvas's graphics needs to change because of layer merging
                Globals.ToolsWindow.CurrentTool.GetNewCanvasGraphics();
            }
        }

        /// <summary>
        /// Called when the selected layer was moved down
        /// </summary>
        public void OnMoveLayerDown()
        {
            // When the selected layer is moved down, this will change the Z index, so I need to visualize that by merging all layers into a Bitmap and then giving this bitmap to the Canvas's visualized image
            this.CanvasDisplayedImage = Globals.LayersWindow.GetAllLayersMergedBitmap();
            if (Globals.ToolsWindow.CurrentTool != null)
            {
                // Because the canvas's visualized image was changed, I have to inform the tool that it needs to get a new canvas graphics so that when the user draws it can be visualized again
                // Note that I don't call GetNewSelectedLayerGraphics, because by RULES, when a layer is moved down, that doesn't deselect it, so the graphics for the selected layer is still same, only the canvas's graphics needs to change because of layer merging
                Globals.ToolsWindow.CurrentTool.GetNewCanvasGraphics();
            }
        }

        /// <summary>
        /// This method should be called by the CurrentTool ALWAYS when the user has finished drawing on the canvas, so that the layers can be merged correctly and visualized to the canvas based on their Z index. In simple terms -> user always draws on top of every layer by drawing on the visualized canvas, user stops drawing on the canvas -> merge layers and display the merged bitmap so that the Z indexes are correct
        /// </summary>
        public void OnSelectedToolFinishedDrawing()
        {
            // When user finishes drawing with the tool, I should visualize the image correctly based on the Z indexes of all layers
            this.CanvasDisplayedImage = Globals.LayersWindow.GetAllLayersMergedBitmap();

            if (Globals.ToolsWindow.CurrentTool != null)
            {
                // Again, inform the current tool that because the layers have been merged, the canvas has a brand new bitmap, so the tool has to acquire the brand new graphics object for the canvas
                // Also note that when the user finises drawing, that doesn't mean that he changed the selected layer, that means I shouldn't tell the tool to update the selected layer graphics object, it should only update the canvas graphics object
                Globals.ToolsWindow.CurrentTool.GetNewCanvasGraphics();
            }
        }

        /// <summary>
        ///  Called when a layer has switched visibility - visible/hidden
        /// </summary>
        public void OnLayerChangedVisibility()
        {
            // Because a layer has been hidden/shown I need to update the visualized canvas again
            this.CanvasDisplayedImage = Globals.LayersWindow.GetAllLayersMergedBitmap();

            if (Globals.ToolsWindow.CurrentTool != null)
            {
                // Because the visualized canvas's image changed, I need to tell the current tool to select the new graphics object
                Globals.ToolsWindow.CurrentTool.GetNewCanvasGraphics();

            }
        }

        /// <summary>
        /// Called when a brand new left color was selected from the colors window
        /// </summary>
        public void OnLeftColorChanged()
        {
            if (Globals.ToolsWindow.CurrentTool != null)
            {
                Globals.ToolsWindow.CurrentTool.OnLeftColorChangedWhileToolSelected();
            }
        }

        /// <summary>
        /// Called when a brand new right color was selected from the colors window
        /// </summary>
        public void OnRightColorChanged()
        {
            if (Globals.ToolsWindow.CurrentTool != null)
            {
                Globals.ToolsWindow.CurrentTool.OnRightColorChangedWhileToolSelected();
            }
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

        /// <summary>
        /// Spawns a brand new shape inside the current selected layer. Called by the DrawSelectedShapeMenu
        /// </summary>
        /// <param name="shapeToSpawn"></param>
        public void SpawnNewShapeInsideSelectedLayer(Shape shapeToSpawn)
        {
            Globals.LayersWindow.SpawnNewShapeInsideSelectedLayer(shapeToSpawn);
        }

        /// <summary>
        /// Called when a new shape was successfully added to the currently selected layer
        /// </summary>
        public void OnNewShapeAddedToSelectedLayer()
        {
            // Because a brand new shape was added to the selected layer, I need to refresh the visualized canvas again by getting the changes (a.k.a get all layers merged yet again)
            this.CanvasDisplayedImage = Globals.LayersWindow.GetAllLayersMergedBitmap();

            if (Globals.ToolsWindow.CurrentTool != null)
            {
                // Because I updated the visualized image, acquire the new graphics object for that image
                Globals.ToolsWindow.CurrentTool.GetNewCanvasGraphics();
            }
        }

        /// <summary>
        /// Called by the select shape tool
        /// </summary>
        /// <returns></returns>
        public Shape? GetShapeUnderneathMousePositionOnCurrentLayer(float x, float y)
        {
            return Globals.LayersWindow.GetShapeUnderneathMousePosition(x, y);
        }

        /// <summary>
        /// Called by the SelectShapeTool whenever the selected shapes are being moved
        /// </summary>
        public void OnCurrentLayerShapesMoved()
        {
            // Because shapes were moved, update the visualized canvas
            this.CanvasDisplayedImage = Globals.LayersWindow.GetAllLayersMergedBitmap();

            if (Globals.ToolsWindow.CurrentTool != null)
            {
                // Because I updated the visualized image, acquire the new graphics object for that image
                Globals.ToolsWindow.CurrentTool.GetNewCanvasGraphics();

                // Update selected layer graphics
                Globals.ToolsWindow.CurrentTool.GetNewSelectedLayerGraphics();
            }
        }

        /// <summary>
        /// Called by select shape tool. Clears all selected shapes
        /// </summary>
        public void DeleteAllSelectedShapesFromCurrentSelectedLayer()
        {
            Globals.LayersWindow.DeleteAllSelectedShapesFromCurrentSelectedLayer();
        }

        /// <summary>
        /// Called after the layers window clears all selected shapes
        /// </summary>
        public void OnAllSelectedShapesDeleted()
        {
            // Because shapes were deleted, update the visualized canvas
            this.CanvasDisplayedImage = Globals.LayersWindow.GetAllLayersMergedBitmap();

            if (Globals.ToolsWindow.CurrentTool != null)
            {
                // Because I updated the visualized image, acquire the new graphics object for that image
                Globals.ToolsWindow.CurrentTool.GetNewCanvasGraphics();

                // Update selected layer graphics
                Globals.ToolsWindow.CurrentTool.GetNewSelectedLayerGraphics();
            }
        }


        // Rotation

        public void RotateAllSelectedShapesPlus90Degrees()
        {
            Globals.LayersWindow.RotateAllSelectedShapesPlus90Degrees();
        }

        public void RotateAllSelectedShapesMinus90Degrees()
        {
            Globals.LayersWindow.RotateAllSelectedShapesMinus90Degrees();
        }

        /// <summary>
        ///  After rotation of shapes
        /// </summary>
        public void OnShapesJustRotated()
        {
            this.CanvasDisplayedImage = Globals.LayersWindow.GetAllLayersMergedBitmap();

            if (Globals.ToolsWindow.CurrentTool != null)
            {
                // Because I updated the visualized image, acquire the new graphics object for that image
                Globals.ToolsWindow.CurrentTool.GetNewCanvasGraphics();

                // Update selected layer graphics
                Globals.ToolsWindow.CurrentTool.GetNewSelectedLayerGraphics();
            }
        }

        /// <summary>
        /// Export
        /// </summary>
        /// <returns></returns>
        public Bitmap GetFinalImageToExport()
        {
            return this.CanvasDisplayedImage;
        }


        public List<Bitmap> GetAllLayerBitmapsInOrder()
        {
            return Globals.LayersWindow.GetAllLayerBitmapsInOrder();
        }

        public void LoadAllLayerBitmapsInOrder(List<Bitmap> allBitmapsToLoad)
        {
            Globals.LayersWindow.LoadAllLayerBitmapsInOrder();
        }

    }
}
