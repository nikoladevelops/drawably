using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Drawably.UserControls.CanvasRelated
{
    public partial class CanvasContainer
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
            canvas = new Canvas();
            SuspendLayout();
            // 
            // canvas
            // 
            canvas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            canvas.BackColor = Color.Transparent;
            canvas.DisplayedImage = null;
            canvas.Location = new Point(116, 109);
            canvas.Name = "canvas";
            canvas.Size = new Size(232, 173);
            canvas.TabIndex = 1;
            // 
            // CanvasContainer
            // 
            BackColor = Color.DarkGray;
            Controls.Add(canvas);
            Name = "CanvasContainer";
            Size = new Size(623, 418);
            ResumeLayout(false);
        }

        #endregion


        protected Canvas canvas;
    }
}
