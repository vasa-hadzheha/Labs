using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Завд._5_Вар._8_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            matrix.RowCount = (int)rowCount.Value;
            matrix.ColumnCount = (int)columnCount.Value;
            dataGridView1.RowCount = (int)rowCount.Value;
            dataGridView1.ColumnCount = (int)columnCount.Value;
            characteristic.RowCount = 1;
            characteristic.ColumnCount = (int)columnCount.Value;
        }

        private void rowCount_ValueChanged(object sender, EventArgs e)
        {
            matrix.RowCount = (int)rowCount.Value;
            dataGridView1.RowCount = (int)rowCount.Value;
        }

        private void columnCount_ValueChanged(object sender, EventArgs e)
        {
            matrix.ColumnCount = (int)columnCount.Value;
            characteristic.ColumnCount = (int)columnCount.Value;
            dataGridView1.ColumnCount = (int)columnCount.Value;
        }

        private void згенеруватиЕлементиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random random = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < matrix.RowCount; i++)
            {
                for (int j = 0; j < matrix.ColumnCount; j++)
                {
                    matrix[j, i].Value = random.Next(-20, 15);
                }
            }
            toolStripStatusLabel1.Text = "Згенеровано масив";
        }

        private void задатиХарактеристикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Створюємо масив і заповнюємо його елементами з DataGridView
            double[,] arr = new double[matrix.RowCount, matrix.ColumnCount];
            for (int i = 0; i < matrix.RowCount; i++)
            {
                for (int j = 0; j < matrix.ColumnCount; j++)
                {
                    arr[i, j] = Convert.ToDouble(matrix[j, i].Value);
                }
            }
            //Задаємо характеристику й добавляємо суму стовпців у новий масив
            double s = 0;
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (arr[j, i] < 0 && arr[j, i] % 2 != 0)
                    {
                        s += Math.Abs(arr[j,i]);
                    }
                    if (j == arr.GetLength(0) - 1)
                    {
                        characteristic[i, 0].Value = s;
                        s = 0;
                    }
                }
            }
            toolStripStatusLabel1.Text = "Задана характеристика";
        }

        private void посортуватиСтовпціЗаХарактеристикоюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // копія матриці
            double[,] arr = new double[matrix.RowCount, matrix.ColumnCount];
            for (int i = 0; i < matrix.RowCount; i++)
            {
                for (int j = 0; j < matrix.ColumnCount; j++)
                {
                    arr[i, j] = Convert.ToDouble(matrix[j, i].Value);
                }
            }
            // Копія матриці характеристика
            double[,] c = new double[1, characteristic.ColumnCount];

            for (int i = 0; i < characteristic.ColumnCount; i++)
            {
                c[0, i] = Convert.ToDouble(characteristic[i, 0].Value);
            }
            //Сортуємо матрицю
            for (int i = 0; i < c.GetLength(1) - 1; i++)
            {
                int maxInd = i;
                for (int j = i + 1; j < c.GetLength(1); j++)
                {
                    if (c[0, j] > c[0, maxInd])
                    {
                        maxInd = j;
                    }
                }
                if (i != maxInd)
                {
                    //сортуємо одновимірний масив
                    double z = c[0, i];
                    c[0, i] = c[0, maxInd];
                    c[0, maxInd] = z;
                    //міняємо стовпці матриці
                    for (int m = 0; m < arr.GetLength(0); m++)
                    {
                        double k = arr[m, i];
                        arr[m, i] = arr[m, maxInd];
                        arr[m, maxInd] = k;
                    }

                }
            }
            //передаємо відсортовану матрицю в dataGrid
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1[j, i].Value = arr[i, j];
                }
            }
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
