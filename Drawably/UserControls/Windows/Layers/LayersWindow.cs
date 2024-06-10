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
        // Note that there should ALWAYS be a selected layer lable
        private LayerLabel selectedLayerLabel;

        public LayersWindow()
        {
            InitializeComponent();
            this.MenuText = "Layers";

            // Create the very first layer
            CreateLayerLabel();

            CreateLayerLabel();
            CreateLayerLabel();
            CreateLayerLabel();
            CreateLayerLabel();
            CreateLayerLabel();
            CreateLayerLabel();
            CreateLayerLabel();
            this.deleteLayerBtn.Enabled = true;

            this.createLayerBtn.Click += (o, e) =>
            {
                // Ensure the delete button is enabled yet again if the count of labels is more than 1 (which would always be true when executing this function, because the last layer can NEVER be deleted)
                this.deleteLayerBtn.Enabled = true;
                CreateLayerLabel();
            };

            this.deleteLayerBtn.Click += (o, e) =>
            {
                DeleteLayerLabel(selectedLayerLabel);

                // Disable the delete button if only a single layer was left
                if (allLayersPanel.Controls.Count == 1)
                {
                    this.deleteLayerBtn.Enabled = false;
                }
            };
        }

        private void SelectNewLayerLabel(LayerLabel newLbl) 
        {
            selectedLayerLabel.IsLayerSelected = false;
            selectedLayerLabel = newLbl;
            newLbl.IsLayerSelected = true;
        }

        private void CreateLayerLabel() 
        {
            LayerLabel newLbl = new LayerLabel($"layer{allLayersPanel.Controls.Count + 1}", true, true);

            // Select layer label when it's clicked
            newLbl.Click += (o, e) =>
            {
                // Basically I don't want the user to be left without a selected label/ being able to deselect all labels
                if (selectedLayerLabel == newLbl)
                {
                    return;
                }

                selectedLayerLabel.IsLayerSelected = false;

                newLbl.IsLayerSelected = true;
                selectedLayerLabel = newLbl;
            };

            // There should always be a selectedLayerLabel
            if (selectedLayerLabel == null) 
            {
                selectedLayerLabel = newLbl;
                selectedLayerLabel.IsLayerSelected = true;
                this.allLayersPanel.Controls.Add(newLbl);
                this.deleteLayerBtn.Enabled = false; // Ensure you can't delete the only layer left
                return;
            }

            // Always add the new label after the selected one
            int indexOfSelected = this.allLayersPanel.Controls.GetChildIndex(this.selectedLayerLabel);
            this.allLayersPanel.Controls.Add(newLbl);
            this.allLayersPanel.Controls.SetChildIndex(newLbl, indexOfSelected+1);

            // Also always deselect the old layer and select the new layer
            SelectNewLayerLabel(newLbl);
        }

        private void DeleteLayerLabel(LayerLabel lblToRemove) 
        {
            int indexOfSelected = this.allLayersPanel.Controls.GetChildIndex(lblToRemove);

            
            // When deleting, select the previous LayerLabel
            int newSelectedIndex = indexOfSelected - 1;
            if (newSelectedIndex == -1)
            {
                // But if there is no previous index, select the next one (which will always be index 1, because there are 2 left in this scenario)
                newSelectedIndex = 1;
            }

            // Select the appropriate LayerLabel
            LayerLabel lblToSelectNext = (LayerLabel)this.allLayersPanel.Controls[newSelectedIndex];
            SelectNewLayerLabel(lblToSelectNext);
            
            
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
