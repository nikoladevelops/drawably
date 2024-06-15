using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawably.UserControls
{
    public partial class Canvas : UserControl
    {
        public PictureBox CanvasPictureBox { get => this.canvasPictureBox; }
        public Canvas()
        {
            InitializeComponent();
            this.backgroundPictureBox.Controls.Add(this.canvasPictureBox);
        }
    }
}
