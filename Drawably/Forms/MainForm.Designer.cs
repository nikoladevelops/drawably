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
            menuWindow2 = new MenuWindow();
            menuWindow1 = new MenuWindow();
            menuWindow3 = new MenuWindow();
            menuWindow5 = new MenuWindow();
            menuWindow4 = new MenuWindow();
            button1 = new Button();
            customButton1 = new UserControls.HoverButton();
            button2 = new Button();
            SuspendLayout();
            // 
            // menuWindow2
            // 
            menuWindow2.AssociatedButton = null;
            menuWindow2.BackColor = SystemColors.ActiveCaption;
            menuWindow2.Location = new Point(628, 112);
            menuWindow2.MenuText = null;
            menuWindow2.Name = "menuWindow2";
            menuWindow2.Size = new Size(153, 151);
            menuWindow2.TabIndex = 2;
            // 
            // menuWindow1
            // 
            menuWindow1.AssociatedButton = null;
            menuWindow1.BackColor = SystemColors.ActiveCaption;
            menuWindow1.Location = new Point(12, 262);
            menuWindow1.MenuText = null;
            menuWindow1.Name = "menuWindow1";
            menuWindow1.Size = new Size(168, 220);
            menuWindow1.TabIndex = 3;
            // 
            // menuWindow3
            // 
            menuWindow3.AssociatedButton = null;
            menuWindow3.BackColor = SystemColors.ActiveCaption;
            menuWindow3.Location = new Point(12, 12);
            menuWindow3.MenuText = null;
            menuWindow3.Name = "menuWindow3";
            menuWindow3.Size = new Size(158, 145);
            menuWindow3.TabIndex = 4;
            // 
            // menuWindow5
            // 
            menuWindow5.AssociatedButton = null;
            menuWindow5.BackColor = SystemColors.ActiveCaption;
            menuWindow5.Location = new Point(372, 311);
            menuWindow5.MenuText = null;
            menuWindow5.Name = "menuWindow5";
            menuWindow5.Size = new Size(141, 150);
            menuWindow5.TabIndex = 6;
            // 
            // menuWindow4
            // 
            menuWindow4.AssociatedButton = null;
            menuWindow4.BackColor = SystemColors.ActiveCaption;
            menuWindow4.Location = new Point(260, 37);
            menuWindow4.MenuText = "Just Testing Windows";
            menuWindow4.Name = "menuWindow4";
            menuWindow4.Size = new Size(175, 243);
            menuWindow4.TabIndex = 8;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(90, 180);
            button1.Name = "button1";
            button1.Size = new Size(117, 52);
            button1.TabIndex = 9;
            button1.TabStop = false;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // customButton1
            // 
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.IsMouseEnterColorEnabled = true;
            customButton1.Location = new Point(462, 112);
            customButton1.MouseEnterColor = Color.DeepSkyBlue;
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(140, 87);
            customButton1.TabIndex = 10;
            customButton1.Text = "customButton1";
            customButton1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(462, 239);
            button2.Name = "button2";
            button2.Size = new Size(122, 41);
            button2.TabIndex = 11;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1302, 629);
            Controls.Add(button2);
            Controls.Add(customButton1);
            Controls.Add(button1);
            Controls.Add(menuWindow4);
            Controls.Add(menuWindow5);
            Controls.Add(menuWindow3);
            Controls.Add(menuWindow2);
            Controls.Add(menuWindow1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Drawably";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private MenuWindow menuWindow2;
        private MenuWindow menuWindow1;
        private MenuWindow menuWindow3;
        private MenuWindow menuWindow5;
        private MenuWindow menuWindow4;
        private Button button1;
        private UserControls.HoverButton customButton1;
        private Button button2;
    }
}