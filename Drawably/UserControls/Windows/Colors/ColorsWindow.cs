using Drawably.UserControls.CanvasRelated;
using Drawably.Utility;

namespace Drawably.UserControls.Windows.Colors
{
    /// <summary>
    /// Visualizes the selected colors and the actions that can be applied to them by the user.
    /// </summary>
    public partial class ColorsWindow : MenuWindow
    {
        private Color cacheLeftColorNoOpacity;
        private Color cacheRightColorNoOpacity;

        private ColorDialog colorDialog;
        public ColorsWindow()
        {
            InitializeComponent();
            this.MenuText = "Colors";
            colorDialog = new ColorDialog();
        }

        public Color LeftColor { get => this.leftColorButton.BackColor; }
        public Color RightColor { get => this.rightColorButton.BackColor; }


        /// <summary>
        /// Ensures the window is ready to be used by the user.
        /// </summary>
        public void SetUp()
        {
            ConnectBtnEvents();
        }

        /// <summary>
        /// Enables the buttons' functionalities.
        /// </summary>
        private void ConnectBtnEvents()
        {
            this.switchColorsButton.Click += switchColorsButton_Click;
            this.leftColorButton.Click += leftColorButton_Click;
            this.rightColorButton.Click += rightColorButton_Click;

            this.leftColorOpacityTrackBar.ValueChanged += LeftColorOpacityTrackBar_ValueChanged;
            this.rightColorOpacityTrackBar.ValueChanged += RightColorOpacityTrackBar_ValueChanged;

            this.leftColorOpacityTrackBar.MouseUp += LeftColorOpacityTrackBar_MouseUp;
            this.rightColorOpacityTrackBar.MouseUp += RightColorOpacityTrackBar_MouseUp;

            this.cacheLeftColorNoOpacity = LeftColor;
            this.cacheRightColorNoOpacity = RightColor;
        }

        // For actual color alpha calculation.
        private Color ApplyAlphaToColor(Color color, int alpha) 
        {
            return Color.FromArgb(alpha, color.R, color.G, color.B);
        }

        private void LeftColorOpacityTrackBar_MouseUp(object? sender, MouseEventArgs e)
        {
            Color applyOpacityColor = ApplyAlphaToColor(cacheLeftColorNoOpacity, this.leftColorOpacityTrackBar.Value);

            this.leftColorButton.BackColor = applyOpacityColor;
            Globals.CanvasContainer.OnLeftColorChanged();

        }
        private void RightColorOpacityTrackBar_MouseUp(object? sender, MouseEventArgs e)
        {
            Color applyOpacityColor = ApplyAlphaToColor(cacheRightColorNoOpacity, this.rightColorOpacityTrackBar.Value);

            this.rightColorButton.BackColor = applyOpacityColor;
            Globals.CanvasContainer.OnRightColorChanged();
        }

        //

        // For label opacity percentages.
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
            DialogResult result = colorDialog.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            cacheLeftColorNoOpacity = colorDialog.Color;
            Color applyOpacityColor = ApplyAlphaToColor(colorDialog.Color, this.leftColorOpacityTrackBar.Value);

            this.leftColorButton.BackColor = applyOpacityColor;
            Globals.CanvasContainer.OnLeftColorChanged();
        }

        private void rightColorButton_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            cacheRightColorNoOpacity = colorDialog.Color;
            Color applyOpacityColor = ApplyAlphaToColor(colorDialog.Color, this.rightColorOpacityTrackBar.Value);

            this.rightColorButton.BackColor = applyOpacityColor;
            Globals.CanvasContainer.OnRightColorChanged();
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

            Globals.CanvasContainer.OnLeftColorChanged();
            Globals.CanvasContainer.OnRightColorChanged();
        }
    }
}
