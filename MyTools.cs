using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using System.

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
            PreviousColor = Color.Black;
        }
        public void SetOldWidth(object item)
        {
            if (item != null) //присваивание выбранной толщины
            {
                var tmp = item;
                tmp = tmp.ToString().Substring(8, 1);
                Width = (float)Convert.ToDouble(tmp) + 1;
                tmp = null;
            }
            else
                Width = 2;
        }
    }

    class Line
    {
        public float StartX, StartY, FinishX, FinishY;
        public Line()
        {
            StartX = -1;
            StartY = -1;
            FinishX = -2;
            FinishY = -2;
        }
    }
    class Figure
    {
        public float StartX, StartY, FinishX, FinishY, Hight, Width;
        public string Type;
        public Figure()
        {
            Type = "";
            StartX = 0;
            StartY = 0;
            FinishX = 0;
            FinishY = 0;
            Hight = 0;
            Width = 0;
        }
        private void Calculate()
        {
            Width = Math.Abs(FinishX - StartX);
            Hight = Math.Abs(FinishY - StartY);
        }
        public void CorrectPosition()
        {
            Calculate();
            if (FinishY < StartY && FinishX > StartX)
            {
                StartY = FinishY;
            }
            else if (FinishY > StartY && FinishX < StartX)
            {
                StartX = FinishX;
            }
            else if (FinishY < StartY && FinishX < StartX)
            {
                StartX = FinishX;
                StartY = FinishY;
            }
        }
    }

    class Triangle : Figure
    {
        public Point cenrt, left, right;
        public Triangle()
        {
            cenrt.X = 0;
            cenrt.Y = 0;
            left.X = 0;
            left.Y = 0;
            right.X = 0;
            right.Y = 0;
        }
        public void CalculatePoints()
        {
            if (Type == "triangle")
            {
                cenrt.X = (int)StartX + (int)((Math.Abs(FinishX - StartX)) / 2);
                cenrt.Y = (int)StartY;
                right.X = (int)FinishX;
                right.Y = (int)FinishY;
                left.X = (int)StartX;
                left.Y = (int)FinishY;
            }
            else if (Type == "sqtriangle")
            {
                cenrt.X = (int)StartX;
                cenrt.Y = (int)StartY;
                right.X = (int)FinishX;
                right.Y = (int)FinishY;
                left.X = (int)StartX;
                left.Y = (int)FinishY;
            }
        }
    }

    class Filler
    {
        public Stack<Point> Pixels;
        int h, w;
        public Color RequiredColor;
        public Color StartColor;
        Bitmap bmp;
        public Filler()
        {
            Pixels = new Stack<Point>();
        }
        private bool StackContains(int x, int y)
        {
            Point p = new Point(x, y);
            if (Pixels.Contains(p))
            {
                return true;
            }
            else
                return false;
        }
        public void AddIntoStack(int x, int y)
        {
            if (x < w && x >=0 && y < h && y >= 0 && !StackContains(x, y) && bmp.GetPixel(x, y).ToArgb() != RequiredColor.ToArgb())
            {
                Point p = new Point(x, y);
                Pixels.Push(p);
            }
        }
        public void Fill(Bitmap picture, int x, int y)
        {
            w = picture.Width;
            h = picture.Height;
            bmp = picture;
            StartColor = bmp.GetPixel(x,y);
            AddIntoStack(x, y);

            while (Pixels.Count != 0)
            {
                Point tmp = Pixels.Pop();
                var c1 = bmp.GetPixel(tmp.X, tmp.Y).ToArgb();
                var c2 = RequiredColor.ToArgb();


                if (tmp.X < w && tmp.X >= 0 && tmp.Y < h && tmp.Y >=0 && bmp.GetPixel(tmp.X, tmp.Y).ToArgb() == StartColor.ToArgb())
                {
                    bmp.SetPixel(tmp.X, tmp.Y, RequiredColor);
                    AddIntoStack(tmp.X - 1, tmp.Y);
                    AddIntoStack(tmp.X + 1, tmp.Y);
                    AddIntoStack(tmp.X, tmp.Y - 1);
                    AddIntoStack(tmp.X, tmp.Y + 1);
                }
            }
        }
    }
}
