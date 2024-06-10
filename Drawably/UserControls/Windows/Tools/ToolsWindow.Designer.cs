namespace Drawably.UserControls.Windows.Tools
{
    partial class ToolsWindow
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
            buttonsHolderContainer = new FlowLayoutPanel();
            penBtn = new Button();
            brushBtn = new Button();
            selectBtn = new Button();
            contentPanel.SuspendLayout();
            topPanel.SuspendLayout();
            buttonsHolderContainer.SuspendLayout();
            SuspendLayout();
            // 
            // contentPanel
            // 
            contentPanel.Controls.Add(buttonsHolderContainer);
            contentPanel.Size = new Size(71, 302);
            // 
            // topPanel
            // 
            topPanel.Size = new Size(71, 23);
            // 
            // menuTextLabel
            // 
            menuTextLabel.Size = new Size(478, 23);
            // 
            // closeButton
            // 
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.Location = new Point(45, 0);
            // 
            // buttonsHolderContainer
            // 
            buttonsHolderContainer.Controls.Add(selectBtn);
            buttonsHolderContainer.Controls.Add(penBtn);
            buttonsHolderContainer.Controls.Add(brushBtn);
            buttonsHolderContainer.Dock = DockStyle.Fill;
            buttonsHolderContainer.Location = new Point(0, 0);
            buttonsHolderContainer.Name = "buttonsHolderContainer";
            buttonsHolderContainer.Padding = new Padding(0, 10, 0, 0);
            buttonsHolderContainer.Size = new Size(71, 302);
            buttonsHolderContainer.TabIndex = 1;
            // 
            // penBtn
            // 
            penBtn.BackColor = Color.Black;
            penBtn.FlatAppearance.MouseDownBackColor = Color.Black;
            penBtn.FlatAppearance.MouseOverBackColor = Color.White;
            penBtn.FlatStyle = FlatStyle.Flat;
            penBtn.ForeColor = SystemColors.Control;
            penBtn.Location = new Point(3, 48);
            penBtn.Name = "penBtn";
            penBtn.Size = new Size(65, 29);
            penBtn.TabIndex = 1;
            penBtn.Text = "Pen";
            penBtn.UseVisualStyleBackColor = false;
            // 
            // brushBtn
            // 
            brushBtn.BackColor = Color.Black;
            brushBtn.FlatAppearance.MouseDownBackColor = Color.Black;
            brushBtn.FlatAppearance.MouseOverBackColor = Color.White;
            brushBtn.FlatStyle = FlatStyle.Flat;
            brushBtn.ForeColor = SystemColors.Control;
            brushBtn.Location = new Point(3, 83);
            brushBtn.Name = "brushBtn";
            brushBtn.Size = new Size(65, 29);
            brushBtn.TabIndex = 2;
            brushBtn.Text = "Brush";
            brushBtn.UseVisualStyleBackColor = false;
            // 
            // selectBtn
            // 
            selectBtn.BackColor = Color.Black;
            selectBtn.FlatAppearance.MouseDownBackColor = Color.Black;
            selectBtn.FlatAppearance.MouseOverBackColor = Color.White;
            selectBtn.FlatStyle = FlatStyle.Flat;
            selectBtn.ForeColor = SystemColors.Control;
            selectBtn.Location = new Point(3, 13);
            selectBtn.Name = "selectBtn";
            selectBtn.Size = new Size(65, 29);
            selectBtn.TabIndex = 3;
            selectBtn.Text = "Select";
            selectBtn.UseVisualStyleBackColor = false;
            // 
            // ToolsWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Name = "ToolsWindow";
            Size = new Size(71, 321);
            contentPanel.ResumeLayout(false);
            topPanel.ResumeLayout(false);
            buttonsHolderContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel buttonsHolderContainer;
        private Button penBtn;
        private Button brushBtn;
        private Button selectBtn;
    }
}
