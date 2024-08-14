using Drawably.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawably.UserControls.Windows.Layers
{
    public class LayerLabelHelper
    {
        /// <summary>
        /// Tracks the currently selected label.
        /// </summary>
        public LayerLabel SelectedLayerLabel { get; set; }

        /// <summary>
        /// Holds every single generated label.
        /// </summary>
        private Panel labelContainer;

        /// <summary>
        /// Gets executed when the label has been selected by a mouse click.
        /// </summary>
        private Action onLabelSelectedByMouseClick;

        /// <summary>
        /// Gets executed when the check box of a label is clicked.
        /// </summary>
        private Action onCheckBoxClicked;

        public LayerLabelHelper(Panel newLabelContainer, Action newOnLabelSelected, Action newOnCheckBoxClicked)
        {
            this.labelContainer = newLabelContainer;
            this.onLabelSelectedByMouseClick = newOnLabelSelected;
            this.onCheckBoxClicked = newOnCheckBoxClicked;
        }

        /// <summary>
        /// Creates a brand new LayerLabel, moves it on top of the currently selected label and marks it as the newly selected one.
        /// </summary>
        /// <returns></returns>
        public LayerLabel CreateLayerLabel() 
        {
            LayerLabel lbl = GenerateLayerLabel($"Layer {labelContainer.Controls.Count + 1}", true);

            this.labelContainer.Controls.Add(lbl);
            MoveLayerLabelOnTopOfCurrentlySelectedLayerLabel(lbl);
            SelectLabel(lbl);

            return lbl;
        }

        /// <summary>
        /// Deletes an already existing label. Note that if the label is the last one, it won't delete it.
        /// </summary>
        /// <param name="lbl"></param>
        public void DeleteSelectedLabel() 
        {
            if (SelectedLayerLabel == null || this.labelContainer.Controls.Count <= 1) 
            {
                return;
            }

            int indexOfSelected = this.labelContainer.Controls.GetChildIndex(SelectedLayerLabel);

            // Select the label that is behind the currently selected one.
            int newSelectedIndex = indexOfSelected - 1;

            // In case there was no label behind the currently selected one, just select the one that is right on top of the current one.
            if (newSelectedIndex == -1)
            {
                // Because there is no previous label, this means that the currently selected label is at index 0 and that the label that is on top of it is at index 1.
                newSelectedIndex = 1;
            }

            // Cache the selected layer label that should get deleted;
            LayerLabel lblToDelete = SelectedLayerLabel;

            // Get the label that should be selected next.
            LayerLabel lblToSelectNext = (LayerLabel)this.labelContainer.Controls[newSelectedIndex];

            // Select the label.
            SelectLabel(lblToSelectNext);

            // Delete the previously selected layer label.
            labelContainer.Controls.Remove(lblToDelete);
        }

        /// <summary>
        /// Duplicates the selected layer label, moves it on top of it and marks it as the newly selected one.
        /// </summary>
        /// <returns></returns>
        public LayerLabel DuplicateSelectedLabel() 
        {
            string layerName = SelectedLayerLabel.Name;
            if (layerName.Contains("- Copy") == false) 
            {
                layerName += "- Copy";
            }

            LayerLabel lbl = GenerateLayerLabel(layerName, SelectedLayerLabel.IsLayerVisible);

            this.labelContainer.Controls.Add(lbl);
            MoveLayerLabelOnTopOfCurrentlySelectedLayerLabel(lbl);
            SelectLabel(lbl);

            return lbl;
        }

        /// <summary>
        /// Generates a LayerLabel control that has click events connected.
        /// </summary>
        /// <returns></returns>
        private LayerLabel GenerateLayerLabel(string labelName, bool isLayerVisible)
        {
            LayerLabel newLbl = new LayerLabel(labelName, isLayerVisible, false); 

            ConnectClickEvents(newLbl);
            return newLbl;
        }

        /// <summary>
        /// Connects the needed click events.
        /// </summary>
        /// <param name="lbl"></param>
        private void ConnectClickEvents(LayerLabel lbl)
        {
            lbl.OnCheckBoxClicked = () =>
            {
                onCheckBoxClicked();
            };

            lbl.Click += (o, e) =>
            {
                // There should always be a selected label. It should never get deselected.
                if (SelectedLayerLabel == lbl)
                {
                    return;
                }

                SelectLabel(lbl);
                onLabelSelectedByMouseClick();
            };
        }

        /// <summary>
        /// Deselects the previously selected label and selects this new one.
        /// </summary>
        /// <param name="newLbl">The new label to mark as selected.</param>
        private void SelectLabel(LayerLabel newLbl)
        {
            if (SelectedLayerLabel != null)
            {
                SelectedLayerLabel.IsLayerSelected = false;
            }

            newLbl.IsLayerSelected = true;
            SelectedLayerLabel = newLbl;
        }

        /// <summary>
        /// Moves layer label on top of the currently selected layer label. 
        /// Note that this happens only if there is a selected layer label already and if the selected label is not the same exact label we are trying to change the position of.
        /// </summary>
        private void MoveLayerLabelOnTopOfCurrentlySelectedLayerLabel(LayerLabel newLbl)
        {
            if (SelectedLayerLabel == null || SelectedLayerLabel == newLbl) 
            {
                return;
            }

            int indexOfSelected = this.labelContainer.Controls.GetChildIndex(this.SelectedLayerLabel);
            this.labelContainer.Controls.SetChildIndex(newLbl, indexOfSelected + 1);
        }

        /// <summary>
        /// Moves the selected layer label up.
        /// </summary>
        /// <returns>True If the selected layer label was moved up successfully.</returns>
        public bool MoveSelectedLayerLabelUp() 
        {
            int indexOfSelected = this.labelContainer.Controls.GetChildIndex(this.SelectedLayerLabel);

            // If it's the last layer you can't move it up anymore, its already at the top.
            if (indexOfSelected == this.labelContainer.Controls.Count - 1)
            {
                return false;
            }

            // Move the label up.
            this.labelContainer.Controls.SetChildIndex(this.SelectedLayerLabel, indexOfSelected + 1);

            return true;
        }
        /// <summary>
        /// Moves the selected layer label down.
        /// </summary>
        /// <returns>True If the selected layer label was moved down successfully.</returns>
        public bool MoveSelectedLayerLabelDown() 
        {
            int indexOfSelected = this.labelContainer.Controls.GetChildIndex(this.SelectedLayerLabel);

            // If it's the first layer you can't move it down anymore, its already at the bottom.
            if (indexOfSelected == 0)
            {
                return false;
            }

            // Move the label down.
            this.labelContainer.Controls.SetChildIndex(this.SelectedLayerLabel, indexOfSelected - 1);

            return true;
        }
    }
}
