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
    public partial class ucTipoPaciente : UserControl
    {
        private Int32 K_Tipo_PacienteInt = 0;
        public Int32 K_Tipo_Paciente
        {
            get { return K_Tipo_PacienteInt; }
            set
            {
                K_Tipo_PacienteInt = value;
                SendPropertyChanged("K_Tipo_Paciente");
            }
        }
        public TextBox txt_Z_Tpo_Paciente
        {
            get { return this.txt_TipoPaciente; }
        }
        public ucTipoPaciente()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Aseguradora frm = new Busquedas.Frm_Busca_Aseguradora();
            frm.ShowDialog();

            if (K_Tipo_Paciente != frm.LLave_Seleccionado)
            {
                K_Tipo_Paciente = frm.LLave_Seleccionado;
                txt_TipoPaciente.Text = frm.Descripcion_Seleccionado;
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
