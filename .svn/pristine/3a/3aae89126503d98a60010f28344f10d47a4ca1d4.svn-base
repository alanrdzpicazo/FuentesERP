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
    class cbx_estatus_compra : System.Windows.Forms.ComboBox
    {
        SQLCatalogos SQLCatalogos = new SQLCatalogos();
        DataTable dt = new DataTable();

        public cbx_estatus_compra()
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
                dt = SQLCatalogos.Sk_Estatus_Compra();
                this.DataSource = dt;
                this.DisplayMember = "D_Estatus_Compra";
                this.ValueMember = "K_Estatus_Compra";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }
    }
}
