using Drawably.Renderer;
using Drawably.UserControls.CanvasRelated;
using Drawably.UserControls.TopPanelRelated;
using Drawably.UserControls.Windows.Colors;
using Drawably.UserControls.Windows.Layers;
using Drawably.UserControls.Windows.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Drawably.Utility
{
    /// <summary>
    /// Contains classes that can be accessed by any other class. Something like a singleton holder.
    /// </summary>
    public static class Globals
    {
        public static MainForm MainForm { get; set; }
        public static CanvasContainer CanvasContainer { get; private set; }

        public static LayersWindow LayersWindow { get; private set; }

        public static ColorsWindow ColorsWindow { get; private set; }

        public static ToolsWindow ToolsWindow { get; private set; }

        public static TopPanel TopPanel { get; private set; }

        public static LayerRenderer LayerRenderer { get; private set; }

        public static ShapeManager ShapeManager { get; private set; } 

        public static void SetUp(
            MainForm mainForm,
            CanvasContainer newCanvasContainer,
            LayersWindow newLayersWindow,
            ColorsWindow newColorsWindow,
            ToolsWindow newToolsWindow,
            TopPanel newTopPanel,
            LayerRenderer newLayerRenderer,
            ShapeManager newShapeManager
            ) 
        {
            MainForm = mainForm;
            CanvasContainer = newCanvasContainer;
            LayersWindow = newLayersWindow;
            ColorsWindow = newColorsWindow;
            ToolsWindow = newToolsWindow;
            TopPanel = newTopPanel;
            LayerRenderer = newLayerRenderer;
            ShapeManager = newShapeManager;
        }
    }
}
