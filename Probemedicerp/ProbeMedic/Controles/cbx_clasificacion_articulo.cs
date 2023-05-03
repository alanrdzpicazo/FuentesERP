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
    class cbx_clasificacion_articulo : System.Windows.Forms.ComboBox
    {
        SQLCatalogos SQLCatalogos = new SQLCatalogos();
        DataTable dt = new DataTable();

        public cbx_clasificacion_articulo()
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
                dt = SQLCatalogos.Sk_Categoria_Articulo();
                this.DataSource = dt;
                this.DisplayMember = "D_Categoria_Articulo";
                this.ValueMember = "K_Categoria_Articulo";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }
    }
}
