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
            colorsWindow = new UserControls.Windows.Colors.ColorsWindow();
            layersWindow = new UserControls.Windows.Layers.LayersWindow();
            topPanel = new UserControls.TopPanelRelated.TopPanel();
            toolsWindow = new UserControls.Windows.Tools.ToolsWindow();
            canvas = new PictureBox();
            canvasContainer = new UserControls.CanvasRelated.CanvasContainer();
            ((System.ComponentModel.ISupportInitialize)canvas).BeginInit();
            SuspendLayout();
            // 
            // colorsWindow
            // 
            colorsWindow.BackColor = SystemColors.ActiveCaption;
            colorsWindow.CanvasContainer = canvasContainer;
            colorsWindow.Location = new Point(12, 400);
            colorsWindow.MenuText = "Colors";
            colorsWindow.MinimumSize = new Size(168, 244);
            colorsWindow.Name = "colorsWindow";
            colorsWindow.Size = new Size(168, 244);
            colorsWindow.TabIndex = 19;
            // 
            // layersWindow
            // 
            layersWindow.BackColor = SystemColors.ActiveCaption;
            layersWindow.CanvasContainer = canvasContainer;
            layersWindow.Location = new Point(980, 400);
            layersWindow.MaximumSize = new Size(175, 225);
            layersWindow.MenuText = "Layers";
            layersWindow.MinimumSize = new Size(175, 225);
            layersWindow.Name = "layersWindow";
            layersWindow.Size = new Size(175, 225);
            layersWindow.TabIndex = 20;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.Black;
            topPanel.CanvasContainer = canvasContainer;
            topPanel.ColorsWindow = colorsWindow;
            topPanel.Dock = DockStyle.Top;
            topPanel.LayersWindow = layersWindow;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1302, 67);
            topPanel.TabIndex = 21;
            topPanel.ToolsWindow = toolsWindow;
            // 
            // toolsWindow
            // 
            toolsWindow.BackColor = SystemColors.ActiveCaption;
            toolsWindow.Location = new Point(12, 73);
            toolsWindow.MenuText = "Tools";
            toolsWindow.Name = "toolsWindow";
            toolsWindow.Size = new Size(71, 321);
            toolsWindow.TabIndex = 0;
            // 
            // canvas
            // 
            canvas.Anchor = AnchorStyles.None;
            canvas.BackColor = Color.White;
            canvas.Image = (Image)resources.GetObject("canvas.Image");
            canvas.Location = new Point(796, 1133);
            canvas.MaximumSize = new Size(1508, 1508);
            canvas.MinimumSize = new Size(32, 32);
            canvas.Name = "canvas";
            canvas.Size = new Size(608, 233);
            canvas.TabIndex = 0;
            canvas.TabStop = false;
            // 
            // canvasContainer
            // 
            canvasContainer.AutoScroll = true;
            canvasContainer.AutoScrollMinSize = new Size(2200, 2500);
            canvasContainer.BackColor = Color.DarkGray;
            canvasContainer.CanvasVisualizedImage = (Bitmap)resources.GetObject("canvasContainer.CanvasVisualizedImage");
            canvasContainer.ColorsWindow = colorsWindow;
            canvasContainer.CurrentTool = null;
            canvasContainer.Dock = DockStyle.Fill;
            canvasContainer.LayersWindow = layersWindow;
            canvasContainer.Location = new Point(0, 67);
            canvasContainer.Name = "canvasContainer";
            canvasContainer.Size = new Size(1302, 562);
            canvasContainer.TabIndex = 22;
            canvasContainer.TopPanel = topPanel;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(1302, 629);
            Controls.Add(layersWindow);
            Controls.Add(colorsWindow);
            Controls.Add(toolsWindow);
            Controls.Add(canvasContainer);
            Controls.Add(topPanel);
            KeyPreview = true;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Drawably";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)canvas).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private UserControls.Windows.Colors.ColorsWindow colorsWindow;
        private UserControls.Windows.Layers.LayersWindow layersWindow;
        private UserControls.Windows.Tools.ToolsWindow toolsWindow;
        private PictureBox canvas;
        public UserControls.TopPanelRelated.TopPanel topPanel;
        private UserControls.CanvasRelated.CanvasContainer canvasContainer;
    }
}