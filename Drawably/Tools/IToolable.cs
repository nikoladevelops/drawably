using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawably.Tools
{
    public interface IToolable
    {
        /// <summary>
        /// Called when this tool was selected from the Tools window. Should be used to set up things that will be used throughout the life time of the tool (until it gets unselected)
        /// </summary>
        void OnToolSelected();
        /// <summary>
        /// Called when this tool was unselected from the Tools window. Should be used to dispose of things the tool no longer needs.
        /// </summary>
        void OnToolUnselected();

        /// <summary>
        /// Called every single time the mouse is moved, while this tool is selected
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        void OnMouseMove(float x, float y);


        // For Left Mouse Click

        /// <summary>
        /// Called when the left mouse button was clicked while on the canvas (this means hold and release the mouse button -> makes a click)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        void OnMouseLeftClick(float x, float y);
        /// <summary>
        /// Callled once when the left mouse click is held down
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        void OnMouseLeftClickDown(float x, float y);
        /// <summary>
        /// Called once when the left mouse click was released
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        void OnMouseLeftClickUp(float x, float y);
        //

        // For Right Mouse Click

        /// <summary>
        /// Called when the right mouse button was clicked while on the canvas (this means hold and release the mouse button -> makes a click)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        void OnMouseRightClick(float x, float y);
        /// <summary>
        /// Callled once when the right mouse click is held down
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        void OnMouseRightClickDown(float x, float y);
        /// <summary>
        /// Called once when the right mouse click was released
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        void OnMouseRightClickUp(float x, float y);
        //

        // Related to other windows, so everything works as expected
        void GetNewCanvasGraphics();

        void GetNewSelectedLayerGraphics();

        void OnToolFinishedDrawing();

        void OnChangedLeftColor();
        void OnChangedRightColor();

    }
}
