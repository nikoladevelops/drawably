using Drawably.Tools.DrawShapesToolRelated.Shapes;
using Drawably.UserControls.CanvasRelated;
using Drawably.UserControls.Windows;
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
    /// This menu is responsible for user input which will be used to draw a particularly selected shape
    /// </summary>
    public partial class DrawSelectedShapeMenu : MenuWindow
    {
        private Shape shapeToDraw;
        public DrawSelectedShapeMenu()
        {
            InitializeComponent();
        }

        private CanvasContainer canvasContainer;
        public DrawSelectedShapeMenu(CanvasContainer newCanvasContainer):this()
        {
            this.canvasContainer = newCanvasContainer;

            PopulateComboBoxWithNumbers(this.widthComboBox);
            PopulateComboBoxWithNumbers(this.heightComboBox);

            this.widthComboBox.SelectedIndex = 0;
            this.heightComboBox.SelectedIndex = 0;

            this.Visible = false;
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
            Shape shapeToDraw = this.shapeToDraw.CopyShape(0, 0, (int)this.widthComboBox.SelectedItem, (int)this.heightComboBox.SelectedItem);
            this.canvasContainer.SpawnNewShapeInsideSelectedLayer(shapeToDraw);
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
