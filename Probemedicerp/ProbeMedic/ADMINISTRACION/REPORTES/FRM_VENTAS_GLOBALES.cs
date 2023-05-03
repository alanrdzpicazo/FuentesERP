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

namespace ProbeMedic.ADMINISTRACION.REPORTES
{
    public partial class FRM_VENTAS_GLOBALES : FormaBase
    {
        SQLAdministracion sqlAdministracion = new SQLAdministracion();
        Procesos procesos = new Procesos();
        DataTable dtCliente = new DataTable();
        DateTime F_Inicial = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        DateTime F_Final = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
        public List<Int32> LstClientesSeleccionados = new List<Int32>();
        public FRM_VENTAS_GLOBALES()
        {
            InitializeComponent();
            dtpInicial.Value = DateTime.Now.PrimerDiaDelMes();
            dtpFinal.Value = DateTime.Now;
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
   
            rdb_TodosClientes.Checked = true;
            cmb_Reporte.SelectedIndex = 0;
            BaseBotonReporte.Visible = true;
            BaseBotonReporte.Enabled = false;
            BaseBotonExcel.Visible = true;
            BaseBotonExcel.Enabled = false;

            dtCliente = Clientes_Type;     
        }
        public override void BaseBotonReporteClick()
        {
            if(cmb_Reporte.SelectedIndex ==0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN REPORTE!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((!chk_Aseguradora.Checked)&&(!chk_VP.Checked) &&(!chk_Farmacia.Checked) &&(!chk_Coaseguro.Checked) && (cmb_Reporte.SelectedIndex == 1 || cmb_Reporte.SelectedIndex == 3))
            {
                MessageBox.Show("DEBE SELECCIONAR AL MENOS UN TIPO DE VENTA!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dtCliente.Rows.Clear();
            Clientes();
            Cursor = Cursors.WaitCursor;
            if(cmb_Reporte.SelectedIndex ==1)
            {
                procesos.Rep_VentasGlobales(GlobalVar.PC_Name, GlobalVar.K_Usuario, chk_Farmacia.Checked, chk_VP.Checked, chk_Aseguradora.Checked,
                    chk_Coaseguro.Checked,dtpInicial.Value, dtpFinal.Value, dtCliente);
            }
            if (cmb_Reporte.SelectedIndex == 2)
            {
                 procesos.Rep_RemisionesPorFacturar();
            }
            if (cmb_Reporte.SelectedIndex == 4)
            {
                procesos.Rep_ConsultaUtilidad(dtpInicial.Value, dtpFinal.Value);
            }


            Cursor = Cursors.Default;        
        }
        public override void BaseBotonExcelClick()
        {
            if (cmb_Reporte.SelectedIndex == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN REPORTE!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((!chk_Aseguradora.Checked) && (!chk_VP.Checked) && (!chk_Farmacia.Checked) && (!chk_Coaseguro.Checked) && (cmb_Reporte.SelectedIndex == 1 || cmb_Reporte.SelectedIndex == 3))
            {

                MessageBox.Show("DEBE SELECCIONAR AL MENOS UN TIPO DE VENTA!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dtCliente.Rows.Clear();
            Clientes();
            Cursor = Cursors.WaitCursor;
            if (cmb_Reporte.SelectedIndex == 1)
            {
                BaseDtDatos = sqlAdministracion.Gp_Reporte_VentasGlobales(GlobalVar.PC_Name, GlobalVar.K_Usuario, chk_Farmacia.Checked, 
                chk_VP.Checked, chk_Aseguradora.Checked,chk_Coaseguro.Checked,dtpInicial.Value, dtpFinal.Value, dtCliente);
            }
            if (cmb_Reporte.SelectedIndex == 2)
            {
                BaseDtDatos = sqlAdministracion.Gp_RepRemisionesPorFacturar();
            }
            if (cmb_Reporte.SelectedIndex == 3)
            {
                BaseDtDatos = sqlAdministracion.Gp_Reporte_VentasNetas(GlobalVar.PC_Name, GlobalVar.K_Usuario, chk_Farmacia.Checked,
                chk_VP.Checked, chk_Aseguradora.Checked, chk_Coaseguro.Checked, dtpInicial.Value, dtpFinal.Value, dtCliente);
            }
            if (cmb_Reporte.SelectedIndex == 4)
            {
                BaseDtDatos = sqlAdministracion.Gp_Consulta_Utilidad(dtpInicial.Value,dtpFinal.Value);
            }

            if (cmb_Reporte.SelectedIndex == 5)
            {
                BaseDtDatos = sqlAdministracion.Rpt_PromedioPonderado();// dtpInicial.Value, dtpFinal.Value);
            }
            if (cmb_Reporte.SelectedIndex == 6)
            {
                BaseDtDatos = sqlAdministracion.Rpt_ReporteCosteo(dtpInicial.Value,dtpFinal.Value);// dtpInicial.Value, dtpFinal.Value);
            }
            base.BaseBotonExcelClick();

            Cursor = Cursors.Default;
        }
        private void Clientes()
        {
            foreach (var item in LstClientesSeleccionados)
            {
                DataRow row = dtCliente.NewRow();
                row["K_Cliente"] = item;

                dtCliente.Rows.Add(row);
                dtCliente.AcceptChanges();
            }
        }
        private void rdbSeleccionarClientes_Click(object sender, EventArgs e)
        {
            LblClientes.Text = string.Empty;

            Cursor = Cursors.WaitCursor;
            ProbeMedic.REPORTES.ASIGNACIONES.Frm_AsignacionClientes frm = new ProbeMedic.REPORTES.ASIGNACIONES.Frm_AsignacionClientes();
            frm.ShowDialog();
            Cursor = Cursors.Default;

            DataTable dtPaso = frm.dtSeleccionados;
            if (dtPaso != null)
            {
                if (dtPaso.Rows.Count > 0)
                {
                    int cont = 0;
                    foreach (DataRow row in dtPaso.Rows)
                    {
                        Int32 K_Cliente = Convert.ToInt32(row["K_Cliente"].ToString());
                        string D_Cliente = row["D_Cliente"].ToString();
                        LblClientes.Text = LblClientes.Text + K_Cliente + ",";
                        LstClientesSeleccionados.Add(K_Cliente);
                        cont += 1;
                    }
                    LblClientes.Text = LblClientes.Text.TrimEnd(',');
                    if (LblClientes.Text.Length <= 204)
                    {
                        LblClientes.Text = LblClientes.Text + ".";
                    }
                    else
                    {
                        LblClientes.Text = LblClientes.Text.Remove(200);
                        LblClientes.Text = LblClientes.Text + "....";
                    }

                }

            }
        }

        private void rdbTodosClientes_Click(object sender, EventArgs e)
        {
            LblClientes.Text = string.Empty;
            LstClientesSeleccionados.Clear();
        }

        private void cmb_Reporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmb_Reporte.SelectedIndex)
            {
                case 1:
                    BaseBotonReporte.Visible = true;
                    BaseBotonReporte.Enabled = true;
                    BaseBotonExcel.Visible = true;
                    BaseBotonExcel.Enabled = true;
                    groupBox1.Enabled = true;
                    groupBox2.Enabled = true;
                    gbCliente.Enabled = true;
                    break;

                case 2:
                    BaseBotonReporte.Visible = true;
                    BaseBotonReporte.Enabled = true;
                    BaseBotonExcel.Visible = true;
                    BaseBotonExcel.Enabled = true;
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    gbCliente.Enabled = false;
                    break;

                case 3:
                    BaseBotonReporte.Visible = true;
                    BaseBotonReporte.Enabled = false;
                    BaseBotonExcel.Visible = true;
                    BaseBotonExcel.Enabled = true;
                    groupBox1.Enabled = true;
                    groupBox2.Enabled = true;
                    gbCliente.Enabled = true;
                    break;

                case 4:
                    BaseBotonReporte.Visible = true;
                    BaseBotonReporte.Enabled = true;
                    BaseBotonExcel.Visible = true;
                    BaseBotonExcel.Enabled = true;
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    gbCliente.Enabled = false;
                    break;

                case 5:
                    BaseBotonReporte.Visible = true;
                    BaseBotonReporte.Enabled = true;
                    BaseBotonExcel.Visible = true;
                    BaseBotonExcel.Enabled = true;
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    gbCliente.Enabled = false;
                    break;

                case 6:
                    BaseBotonReporte.Visible = true;
                    BaseBotonReporte.Enabled = true;
                    BaseBotonExcel.Visible = true;
                    BaseBotonExcel.Enabled = true;
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = true;
                    gbCliente.Enabled = false;
                    break;

            }
   
              
        }
    }
}
