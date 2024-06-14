using Drawably.UserControls.CanvasRelated;
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

        // Every single layer should contain a LayerData containing the bitmap image associated
        private Dictionary<LayerLabel, LayerData> allLayersData = new Dictionary<LayerLabel, LayerData>();

        // Accessed by other windows but not set up from outside. Make sure you always call this, so you always get the correct selected layer bitmap
        public Bitmap GetSelectedLayerBitmap { get => allLayersData[selectedLayerLabel].LayerImage; }
        //

        [
           Category("All Custom Props"),
           Description("The canvas container is needed in order for everything to work correctly")
        ]
        public CanvasContainer CanvasContainer { get; set; }

        public LayersWindow()
        {
            InitializeComponent();
            this.MenuText = "Layers";

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

            this.duplicateLayerBtn.Click += (o, e) =>
            {
                MessageBox.Show("Not implemented");
            };

            this.moveUpLayerBtn.Click += (o, e) =>
            {
                MoveLayerUp();
            };

            this.moveDownLayerBtn.Click += (o, e) =>
            {
                MoveLayerDown();
            };

            this.Load += LayersWindow_Load;

        }

        private void LayersWindow_Load(object? sender, EventArgs e)
        {
            if (this.CanvasContainer == null)
            {
                MessageBox.Show("Error: Layers Window has no CanvasContainer");
                return;
            }

            // Create the very first layer
            CreateLayerLabel();

            // just testing
            //CreateLayerLabel();
            //CreateLayerLabel();
            //CreateLayerLabel();
            //CreateLayerLabel();
            //CreateLayerLabel();
            //CreateLayerLabel();
            //CreateLayerLabel();
            this.deleteLayerBtn.Enabled = true;
            //
        }

        private void SelectNewLayerLabel(LayerLabel newLbl)
        {
            if (selectedLayerLabel != null)
            {
                selectedLayerLabel.IsLayerSelected = false;
            }

            selectedLayerLabel = newLbl;
            newLbl.IsLayerSelected = true;
        }

        // Note : When creating a brand new layer, it will always be the newly selected one
        private void CreateLayerLabel()
        {
            LayerLabel newLbl = new LayerLabel($"Layer {allLayersPanel.Controls.Count + 1}", true, true);

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

            // Ensure the layer has a layer data and is added to the dictionary that tracks all layers
            LayerData layerData = new LayerData(this.CanvasContainer.GetCanvasBitmapWidth, this.CanvasContainer.GetCanvasBitmapHeight);
            allLayersData.Add(newLbl, layerData);

            // There should always be a selectedLayerLabel
            if (selectedLayerLabel == null)
            {
                selectedLayerLabel = newLbl;
                selectedLayerLabel.IsLayerSelected = true;
                this.allLayersPanel.Controls.Add(newLbl);
                return;
            }

            // Always add the new label after the selected one
            int indexOfSelected = this.allLayersPanel.Controls.GetChildIndex(this.selectedLayerLabel);
            this.allLayersPanel.Controls.Add(newLbl);
            this.allLayersPanel.Controls.SetChildIndex(newLbl, indexOfSelected + 1);

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

            // Select the appropriate new LayerLabel
            LayerLabel lblToSelectNext = (LayerLabel)this.allLayersPanel.Controls[newSelectedIndex];
            SelectNewLayerLabel(lblToSelectNext);

            // Delete the layer from being tracked
            this.allLayersData.Remove(lblToRemove);

            // Delete the layer label itself
            this.allLayersPanel.Controls.Remove(lblToRemove);

            // Ensure the canvas is informed about the layer being deleted so it can refresh the visualized canvas
            this.CanvasContainer.UpdateVisualizedCanvasToAllLayersMerged();
        }

        private void DuplicateLayerLabel(LayerLabel lblToDuplicate)
        {
            // TODO should duplicate the bitmap
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
            int indexOfSelected = this.allLayersPanel.Controls.GetChildIndex(selectedLayerLabel);

            // If it's the last layer you can't move it up anymore, its already at the top
            if (indexOfSelected == this.allLayersPanel.Controls.Count - 1)
            {
                return;
            }

            // Move the label up
            this.allLayersPanel.Controls.SetChildIndex(selectedLayerLabel, indexOfSelected + 1);

            // Ensure the canvas is refreshed due to the changes (the Z index got changed, so some things should be displayed on top, while others behind)
            this.CanvasContainer.UpdateVisualizedCanvasToAllLayersMerged();
        }

        private void MoveLayerDown()
        {
            int indexOfSelected = this.allLayersPanel.Controls.GetChildIndex(selectedLayerLabel);

            // If it's the first layer you can't move it down anymore, its already at the bottom
            if (indexOfSelected == 0)
            {
                return;
            }

            // Move the label down
            this.allLayersPanel.Controls.SetChildIndex(selectedLayerLabel, indexOfSelected - 1);

            // Ensure the canvas is refreshed due to the changes (the Z index got changed, so some things should be displayed on top, while others behind)
            this.CanvasContainer.UpdateVisualizedCanvasToAllLayersMerged();
        }

        /// <summary>
        /// Merges all layers into one Bitmap
        /// </summary>
        /// <returns>The bitmap containing all layers merged</returns>
        public Bitmap GetAllLayersMergedBitmap()
        {
            Bitmap allLayersMerged = new Bitmap(this.CanvasContainer.GetCanvasBitmapWidth, this.CanvasContainer.GetCanvasBitmapHeight);

            // TODO fix all of this 
            foreach (var kvp in allLayersData)
            {
                LayerData layerData = kvp.Value;

                using (Graphics mergedG = Graphics.FromImage(allLayersMerged))
                {
                    mergedG.DrawImage(layerData.LayerImage, new Point(0, 0));
                }

            }
            //foreach (LayerLabel layerLabel in this.allLayersPanel.Controls)
            //{
            //    //MessageBox.Show(layerLabel.GetHashCode().ToString());

            //    //foreach (var item in allLayersData)
            //    //{
            //    //    MessageBox.Show(item.GetHashCode().ToString());
            //    //}

            //    LayerData layerData = allLayersData[layerLabel];

            //    using (Graphics mergedG = Graphics.FromImage(allLayersMerged))
            //    {
            //        mergedG.DrawImage(layerData.LayerImage, new Point(0,0));
            //    }
            //}

            return allLayersMerged;
        }
    }
}
