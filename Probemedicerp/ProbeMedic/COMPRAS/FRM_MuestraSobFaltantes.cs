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
using ProbeMedic.INVENTARIOS;

namespace ProbeMedic.COMPRAS
{

    public partial class FRM_MuestraSobFaltantes : FormaBase
    {
        SQLAlmacen sqlAlmacen = new SQLAlmacen();

        DataTable dtDatos = new DataTable();
        public Int32 K_Orden_Compra_ { get; set; }

        public FRM_MuestraSobFaltantes()
        {
            InitializeComponent();
        }

        private void FRM_MuestraSobFaltantes_Load(object sender, EventArgs e)
        {
            grdDatos.AutoGenerateColumns = false;
            dtDatos = sqlAlmacen.Gp_TraeSobanteFaltante(Convert.ToInt32(K_Orden_Compra_));

            if (dtDatos != null)
            {
                grdDatos.DataSource = dtDatos;
            }
            else
            {
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
            dtDatos = sqlAlmacen.Gp_TraeSobanteFaltante(Convert.ToInt32(K_Orden_Compra_));

            if (dtDatos != null)
                grdDatos.DataSource = dtDatos;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            //INVENTARIOS.Frm_NotasRecepcion frm = new INVENTARIOS.Frm_NotasRecepcion(K_Orden_Compra_);
            //frm.B_Acepta = 1;
        }
    }
}
