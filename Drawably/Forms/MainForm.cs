using Drawably.Renderer;
using Drawably.UserControls.Windows;
using Drawably.Utility;
using System.Runtime.CompilerServices;

namespace Drawably
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Tracks whether the CTRL is pressed.
        /// </summary>
        public bool IsCtrlPressed { get; private set; }

        public MainForm()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.KeyDown += Form_KeyDown;
            this.KeyUp += Form_KeyUp;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Globals.SetUp(
                this,
                this.canvasContainer,
                this.layersWindow,
                this.colorsWindow,
                this.toolsWindow,
                this.topPanel,
                new LayerRenderer(),
                new ShapeManager()
                );

            this.WindowState = FormWindowState.Maximized;

            this.canvasContainer.SetUp();

            this.toolsWindow.SetUp();
            this.layersWindow.SetUp();
            this.colorsWindow.SetUp();
            this.topPanel.SetUp();
        }

        /// <summary>
        /// Places a custom menu inside the MainForm
        /// </summary>
        public void PlaceCustomMenuToMainForm(MenuWindow customMenu)
        {
            this.Controls.Add(customMenu);
            customMenu.Location = new Point(150, 150);
            customMenu.BringToFront();
        }

        /// <summary>
        /// Used to track when the CTRL key has been pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                this.IsCtrlPressed = true;
            }
        }

        /// <summary>
        /// Used to track when the CTRL key has been released.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_KeyUp(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                this.IsCtrlPressed = false;
            }
        }
    }
}