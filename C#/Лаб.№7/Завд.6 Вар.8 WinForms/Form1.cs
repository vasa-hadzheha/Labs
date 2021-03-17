using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Завд._6_Вар._8_WinForms
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
        }

        private void rowCount_ValueChanged(object sender, EventArgs e)
        {
            matrix.RowCount = (int)rowCount.Value;
        }

        private void columnCount_ValueChanged(object sender, EventArgs e)
        {
            matrix.ColumnCount = (int)columnCount.Value;
        }

        private void задатиЕлементиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random random = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < matrix.RowCount; i++)
            {
                for (int j = 0; j < matrix.ColumnCount; j++)
                {
                    matrix[j, i].Value = random.Next(-10, 20);
                }
            }
            toolStripStatusLabel1.Text = "Згенеровано масив";
        }

        private void знайтиСумуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double s = 0;
            for (int i = 0; i < (int)columnCount.Value; i++)
            {
                for (int j = 0; j < (int)rowCount.Value; j++)
                {
                    if (Convert.ToDouble(matrix[i,j].Value) < 0 && j == i)
                    {
                        s += Convert.ToDouble(matrix[i, j].Value);
                    }

                }
            }
            if (s == 0)
            {
                toolStripStatusLabel1.Text = "Елементів що задовльняють умову не знайшлося, тому sum=0;";
            }
            toolStripStatusLabel1.Text = "Сума = "+ s.ToString();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
