using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProbeMedic.FILTROS;
using ProbeMedic.AppCode.BLL;

namespace ProbeMedic.Busquedas
{
    public partial class Frm_Busca_Articulos_SOS : Frm_Filtro
    {
        SQLVentas sqlventas = new SQLVentas();
        DataTable AR_DISPONIBLES = new DataTable();
        DataTable AR_DISPONIBLESS = new DataTable();

        public int LLave_Seleccionado { get; set; }
        public string Descripcion_Seleccionado { get; set; }
        public decimal Subtotal_Seleccionado { get; set; }
        public decimal Precio_Seleccionado { get; set; }
        public decimal Iva_Seleccionado { get; set; }

        public Frm_Busca_Articulos_SOS()
        {
            InitializeComponent();
        }
     
        private void Frm_Busca_Articulos_SOS_Load(object sender, EventArgs e)
        {
            AR_DISPONIBLES.Columns.Add("K_Articulo", typeof(Int32));
            AR_DISPONIBLES.Columns.Add("D_Articulo", typeof(string));
            AR_DISPONIBLES.Columns.Add("Subtotal", typeof(decimal));
            AR_DISPONIBLES.Columns.Add("Iva", typeof(decimal));
            AR_DISPONIBLES.Columns.Add("Precio", typeof(decimal));
            ObtieneArticulos();
        }

        private void grdDatos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Enter))
            {
                grDatos.EndEdit();             // if you want to preserve the current commit behavior
                e.Handled = true;

                DataGridViewRow row = grDatos.CurrentRow;
                if (row == null)
                    return;
                LLave_Seleccionado = (Convert.ToInt32(row.Cells["K_Articulo"].Value));
                Descripcion_Seleccionado = (row.Cells["D_Articulo"].Value.ToString());
                Subtotal_Seleccionado = (Convert.ToDecimal(row.Cells["Subtotal"].Value));
                Iva_Seleccionado = (Convert.ToDecimal(row.Cells["Iva"].Value));
                Precio_Seleccionado = (Convert.ToDecimal(row.Cells["Precio"].Value));
                this.Close();
            }
        }

        private void ObtieneArticulos()
        {
            AR_DISPONIBLESS = sqlventas.SK_Articulos_SOS();

            if (AR_DISPONIBLESS != null)
            {
                foreach (DataRow irew in AR_DISPONIBLESS.Rows)
                {
                    DataRow dtdRow3 = AR_DISPONIBLES.NewRow();
                    dtdRow3["K_Articulo"] = Convert.ToInt32(irew["K_Articulo"]);
                    dtdRow3["D_Articulo"] = irew["D_Articulo"].ToString();
                    dtdRow3["Subtotal"] = Convert.ToDecimal(irew["Subtotal"]);
                    dtdRow3["Iva"] = Convert.ToDecimal(irew["Iva"]);

                    dtdRow3["Precio"] = Convert.ToDecimal(irew["Precio"]);

                    AR_DISPONIBLES.Rows.Add(dtdRow3);
                }
               grDatos.DataSource = AR_DISPONIBLES;
            }
        }

        private void grDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = grDatos.CurrentRow;
            if (row == null)
                return;
            LLave_Seleccionado = (Convert.ToInt32(row.Cells["K_Articulo"].Value));
            Descripcion_Seleccionado = (row.Cells["D_Articulo"].Value.ToString());
            Subtotal_Seleccionado = (Convert.ToDecimal(row.Cells["Subtotal"].Value));
            Iva_Seleccionado = (Convert.ToDecimal(row.Cells["Iva"].Value));
            Precio_Seleccionado = (Convert.ToDecimal(row.Cells["Precio"].Value));

            this.Close();
        }
    }
}
