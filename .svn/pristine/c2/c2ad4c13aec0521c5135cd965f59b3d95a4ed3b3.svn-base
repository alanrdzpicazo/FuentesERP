using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;
using System.Configuration;
using System.IO;
using ProbeMedic.VENTAS;

namespace ProbeMedic.COMPRAS
{
    public partial class Frm_RequisicionAutorizarBloqueadas : FormaBase
    {
        SQLCompras sqlCompras = new SQLCompras();
        //        int KArticulo = 0;
        int res = 0;
        string msg = string.Empty;

        DataTable dtDatos = new DataTable();
        DataTable dtRequisiciones = new DataTable();
        Funciones fx = new Funciones(); 

        public Frm_RequisicionAutorizarBloqueadas()
        {
            BaseGridSinFormato = true;
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            BaseBotonAfectar.Text = "Autorizar";
            BaseBotonAfectar.ToolTipText = "Autorizar Requisiciones";

            BaseBotonNuevo.Visible = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonReporte.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonBorrar.Visible = true;
            BaseBotonGuardar.Visible = false;

            BaseBotonBorrar.Text = "Cancelar";
            BaseBotonBorrar.ToolTipText = "Cancelar Requisición...!";

            grdDetalle.AutoGenerateColumns = false;
            grdRequisiciones.AutoGenerateColumns = false;
            grdRequisiciones.DataSource = null;
            grdDetalle.DataSource = null;
            BaseErrorResultado = true;
            BaseEtiquetaEstatus.Visible = false;

            dtRequisiciones = sqlCompras.Sk_Requisicion(12,false);
            BasePropiedadCampoClave = "K_Requisicion";

            BaseDtDatos = dtRequisiciones;
            dtDatos = DetalleRequisicion_Type;

            LlenaRequisiciones();

            BasePropiedadId_Identity = 0;

            base.BaseMetodoInicio();
        }


