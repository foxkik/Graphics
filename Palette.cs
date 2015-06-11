using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphic
{
    public class MyColors
    {
        public float X, Y;
        public Color color;
        public MyColors(float nx, float ny, Color nbr)
        {
            X = nx;
            Y = ny;
            color = nbr;
        }
    }

    public class Palette
    {
        public List<MyColors> MyPalette;

        public Color[] LColors;
        public Palette()
        {
            LColors = new Color[10];
            LColors[0] = Color.Black;
            LColors[1] = Color.Gray;
            LColors[2] = Color.Red;
            LColors[3] = Color.Pink;
            LColors[4] = Color.Yellow;
            LColors[5] = Color.Orange;
            LColors[6] = Color.LightBlue;
            LColors[7] = Color.Blue;
            LColors[8] = Color.Brown;
            LColors[9] = Color.Green;


            MyPalette = new List<MyColors>();
            for (int i = 0; i < 5; i++)
                MyPalette.Add(new MyColors(1050 + i * 60, 520, LColors[i]));
            for (int i = 5; i < 10; i++)
                MyPalette.Add(new MyColors(1050 + (i - 5) * 60, 560, LColors[i]));
        }

    }

}
