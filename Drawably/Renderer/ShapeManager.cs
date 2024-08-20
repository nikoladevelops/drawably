using Drawably.Tools.DrawShapesToolRelated.Shapes;
using Drawably.UserControls.Windows.Layers;
using Drawably.Utility;

namespace Drawably.Renderer
{
    /// <summary>
    /// Contains functions related to shape manipulation.
    /// </summary>
    public class ShapeManager
    {
        /// <summary>
        /// Spawns a new shape inside the currently selected layer.
        /// </summary>
        /// <param name="shapeToSpawn"></param>
        public void SpawnNewShapeInsideSelectedLayer(Shape shapeToSpawn)
        {
            LayerData selectedLayerData = Globals.LayersWindow.GetSelectedLayerData;
            selectedLayerData.AllLayerShapes.Add(shapeToSpawn);

            Globals.LayerRenderer.OnLayerChangesApplied();
        }

        /// <summary>
        /// Gets the first shape it finds on the layer at the correct position, otherwise returns null if no shape found.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public Shape? GetShapeUnderneathMousePosition(float x, float y)
        {
            List<Shape> selectedLayerShapes = Globals.LayersWindow.GetSelectedLayerData.AllLayerShapes;

            foreach (var shape in selectedLayerShapes)
            {
                if (shape.SelectionDimensions.Contains((int)x, (int)y))
                {
                    return shape;
                }
            }
            return null;
        }

        /// <summary>
        /// Delets all selected shapes from the currently selected layer.
        /// </summary>
        public void DeleteAllSelectedShapesFromCurrentSelectedLayer()
        {
            List<Shape> selectedLayerShapes = Globals.LayersWindow.GetSelectedLayerData.AllLayerShapes;

            for (int i = 0; i < selectedLayerShapes.Count; i++)
            {
                Shape currentShape = selectedLayerShapes[i];

                if (currentShape.IsSelectedInGroup)
                {
                    selectedLayerShapes.Remove(currentShape);
                    i--;
                }
            }

            Globals.LayerRenderer.OnLayerChangesApplied();
        }
    }
}
