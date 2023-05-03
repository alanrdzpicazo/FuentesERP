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
    public partial class Ctrl_CuadroTotal : UserControl
    {
        public TextBox txt_G_Subtotal
        {
            get { return this.txtSubtotal; }
        }

        public TextBox txt_G_Descuento
        {
            get { return this.txtDescuento; }
        }

        public TextBox txt_G_IEPS
        {
            get { return this.txtIEPS; }
        }

        public TextBox txt_G_IVA
        {
            get { return this.txtIVA; }
        }

        public TextBox txt_G_Total
        {
            get { return this.txtTotal; }
        }
        public Ctrl_CuadroTotal()
        {
            InitializeComponent();
        }
    }
}
