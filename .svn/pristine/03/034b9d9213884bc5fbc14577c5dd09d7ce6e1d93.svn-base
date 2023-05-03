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

namespace ProbeMedic.REPORTES.ASIGNACIONES
{
    public partial class Frm_AsignacionClientes : FormaBase
    {
        SQLCatalogos sqlCatalogos = new SQLCatalogos();
        public DataTable dtSeleccionados { get; set; }

        public Frm_AsignacionClientes()
        {
            InitializeComponent();
            BaseBotonExcel.Visible = false;
        }
        public override void BaseMetodoInicio()
        {
            BaseBotonBuscar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonAfectar.Enabled = false;
            BaseBotonCorreo.Visible = false;
            BaseBotonCorreo.Enabled = false;
            BaseBotonModificar.Visible = false;
            BaseBotonModificar.Enabled = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonCancelar.Enabled = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonGuardar.Enabled = false;
            BaseBotonReporte.Visible = false;
            BaseBotonReporte.Enabled = false;

            BaseBotonAfectar.Enabled = true;
            BaseBotonAfectar.Visible = true;
            BaseBotonAfectar.Text = "Aceptar";

            DataTable dtDisp = sqlCatalogos.Sk_Clientes();

            dtDisp.Columns.Remove("C_Cliente");
            dtDisp.Columns.Remove("D_Comercial");
            dtDisp.Columns.Remove("RFC");
            dtDisp.Columns.Remove("CURP");
            dtDisp.Columns.Remove("DiasCredito");
            dtDisp.Columns.Remove("LimiteCredito");
            dtDisp.Columns.Remove("URL");
            dtDisp.Columns.Remove("Correo");
            dtDisp.Columns.Remove("B_Cliente_Tarjeta");
            dtDisp.Columns.Remove("Telefono");
            dtDisp.Columns.Remove("K_Canal_Distribucion_Cliente");
            dtDisp.Columns.Remove("D_Canal_Distribucion_Cliente");
            dtDisp.Columns.Remove("K_Estatus_Cliente");
            dtDisp.Columns.Remove("D_Estatus_Cliente");
            dtDisp.Columns.Remove("K_Tipo_Fiscal");
            dtDisp.Columns.Remove("D_Tipo_Fiscal");
            dtDisp.Columns.Remove("K_Empresa");
            dtDisp.Columns.Remove("D_Empresa");
            dtDisp.AcceptChanges();

            ctrl_Asignacion1.dtDisponible = dtDisp;
            ctrl_Asignacion1.dtAsignado = ctrl_Asignacion1.dtDisponible.Clone();
            ctrl_Asignacion1.DAsignado = "D_Cliente";
            ctrl_Asignacion1.KAsignado = "K_Cliente";
            ctrl_Asignacion1.DDisponible = "D_Cliente";
            ctrl_Asignacion1.KDisponible = "K_Cliente";
            ctrl_Asignacion1.llena_listados();
        }

        public override void BaseBotonAfectarClick()
        {
            if (ctrl_Asignacion1.dtAsignado != null)
            {
                if (ctrl_Asignacion1.dtAsignado.Rows.Count > 0)
                {
                    dtSeleccionados = ctrl_Asignacion1.dtAsignado;
                }
            }

            this.Close();

        }
    }
}
