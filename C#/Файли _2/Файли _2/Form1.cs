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

namespace Файли__2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName,RichTextBoxStreamType.PlainText);
            }
        }

        private void завантажитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void посортуватиПоФайлахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                StreamWriter sw = new StreamWriter("Посортоване.txt");
                while (!sr.EndOfStream)
                {
                    string[] wordArr = sr.ReadLine().Split(new char[] { ' ', ',', ';','-' });
                    foreach (var word in wordArr)
                    {
                        if (word.Length > 5)
                        {
                            sw.WriteLine(word);
                        }
                    } 
                }
                sr.Close();
                sw.Close();
            }
        }
    }
}
