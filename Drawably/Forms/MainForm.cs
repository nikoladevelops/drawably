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
        }

        private void MainForm_MouseWheel(object? sender, MouseEventArgs e)
        {
        }


        private void colorsMenuWindow_Load(object sender, EventArgs e)
        {

        }

    }
}