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
            layerLabel6 = new LayerLabel();
            layerLabel7 = new LayerLabel();
            layerLabel8 = new LayerLabel();
            layerLabel9 = new LayerLabel();
            layerLabel10 = new LayerLabel();
            layerLabel11 = new LayerLabel();
            layerLabel1 = new LayerLabel();
            layerLabel2 = new LayerLabel();
            contentPanel.SuspendLayout();
            topPanel.SuspendLayout();
            layerControlPanel.SuspendLayout();
            allLayersPanel.SuspendLayout();
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
            allLayersPanel.Controls.Add(layerLabel6);
            allLayersPanel.Controls.Add(layerLabel7);
            allLayersPanel.Controls.Add(layerLabel8);
            allLayersPanel.Controls.Add(layerLabel9);
            allLayersPanel.Controls.Add(layerLabel10);
            allLayersPanel.Controls.Add(layerLabel11);
            allLayersPanel.Controls.Add(layerLabel1);
            allLayersPanel.Controls.Add(layerLabel2);
            allLayersPanel.Dock = DockStyle.Bottom;
            allLayersPanel.FlowDirection = FlowDirection.BottomUp;
            allLayersPanel.Location = new Point(0, 98);
            allLayersPanel.Name = "allLayersPanel";
            allLayersPanel.Size = new Size(175, 177);
            allLayersPanel.TabIndex = 2;
            allLayersPanel.WrapContents = false;
            // 
            // layerLabel6
            // 
            layerLabel6.BackColor = Color.Transparent;
            layerLabel6.IsLayerSelected = false;
            layerLabel6.IsLayerVisible = false;
            layerLabel6.LayerName = "LayerNameGoesHere";
            layerLabel6.Location = new Point(3, 192);
            layerLabel6.Name = "layerLabel6";
            layerLabel6.Size = new Size(151, 21);
            layerLabel6.TabIndex = 26;
            // 
            // layerLabel7
            // 
            layerLabel7.BackColor = Color.Transparent;
            layerLabel7.IsLayerSelected = false;
            layerLabel7.IsLayerVisible = false;
            layerLabel7.LayerName = "LayerNameGoesHere";
            layerLabel7.Location = new Point(3, 165);
            layerLabel7.Name = "layerLabel7";
            layerLabel7.Size = new Size(151, 21);
            layerLabel7.TabIndex = 27;
            // 
            // layerLabel8
            // 
            layerLabel8.BackColor = Color.Transparent;
            layerLabel8.IsLayerSelected = false;
            layerLabel8.IsLayerVisible = false;
            layerLabel8.LayerName = "LayerNameGoesHere";
            layerLabel8.Location = new Point(3, 138);
            layerLabel8.Name = "layerLabel8";
            layerLabel8.Size = new Size(151, 21);
            layerLabel8.TabIndex = 28;
            // 
            // layerLabel9
            // 
            layerLabel9.BackColor = Color.Transparent;
            layerLabel9.IsLayerSelected = false;
            layerLabel9.IsLayerVisible = false;
            layerLabel9.LayerName = "LayerNameGoesHere";
            layerLabel9.Location = new Point(3, 111);
            layerLabel9.Name = "layerLabel9";
            layerLabel9.Size = new Size(151, 21);
            layerLabel9.TabIndex = 29;
            // 
            // layerLabel10
            // 
            layerLabel10.BackColor = Color.Transparent;
            layerLabel10.IsLayerSelected = false;
            layerLabel10.IsLayerVisible = false;
            layerLabel10.LayerName = "LayerNameGoesHere";
            layerLabel10.Location = new Point(3, 84);
            layerLabel10.Name = "layerLabel10";
            layerLabel10.Size = new Size(151, 21);
            layerLabel10.TabIndex = 30;
            // 
            // layerLabel11
            // 
            layerLabel11.BackColor = Color.Transparent;
            layerLabel11.IsLayerSelected = false;
            layerLabel11.IsLayerVisible = false;
            layerLabel11.LayerName = "LayerNameGoesHere";
            layerLabel11.Location = new Point(3, 57);
            layerLabel11.Name = "layerLabel11";
            layerLabel11.Size = new Size(151, 21);
            layerLabel11.TabIndex = 31;
            // 
            // layerLabel1
            // 
            layerLabel1.BackColor = Color.Transparent;
            layerLabel1.IsLayerSelected = false;
            layerLabel1.IsLayerVisible = false;
            layerLabel1.LayerName = "LayerNameGoesHere";
            layerLabel1.Location = new Point(3, 30);
            layerLabel1.Name = "layerLabel1";
            layerLabel1.Size = new Size(151, 21);
            layerLabel1.TabIndex = 32;
            // 
            // layerLabel2
            // 
            layerLabel2.BackColor = Color.Transparent;
            layerLabel2.IsLayerSelected = false;
            layerLabel2.IsLayerVisible = false;
            layerLabel2.LayerName = "LayerNameGoesHere";
            layerLabel2.Location = new Point(3, 3);
            layerLabel2.Name = "layerLabel2";
            layerLabel2.Size = new Size(151, 21);
            layerLabel2.TabIndex = 33;
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
            allLayersPanel.ResumeLayout(false);
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
        private LayerLabel layerLabel6;
        private LayerLabel layerLabel7;
        private LayerLabel layerLabel8;
        private LayerLabel layerLabel9;
        private LayerLabel layerLabel10;
        private LayerLabel layerLabel11;
        private LayerLabel layerLabel1;
        private LayerLabel layerLabel2;
    }
}
