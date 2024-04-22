using System.ComponentModel;

namespace Drawably.UserControls
{
    public class HoverButton:Button
    {
        private Color originalColorCached;
        private Color mouseEnterColor;

        [
           Category("All Custom Props"),
           Description("Enables/Disables whether the MouseEnterColor is used")
        ]
        public bool IsMouseEnterColorEnabled { get; set; } = false;

        [
           Category("All Custom Props"),
           Description("The color the button has when the mouse enters it")
        ]
        public Color MouseEnterColor
        {
            get => this.mouseEnterColor;
            set 
            {
                this.mouseEnterColor = value;
            }
        }

        public HoverButton()
        {
            this.SetStyle(ControlStyles.Selectable, false); // disable focus
            this.originalColorCached = this.BackColor;
           
            this.Paint += HoverButton_Paint;
        }

        private void HoverButton_Paint(object? sender, PaintEventArgs e)
        {
            if (IsMouseEnterColorEnabled)
            {
                this.MouseEnter += CustomButton_MouseEnter;
                this.MouseLeave += CustomButton_MouseLeave;
                this.MouseHover += HoverButton_MouseHover;
            }
        }

        private void HoverButton_MouseHover(object? sender, EventArgs e)
        {
            this.BackColor = mouseEnterColor;
        }

        private void CustomButton_MouseLeave(object? sender, EventArgs e)
        {
            this.BackColor = originalColorCached;
        }

        private void CustomButton_MouseEnter(object? sender, EventArgs e)
        {
            this.BackColor = mouseEnterColor;
        }
    }
}
