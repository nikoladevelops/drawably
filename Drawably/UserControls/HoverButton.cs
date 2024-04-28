using System.ComponentModel;

namespace Drawably.UserControls
{
    public class HoverButton:Button
    {
        private bool firstTimePainting = true;

        private Color originalColorCached;
        private Color mouseEnterColor;

        private Color originalBorderColorCached;
        private Color mouseEnterBorderColor;

        // Background color
        [
           Category("All Custom Props"),
           Description("Enables/Disables whether the MouseEnterColor is used")
        ]
        public bool IsMouseEnterColorEnabled { get; set; } = false;

        [
           Category("All Custom Props"),
           Description("The color the button has, when the mouse enters it")
        ]
        public Color MouseEnterColor
        {
            get => this.mouseEnterColor;
            set 
            {
                this.mouseEnterColor = value;
            }
        }

        // Border
        [
           Category("All Custom Props"),
           Description("Enables/Disables whether the MouseEnterBorderColor is used")
        ]
        public bool IsMouseEnterBorderColorEnabled { get; set; } = false;

        [
           Category("All Custom Props"),
           Description("The color the button's border has, when the mouse enters it")
        ]
        public Color MouseEnterBorderColor
        {
            get => this.mouseEnterBorderColor;
            set
            {
                this.mouseEnterBorderColor = value;
            }
        }

        public HoverButton()
        {
            this.SetStyle(ControlStyles.Selectable, false); // disable focus
            this.Paint += HoverButton_Paint;
        }

        private void HoverButton_Paint(object? sender, PaintEventArgs e)
        {
            if (firstTimePainting) 
            {
                this.originalColorCached = this.BackColor;
                this.originalBorderColorCached = this.FlatAppearance.BorderColor;
                firstTimePainting = false;
            }

            this.MouseEnter += CustomButton_MouseEnter;
            this.MouseLeave += CustomButton_MouseLeave;
            this.MouseHover += HoverButton_MouseHover;
        }

        private void HoverButton_MouseHover(object? sender, EventArgs e)
        {
            if (IsMouseEnterColorEnabled) 
            {
                this.BackColor = mouseEnterColor;
            }

            if (IsMouseEnterBorderColorEnabled) 
            {
                this.FlatAppearance.BorderColor = mouseEnterBorderColor;
            }
        }

        private void CustomButton_MouseLeave(object? sender, EventArgs e)
        {
            if (IsMouseEnterColorEnabled) 
            {
                this.BackColor = originalColorCached;
            }

            if (IsMouseEnterBorderColorEnabled) 
            {
                this.FlatAppearance.BorderColor = originalBorderColorCached;
            }
        }

        private void CustomButton_MouseEnter(object? sender, EventArgs e)
        {
            if (IsMouseEnterColorEnabled)
            {
                this.BackColor = mouseEnterColor;
            }

            if (IsMouseEnterBorderColorEnabled) 
            {
                this.FlatAppearance.BorderColor = mouseEnterBorderColor;
            }
        }
    }
}
