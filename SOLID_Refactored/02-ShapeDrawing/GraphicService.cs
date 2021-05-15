using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_ShapeDrawing
{
    public class GraphicService
    {
        public void Draw(Form form, GeometricRectangle rectangle)
        {
            var myBrush = new SolidBrush(System.Drawing.Color.Black);
            var formGraphics = form.CreateGraphics();
            formGraphics.Clear(form.BackColor);
            formGraphics.DrawRectangle(Pens.Black, 5, 5, rectangle.Width, rectangle.Height);
        }
    }
}
