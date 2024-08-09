﻿using Drawably.Tools.DrawShapesToolRelated.Shapes;
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
    /// <summary>
    /// Visualizes all available layers and also the actions that can be applied to them by the user.
    /// </summary>
    public partial class LayersWindow : MenuWindow
    {
        // Note that there should ALWAYS be a selected layer lable.
        private LayerLabel selectedLayerLabel;

        // Every single layer should contain a LayerData containing the bitmap image associated.
        private Dictionary<LayerLabel, LayerData> allLayersData = new Dictionary<LayerLabel, LayerData>();

        // TODO should be eliminated as a dependency.
        private CanvasContainer canvasContainer { get; set; }

        public LayersWindow()
        {
            InitializeComponent();
            this.MenuText = "Layers";
        }

        // Accessed by other windows but not set up from outside. Make sure you always call this, so you always get the correct selected layer bitmap.
        public Bitmap GetSelectedLayerBitmap { get => allLayersData[selectedLayerLabel].LayerImage; }
        //

        /// <summary>
        /// Ensures the window is ready to be used by the user.
        /// </summary>
        public void SetUp(CanvasContainer newCanvasContainer) 
        {
            if (newCanvasContainer == null)
            {
                MessageBox.Show("Error: Layers Window has no CanvasContainer.");
                return;
            }

            this.canvasContainer = newCanvasContainer;


            // Create the very first layer.
            CreateLayerLabel();

            // Connect necessary click events.
            ConnectBtnEvents();

            // Because we have a single layer, the delete button should be disabled by default.
            this.deleteLayerBtn.Enabled = false;

        }

        /// <summary>
        /// Enables the buttons' functionalities
        /// </summary>
        private void ConnectBtnEvents() 
        {
            this.createLayerBtn.Click += (o, e) =>
            {
                // Ensure the delete button is enabled yet again if the count of labels is more than 1 (which would always be true when executing this function, because the last layer can NEVER be deleted)
                this.deleteLayerBtn.Enabled = true;
                CreateLayerLabel();
            };

            this.deleteLayerBtn.Click += (o, e) =>
            {
                DeleteLayerLabel(this.selectedLayerLabel);

                // Disable the delete button if only a single layer was left
                if (allLayersPanel.Controls.Count == 1)
                {
                    this.deleteLayerBtn.Enabled = false;
                }
            };

            this.duplicateLayerBtn.Click += (o, e) =>
            {
                this.deleteLayerBtn.Enabled = true;
                DuplicateLayerLabel(this.selectedLayerLabel);
            };

            this.moveUpLayerBtn.Click += (o, e) =>
            {
                MoveLayerUp();
            };

            this.moveDownLayerBtn.Click += (o, e) =>
            {
                MoveLayerDown();
            };

        }
        
        private void LayersWindow_Load(object? sender, EventArgs e)
        {
        }

        /// <summary>
        /// Marks the newly selected layer. Should always be called first when a new layer label is selected
        /// </summary>
        /// <param name="newLbl"></param>
        private void MarkNewSelectedLabel(LayerLabel newLbl)
        {
            if (selectedLayerLabel != null)
            {
                selectedLayerLabel.IsLayerSelected = false;
            }

            selectedLayerLabel = newLbl;
            newLbl.IsLayerSelected = true;
        }

        /// <summary>
        /// When the user clicks with the mouse and selects a brand new layer label
        /// </summary>
        private void SelectNewLayerLabelByUserClick(LayerLabel newLbl) 
        {
            MarkNewSelectedLabel(newLbl);
            this.canvasContainer.OnNewLayerSelectedByUserClick();
        }

        /// <summary>
        /// Helper method to re-use logic that creates a label and places it exactly after the selected label
        /// </summary>
        private void PlaceNewLayerLableAfterCurrentlySelectedLayerLable(LayerLabel newLbl) 
        {
            int indexOfSelected = this.allLayersPanel.Controls.GetChildIndex(this.selectedLayerLabel);
            this.allLayersPanel.Controls.Add(newLbl);
            this.allLayersPanel.Controls.SetChildIndex(newLbl, indexOfSelected + 1);
        }

        /// <summary>
        /// Helper method to re-use logic that registers click event for the newly created layer label
        /// </summary>
        /// <param name="newLbl"></param>
        private void ConfigureNewLayerLabelClickEvent(LayerLabel newLbl) 
        {
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
                SelectNewLayerLabelByUserClick(newLbl);
            };
        }

        /// <summary>
        /// Helper method to re-use logic that registers checkbox clicked event for the newly created label.
        /// </summary>
        /// <param name="newLbl"></param>
        private void ConfigureNewLayerLabelCheckBoxEvent(LayerLabel newLbl) 
        {
            newLbl.OnCheckBoxClicked = () =>
            {
                this.canvasContainer.OnLayerChangedVisibility();
            };
        }

        /// <summary>
        /// Creates a brand new layer label. 
        /// Called when the user clicks the add new layer button. 
        /// Note that when a new layer is created it is automatically marked as selected as well.
        /// </summary>
        private void CreateLayerLabel()
        {
            LayerLabel newLbl = new LayerLabel($"Layer {allLayersPanel.Controls.Count + 1}", true, true);

            // Register select layer label click event
            ConfigureNewLayerLabelClickEvent(newLbl);

            // Register checkbox click event
            ConfigureNewLayerLabelCheckBoxEvent(newLbl);

            // Ensure the layer has a layer data and is added to the dictionary that tracks all layers
            LayerData layerData = new LayerData(this.canvasContainer.GetCanvasBitmapWidth, this.canvasContainer.GetCanvasBitmapHeight);
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
            PlaceNewLayerLableAfterCurrentlySelectedLayerLable(newLbl);

            MarkNewSelectedLabel(newLbl);

            // Ensure the Canvas container is informed about the newly created layer. Note that the canvas container should know that by creating a new layer, the new layer is being marked as selected automatically.
            this.canvasContainer.OnLayerCreated();
        }

        /// <summary>
        /// Delets a selected layer. Note that when deleting a layer label, another label will get marked automatically as the newly selected layer label
        /// </summary>
        /// <param name="lblToRemove"></param>
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
            MarkNewSelectedLabel(lblToSelectNext);

            // Delete the layer from being tracked
            this.allLayersData.Remove(lblToRemove);

            // Delete the layer label itself
            this.allLayersPanel.Controls.Remove(lblToRemove);

            // Ensure the Canvas container is informed about the user deleting a selected layer. Note that the canvas container should know that by deleting a layer, another one will be selected automatically.
            this.canvasContainer.OnLayerDeleted();
        }

        /// <summary>
        /// Duplicates a layer and places the layer label exactly after the currently selected one. Also makes the duplicated label the newly selected label
        /// </summary>
        /// <param name="lblToDuplicate"></param>
        private void DuplicateLayerLabel(LayerLabel lblToDuplicate)
        {
            LayerData lblToDuplicateData = allLayersData[lblToDuplicate];

            LayerLabel newLbl = new LayerLabel
            (
                // If already contains "- Copy" inside the name, no need to stack Copy infinitely..
                lblToDuplicate.LayerName.Contains("- Copy") ? $"{lblToDuplicate.LayerName}" : $"{lblToDuplicate.LayerName} - Copy",
                lblToDuplicate.IsLayerVisible,
                lblToDuplicate.IsLayerSelected
            );

            // Register select layer label click event
            ConfigureNewLayerLabelClickEvent(newLbl);

            // Register checkbox click event
            ConfigureNewLayerLabelCheckBoxEvent(newLbl);

            // Create brand new LayerData with the same size
            LayerData newData = new LayerData(lblToDuplicateData.LayerImage.Width, lblToDuplicateData.LayerImage.Height);

            // Draw the same image on to the new layer's bitmap
            using (Graphics g = Graphics.FromImage(newData.LayerImage))
            {
                g.DrawImage(lblToDuplicateData.LayerImage, new Point(0,0));
            }


            // Add the brand new copied layer to the dictionary of layers
            this.allLayersData.Add(newLbl, newData);

            // Always add the duplicated layer after the selected layer label
            PlaceNewLayerLableAfterCurrentlySelectedLayerLable(newLbl);

            // Mark new selected label
            MarkNewSelectedLabel(newLbl);

            // Inform the canvas container that a layer has been duplicated
            this.canvasContainer.OnLayerDuplicated();
        }

        /// <summary>
        /// Moves a layer label up. Note that this should affect Z index when merging layers
        /// </summary>
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

            // Inform the Canvas container that the selected layer was moved up
            this.canvasContainer.OnMoveLayerUp();

        }

        /// <summary>
        /// Moves layer down. Note that this should affect Z index when merging layers
        /// </summary>
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

            // Inform the Canvas container that the selected layer was moved down
            this.canvasContainer.OnMoveLayerDown();
        }

        /// <summary>
        /// Merges all layers into one Bitmap
        /// </summary>
        /// <returns>The bitmap containing all layers merged.</returns>
        public Bitmap GetAllLayersMergedBitmap()
        {
            Bitmap allLayersMerged = new Bitmap(this.canvasContainer.GetCanvasBitmapWidth, this.canvasContainer.GetCanvasBitmapHeight);

            // The Z index is automatically achieved by looping all layer labels inside the allLayersPanel, they are already ordered in the way I want them to be
            // This is done, because I used this.allLayersPanel.Controls.SetChildIndex and this.allLayersPanel.Controls.GetChildIndex to rely on ordering
            // In other words it will merge layers one after another starting from index 0 all the way to max index (last layer label), pretty cool
            foreach (LayerLabel layerLabel in this.allLayersPanel.Controls)
            {
                // Ignore merging a layer if it's marked as NOT visible
                if (layerLabel.IsLayerVisible == false)
                {
                    continue;
                }

                LayerData layerData = allLayersData[layerLabel];

                using (Graphics mergedG = Graphics.FromImage(allLayersMerged))
                {


                    mergedG.DrawImage(layerData.GetLayerImageWithAllShapesSpawnedOnTop(), new Point(0, 0));
                }
            }

            return allLayersMerged;
        }



        /// <summary>
        /// Called by the CanvasContainer whenever a new shape has to be spawned inside the currently selected layer
        /// </summary>
        /// <param name="shapeToSpawn"></param>
        public void SpawnNewShapeInsideSelectedLayer(Shape shapeToSpawn) 
        {
            LayerData selectedLayerData = this.allLayersData[selectedLayerLabel];
            selectedLayerData.AllLayerShapes.Add(shapeToSpawn);
            this.canvasContainer.OnNewShapeAddedToSelectedLayer();

        }

        /// <summary>
        /// Gets the first shape it finds on the layer at the correct position, otherwise returns null if no shape found
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public Shape? GetShapeUnderneathMousePosition(float x, float y) 
        {
            foreach (var shape in this.allLayersData[this.selectedLayerLabel].AllLayerShapes)
            {
                if (shape.SelectionDimensions.Contains((int)x, (int)y)) 
                {
                    return shape;
                }
            }
            return null;
        }

        public void DeleteAllSelectedShapesFromCurrentSelectedLayer() 
        {
            for (int i = 0; i < this.allLayersData[this.selectedLayerLabel].AllLayerShapes.Count; i++)
            {
                Shape currentShape = this.allLayersData[this.selectedLayerLabel].AllLayerShapes[i];

                if (currentShape.IsSelectedInGroup)
                {
                    this.allLayersData[this.selectedLayerLabel].AllLayerShapes.Remove(currentShape);
                    i--;
                }

            }

            this.canvasContainer.OnAllSelectedShapesDeleted();
        }


        /// <summary>
        /// Rotates every single shape bitmap plus 90 degrees (clockwise)
        /// </summary>
        public void RotateAllSelectedShapesPlus90Degrees() 
        {
            for (int i = 0; i < this.allLayersData[this.selectedLayerLabel].AllLayerShapes.Count; i++)
            {
                Shape currentShape = this.allLayersData[this.selectedLayerLabel].AllLayerShapes[i];
                
                if (currentShape.IsSelectedInGroup)
                {
                    this.allLayersData[this.selectedLayerLabel].AllLayerShapes[i].Rotation += 90;
                }
            }

            this.canvasContainer.OnShapesJustRotated();
        }

        /// <summary>
        /// Rotates every single shape bitmap minus 90 degrees (counter clockwise)
        /// </summary>
        public void RotateAllSelectedShapesMinus90Degrees() 
        {
            for (int i = 0; i < this.allLayersData[this.selectedLayerLabel].AllLayerShapes.Count; i++)
            {
                Shape currentShape = this.allLayersData[this.selectedLayerLabel].AllLayerShapes[i];

                if (currentShape.IsSelectedInGroup)
                {
                    this.allLayersData[this.selectedLayerLabel].AllLayerShapes[i].Rotation -= 90;
                }

                this.canvasContainer.OnShapesJustRotated();
            }
        }


        public List<Bitmap> GetAllLayerBitmapsInOrder() 
        {
            List<Bitmap> newList = new List<Bitmap>();

            foreach (var layerData in allLayersData.Values)
            {
                Bitmap bmp = layerData.LayerImage;
                newList.Add(bmp);
            }

            return newList;
        }


        public void LoadAllLayerBitmapsInOrder() 
        {
        }


    }
}
