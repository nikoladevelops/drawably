using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawably.UserControls.Windows.Layers
{
    public partial class LayerLabel : UserControl
    {
        private bool isLayerSelected;

        [
            Category("All Custom Props"), 
            Description("Displays the layer's name")
        ]
        public string LayerName 
        { 
            get => this.layerNameLabel.Text; 
            set => this.layerNameLabel.Text = value; 
        }

        [
            Category("All Custom Props"),
            Description("Displays whether the layer is visible")
        ]
        public bool IsLayerVisible 
        { 
            get => this.isLayerVisibleCheckBox.Checked; 
            set => this.isLayerVisibleCheckBox.Checked = value; 
        }

        [
            Category("All Custom Props"),
            Description("Displays whether the layer is selected")
        ]
        public bool IsLayerSelected
        {
            get 
            {
                return this.isLayerSelected;
            }
            set 
            {
                if (value)
                {
                    this.BackColor = Color.FromArgb(80, 76, 152, 214);
                }
                else 
                {
                    this.BackColor = Color.Transparent;
                }
                this.isLayerSelected = value;
            }
        }

        public LayerLabel()
        {
            InitializeComponent();
        }

        public LayerLabel(string newLayerName, bool newIsLayerVisible=true, bool newIsLayerSelected=false)
        {
            InitializeComponent();

            this.LayerName = newLayerName;
            this.IsLayerVisible = newIsLayerVisible;
            this.IsLayerSelected = newIsLayerSelected;
        }
    }
}
