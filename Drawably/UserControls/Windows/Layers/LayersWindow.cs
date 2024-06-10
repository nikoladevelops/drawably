using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawably.UserControls.Windows.Layers
{
    public partial class LayersWindow : MenuWindow
    {
        public LayersWindow()
        {
            InitializeComponent();
            this.MenuText = "Layers";

            // Add the very first layer
            LayerLabel newLbl = new LayerLabel("layer1", true, true);
           
            this.allLayersPanel.Controls.Add(newLbl);

            CreateLayerLabel();
        }

        private void CreateLayerLabel() 
        {
            LayerLabel newLbl = new LayerLabel($"layer{allLayersPanel.Controls.Count + 1}", true, false);
            this.allLayersPanel.Controls.Add(newLbl);
        }

        private void DeleteLayerLabel(LayerLabel lblToRemove) 
        {
            // Can't delete the last layer
            if (allLayersPanel.Controls.Count == 1) 
            {
                return;
            }

            this.allLayersPanel.Controls.Remove(lblToRemove);
        }

        private void DuplicateLayerLabel(LayerLabel lblToDuplicate) 
        {
            LayerLabel newLbl = new LayerLabel
            (
                lblToDuplicate.LayerName,
                lblToDuplicate.IsLayerVisible,
                lblToDuplicate.IsLayerSelected
            );

            this.allLayersPanel.Controls.Add(newLbl);
        }

        private void MoveLayerUp()
        {

        }

        private void MoveLayerDown() 
        {

        }
    }
}
