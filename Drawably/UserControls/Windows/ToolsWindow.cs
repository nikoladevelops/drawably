using Drawably.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawably.UserControls.Windows
{
    public partial class ToolsWindow : MenuWindow
    {
        // Keeps track of each tool button and the actual tool it corresponds to
        private Dictionary<Button, IToolable> btnTools;

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

            btnTools = new Dictionary<Button, IToolable>()
            {
                { penBtn, new PenTool(canvContainer) },
                { brushBtn, new PenTool(canvContainer) }
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
                    if (selectedBtn != null) 
                    {
                        selectedBtn.BackColor = Color.Black;
                        selectedBtn.ForeColor = Color.White;
                    }

                    if (selectedBtn == kvp.Key)
                    {
                        // In case the same tool was selected, deselect it
                        selectedBtn = null;
                        canvContainer.CurrentTool = null;
                        return;
                    }

                    // Otherwise select the new tool
                    selectedBtn = kvp.Key;
                    selectedBtn.BackColor = Color.Yellow;
                    selectedBtn.ForeColor = Color.Black;
                    canvContainer.CurrentTool = kvp.Value;
                };
            }
        }

    }
}
