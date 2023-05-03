using ProbeMedic.Busquedas;
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
using ProbeMedic.AppCode.DCC;
using CrystalDecisions.CrystalReports.Engine;
using System.Reflection;
using System.Data.Common;


namespace ProbeMedic.ENTREGAS
{
    public partial class FRM_ENTREGA_PEDIDOS : FormaBase
    {
        int K_Oficina, K_Empleado_Entrega, K_Empleado_Recibe;
        DataTable dt_remisiones_busqueda,dt_remisiones;
        SQLEntregas SQL_ENTREGAS = new SQLEntregas();

        public FRM_ENTREGA_PEDIDOS()
        {
            InitializeComponent();
            dt_remisiones = new DataTable();
            dt_remisiones.Columns.Add("K_Oficina");
            dt_remisiones.Columns.Add("K_liquidacion_Empleados");
            dt_remisiones.Columns.Add("K_Remision");
            dt_remisiones.Columns.Add("K_Empleado");           
        }
        private void FRM_ENTREGA_PEDIDOS_Load(object sender, EventArgs e)
        {
            this.cbx_oficina1.LlenaDatos();
            this.cbx_oficina1.SelectedValue = GlobalVar.K_Oficina;
            BaseBotonAfectar.Visible = true;
            BaseBotonAfectar.Enabled = true;
            BaseBotonBorrar.Visible = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonExcel.Visible = true;
            BaseBotonGuardar.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonReporte.Visible = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonCancelar.Enabled = false;

        }
      
