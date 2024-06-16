using Drawably.Tools.PenToolRelated;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawably.Tools.BrushToolRelated
{
    public partial class BrushOptionsControl : UserControl
    {
        private BrushTool brushTool;
        public BrushOptionsControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Always call this constructor when setting up from code.
        /// </summary>
        /// <param name="newBrushTool"></param>
        public BrushOptionsControl(BrushTool newBrushTool):this()
        {
            this.brushTool = newBrushTool;

            PopulateBrushSizeComboBoxWithBrushSizes();

        }

        /// <summary>
        /// Populates all available brush sizes the user can select for the brush
        /// </summary>
        private void PopulateBrushSizeComboBoxWithBrushSizes() 
        {
            List<object> brushSizes = new List<object>();
            for (int i = 1; i <= 1000; i+=2)
            {
                brushSizes.Add(i);
            }
            
            this.brushSizeComboBox.Items.AddRange(brushSizes.ToArray());
            this.brushSizeComboBox.SelectedIndex = 2; // because brush size is 5 at the beginning always, a little bit hardcoded ik

            this.brushSizeComboBox.SelectedIndexChanged += BrushSizeComboBox_SelectedIndexChanged;
        
        }

        private void BrushSizeComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            this.brushTool.BrushSizeChanged((int)this.brushSizeComboBox.SelectedIndex);
        }
    }
}
