using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Робота_з_файлами_та_гарфіком
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox3.Text);
            textBox2.Text = a.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = (int)numericUpDown1.Value;
            dataGridView1.RowCount = 2;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = (int)numericUpDown1.Value;
            згенеруватиToolStripMenuItem_Click(this, e);
        }

        private void згенеруватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1[i, 0].Value = rand.Next(-100, 100);
                dataGridView1[i, 1].Value = rand.Next(-100, 100);
            }
        }

        private void побудуватиГрафікToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                double x = Convert.ToDouble(dataGridView1[i,0].Value);
                double y = Convert.ToDouble(dataGridView1[i, 1].Value);
                chart1.Series[0].Points.AddXY(x,y);
            }
        }
        double f2(double x)
        {
            return x * x;
        }
        double f3(double x)
        {
            if (x == 0)
            {
             
            }
            return 1/x;
        }
        void drawFunction(double a,double b, Func<double, double> f,int pointsCount = 100)
        {
            chart1.Series[0].Points.Clear();
            double h = (b-a) / pointsCount;
            double x = a;
            while (x <= b)
            {
                chart1.Series[0].Points.AddXY(x, f(x));
                x += h;
            }
        }

        private void sinxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            drawFunction(a, b, Math.Sin);
        }

        private void cosxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            drawFunction(a, b, Math.Cos);
        }

        private void x2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            drawFunction(a, b, f2);
        }

        private void x3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            drawFunction(a, b, (x)=>x*x*x);
        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine(dataGridView1.ColumnCount);
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    sw.WriteLine(dataGridView1[i, 0].Value);
                    sw.WriteLine(dataGridView1[i, 1].Value);
                }
                sw.Close();
            }
        }

        private void завантажитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                numericUpDown1.Value = Convert.ToInt32(sr.ReadLine());
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    dataGridView1[i, 0].Value = sr.ReadLine();
                    dataGridView1[i, 1].Value = sr.ReadLine();
                }
                sr.Close();
            }
        }
    }
}
