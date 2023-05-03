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
    class cbx_tipo_articulo : System.Windows.Forms.ComboBox
    {
        SQLCatalogos SQLCatalogos = new SQLCatalogos();
        DataTable dt = new DataTable();

        public cbx_tipo_articulo()
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
                dt = SQLCatalogos.Sk_Tipos_Productos();
                this.DataSource = dt;
                this.DisplayMember = "D_Tipo_Producto";
                this.ValueMember = "K_Tipo_Producto";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }
    }
}
