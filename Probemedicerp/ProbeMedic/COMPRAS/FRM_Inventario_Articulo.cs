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

namespace ProbeMedic.COMPRAS
{
    public partial class FRM_Inventario_Articulo : FormaBase
    {
        DataTable dtDatos = new DataTable();
        SQLAlmacen sqlAlmacen = new SQLAlmacen();
        public Int32 K_Articulo_ { get; set; }

        public FRM_Inventario_Articulo()
        {
            InitializeComponent();
            grdDatos.AutoGenerateColumns = false;
        }

        private void FRM_Inventario_Articulo_Load(object sender, EventArgs e)
        {
            dtDatos = sqlAlmacen.Gp_Inventario(Convert.ToInt32(K_Articulo_), true, true);

            if (dtDatos != null)
            {
                grdDatos.DataSource = dtDatos;
            }
            else
            {
                MessageBox.Show("EL ARTICULO NO CUENTA CON INVENTARIO DISPONIBLE!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }            
        }

        public override void BaseMetodoInicio()
        {
            BaseBotonAfectar.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonReporte.Visible = false;
            BaseBotonBorrar.Visible = false;

            dtDatos = sqlAlmacen.Gp_Inventario(Convert.ToInt32(K_Articulo_), true, true);

            if (dtDatos != null)
                grdDatos.DataSource = dtDatos;
        }
    }
}
