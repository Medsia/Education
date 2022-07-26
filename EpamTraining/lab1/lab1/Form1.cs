using System;
using System.IO;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        int i;
        private void button1_Click(object sender, EventArgs e)
        {
            string[] lines = textBox1.Lines;

            foreach (string line in lines)
            {

                string[] words = line.Trim().Split(',');    // Text Splitting
                foreach (var coordinate in words)
                {
                    if( i % 2==0 )
                    {
                        textBox1.Text += $"\r\nX: {coordinate.Trim().Replace(".", ",")} ";
                        i++;
                    }  
                    else
                    {
                        textBox1.Text += $"Y: {coordinate.Trim().Replace(".", ",")}";
                        i++;
                    }

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
            textBox1.Text = "23.8976,12.3218\n25.7639,11.9463\n24.8293,12.2134";
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e) // clear textBox
        {
            textBox1.Text = "";
        }
    }
}
