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
    class cbx_motivo_ajuste_inventario : System.Windows.Forms.ComboBox
    {
        SQLCatalogos SQLCatalogos = new SQLCatalogos();
        DataTable dt = new DataTable();

        public cbx_motivo_ajuste_inventario()
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
                dt = SQLCatalogos.Sk_Motivo_Ajuste_Inventario();
                this.DataSource = dt;
                this.DisplayMember = "D_Motivo_Ajuste_Inventario";
                this.ValueMember = "K_Motivo_Ajuste_Inventario";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }
        
    }
}
