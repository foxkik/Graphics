﻿using System;
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
            StartX = 100;
            StartY = 100;
            FinishX = -2;
            FinishY = -2;
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

    class Triangle:Figure
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
        public void CalculatePoint()
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
            else
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

}
