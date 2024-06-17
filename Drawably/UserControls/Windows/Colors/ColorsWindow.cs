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

            this.leftColorOpacityTrackBar.ValueChanged += LeftColorOpacityTrackBar_ValueChanged;
            this.rightColorOpacityTrackBar.ValueChanged += RightColorOpacityTrackBar_ValueChanged;

            this.leftColorOpacityTrackBar.MouseUp += LeftColorOpacityTrackBar_MouseUp;
            this.rightColorOpacityTrackBar.MouseUp += RightColorOpacityTrackBar_MouseUp;

            this.cacheLeftColorNoOpacity = LeftColor;
            this.cacheRightColorNoOpacity = RightColor;
        }

        [
          Category("All Custom Props"),
          Description("The Canvas Container is needed in order for everything to work correctly.")
       ]
        public CanvasContainer CanvasContainer { get; set; }

        public Color LeftColor { get => this.leftColorButton.BackColor; }
        public Color RightColor { get => this.rightColorButton.BackColor; }

        private Color cacheLeftColorNoOpacity;
        private Color cacheRightColorNoOpacity;


        // For actual color alpha calculation
        private Color ApplyAlphaToColor(Color color, int alpha) 
        {
            return Color.FromArgb(alpha, color.R, color.G, color.B);
        }


        private void LeftColorOpacityTrackBar_MouseUp(object? sender, MouseEventArgs e)
        {
            Color applyOpacityColor = ApplyAlphaToColor(cacheLeftColorNoOpacity, this.leftColorOpacityTrackBar.Value);

            this.leftColorButton.BackColor = applyOpacityColor;
            this.CanvasContainer.OnLeftColorChanged();

        }
        private void RightColorOpacityTrackBar_MouseUp(object? sender, MouseEventArgs e)
        {
            Color applyOpacityColor = ApplyAlphaToColor(cacheRightColorNoOpacity, this.rightColorOpacityTrackBar.Value);

            this.rightColorButton.BackColor = applyOpacityColor;
            this.CanvasContainer.OnRightColorChanged();
        }

        //

        // For label opacity percentages
        private void LeftColorOpacityTrackBar_ValueChanged(object? sender, EventArgs e)
        {
            int opacityPercentage = (int)(this.leftColorOpacityTrackBar.Value / 255.0f * 100);
            this.leftColorOpacityPercentageLabel.Text = $"{opacityPercentage}%";
        }
        private void RightColorOpacityTrackBar_ValueChanged(object? sender, EventArgs e)
        {
            int opacityPercentage = (int)(this.rightColorOpacityTrackBar.Value / 255.0f * 100);
            this.rightColorOpacityPercentageLabel.Text = $"{opacityPercentage}%";
        }
        //

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

            cacheLeftColorNoOpacity = colorDialog.Color;
            Color applyOpacityColor = ApplyAlphaToColor(colorDialog.Color, this.leftColorOpacityTrackBar.Value);

            this.leftColorButton.BackColor = applyOpacityColor;
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

            cacheRightColorNoOpacity = colorDialog.Color;
            Color applyOpacityColor = ApplyAlphaToColor(colorDialog.Color, this.rightColorOpacityTrackBar.Value);

            this.rightColorButton.BackColor = applyOpacityColor;
            this.CanvasContainer.OnRightColorChanged();
        }

        private void switchColorsButton_Click(object sender, EventArgs e)
        {
            Color tempLeftColor = this.leftColorButton.BackColor;
            Color tempCacheLeftColor = this.cacheLeftColorNoOpacity;

            int leftTrackBarValueTemp = this.leftColorOpacityTrackBar.Value;

            // Switch colors
            this.leftColorButton.BackColor = this.rightColorButton.BackColor;
            this.rightColorButton.BackColor = tempLeftColor;

            // Switch trackbar values
            this.leftColorOpacityTrackBar.Value = this.rightColorOpacityTrackBar.Value;
            this.rightColorOpacityTrackBar.Value = leftTrackBarValueTemp;

            // Switch caches
            this.cacheLeftColorNoOpacity = this.cacheRightColorNoOpacity;
            this.cacheRightColorNoOpacity = tempCacheLeftColor;

            this.CanvasContainer.OnLeftColorChanged();
            this.CanvasContainer.OnRightColorChanged();
        }
    }
}
