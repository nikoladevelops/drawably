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
            cancelBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            createShapeBtn = new Button();
            heightComboBox = new ComboBox();
            widthComboBox = new ComboBox();
            shapeNameLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            borderSizeComboBox = new ComboBox();
            fillShapeCheckBox = new CheckBox();
            contentPanel.SuspendLayout();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // contentPanel
            // 
            contentPanel.Controls.Add(shapeNameLabel);
            contentPanel.Controls.Add(label3);
            contentPanel.Controls.Add(fillShapeCheckBox);
            contentPanel.Controls.Add(borderSizeComboBox);
            contentPanel.Controls.Add(label4);
            contentPanel.Controls.Add(heightComboBox);
            contentPanel.Controls.Add(label2);
            contentPanel.Controls.Add(label1);
            contentPanel.Controls.Add(cancelBtn);
            contentPanel.Controls.Add(widthComboBox);
            contentPanel.Controls.Add(createShapeBtn);
            contentPanel.Location = new Point(0, -61);
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
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.Gray;
            cancelBtn.FlatAppearance.BorderSize = 0;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.ForeColor = Color.White;
            cancelBtn.Location = new Point(138, 276);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 23);
            cancelBtn.TabIndex = 3;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(55, 138);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Width";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(55, 171);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Height";
            // 
            // createShapeBtn
            // 
            createShapeBtn.BackColor = Color.FromArgb(0, 0, 192);
            createShapeBtn.FlatAppearance.BorderSize = 0;
            createShapeBtn.FlatStyle = FlatStyle.Flat;
            createShapeBtn.ForeColor = Color.White;
            createShapeBtn.Location = new Point(35, 276);
            createShapeBtn.Name = "createShapeBtn";
            createShapeBtn.Size = new Size(94, 23);
            createShapeBtn.TabIndex = 2;
            createShapeBtn.Text = "Create";
            createShapeBtn.UseVisualStyleBackColor = false;
            createShapeBtn.Click += createShapeBtn_Click;
            // 
            // heightComboBox
            // 
            heightComboBox.FormattingEnabled = true;
            heightComboBox.Location = new Point(126, 163);
            heightComboBox.Name = "heightComboBox";
            heightComboBox.Size = new Size(94, 23);
            heightComboBox.TabIndex = 5;
            // 
            // widthComboBox
            // 
            widthComboBox.FormattingEnabled = true;
            widthComboBox.Location = new Point(126, 130);
            widthComboBox.Name = "widthComboBox";
            widthComboBox.Size = new Size(94, 23);
            widthComboBox.TabIndex = 4;
            // 
            // shapeNameLabel
            // 
            shapeNameLabel.AutoSize = true;
            shapeNameLabel.ForeColor = Color.White;
            shapeNameLabel.Location = new Point(110, 106);
            shapeNameLabel.Name = "shapeNameLabel";
            shapeNameLabel.Size = new Size(122, 15);
            shapeNameLabel.TabIndex = 1;
            shapeNameLabel.Text = "ShapeNameGoesHere";
            shapeNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(56, 106);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Shape:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(55, 205);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 6;
            label4.Text = "Border Size";
            // 
            // borderSizeComboBox
            // 
            borderSizeComboBox.FormattingEnabled = true;
            borderSizeComboBox.Location = new Point(126, 197);
            borderSizeComboBox.Name = "borderSizeComboBox";
            borderSizeComboBox.Size = new Size(94, 23);
            borderSizeComboBox.TabIndex = 7;
            // 
            // fillShapeCheckBox
            // 
            fillShapeCheckBox.AutoSize = true;
            fillShapeCheckBox.ForeColor = Color.White;
            fillShapeCheckBox.Location = new Point(86, 240);
            fillShapeCheckBox.Name = "fillShapeCheckBox";
            fillShapeCheckBox.Size = new Size(76, 19);
            fillShapeCheckBox.TabIndex = 8;
            fillShapeCheckBox.Text = "Fill Shape";
            fillShapeCheckBox.UseVisualStyleBackColor = true;
            // 
            // DrawSelectedShapeMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Name = "DrawSelectedShapeMenu";
            Size = new Size(258, 241);
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            topPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button cancelBtn;
        private Button createShapeBtn;
        private ComboBox heightComboBox;
        private ComboBox widthComboBox;
        private Label label3;
        private Label shapeNameLabel;
        private ComboBox borderSizeComboBox;
        private Label label4;
        private CheckBox fillShapeCheckBox;
    }
}
