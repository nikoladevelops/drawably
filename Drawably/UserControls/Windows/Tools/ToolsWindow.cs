using Drawably.Tools;
using Drawably.Tools.DrawShapesToolRelated;
using Drawably.Tools.PenToolRelated;
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
    public partial class ToolsWindow : MenuWindow
    {
        // Keeps track of each tool button and the actual tool it corresponds to
        private Dictionary<Button, Tool> btnTools;

        // Keeps track of the selected button
        private Button? selectedBtn;

        [
           Category("All Custom Props"),
           Description("This is the Canvas Container. It HAS TO be set in order for the tool buttons to work.")
        ]
        private CanvasContainer canvContainer;
        public ToolsWindow()
        {
            InitializeComponent();
            this.MenuText = "Tools";
        }

        public void SetUp(CanvasContainer newCanvContainer) 
        {
            this.canvContainer = newCanvContainer;
            PopulateBtnTools();
            ConnectBtnEvents();
        }

        private void PopulateBtnTools()
        {
            if (canvContainer == null) 
            {
                return;
            }

            btnTools = new Dictionary<Button, Tool>()
            {
                { this.selectShapeToolBtn, new BrushTool(canvContainer) },
                { this.moveImageToolBtn, new BrushTool(canvContainer) },
                { this.penToolBtn, new PenTool(canvContainer) },
                { this.brushToolBtn, new BrushTool(canvContainer) },
                { this.drawShapesToolBtn, new DrawShapesTool(canvContainer) },
                { this.zoomInToolBtn, new BrushTool(canvContainer) },
                { this.zoomOutToolBtn, new BrushTool(canvContainer) }
            };
            
        }

        private void ConnectBtnEvents() 
        {
            if (canvContainer == null)
            {
                return;
            }

            foreach (var kvp in btnTools)
            {
                kvp.Key.Click += (o, e) =>
                {
                    if (selectedBtn == kvp.Key)
                    {
                        DeselectCurrentTool(kvp);
                        return;
                    }

                    DeselectCurrentTool(kvp);
                    SelectNewTool(kvp);
                };
            }
        }

        private void SelectNewTool(KeyValuePair<Button, Tool> kvp) 
        {
            selectedBtn = kvp.Key;
            selectedBtn.BackColor = Color.Yellow;
            selectedBtn.FlatAppearance.MouseOverBackColor = Color.Yellow;
            kvp.Value.OnToolSelected();
            canvContainer.CurrentTool = kvp.Value;
        }

        private void DeselectCurrentTool(KeyValuePair<Button, Tool> kvp) 
        {
            // Deselect only if there is a tool to deselect
            if (selectedBtn == null) 
            {
                return;
            }

            selectedBtn.BackColor = Color.White;
            selectedBtn.FlatAppearance.MouseOverBackColor = Color.LightGray;
            canvContainer.CurrentTool.OnToolUnselected();
            selectedBtn = null;
            canvContainer.CurrentTool = null;
        }

    }
}
