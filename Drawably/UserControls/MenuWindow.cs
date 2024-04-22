using Drawably.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawably
{
    public partial class MenuWindow : UserControl
    {
        private string menuText;

        [
           Category("All Custom Props"),
           Description("The displayed text at the top left corner for the menu window's top panel")
        ]
        public string MenuText
        {
            get => menuText;
            set
            {
                menuText = value;
                menuTextLabel.Text = MenuText;

                EnsureMenuTextLabelFitsSize();
            }
        }
        [
           Category("All Custom Props"),
           Description("The button that has the task of opening/closing this menu window")
        ]
        public Button AssociatedButton { get; set; }
        public MenuWindow()
        {
            InitializeComponent();
            this.EnableDrag(topPanel);
            this.EnableDrag(menuTextLabel);
            this.Resize += MenuWindow_Resize;
            this.closeButton.Click += CloseButton_Click;
        }

        private void CloseButton_Click(object? sender, EventArgs e)
        {
            // TODO should toggle associated button instead
            this.Visible = false;
        }

        private void menuWindowLoad(object sender, EventArgs e)
        {
            if (AssociatedButton != null)
            {
                AssociatedButton.Click += AssociatedButton_Click;
            }
        }

        private void MenuWindow_Resize(object? sender, EventArgs e)
        {
            EnsureMenuTextLabelFitsSize();
        }

        private void AssociatedButton_Click(object? sender, EventArgs e)
        {
            this.Visible = !this.Visible;
        }

        private void EnsureMenuTextLabelFitsSize()
        {
            // Handle the case where the label's width doesn't fit the menu's width. This also relies on the label's AutoElipsis property
            int totalTakenWidth = menuTextLabel.Width + closeButton.Width;
            if (totalTakenWidth > this.Width)
            {
                totalTakenWidth -= this.Width;
                menuTextLabel.Width -= totalTakenWidth;
            }
            else
            {
                menuTextLabel.Width = topPanel.Width - closeButton.Width;
            }
        }
    }
}
