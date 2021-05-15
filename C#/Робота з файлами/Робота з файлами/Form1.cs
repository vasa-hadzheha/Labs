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

namespace Робота_з_файлами
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
        }

        private void згенеруватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                dataGridView1[i, 0].Value = rand.Next(-100, 100);
            }
        }

        private void знайтиСумуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                sum += Convert.ToInt32(dataGridView1[i, 0].Value);
            }
            //MessageBox.Show(String.Format("Sum={0}", sum));
            textBox1.Text = sum.ToString();
        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter SW = new StreamWriter(saveFileDialog1.FileName);
                SW.WriteLine(dataGridView1.ColumnCount);
                for (int i = 0; i < numericUpDown1.Value; i++)
                {
                    SW.WriteLine(dataGridView1[i, 0].Value);
                }
                SW.Close();
            }
        }

        private void завантажитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //1.Відкрили файл для читання
                StreamReader SR = new StreamReader(openFileDialog1.FileName);
                //2.Читаємо дані
                numericUpDown1.Value = Convert.ToInt32(SR.ReadLine());
                for (int i = 0; i < numericUpDown1.Value; i++)
                {
                    dataGridView1[i, 0].Value = SR.ReadLine();
                }
                //3. Закриваємо
                SR.Close();
            }
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
