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
            layersMenuWindow = new MenuWindow();
            colorsMenuWindow = new MenuWindow();
            toolsMenuWindow = new MenuWindow();
            topMainPanel = new Panel();
            topRightPanel = new Panel();
            mainToolsPanel1 = new UserControls.CustomMenuStrip.MainToolsPanel();
            topLeftPanel = new Panel();
            customMenuStrip1 = new UserControls.CustomMenuStrip.CustomMenuStrip();
            testingggToolStripMenuItem = new ToolStripMenuItem();
            dxfhdsafhToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            adsfhfdshToolStripMenuItem = new ToolStripMenuItem();
            topMainPanel.SuspendLayout();
            topRightPanel.SuspendLayout();
            topLeftPanel.SuspendLayout();
            customMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // layersMenuWindow
            // 
            layersMenuWindow.BackColor = SystemColors.ActiveCaption;
            layersMenuWindow.Location = new Point(1119, 427);
            layersMenuWindow.MenuText = "Layers";
            layersMenuWindow.Name = "layersMenuWindow";
            layersMenuWindow.OnCloseBtnClicked = null;
            layersMenuWindow.Size = new Size(162, 179);
            layersMenuWindow.TabIndex = 2;
            // 
            // colorsMenuWindow
            // 
            colorsMenuWindow.BackColor = SystemColors.ActiveCaption;
            colorsMenuWindow.Location = new Point(12, 397);
            colorsMenuWindow.MenuText = "Colors";
            colorsMenuWindow.Name = "colorsMenuWindow";
            colorsMenuWindow.OnCloseBtnClicked = null;
            colorsMenuWindow.Size = new Size(168, 220);
            colorsMenuWindow.TabIndex = 3;
            colorsMenuWindow.Load += colorsMenuWindow_Load;
            // 
            // toolsMenuWindow
            // 
            toolsMenuWindow.BackColor = SystemColors.ActiveCaption;
            toolsMenuWindow.Location = new Point(12, 56);
            toolsMenuWindow.MenuText = "Tools";
            toolsMenuWindow.Name = "toolsMenuWindow";
            toolsMenuWindow.OnCloseBtnClicked = null;
            toolsMenuWindow.Size = new Size(75, 267);
            toolsMenuWindow.TabIndex = 4;
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
            mainToolsPanel1.ColorsWindow = colorsMenuWindow;
            mainToolsPanel1.LayersWindow = layersMenuWindow;
            mainToolsPanel1.Location = new Point(3, 0);
            mainToolsPanel1.Name = "mainToolsPanel1";
            mainToolsPanel1.Size = new Size(95, 31);
            mainToolsPanel1.TabIndex = 14;
            mainToolsPanel1.ToolsWindow = toolsMenuWindow;
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1302, 629);
            Controls.Add(topMainPanel);
            Controls.Add(toolsMenuWindow);
            Controls.Add(layersMenuWindow);
            Controls.Add(colorsMenuWindow);
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
            ResumeLayout(false);
        }

        #endregion
        private MenuWindow layersMenuWindow;
        private MenuWindow colorsMenuWindow;
        private MenuWindow toolsMenuWindow;
        private Panel topMainPanel;
        private Panel topRightPanel;
        private Panel topLeftPanel;
        private UserControls.CustomMenuStrip.CustomMenuStrip customMenuStrip1;
        private ToolStripMenuItem testingggToolStripMenuItem;
        private ToolStripMenuItem dxfhdsafhToolStripMenuItem;
        private ToolStripMenuItem adsfhfdshToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private UserControls.CustomMenuStrip.MainToolsPanel mainToolsPanel1;
    }
}