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
            selectShapeToolBtn = new Button();
            brushToolBtn = new Button();
            drawShapesToolBtn = new Button();
            zoomInToolBtn = new Button();
            zoomOutToolBtn = new Button();
            penToolBtn = new Button();
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
            buttonsHolderContainer.Controls.Add(selectShapeToolBtn);
            buttonsHolderContainer.Controls.Add(penToolBtn);
            buttonsHolderContainer.Controls.Add(brushToolBtn);
            buttonsHolderContainer.Controls.Add(drawShapesToolBtn);
            buttonsHolderContainer.Controls.Add(zoomInToolBtn);
            buttonsHolderContainer.Controls.Add(zoomOutToolBtn);
            buttonsHolderContainer.Dock = DockStyle.Fill;
            buttonsHolderContainer.Location = new Point(0, 0);
            buttonsHolderContainer.Name = "buttonsHolderContainer";
            buttonsHolderContainer.Padding = new Padding(0, 10, 0, 0);
            buttonsHolderContainer.Size = new Size(71, 302);
            buttonsHolderContainer.TabIndex = 1;
            // 
            // selectShapeToolBtn
            // 
            selectShapeToolBtn.BackColor = Color.White;
            selectShapeToolBtn.BackgroundImage = Properties.Resources.select_shape;
            selectShapeToolBtn.BackgroundImageLayout = ImageLayout.Zoom;
            selectShapeToolBtn.FlatAppearance.BorderSize = 0;
            selectShapeToolBtn.FlatAppearance.MouseDownBackColor = Color.White;
            selectShapeToolBtn.FlatAppearance.MouseOverBackColor = Color.LightGray;
            selectShapeToolBtn.FlatStyle = FlatStyle.Flat;
            selectShapeToolBtn.ForeColor = SystemColors.Control;
            selectShapeToolBtn.Location = new Point(3, 13);
            selectShapeToolBtn.Name = "selectShapeToolBtn";
            selectShapeToolBtn.Size = new Size(65, 26);
            selectShapeToolBtn.TabIndex = 7;
            selectShapeToolBtn.UseVisualStyleBackColor = false;
            // 
            // brushToolBtn
            // 
            brushToolBtn.BackColor = Color.White;
            brushToolBtn.BackgroundImage = Properties.Resources.paint_brush;
            brushToolBtn.BackgroundImageLayout = ImageLayout.Zoom;
            brushToolBtn.FlatAppearance.BorderSize = 0;
            brushToolBtn.FlatAppearance.MouseDownBackColor = Color.White;
            brushToolBtn.FlatAppearance.MouseOverBackColor = Color.LightGray;
            brushToolBtn.FlatStyle = FlatStyle.Flat;
            brushToolBtn.ForeColor = SystemColors.Control;
            brushToolBtn.Location = new Point(3, 77);
            brushToolBtn.Name = "brushToolBtn";
            brushToolBtn.Size = new Size(65, 26);
            brushToolBtn.TabIndex = 4;
            brushToolBtn.UseVisualStyleBackColor = false;
            // 
            // drawShapesToolBtn
            // 
            drawShapesToolBtn.BackColor = Color.White;
            drawShapesToolBtn.BackgroundImage = Properties.Resources.draw_shapes;
            drawShapesToolBtn.BackgroundImageLayout = ImageLayout.Zoom;
            drawShapesToolBtn.FlatAppearance.BorderSize = 0;
            drawShapesToolBtn.FlatAppearance.MouseDownBackColor = Color.White;
            drawShapesToolBtn.FlatAppearance.MouseOverBackColor = Color.LightGray;
            drawShapesToolBtn.FlatStyle = FlatStyle.Flat;
            drawShapesToolBtn.ForeColor = SystemColors.Control;
            drawShapesToolBtn.Location = new Point(3, 109);
            drawShapesToolBtn.Name = "drawShapesToolBtn";
            drawShapesToolBtn.Size = new Size(65, 26);
            drawShapesToolBtn.TabIndex = 8;
            drawShapesToolBtn.UseVisualStyleBackColor = false;
            // 
            // zoomInToolBtn
            // 
            zoomInToolBtn.BackColor = Color.White;
            zoomInToolBtn.BackgroundImage = Properties.Resources.zoom_in;
            zoomInToolBtn.BackgroundImageLayout = ImageLayout.Zoom;
            zoomInToolBtn.FlatAppearance.BorderSize = 0;
            zoomInToolBtn.FlatAppearance.MouseDownBackColor = Color.White;
            zoomInToolBtn.FlatAppearance.MouseOverBackColor = Color.LightGray;
            zoomInToolBtn.FlatStyle = FlatStyle.Flat;
            zoomInToolBtn.ForeColor = SystemColors.Control;
            zoomInToolBtn.Location = new Point(3, 141);
            zoomInToolBtn.Name = "zoomInToolBtn";
            zoomInToolBtn.Size = new Size(65, 26);
            zoomInToolBtn.TabIndex = 9;
            zoomInToolBtn.UseVisualStyleBackColor = false;
            // 
            // zoomOutToolBtn
            // 
            zoomOutToolBtn.BackColor = Color.White;
            zoomOutToolBtn.BackgroundImage = Properties.Resources.zoom_out;
            zoomOutToolBtn.BackgroundImageLayout = ImageLayout.Zoom;
            zoomOutToolBtn.FlatAppearance.BorderSize = 0;
            zoomOutToolBtn.FlatAppearance.MouseDownBackColor = Color.White;
            zoomOutToolBtn.FlatAppearance.MouseOverBackColor = Color.LightGray;
            zoomOutToolBtn.FlatStyle = FlatStyle.Flat;
            zoomOutToolBtn.ForeColor = SystemColors.Control;
            zoomOutToolBtn.Location = new Point(3, 173);
            zoomOutToolBtn.Name = "zoomOutToolBtn";
            zoomOutToolBtn.Size = new Size(65, 26);
            zoomOutToolBtn.TabIndex = 10;
            zoomOutToolBtn.UseVisualStyleBackColor = false;
            // 
            // penToolBtn
            // 
            penToolBtn.BackColor = Color.White;
            penToolBtn.BackgroundImage = Properties.Resources.pen;
            penToolBtn.BackgroundImageLayout = ImageLayout.Zoom;
            penToolBtn.FlatAppearance.BorderSize = 0;
            penToolBtn.FlatAppearance.MouseDownBackColor = Color.White;
            penToolBtn.FlatAppearance.MouseOverBackColor = Color.LightGray;
            penToolBtn.FlatStyle = FlatStyle.Flat;
            penToolBtn.ForeColor = SystemColors.Control;
            penToolBtn.Location = new Point(3, 45);
            penToolBtn.Name = "penToolBtn";
            penToolBtn.Size = new Size(65, 26);
            penToolBtn.TabIndex = 5;
            penToolBtn.UseVisualStyleBackColor = false;
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
        private Button brushToolBtn;
        private Button selectShapeToolBtn;
        private Button drawShapesToolBtn;
        private Button zoomInToolBtn;
        private Button zoomOutToolBtn;
        private Button penToolBtn;
    }
}
