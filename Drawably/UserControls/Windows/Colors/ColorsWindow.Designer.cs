namespace Drawably.UserControls.Windows.Colors
{
    partial class ColorsWindow
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
            tableLayoutPanel1 = new TableLayoutPanel();
            rightColorButton = new Button();
            leftColorButton = new Button();
            colorBtnHolder = new Panel();
            switchColorsButton = new Button();
            contentPanel.SuspendLayout();
            topPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            colorBtnHolder.SuspendLayout();
            SuspendLayout();
            // 
            // contentPanel
            // 
            contentPanel.Controls.Add(switchColorsButton);
            contentPanel.Controls.Add(colorBtnHolder);
            contentPanel.Location = new Point(0, -58);
            contentPanel.Size = new Size(168, 302);
            // 
            // topPanel
            // 
            topPanel.Size = new Size(168, 23);
            // 
            // menuTextLabel
            // 
            menuTextLabel.Size = new Size(478, 23);
            // 
            // closeButton
            // 
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.Location = new Point(142, 0);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(rightColorButton, 1, 0);
            tableLayoutPanel1.Controls.Add(leftColorButton, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(168, 211);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // rightColorButton
            // 
            rightColorButton.Anchor = AnchorStyles.None;
            rightColorButton.BackColor = Color.White;
            rightColorButton.Cursor = Cursors.Hand;
            rightColorButton.FlatStyle = FlatStyle.Flat;
            rightColorButton.Location = new Point(88, 70);
            rightColorButton.Name = "rightColorButton";
            rightColorButton.Size = new Size(75, 70);
            rightColorButton.TabIndex = 1;
            rightColorButton.UseVisualStyleBackColor = false;
            rightColorButton.Click += rightColorButton_Click;
            // 
            // leftColorButton
            // 
            leftColorButton.Anchor = AnchorStyles.None;
            leftColorButton.BackColor = Color.Black;
            leftColorButton.Cursor = Cursors.Hand;
            leftColorButton.FlatStyle = FlatStyle.Flat;
            leftColorButton.Location = new Point(4, 70);
            leftColorButton.Name = "leftColorButton";
            leftColorButton.Size = new Size(75, 70);
            leftColorButton.TabIndex = 0;
            leftColorButton.UseVisualStyleBackColor = false;
            leftColorButton.Click += leftColorButton_Click;
            // 
            // colorBtnHolder
            // 
            colorBtnHolder.Controls.Add(tableLayoutPanel1);
            colorBtnHolder.Location = new Point(0, 78);
            colorBtnHolder.Name = "colorBtnHolder";
            colorBtnHolder.Size = new Size(168, 211);
            colorBtnHolder.TabIndex = 3;
            // 
            // switchColorsButton
            // 
            switchColorsButton.BackColor = Color.Black;
            switchColorsButton.FlatAppearance.BorderSize = 0;
            switchColorsButton.FlatStyle = FlatStyle.Flat;
            switchColorsButton.ForeColor = Color.White;
            switchColorsButton.Location = new Point(28, 253);
            switchColorsButton.Name = "switchColorsButton";
            switchColorsButton.Size = new Size(114, 28);
            switchColorsButton.TabIndex = 4;
            switchColorsButton.Text = "Switch";
            switchColorsButton.UseVisualStyleBackColor = false;
            switchColorsButton.Click += switchColorsButton_Click;
            // 
            // ColorsWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Name = "ColorsWindow";
            Size = new Size(168, 244);
            contentPanel.ResumeLayout(false);
            topPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            colorBtnHolder.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button rightColorButton;
        private Button leftColorButton;
        private Panel colorBtnHolder;
        private Button switchColorsButton;
    }
}
