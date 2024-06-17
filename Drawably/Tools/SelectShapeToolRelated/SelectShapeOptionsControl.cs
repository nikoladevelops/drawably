using Drawably.Tools.DrawShapesToolRelated.Shapes;
using Drawably.UserControls.CanvasRelated;
using Drawably.UserControls.Windows.Layers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawably.Tools.SelectShapeToolRelated
{
    public partial class SelectShapeOptionsControl : UserControl
    {
        private List<Shape> selectedShapes;

        private CanvasContainer canvasContainer;
        public SelectShapeOptionsControl()
        {
            InitializeComponent();
        }

        public SelectShapeOptionsControl(CanvasContainer newCanvasContainer) : this()
        {
            this.canvasContainer = newCanvasContainer;
            selectedShapes = new List<Shape>();
            this.Visible = false;
        }

        public void Open()
        {
            this.Visible = true;
        }

        public void Close()
        {
            this.Visible = false;
            this.amountShapesSelectedLabel.Text = "0";
            ClearAllSelectedShapes();
        }

        private void rotatePlus90DegreesBtn_Click(object sender, EventArgs e)
        {
            // TODO shape rotation
        }

        private void rotateMinus90DegreesBtn_Click(object sender, EventArgs e)
        {
            // TODO shape rotation
        }

        public void SelectShape(Shape? shapeToSelect)
        {
            // If shape not there OR shape already selected / no need to select again
            if (shapeToSelect == null || shapeToSelect.IsSelectedInGroup)
            {
                return;
            }

            this.selectedShapes.Add(shapeToSelect);
            shapeToSelect.IsSelectedInGroup = true;
            this.amountShapesSelectedLabel.Text = this.selectedShapes.Count.ToString();
        }

        public void UnselectShape(Shape? shapeToDeselect)
        {
            // If shape not there OR shape not selected / no need to deselect again
            if (shapeToDeselect == null || shapeToDeselect.IsSelectedInGroup == false)
            {
                return;
            }

            this.selectedShapes.Remove(shapeToDeselect);
            shapeToDeselect.IsSelectedInGroup = false;
            this.amountShapesSelectedLabel.Text = this.selectedShapes.Count.ToString();
        }

        private void deleteSelectedBtn_Click(object sender, EventArgs e)
        {
            // todo delete all selected shapes
        }

        public void MoveAllSelectedShapes(float x, float y)
        {
            foreach (var shape in selectedShapes)
            {
                shape.MoveShapeByAmount(x, y);
            }
            this.canvasContainer.OnCurrentLayerShapesMoved();
        }

        private void clearAllSelectedBtn_Click(object sender, EventArgs e)
        {
            ClearAllSelectedShapes();
        }

        private void ClearAllSelectedShapes() 
        {
            foreach (var shape in selectedShapes)
            {
                shape.IsSelectedInGroup = false;
            }
            this.selectedShapes.Clear();
            this.amountShapesSelectedLabel.Text = this.selectedShapes.Count().ToString();
        }
    }
}
