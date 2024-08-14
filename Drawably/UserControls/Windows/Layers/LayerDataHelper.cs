using Drawably.Tools.DrawShapesToolRelated.Shapes;
using Drawably.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawably.UserControls.Windows.Layers
{
    /// <summary>
    /// Manages layer data.
    /// </summary>
    public class LayerDataHelper
    {
        /// <summary>
        /// Holds layer labels and their corresponding data.
        /// </summary>
        private Dictionary<LayerLabel, LayerData> allLayersData;

        public LayerDataHelper()
        {
            allLayersData = new Dictionary<LayerLabel, LayerData>();
        }

        public LayerData GetLayerData(LayerLabel lbl)
        {
            return allLayersData[lbl];
        }

        public void AddNewLayerData(LayerLabel lbl)
        {
            LayerData layerData = new LayerData(Globals.CanvasContainer.CanvasDisplayedImage.Width, Globals.CanvasContainer.CanvasDisplayedImage.Height);
            allLayersData.Add(lbl, layerData);
        }

        public void DuplicateLayerData(LayerLabel lblToDuplicateDataFrom, LayerLabel newLabelToAssociateWithDuplicatedData)
        {
            LayerData layerDataDuplicate = GetLayerData(lblToDuplicateDataFrom).DuplicateLayerData();

            // Add the copied layer to the dictionary of layers.
            allLayersData.Add(newLabelToAssociateWithDuplicatedData, layerDataDuplicate);
        }

        public void DeleteLayerData(LayerLabel lbl)
        {
            allLayersData.Remove(lbl);
        }
    }
}
