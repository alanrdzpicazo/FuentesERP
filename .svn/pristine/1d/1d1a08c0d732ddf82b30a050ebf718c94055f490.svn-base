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

namespace ProbeMedic.PEDIDOS
{
    public partial class FRM_FILTRA_ARTICULOS : FormaBase
    {
        DataTable dtResultadoDetalle = new DataTable();

        SQLCatalogos SQLCatalogos = new SQLCatalogos();
        public FRM_FILTRA_ARTICULOS()
        {
            InitializeComponent();
            BaseGridSinFormato = true;
        }

        private void FRM_FILTRA_ARTICULOS_Load(object sender, EventArgs e)
        {
            grdDetalle.AutoGenerateColumns = false;
            FiltraDetalle();

        }

        void FiltraDetalle()
        {
            dtResultadoDetalle = SQLCatalogos.Sk_Articulos_Consulta(K_Oficina, K_Articulo, K_Almacen, dtpInicio.Value, dtpFinal.Value, txtLote.Text.Trim(), (txtRecepcion.Text.Trim().Length == 0) ? 0 : Convert.ToInt32(txtRecepcion.Text.Trim()), true, Txt_Sku.Text.Trim());

            if (dtResultadoDetalle != null)
            {
                dtResultadoDetalle.Columns.Add(new DataColumn("Seleccion", typeof(bool)));
                dtResultadoDetalle.Columns.Add(new DataColumn("Cantidad_Transferir", typeof(decimal)));

                foreach (DataRow dr in dtResultadoDetalle.Rows)
                {
                    dr["Seleccion"] = false;
                    dr["Cantidad_Transferir"] = 0;
                }

            }
            grdDetalle.DataSource = dtResultadoDetalle;


            if (dtTransferidos != null)
            {
                foreach (DataGridViewRow grow in grdDetalle.Rows)
                {
                    foreach (DataRow row in dtTransferidos.Rows)
                    {
                        if (grow.Cells["K_Movimiento_Inventario"].Value.ToString() == row["K_Movimiento_Inventario"].ToString())
                        {
                            grow.Cells["Cantidad_Transferir"].ReadOnly = true;
                            grow.DefaultCellStyle.BackColor = System.Drawing.Color.IndianRed;
                        }
                    }
                }

            }

            Txt_Sku.Focus();

        }
    }
}
