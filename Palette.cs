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
        public SolidBrush BrushColor;
        public MyColors(float nx, float ny, SolidBrush nbr)
        {
            X = nx;
            Y = ny;
            BrushColor = nbr;
        }
    }

    public class Palette
    {
        public List<MyColors> MyPalette;

        public SolidBrush[] LBrushColors;
        public Palette()
        {
            LBrushColors = new SolidBrush[10];
            LBrushColors[0] = new SolidBrush(Color.Black);
            LBrushColors[1] = new SolidBrush(Color.Gray);
            LBrushColors[2] = new SolidBrush(Color.Red);
            LBrushColors[3] = new SolidBrush(Color.Pink);
            LBrushColors[4] = new SolidBrush(Color.Yellow);
            LBrushColors[5] = new SolidBrush(Color.Orange);
            LBrushColors[6] = new SolidBrush(Color.LightBlue);
            LBrushColors[7] = new SolidBrush(Color.Blue);
            LBrushColors[8] = new SolidBrush(Color.Brown);
            LBrushColors[9] = new SolidBrush(Color.Green);


            MyPalette = new List<MyColors>();
            for (int i = 0; i < 5; i++)
                MyPalette.Add(new MyColors(1050 + i * 60, 520, LBrushColors[i]));
            for (int i = 5; i < 10; i++)
                MyPalette.Add(new MyColors(1050 + (i - 5) * 60, 560, LBrushColors[i]));
        }

    }

}
