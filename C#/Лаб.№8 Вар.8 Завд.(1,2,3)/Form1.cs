using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаб._5_Вар._8_Завд._1_2_3_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double z = Convert.ToDouble(textBox3.Text);
            double upper = Funkcions.getmax(x, y, z) + Funkcions.getmax(x + y, x * y, 4 * z);
            double lower = Funkcions.getmax(Math.Pow(Funkcions.getmax(x + y, x * y, x * x), 2), 7, z*z);
            double answ = upper / lower;
            textBox4.Text = answ.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x1 = Convert.ToDouble(x_1.Text);
            double y1 = Convert.ToDouble(y_1.Text);
            double x2 = Convert.ToDouble(x_2.Text);
            double y2 = Convert.ToDouble(y_2.Text);
            if (Funkcions.angle(x1,y1,x2,y2)<90)
            {
                textBox8.Text = "гострокутний";
            }
            else if (Funkcions.angle(x1, y1, x2, y2)==90)
            {
                textBox8.Text = "прямокутний";
            }
            else
            {
                textBox8.Text = "тупокутний";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
