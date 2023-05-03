using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;

namespace ProbeMedic.FILTROS
{
    public partial class Frm_Filtra_Colonia : Frm_Filtro
    {
        public DataTable dtFiltra;
        SQLCatalogos sql_catalogo = new SQLCatalogos();

        public Frm_Filtra_Colonia()
        {
            InitializeComponent();
            geo_Ciudades1.K_Pais = 1;
            geo_Ciudades1.txt_G_Pais.Text = "MEXICO";

            geo_Ciudades1.K_Estado = 1;
            geo_Ciudades1.txt_G_Estado.Text = "AGUASCALIENTES";

        }

        public override void Filtra()
        {

            if (geo_Ciudades1.K_Ciudad > 0)
            {
                dtFiltra = sql_catalogo.SK_Colonia(geo_Ciudades1.K_Pais, geo_Ciudades1.K_Estado, geo_Ciudades1.K_Ciudad, txt_D_Ciudad.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("TIENE QUE ESPECIFICAR LA CIUDAD", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    
        private void txt_D_Ciudad_Leave(object sender, EventArgs e)
        {
            Filtra();
        }

        private void txt_D_Ciudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((Char.IsLetter(e.KeyChar)) || (e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
