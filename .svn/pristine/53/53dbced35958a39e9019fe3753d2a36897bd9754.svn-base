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

namespace ProbeMedic.INVENTARIOS
{
    public partial class Frm_RPT_MedicamentosDesplazamiento : FormaBase
    {
        SQLAlmacen SQLALMACEN = new SQLAlmacen();
        SQLCatalogos SQLCATALOGOS = new SQLCatalogos();
        public Frm_RPT_MedicamentosDesplazamiento()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            BaseBotonProceso2.Visible = false;
            BaseBotonProceso3.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonAfectar.Enabled = false;
            BaseBotonCorreo.Visible = false;
            BaseBotonCorreo.Enabled = false;
            BaseBotonModificar.Visible = false;
            BaseBotonModificar.Enabled = false;
            BaseBotonCancelar.Enabled = true;
            BaseBotonNuevo.Visible = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonCancelar.Enabled = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonGuardar.Enabled = false;
            BaseBotonReporte.Visible = false;
            BaseBotonReporte.Enabled = false;
            BaseBotonProceso1.Visible = false;
            BaseBotonProceso2.Visible = false;
            BaseBotonProceso3.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonBuscar.Visible = true;

            BaseBotonCancelar.Text = "Limpiar";
            BaseBotonCancelar.ToolTipText = "Limpiar";

            grdDatos.AutoGenerateColumns = false;

            this.rdb4.Checked = true;

            this.WindowState = FormWindowState.Maximized;

            MtdCargaAlmacen();

        }
        public override void BaseBotonBuscarClick()
        {
            Int32 K_AlmacenInt = 0;
            Int32 Dias = 0;
            if ((Int32)cbxAlmacen.SelectedValue > 0)
            {
                K_AlmacenInt = (Int32)cbxAlmacen.SelectedValue;
            }
            else
            {
                K_AlmacenInt = 0;
            }
            if(rdb4.Checked)
            {
                Dias = 120;
            }
            else if(rdb6.Checked)
            {
                Dias = 180;
            }
            if (K_AlmacenInt == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR UN ALMACÉN...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxAlmacen.Focus();
                return;
            }
            DataTable dtDatos = new DataTable();
            dtDatos = SQLALMACEN.Gp_Movimiento_Medicamentos(K_AlmacenInt,Dias);

            if (dtDatos!= null)
            {
                BaseBotonCancelar.Visible = true;
                BaseBotonCancelar.Enabled = true;
                grdDatos.DataSource = dtDatos;
            }
            else
            {
                BaseBotonCancelar.Visible = false;
                BaseBotonCancelar.Enabled = false;
                MessageBox.Show("No se encontró Información!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxAlmacen.Focus();
            }
            grdDatos.DataSource = dtDatos;
            base.BaseBotonBuscarClick();
        }
        public override void BaseBotonCancelarClick()
        {
            MtdCargaAlmacen();
            grdDatos.DataSource = null;
            BaseMetodoInicio();
            base.BaseBotonCancelarClick();
        }
        void MtdCargaAlmacen()
        {
            DataTable dtAlmacen = SQLCATALOGOS.Sk_Almacenes(GlobalVar.K_Oficina);

            if (dtAlmacen != null)
            {
                DataRow dr = dtAlmacen.NewRow();

                dr["K_Almacen"] = 0;
                dr["K_Oficina"] = 0;
                dr["D_Oficina"] = "";
                dr["D_Almacen"] = "[Seleccionar]";
                dr["B_AceptaDevolucionesCliente"] = false;

                dtAlmacen.Rows.InsertAt(dr, 0);
                dtAlmacen.AcceptChanges();

                int indice = -1;
                indice = 0;
                LlenaCombo(dtAlmacen, ref cbxAlmacen, "K_Almacen", "D_Almacen", indice);
            }
        }
    }
}
