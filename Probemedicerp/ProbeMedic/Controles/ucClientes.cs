using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;


namespace ProbeMedic.Controles
{
    public partial class ucClientes : UserControl
    {
        //public Int32 K_Empresa = 0;
        public Int32 K_Cliente = 0;
        public TextBox txt_Cliente
        {
            get { return this.txtCliente; }
        }

        SQLSeguridad sqlSeguridad = new SQLSeguridad();
        public ucClientes()
        {
            InitializeComponent();

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Cliente frm = new Busquedas.Frm_Busca_Cliente(GlobalVar.K_Empresa);
            frm.ShowDialog();

            if (K_Cliente != frm.LLave_Seleccionado)
            {
                K_Cliente= frm.LLave_Seleccionado;
                txt_Cliente.Text = frm.Descripcion_Seleccionado;
                ncliente = frm.LLave_Seleccionado;
            }
  
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }
        private int _cliente;
        public int ncliente
        {
            get { return _cliente; }
            set
            {

                _cliente = value;
                SendPropertyChanged("ncliente");

            }
        }

        private void SendPropertyChanged(string property)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }


        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}
