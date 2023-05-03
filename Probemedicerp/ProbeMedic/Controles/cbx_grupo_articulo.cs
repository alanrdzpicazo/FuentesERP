using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProbeMedic.AppCode.BLL;
using System.Data;
using System.Windows.Forms;

namespace ProbeMedic.Controles
{
    class cbx_grupo_articulo : System.Windows.Forms.ComboBox
    {
        SQLCatalogos SQLCatalogos = new SQLCatalogos();
        DataTable dt = new DataTable();

        public cbx_grupo_articulo()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {

            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;

            this.SuspendLayout();
            this.ResumeLayout(false);

        }
        public void LlenaDatos()
        {

            try
            {
                dt = SQLCatalogos.Sk_Grupos_Articulos();
                this.DataSource = dt;
                this.DisplayMember = "D_Grupo_Articulo";
                this.ValueMember = "K_Grupo_Articulo";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }
    }
}
