using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;

namespace ProbeMedic.FILTROS
{
    public partial class Frm_Filtra_Ciudades : Frm_Filtro

    {
        public DataTable dtFiltra;
        SQLCatalogos sql_catalogo = new SQLCatalogos();

        public Frm_Filtra_Ciudades()
        {
            InitializeComponent();
            geo_Pais1.K_Pais = 1;
            geo_Pais1.txt_G_Pais.Text = "MEXICO";
        }
        public override void Filtra()
        {

            if (geo_Pais1.K_Estado > 0)
            {
                dtFiltra = sql_catalogo.Sk_Ciudad(geo_Pais1.K_Pais, geo_Pais1.K_Estado, txt_D_Ciudad.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("TIENE QUE ESPECIFICAR EL ESTADO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Entrar_Click(object sender, EventArgs e)
        {

        }
    }
}
