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
    public partial class Geo_Colonia : UserControl
    {
        public int PCodigo_Postal { get; set; }

        public Int32 K_Pais = 0, K_Estado = 0, K_Ciudad = 0,K_Colonia=0;

        public TextBox txt_G_Pais
        {
            get { return this.txt_D_Pais; }
        }

        public TextBox txt_G_Estado
        {
            get { return this.txt_D_Estado; }
        }

        public TextBox txt_G_Ciudad
        {
            get { return this.txt_D_Ciudad; }
        }

        public TextBox txt_G_Colonia
        {
            get
            {
                return this.txt_D_Colonia;
            }
           
        }
        
        public Geo_Colonia()
        {
            InitializeComponent();
        }

        private int _codigopostal;
        public int Codigo_Postal
        {
            get
            {
                return _codigopostal;
            }
            set
            {
                _codigopostal = value;
                SendPropertyChanged("K_Colonia");
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

        private void btn_Pais_Click(object sender, EventArgs e)
        {
            txt_D_Estado.Text = "";
            K_Estado = 0;
            txt_D_Ciudad.Text = "";
            K_Ciudad = 0;
            txt_D_Colonia.Text = "";
            K_Colonia = 0;
            Busquedas.Frm_Busca_Pais frm = new Busquedas.Frm_Busca_Pais();
            frm.ShowDialog();

            K_Pais = frm.LLave_Seleccionado;
            txt_D_Pais.Text = frm.Descripcion_Seleccionado;

            K_Estado = 0;
            txt_D_Estado.Text = string.Empty;

            K_Ciudad = 0;
            txt_D_Ciudad.Text = string.Empty;
        }

        private void Geo_Colonia_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Estado_Click(object sender, EventArgs e)
        {
            txt_D_Ciudad.Text = "";
            K_Ciudad = 0;
            txt_D_Colonia.Text = "";
            K_Colonia = 0;
            Busquedas.Frm_Busca_Estado frm = new Busquedas.Frm_Busca_Estado(K_Pais);
            frm.ShowDialog();

            if (K_Estado != frm.LLave_Seleccionado)
            {
                K_Estado = frm.LLave_Seleccionado;
                txt_D_Estado.Text = frm.Descripcion_Seleccionado;

                K_Ciudad = 0;
                txt_D_Ciudad.Text = string.Empty;
            }
        }

        private void btn_Ciudad_Click(object sender, EventArgs e)
        {
            txt_D_Colonia.Text = "";
            K_Colonia = 0;
            Busquedas.Frm_Busca_Ciudad frm = new Busquedas.Frm_Busca_Ciudad(K_Pais, K_Estado);
            frm.ShowDialog();

            if (K_Ciudad != frm.LLave_Seleccionado)
            {
                K_Ciudad = frm.LLave_Seleccionado;
                txt_D_Ciudad.Text = frm.Descripcion_Seleccionado;
            }
        }

        private void btn_Colonia_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Colonia frm = new Busquedas.Frm_Busca_Colonia(K_Pais, K_Estado,K_Ciudad);
            frm.ShowDialog();

            if (K_Colonia != frm.LLave_Seleccionado)
            {
                K_Colonia = frm.LLave_Seleccionado;
                Codigo_Postal = frm.LLave_Seleccionado;
                txt_D_Colonia.Text = frm.Descripcion_Seleccionado;      
            }
        }

      
    }
}
