using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphic
{
    class MyTools
    {
    }
    class Pencil
    {
        public float Width;
        public Color PencilColor;
        public Pencil()
        {
            Width = 2;
            PencilColor = Color.Black;
        }
        public void DrawLine(Graphics g, Color color, float ndx, float ndy)
        {
           // g.DrawLine(new Pen(color,Width), 
        }
    }
}
