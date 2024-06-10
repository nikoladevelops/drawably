namespace Drawably.UserControls.Windows.Layers
{
    partial class LayerLabel
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
            tableLayoutPanel = new TableLayoutPanel();
            layerNameLabel = new Label();
            isLayerVisibleCheckBox = new CheckBox();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.BackColor = Color.Transparent;
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.1212158F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.878788F));
            tableLayoutPanel.Controls.Add(layerNameLabel, 0, 0);
            tableLayoutPanel.Controls.Add(isLayerVisibleCheckBox, 1, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Size = new Size(151, 21);
            tableLayoutPanel.TabIndex = 0;
            // 
            // layerNameLabel
            // 
            layerNameLabel.Anchor = AnchorStyles.Left;
            layerNameLabel.AutoEllipsis = true;
            layerNameLabel.AutoSize = true;
            layerNameLabel.ForeColor = Color.White;
            layerNameLabel.Location = new Point(3, 3);
            layerNameLabel.Name = "layerNameLabel";
            layerNameLabel.Size = new Size(118, 15);
            layerNameLabel.TabIndex = 0;
            layerNameLabel.Text = "LayerNameGoesHere";
            layerNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // isLayerVisibleCheckBox
            // 
            isLayerVisibleCheckBox.Anchor = AnchorStyles.None;
            isLayerVisibleCheckBox.AutoSize = true;
            isLayerVisibleCheckBox.FlatStyle = FlatStyle.Flat;
            isLayerVisibleCheckBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            isLayerVisibleCheckBox.Location = new Point(131, 5);
            isLayerVisibleCheckBox.Name = "isLayerVisibleCheckBox";
            isLayerVisibleCheckBox.Size = new Size(12, 11);
            isLayerVisibleCheckBox.TabIndex = 1;
            isLayerVisibleCheckBox.UseVisualStyleBackColor = true;
            // 
            // LayerLabel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(tableLayoutPanel);
            Name = "LayerLabel";
            Size = new Size(151, 21);
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private Label layerNameLabel;
        private CheckBox isLayerVisibleCheckBox;
    }
}
