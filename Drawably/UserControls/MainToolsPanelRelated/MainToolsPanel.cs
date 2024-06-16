using Drawably.UserControls.Windows;
using System.ComponentModel;

namespace Drawably.UserControls.MainToolsPanelRelated
{
    public partial class MainToolsPanel : UserControl
    {
        private class ToolsButtonData
        {
            public HoverButton AssociatedButton { get; set; }
            public bool IsWindowOpened { get; set; }

            public ToolsButtonData(HoverButton newAssociatedButton, bool newIsWindowsOpened)
            {
                this.AssociatedButton = newAssociatedButton;
                this.IsWindowOpened = newIsWindowsOpened;
            }
        }

        // When the window state is opened, the button should be colored like this
        private Color windowOpenedColor = Color.FromArgb(139, 138, 194);

        // When the window state is closed, the button should be colored like this
        private Color windowClosedColor = Color.FromArgb(192, 192, 255);

        [
           Category("All Custom Props"),
           Description("The Tools window, that the tools button controls")
        ]
        
        public MenuWindow ToolsWindow { get; set; }
        [
           Category("All Custom Props"),
           Description("The Colors window, that the colors button controls")
        ]
        public MenuWindow ColorsWindow { get; set; }

        [
           Category("All Custom Props"),
           Description("The Layers window, that the layers button controls")
        ]
        public MenuWindow LayersWindow { get; set; }

        // Holds window as KEY and the data of the corresponding button as VALUE
        private Dictionary<MenuWindow, ToolsButtonData> windowsOpenedState = new Dictionary<MenuWindow, ToolsButtonData>();
        public MainToolsPanel()
        {
            InitializeComponent();
        }

        private void MainToolsPanel_Load(object sender, EventArgs e)
        {
            // Note that all these menus have to be set from the outside before trying to put them inside the dictionary.

            if (ToolsWindow == null || ColorsWindow == null || LayersWindow == null) 
            {
                return;
            }

            // Initial state, all windows are visible TODO this should probably get loaded from a settings json file
            windowsOpenedState[ToolsWindow] = new ToolsButtonData(this.toolsButton, true);
            windowsOpenedState[ColorsWindow] = new ToolsButtonData(this.colorsButton, true);
            windowsOpenedState[LayersWindow] = new ToolsButtonData(this.layersButton, true);

            // Set close btn clicked behaviour for each window
            foreach (var window in windowsOpenedState.Keys)
            {
                window.OnCloseBtnClicked = () =>
                {
                    ToolsButtonData btnData = windowsOpenedState[window];
                    btnData.IsWindowOpened = false;
                    btnData.AssociatedButton.OriginalColorCached = windowClosedColor;
                    btnData.AssociatedButton.BackColor = windowClosedColor;
                };
            }

            this.toolsButton.Click += ToolsButton_Click; ;
            this.colorsButton.Click += ColorsButton_Click;
            this.layersButton.Click += LayersButton_Click;
        }

        private void LayersButton_Click(object? sender, EventArgs e)
        {
            ChangeMenuWindowState(LayersWindow);
        }

        private void ColorsButton_Click(object? sender, EventArgs e)
        {
            ChangeMenuWindowState(ColorsWindow);
        }

        private void ToolsButton_Click(object? sender, EventArgs e)
        {
            ChangeMenuWindowState(ToolsWindow);
        }

        private void ChangeMenuWindowState(MenuWindow window)
        {
            ToolsButtonData currData = windowsOpenedState[window];

            // If the menu is already opened close it
            if (currData.IsWindowOpened)
            {
                currData.IsWindowOpened = false;
                window.Close();
                currData.AssociatedButton.OriginalColorCached = windowClosedColor; // notice how I'm changing the cached color and NOT the back color
                return;
            }

            // If the menu is closed then open it
            currData.IsWindowOpened = true;
            window.Open();
            currData.AssociatedButton.OriginalColorCached = windowOpenedColor;
        }
    }
}
