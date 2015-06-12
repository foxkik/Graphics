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
        float ChosenColorFlagX = 1050; //выбранный цвет палитры
        float ChosenColorFlagY = 520;
        int StandartHeight = 598, StandartWidth = 942;
        Pencil pencil;

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
            g = Graphics.FromImage(picture);
            g.Clear(Color.White);
            pictureBox1.BackColor = Color.White;
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
            MouseDownFlag = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseDownFlag==true)
            {
                x2 = e.X;
                y2 = e.Y;
                g = Graphics.FromImage(picture);
                g.DrawLine(new Pen(pencil.PencilColor, pencil.Width), x1, y1, x2, y2);
                pictureBox1.Image = picture;
                pictureBox1.Invalidate();
                x1 = x2;
                y1 = y2;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDownFlag = false;
        }

        

        private void MyForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (RBpencil.Checked == true)
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
            if (CBwidth.SelectedItem != null) //присваивание выбранной толщины
            {
                var tmp = CBwidth.SelectedItem;
                tmp = tmp.ToString().Substring(8, 1);
                pencil.Width = (float)Convert.ToDouble(tmp) + 1;
                tmp = null;
            }
            else
                pencil.Width = 2; //выставление варианта по умолчанию
            pencil.PencilColor = pencil.PreviousColor;
        }

        private void RBeraser_Click(object sender, EventArgs e)//ластик
        {
            CBwidth.Enabled = false;
            pencil.Width = 10;
            pencil.PreviousColor = pencil.PencilColor;
            pencil.PencilColor = Color.White;
        }

        /*ОБРАБОТКА КНОПОК*/
        private void ButtonCreate_Click(object sender, EventArgs e)//сбросить всё
        {
            picture = new Bitmap(StandartWidth, StandartHeight);
            pictureBox1.Size = picture.Size;
            pictureBox1.Image = picture;
            Graphics gi = Graphics.FromImage(picture);
            gi.Clear(Color.White);
        }
        private void ButtonSave_Click(object sender, EventArgs e)//сохранить
        {
            SaveFileDialog SaveDialog = new SaveFileDialog();
            SaveDialog.Title = "Сохранить изображение как ...";
            SaveDialog.Filter =
                "Bitmap File(*.bmp)|*.bmp|" +
                "JPEG File(*.jpg)|*.jpg|" +
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
                    picture = (Bitmap)pictureBox1.Image;
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
            OpenDialog.Filter = "Bitmap File(*.bmp)|*.bmp|" +
                "JPEG File(*.jpg)|*.jpg|" +
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

                pictureBox1.Invalidate();
                int p = 0;
            }
        }
    }
}
