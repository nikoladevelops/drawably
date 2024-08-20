using Drawably.Tools;
using Drawably.Tools.DrawShapesToolRelated;
using Drawably.Tools.PenToolRelated;
using Drawably.Tools.SelectShapeToolRelated;
using Drawably.Tools.ZoomInToolRelated;
using Drawably.Tools.ZoomOutToolRelated;
using Drawably.UserControls.CanvasRelated;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawably.UserControls.Windows.Tools
{
    /// <summary>
    /// Keeps a collection of tools that the user can select and use to draw on the canvas.
    /// </summary>
    public partial class ToolsWindow : MenuWindow
    {
        /// <summary>
        /// Keeps track of each tool button and the actual tool it corresponds to.
        /// </summary>
        private Dictionary<Button, Tool> btnTools;

        /// <summary>
        /// Keeps track of the currently selected button.
        /// </summary>
        private Button? selectedBtn;

        /// <summary>
        /// Keeps track of the currently selected tool.
        /// </summary>
        public Tool? CurrentTool { get; set; }
        public ToolsWindow()
        {
            InitializeComponent();
            this.MenuText = "Tools";
        }

        /// <summary>
        /// Ensures the window is ready to be used by the user.
        /// </summary>
        public void SetUp() 
        {
            PopulateBtnTools();
            ConnectBtnEvents();
        }

        /// <summary>
        /// Ensures each tool button corresponds to the correct tool.
        /// </summary>
        private void PopulateBtnTools()
        {
            btnTools = new Dictionary<Button, Tool>()
            {
                { this.selectShapeToolBtn, new SelectShapeTool() },
                { this.penToolBtn, new PenTool() },
                { this.brushToolBtn, new BrushTool() },
                { this.drawShapesToolBtn, new DrawShapesTool() },
                { this.zoomInToolBtn, new ZoomInTool() },
                { this.zoomOutToolBtn, new ZoomOutTool() }
            };
            
        }

        /// <summary>
        /// Enables the tool buttons' functionalities.
        /// </summary>
        private void ConnectBtnEvents() 
        {
            foreach (var kvp in btnTools)
            {
                kvp.Key.Click += (o, e) =>
                {
                    if (selectedBtn == kvp.Key)
                    {
                        UnselectCurrentTool(kvp);
                        return;
                    }

                    UnselectCurrentTool(kvp);
                    SelectNewTool(kvp);
                };
            }
        }

        /// <summary>
        /// Selects a different tool button and its corresponding tool.
        /// </summary>
        /// <param name="kvp"></param>
        private void SelectNewTool(KeyValuePair<Button, Tool> kvp) 
        {
            selectedBtn = kvp.Key;
            selectedBtn.BackColor = Color.Yellow;
            selectedBtn.FlatAppearance.MouseOverBackColor = Color.Yellow;
            this.CurrentTool = kvp.Value;
            kvp.Value.OnToolSelected();
        }

        /// <summary>
        /// Unselects the current tool button and its corresponding tool.
        /// </summary>
        /// <param name="kvp"></param>
        private void UnselectCurrentTool(KeyValuePair<Button, Tool> kvp) 
        {
            // Deselect only if there is a tool to deselect
            if (selectedBtn == null) 
            {
                return;
            }

            selectedBtn.BackColor = Color.White;
            selectedBtn.FlatAppearance.MouseOverBackColor = Color.LightGray;
            this.CurrentTool.OnToolUnselected();
            selectedBtn = null;
            this.CurrentTool = null;
        }
    }
}
