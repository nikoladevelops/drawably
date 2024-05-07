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
            this.KeyPreview = true; // Makes it possible to process keydown events no matter which control is focused, basically the form processes the events first / my other choice was using win32 API to set up hotkeys, but decided that this approach is easier
        }

        private void MainForm_MouseWheel(object? sender, MouseEventArgs e)
        {
        }


        private void colorsMenuWindow_Load(object sender, EventArgs e)
        {

        }

    }
}