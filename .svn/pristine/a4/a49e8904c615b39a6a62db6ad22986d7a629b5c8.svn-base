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
    public partial class ucExtraeOficinaEnfermeria : UserControl
    {
        public ucExtraeOficinaEnfermeria()
        {
            InitializeComponent();
        }

 
        SQLCatalogos catalogos_sql = new SQLCatalogos();
        SQLVentas sqlventas = new SQLVentas();

        public Int32 K_Pais = 0, K_Estado = 0, K_Ciudad = 0, K_Oficina = 0, K_Colonia = 0;

        public bool B_Local = false;

        public TextBox txt_G_Pais
        {
            get { return this.txt_Z_Pais; }
        }
        public TextBox txt_G_Estado
        {
            get { return this.txt_Z_Estado; }
        }
        public TextBox txt_G_Ciudad
        {
            get { return this.txt_Z_Ciudad; }
        }
        public TextBox txt_G_Colonia
        {
            get { return this.txt_Z_Colonia; }
        }
        public TextBox txt_G_Oficina
        {
            get { return this.txt_Z_Oficina; }
        }
        public Button btn_G_Pais
        {
            get { return this.btn_Pais; }
        }
        public Button btn_G_Estado
        {
            get { return this.btn_Estado; }
        }
        public Button btn_G_Ciudad
        {
            get { return this.btn_Ciudad; }
        }
        public Button btn_G_Colonia
        {
            get { return this.btn_Colonia; }
        }


        private void btn_Colonia_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Colonia frm = new Busquedas.Frm_Busca_Colonia(K_Pais, K_Estado, K_Ciudad);
            frm.ShowDialog();

            if (K_Colonia != frm.LLave_Seleccionado)
            {
                K_Colonia = frm.LLave_Seleccionado;
                txt_Z_Colonia.Text = frm.Descripcion_Seleccionado;

                K_Oficina = 0;
                BuscarOficina();

            }

        }

        private void btn_Pais_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Pais frm = new Busquedas.Frm_Busca_Pais();
            frm.ShowDialog();


            K_Pais = frm.LLave_Seleccionado;
            txt_Z_Pais.Text = frm.Descripcion_Seleccionado;

            K_Estado = 0;
            txt_Z_Estado.Text = string.Empty;

            K_Ciudad = 0;
            txt_Z_Ciudad.Text = string.Empty;

            K_Colonia = 0;
            txt_Z_Colonia.Text = string.Empty;
        }

        private void btn_Estado_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Estado frm = new Busquedas.Frm_Busca_Estado(K_Pais);
            frm.ShowDialog();

            if (K_Estado != frm.LLave_Seleccionado)
            {
                K_Estado = frm.LLave_Seleccionado;
                txt_Z_Estado.Text = frm.Descripcion_Seleccionado;

                K_Ciudad = 0;
                txt_Z_Ciudad.Text = string.Empty;

                K_Colonia = 0;
                txt_Z_Colonia.Text = string.Empty;
            }
        }

        private void btn_Ciudad_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Ciudad frm = new Busquedas.Frm_Busca_Ciudad(K_Pais, K_Estado);
            frm.ShowDialog();

            if (K_Ciudad != frm.LLave_Seleccionado)
            {
                K_Ciudad = frm.LLave_Seleccionado;
                txt_Z_Ciudad.Text = frm.Descripcion_Seleccionado;

                K_Colonia = 0;
                txt_Z_Colonia.Text = string.Empty;

            }
        }

        private void BuscarOficina()
        {

            try
            {
                DataTable datos = new DataTable();
                datos = sqlventas.GP_Extrae_OficinaEnfermeria(K_Pais, K_Estado, K_Ciudad, K_Colonia);
                DataRow row = datos.Rows[0];
                this.txt_Z_Oficina.Text = row["D_Oficina"].ToString();
                K_Oficina = Convert.ToInt16(row["K_Oficina"]);
                B_Local = Convert.ToBoolean(row["B_Local"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("NO HAY COBERTURA EN LA COLONIA ESPECIFICADA..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                K_Oficina = 0;
                txt_G_Oficina.Text = string.Empty;

            }
        }
    }
}
