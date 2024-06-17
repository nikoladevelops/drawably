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
            rotatePlus90DegreesBtn = new Button();
            rotateMinus90DegreesBtn = new Button();
            deleteSelectedBtn = new Button();
            clearAllSelectedBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Shapes selected: ";
            // 
            // amountShapesSelectedLabel
            // 
            amountShapesSelectedLabel.AutoSize = true;
            amountShapesSelectedLabel.ForeColor = Color.White;
            amountShapesSelectedLabel.Location = new Point(98, 11);
            amountShapesSelectedLabel.Name = "amountShapesSelectedLabel";
            amountShapesSelectedLabel.Size = new Size(13, 15);
            amountShapesSelectedLabel.TabIndex = 1;
            amountShapesSelectedLabel.Text = "0";
            // 
            // rotatePlus90DegreesBtn
            // 
            rotatePlus90DegreesBtn.BackColor = Color.White;
            rotatePlus90DegreesBtn.FlatStyle = FlatStyle.Flat;
            rotatePlus90DegreesBtn.Location = new Point(130, 5);
            rotatePlus90DegreesBtn.Name = "rotatePlus90DegreesBtn";
            rotatePlus90DegreesBtn.Size = new Size(109, 26);
            rotatePlus90DegreesBtn.TabIndex = 2;
            rotatePlus90DegreesBtn.Text = "Rotate +90deg";
            rotatePlus90DegreesBtn.UseVisualStyleBackColor = false;
            rotatePlus90DegreesBtn.Click += rotatePlus90DegreesBtn_Click;
            // 
            // rotateMinus90DegreesBtn
            // 
            rotateMinus90DegreesBtn.BackColor = Color.White;
            rotateMinus90DegreesBtn.FlatStyle = FlatStyle.Flat;
            rotateMinus90DegreesBtn.Location = new Point(245, 5);
            rotateMinus90DegreesBtn.Name = "rotateMinus90DegreesBtn";
            rotateMinus90DegreesBtn.Size = new Size(109, 26);
            rotateMinus90DegreesBtn.TabIndex = 3;
            rotateMinus90DegreesBtn.Text = "Rotate -90deg";
            rotateMinus90DegreesBtn.UseVisualStyleBackColor = false;
            rotateMinus90DegreesBtn.Click += rotateMinus90DegreesBtn_Click;
            // 
            // deleteSelectedBtn
            // 
            deleteSelectedBtn.BackColor = Color.IndianRed;
            deleteSelectedBtn.FlatStyle = FlatStyle.Flat;
            deleteSelectedBtn.Location = new Point(468, 5);
            deleteSelectedBtn.Name = "deleteSelectedBtn";
            deleteSelectedBtn.Size = new Size(74, 26);
            deleteSelectedBtn.TabIndex = 4;
            deleteSelectedBtn.Text = "Delete All";
            deleteSelectedBtn.UseVisualStyleBackColor = false;
            deleteSelectedBtn.Click += deleteSelectedBtn_Click;
            // 
            // clearAllSelectedBtn
            // 
            clearAllSelectedBtn.BackColor = Color.White;
            clearAllSelectedBtn.FlatStyle = FlatStyle.Flat;
            clearAllSelectedBtn.Location = new Point(360, 5);
            clearAllSelectedBtn.Name = "clearAllSelectedBtn";
            clearAllSelectedBtn.Size = new Size(102, 26);
            clearAllSelectedBtn.TabIndex = 5;
            clearAllSelectedBtn.Text = "Clear Selection";
            clearAllSelectedBtn.UseVisualStyleBackColor = false;
            clearAllSelectedBtn.Click += clearAllSelectedBtn_Click;
            // 
            // SelectShapeOptionsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(clearAllSelectedBtn);
            Controls.Add(deleteSelectedBtn);
            Controls.Add(rotateMinus90DegreesBtn);
            Controls.Add(rotatePlus90DegreesBtn);
            Controls.Add(amountShapesSelectedLabel);
            Controls.Add(label1);
            Name = "SelectShapeOptionsControl";
            Size = new Size(554, 31);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label amountShapesSelectedLabel;
        private Button rotatePlus90DegreesBtn;
        private Button rotateMinus90DegreesBtn;
        private Button deleteSelectedBtn;
        private Button clearAllSelectedBtn;
    }
}
