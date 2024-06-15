namespace Drawably.UserControls
{
    partial class Canvas
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
            canvasPictureBox = new PictureBox();
            backgroundPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)canvasPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backgroundPictureBox).BeginInit();
            SuspendLayout();
            // 
            // canvasPictureBox
            // 
            canvasPictureBox.BackColor = Color.Transparent;
            canvasPictureBox.Dock = DockStyle.Fill;
            canvasPictureBox.Location = new Point(0, 0);
            canvasPictureBox.Name = "canvasPictureBox";
            canvasPictureBox.Size = new Size(559, 332);
            canvasPictureBox.TabIndex = 0;
            canvasPictureBox.TabStop = false;
            // 
            // backgroundPictureBox
            // 
            backgroundPictureBox.BackgroundImage = Properties.Resources.squares;
            backgroundPictureBox.Dock = DockStyle.Fill;
            backgroundPictureBox.Location = new Point(0, 0);
            backgroundPictureBox.Name = "backgroundPictureBox";
            backgroundPictureBox.Size = new Size(559, 332);
            backgroundPictureBox.TabIndex = 1;
            backgroundPictureBox.TabStop = false;
            // 
            // Canvas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(canvasPictureBox);
            Controls.Add(backgroundPictureBox);
            Name = "Canvas";
            Size = new Size(559, 332);
            ((System.ComponentModel.ISupportInitialize)canvasPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)backgroundPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox canvasPictureBox;
        private PictureBox backgroundPictureBox;
    }
}
