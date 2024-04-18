namespace Drawably
{
    partial class MenuWindow
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
            dragPanel = new Panel();
            topPanel = new Panel();
            label1 = new Label();
            contentPanel = new Panel();
            dragPanel.SuspendLayout();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // dragPanel
            // 
            dragPanel.BackColor = Color.Black;
            dragPanel.Controls.Add(topPanel);
            dragPanel.Controls.Add(contentPanel);
            dragPanel.Dock = DockStyle.Fill;
            dragPanel.Location = new Point(0, 0);
            dragPanel.Name = "dragPanel";
            dragPanel.Size = new Size(504, 321);
            dragPanel.TabIndex = 1;
            dragPanel.Paint += dragPanel_Paint;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.Gainsboro;
            topPanel.Controls.Add(label1);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(504, 22);
            topPanel.TabIndex = 3;
            // 
            // label1
            // 
            label1.BackColor = Color.LightCoral;
            label1.Dock = DockStyle.Right;
            label1.Location = new Point(479, 0);
            label1.Name = "label1";
            label1.Size = new Size(25, 22);
            label1.TabIndex = 2;
            label1.Text = "X";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(64, 64, 64);
            contentPanel.Dock = DockStyle.Bottom;
            contentPanel.Location = new Point(0, 19);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(504, 302);
            contentPanel.TabIndex = 0;
            // 
            // MenuWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(dragPanel);
            Name = "MenuWindow";
            Size = new Size(504, 321);
            Load += menuWindowLoad;
            dragPanel.ResumeLayout(false);
            topPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel dragPanel;
        private Label label1;
        private Panel contentPanel;
        private Panel topPanel;
    }
}
