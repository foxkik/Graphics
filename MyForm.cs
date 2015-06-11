using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphic
{
    public partial class MyForm : Form
    {
        Graphics Draw;
        int flag = 0;

        /*тестовая хрень*/

        float bx = 0, by = 0;
        float ddx=0, ddy=0;

        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/

        public MyForm()
        {
            InitializeComponent();
        }

        private void MyForm_Load(object sender, EventArgs e)
        {        
        }

        private void MyForm_Paint(object sender, PaintEventArgs e)
        {
            Draw = e.Graphics;
            float WorkplaceX = this.Width / 2 - this.Width / 2 + 10;
            float WorkplaceY = this.Height / 2 - this.Height / 2 + 10;
            float WorkplaceWidth = 2*this.Width / 3;
            float WorkplaceHeight = 4 * this.Height / 5;
       //     Draw.FillRectangle(new SolidBrush(Color.White), WorkplaceX, WorkplaceY, WorkplaceWidth, WorkplaceHeight);

            Palette palette = new Palette();
            foreach(MyColors cl in palette.MyPalette)
            {
                Draw.FillRectangle(cl.BrushColor, cl.X, cl.Y, 30, 30);
            }


      //      if(flag!=0)
        //    Draw.DrawLine(new Pen(Color.Tomato,3)bx,by,)



            //if(flag!=0)
            //    Draw.DrawRectangle(new Pen(Color.Red), 900, 30, 34, 34);
         //   Invalidate();
        }

        private void MyForm_MouseMove(object sender, MouseEventArgs e)
        {
            //try
            //{
            //    Palette palette = new Palette();
                
            //    foreach (MyColors cl in palette.MyPalette)
            //    {
            //        if (e.X >= cl.X && e.Y >= cl.Y && e.X <= cl.X + 30 && e.Y <= cl.Y + 30)
            //            //  Draw.DrawRectangle(new Pen(Color.White), cl.X - 2, cl.Y - 2, 34, 34);
            //            //       Draw.FillRectangle(cl.BrushColor, 990, 30, 34, 34);
            //            //Draw.DrawRectangle(new Pen(Color.White,))
            //            flag=60;
            //    }
            //    this.Invalidate();
            //}
            //catch(Exception ex)
            //{
            //    string lala = ex.Message;
            //}
        }

        private void MyForm_MouseDown(object sender, MouseEventArgs e)
        {
            flag = 9;
            bx = e.X;
            by = e.Y;
        }

    }
}
