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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            topMainPanel = new Panel();
            topRightPanel = new Panel();
            mainToolsPanel1 = new UserControls.CustomMenuStrip.MainToolsPanel();
            colorsWindow = new UserControls.Windows.ColorsWindow();
            layersWindow = new UserControls.Windows.LayersWindow();
            toolsWindow = new UserControls.Windows.ToolsWindow();
            topLeftPanel = new Panel();
            customMenuStrip1 = new UserControls.CustomMenuStrip.CustomMenuStrip();
            testingggToolStripMenuItem = new ToolStripMenuItem();
            dxfhdsafhToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            adsfhfdshToolStripMenuItem = new ToolStripMenuItem();
            canvasContainer = new UserControls.CanvasContainer();
            canvas = new PictureBox();
            topMainPanel.SuspendLayout();
            topRightPanel.SuspendLayout();
            topLeftPanel.SuspendLayout();
            customMenuStrip1.SuspendLayout();
            canvasContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)canvas).BeginInit();
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
            topRightPanel.Location = new Point(1200, 0);
            topRightPanel.Name = "topRightPanel";
            topRightPanel.Size = new Size(102, 31);
            topRightPanel.TabIndex = 15;
            // 
            // mainToolsPanel1
            // 
            mainToolsPanel1.ColorsWindow = colorsWindow;
            mainToolsPanel1.LayersWindow = layersWindow;
            mainToolsPanel1.Location = new Point(0, 0);
            mainToolsPanel1.Name = "mainToolsPanel1";
            mainToolsPanel1.Size = new Size(98, 31);
            mainToolsPanel1.TabIndex = 14;
            mainToolsPanel1.ToolsWindow = toolsWindow;
            // 
            // colorsWindow
            // 
            colorsWindow.BackColor = SystemColors.ActiveCaption;
            colorsWindow.Location = new Point(20, 370);
            colorsWindow.MenuText = "Colors";
            colorsWindow.Name = "colorsWindow";
            colorsWindow.Size = new Size(168, 220);
            colorsWindow.TabIndex = 19;
            // 
            // layersWindow
            // 
            layersWindow.BackColor = SystemColors.ActiveCaption;
            layersWindow.Location = new Point(980, 400);
            layersWindow.MenuText = "Layers";
            layersWindow.Name = "layersWindow";
            layersWindow.Size = new Size(162, 179);
            layersWindow.TabIndex = 20;
            // 
            // toolsWindow
            // 
            toolsWindow.BackColor = SystemColors.ActiveCaption;
            toolsWindow.Location = new Point(20, 35);
            toolsWindow.MenuText = "Tools";
            toolsWindow.Name = "toolsWindow";
            toolsWindow.Size = new Size(71, 321);
            toolsWindow.TabIndex = 0;
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
            canvasContainer.CurrentTool = null;
            canvasContainer.Dock = DockStyle.Fill;
            canvasContainer.Location = new Point(0, 0);
            canvasContainer.Name = "canvasContainer";
            canvasContainer.RowCount = 1;
            canvasContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            canvasContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            canvasContainer.Size = new Size(1302, 629);
            canvasContainer.TabIndex = 17;
            // 
            // canvas
            // 
            canvas.Anchor = AnchorStyles.None;
            canvas.BackColor = SystemColors.Control;
            canvas.Image = (Image)resources.GetObject("canvas.Image");
            canvas.Location = new Point(901, 1157);
            canvas.MaximumSize = new Size(1508, 1508);
            canvas.MinimumSize = new Size(32, 32);
            canvas.Name = "canvas";
            canvas.Size = new Size(397, 185);
            canvas.SizeMode = PictureBoxSizeMode.Zoom;
            canvas.TabIndex = 16;
            canvas.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1302, 629);
            Controls.Add(layersWindow);
            Controls.Add(toolsWindow);
            Controls.Add(colorsWindow);
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
            canvasContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)canvas).EndInit();
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
        private PictureBox canvas;
        private UserControls.CanvasContainer canvasContainer;
        private UserControls.Windows.ColorsWindow colorsWindow;
        private UserControls.Windows.LayersWindow layersWindow;
        private UserControls.Windows.ToolsWindow toolsWindow;
    }
}