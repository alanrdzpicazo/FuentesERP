using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbeMedic
{
    public partial class MsgBox : Forma
    {
        

        public MsgBox()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Show(string message, string title)
        {
            this.txt_mensaje.Text = message;
            this.lbl_titulo.Text = title;
            this.ShowDialog();
        }
    }
}
