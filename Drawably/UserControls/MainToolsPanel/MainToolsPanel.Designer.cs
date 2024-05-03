namespace Drawably.UserControls.CustomMenuStrip
{
    partial class MainToolsPanel
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
            toolsButton = new HoverButton();
            colorsButton = new HoverButton();
            layersButton = new HoverButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // toolsButton
            // 
            toolsButton.BackColor = Color.FromArgb(139, 138, 194);
            toolsButton.BackgroundImage = Properties.Resources.hammer;
            toolsButton.BackgroundImageLayout = ImageLayout.Zoom;
            toolsButton.Dock = DockStyle.Fill;
            toolsButton.FlatAppearance.BorderColor = Color.FromArgb(128, 128, 255);
            toolsButton.FlatStyle = FlatStyle.Flat;
            toolsButton.IsMouseEnterBorderColorEnabled = true;
            toolsButton.IsMouseEnterColorEnabled = true;
            toolsButton.Location = new Point(3, 3);
            toolsButton.MouseEnterBorderColor = Color.Blue;
            toolsButton.MouseEnterColor = Color.FromArgb(139, 138, 194);
            toolsButton.Name = "toolsButton";
            toolsButton.Size = new Size(131, 136);
            toolsButton.TabIndex = 16;
            toolsButton.UseVisualStyleBackColor = false;
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
            colorsButton.Location = new Point(140, 3);
            colorsButton.MouseEnterBorderColor = Color.Blue;
            colorsButton.MouseEnterColor = Color.FromArgb(139, 138, 194);
            colorsButton.Name = "colorsButton";
            colorsButton.Size = new Size(131, 136);
            colorsButton.TabIndex = 17;
            colorsButton.UseVisualStyleBackColor = false;
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
            layersButton.Location = new Point(277, 3);
            layersButton.MouseEnterBorderColor = Color.Blue;
            layersButton.MouseEnterColor = Color.FromArgb(139, 138, 194);
            layersButton.Name = "layersButton";
            layersButton.Size = new Size(133, 136);
            layersButton.TabIndex = 18;
            layersButton.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(layersButton, 2, 0);
            tableLayoutPanel1.Controls.Add(colorsButton, 1, 0);
            tableLayoutPanel1.Controls.Add(toolsButton, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(413, 142);
            tableLayoutPanel1.TabIndex = 20;
            // 
            // MainToolsPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "MainToolsPanel";
            Size = new Size(413, 142);
            Load += MainToolsPanel_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private HoverButton toolsButton;
        private HoverButton colorsButton;
        private HoverButton layersButton;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
