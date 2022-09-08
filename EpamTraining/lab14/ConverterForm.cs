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
    public partial class ConverterForm : Form
    {
        public ConverterForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDO_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton2.Checked)
                {
                    uint i = Convert.ToUInt32(InputTextBox.Text);
                    LabelResult.Text = Convert.ToString(i, 2);
                }
                if (radioButton8.Checked)
                {
                    uint i = Convert.ToUInt32(InputTextBox.Text);
                    LabelResult.Text = Convert.ToString(i, 8);
                }
                if (radioButton16.Checked)
                {
                    uint i = Convert.ToUInt32(InputTextBox.Text);
                    LabelResult.Text = Convert.ToString(i, 16);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Wrong value\n" + ex.Message, "Exception");
            }
        }
    }
}
