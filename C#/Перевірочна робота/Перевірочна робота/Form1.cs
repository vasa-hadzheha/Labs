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

namespace Перевірочна_робота
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
            dataGridView1.RowCount = (int)numericUpDown1.Value;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = (int)numericUpDown1.Value;
            dataGridView1.RowCount = (int)numericUpDown1.Value;
        }

        private void згенеруватиЕлементиToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void знайтиКількістьПарнихЕлементівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //копія матриці
            //double [,]arr = new double[dataGridView1.ColumnCount, dataGridView1.RowCount];
            //for (int i = 0; i < dataGridView1.ColumnCount; i++)
            //{
            //    for (int j = 0; j < dataGridView1.RowCount; j++)
            //    {
            //        arr[i, j] = Convert.ToDouble(dataGridView1[i, j].Value);
            //    }
            //}
            int dualEl = 0;
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    if (Convert.ToDouble(dataGridView1[i,j].Value) % 2 == 0)
                    {
                        dualEl++;
                    }
                }
            }
            textBox1.Text = dualEl.ToString();
        }

        private void зберегиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine(dataGridView1.ColumnCount);
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    for (int j = 0; j < dataGridView1.RowCount; j++)
                    {
                        sw.WriteLine(dataGridView1[i, j].Value);
                    }
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
                    for (int j = 0; j < dataGridView1.RowCount; j++)
                    {
                        dataGridView1[i, j].Value = sr.ReadLine();
                    }
                }
                sr.Close();
            }
        }

        private void знайтиКількістьНулівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int zeroCount = 0;
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    if (Convert.ToInt32(dataGridView1[i, j].Value) == 0)
                    {
                        zeroCount++;
                    }
                }
            }
            MessageBox.Show(String.Format("Count zero = {0}",zeroCount));
        }

        private void зберегтиБінарнийФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream FS = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                BinaryWriter BW = new BinaryWriter(FS);
                BW.Write(dataGridView1.ColumnCount);

                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    for (int j = 0; j < dataGridView1.RowCount; j++)
                    {
                        BW.Write(Convert.ToInt32(dataGridView1[i, j].Value));
                    }
                }
                FS.Close();
                BW.Close();
            }
        }

        private void зToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream FS1 = new FileStream(openFileDialog1.FileName, FileMode.Open);
                BinaryReader BR = new BinaryReader(FS1);
                numericUpDown1.Value = BR.ReadInt32();
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    for (int j = 0; j < dataGridView1.RowCount; j++)
                    {
                        dataGridView1[i, j].Value = BR.ReadInt32();
                    }
                }
                BR.Close();
                FS1.Close();

            }
        }
    }
}
