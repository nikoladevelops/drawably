namespace Drawably
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuWindow1 = new MenuWindow();
            menuWindow2 = new MenuWindow();
            SuspendLayout();
            // 
            // menuWindow1
            // 
            menuWindow1.BackColor = SystemColors.ActiveCaption;
            menuWindow1.Location = new Point(46, 62);
            menuWindow1.Name = "menuWindow1";
            menuWindow1.Size = new Size(510, 329);
            menuWindow1.TabIndex = 1;
            // 
            // menuWindow2
            // 
            menuWindow2.BackColor = SystemColors.ActiveCaption;
            menuWindow2.Location = new Point(253, 238);
            menuWindow2.Name = "menuWindow2";
            menuWindow2.Size = new Size(504, 321);
            menuWindow2.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1302, 629);
            Controls.Add(menuWindow2);
            Controls.Add(menuWindow1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Drawably";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private MenuWindow menuWindow1;
        private MenuWindow menuWindow2;
    }
}