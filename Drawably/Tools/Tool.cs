using Drawably.Tools.PenToolRelated;
using Drawably.UserControls;
using Drawably.UserControls.CanvasRelated;
using Drawably.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawably.Tools
{
    /// <summary>
    /// Each tool will draw/make changes both on the visualized canvas image Bitmap, as well as the currently selected layer's Bitmap.
    /// </summary>
    public abstract class Tool
    {
        /// <summary>
        /// Holds a reference to the canvas image's graphics object, so that the tool can draw on the canvas
        /// </summary>
        protected Graphics canvasGraphics;
        /// <summary>
        /// Holds a reference to the currently selected layer's graphics object, so that the tool can draw on the selected layer
        /// </summary>
        protected Graphics selectedLayerGraphics;
        /// <summary>
        /// Called when this tool was selected from the Tools window. Should be used to set up things that will be used throughout the life time of the tool (until it gets unselected). By default retrieves the new graphics objects
        /// </summary>
        public virtual void OnToolSelected() 
        {
            canvasGraphics = Globals.CanvasContainer.CanvasGraphics;
            selectedLayerGraphics = Graphics.FromImage(Globals.LayersWindow.GetSelectedLayerBitmap);
        }

        /// <summary>
        /// Called when this tool was unselected from the Tools window. Should be used to dispose of things the tool no longer needs. By default disposes of the current graphics objects
        /// </summary>
        public virtual void OnToolUnselected() 
        {
            canvasGraphics.Dispose();
            selectedLayerGraphics.Dispose();
        }

        /// <summary>
        /// Called every single time the mouse is moved, while this tool is selected
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public virtual void OnMouseMove(float x, float y) { }

        // For Left Mouse Click

        /// <summary>
        /// Called when the left mouse button was clicked while on the canvas (this means hold and release the mouse button -> makes a click)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public virtual void OnMouseLeftClick(float x, float y) { }

        /// <summary>
        /// Callled once when the left mouse click is held down
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public virtual void OnMouseLeftClickDown(float x, float y) { }

        /// <summary>
        /// Called once when the left mouse click was released
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public virtual void OnMouseLeftClickUp(float x, float y) { }

        //

        // For Right Mouse Click

        /// <summary>
        /// Called when the right mouse button was clicked while on the canvas (this means hold and release the mouse button -> makes a click)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public virtual void OnMouseRightClick(float x, float y) { }

        /// <summary>
        /// Callled once when the right mouse click is held down
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public virtual void OnMouseRightClickDown(float x, float y) { }

        /// <summary>
        /// Called once when the right mouse click was released
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public virtual void OnMouseRightClickUp(float x, float y) { }

        //

        // Related to other windows, so everything works as expected

        /// <summary>
        /// Gets called by the Canvas Container when it updates the canvas image Bitmap with all merged layers Bitmap. Basically we need to retrieve the new canvas graphics object, so that we can keep drawing on the visualized canvas (it has a new image Bitmap)
        /// </summary>
        public virtual void GetNewCanvasGraphics() 
        {
            if (canvasGraphics != null)
            {
                canvasGraphics.Dispose();
            }
            canvasGraphics = Globals.CanvasContainer.CanvasGraphics;
        }

        /// <summary>
        /// Gets called by the Canvas Container when a new layer is selected. Basically retrieves the new selected layer graphics object, so that we can continue drawing on the newly selected layer.
        /// </summary>
        public virtual void GetNewSelectedLayerGraphics() 
        {
            if (selectedLayerGraphics != null)
            {
                selectedLayerGraphics.Dispose();
            }
            selectedLayerGraphics = Graphics.FromImage(Globals.LayersWindow.GetSelectedLayerBitmap);
        }

        /// <summary>
        /// Call whenver the bitmap has been edited/ all edits were done. When the tool finishes drawing, tell the canvas container to apply the necessary changes (merging all layers -> telling the tool to update the graphics etc..). By default just informs the Canvas Container about the changes made.
        /// </summary>
        public virtual void OnToolFinishedDrawing() 
        {
            Globals.CanvasContainer.OnSelectedToolFinishedDrawing();
        }

        /// <summary>
        /// Called when the selected left color was changed, WHILE the tool is selected
        /// </summary>
        public virtual void OnLeftColorChangedWhileToolSelected() { }

        /// <summary>
        /// Called when the selected right color was changed, WHILE the tool is selected
        /// </summary>
        public virtual void OnRightColorChangedWhileToolSelected() { }
    }
}
