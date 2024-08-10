using Drawably.UserControls.Windows;
using System.ComponentModel;

namespace Drawably.UserControls.MainToolsPanelRelated
{
    /// <summary>
    /// Holds buttons that associate to tool panels and the functionality of opening/closing them.
    /// </summary>
    public partial class MainToolsPanel : UserControl
    {
        /// <summary>
        /// Holds data for a tools button.
        /// </summary>
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

        // When the window state is opened, the button should be colored like this.
        private Color windowOpenedColor = Color.FromArgb(139, 138, 194);

        // When the window state is closed, the button should be colored like this.
        private Color windowClosedColor = Color.FromArgb(192, 192, 255);

        // Holds window as KEY and the data of the corresponding button as VALUE.
        private Dictionary<MenuWindow, ToolsButtonData> windowsOpenedState = new Dictionary<MenuWindow, ToolsButtonData>();
        
        // External dependencies.
        private MenuWindow toolsWindow;

        private MenuWindow colorsWindow;

        private MenuWindow layersWindow;
        //

        public MainToolsPanel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ensures the tools panel is ready to be used by the user.
        /// </summary>
        public void SetUp(MenuWindow newToolsWindow, MenuWindow newColorsWindow, MenuWindow newLayersWindow) 
        {
            string errorInfo = "";

            if (newToolsWindow == null) 
            {
                errorInfo += "Error: Main Tools Panel has no ToolsWindow.";
            }

            if (newColorsWindow == null) 
            {
                errorInfo += "Error: Main Tools Panel has no ColorsWindow.";
            }

            if (newLayersWindow == null) 
            {
                errorInfo += "Error: Main Tools Panel has no LayersWindow.";
            }

            if (errorInfo.Length != 0) 
            {
                MessageBox.Show(errorInfo);
                return;
            }

            this.toolsWindow = newToolsWindow;
            this.colorsWindow = newColorsWindow;
            this.layersWindow = newLayersWindow;

            ConnectBtnEvents();
        }

        private void ConnectBtnEvents() 
        {
            // Initial state, all windows are visible.
            windowsOpenedState[toolsWindow] = new ToolsButtonData(this.toolsButton, true);
            windowsOpenedState[colorsWindow] = new ToolsButtonData(this.colorsButton, true);
            windowsOpenedState[layersWindow] = new ToolsButtonData(this.layersButton, true);

            // Override the close button behaviour for each individual window, so that it affects the style of the associated tools button.
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

            // Connect button click events.
            this.toolsButton.Click += ToolsButton_Click; ;
            this.colorsButton.Click += ColorsButton_Click;
            this.layersButton.Click += LayersButton_Click;
        }

        private void LayersButton_Click(object? sender, EventArgs e)
        {
            ChangeMenuWindowState(layersWindow);
        }

        private void ColorsButton_Click(object? sender, EventArgs e)
        {
            ChangeMenuWindowState(colorsWindow);
        }

        private void ToolsButton_Click(object? sender, EventArgs e)
        {
            ChangeMenuWindowState(toolsWindow);
        }

        /// <summary>
        /// Changes the state of the window (opened/closed).
        /// </summary>
        /// <param name="window"></param>
        private void ChangeMenuWindowState(MenuWindow window)
        {
            ToolsButtonData currData = windowsOpenedState[window];

            // If the menu is already opened close it.
            if (currData.IsWindowOpened)
            {
                currData.IsWindowOpened = false;
                window.Close();
                currData.AssociatedButton.OriginalColorCached = windowClosedColor; // notice how I'm changing the cached color and NOT the back color.
                return;
            }

            // If the menu is closed then open it.
            currData.IsWindowOpened = true;
            window.Open();
            currData.AssociatedButton.OriginalColorCached = windowOpenedColor;
        }
    }
}
