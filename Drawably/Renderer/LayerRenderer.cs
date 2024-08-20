﻿using Drawably.Tools.DrawShapesToolRelated.Shapes;
using Drawably.UserControls.Windows.Layers;
using Drawably.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawably.Renderer
{
    /// <summary>
    /// Responsible for rendering all layers.
    /// </summary>
    public class LayerRenderer
    {
        /// <summary>
        /// Draws every single bitmap on to the canvas.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="renderingArea"></param>
        public void RenderAllLayers(Graphics g, Rectangle renderingArea, Bitmap canvasDisplayedImage)
        {
            g.DrawImage(canvasDisplayedImage, renderingArea);
        }

        /// <summary>
        /// Should be called every single time some layer related changes are DONE being added - finished drawing/ finished placing something/ new layer added etc..
        /// Ensures the displayed image of the canvas is showing all layers merged with the correct Z indexes as well.
        /// Also ensures to refresh the graphics objects of the currently selected tool.
        /// </summary>
        public void OnLayerChangesApplied()
        {
            Globals.CanvasContainer.CanvasDisplayedImage = GetAllLayersMergedBitmap();
            
            if (Globals.ToolsWindow.CurrentTool != null)
            {
                Globals.ToolsWindow.CurrentTool.GetNewCanvasGraphics();
                Globals.ToolsWindow.CurrentTool.GetNewSelectedLayerGraphics();
            }
        }

        /// <summary>
        /// Merges all layers into one Bitmap.
        /// </summary>
        /// <returns>The bitmap containing all layers merged.</returns>
        private Bitmap GetAllLayersMergedBitmap()
        {
            List<Bitmap> bitmaps = new List<Bitmap>();

            foreach (LayerData data in Globals.LayersWindow.GetAllVisibleLayersData)
            {
                bitmaps.Add(data.GetLayerImageWithAllShapesSpawnedOnTop());
            }

            Bitmap mergedLayers = BitmapHelper.MergeBitmaps(
                bitmaps,
                Globals.CanvasContainer.CanvasDisplayedImage.Width,
                Globals.CanvasContainer.CanvasDisplayedImage.Height
                );


            return mergedLayers;
        }
    }
}