namespace Drawably.UserControls.Windows
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
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // contentPanel
            // 
            contentPanel.Location = new Point(0, -123);
            contentPanel.Size = new Size(162, 302);
            // 
            // topPanel
            // 
            topPanel.Size = new Size(162, 23);
            // 
            // menuTextLabel
            // 
            menuTextLabel.Size = new Size(136, 23);
            // 
            // closeButton
            // 
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.Location = new Point(136, 0);
            // 
            // LayersWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Name = "LayersWindow";
            Size = new Size(162, 179);
            topPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}
