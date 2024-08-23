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
            Bitmap bmpToSaveToDisk = Globals.CanvasContainer.CanvasDisplayedImage;
            ExportBitmapAsPNG(bmpToSaveToDisk);
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

        private void resizeCanvasBtn_Click(object sender, EventArgs e)
        {
            int width = -1;
            int height = -1;

            // Just in case someone entered letters or a negative numbers in the textboxes.
            bool isSuccessful = 
                int.TryParse(this.widthTextBox.Text, out width) &&
                int.TryParse(this.heightTextBox.Text, out height) &&
                width > 0 && height > 0;

            if (isSuccessful == false) 
            {
                return;
            }

            Globals.CanvasContainer.ResizeCanvasSafely(width, height);
        }
    }
}
