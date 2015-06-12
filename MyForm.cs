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
        Graphics g;
        bool MouseDownFlag = false; //чтобы отследивать, когда необходимо рисовать/стирать

    //    string FigureChosen = "";

        float ChosenColorFlagX = 1050; //выбранный цвет палитры
        float ChosenColorFlagY = 520;
        int StandartHeight = 598, StandartWidth = 942;
        Pencil pencil;
      //  Line line;

        Figure figure;


        /*координаты карандаша*/
        float x1 = 0, y1 = 0;
        float x2 = 0, y2 = 0;
        Bitmap picture;
        string FileName;
        string FileFormat;
        public MyForm()
        {
            InitializeComponent();
          //  picture = new Bitmap(942, 598);
            picture = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pencil = new Pencil();
       //     line = new Line();
            figure = new Figure();
            g = Graphics.FromImage(picture);
            g.Clear(Color.White);
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = picture;
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
            Draw.DrawRectangle(new Pen(Color.White, 2), ChosenColorFlagX - 2, ChosenColorFlagY - 2, 34, 34);
        }


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
            if(figure.Type !="")
            {
                    figure.StartX = e.X;
                    figure.StartY = e.Y;
            }
            MouseDownFlag = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            x2 = e.X;
            y2 = e.Y;
            if (MouseDownFlag == true && figure.Type== "")
            {
                g.DrawLine(new Pen(pencil.PencilColor, pencil.Width), x1, y1, x2, y2);
                pictureBox1.Invalidate();
                x1 = x2;
                y1 = y2;
            }

            else if (MouseDownFlag == true && figure.Type == "line")
            {
                figure.FinishX = e.X;
                figure.FinishY = e.Y;
            }
            else if (MouseDownFlag == true && figure.Type == "ellips")
            {
                figure.FinishX = e.X;
                figure.FinishY = e.Y;
            }
            else if (figure.Type == "rectangle")
            {

            }
            else if (figure.Type == "triangle")
            {

            }
            else if (figure.Type == "sqtriangle")
            {

            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDownFlag = false;
            pictureBox1.Image = picture;

            if (figure.Type == "line")
            {
                g.DrawLine(new Pen(pencil.PencilColor, pencil.Width), figure.StartX, figure.StartY, figure.FinishX, figure.FinishY);
                pictureBox1.Invalidate();
            }
            else if (figure.Type == "ellips")
            {
                figure.CorrectPosition();
                g.DrawEllipse(new Pen(pencil.PencilColor, pencil.Width), figure.StartX, figure.StartY, figure.Width, figure.Hight);
            }
        }

        private void MyForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (RBeraser.Checked == false)
            {
                Palette palette = new Palette();
                foreach (MyColors cl in palette.MyPalette)
                {
                    if (e.X >= cl.X && e.Y >= cl.Y && e.X <= cl.X + 30 && e.Y <= cl.Y + 30)
                    {
                        pencil.PencilColor = cl.color;
                        ChosenColorFlagX = cl.X;
                        ChosenColorFlagY = cl.Y;
                        this.Invalidate();
                    }
                }
            }
        }

        /*ПАНЕЛЬ ИНСТРУМЕНТОВ*/
        private void CBwidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tmp = CBwidth.SelectedItem;//толщина карадаша
            tmp = tmp.ToString().Substring(8, 1);
            pencil.Width = (float)Convert.ToDouble(tmp) + 1;
            tmp = null;
        }

        private void RBpencil_Click(object sender, EventArgs e)//карандаш
        {
            CBwidth.Enabled = true; //включить выбор толщины
            pencil.SetOldWidth(CBwidth.SelectedItem);
            if (figure.Type == "")
                pencil.PencilColor = pencil.PreviousColor;
            else
                figure.Type = "";
        }


        private void RBeraser_Click(object sender, EventArgs e)//ластик
        {
            figure.Type = "";
            CBwidth.Enabled = false;
            pencil.Width = 10;
            pencil.PreviousColor = pencil.PencilColor;
            pencil.PencilColor = Color.White;
        }
        private void RBline_Click(object sender, EventArgs e)
        {
            CBwidth.Enabled = true;
            figure = new Figure();
            figure.Type = "line";
            pencil.PencilColor = pencil.PreviousColor;
            pencil.SetOldWidth(CBwidth.SelectedItem);
        }

        private void RBellips_Click(object sender, EventArgs e)
        {
            figure = new Figure();
            figure.Type = "ellips";
        }

        private void RBrectangle_Click(object sender, EventArgs e)
        {

        }

        private void RBtriangle_Click(object sender, EventArgs e)
        {

        }

        private void RBsqtriangle_Click(object sender, EventArgs e)
        {

        }

        private void RBfilling_Click(object sender, EventArgs e)
        {
            CBwidth.Enabled = false;
        }


        /*ОБРАБОТКА КНОПОК*/
        private void ButtonCreate_Click(object sender, EventArgs e)//сбросить всё
        {
            picture = new Bitmap(StandartWidth, StandartHeight);
            pictureBox1.Size = picture.Size;
            pictureBox1.Image = picture;
            g = Graphics.FromImage(picture);
            g.Clear(Color.White);
        }
        private void ButtonSave_Click(object sender, EventArgs e)//сохранить
        {
            SaveFileDialog SaveDialog = new SaveFileDialog();
            SaveDialog.Title = "Сохранить изображение как ...";
            SaveDialog.Filter =
                "JPEG File(*.jpg)|*.jpg|" +
                "Bitmap File(*.bmp)|*.bmp|" +
                "PNG File(*.png)|*.png";
            //окно компактнее, есть "справка"
            SaveDialog.ShowHelp = true;
            if (SaveDialog.ShowDialog() == DialogResult.OK)
            {

                FileName = SaveDialog.FileName;//получает путь до файла, имя и формат
                FileFormat = FileName.Remove(0, FileName.Length - 3);//последние три символа - формат
                
                //сохранение в нужном формате
                try
                {
         //           picture = (Bitmap)pictureBox1.Image;
                    switch (FileFormat)
                    {
                        case "bmp":
                                picture.Save(FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                                break;
                        case "jpg":
                                picture.Save(FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                                break;
                        case "png":
                                picture.Save(FileName, System.Drawing.Imaging.ImageFormat.Png);
                                break;
                        default:
                            throw new Exception();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ButtonLoad_Click(object sender, EventArgs e)//загрузить
        {
            OpenFileDialog OpenDialog = new OpenFileDialog();
            OpenDialog.Filter =
                "JPEG File(*.jpg)|*.jpg|" +
                "Bitmap File(*.bmp)|*.bmp|" +
                "PNG File(*.png)|*.png";
            OpenDialog.ShowHelp = true;
            if(OpenDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = OpenDialog.FileName;
                picture = new Bitmap(FileName);


                if (picture.Height <= pictureBox1.Height || picture.Width <= pictureBox1.Width)
                {
                    pictureBox1.Size = picture.Size;
                    pictureBox1.Image = picture;
                }
                else
                {
                    pictureBox1.Height = StandartHeight;
                    pictureBox1.Width = StandartWidth;
                    pictureBox1.Image = picture;
                }
                pictureBox1.Invalidate();
                int p = 0;
            }
        }
    }
}
