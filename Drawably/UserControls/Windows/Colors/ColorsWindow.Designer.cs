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
            leftColorOpacityPercentageLabel = new Label();
            rightColorOpacityPercentageLabel = new Label();
            rightColorOpacityTrackBar = new TrackBar();
            label2 = new Label();
            label1 = new Label();
            leftColorOpacityTrackBar = new TrackBar();
            rightColorButton = new Button();
            leftColorButton = new Button();
            colorBtnHolder = new Panel();
            switchColorsButton = new Button();
            contentPanel.SuspendLayout();
            topPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rightColorOpacityTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftColorOpacityTrackBar).BeginInit();
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
            tableLayoutPanel1.Controls.Add(leftColorOpacityPercentageLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(rightColorOpacityPercentageLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(rightColorOpacityTrackBar, 1, 2);
            tableLayoutPanel1.Controls.Add(label2, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(leftColorOpacityTrackBar, 0, 2);
            tableLayoutPanel1.Controls.Add(rightColorButton, 1, 0);
            tableLayoutPanel1.Controls.Add(leftColorButton, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 86.02941F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.9705887F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(168, 175);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // firstColorOpacityPercentageLabel
            // 
            leftColorOpacityPercentageLabel.AutoSize = true;
            leftColorOpacityPercentageLabel.Dock = DockStyle.Fill;
            leftColorOpacityPercentageLabel.ForeColor = Color.White;
            leftColorOpacityPercentageLabel.Location = new Point(3, 154);
            leftColorOpacityPercentageLabel.Name = "firstColorOpacityPercentageLabel";
            leftColorOpacityPercentageLabel.Size = new Size(78, 21);
            leftColorOpacityPercentageLabel.TabIndex = 10;
            leftColorOpacityPercentageLabel.Text = "100%";
            leftColorOpacityPercentageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // secondColorOpacityPercentageLabel
            // 
            rightColorOpacityPercentageLabel.AutoSize = true;
            rightColorOpacityPercentageLabel.Dock = DockStyle.Fill;
            rightColorOpacityPercentageLabel.ForeColor = Color.White;
            rightColorOpacityPercentageLabel.Location = new Point(87, 154);
            rightColorOpacityPercentageLabel.Name = "secondColorOpacityPercentageLabel";
            rightColorOpacityPercentageLabel.Size = new Size(78, 21);
            rightColorOpacityPercentageLabel.TabIndex = 9;
            rightColorOpacityPercentageLabel.Text = "100%";
            rightColorOpacityPercentageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // secondColorOpacityTrackBar
            // 
            rightColorOpacityTrackBar.Location = new Point(87, 127);
            rightColorOpacityTrackBar.Maximum = 255;
            rightColorOpacityTrackBar.Name = "secondColorOpacityTrackBar";
            rightColorOpacityTrackBar.Size = new Size(78, 24);
            rightColorOpacityTrackBar.TabIndex = 8;
            rightColorOpacityTrackBar.TickStyle = TickStyle.None;
            rightColorOpacityTrackBar.Value = 255;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.ForeColor = Color.White;
            label2.Location = new Point(87, 107);
            label2.Name = "label2";
            label2.Size = new Size(78, 17);
            label2.TabIndex = 7;
            label2.Text = "Opacity";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 107);
            label1.Name = "label1";
            label1.Size = new Size(78, 17);
            label1.TabIndex = 6;
            label1.Text = "Opacity";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // firstColorOpacityTrackBar
            // 
            leftColorOpacityTrackBar.Location = new Point(3, 127);
            leftColorOpacityTrackBar.Maximum = 255;
            leftColorOpacityTrackBar.Name = "firstColorOpacityTrackBar";
            leftColorOpacityTrackBar.Size = new Size(78, 24);
            leftColorOpacityTrackBar.TabIndex = 5;
            leftColorOpacityTrackBar.TickStyle = TickStyle.None;
            leftColorOpacityTrackBar.Value = 255;
            // 
            // rightColorButton
            // 
            rightColorButton.Anchor = AnchorStyles.None;
            rightColorButton.BackColor = Color.White;
            rightColorButton.Cursor = Cursors.Hand;
            rightColorButton.FlatStyle = FlatStyle.Flat;
            rightColorButton.Location = new Point(88, 18);
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
            leftColorButton.Location = new Point(4, 18);
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
            colorBtnHolder.Size = new Size(168, 175);
            colorBtnHolder.TabIndex = 3;
            // 
            // switchColorsButton
            // 
            switchColorsButton.BackColor = Color.Black;
            switchColorsButton.FlatAppearance.BorderSize = 0;
            switchColorsButton.FlatStyle = FlatStyle.Flat;
            switchColorsButton.ForeColor = Color.White;
            switchColorsButton.Location = new Point(28, 268);
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
            MinimumSize = new Size(168, 244);
            Name = "ColorsWindow";
            Size = new Size(168, 244);
            contentPanel.ResumeLayout(false);
            topPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)rightColorOpacityTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftColorOpacityTrackBar).EndInit();
            colorBtnHolder.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button rightColorButton;
        private Button leftColorButton;
        private Panel colorBtnHolder;
        private Button switchColorsButton;
        private Label label1;
        private TrackBar leftColorOpacityTrackBar;
        private Label leftColorOpacityPercentageLabel;
        private Label rightColorOpacityPercentageLabel;
        private TrackBar rightColorOpacityTrackBar;
        private Label label2;
    }
}
