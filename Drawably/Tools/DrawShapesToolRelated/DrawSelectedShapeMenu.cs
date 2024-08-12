using Drawably.Tools.DrawShapesToolRelated.Shapes;
using Drawably.UserControls.CanvasRelated;
using Drawably.UserControls.Windows;
using Drawably.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawably.Tools.DrawShapesToolRelated
{
    /// <summary>
    /// This menu is responsible for user input which will be used to draw a selected shape.
    /// </summary>
    public partial class DrawSelectedShapeMenu : MenuWindow
    {
        private Shape shapeToDraw;
        public DrawSelectedShapeMenu()
        {
            InitializeComponent();

            PopulateComboBoxWithNumbers(this.widthComboBox);
            PopulateComboBoxWithNumbers(this.heightComboBox);
            PopulateComboBoxWithNumbers(this.borderSizeComboBox);

            this.widthComboBox.SelectedIndex = 0;
            this.heightComboBox.SelectedIndex = 0;
            this.borderSizeComboBox.SelectedIndex = 0;

            this.Visible = false;
        }

        private void VerifyTypedTextExistsAsItemInComboBox(ComboBox box) 
        {
            for (int i = 0; i < box.Items.Count; i++)
            {
                if (box.GetItemText(i) == box.Text)
                {
                    // There is a weird bug where executing this method increases the index by 1 after finishing. To fix it I just subtract the index by 1 and get the correct behaviour.
                    box.SelectedIndex = i-1;
                    return;
                }
            }

            box.SelectedIndex = 0;
        }


        /// <summary>
        /// Populates combo box with numbers
        /// </summary>
        private void PopulateComboBoxWithNumbers(ComboBox comboBoxToPopulate)
        {
            List<object> brushSizes = new List<object>();
            for (int i = 1; i <= 1000; i += 1)
            {
                brushSizes.Add(i);
            }

            comboBoxToPopulate.Items.AddRange(brushSizes.ToArray());
        }

        /// <summary>
        /// When the create shape button is clicked, ensure you make a copy of the shape, populate it with the correct properties and tell the Selected layer to take care of spawning it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createShapeBtn_Click(object sender, EventArgs e)
        {
            VerifyTypedTextExistsAsItemInComboBox(this.widthComboBox);
            VerifyTypedTextExistsAsItemInComboBox(this.heightComboBox);
            VerifyTypedTextExistsAsItemInComboBox(this.borderSizeComboBox);

            Shape shapeToDraw = this.shapeToDraw.CopyShape
            (
                0,
                0,
                (int)this.widthComboBox.SelectedItem,
                (int)this.heightComboBox.SelectedItem,
                (int)this.borderSizeComboBox.SelectedItem,
                this.fillShapeCheckBox.Checked,
                Globals.ColorsWindow.LeftColor,
                Globals.ColorsWindow.RightColor
            );

            Globals.CanvasContainer.SpawnNewShapeInsideSelectedLayer(shapeToDraw);
            this.Visible = false;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        /// <summary>
        /// Should be called whenever the window is being opened (a.k.a whenever a shape button is clicked, a new shape to draw should be provided)
        /// </summary>
        /// <param name="shapeName"></param>
        public void MakeVisible(Shape newShapeToDraw) 
        {
            shapeToDraw = newShapeToDraw;
            this.Visible = true;
            this.shapeNameLabel.Text = shapeToDraw.Name;
        }
    }
}