        private void btnBuscaEmpleado_Click(object sender, EventArgs e)
        {
            DataTable dtRes = new DataTable();
            var x = GlobalVar.dtEmpleados.AsEnumerable().Where(p => p.Field<int>(3) == GlobalVar.K_Oficina).AsDataView();
            var res = from c in GlobalVar.dtEmpleados.AsEnumerable()
                      select c;

            res = res.Where(o => o.Field<int>(3) == GlobalVar.K_Oficina);
            if (res.Any())
            {
                dtRes = res.CopyToDataTable();
            }

            if (dtRes.Rows.Count > 0)
                dtRes = dtRes.DefaultView.ToTable(true);

            Frm_Busca_Empleado frm = new Frm_Busca_Empleado();
  
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dtRes);
            frm.BusquedaPropiedadTablaFiltra = dtRes;
            frm.BusquedaPropiedadTitulo = "Busca empleados";
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {
                txtClaveEmpleado.Text = Convert.ToString(frm.BusquedaPropiedadReglonRes["K_Empleado"]);
                txtEmpleado.Text = Convert.ToString(frm.BusquedaPropiedadReglonRes["D_Empleado"]);
            }
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if(txtClaveRemision.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR UNA REMISIÓN. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
            //llenamos el datagrid de datos
            //VALIDACION DE QUE NO SE REPITA LA REMISIÓN
            if (this.txtClaveRemision.Text.Length > 0)
            {
                if (Valida_Duplica_Remision(Convert.ToInt32(this.txtClaveRemision.Text)))
                {
                    BaseErrorResultado = true;
                    MessageBox.Show("Ya existe una remisión con la misma clave", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                    agrega_remision(dt_remisiones_busqueda, this.txtClaveRemision.Text);
            }

           
        }
        private bool Valida_Duplica_Remision(int num_remision)
        {
            bool es_duplicado = false; 

            foreach(DataGridViewRow dgvr in dgv_datos.Rows)
            {
                if ((int)dgvr.Cells["CLAVE_REMISION"].Value == num_remision)
                {
                    es_duplicado = true;
                    break;
                }
            }

            return es_duplicado;
        }     
        private void agrega_remision(DataTable datos,string clave_remision)
        {
            DataRow[] drows;
            DataRow aux ;
            DataTable dt = new DataTable();
            
            drows = datos.Select("CLAVE_REMISION = " + clave_remision);
            aux =  drows[0];

            this.dgv_datos.Rows.Add(aux["CLAVE_REMISION"],aux["CLAVE_OFICINA"],aux["OFICINA"],this.txtEmpleado.Text ,aux["ESTATUS_REMISION"]);
            dt_remisiones.Rows.Add(aux["CLAVE_OFICINA"], 1, aux["CLAVE_REMISION"], Convert.ToInt32(this.txtClaveEmpleado.Text));
        }
        private void btn_busca_remisiones_Click(object sender, EventArgs e)
        {
            FRM_BUSQUEDA_REMISIONES  frm = new FRM_BUSQUEDA_REMISIONES();
            dt_remisiones_busqueda = new DataTable();

            dt_remisiones_busqueda = SQL_ENTREGAS.Sk_Remisiones_Documentadas(GlobalVar.K_Oficina);

            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dt_remisiones_busqueda);
            frm.BusquedaPropiedadTablaFiltra = dt_remisiones_busqueda;
            frm.BusquedaPropiedadTitulo = "Busca remisiones";
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {

                txtClaveRemision.Text = Convert.ToString(frm.BusquedaPropiedadReglonRes["CLAVE_REMISION"]);
               
               
            }
        }
        private void btn_LiquidacionEmpleado_Click(object sender, EventArgs e)
        {
            FRM_BUSQUEDA_REMISIONES frm = new FRM_BUSQUEDA_REMISIONES();
            DataTable dt_liquidacion = new DataTable();

           

            dt_liquidacion = SQL_ENTREGAS.Sk_Liquidacion_Empleados (GlobalVar.K_Oficina);

            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(dt_liquidacion);
            frm.BusquedaPropiedadTablaFiltra = dt_liquidacion;
            frm.BusquedaPropiedadTitulo = "Busca liquidación empleados";
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {

                txtClaveRemision.Text = Convert.ToString(frm.BusquedaPropiedadReglonRes["CLAVE_LIQUIDACION"]);
                
            }
        }
        void Reporte1(Int32 K_Empleado_Entrega)
        {
            DataTable dtReporte = SQL_ENTREGAS.Gp_Rep_AsigRemisiones(K_Empleado_Entrega);
            ReportedtCorreo = null; //dtReporte
            string Version = "";//dtReporte.Rows[0]["Version"].ToString();

            ReportDocument rpt = new ReportDocument();
            rpt = new ENTREGAS.RPT_Asigna_Remision();

            ReporteTitulo = "Asignación de Remisiones";
            ReporteModulo = "PEDIDOS";

            DataRow row = dtReporte.Rows[0];

            rpt.DataDefinition.FormulaFields["Str_K_Pedido"].Text = "'" + row["K_Pedido"].ToString() + "'";
            rpt.DataDefinition.FormulaFields["Str_K_Remision"].Text = "'" + row["K_Remision"].ToString() + "'";
            rpt.DataDefinition.FormulaFields["Str_D_Oficina"].Text = "'" + row["D_Oficina"].ToString() + "'";
            rpt.DataDefinition.FormulaFields["Str_K_Empleado_Entrega"].Text = "'" + row["K_Empleado_Entrega"].ToString() + "'";
            rpt.DataDefinition.FormulaFields["Str_D_Empleado"].Text = "'" + row["D_Empleado"].ToString() + "'";
            rpt.DataDefinition.FormulaFields["Str_F_Remision"].Text = "'" + row["F_Remision"].ToString() + "'";
            rpt.DataDefinition.FormulaFields["Str_K_Paciente"].Text = "'" + row["K_Paciente"].ToString() + "'";
            rpt.DataDefinition.FormulaFields["Str_Nombre"].Text = "'" + row["Nombre"].ToString() + "'";
            rpt.DataDefinition.FormulaFields["Str_D_Pais"].Text = "'" + row["D_Pais"].ToString() + "'";
            rpt.DataDefinition.FormulaFields["Str_D_Estado"].Text = "'" + row["D_Estado"].ToString() + "'";
            rpt.DataDefinition.FormulaFields["Str_D_Ciudad"].Text = "'" + row["D_Ciudad"].ToString() + "'";
            rpt.DataDefinition.FormulaFields["Str_D_Colonia"].Text = "'" + row["D_Colonia"].ToString() + "'";
            rpt.DataDefinition.FormulaFields["Str_Codigo_Postal"].Text = "'" + row["Codigo_Postal"].ToString() + "'";
            rpt.DataDefinition.FormulaFields["Str_Calle"].Text = "'" + row["Calle"].ToString() + "'";
            rpt.DataDefinition.FormulaFields["Str_Numero_Exterior"].Text = "'" + row["Numero_Exterior"].ToString() + "'";
            rpt.DataDefinition.FormulaFields["Str_Numero_Interior"].Text = "'" + row["Numero_Interior"].ToString() + "'";
            rpt.DataDefinition.FormulaFields["Str_Entre_Calles"].Text = "'" + row["Entre_Calles"].ToString() + "'";
            rpt.DataDefinition.FormulaFields["Str_Edificio"].Text = "'" + row["Edificio"].ToString() + "'";
            rpt.DataDefinition.FormulaFields["Str_Total_Remision"].Text = "'" + row["Total_Remision"].ToString() + "'";
            rpt.DataDefinition.FormulaFields["Str_Coaseguro"].Text = "'" + row["Coaseguro"].ToString() + "'";
            ConectaReporte(ref rpt, null, ReporteTitulo, ReporteModulo, Version);
            ReporteRPT = rpt;

            Frm_Reportes frmReporte = new Frm_Reportes();
            frmReporte.P_Titulo = ReporteTitulo;
            frmReporte.P_ReporteRPT = ReporteRPT;
            frmReporte.P_TablaCorreo = ReportedtCorreo;
            frmReporte.ShowDialog();
        }
        public override void BaseBotonAfectarClick()
        {
            if(txtClaveEmpleado.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR UN EMPLEADO AL QUE SE LE ASIGNARAN LAS REMISIONES. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(dt_remisiones.Rows.Count == 0)
            {
                MessageBox.Show("FALTA AGREGAR REMISIONES. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int res = 0;
            string msg = string.Empty;
            int CampoIdentity = 0; //

            if (dt_remisiones.Rows.Count > 0 && txtClaveEmpleado.Text.Length > 0 && txtClaveRemision.Text.Length > 0)
            {
                res = SQL_ENTREGAS.Gp_In_Liquidacion_Camionetas(ref CampoIdentity, Convert.ToInt32(this.txtClaveEmpleado.Text), DateTime.Now, 1, Convert.ToInt32(this.cbx_oficina1.SelectedValue), this.dt_remisiones, ref msg);

                if (res == -1)
                {
                    BaseErrorResultado = true;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    BaseErrorResultado = false;
                    MessageBox.Show("SE HA ASIGNADO LA LIQUIDACIÓN CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cursor = Cursors.WaitCursor;
                    Reporte1(Convert.ToInt32(txtClaveEmpleado.Text.Trim()));
                    Cursor = Cursors.Default;
                    BaseMetodoInicio();
                    BaseMetodoLimpiaControles();
                }
            }

            //SQL_ENTREGAS.Gp_In_Liquidacion_Camionetas(ref CampoIdentity, GlobalVar.K_Empleado, DateTime.Now, Convert.ToInt32(this.txtClaveEmpleado.Text), Convert.ToInt32(this.cbx_oficina1.SelectedValue), this.dt_remisiones, ref msg);
        }
        public override void BaseMetodoLimpiaControles()
        {
            this.txtClaveEmpleado.Text = string.Empty;
            this.txtClaveRemision.Text = string.Empty;
            this.txtEmpleado.Text = string.Empty;
            this.dgv_datos.Rows.Clear();
            this.dt_remisiones.Rows.Clear();
            
           
        }
        public override void BaseBotonCancelarClick()
        {
            base.BaseBotonCancelarClick();
            BaseMetodoInicio();
            BaseMetodoLimpiaControles();
        }
    }
}
