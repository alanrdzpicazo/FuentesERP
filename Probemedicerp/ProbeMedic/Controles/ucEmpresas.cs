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
    public partial class ucEmpresas : UserControl
    {
        public Int32 K_Empresa = 0;
        public TextBox txt_E_Empresa;
        public TextBox txt_G_Empresa
        {
            get { return this.txt_D_Empresa; }
        }
        public ucEmpresas()
        {
            InitializeComponent();
            txt_D_Empresa.CharacterCasing = CharacterCasing.Upper;
        }
        private void txt_D_Empresa_TextChanged(object sender, EventArgs e)
        {
            if (txt_D_Empresa.Text.Length == 0)
            {
                K_Empresa = 0;
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Empresa frm = new Busquedas.Frm_Busca_Empresa();
            frm.ShowDialog();

            K_Empresa = frm.LLave_Seleccionado;
            txt_D_Empresa.Text = frm.Descripcion_Seleccionado;
            kEmpresa = frm.LLave_Seleccionado;
        }
        #region
        private int KEmpresa;

        public int kEmpresa
        {
            get { return KEmpresa; }
            set
            {
                KEmpresa = value;
                SendPropertyChanged("kEmpresa");
            }
        }
        #endregion
        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
        private void SendPropertyChanged(string property)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
