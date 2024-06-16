using Drawably.UserControls.CanvasRelated;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawably.UserControls.Windows.Colors
{
    public partial class ColorsWindow : MenuWindow
    {
        private ColorDialog colorDialog;
        public ColorsWindow()
        {
            InitializeComponent();
            this.MenuText = "Colors";
            colorDialog = new ColorDialog();
        }

        [
          Category("All Custom Props"),
          Description("The Canvas Container is needed in order for everything to work correctly.")
       ]
        public CanvasContainer CanvasContainer { get; set; }

        public Color LeftColor { get => this.leftColorButton.BackColor; }
        public Color RightColor { get => this.rightColorButton.BackColor; }

        private void leftColorButton_Click(object sender, EventArgs e)
        {
            if (CanvasContainer == null)
            {
                MessageBox.Show("Error: Canvas Container was not set");
                return;
            }

            DialogResult result = colorDialog.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            this.leftColorButton.BackColor = colorDialog.Color;
            this.CanvasContainer.OnLeftColorChanged();
        }

        private void rightColorButton_Click(object sender, EventArgs e)
        {
            if (CanvasContainer == null)
            {
                MessageBox.Show("Error: Canvas Container was not set");
                return;
            }

            DialogResult result = colorDialog.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            this.rightColorButton.BackColor = colorDialog.Color;
            this.CanvasContainer.OnRightColorChanged();
        }

        private void switchColorsButton_Click(object sender, EventArgs e)
        {
            Color temp = this.leftColorButton.BackColor;

            this.leftColorButton.BackColor = this.rightColorButton.BackColor;
            this.rightColorButton.BackColor = temp;

            this.CanvasContainer.OnLeftColorChanged();
            this.CanvasContainer.OnRightColorChanged();
        }
    }
}
