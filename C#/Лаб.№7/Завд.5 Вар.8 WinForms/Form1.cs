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
            characteristic.RowCount = 1;
            characteristic.ColumnCount = (int)columnCount.Value;
        }

        private void rowCount_ValueChanged(object sender, EventArgs e)
        {
            matrix.RowCount = (int)rowCount.Value;
        }

        private void columnCount_ValueChanged(object sender, EventArgs e)
        {
            matrix.ColumnCount = (int)columnCount.Value;
            characteristic.ColumnCount = (int)columnCount.Value;
        }

        private void згенеруватиЕлементиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random random = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < matrix.RowCount; i++)
            {
                for (int j = 0; j < matrix.ColumnCount; j++)
                {
                    matrix[j, i].Value = random.Next(1, 11);
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
            int k = 0;
            double[] c = new double[(int)columnCount.Value];
            for (int i = 0; i < (int)columnCount.Value; i++)
            {
                for (int j = 0; j < (int)rowCount.Value; j++)
                {
                    if (arr[j, i] < 0 && arr[j, i] % 2 != 0)
                    {
                        s += Math.Abs(arr[j, i]);
                    }
                    if (j == arr.GetLength(0) - 1)
                    {
                        c[k] = s;
                        s = 0;
                        k += 1;
                    }
                }
            }

            for (int i = 0; i < c.GetLength(0)-1; i++)
            {
                for (int j = 0; j < c.GetLength(0); j++)
                {

                }
            }
            for (int i = 0; i < (int)columnCount.Value; i++)
            {
                characteristic[1,i].Value= c[i];
            }
        }
    }
}
