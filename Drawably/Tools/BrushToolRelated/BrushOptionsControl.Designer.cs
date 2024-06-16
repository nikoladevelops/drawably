namespace Drawably.Tools.BrushToolRelated
{
    partial class BrushOptionsControl
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
            brushSizeComboBox = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // brushSizeComboBox
            // 
            brushSizeComboBox.FormattingEnabled = true;
            brushSizeComboBox.Location = new Point(83, 5);
            brushSizeComboBox.Name = "brushSizeComboBox";
            brushSizeComboBox.Size = new Size(45, 23);
            brushSizeComboBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(17, 8);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Brush Size";
            // 
            // BrushOptionsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(label1);
            Controls.Add(brushSizeComboBox);
            Name = "BrushOptionsControl";
            Size = new Size(460, 30);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox brushSizeComboBox;
        private Label label1;
    }
}
