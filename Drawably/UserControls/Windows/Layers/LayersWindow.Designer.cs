namespace Drawably.UserControls.Windows.Layers
{
    partial class LayersWindow
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
            layerControlPanel = new FlowLayoutPanel();
            createLayerBtn = new Button();
            deleteLayerBtn = new Button();
            duplicateLayerBtn = new Button();
            moveUpLayerBtn = new Button();
            moveDownLayerBtn = new Button();
            allLayersPanel = new FlowLayoutPanel();
            contentPanel.SuspendLayout();
            topPanel.SuspendLayout();
            layerControlPanel.SuspendLayout();
            SuspendLayout();
            // 
            // contentPanel
            // 
            contentPanel.Controls.Add(allLayersPanel);
            contentPanel.Controls.Add(layerControlPanel);
            contentPanel.Location = new Point(0, -77);
            contentPanel.Size = new Size(175, 302);
            // 
            // topPanel
            // 
            topPanel.Size = new Size(175, 23);
            // 
            // menuTextLabel
            // 
            menuTextLabel.Size = new Size(478, 23);
            // 
            // closeButton
            // 
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.Location = new Point(149, 0);
            // 
            // layerControlPanel
            // 
            layerControlPanel.BackColor = Color.White;
            layerControlPanel.Controls.Add(createLayerBtn);
            layerControlPanel.Controls.Add(deleteLayerBtn);
            layerControlPanel.Controls.Add(duplicateLayerBtn);
            layerControlPanel.Controls.Add(moveUpLayerBtn);
            layerControlPanel.Controls.Add(moveDownLayerBtn);
            layerControlPanel.Dock = DockStyle.Bottom;
            layerControlPanel.Location = new Point(0, 275);
            layerControlPanel.Name = "layerControlPanel";
            layerControlPanel.Size = new Size(175, 27);
            layerControlPanel.TabIndex = 1;
            // 
            // createLayerBtn
            // 
            createLayerBtn.Anchor = AnchorStyles.None;
            createLayerBtn.BackColor = Color.Transparent;
            createLayerBtn.BackgroundImage = Properties.Resources.add_layer;
            createLayerBtn.BackgroundImageLayout = ImageLayout.Zoom;
            createLayerBtn.FlatAppearance.MouseDownBackColor = Color.Silver;
            createLayerBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            createLayerBtn.FlatStyle = FlatStyle.Flat;
            createLayerBtn.ForeColor = Color.Transparent;
            createLayerBtn.Location = new Point(3, 3);
            createLayerBtn.Name = "createLayerBtn";
            createLayerBtn.Size = new Size(27, 23);
            createLayerBtn.TabIndex = 0;
            createLayerBtn.UseVisualStyleBackColor = false;
            // 
            // deleteLayerBtn
            // 
            deleteLayerBtn.Anchor = AnchorStyles.None;
            deleteLayerBtn.BackColor = Color.Transparent;
            deleteLayerBtn.BackgroundImage = Properties.Resources.delete_layer;
            deleteLayerBtn.BackgroundImageLayout = ImageLayout.Zoom;
            deleteLayerBtn.FlatAppearance.MouseDownBackColor = Color.Silver;
            deleteLayerBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            deleteLayerBtn.FlatStyle = FlatStyle.Flat;
            deleteLayerBtn.ForeColor = Color.Transparent;
            deleteLayerBtn.Location = new Point(36, 3);
            deleteLayerBtn.Name = "deleteLayerBtn";
            deleteLayerBtn.Size = new Size(27, 23);
            deleteLayerBtn.TabIndex = 1;
            deleteLayerBtn.UseVisualStyleBackColor = false;
            // 
            // duplicateLayerBtn
            // 
            duplicateLayerBtn.Anchor = AnchorStyles.None;
            duplicateLayerBtn.BackColor = Color.Transparent;
            duplicateLayerBtn.BackgroundImage = Properties.Resources.duplicate;
            duplicateLayerBtn.BackgroundImageLayout = ImageLayout.Zoom;
            duplicateLayerBtn.FlatAppearance.MouseDownBackColor = Color.Silver;
            duplicateLayerBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            duplicateLayerBtn.FlatStyle = FlatStyle.Flat;
            duplicateLayerBtn.ForeColor = Color.Transparent;
            duplicateLayerBtn.Location = new Point(69, 3);
            duplicateLayerBtn.Name = "duplicateLayerBtn";
            duplicateLayerBtn.Size = new Size(27, 23);
            duplicateLayerBtn.TabIndex = 2;
            duplicateLayerBtn.UseVisualStyleBackColor = false;
            // 
            // moveUpLayerBtn
            // 
            moveUpLayerBtn.Anchor = AnchorStyles.None;
            moveUpLayerBtn.BackColor = Color.Transparent;
            moveUpLayerBtn.BackgroundImage = Properties.Resources.up_arrow;
            moveUpLayerBtn.BackgroundImageLayout = ImageLayout.Zoom;
            moveUpLayerBtn.FlatAppearance.MouseDownBackColor = Color.Silver;
            moveUpLayerBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            moveUpLayerBtn.FlatStyle = FlatStyle.Flat;
            moveUpLayerBtn.ForeColor = Color.Transparent;
            moveUpLayerBtn.Location = new Point(102, 3);
            moveUpLayerBtn.Name = "moveUpLayerBtn";
            moveUpLayerBtn.Size = new Size(27, 23);
            moveUpLayerBtn.TabIndex = 3;
            moveUpLayerBtn.UseVisualStyleBackColor = false;
            // 
            // moveDownLayerBtn
            // 
            moveDownLayerBtn.Anchor = AnchorStyles.None;
            moveDownLayerBtn.BackColor = Color.Transparent;
            moveDownLayerBtn.BackgroundImage = Properties.Resources.down_arrow;
            moveDownLayerBtn.BackgroundImageLayout = ImageLayout.Zoom;
            moveDownLayerBtn.FlatAppearance.MouseDownBackColor = Color.Silver;
            moveDownLayerBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            moveDownLayerBtn.FlatStyle = FlatStyle.Flat;
            moveDownLayerBtn.ForeColor = Color.Transparent;
            moveDownLayerBtn.Location = new Point(135, 3);
            moveDownLayerBtn.Name = "moveDownLayerBtn";
            moveDownLayerBtn.Size = new Size(27, 23);
            moveDownLayerBtn.TabIndex = 4;
            moveDownLayerBtn.UseVisualStyleBackColor = false;
            // 
            // allLayersPanel
            // 
            allLayersPanel.AutoScroll = true;
            allLayersPanel.Dock = DockStyle.Bottom;
            allLayersPanel.FlowDirection = FlowDirection.BottomUp;
            allLayersPanel.Location = new Point(0, 95);
            allLayersPanel.Name = "allLayersPanel";
            allLayersPanel.Size = new Size(175, 180);
            allLayersPanel.TabIndex = 2;
            allLayersPanel.WrapContents = false;
            // 
            // LayersWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            MaximumSize = new Size(175, 225);
            MinimumSize = new Size(175, 225);
            Name = "LayersWindow";
            Size = new Size(175, 225);
            contentPanel.ResumeLayout(false);
            topPanel.ResumeLayout(false);
            layerControlPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel layerControlPanel;
        private Button createLayerBtn;
        private FlowLayoutPanel allLayersPanel;
        private Button deleteLayerBtn;
        private Button duplicateLayerBtn;
        private Button moveUpLayerBtn;
        private Button moveDownLayerBtn;
    }
}
