using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_ShapeDrawing
{
    public class RectangleShape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public int Area()
        {
            return Width * Height;
        }

        public void Draw(Form form)
        {
            SolidBrush myBrush = new SolidBrush(System.Drawing.Color.Black);
            Graphics formGraphics = form.CreateGraphics();
            formGraphics.Clear(form.BackColor);
            formGraphics.DrawRectangle(Pens.Black,5,5,Width,Height);
        }
    }   
}
