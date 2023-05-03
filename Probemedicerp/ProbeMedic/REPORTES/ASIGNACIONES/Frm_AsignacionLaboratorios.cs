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
    public partial class Frm_AsignacionLaboratorios : FormaBase
    {
        SQLCatalogos SqlCatalogos = new SQLCatalogos();
        public DataTable DtSeleccionados { get; set; }

        public Frm_AsignacionLaboratorios()
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

            DataTable DtDisp = SqlCatalogos.Sk_Laboratorio();


            ctrl_Asignacion1.dtDisponible = DtDisp;
            ctrl_Asignacion1.dtAsignado = ctrl_Asignacion1.dtDisponible.Clone();
            ctrl_Asignacion1.DAsignado = "D_Laboratorio";
            ctrl_Asignacion1.KAsignado = "K_Laboratorio";
            ctrl_Asignacion1.DDisponible = "D_Laboratorio";
            ctrl_Asignacion1.KDisponible = "K_Laboratorio";
            ctrl_Asignacion1.llena_listados();
        }

        public override void BaseBotonAfectarClick()
        {
            if (ctrl_Asignacion1.dtAsignado != null)
            {
                if (ctrl_Asignacion1.dtAsignado.Rows.Count > 0)
                {
                    DtSeleccionados = ctrl_Asignacion1.dtAsignado;
                }
            }

            this.Close();

        }
    }
}
