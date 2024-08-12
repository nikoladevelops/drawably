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
            this.WindowState = FormWindowState.Maximized;

            this.canvasContainer.SetUp(layersWindow, colorsWindow, topPanel);

            this.toolsWindow.SetUp(this.canvasContainer);
            this.layersWindow.SetUp(this.canvasContainer);
            this.colorsWindow.SetUp(this.canvasContainer);
            this.topPanel.SetUp(this.toolsWindow, this.colorsWindow, this.layersWindow, this.canvasContainer);
        }
    }
}