namespace Drawably.Tools.DrawShapesToolRelated
{
    partial class DrawShapesOptionsControl
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
            contentFlowLayoutPanel = new FlowLayoutPanel();
            rectangleShapeBtn = new Button();
            circleShapeBtn = new Button();
            normalTriangleShapeBtn = new Button();
            rightTriangleShapeBtn = new Button();
            contentFlowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // contentFlowLayoutPanel
            // 
            contentFlowLayoutPanel.BackColor = Color.Black;
            contentFlowLayoutPanel.Controls.Add(rectangleShapeBtn);
            contentFlowLayoutPanel.Controls.Add(circleShapeBtn);
            contentFlowLayoutPanel.Controls.Add(normalTriangleShapeBtn);
            contentFlowLayoutPanel.Controls.Add(rightTriangleShapeBtn);
            contentFlowLayoutPanel.Dock = DockStyle.Fill;
            contentFlowLayoutPanel.Location = new Point(0, 0);
            contentFlowLayoutPanel.Name = "contentFlowLayoutPanel";
            contentFlowLayoutPanel.Size = new Size(415, 29);
            contentFlowLayoutPanel.TabIndex = 0;
            // 
            // rectangleShapeBtn
            // 
            rectangleShapeBtn.BackColor = Color.Gray;
            rectangleShapeBtn.BackgroundImage = Properties.Resources.rectangle_shape;
            rectangleShapeBtn.BackgroundImageLayout = ImageLayout.Zoom;
            rectangleShapeBtn.FlatAppearance.BorderSize = 0;
            rectangleShapeBtn.FlatStyle = FlatStyle.Flat;
            rectangleShapeBtn.Location = new Point(3, 3);
            rectangleShapeBtn.Name = "rectangleShapeBtn";
            rectangleShapeBtn.Size = new Size(38, 23);
            rectangleShapeBtn.TabIndex = 0;
            rectangleShapeBtn.UseVisualStyleBackColor = false;
            // 
            // circleShapeBtn
            // 
            circleShapeBtn.BackColor = Color.Gray;
            circleShapeBtn.BackgroundImage = Properties.Resources.circle_shape;
            circleShapeBtn.BackgroundImageLayout = ImageLayout.Zoom;
            circleShapeBtn.FlatAppearance.BorderSize = 0;
            circleShapeBtn.FlatStyle = FlatStyle.Flat;
            circleShapeBtn.Location = new Point(47, 3);
            circleShapeBtn.Name = "circleShapeBtn";
            circleShapeBtn.Size = new Size(38, 23);
            circleShapeBtn.TabIndex = 1;
            circleShapeBtn.UseVisualStyleBackColor = false;
            // 
            // normalTriangleShapeBtn
            // 
            normalTriangleShapeBtn.BackColor = Color.Gray;
            normalTriangleShapeBtn.BackgroundImage = Properties.Resources.triangle_shape;
            normalTriangleShapeBtn.BackgroundImageLayout = ImageLayout.Zoom;
            normalTriangleShapeBtn.FlatAppearance.BorderSize = 0;
            normalTriangleShapeBtn.FlatStyle = FlatStyle.Flat;
            normalTriangleShapeBtn.Location = new Point(91, 3);
            normalTriangleShapeBtn.Name = "normalTriangleShapeBtn";
            normalTriangleShapeBtn.Size = new Size(38, 23);
            normalTriangleShapeBtn.TabIndex = 2;
            normalTriangleShapeBtn.UseVisualStyleBackColor = false;
            // 
            // rightTriangleShapeBtn
            // 
            rightTriangleShapeBtn.BackColor = Color.Gray;
            rightTriangleShapeBtn.BackgroundImage = Properties.Resources.right_triangle_shape;
            rightTriangleShapeBtn.BackgroundImageLayout = ImageLayout.Zoom;
            rightTriangleShapeBtn.FlatAppearance.BorderSize = 0;
            rightTriangleShapeBtn.FlatStyle = FlatStyle.Flat;
            rightTriangleShapeBtn.Location = new Point(135, 3);
            rightTriangleShapeBtn.Name = "rightTriangleShapeBtn";
            rightTriangleShapeBtn.Size = new Size(38, 23);
            rightTriangleShapeBtn.TabIndex = 3;
            rightTriangleShapeBtn.UseVisualStyleBackColor = false;
            // 
            // DrawShapesOptionsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(contentFlowLayoutPanel);
            Name = "DrawShapesOptionsControl";
            Size = new Size(415, 29);
            contentFlowLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel contentFlowLayoutPanel;
        private Button rectangleShapeBtn;
        private Button circleShapeBtn;
        private Button normalTriangleShapeBtn;
        private Button rightTriangleShapeBtn;
    }
}
