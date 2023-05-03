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
    public partial class Frm_OrdenesCompraAutorizar : FormaBase
    {
        SQLCompras sqlCompras = new SQLCompras();
//        int K_Articulo = 0;
        int res = 0;
        string msg = string.Empty;
        string MotivoCancela = string.Empty;
        string Correos = string.Empty;
        DataTable dtDatos = new DataTable();
        DataTable dtOrdenes = new DataTable();
        Funciones fx = new Funciones();

        public Frm_OrdenesCompraAutorizar()
        {
            BaseGridSinFormato = true;
            InitializeComponent();
        }

        public override void BaseMetodoInicio()
        {
            BaseBotonAfectar.Text = "Autorizar";
            BaseBotonAfectar.ToolTipText = "Autorizar Orden de Compra";

            BaseBotonReporte.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonBorrar.Visible = true;
            BaseBotonGuardar.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonNuevo.Enabled = false;

            BaseBotonBorrar.Text = "Cancelar";
            BaseBotonBorrar.ToolTipText = "Cancelar Orden de Compra...!";
            
            
            grdDetalle.AutoGenerateColumns = false;
            grdRequisiciones.AutoGenerateColumns = false;
            BaseErrorResultado = true;            
            BaseEtiquetaEstatus.Visible = false;

            dtOrdenes = sqlCompras.Sk_ConsultaOrdenesCompra(1, false);
            BasePropiedadCampoClave = "K_Orden_Compra";


            BaseDtDatos = dtOrdenes;
            dtDatos = DetalleRequisicion_Type;
            //dtDatos.Columns.Add("D_Articulo", typeof(string));

            //LlenaRequisiciones();
            grdRequisiciones.DataSource = dtOrdenes;
            
            
            base.BaseMetodoInicio();
        }


        public override void BaseBotonBorrarClick()
        {
            if (BasePropiedadId_Identity == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA ORDEN DE COMPRA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dlg = MessageBox.Show("SERA CANCELADA LA ORDEN DE COMPRA No: " + BasePropiedadId_Identity.ToString() + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                MotivoCancela = "";

                Frm_DatosCancelacionOC frmMotivo = new Frm_DatosCancelacionOC();
                frmMotivo.Text = "Motivo Cancela";
                frmMotivo.ShowDialog();

                

                if (frmMotivo.P_MotivoCancelacion .Trim().Length == 0)
                {
                    MessageBox.Show("DEBE CAPTURAR MOTIVO DE CANCELACION...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
               
                res = sqlCompras.Gp_AutorizaCancelaOrdenCompra(BasePropiedadId_Identity, false, true, GlobalVar.K_Usuario, frmMotivo.P_k_motivo_cancelacion, frmMotivo.P_MotivoCancelacion , ref Correos, ref msg);
                if (res == -1)
                {
                    BaseErrorResultado = true;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    BaseErrorResultado = false;

/*
                    //Enviar Correo al usuario que realiza requisición:                    
                    DataTable dt = new DataTable();
                    var resul = from c in dtOrdenes.AsEnumerable()
                                select c;
                    resul = resul.Where(o => o.Field<int>("K_Requisicion") == BasePropiedadId_Identity);
                    if (resul.Any())
                        dt = resul.CopyToDataTable();


                    string Correo = string.Empty;
                    if (dt.Rows[0]["E_MailRequiere"] != null)
                        Correo = dt.Rows[0]["E_MailRequiere"].ToString().Trim();
*/
                    if (Correos.Trim().Length > 0)
                    {
                        string Asunto = "Productos Eiffel, Cancelación de Orden de Compra No. " + BasePropiedadId_Identity.ToString().Trim();
                        string CorreoDe = System.Configuration.ConfigurationManager.AppSettings["CorreoDe"].ToString();
                        string Cuerpo = fx.CuerpoCorreoHTML("<p>Se notifica que la Orden de Compra No. " + BasePropiedadId_Identity.ToString().Trim() + " ha sido cancelada</p></br><p>Motivo Cancelacion: </p></br>" + MotivoCancela.Trim());
                        string Recursos = "logo";
                        string Archivos = Path.Combine(GlobalVar.rutaExe, "Imagenes/LogoEiffel.png"); //+ "," + Path.Combine(GlobalVar.rutaExe, "Imagenes/Bottom.png");
                        string Adjuntos = "";

                        fx.EnviaCorreo(CorreoDe, Correos, Asunto, "Orden de Compra Cancelada", Cuerpo, Adjuntos, Archivos, Recursos, "", false);
                    }

                    MessageBox.Show("SE CANCELÓ LA ORDEN DE COMPRA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BasePropiedadId_Identity = 0;
                    BaseMetodoInicio();
                    BaseBotonCancelarClick();
//                    grdDetalle.DataSource = null;
                }

            }
        }


        //private void LlenaRequisiciones()
        //{
        //    DataTable dt = new DataTable();
        //    try
        //    {
        //        var res = from c in dtRequisiciones.AsEnumerable()
        //                  select c;
        //        res = res.Where(o => o.Field<int>("K_Oficina_Requiere") == GlobalVar.K_Oficina && o.Field<bool>("B_Autorizada") == false && o.Field<bool>("B_Cancelada") == false);
        //        if (res.Any())
        //        {
        //            dt = res.CopyToDataTable();

        //        }
        //    }
        //    finally
        //    {
        //        grdRequisiciones.DataSource = dt;
        //    }


        //}

        public override void BaseBotonAfectarClick()
        {
            if (BasePropiedadId_Identity == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA ORDEN DE COMPRA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dlg = MessageBox.Show("SERA AUTORIZADA LA ORDEN DE COMPRA No: " + BasePropiedadId_Identity.ToString() + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                MotivoCancela = "";
                res = sqlCompras.Gp_AutorizaCancelaOrdenCompra(BasePropiedadId_Identity, true, false, GlobalVar.K_Usuario, 1,MotivoCancela, ref Correos, ref msg);
                if (res == -1)
                {
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    MessageBox.Show("SE AUTORIZÓ LA ORDEN DE COMPRA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    grdDetalle.Rows.Clear();
                    BaseMetodoInicio();
                    BaseBotonCancelarClick();

                    //if (Correos.Trim().Length > 0)
                    //{
                    //    string Asunto = "Productos Eiffel, Autorización de Orden de Compra No. " + BasePropiedadId_Identity.ToString().Trim();
                    //    string CorreoDe = System.Configuration.ConfigurationManager.AppSettings["CorreoDe"].ToString();
                    //    string Cuerpo = fx.CuerpoCorreoHTML("<p>La Orden de Compra No. " + BasePropiedadId_Identity.ToString().Trim()) + " fue Autorizada.</p></br><p>Puede Reimprimir el Reporte en la Consulta de Ordenes de Compra ó en su Defecto enviar por Correo al Proveedor.</p>";
                    //    string Recursos = "logo";
                    //    string Archivos = Path.Combine(GlobalVar.rutaExe, "Imagenes/LogoEiffel.png"); //+ "," + Path.Combine(GlobalVar.rutaExe, "Imagenes/Bottom.png");
                    //    string Adjuntos = "";

                    //    fx.EnviaCorreo(CorreoDe, Correos, Asunto, "Orden de Compra", Cuerpo, Adjuntos, Archivos, Recursos, "", false);
                    //}
                }

            }
        }

        public void MostrarDetalle(int K_OrdenCompra)
        {
            //dtDatos = DetalleRequisicion_Type;
            ////dtDatos.Columns.Add("D_Articulo", typeof(string));


            //DataTable dtDetalle = sqlCompras.sps_RequisicionDetalle(BasePropiedadId_Identity);
            //foreach (DataRow row in dtDetalle.Rows)
            //{
            //    dtDatos.ImportRow(row);
            //}
            dtDatos = sqlCompras.Sk_ConsultaOrdenesCompraDetalle(K_OrdenCompra);
            grdDetalle.DataSource = dtDatos;
        }

        private void grdRequisiciones_SelectionChanged_1(object sender, EventArgs e)
        {
            DataGridViewRow row = grdRequisiciones.CurrentRow;
            if (row != null)
            {
                BasePropiedadId_Identity = Convert.ToInt32(row.Cells[0].Value);
                MostrarDetalle(BasePropiedadId_Identity);
            }
        }

        private void grdRequisiciones_Click_1(object sender, EventArgs e)
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
