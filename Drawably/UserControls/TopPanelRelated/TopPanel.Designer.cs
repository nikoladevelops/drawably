using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawably.UserControls.TopPanelRelated
{
    public partial class TopPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
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
            dxfhdsafhToolStripMenuItem.Size = new Size(114, 22);
            dxfhdsafhToolStripMenuItem.Text = "New";
            // 
            // saveButton
            // 
            saveButton.ForeColor = Color.White;
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(114, 22);
            saveButton.Text = "Save";
            saveButton.Click += saveButton_Click;
            // 
            // saveAsButton
            // 
            saveAsButton.ForeColor = Color.White;
            saveAsButton.Name = "saveAsButton";
            saveAsButton.Size = new Size(114, 22);
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
            mainToolsPanel.Dock = DockStyle.Right;
            mainToolsPanel.Location = new Point(523, 3);
            mainToolsPanel.Name = "mainToolsPanel";
            mainToolsPanel.Size = new Size(90, 29);
            mainToolsPanel.TabIndex = 16;
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
        #endregion

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
    }
}
