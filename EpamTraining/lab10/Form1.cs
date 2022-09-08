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

namespace lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string[] lines = textBox1.Lines;
            int i = 1;
            //textBox1.Clear();
            foreach (string line in lines)
            {            
                string[] words = line.Trim().Split(',');    // Text Splitting
                textBox1.Text += ($"  {words[0]}");
                foreach (var coordinate in words)
                {
                    if (i > words.Length - 1)
                        break;
                    textBox1.Text += ($",[{i}]{words[i]}");
                    i++;
                }
            }



        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)   // Open file
        {
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)  // save file
        {
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
            }
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e) // input test text
        {
            textBox1.Text = "У меня 10 долларов, 3 яблока, 5 апельсинов.";
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e) // clear textBox
        {
            textBox1.Text = "";
        }
    }
}
