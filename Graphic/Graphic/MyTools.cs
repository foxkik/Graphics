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
        public Color PreviousColor;
        public Pencil()
        {
            Width = 2;
            PencilColor = Color.Black;
        }
    }
}
