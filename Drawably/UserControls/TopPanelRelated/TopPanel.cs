using Drawably.UserControls.CanvasRelated;
using Drawably.UserControls.Windows;
using Drawably.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Drawably.UserControls.TopPanelRelated
{
    /// <summary>
    /// Holds different buttons, combo boxes and selected tool specific menus that can be easily used by the user.
    /// </summary>
    public partial class TopPanel : UserControl
    {
        public TopPanel()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Ensures the top panel is ready to be used by the user.
        /// </summary>
        public void SetUp() 
        {
            this.mainToolsPanel.SetUp();
        }

        /// <summary>
        /// Adds a tool options control to the top panel.
        /// </summary>
        /// <param name="controlToAdd"></param>
        public void AddToolOptionsControlToTopPanel(Control controlToAdd)
        {
            this.additionalPanel.Controls.Add(controlToAdd);
        }


        // TODO Some of the functions don't work/ are not finished

        private void saveButton_Click(object sender, EventArgs e)
        {
            Bitmap bmpToSaveToDisk = Globals.CanvasContainer.GetFinalImageToExport();
            ExportBitmapAsPNG(bmpToSaveToDisk);
        }

        private void saveAsButton_Click(object sender, EventArgs e)
        {

        }


        public void ExportBitmapAsPNG(Bitmap bitmapToExport)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PNG Image|*.png";
            saveDialog.Title = "Save PNG File";
            saveDialog.FileName = "image.png"; // Default file name

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Save the bitmap to the selected path as PNG
                    bitmapToExport.Save(saveDialog.FileName, ImageFormat.Png);
                    MessageBox.Show("Image saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        public void ExportAllLayerBitmaps() 
        {
            List<Bitmap> allBitmaps = Globals.CanvasContainer.GetAllLayerBitmapsInOrder();
            // open file dialog for exporting

        }

        public void LoadAllLayers() 
        {
            // open file dialog for loading
            List<Bitmap> allLoadedBitmaps = new List<Bitmap>();
            // Load file path with bitmaps
            // deserialize it and load everything in allBitmapsFil

            Globals.CanvasContainer.LoadAllLayerBitmapsInOrder(allLoadedBitmaps);
        }
    }
}
