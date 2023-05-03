using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using ProbeMedic.AppCode.BLL;
using ProbeMedic.Busquedas;

namespace ProbeMedic.ENTREGAS
{
    public partial class FRM_REGISTRO_PAGOS_REMISIONES  : FormaBase
    {
        DataTable dt_registro_pagos, dt_liquidacion_remisiones;
        SQLEntregas SQL_ENTREGAS = new SQLEntregas();
        public FRM_REGISTRO_PAGOS_REMISIONES()
        {
            InitializeComponent();
            dt_registro_pagos = new DataTable();

            dt_registro_pagos.Columns.Add("K_Oficina");
            dt_registro_pagos.Columns.Add("K_Liquidacion_Empleados");
            dt_registro_pagos.Columns.Add("K_Remision");
            dt_registro_pagos.Columns.Add("K_Empleado");
            dt_registro_pagos.Columns.Add("K_Banco_Transferencia");
            dt_registro_pagos.Columns.Add("Cuenta_Transferencia");
            dt_registro_pagos.Columns.Add("Cantidad_Transferencia");
            dt_registro_pagos.Columns.Add("K_Banco_Tarjeta");
            dt_registro_pagos.Columns.Add("Numero_Tarjeta");
            dt_registro_pagos.Columns.Add("Aprobacion");
            dt_registro_pagos.Columns.Add("No_Operacion");
            dt_registro_pagos.Columns.Add("B_TajetaCredito");
            dt_registro_pagos.Columns.Add("Cantidad_Tarjeta");
            dt_registro_pagos.Columns.Add("K_Banco_Cheque");
            dt_registro_pagos.Columns.Add("Numero_Cheque");
            dt_registro_pagos.Columns.Add("Cantidad_Cheque");
            dt_registro_pagos.Columns.Add("Efectivo");
            dt_registro_pagos.Columns.Add("Persona_RecibeGuia");
            dt_registro_pagos.Columns.Add("ID_RecibeGuia");


        }
        private void FRM_REGISTRO_PAGOS_REMISIONES_Load(object sender, EventArgs e)
        {
            BaseBotonAfectar.Visible = true;
            BaseBotonAfectar.Enabled = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonExcel.Visible = true;
            BaseBotonGuardar.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonReporte.Visible = false;
            BaseBotonCancelar.Visible = false;
        }
        public override void BaseBotonAfectarClick()
        {
            int res = 0;
            string msg = string.Empty;

            if (dt_registro_pagos.Rows.Count == 0)
            {
                BaseErrorResultado = true;
                MessageBox.Show("Faltan remisiones por registrar la entrega favor de verificar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Verifica_Remisiones_Registro_Pagos())
            {
                BaseErrorResultado = true;
                MessageBox.Show("Faltan remisiones por registrar la entrega favor de verificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            res = SQL_ENTREGAS.Gp_Cierre_Camionetas(Convert.ToInt32(txtClaveLiquidacion.Text), Convert.ToInt32(this.txtClaveOficina.Text), Convert.ToInt32(txtClaveEmpleadoRecibe.Text), GlobalVar.K_Usuario, dt_registro_pagos);

            if (res == -1)
            {
                BaseErrorResultado = true;
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                BaseErrorResultado = false;
                MessageBox.Show("SE HA CERRADO Y ALMACENADO LA LIQUIDACIÓN CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cursor = Cursors.WaitCursor;
                Reporte_Gp_Rep_CierreLiq(Convert.ToInt32(txtClaveLiquidacion.Text), Convert.ToInt32(txtClaveEmpleadoEntrega.Text.Trim()));
                Cursor = Cursors.Default;
                BaseMetodoInicio();
                BaseMetodoLimpiaControles();
            }
        }
        public override void BaseBotonCancelarClick()
        {
            base.BaseBotonCancelarClick();
            BaseMetodoInicio();
            BaseMetodoLimpiaControles();
        }
        private void btnBuscaLiquidacion_Click(object sender, EventArgs e)
        {

            FRM_BUSQUEDA_LIQUIDACION_EMPLEADOS frm = new FRM_BUSQUEDA_LIQUIDACION_EMPLEADOS();
            DataTable dt_liquidacion = new DataTable();

            //cada que hay una búsqueda nueva borramos


            dt_liquidacion = SQL_ENTREGAS.Sk_Liquidacion_Empleados(GlobalVar.K_Oficina);

            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dt_liquidacion);
            frm.BusquedaPropiedadTablaFiltra = dt_liquidacion;
            frm.BusquedaPropiedadTitulo = "Busca liquidación empleados";
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {

                txtClaveLiquidacion.Text = Convert.ToString(frm.BusquedaPropiedadReglonRes["CLAVE_LIQUIDACION"]);
                txtClaveEmpleadoEntrega.Text = Convert.ToString(frm.BusquedaPropiedadReglonRes["CLAVE_EMPLEADO_ENTREGA"]);
                txtEmpleadoEntrega.Text = Convert.ToString(frm.BusquedaPropiedadReglonRes["EMPLEADO_ENTREGA"]);
                txtClaveEmpleadoRecibe.Text  = Convert.ToString(frm.BusquedaPropiedadReglonRes["CLAVE_EMPLEADO_RECIBE"]);
                txtEmpleadoRecibe.Text = Convert.ToString(frm.BusquedaPropiedadReglonRes["EMPLEADO_RECIBE"]);
                txtFechaApertura.Text = Convert.ToString(frm.BusquedaPropiedadReglonRes["F_APERTURA_LIQ"]);
                txtClaveOficina.Text = Convert.ToString(frm.BusquedaPropiedadReglonRes["CLAVE_OFICINA_LIQUIDACION"]);
                txtOficinaLiquidacion .Text = Convert.ToString(frm.BusquedaPropiedadReglonRes["OFICINA_LIQUIDACION"]);

            }

            if (this.txtClaveLiquidacion.Text.Length > 0)
                LlenaDataGrid();
            if (dgv_datos.RowCount > 0)
                BaseBotonAfectar.Enabled = true;
            else
                BaseBotonAfectar.Enabled = false;
        
        }
        private void LlenaDataGrid()
        {
             
            if (dgv_datos.Rows.Count > 0)
            {
                dgv_datos.Rows.Clear();
                dt_registro_pagos.Rows.Clear();
            }

            dt_liquidacion_remisiones = new DataTable();

            dt_liquidacion_remisiones = SQL_ENTREGAS.Sk_Consulta_LiqEmpleados(  Convert.ToInt32(this.txtClaveLiquidacion.Text)  );

            if(dt_liquidacion_remisiones!=null)
            {
                foreach (DataRow dr in dt_liquidacion_remisiones.Rows)
                {
                    dgv_datos.Rows.Add(dr["K_Liquidacion_Empleados"], dr["K_Oficina"], dr["K_Remision"], dr["D_Oficina"], dr["D_Cliente"], dr["Coaseguro"], dr["Total_Remision"], 0);
                }
            }
            






        }
        private void dgv_datos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Llama_Ventana_Pagos(e.RowIndex);
        }
        private void Llama_Ventana_Pagos(int row_index)
        {
            FRM_POPUP_PAGOS_LIQUIDACION frm_pagos = new FRM_POPUP_PAGOS_LIQUIDACION();
            frm_pagos.K_Remision = Convert.ToInt32 (dgv_datos.Rows[row_index].Cells["K_Remision"].Value);
            frm_pagos.total_coaseguro = Convert.ToDecimal(dgv_datos.Rows[row_index].Cells["COASEGURO"].Value);
            frm_pagos.ShowDialog();


            //aprovechamos para llenar el dt_registro_pagos
            if (frm_pagos.B_Validado)
            {
               
     
                   dt_registro_pagos.Rows.Add(dgv_datos.Rows[row_index].Cells["K_Oficina"].Value,
                       Convert.ToInt32( this.txtClaveLiquidacion.Text),
                       dgv_datos.Rows[row_index].Cells["K_Remision"].Value,
                       Convert.ToInt32 (this.txtClaveEmpleadoEntrega.Text),
                       frm_pagos.K_Banco_Transferencia,
                       frm_pagos.Cuenta_Transferencia,
                       frm_pagos.Cantidad_Transferencia,
                       frm_pagos.K_Banco_Tarjeta,
                       frm_pagos.Numero_Tarjeta,
                       frm_pagos.Aprobacion,
                       frm_pagos.No_Operacion,
                       frm_pagos.B_TajetaCredito,
                       frm_pagos.Cantidad_Tarjeta,
                       frm_pagos.K_Banco_Cheque,
                       frm_pagos.Numero_Cheque,
                       frm_pagos.Cantidad_Cheque,
                       frm_pagos.Efectivo,
                       frm_pagos.Persona_RecibeGuia,
                       frm_pagos.ID_RecibeGuia

                    );

                dgv_datos.Rows[row_index].Cells["PAGO_REGISTRADO"].Value = 1;
                //dgv_datos.Rows[row_index].Cells["COASEGURO"].Value = frm_pagos.total_coaseguro;
            }


           


        }
        private bool Verifica_Remisiones_Registro_Pagos()
        {
            bool verificado = true;

            if (dgv_datos.Rows.Count > 0)
            {
                foreach (DataGridViewRow dgvr in dgv_datos.Rows )
                {
                    if ((int)dgvr.Cells["PAGO_REGISTRADO"].Value == 0) 
                    {
                        verificado = false;
                        break;
                    }
                }

               
            }

            return verificado;
        }
        public override void BaseMetodoLimpiaControles()
        {
            this.txtClaveEmpleadoEntrega.Text = string.Empty;
            this.txtClaveEmpleadoRecibe.Text = string.Empty;
            this.txtClaveLiquidacion.Text = string.Empty;
            this.txtClaveOficina.Text = string.Empty;
            this.txtFechaApertura.Text = string.Empty;
            this.txtEmpleadoEntrega.Text = string.Empty;
            this.txtEmpleadoRecibe.Text = string.Empty;
            this.txtOficinaLiquidacion.Text = string.Empty;
            dgv_datos.Rows.Clear();
            dt_registro_pagos.Rows.Clear();
            
        }
        void Reporte_Gp_Rep_CierreLiq(Int32 K_Liquidacion_Empleados, Int32 K_Empleado)
        {
            DataTable dtResultado = new DataTable();
            dtResultado = SQL_ENTREGAS.Gp_Rep_CierreLiq(K_Liquidacion_Empleados, K_Empleado);
            BaseErrorResultado = false;
            if (dtResultado != null)
            {
                ReportDocument rpt = new REPORTES.RPT_Cierre_Liquidacion();
                ReporteTitulo = "Cierre de Liquidación";
                ReporteModulo = "Pedidos";

                rpt.DataDefinition.FormulaFields["Str_K_Liquidacion_Empleados"].Text = "'" + "14" + "'";

                ConectaReporte(ref rpt, dtResultado, ReporteTitulo, ReporteModulo, "", true);
                ReporteRPT = rpt;

                Frm_Reportes frmReporte = new Frm_Reportes();
                frmReporte.P_Titulo = ReporteTitulo;
                frmReporte.P_ReporteRPT = ReporteRPT;
                frmReporte.P_TablaCorreo = ReportedtCorreo;
                frmReporte.ShowDialog();
            }


        }
 
    }
}