        public override void BaseBotonBorrarClick()
        {
            if (BasePropiedadId_Identity == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA REQUISICION...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dlg = MessageBox.Show("SERA CANCELADA LA REQUISICION CON FOLIO: " + BasePropiedadId_Identity.ToString() + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                Frm_DatosCancelacionOC frmMotivo = new Frm_DatosCancelacionOC();
                frmMotivo.Text = "Motivo Cancela";
                frmMotivo.ShowDialog();
                if ((frmMotivo.P_MotivoCancelacion.Length == 0) || (frmMotivo.P_k_motivo_cancelacion == 0))
                {
                    return;
                }
                res = sqlCompras.Gp_ApruebaCancelaRequisicion(BasePropiedadId_Identity, GlobalVar.K_Usuario, false, true, frmMotivo.P_k_motivo_cancelacion, frmMotivo.P_MotivoCancelacion, ref msg);

                if (res == -1)
                {
                    BaseErrorResultado = true;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    BaseErrorResultado = false;

                    //Enviar Correo al usuario que realiza requisición:                    
                    DataTable dt = new DataTable();
                    var resul = from c in dtRequisiciones.AsEnumerable()
                                select c;
                    resul = resul.Where(o => o.Field<int>("K_Requisicion") == BasePropiedadId_Identity);
                    if (resul.Any())
                        dt = resul.CopyToDataTable();


                    string Correo = string.Empty;
                    if (dt.Rows[0]["E_MailRequiere"] != null)
                        Correo = dt.Rows[0]["E_MailRequiere"].ToString().Trim();

                    if (Correo.Trim().Length > 0)
                    {
                        /*  string Asunto = "Productos Eiffel, Cancelación de Requisición No. " + BasePropiedadId_Identity.ToString().Trim();
                          string CorreoDe = ConfigurationManager.AppSettings["CorreoDe"].ToString();
                          string Cuerpo = fx.CuerpoCorreoHTML("Se notifica que la requisición que usted solicito ha sido cancelada.");
                          string Recursos = "logo";
                          string Archivos = Path.Combine(GlobalVar.rutaExe, "Imagenes/LogoEiffel.png"); //+ "," + Path.Combine(GlobalVar.rutaExe, "Imagenes/Bottom.png");
                          string Adjuntos = "";

                          fx.EnviaCorreo(CorreoDe, Correo, Asunto, "Requisición Cancelada", Cuerpo, Adjuntos, Archivos, Recursos, "", false);*/

                    }

                    MessageBox.Show("SE CANCELÓ LA REQUISICIÓN CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BasePropiedadId_Identity = 0;
                    BaseMetodoInicio();
                    BaseBotonCancelarClick();
                    grdDetalle.DataSource = null;
                }

            }
        }


        private void LlenaRequisiciones()
        {
            DataTable dt = new DataTable();
            if ((dtRequisiciones != null) && (dtRequisiciones.Rows.Count > 0))
            {
                try
                {
                    var res = from c in dtRequisiciones.AsEnumerable()
                              select c;
                    res = res.Where(o => o.Field<int>("K_Oficina_Requiere") == GlobalVar.K_Oficina && o.Field<bool>("B_Autorizada") == true && o.Field<bool>("B_Cancelada") == false);
                    if (res.Any())
                    {
                        dt = res.CopyToDataTable();
                    }
                }
                finally
                {
                    grdRequisiciones.DataSource = dt;                
                }
            }
            else
            {
                MessageBox.Show("ESTE USUARIO NO CUENTA CON REQUISICIONES PENDIENTES POR AUTORIZAR" + System.Environment.NewLine +
                                "O ESTE USUARIO NO CUENTA CON PRIVILEGIOS PARA AUTORIZAR REQUISICIONES", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        public override void BaseBotonAfectarClick()
        {
            if (BasePropiedadId_Identity == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA REQUISICION...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dlg = MessageBox.Show("SERA AUTORIZADA LA REQUISICION CON FOLIO: " + BasePropiedadId_Identity.ToString() + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                //Frm_DatosCancelacionOC frmMotivo = new Frm_DatosCancelacionOC();
                //frmMotivo.Text = "Motivo Cancela";
                //frmMotivo.ShowDialog();

                res = sqlCompras.Gp_ApruebaCancelaRequisicion(BasePropiedadId_Identity, GlobalVar.K_Usuario, true, false, 1, "", ref msg);

                if (res == -1)
                {
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    MessageBox.Show("SE AUTORIZÓ LA REQUISICIÓN CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BaseBotonCancelarClick();
                    BaseMetodoInicio();
                }

            }
        }


        public void MostrarDetalle(int K_Requisicion)
        {
            dtDatos = DetalleRequisicion_Type;
  
            DataTable dtDetalle = sqlCompras.Sk_RequisicionDetalle(BasePropiedadId_Identity);

            DataRow dr;
            foreach (DataRow row in dtDetalle.Rows)
            {
                dr = dtDatos.NewRow();

                dr["K_Detalle_Requisicion"] = row["K_Detalle_Requisicion"];
                dr["K_Articulo"] = row["K_Articulo"];
                dr["D_Articulo"] = row["D_Articulo"];
                dr["CantidadRequerida"] = row["CantidadRequerida"];
                dr["UMedida"] = row["D_Unidad_Medida"];
                dr["IVA"] = row["IVA"];
                dr["Unitario"] = row["Unitario"];
                dr["PrecioTotal"] = row["PrecioTotal"];
                dr["ObservacionesDetalle"] = row["ObservacionesDetalle"];

                dtDatos.Rows.Add(dr);
            }

            if (dtDatos != null)
                if (dtDatos.Rows.Count > 0)
                    grdDetalle.DataSource = dtDatos;
                else
                    grdDetalle.DataSource = null;

        }


        private void grdRequisiciones_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = grdRequisiciones.CurrentRow;
            if (row != null)
            {
                BasePropiedadId_Identity = Convert.ToInt32(row.Cells[0].Value);
                MostrarDetalle(BasePropiedadId_Identity);
            }
        }

        private void grdRequisiciones_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = grdRequisiciones.CurrentRow;
            if (row != null)
            {
                BasePropiedadId_Identity = Convert.ToInt32(row.Cells[0].Value);
                MostrarDetalle(BasePropiedadId_Identity);
            }
        }
    }
}
