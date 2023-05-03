using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbeMedic.Controles
{
    public partial class ucInteger32 : UserControl
    {
        public TextBox valor
        {
            get { return this.textBox1; }
        }
        public ucInteger32()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((Char.IsNumber(e.KeyChar) ||(e.KeyChar == Convert.ToChar(Keys.Back))))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length > 0)
            {
                try
                {
                    Int32 valor = Convert.ToInt32(textBox1.Text.Trim());
                }
                catch (Exception ex)
                {

                    MessageBox.Show("VALOR DEMASIADO GRANDE!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Text = "";

                }
            }
            else
            {
                textBox1.Text = "";
            }
        }
    }
}
