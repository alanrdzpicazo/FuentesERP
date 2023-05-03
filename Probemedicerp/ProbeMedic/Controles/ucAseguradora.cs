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
    public partial class ucAseguradora : UserControl
    {
        private Int32 K_AseguradoraInt=0;
        public Int32 K_Aseguradora
        {
            get { return K_AseguradoraInt; }
            set
            {
                K_AseguradoraInt = value;
                SendPropertyChanged("K_Aseguradora");
            }
        }
        public TextBox txt_Z_Aseguradora
        {
            get { return this.txt_Aseguradora; }
        }

        SQLSeguridad sqlSeguridad = new SQLSeguridad();

        public ucAseguradora()
        {
            InitializeComponent();
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Aseguradora frm = new Busquedas.Frm_Busca_Aseguradora();
            frm.ShowDialog();

            if (K_Aseguradora != frm.LLave_Seleccionado)
            {
                K_Aseguradora = frm.LLave_Seleccionado;
                txt_Aseguradora.Text = frm.Descripcion_Seleccionado;
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

        private void txt_Aseguradora_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
