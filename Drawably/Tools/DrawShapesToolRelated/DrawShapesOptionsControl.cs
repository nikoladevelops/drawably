using Drawably.Tools.DrawShapesToolRelated.Shapes;
using Drawably.UserControls.CanvasRelated;
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

namespace Drawably.Tools.DrawShapesToolRelated
{
    /// <summary>
    /// The idea of this class is to hold a bunch of buttons, each button is related to a particular shape. When a button is clicked, a new menu should open up for drawing that shape
    /// </summary>
    public partial class DrawShapesOptionsControl : UserControl
    {
        // This is the menu that gets opened every time a shape button is clicked
        private DrawSelectedShapeMenu drawSelectedMenu;
        Dictionary<Button, Shape> btnShapes;

        public DrawShapesOptionsControl()
        {
            InitializeComponent();

            this.drawSelectedMenu = new DrawSelectedShapeMenu();
            Globals.MainForm.PlaceCustomMenuToMainForm(this.drawSelectedMenu);

            RegisterBtnClickEvents();

            this.Visible = false;
        }

        /// <summary>
        /// Makes it so that each time a shape button is clicked, the draw shape menu is opened with the appropriate shape to draw
        /// </summary>
        private void RegisterBtnClickEvents() 
        {
            btnShapes = new Dictionary<Button, Shape>()
            {
                {rectangleShapeBtn, new RectangleShape()},
                {normalTriangleShapeBtn, new NormalTriangleShape()},
                {rightTriangleShapeBtn, new RightTriangleShape()},
                {circleShapeBtn, new CircleShape()},
                {rightArrowShapeBtn, new RightArrowShape()}
            };


            foreach (var kvp in btnShapes)
            {
                kvp.Key.Click += (o, e) =>
                {
                    this.drawSelectedMenu.MakeVisible(kvp.Value);
                };
            }

        }
    }
}
