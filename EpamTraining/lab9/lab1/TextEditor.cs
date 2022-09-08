using System;
using System.IO;
using System.Windows.Forms;

namespace lab9
{
    public partial class TextEditor : Form
    {
        
        public TextEditor()
        {
            InitializeComponent();
        }
        
        private void openToolStripMenuItem_Click(object sender, EventArgs e)   // Open file
        {
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void savetoToolStripMenuItem_Click(object sender, EventArgs e)  // save file
        {
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
            }
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e) // input test text
        {
            textBox1.Text = "Строка — это последовательная коллекция символов, используемых для представления текста." +
                " String Объект — это последовательная коллекция System.Char объектов, представляющих строку;" +
                " System.Char объект соответствует единице кода UTF-16." +
                " Значение String объекта — это содержимое последовательной коллекции System.Char объектов," +
                " и это значение неизменяемо (то есть оно доступно только для чтения).";
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e) // clear textBox
        {
            textBox1.Text = "";
        }
    }
}
