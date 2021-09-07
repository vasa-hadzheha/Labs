using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Графіки_Перевірка
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = (int)numericUpDown1.Value;
            dataGridView1.RowCount = 2;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = (int)numericUpDown1.Value;
        }

        private void згенеруватиКоординатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    dataGridView1[i, j].Value = rand.Next(-10, 10);
                }
            }
        }

        private void намалюватиГрафікToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                double x = Convert.ToDouble(dataGridView1[i, 0].Value);
                double y = Convert.ToDouble(dataGridView1[i, 1].Value);
                chart1.Series[0].Points.AddXY(x, y);
            }
        }
        double f2(double x)
        {
            return x * x ;
        }
        void drawFunction(double a, double b, Func<double, double> f, int pointsCount = 100)
        {
            chart1.Series[0].Points.Clear();
            double h = (b - a) / pointsCount;
            double x = a;
            while (x <= b)
            {
                chart1.Series[0].Points.AddXY(x, f(x));
                x += h;
            }
        }

        private void xxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            drawFunction(a, b, (x) => x * x);
        }
    }
}
