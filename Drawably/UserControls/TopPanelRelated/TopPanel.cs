using Drawably.UserControls.CanvasRelated;
using Drawably.UserControls.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawably.UserControls.TopPanelRelated
{
    public class TopPanel : UserControl
    {

        [
           Category("All Custom Props"),
           Description("The Tools window, that the tools button controls")
        ]

        public MenuWindow ToolsWindow
        {
            get => this.mainToolsPanel.ToolsWindow;
            set => this.mainToolsPanel.ToolsWindow = value;
        }

        [
           Category("All Custom Props"),
           Description("The Colors window, that the colors button controls")
        ]
        public MenuWindow ColorsWindow
        {
            get => this.mainToolsPanel.ColorsWindow;
            set => this.mainToolsPanel.ColorsWindow = value;
        }

        [
           Category("All Custom Props"),
           Description("The Layers window, that the layers button controls")
        ]
        public MenuWindow LayersWindow
        {
            get => this.mainToolsPanel.LayersWindow;
            set => this.mainToolsPanel.LayersWindow = value;
        }
        [
           Category("All Custom Props"),
           Description("The Canvas Container window")
        ]
        public CanvasContainer CanvasContainer { get; set; }

        public TopPanel()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Adds a tool options control to the top panel
        /// </summary>
        /// <param name="controlToAdd"></param>
        public void AddToolOptionsControlToTopPanel(Control controlToAdd)
        {
            this.additionalPanel.Controls.Add(controlToAdd);
        }

        private void InitializeComponent()
        {
            customMenuStrip = new CustomMenuStrip();
            testingggToolStripMenuItem = new ToolStripMenuItem();
            dxfhdsafhToolStripMenuItem = new ToolStripMenuItem();
            saveButton = new ToolStripMenuItem();
            saveAsButton = new ToolStripMenuItem();
            mainControlsPanel = new TableLayoutPanel();
            mainToolsPanel = new MainToolsPanelRelated.MainToolsPanel();
            additionalPanel = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            layersButton = new HoverButton();
            colorsButton = new HoverButton();
            customMenuStrip.SuspendLayout();
            mainControlsPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // customMenuStrip
            // 
            customMenuStrip.BackColor = Color.Black;
            customMenuStrip.Dock = DockStyle.Fill;
            customMenuStrip.ForeColor = Color.White;
            customMenuStrip.Items.AddRange(new ToolStripItem[] { testingggToolStripMenuItem });
            customMenuStrip.Location = new Point(0, 0);
            customMenuStrip.Name = "customMenuStrip";
            customMenuStrip.Size = new Size(248, 35);
            customMenuStrip.TabIndex = 15;
            customMenuStrip.Text = "customMenuStrip1";
            // 
            // testingggToolStripMenuItem
            // 
            testingggToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dxfhdsafhToolStripMenuItem, saveButton, saveAsButton });
            testingggToolStripMenuItem.Name = "testingggToolStripMenuItem";
            testingggToolStripMenuItem.Size = new Size(37, 31);
            testingggToolStripMenuItem.Text = "File";
            // 
            // dxfhdsafhToolStripMenuItem
            // 
            dxfhdsafhToolStripMenuItem.ForeColor = Color.White;
            dxfhdsafhToolStripMenuItem.Name = "dxfhdsafhToolStripMenuItem";
            dxfhdsafhToolStripMenuItem.Size = new Size(180, 22);
            dxfhdsafhToolStripMenuItem.Text = "New";
            // 
            // saveButton
            // 
            saveButton.ForeColor = Color.White;
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(180, 22);
            saveButton.Text = "Save";
            saveButton.Click += saveButton_Click;
            // 
            // saveAsButton
            // 
            saveAsButton.ForeColor = Color.White;
            saveAsButton.Name = "saveAsButton";
            saveAsButton.Size = new Size(180, 22);
            saveAsButton.Text = "Save As";
            saveAsButton.Click += saveAsButton_Click;
            // 
            // mainControlsPanel
            // 
            mainControlsPanel.BackColor = Color.Black;
            mainControlsPanel.ColumnCount = 2;
            mainControlsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.31142F));
            mainControlsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.68858F));
            mainControlsPanel.Controls.Add(customMenuStrip, 0, 0);
            mainControlsPanel.Controls.Add(mainToolsPanel, 1, 0);
            mainControlsPanel.Dock = DockStyle.Top;
            mainControlsPanel.Location = new Point(0, 0);
            mainControlsPanel.Name = "mainControlsPanel";
            mainControlsPanel.RowCount = 1;
            mainControlsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            mainControlsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            mainControlsPanel.Size = new Size(616, 35);
            mainControlsPanel.TabIndex = 18;
            // 
            // mainToolsPanel
            // 
            mainToolsPanel.ColorsWindow = null;
            mainToolsPanel.Dock = DockStyle.Right;
            mainToolsPanel.LayersWindow = null;
            mainToolsPanel.Location = new Point(523, 3);
            mainToolsPanel.Name = "mainToolsPanel";
            mainToolsPanel.Size = new Size(90, 29);
            mainToolsPanel.TabIndex = 16;
            mainToolsPanel.ToolsWindow = null;
            // 
            // additionalPanel
            // 
            additionalPanel.BackColor = Color.Black;
            additionalPanel.BorderStyle = BorderStyle.FixedSingle;
            additionalPanel.Dock = DockStyle.Fill;
            additionalPanel.Location = new Point(0, 35);
            additionalPanel.Name = "additionalPanel";
            additionalPanel.Size = new Size(616, 36);
            additionalPanel.TabIndex = 19;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(layersButton, 2, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // layersButton
            // 
            layersButton.BackColor = Color.FromArgb(139, 138, 194);
            layersButton.BackgroundImage = Properties.Resources.layers;
            layersButton.BackgroundImageLayout = ImageLayout.Zoom;
            layersButton.Dock = DockStyle.Fill;
            layersButton.FlatAppearance.BorderColor = Color.FromArgb(128, 128, 255);
            layersButton.FlatStyle = FlatStyle.Flat;
            layersButton.IsMouseEnterBorderColorEnabled = true;
            layersButton.IsMouseEnterColorEnabled = true;
            layersButton.Location = new Point(135, 3);
            layersButton.MouseEnterBorderColor = Color.Blue;
            layersButton.MouseEnterColor = Color.FromArgb(139, 138, 194);
            layersButton.Name = "layersButton";
            layersButton.OriginalColorCached = Color.FromArgb(139, 138, 194);
            layersButton.Size = new Size(62, 94);
            layersButton.TabIndex = 18;
            layersButton.UseVisualStyleBackColor = false;
            // 
            // colorsButton
            // 
            colorsButton.BackColor = Color.FromArgb(139, 138, 194);
            colorsButton.BackgroundImage = Properties.Resources.colour;
            colorsButton.BackgroundImageLayout = ImageLayout.Zoom;
            colorsButton.Dock = DockStyle.Fill;
            colorsButton.FlatAppearance.BorderColor = Color.FromArgb(128, 128, 255);
            colorsButton.FlatStyle = FlatStyle.Flat;
            colorsButton.IsMouseEnterBorderColorEnabled = true;
            colorsButton.IsMouseEnterColorEnabled = true;
            colorsButton.Location = new Point(69, 3);
            colorsButton.MouseEnterBorderColor = Color.Blue;
            colorsButton.MouseEnterColor = Color.FromArgb(139, 138, 194);
            colorsButton.Name = "colorsButton";
            colorsButton.OriginalColorCached = Color.FromArgb(139, 138, 194);
            colorsButton.Size = new Size(60, 94);
            colorsButton.TabIndex = 17;
            colorsButton.UseVisualStyleBackColor = false;
            // 
            // TopPanel
            // 
            Controls.Add(additionalPanel);
            Controls.Add(mainControlsPanel);
            Name = "TopPanel";
            Size = new Size(616, 71);
            customMenuStrip.ResumeLayout(false);
            customMenuStrip.PerformLayout();
            mainControlsPanel.ResumeLayout(false);
            mainControlsPanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private TopPanelRelated.CustomMenuStrip customMenuStrip;
        private ToolStripMenuItem testingggToolStripMenuItem;
        private ToolStripMenuItem dxfhdsafhToolStripMenuItem;
        private ToolStripMenuItem saveButton;
        private ToolStripMenuItem saveAsButton;
        private Panel additionalPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private HoverButton layersButton;
        private HoverButton colorsButton;
        public MainToolsPanelRelated.MainToolsPanel mainToolsPanel;
        public TableLayoutPanel mainControlsPanel;

        private void saveButton_Click(object sender, EventArgs e)
        {
            Bitmap bmpToSaveToDisk = this.CanvasContainer.GetFinalImageToExport();
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
    }
}
