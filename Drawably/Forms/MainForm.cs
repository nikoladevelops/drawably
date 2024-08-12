using Drawably.Utility;

namespace Drawably
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Globals.SetUp(
                this.canvasContainer,
                this.layersWindow,
                this.colorsWindow,
                this.toolsWindow,
                this.topPanel
                );

            this.WindowState = FormWindowState.Maximized;

            this.canvasContainer.SetUp();

            this.toolsWindow.SetUp();
            this.layersWindow.SetUp();
            this.colorsWindow.SetUp();
            this.topPanel.SetUp();
        }
    }
}