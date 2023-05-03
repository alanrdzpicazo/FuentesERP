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
        }

        private void btnBuscaEmpleado_Click(object sender, EventArgs e)
        {
            Frm_Busca_Empleado frm = new Frm_Busca_Empleado();

            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(GlobalVar.dtEmpleados);
            frm.BusquedaPropiedadTablaFiltra = GlobalVar.dtEmpleados;
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
        private void btnGuardarLiquidacion_Click(object sender, EventArgs e)
        {

            int res = 0;
            string msg = string.Empty;
            int  CampoIdentity = 0; //

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
                    BaseMetodoInicio();
                    BaseMetodoLimpiaControles();
                }
            }

            //SQL_ENTREGAS.Gp_In_Liquidacion_Camionetas(ref CampoIdentity, GlobalVar.K_Empleado, DateTime.Now, Convert.ToInt32(this.txtClaveEmpleado.Text), Convert.ToInt32(this.cbx_oficina1.SelectedValue), this.dt_remisiones, ref msg);
            
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

        public override void BaseMetodoLimpiaControles()
        {
            this.txtClaveEmpleado.Text = string.Empty;
            this.txtClaveRemision.Text = string.Empty;
            this.txtEmpleado.Text = string.Empty;
            this.dgv_datos.Rows.Clear();
            this.dt_remisiones.Rows.Clear();
            
           
        }
    }


}
