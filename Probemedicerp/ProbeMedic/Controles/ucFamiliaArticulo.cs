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
    public partial class ucFamiliaArticulo : UserControl
    {
        SQLSeguridad sqlSeguridad = new SQLSeguridad();

        public Int32 K_Familia_Articulo = 0;
        public TextBox txt_FA_D_Familia_Articulo
        {
            get { return this.txtFamiliaArticulo; }
        }


        public ucFamiliaArticulo()
        {
            InitializeComponent();
 
        }

        private void btn_BuscaFamArt_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Familia_Articulo frm = new Busquedas.Frm_Busca_Familia_Articulo();
            frm.ShowDialog();

            if (K_Familia_Articulo!= frm.LLave_Seleccionado)
            {
                K_Familia_Articulo = frm.LLave_Seleccionado;
                txt_FA_D_Familia_Articulo.Text = frm.Descripcion_Seleccionado;
                SendPropertyChanged("K_Familia_Articulo");
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
