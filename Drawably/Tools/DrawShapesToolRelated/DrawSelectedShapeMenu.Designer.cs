namespace Drawably.Tools.DrawShapesToolRelated
{
    partial class DrawSelectedShapeMenu
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
            tableLayoutPanel1 = new TableLayoutPanel();
            cancelBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            createShapeBtn = new Button();
            heightComboBox = new ComboBox();
            widthComboBox = new ComboBox();
            shapeNameLabel = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label3 = new Label();
            contentPanel.SuspendLayout();
            topPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // contentPanel
            // 
            contentPanel.Controls.Add(tableLayoutPanel1);
            contentPanel.Controls.Add(flowLayoutPanel1);
            contentPanel.Location = new Point(0, -100);
            contentPanel.Size = new Size(258, 302);
            // 
            // topPanel
            // 
            topPanel.Size = new Size(258, 23);
            // 
            // menuTextLabel
            // 
            menuTextLabel.Size = new Size(478, 23);
            menuTextLabel.Text = "Draw Shape Menu";
            // 
            // closeButton
            // 
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.Location = new Point(232, 0);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(cancelBtn, 1, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(createShapeBtn, 0, 2);
            tableLayoutPanel1.Controls.Add(heightComboBox, 1, 1);
            tableLayoutPanel1.Controls.Add(widthComboBox, 1, 0);
            tableLayoutPanel1.Location = new Point(32, 153);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52.3076935F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.6923065F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 66F));
            tableLayoutPanel1.Size = new Size(200, 161);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.None;
            cancelBtn.BackColor = Color.Gray;
            cancelBtn.FlatAppearance.BorderSize = 0;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.ForeColor = Color.White;
            cancelBtn.Location = new Point(103, 116);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 23);
            cancelBtn.TabIndex = 3;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 17);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Width";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(28, 64);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Height";
            // 
            // createShapeBtn
            // 
            createShapeBtn.Anchor = AnchorStyles.None;
            createShapeBtn.BackColor = Color.FromArgb(0, 0, 192);
            createShapeBtn.FlatAppearance.BorderSize = 0;
            createShapeBtn.FlatStyle = FlatStyle.Flat;
            createShapeBtn.ForeColor = Color.White;
            createShapeBtn.Location = new Point(3, 116);
            createShapeBtn.Name = "createShapeBtn";
            createShapeBtn.Size = new Size(94, 23);
            createShapeBtn.TabIndex = 2;
            createShapeBtn.Text = "Create";
            createShapeBtn.UseVisualStyleBackColor = false;
            createShapeBtn.Click += createShapeBtn_Click;
            // 
            // heightComboBox
            // 
            heightComboBox.Anchor = AnchorStyles.None;
            heightComboBox.FormattingEnabled = true;
            heightComboBox.Location = new Point(103, 60);
            heightComboBox.Name = "heightComboBox";
            heightComboBox.Size = new Size(94, 23);
            heightComboBox.TabIndex = 5;
            // 
            // widthComboBox
            // 
            widthComboBox.Anchor = AnchorStyles.None;
            widthComboBox.FormattingEnabled = true;
            widthComboBox.Location = new Point(103, 13);
            widthComboBox.Name = "widthComboBox";
            widthComboBox.Size = new Size(94, 23);
            widthComboBox.TabIndex = 4;
            // 
            // shapeNameLabel
            // 
            shapeNameLabel.Anchor = AnchorStyles.Left;
            shapeNameLabel.AutoSize = true;
            shapeNameLabel.ForeColor = Color.White;
            shapeNameLabel.Location = new Point(51, 0);
            shapeNameLabel.Name = "shapeNameLabel";
            shapeNameLabel.Size = new Size(122, 15);
            shapeNameLabel.TabIndex = 1;
            shapeNameLabel.Text = "ShapeNameGoesHere";
            shapeNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(shapeNameLabel);
            flowLayoutPanel1.Location = new Point(35, 132);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(194, 28);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Shape:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DrawSelectedShapeMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Name = "DrawSelectedShapeMenu";
            Size = new Size(258, 202);
            contentPanel.ResumeLayout(false);
            topPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Button cancelBtn;
        private Button createShapeBtn;
        private ComboBox heightComboBox;
        private ComboBox widthComboBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label3;
        private Label shapeNameLabel;
    }
}
