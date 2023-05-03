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

namespace ProbeMedic.INVENTARIOS
{
    public partial class Frm_PedidosAutoriza : FormaBase
    {
        SQLVentas sql_ventas = new SQLVentas();
        int res = 0;
        string msg = string.Empty;
        string strMensaje = "";


        DataTable dtDatos = new DataTable();
        DataTable dtPedidos = new DataTable();
        Funciones fx = new Funciones();

        public Frm_PedidosAutoriza()
        {
            BaseGridSinFormato = true;
            InitializeComponent();
            dtDatos.Columns.Add("k_articulo", typeof(Int32));
            dtDatos.Columns.Add("d_articulo", typeof(String));
            dtDatos.Columns.Add("Cantidad", typeof(Int32));
            dtDatos.Columns.Add("d_unidad_medida", typeof(String));
            dtDatos.Columns.Add("Precio_Unitario", typeof(Decimal));
            dtDatos.Columns.Add("Total_Detalle", typeof(Decimal));
        }

        public override void BaseMetodoInicio()
        {
            BaseBotonAfectar.Text = "Autorizar";
            BaseBotonAfectar.ToolTipText = "Autorizar Pedidos";

            BaseBotonNuevo.Visible = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonReporte.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonBorrar.Visible = true;
            BaseBotonGuardar.Visible = false;

            BaseBotonBorrar.Text = "Cancelar";
            BaseBotonBorrar.ToolTipText = "Cancelar Pedido...!";


            grdDetalle.AutoGenerateColumns = false;
            grdPedidos.AutoGenerateColumns = false;
            BaseErrorResultado = true;
            BaseEtiquetaEstatus.Visible = false;

            dtPedidos = sql_ventas.Gp_Pedidos_Bloqueados();
            BasePropiedadCampoClave = "K_Pedido";

            BaseDtDatos = dtPedidos;

            LlenaPedidos();

            base.BaseMetodoInicio();
        }


        public override void BaseBotonBorrarClick()
        {
            if (BasePropiedadId_Identity == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN PEDIDO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dlg = MessageBox.Show("SERA CANCELADO EL PEDIDO CON FOLIO: " + BasePropiedadId_Identity.ToString() + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                Frm_DatosCancelacionOC frmMotivo = new Frm_DatosCancelacionOC();
                frmMotivo.Text = "Motivo Cancela";
                frmMotivo.ShowDialog();
                if ((frmMotivo.P_MotivoCancelacion.Length == 0) || (frmMotivo.P_k_motivo_cancelacion == 0))
                {
                    return;
                }
                //res = .Gp_ApruebaCancelaRequisicion(BasePropiedadId_Identity, GlobalVar.K_Usuario, false, true, frmMotivo.P_k_motivo_cancelacion, frmMotivo.P_MotivoCancelacion, ref msg);

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
                    var resul = from c in dtPedidos.AsEnumerable()
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

        private void LlenaPedidos()
        {
            DataTable dt = new DataTable();
            if ((dtPedidos != null) && (dtPedidos.Rows.Count > 0))
            {
                try
                {
                    var res = from c in dtPedidos.AsEnumerable()
                              select c;
                    res = res.Where(o => o.Field<int>("K_Oficina") == GlobalVar.K_Oficina);
                    if (res.Any())
                    {
                        dt = res.CopyToDataTable();
                    }
                }
                finally
                {
                    grdPedidos.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("ESTE USUARIO NO CUENTA CON PEDIDOS PENDIENTES POR AUTORIZAR" + System.Environment.NewLine +
                                "O ESTE USUARIO NO CUENTA CON PRIVILEGIOS PARA AUTORIZAR PEDIDOS", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public override void BaseBotonAfectarClick()
        {
            if (BasePropiedadId_Identity == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN PEDIDO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dlg = MessageBox.Show("SERA AUTORIZADO EL PEDIDO CON FOLIO: " + BasePropiedadId_Identity.ToString() + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
             
                res = sql_ventas.Gp_ApruebaPedido(BasePropiedadId_Identity, 5, ref msg);

                if (res == -1)
                {
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    MessageBox.Show("SE AUTORIZÓ EL PEDIDO CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BaseMetodoInicio();
                    BaseBotonCancelarClick();                  
                }

            }
        }

        public void MostrarDetalle(int K_Pedido)
        {           
            dtDatos.Rows.Clear();
            strMensaje = "";
            int int_Consecutivo = 0;

            DataTable dtDetalle = sql_ventas.Sk_ConsultaPedidoporAsignar(K_Pedido, GlobalVar.K_Oficina, ref int_Consecutivo, ref strMensaje);
            DataRow dr;
            foreach (DataRow row in dtDetalle.Rows)
            {
                dr = dtDatos.NewRow();

                dr["k_articulo"] = row["k_articulo"];
                dr["d_articulo"] = row["d_articulo"];
                dr["Cantidad"] = row["Cantidad"];
                dr["d_unidad_medida"] = row["d_unidad_medida"];
                dr["Precio_Unitario"] = row["Precio_Unitario"];
                dr["Total_Detalle"] = row["Total_Detalle"];
      
                dtDatos.Rows.Add(dr);               
            }
            grdDetalle.DataSource = dtDatos;
        }

        private void grdPedidos_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = grdPedidos.CurrentRow;
            if (row != null)
            {
                BasePropiedadId_Identity = Convert.ToInt32(row.Cells[0].Value);
                MostrarDetalle(BasePropiedadId_Identity);
            }
        }

        private void grdPedidos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = grdPedidos.CurrentRow;
            if (row != null)
            {
                BasePropiedadId_Identity = Convert.ToInt32(row.Cells[0].Value);
                MostrarDetalle(BasePropiedadId_Identity);
            }
        }
    }
}
