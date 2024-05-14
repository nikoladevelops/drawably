namespace Drawably
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            topMainPanel = new Panel();
            topRightPanel = new Panel();
            mainToolsPanel1 = new UserControls.CustomMenuStrip.MainToolsPanel();
            topLeftPanel = new Panel();
            customMenuStrip1 = new UserControls.CustomMenuStrip.CustomMenuStrip();
            testingggToolStripMenuItem = new ToolStripMenuItem();
            dxfhdsafhToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            adsfhfdshToolStripMenuItem = new ToolStripMenuItem();
            canvas = new PictureBox();
            canvasContainer = new UserControls.CanvasContainer();
            colorsWindow1 = new UserControls.Windows.ColorsWindow();
            toolsWindow1 = new UserControls.Windows.ToolsWindow();
            layersWindow1 = new UserControls.Windows.LayersWindow();
            topMainPanel.SuspendLayout();
            topRightPanel.SuspendLayout();
            topLeftPanel.SuspendLayout();
            customMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)canvas).BeginInit();
            canvasContainer.SuspendLayout();
            SuspendLayout();
            // 
            // topMainPanel
            // 
            topMainPanel.Controls.Add(topRightPanel);
            topMainPanel.Controls.Add(topLeftPanel);
            topMainPanel.Dock = DockStyle.Top;
            topMainPanel.Location = new Point(0, 0);
            topMainPanel.Name = "topMainPanel";
            topMainPanel.Size = new Size(1302, 31);
            topMainPanel.TabIndex = 13;
            // 
            // topRightPanel
            // 
            topRightPanel.BackColor = Color.Black;
            topRightPanel.Controls.Add(mainToolsPanel1);
            topRightPanel.Dock = DockStyle.Right;
            topRightPanel.Location = new Point(1198, 0);
            topRightPanel.Name = "topRightPanel";
            topRightPanel.Size = new Size(104, 31);
            topRightPanel.TabIndex = 15;
            // 
            // mainToolsPanel1
            // 
            mainToolsPanel1.ColorsWindow = colorsWindow1;
            mainToolsPanel1.LayersWindow = layersWindow1;
            mainToolsPanel1.Location = new Point(3, 0);
            mainToolsPanel1.Name = "mainToolsPanel1";
            mainToolsPanel1.Size = new Size(95, 31);
            mainToolsPanel1.TabIndex = 14;
            mainToolsPanel1.ToolsWindow = toolsWindow1;
            // 
            // topLeftPanel
            // 
            topLeftPanel.Controls.Add(customMenuStrip1);
            topLeftPanel.Dock = DockStyle.Fill;
            topLeftPanel.Location = new Point(0, 0);
            topLeftPanel.Name = "topLeftPanel";
            topLeftPanel.Size = new Size(1302, 31);
            topLeftPanel.TabIndex = 14;
            // 
            // customMenuStrip1
            // 
            customMenuStrip1.BackColor = Color.Black;
            customMenuStrip1.Dock = DockStyle.Fill;
            customMenuStrip1.ForeColor = Color.White;
            customMenuStrip1.Items.AddRange(new ToolStripItem[] { testingggToolStripMenuItem });
            customMenuStrip1.Location = new Point(0, 0);
            customMenuStrip1.Name = "customMenuStrip1";
            customMenuStrip1.Size = new Size(1302, 31);
            customMenuStrip1.TabIndex = 14;
            customMenuStrip1.Text = "customMenuStrip1";
            // 
            // testingggToolStripMenuItem
            // 
            testingggToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dxfhdsafhToolStripMenuItem, toolStripMenuItem1, adsfhfdshToolStripMenuItem });
            testingggToolStripMenuItem.Name = "testingggToolStripMenuItem";
            testingggToolStripMenuItem.Size = new Size(37, 27);
            testingggToolStripMenuItem.Text = "File";
            // 
            // dxfhdsafhToolStripMenuItem
            // 
            dxfhdsafhToolStripMenuItem.ForeColor = Color.White;
            dxfhdsafhToolStripMenuItem.Name = "dxfhdsafhToolStripMenuItem";
            dxfhdsafhToolStripMenuItem.Size = new Size(114, 22);
            dxfhdsafhToolStripMenuItem.Text = "New";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.ForeColor = Color.White;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(114, 22);
            toolStripMenuItem1.Text = "Save";
            // 
            // adsfhfdshToolStripMenuItem
            // 
            adsfhfdshToolStripMenuItem.ForeColor = Color.White;
            adsfhfdshToolStripMenuItem.Name = "adsfhfdshToolStripMenuItem";
            adsfhfdshToolStripMenuItem.Size = new Size(114, 22);
            adsfhfdshToolStripMenuItem.Text = "Save As";
            // 
            // canvas
            // 
            canvas.Anchor = AnchorStyles.None;
            canvas.BackColor = SystemColors.ActiveCaption;
            canvas.Image = Properties.Resources.hammer;
            canvas.Location = new Point(901, 1157);
            canvas.MaximumSize = new Size(1508, 1508);
            canvas.MinimumSize = new Size(32, 32);
            canvas.Name = "canvas";
            canvas.Size = new Size(397, 185);
            canvas.SizeMode = PictureBoxSizeMode.Zoom;
            canvas.TabIndex = 16;
            canvas.TabStop = false;
            // 
            // canvasContainer
            // 
            canvasContainer.AutoScroll = true;
            canvasContainer.AutoScrollMinSize = new Size(2200, 2500);
            canvasContainer.BackColor = SystemColors.AppWorkspace;
            canvasContainer.BackgroundImageLayout = ImageLayout.Zoom;
            canvasContainer.Canvas = canvas;
            canvasContainer.ColumnCount = 1;
            canvasContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            canvasContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            canvasContainer.Controls.Add(canvas, 0, 0);
            canvasContainer.Dock = DockStyle.Fill;
            canvasContainer.Location = new Point(0, 0);
            canvasContainer.Name = "canvasContainer";
            canvasContainer.RowCount = 1;
            canvasContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            canvasContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            canvasContainer.Size = new Size(1302, 629);
            canvasContainer.TabIndex = 17;
            // 
            // colorsWindow1
            // 
            colorsWindow1.BackColor = SystemColors.ActiveCaption;
            colorsWindow1.Location = new Point(526, 0);
            colorsWindow1.MenuText = "Colors";
            colorsWindow1.Name = "colorsWindow1";
            colorsWindow1.OnCloseBtnClicked = null;
            colorsWindow1.Size = new Size(168, 220);
            colorsWindow1.TabIndex = 19;
            // 
            // toolsWindow1
            // 
            toolsWindow1.BackColor = SystemColors.ActiveCaption;
            toolsWindow1.Location = new Point(814, 0);
            toolsWindow1.MenuText = "Tools";
            toolsWindow1.Name = "toolsWindow1";
            toolsWindow1.OnCloseBtnClicked = null;
            toolsWindow1.Size = new Size(71, 321);
            toolsWindow1.TabIndex = 0;
            // 
            // layersWindow1
            // 
            layersWindow1.BackColor = SystemColors.ActiveCaption;
            layersWindow1.Location = new Point(226, 0);
            layersWindow1.MenuText = "Layers";
            layersWindow1.Name = "layersWindow1";
            layersWindow1.OnCloseBtnClicked = null;
            layersWindow1.Size = new Size(162, 179);
            layersWindow1.TabIndex = 20;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1302, 629);
            Controls.Add(layersWindow1);
            Controls.Add(toolsWindow1);
            Controls.Add(colorsWindow1);
            Controls.Add(topMainPanel);
            Controls.Add(canvasContainer);
            KeyPreview = true;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Drawably";
            Load += MainForm_Load;
            topMainPanel.ResumeLayout(false);
            topRightPanel.ResumeLayout(false);
            topLeftPanel.ResumeLayout(false);
            topLeftPanel.PerformLayout();
            customMenuStrip1.ResumeLayout(false);
            customMenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)canvas).EndInit();
            canvasContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel topMainPanel;
        private Panel topRightPanel;
        private Panel topLeftPanel;
        private UserControls.CustomMenuStrip.CustomMenuStrip customMenuStrip1;
        private ToolStripMenuItem testingggToolStripMenuItem;
        private ToolStripMenuItem dxfhdsafhToolStripMenuItem;
        private ToolStripMenuItem adsfhfdshToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private UserControls.CustomMenuStrip.MainToolsPanel mainToolsPanel1;
        private UserControls.Windows.ToolsWindow toolsWindow;
        private PictureBox canvas;
        private UserControls.CanvasContainer canvasContainer;
        private UserControls.Windows.LayersWindow layersWindow;
        private UserControls.Windows.ColorsWindow colorsWindow;
        private UserControls.Windows.ColorsWindow colorsWindow1;
        private UserControls.Windows.LayersWindow layersWindow1;
        private UserControls.Windows.ToolsWindow toolsWindow1;
    }
}