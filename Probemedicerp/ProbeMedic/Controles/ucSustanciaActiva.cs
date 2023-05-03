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
    public partial class ucSustanciaActiva : UserControl
    {
        public Int32 K_Sustancia_Activa = 0;
        public TextBox txt_SA_D_Sustancia_Activa
        {
            get { return this.txtSustanciaActiva; }
        }

        public ucSustanciaActiva()
        {
            InitializeComponent();
        }

        private void btn_BuscaSustanciaActiva_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Sustancia_Activa frm = new Busquedas.Frm_Busca_Sustancia_Activa();
            frm.ShowDialog();

            if (K_Sustancia_Activa != frm.LLave_Seleccionado)
            {
               K_Sustancia_Activa = frm.LLave_Seleccionado;
               txt_SA_D_Sustancia_Activa.Text = frm.Descripcion_Seleccionado;
               SendPropertyChanged("K_Sustancia_Activa");
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
