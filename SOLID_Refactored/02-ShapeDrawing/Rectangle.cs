using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_ShapeDrawing
{
    public class GeometricRectangle
    {
        public int Height { get; private set; }
        public int Width { get; private set; }

        public int Area()
        {
            return Width * Height;
        }

        public GeometricRectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }
    }   
}
