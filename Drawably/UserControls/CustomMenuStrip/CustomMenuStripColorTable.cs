namespace Drawably.UserControls.CustomMenuStrip
{
    public class CustomMenuStripColorTable : ProfessionalColorTable
    {
        /// <summary>
        /// Gets the starting color of the gradient used when 
        /// a top-level System.Windows.Forms.ToolStripMenuItem is pressed.
        /// </summary>
        public override Color MenuItemPressedGradientBegin => Color.Azure;

        /// <summary>
        /// Gets the end color of the gradient used when a top-level 
        /// System.Windows.Forms.ToolStripMenuItem is pressed.
        /// </summary>
        public override Color MenuItemPressedGradientEnd => Color.DimGray;

        /// <summary>
        /// Gets the border color to use with a 
        /// System.Windows.Forms.ToolStripMenuItem.
        /// </summary>
        public override Color MenuItemBorder => Color.FromArgb(129, 133, 137);

        /// <summary>
        /// Gets the starting color of the gradient used when the 
        /// System.Windows.Forms.ToolStripMenuItem is selected.
        /// </summary>
        public override Color MenuItemSelectedGradientBegin => Color.Silver;

        /// <summary>
        /// Gets the end color of the gradient used when the 
        /// System.Windows.Forms.ToolStripMenuItem is selected.
        /// </summary>
        public override Color MenuItemSelectedGradientEnd => Color.DimGray;

        /// <summary>
        /// Gets the solid background color of the 
        /// System.Windows.Forms.ToolStripDropDown.
        /// </summary>
        public override Color ToolStripDropDownBackground => Color.Black;

        /// <summary>
        /// Gets the starting color of the gradient used in the image 
        /// margin of a System.Windows.Forms.ToolStripDropDownMenu.
        /// </summary>
        public override Color ImageMarginGradientBegin => Color.DimGray;

        /// <summary>
        /// Gets the middle color of the gradient used in the image 
        /// margin of a System.Windows.Forms.ToolStripDropDownMenu.
        /// </summary>
        public override Color ImageMarginGradientMiddle => Color.DimGray;

        /// <summary>
        /// Gets the end color of the gradient used in the image 
        /// margin of a System.Windows.Forms.ToolStripDropDownMenu.
        /// </summary>
        public override Color ImageMarginGradientEnd => Color.DimGray;

        /// <summary>
        /// Gets the color to use to for shadow effects on 
        /// the System.Windows.Forms.ToolStripSeparator.
        /// </summary>
        public override Color SeparatorDark => Color.FromArgb(129, 133, 137);

        /// <summary>
        /// Gets the color that is the border color to use 
        /// on a System.Windows.Forms.MenuStrip.
        /// </summary>
        public override Color MenuBorder => Color.FromArgb(129, 133, 137);
    }
}
