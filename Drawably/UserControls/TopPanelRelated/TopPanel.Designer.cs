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
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveButton = new ToolStripMenuItem();
            mainControlsPanel = new TableLayoutPanel();
            label2 = new Label();
            widthTextBox = new TextBox();
            label1 = new Label();
            heightTextBox = new TextBox();
            resizeCanvasBtn = new Button();
            mainToolsPanel = new MainToolsPanelRelated.MainToolsPanel();
            additionalPanel = new Panel();
            layersButton = new HoverButton();
            colorsButton = new HoverButton();
            customMenuStrip.SuspendLayout();
            mainControlsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // customMenuStrip
            // 
            customMenuStrip.BackColor = Color.Black;
            customMenuStrip.Dock = DockStyle.Fill;
            customMenuStrip.ForeColor = Color.White;
            customMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            customMenuStrip.Location = new Point(0, 0);
            customMenuStrip.Name = "customMenuStrip";
            customMenuStrip.Size = new Size(271, 41);
            customMenuStrip.TabIndex = 15;
            customMenuStrip.Text = "customMenuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveButton });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 37);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveButton
            // 
            saveButton.ForeColor = Color.White;
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(98, 22);
            saveButton.Text = "Save";
            saveButton.Click += saveButton_Click;
            // 
            // mainControlsPanel
            // 
            mainControlsPanel.BackColor = Color.Black;
            mainControlsPanel.ColumnCount = 8;
            mainControlsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainControlsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 71F));
            mainControlsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 71F));
            mainControlsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 71F));
            mainControlsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 71F));
            mainControlsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 151F));
            mainControlsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 101F));
            mainControlsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            mainControlsPanel.Controls.Add(customMenuStrip, 0, 0);
            mainControlsPanel.Controls.Add(label2, 1, 0);
            mainControlsPanel.Controls.Add(widthTextBox, 2, 0);
            mainControlsPanel.Controls.Add(label1, 3, 0);
            mainControlsPanel.Controls.Add(heightTextBox, 4, 0);
            mainControlsPanel.Controls.Add(resizeCanvasBtn, 5, 0);
            mainControlsPanel.Controls.Add(mainToolsPanel, 6, 0);
            mainControlsPanel.Dock = DockStyle.Top;
            mainControlsPanel.Location = new Point(0, 0);
            mainControlsPanel.Name = "mainControlsPanel";
            mainControlsPanel.RowCount = 1;
            mainControlsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainControlsPanel.Size = new Size(815, 41);
            mainControlsPanel.TabIndex = 18;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(285, 13);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 22;
            label2.Text = "Width:";
            // 
            // widthTextBox
            // 
            widthTextBox.Anchor = AnchorStyles.None;
            widthTextBox.Location = new Point(345, 9);
            widthTextBox.Name = "widthTextBox";
            widthTextBox.Size = new Size(65, 23);
            widthTextBox.TabIndex = 17;
            widthTextBox.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(425, 13);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 21;
            label1.Text = "Height:";
            // 
            // heightTextBox
            // 
            heightTextBox.Anchor = AnchorStyles.None;
            heightTextBox.Location = new Point(488, 9);
            heightTextBox.Name = "heightTextBox";
            heightTextBox.Size = new Size(62, 23);
            heightTextBox.TabIndex = 18;
            heightTextBox.TabStop = false;
            // 
            // resizeCanvasBtn
            // 
            resizeCanvasBtn.FlatStyle = FlatStyle.Flat;
            resizeCanvasBtn.ForeColor = Color.White;
            resizeCanvasBtn.Location = new Point(558, 3);
            resizeCanvasBtn.Name = "resizeCanvasBtn";
            resizeCanvasBtn.Size = new Size(145, 29);
            resizeCanvasBtn.TabIndex = 20;
            resizeCanvasBtn.TabStop = false;
            resizeCanvasBtn.Text = "Resize Canvas";
            resizeCanvasBtn.UseVisualStyleBackColor = true;
            resizeCanvasBtn.Click += resizeCanvasBtn_Click;
            // 
            // mainToolsPanel
            // 
            mainToolsPanel.Location = new Point(709, 3);
            mainToolsPanel.Name = "mainToolsPanel";
            mainToolsPanel.Size = new Size(91, 29);
            mainToolsPanel.TabIndex = 23;
            // 
            // additionalPanel
            // 
            additionalPanel.AutoSize = true;
            additionalPanel.BackColor = Color.Black;
            additionalPanel.Dock = DockStyle.Bottom;
            additionalPanel.Location = new Point(0, 76);
            additionalPanel.Name = "additionalPanel";
            additionalPanel.Size = new Size(815, 0);
            additionalPanel.TabIndex = 19;
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
            layersButton.Location = new Point(102, 3);
            layersButton.MouseEnterBorderColor = Color.Blue;
            layersButton.MouseEnterColor = Color.FromArgb(139, 138, 194);
            layersButton.Name = "layersButton";
            layersButton.OriginalColorCached = Color.FromArgb(139, 138, 194);
            layersButton.Size = new Size(95, 94);
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
            BackColor = Color.Black;
            Controls.Add(additionalPanel);
            Controls.Add(mainControlsPanel);
            Name = "TopPanel";
            Size = new Size(815, 76);
            customMenuStrip.ResumeLayout(false);
            customMenuStrip.PerformLayout();
            mainControlsPanel.ResumeLayout(false);
            mainControlsPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private TopPanelRelated.CustomMenuStrip customMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveButton;
        private Panel additionalPanel;
        private HoverButton layersButton;
        private HoverButton colorsButton;
        public TableLayoutPanel mainControlsPanel;
        private Button resizeCanvasBtn;
        private TextBox heightTextBox;
        private Label label2;
        private TextBox widthTextBox;
        private Label label1;
        private MainToolsPanelRelated.MainToolsPanel mainToolsPanel;
    }
}
