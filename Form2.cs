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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Form1 fd = new Form1())
            {
                fd.a = 1;
                fd.b = 0;
                fd.ShowDialog();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Form1 fd = new Form1())
            {
                fd.a = 5;
                fd.b = 1;
                fd.ShowDialog();
            }
        }
    }
}
