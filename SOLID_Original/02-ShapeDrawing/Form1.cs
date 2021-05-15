using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_ShapeDrawing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            var rectangle = new RectangleShape();
            rectangle.Width = int.Parse(textWidth.Text);
            rectangle.Height = int.Parse(textHeight.Text);

            MessageBox.Show("Area : " + rectangle.Area().ToString());
            rectangle.Draw(this);
        }
    }
}
