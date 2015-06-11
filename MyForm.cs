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
        Pencil pencil;

        /*тестовая хрень*/

        float x1 = 0, y1 = 0;
        float x2 = 0, y2 = 0;
        Bitmap picture;
        /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/

        public MyForm()
        {
            InitializeComponent();
            picture = new Bitmap(942, 598);
            pencil = new Pencil();
        }

        private void MyForm_Load(object sender, EventArgs e)
        {
        }

        private void MyForm_Paint(object sender, PaintEventArgs e)
        {
            Draw = e.Graphics;

            Palette palette = new Palette();
            foreach (MyColors cl in palette.MyPalette)
            {
                Draw.FillRectangle(new SolidBrush(cl.color), cl.X, cl.Y, 30, 30);
            }

        }

        private void MyForm_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void MyForm_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
            flag = 9;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag != 0)
            {
                x2 = e.X;
                y2 = e.Y;

                Graphics g = Graphics.FromImage(picture);

                g.DrawLine(new Pen(pencil.PencilColor, pencil.Width), x1, y1, x2, y2);
                pictureBox1.Image = picture;
                pictureBox1.Invalidate();
                x1 = x2;
                y1 = y2;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            flag = 0;
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            picture = new Bitmap(942, 598);
            pictureBox1.Image = picture;
            pictureBox1.Invalidate();
        }

        private void MyForm_MouseClick(object sender, MouseEventArgs e)
        {
            Palette palette = new Palette();
            foreach (MyColors cl in palette.MyPalette)
            {
                if (e.X >= cl.X && e.Y >= cl.Y && e.X <= cl.X + 30 && e.Y <= cl.Y + 30)
                {
                    pencil.PencilColor = cl.color;
                    
                }
            }
        }

        private void CBwidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tmp = CBwidth.SelectedItem;
            tmp = tmp.ToString().Substring(8, 1);
            pencil.Width = (float)Convert.ToDouble(tmp) + 1;
            tmp = null;
        }

        private void RBpencil_Click(object sender, EventArgs e)
        {
            CBwidth.Enabled = true;
            if (CBwidth.SelectedItem != null)
            {
                var tmp = CBwidth.SelectedItem;
                tmp = tmp.ToString().Substring(8, 1);
                pencil.Width = (float)Convert.ToDouble(tmp) + 1;
                tmp = null;
            }
            else
                pencil.Width = 2;
            pencil.PencilColor = Color.Black;
        }

        private void RBeraser_Click(object sender, EventArgs e)
        {
            CBwidth.Enabled = false;
            pencil.Width = 10;
            pencil.PencilColor = Color.White;
        }
    }
}
