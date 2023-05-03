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
    public partial class ucLaboratorio : UserControl
    {
        SQLSeguridad sqlSeguridad = new SQLSeguridad();

        public Int32 K_Laboratorio = 0;
        public TextBox txt_L_D_Laboratorio
        {
            get { return this.txtLaboratorio; }
        }


        public ucLaboratorio()
        {
            InitializeComponent();
        }

        private void btn_BuscaLaboratorio_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Laboratorio frm = new Busquedas.Frm_Busca_Laboratorio();
            frm.ShowDialog();

            if (K_Laboratorio != frm.LLave_Seleccionado)
            {
                K_Laboratorio = frm.LLave_Seleccionado;
                txt_L_D_Laboratorio.Text = frm.Descripcion_Seleccionado;
                SendPropertyChanged("K_Laboratorio");
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
