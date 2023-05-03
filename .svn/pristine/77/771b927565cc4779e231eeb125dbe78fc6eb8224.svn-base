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
    public partial class ucOficinas : UserControl
    {
        public Int32 K_Oficina = 0;
        public Int32 K_Empresa= 0;
        public TextBox txt_E_Oficina
        {
            get { return this.txt_Oficina; }
        }

        #region
        private int KOficina;

        public int kOficina
        {
            get { return KOficina; }
            set
            {
                KOficina= value;
                SendPropertyChanged("kOficina");
            }
        }
        #endregion

        public ucOficinas()
        {
            InitializeComponent();
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

        private void btn_BuscarOficina_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Oficina frm = new Busquedas.Frm_Busca_Oficina(K_Empresa);
            frm.ShowDialog();

            K_Oficina = frm.LLave_Seleccionado;
            kOficina = frm.LLave_Seleccionado;
            txt_Oficina.Text = frm.Descripcion_Seleccionado;
        }
    }
}
