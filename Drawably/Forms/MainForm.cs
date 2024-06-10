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
            
            this.canvasContainer.ScrollToMiddle();

            toolsWindow.SetUp(this.canvasContainer);
        }

        private void MainForm_MouseWheel(object? sender, MouseEventArgs e)
        {
        }


        private void colorsMenuWindow_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}