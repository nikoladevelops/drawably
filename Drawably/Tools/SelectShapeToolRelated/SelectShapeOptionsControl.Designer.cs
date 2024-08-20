namespace Drawably.Tools.SelectShapeToolRelated
{
    partial class SelectShapeOptionsControl
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
            label1 = new Label();
            amountShapesSelectedLabel = new Label();
            deleteSelectedBtn = new Button();
            clearAllSelectedBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Shapes selected: ";
            // 
            // amountShapesSelectedLabel
            // 
            amountShapesSelectedLabel.AutoSize = true;
            amountShapesSelectedLabel.ForeColor = Color.White;
            amountShapesSelectedLabel.Location = new Point(93, 9);
            amountShapesSelectedLabel.Name = "amountShapesSelectedLabel";
            amountShapesSelectedLabel.Size = new Size(13, 15);
            amountShapesSelectedLabel.TabIndex = 1;
            amountShapesSelectedLabel.Text = "0";
            // 
            // deleteSelectedBtn
            // 
            deleteSelectedBtn.BackColor = Color.IndianRed;
            deleteSelectedBtn.FlatStyle = FlatStyle.Flat;
            deleteSelectedBtn.Location = new Point(654, 2);
            deleteSelectedBtn.Name = "deleteSelectedBtn";
            deleteSelectedBtn.Size = new Size(105, 26);
            deleteSelectedBtn.TabIndex = 4;
            deleteSelectedBtn.Text = "Delete Selected";
            deleteSelectedBtn.UseVisualStyleBackColor = false;
            deleteSelectedBtn.Click += deleteSelectedBtn_Click;
            // 
            // clearAllSelectedBtn
            // 
            clearAllSelectedBtn.BackColor = Color.White;
            clearAllSelectedBtn.FlatStyle = FlatStyle.Flat;
            clearAllSelectedBtn.Location = new Point(546, 2);
            clearAllSelectedBtn.Name = "clearAllSelectedBtn";
            clearAllSelectedBtn.Size = new Size(102, 26);
            clearAllSelectedBtn.TabIndex = 5;
            clearAllSelectedBtn.Text = "Clear Selection";
            clearAllSelectedBtn.UseVisualStyleBackColor = false;
            clearAllSelectedBtn.Click += clearAllSelectedBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(136, 9);
            label2.Name = "label2";
            label2.Size = new Size(159, 15);
            label2.TabIndex = 6;
            label2.Text = "Left Mouse Btn: Select Shape";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(327, 9);
            label3.Name = "label3";
            label3.Size = new Size(180, 15);
            label3.TabIndex = 7;
            label3.Text = "Right Mouse Btn: Deselect Shape";
            // 
            // SelectShapeOptionsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(clearAllSelectedBtn);
            Controls.Add(deleteSelectedBtn);
            Controls.Add(amountShapesSelectedLabel);
            Controls.Add(label1);
            Name = "SelectShapeOptionsControl";
            Size = new Size(827, 31);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label amountShapesSelectedLabel;
        private Button deleteSelectedBtn;
        private Button clearAllSelectedBtn;
        private Label label2;
        private Label label3;
    }
}
