using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_car_racing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
        public int a = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(a);
        }

        void moveline(int speed)
        {
            if (pictureBox1.Top >= 500)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }

            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }

            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }

            if (pictureBox5.Top >= 500)
            {
                pictureBox5.Top = 0;
            }
            else
            {
                pictureBox5.Top += speed;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) car.Left -= 4;
            if (e.KeyCode == Keys.Left) car.Left += 4;
        }
        public int b=0;
        private void Form1_Load_1(object sender, EventArgs e)
        {
            if (b == 1)
            { 
                Image image = Image.FromFile("C:/Users/jame1/Downloads/car.png");
                pictureBox1.Image = image;
                pictureBox1.Height = 177;
                pictureBox1.Width = 147;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            }
            if (b == 0)
            {
                Image image = Image.FromFile("C:/Users/jame1/Downloads/sport-car.png");
                pictureBox1.Image = image;
                pictureBox1.Height = 177;
                pictureBox1.Width = 147;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
