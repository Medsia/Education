using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("© Гузненок Д. А. , 2022", "About");
        }

        private void beginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConverterForm form = new ConverterForm();
            form.ShowDialog();
        }
    }
}
