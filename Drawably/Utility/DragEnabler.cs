using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawably.Utility
{
    public static class DragEnabler
    {
        private static bool isDragging = false;
        private static Point lastMouseLocation;

        // TKey is controlToTouch, TValue is controlToDrag
        private static Dictionary<Control, Control> draggableControls = new Dictionary<Control, Control>();
        /// <summary>
        /// Enables dragging for a control. 
        /// The control to drag is controlToDrag, while the control that you need to hold with 
        /// your left mouse click in order for controlToDrag to be dragged is called controlToTouch
        /// </summary>
        /// <param name="controlToDrag">The control that gets dragged</param>
        /// <param name="controlToTouch">The control over which you hold the left mouse clicked
        /// By default if you don't set it to anything, the controlToDrag will be the one that has to be touched, in order for dragging to occur</param>
        public static void EnableDrag(this Control controlToDrag, Control? controlToTouch = null) 
        {
            if (controlToTouch == null) 
            {
                controlToTouch = controlToDrag;
            }

            // Check if dragging is already enabled
            if (draggableControls.ContainsKey(controlToTouch)) 
            {
                return;
            }

            controlToTouch.MouseDown += ControlToTouch_MouseDown;
            controlToTouch.MouseUp += ControlToTouch_MouseUp;
            controlToTouch.MouseMove += ControlToTouch_MouseMove;

            draggableControls.Add(controlToTouch, controlToDrag);
        }

        /// <summary>
        /// When the mouse hovers the controlToTouch and the left mouse button is held pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void ControlToTouch_MouseDown(object? sender, MouseEventArgs e)
        {
            lastMouseLocation = e.Location;
            isDragging = true;
            draggableControls[(Control)sender].BringToFront();

        }
        /// <summary>
        /// When the mouse hovers the controlToTouch and the left mouse stops being held pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void ControlToTouch_MouseUp(object? sender, MouseEventArgs e)
        {
            isDragging = false;
        }
        /// <summary>
        /// When the mouse is being moved, while it hovers controlToTouch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void ControlToTouch_MouseMove(object? sender, MouseEventArgs e)
        {
            if (!isDragging) 
            {
                return;
            }
            int offsetX = e.Location.X - lastMouseLocation.X;
            int offsetY = e.Y - lastMouseLocation.Y;

            Control currentlyDraggedControl = draggableControls[(Control)sender];
            Point newDraggedControlLocation = new Point(currentlyDraggedControl.Location.X + offsetX, currentlyDraggedControl.Location.Y + offsetY);
            currentlyDraggedControl.Location = newDraggedControlLocation;
        }
    }
}
