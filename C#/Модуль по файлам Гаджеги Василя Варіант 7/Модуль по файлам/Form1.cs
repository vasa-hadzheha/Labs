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

namespace Модуль_по_файлам
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = (int)Rows.Value;
            dataGridView1.ColumnCount = (int)Columns.Value;
        }

        private void Rows_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.RowCount = (int)Rows.Value;
        }

        private void Columns_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = (int)Columns.Value;
        }

        private void згенеруватиЕлементиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    dataGridView1[i, j].Value = rand.Next(-5, 5);
                }
            }
        }

        private void знайтиСумуЗаУмовоюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //створюємо новий масий в який копіюємо всі елементи dataGridView1
            double[,] arr = new double[dataGridView1.ColumnCount, dataGridView1.RowCount];
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    arr[i, j] = Convert.ToDouble(dataGridView1[i, j].Value);
                }
            }
            //знаходимо суму за умовою
            double s = 0;
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    if (arr[i, j] < 0)
                    {
                        break;
                    }
                    s += arr[i, j];
                }
                    if (arr[i, 0]<0)
                    {
                        break;
                    }
            }
            //Виводимо найбільший елемент у textBox
            textBox1.Text = s.ToString();
        }

        private void знайтиСкалярнийДобутокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //створюємо новий масий в який копіюємо всі елементи dataGridView1
            double[,] arr = new double[dataGridView1.ColumnCount, dataGridView1.RowCount];
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    arr[i, j] = Convert.ToDouble(dataGridView1[i, j].Value);
                }
            }
            //починаємо рахунок від нуля
            int a = Convert.ToInt32(textBox2.Text);
            int b = Convert.ToInt32(textBox3.Text);
            double[] iRow = new double[dataGridView1.ColumnCount];
            double[] jColumn = new double[dataGridView1.RowCount];
            double scalDob = 0;
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                iRow[i] = arr[i, a];
            }
            for (int j = 0; j < dataGridView1.RowCount; j++)
            {
                jColumn[j] = arr[b, j];
            }
            //Знаходимо скалярний добуток
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                scalDob += iRow[i] * jColumn[i];
            }
            textBox4.Text = scalDob.ToString();
        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sr = new StreamWriter(saveFileDialog1.FileName);
                sr.WriteLine(dataGridView1.ColumnCount);
                sr.WriteLine(dataGridView1.RowCount);
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    for (int j = 0; j < dataGridView1.RowCount; j++)
                    {
                        sr.WriteLine(dataGridView1[i, j].Value);
                    }
                    //sr.WriteLine("-----------------------");
                }
                sr.Close();
            }
        }

        private void завантажитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                Columns.Value = Convert.ToInt32(sr.ReadLine());
                Rows.Value = Convert.ToInt32(sr.ReadLine());
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    for (int j = 0; j < dataGridView1.RowCount; j++)
                    {
                        dataGridView1[i, j].Value = sr.ReadLine();
                    }
                }
                sr.Close();
            }
        }

        private void побудуватиГрафікToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                double x = Convert.ToDouble(dataGridView1[i, 0].Value);
                double y = Convert.ToDouble(dataGridView1[i, 1].Value);
                chart1.Series[0].Points.AddXY(x, y);
            }
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

        private void визначитиЧиФункціяЄВємноВизначеноюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if(drawFunction(Convert.ToInt32(textBox2), Convert.ToInt32(textBox2),){ }
        }
    }
}
