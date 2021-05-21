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

namespace Завд._1_Вар._8
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
            dataGridView1.RowCount = 1;
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
            }
        }

        private void знайтиНайбільшийВідємнийЕлементToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[,] arr = new double[dataGridView1.RowCount, dataGridView1.ColumnCount];
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    arr[i, j] = Convert.ToDouble(dataGridView1[j, i].Value);
                }
            }

            double minmax = -1000000;
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                if (arr[0,i] < 0 && arr[0,i] > minmax)
                {
                    minmax = arr[0,i];
                }
            }
            textBox1.Text = minmax.ToString();
        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine(dataGridView1.ColumnCount);
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    sw.WriteLine(dataGridView1[i, 0].Value);
                }
                sw.Close();
            }
        }

        private void завантажитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                numericUpDown1.Value = Convert.ToInt32( sr.ReadLine());
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    dataGridView1[i,0].Value = sr.ReadLine();
                }
                sr.Close();
            }
        }
    }
}
