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
            closeButton = new UserControls.HoverButton();
            menuTextLabel = new Label();
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
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.Black;
            topPanel.Controls.Add(closeButton);
            topPanel.Controls.Add(menuTextLabel);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(504, 23);
            topPanel.TabIndex = 3;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.LightCoral;
            closeButton.Dock = DockStyle.Right;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.IsMouseEnterBorderColorEnabled = false;
            closeButton.IsMouseEnterColorEnabled = true;
            closeButton.Location = new Point(478, 0);
            closeButton.Margin = new Padding(0);
            closeButton.MouseEnterBorderColor = Color.Empty;
            closeButton.MouseEnterColor = Color.Salmon;
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(26, 23);
            closeButton.TabIndex = 4;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = false;
            // 
            // menuTextLabel
            // 
            menuTextLabel.AutoEllipsis = true;
            menuTextLabel.Dock = DockStyle.Left;
            menuTextLabel.ForeColor = SystemColors.Control;
            menuTextLabel.Location = new Point(0, 0);
            menuTextLabel.Name = "menuTextLabel";
            menuTextLabel.Padding = new Padding(10, 1, 0, 0);
            menuTextLabel.Size = new Size(143, 23);
            menuTextLabel.TabIndex = 3;
            menuTextLabel.Text = "MenuTextGoesHere";
            menuTextLabel.TextAlign = ContentAlignment.MiddleLeft;
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
        private Panel contentPanel;
        private Panel topPanel;
        private Label menuTextLabel;
        private UserControls.HoverButton closeButton;
    }
}
