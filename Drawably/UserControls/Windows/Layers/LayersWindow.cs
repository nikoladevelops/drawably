using Drawably.Tools.DrawShapesToolRelated.Shapes;
using Drawably.UserControls.CanvasRelated;
using Drawably.Utility;
using System.Collections.ObjectModel;

namespace Drawably.UserControls.Windows.Layers
{
    /// <summary>
    /// Visualizes all available layers and also the actions that can be applied to them by the user.
    /// </summary>
    public partial class LayersWindow : MenuWindow
    {
        private LayerLabelHelper labelHelper;
        private LayerDataHelper layerDataHelper;

        public LayersWindow()
        {
            InitializeComponent();
            this.MenuText = "Layers";
            this.labelHelper = new LayerLabelHelper(this.allLayersPanel, this.OnLayerLabelSelected, this.OnLayerLabelCheckBoxClicked);
            this.layerDataHelper = new LayerDataHelper();
        }

        /// <summary>
        /// Retrieve the selected layer's bitmap.
        /// </summary>
        public Bitmap GetSelectedLayerBitmap { get => this.layerDataHelper.GetLayerData(this.labelHelper.SelectedLayerLabel).LayerImage; }

        /// <summary>
        /// Retrieves the selected layer's data.
        /// </summary>
        public LayerData GetSelectedLayerData { get => this.layerDataHelper.GetLayerData(this.labelHelper.SelectedLayerLabel);}
        
        /// <summary>
        /// Retrieves all visible layers' data. It is ordered by Z index.
        /// </summary>
        public IEnumerable<LayerData> GetAllVisibleLayersData {
            get
            {
                List<LayerData> allVisibleLayersData = new List<LayerData>();
                foreach (LayerLabel lbl in this.allLayersPanel.Controls) // all labels are already ordered in the panel based on Z index
                {
                    if (lbl.IsLayerVisible == false)
                    {
                        continue;
                    }

                    LayerData layerData = this.layerDataHelper.GetLayerData(lbl);
                    allVisibleLayersData.Add(layerData);
                }

                return allVisibleLayersData;
            }
        }

        /// <summary>
        /// Ensures the window is ready to be used by the user.
        /// </summary>
        public void SetUp() 
        {
            // Create the very first layer.
            CreateNewLayer();
           
            // Connect necessary click events.
            ConnectBtnEvents();

            // Because we have a single layer, the delete button should be disabled by default.
            this.deleteLayerBtn.Enabled = false;
        }

        /// <summary>
        /// Creates a brand new layer.
        /// </summary>
        public void CreateNewLayer()
        {
            // Create a layer label.
            LayerLabel newLbl = this.labelHelper.CreateLayerLabel();

            // Create a layer data that is associated with the label.
            this.layerDataHelper.AddNewLayerData(newLbl);

            Globals.LayerRenderer.OnLayerChangesApplied();
        }

        /// <summary>
        /// Deletes the selected layer.
        /// </summary>
        /// <param name="lblToRemove"></param>
        private void DeleteSelectedLayer()
        {
            // Delete the selected layer's data.
            this.layerDataHelper.DeleteLayerData(this.labelHelper.SelectedLayerLabel);

            // Delete the selected layer label.
            this.labelHelper.DeleteSelectedLabel();

            Globals.LayerRenderer.OnLayerChangesApplied();
        }

        /// <summary>
        /// Duplicates the selected layer.
        /// </summary>
        /// <param name="lblToDuplicate"></param>
        private void DuplicateSelectedLayer()
        {
            // I need this, because when you duplicate a layer label, the duplicate becomes the newly selected one.
            LayerLabel cachePreviouslySelectedLabel = this.labelHelper.SelectedLayerLabel;

            // Duplicate layer label.
            LayerLabel duplicatedLabel = this.labelHelper.DuplicateSelectedLabel();

            // Duplicate layer data.
            this.layerDataHelper.DuplicateLayerData(cachePreviouslySelectedLabel, duplicatedLabel);

            Globals.LayerRenderer.OnLayerChangesApplied();
        }

        /// <summary>
        /// Moves the selected layer up.
        /// </summary>
        private void MoveLayerUp()
        {
            if (this.labelHelper.MoveSelectedLayerLabelUp() == false)
            {
                return;
            }

            Globals.LayerRenderer.OnLayerChangesApplied();
        }

        /// <summary>
        /// Moves the selected layer down.
        /// </summary>
        private void MoveLayerDown()
        {
            if (this.labelHelper.MoveSelectedLayerLabelDown() == false) 
            {
                return;
            }

            Globals.LayerRenderer.OnLayerChangesApplied();
        }

        /// <summary>
        /// Enables the buttons' functionalities.
        /// </summary>
        private void ConnectBtnEvents()
        {
            this.createLayerBtn.Click += (o, e) =>
            {
                // Ensure the delete button is enabled yet again if the count of labels is more than 1 (which would always be true when executing this function, because the last layer can NEVER be deleted)
                this.deleteLayerBtn.Enabled = true;
                CreateNewLayer();
            };

            this.deleteLayerBtn.Click += (o, e) =>
            {
                DeleteSelectedLayer();

                // Disable the delete button if only a single layer was left
                if (allLayersPanel.Controls.Count == 1)
                {
                    this.deleteLayerBtn.Enabled = false;
                }
            };

            this.duplicateLayerBtn.Click += (o, e) =>
            {
                this.deleteLayerBtn.Enabled = true;
                DuplicateSelectedLayer();
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

        private void OnLayerLabelCheckBoxClicked() 
        {
            Globals.LayerRenderer.OnLayerChangesApplied();
        }

        private void OnLayerLabelSelected() 
        {
            Globals.LayerRenderer.OnLayerChangesApplied();
        }
    }
}
