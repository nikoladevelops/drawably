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
            layersMenuWindow = new MenuWindow();
            colorsMenuWindow = new MenuWindow();
            toolsMenuWindow = new MenuWindow();
            topMainPanel = new Panel();
            topRightPanel = new Panel();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            topLeftPanel = new Panel();
            customMenuStrip1 = new UserControls.CustomMenuStrip.CustomMenuStrip();
            testingggToolStripMenuItem = new ToolStripMenuItem();
            dxfhdsafhToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            adsfhfdshToolStripMenuItem = new ToolStripMenuItem();
            hoverButton1 = new UserControls.HoverButton();
            hoverButton2 = new UserControls.HoverButton();
            hoverButton3 = new UserControls.HoverButton();
            topMainPanel.SuspendLayout();
            topRightPanel.SuspendLayout();
            toolStrip1.SuspendLayout();
            topLeftPanel.SuspendLayout();
            customMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // layersMenuWindow
            // 
            layersMenuWindow.AssociatedButton = null;
            layersMenuWindow.BackColor = SystemColors.ActiveCaption;
            layersMenuWindow.Location = new Point(1119, 427);
            layersMenuWindow.MenuText = "Layers";
            layersMenuWindow.Name = "layersMenuWindow";
            layersMenuWindow.Size = new Size(162, 179);
            layersMenuWindow.TabIndex = 2;
            // 
            // colorsMenuWindow
            // 
            colorsMenuWindow.AssociatedButton = null;
            colorsMenuWindow.BackColor = SystemColors.ActiveCaption;
            colorsMenuWindow.Location = new Point(12, 397);
            colorsMenuWindow.MenuText = "Colors";
            colorsMenuWindow.Name = "colorsMenuWindow";
            colorsMenuWindow.Size = new Size(168, 220);
            colorsMenuWindow.TabIndex = 3;
            colorsMenuWindow.Load += colorsMenuWindow_Load;
            // 
            // toolsMenuWindow
            // 
            toolsMenuWindow.AssociatedButton = null;
            toolsMenuWindow.BackColor = SystemColors.ActiveCaption;
            toolsMenuWindow.Location = new Point(12, 56);
            toolsMenuWindow.MenuText = "Tools";
            toolsMenuWindow.Name = "toolsMenuWindow";
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
            topMainPanel.Size = new Size(1302, 24);
            topMainPanel.TabIndex = 13;
            // 
            // topRightPanel
            // 
            topRightPanel.Controls.Add(toolStrip1);
            topRightPanel.Dock = DockStyle.Right;
            topRightPanel.Location = new Point(1196, 0);
            topRightPanel.Name = "topRightPanel";
            topRightPanel.Size = new Size(106, 24);
            topRightPanel.TabIndex = 15;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Black;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripButton4, toolStripButton5 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(106, 25);
            toolStrip1.Stretch = true;
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(23, 22);
            toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(23, 20);
            toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(23, 20);
            toolStripButton5.Text = "toolStripButton5";
            // 
            // topLeftPanel
            // 
            topLeftPanel.Controls.Add(customMenuStrip1);
            topLeftPanel.Dock = DockStyle.Fill;
            topLeftPanel.Location = new Point(0, 0);
            topLeftPanel.Name = "topLeftPanel";
            topLeftPanel.Size = new Size(1302, 24);
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
            customMenuStrip1.Size = new Size(1302, 24);
            customMenuStrip1.TabIndex = 14;
            customMenuStrip1.Text = "customMenuStrip1";
            // 
            // testingggToolStripMenuItem
            // 
            testingggToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dxfhdsafhToolStripMenuItem, toolStripMenuItem1, adsfhfdshToolStripMenuItem });
            testingggToolStripMenuItem.Name = "testingggToolStripMenuItem";
            testingggToolStripMenuItem.Size = new Size(37, 20);
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
            // hoverButton1
            // 
            hoverButton1.BackColor = SystemColors.Desktop;
            hoverButton1.FlatAppearance.BorderColor = Color.IndianRed;
            hoverButton1.FlatAppearance.BorderSize = 3;
            hoverButton1.FlatStyle = FlatStyle.Flat;
            hoverButton1.IsMouseEnterBorderColorEnabled = true;
            hoverButton1.IsMouseEnterColorEnabled = true;
            hoverButton1.Location = new Point(283, 128);
            hoverButton1.MouseEnterBorderColor = Color.LightCoral;
            hoverButton1.MouseEnterColor = Color.DimGray;
            hoverButton1.Name = "hoverButton1";
            hoverButton1.Size = new Size(129, 48);
            hoverButton1.TabIndex = 14;
            hoverButton1.Text = "hoverButton1";
            hoverButton1.UseVisualStyleBackColor = false;
            // 
            // hoverButton2
            // 
            hoverButton2.BackColor = SystemColors.ActiveCaptionText;
            hoverButton2.FlatAppearance.BorderColor = Color.Fuchsia;
            hoverButton2.FlatAppearance.BorderSize = 4;
            hoverButton2.FlatStyle = FlatStyle.Flat;
            hoverButton2.IsMouseEnterBorderColorEnabled = true;
            hoverButton2.IsMouseEnterColorEnabled = true;
            hoverButton2.Location = new Point(125, 153);
            hoverButton2.MouseEnterBorderColor = Color.FromArgb(192, 255, 192);
            hoverButton2.MouseEnterColor = Color.Yellow;
            hoverButton2.Name = "hoverButton2";
            hoverButton2.Size = new Size(115, 50);
            hoverButton2.TabIndex = 15;
            hoverButton2.Text = "hoverButton2";
            hoverButton2.UseVisualStyleBackColor = false;
            // 
            // hoverButton3
            // 
            hoverButton3.BackColor = SystemColors.Highlight;
            hoverButton3.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            hoverButton3.FlatAppearance.BorderSize = 4;
            hoverButton3.FlatStyle = FlatStyle.Flat;
            hoverButton3.IsMouseEnterBorderColorEnabled = true;
            hoverButton3.IsMouseEnterColorEnabled = true;
            hoverButton3.Location = new Point(445, 199);
            hoverButton3.MouseEnterBorderColor = Color.Green;
            hoverButton3.MouseEnterColor = Color.Red;
            hoverButton3.Name = "hoverButton3";
            hoverButton3.Size = new Size(156, 45);
            hoverButton3.TabIndex = 16;
            hoverButton3.Text = "hoverButton3";
            hoverButton3.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1302, 629);
            Controls.Add(hoverButton3);
            Controls.Add(hoverButton2);
            Controls.Add(hoverButton1);
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
            topRightPanel.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
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
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private UserControls.HoverButton hoverButton1;
        private UserControls.HoverButton hoverButton2;
        private UserControls.HoverButton hoverButton3;
    }
}