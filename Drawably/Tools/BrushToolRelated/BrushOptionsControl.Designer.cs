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
            label2 = new Label();
            opacityTrackBar = new TrackBar();
            opacityValueLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)opacityTrackBar).BeginInit();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(207, 8);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 2;
            label2.Text = "Opacity";
            // 
            // opacityTrackBar
            // 
            opacityTrackBar.BackColor = Color.Black;
            opacityTrackBar.Location = new Point(250, 8);
            opacityTrackBar.Maximum = 100;
            opacityTrackBar.Name = "opacityTrackBar";
            opacityTrackBar.Size = new Size(99, 45);
            opacityTrackBar.TabIndex = 4;
            opacityTrackBar.TickStyle = TickStyle.None;
            // 
            // opacityValueLabel
            // 
            opacityValueLabel.AutoSize = true;
            opacityValueLabel.ForeColor = Color.White;
            opacityValueLabel.Location = new Point(349, 8);
            opacityValueLabel.Name = "opacityValueLabel";
            opacityValueLabel.Size = new Size(86, 15);
            opacityValueLabel.TabIndex = 5;
            opacityValueLabel.Text = "ValueGoesHere";
            // 
            // BrushOptionsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(opacityValueLabel);
            Controls.Add(opacityTrackBar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(brushSizeComboBox);
            Name = "BrushOptionsControl";
            Size = new Size(460, 30);
            ((System.ComponentModel.ISupportInitialize)opacityTrackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox brushSizeComboBox;
        private Label label1;
        private Label label2;
        private TrackBar opacityTrackBar;
        private Label opacityValueLabel;
    }
}
