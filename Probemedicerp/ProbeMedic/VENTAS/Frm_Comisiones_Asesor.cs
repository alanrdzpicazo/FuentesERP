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

namespace ProbeMedic.VENTAS
{
    public partial class Frm_Comisiones_Asesor : FormaBase
    {
        SQLVentas sql_ventas = new SQLVentas();
        DataTable dtEncabezado = new DataTable();
        public Frm_Comisiones_Asesor()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            this.WindowState = FormWindowState.Maximized;

            BaseBotonAfectar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBuscar.Visible = true;
            BaseBotonBuscar.Enabled = true;
            BaseBotonExcel.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonReporte.Visible = false;
            BaseBotonCancelar.Visible = false;

            this.grdDetalle.MultiSelect = false;
            this.grdDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.grdDetalle.BackgroundColor = Color.White;
            this.grdDetalle.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 70, 209);
            this.grdDetalle.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.grdDetalle.EnableHeadersVisualStyles = false;
            this.grdDetalle.AutoGenerateColumns = false;
            
            int var_mesActual = DateTime.Now.Month; // obtengo el mes actual
            int var_anio = DateTime.Now.Year; // obtengo el año actual 
            int var_totalDiasMes = DateTime.DaysInMonth(var_anio, var_mesActual);
            dtpInicial.Value = Convert.ToDateTime(var_mesActual + "/01" + "/" + var_anio);// pongo el 1 porque siempre es el primer día obvio
            dtpFinal.Value = Convert.ToDateTime(var_mesActual + "/" + var_totalDiasMes + "/" + var_anio); //resto un día al mes y con esto obtengo el ultimo día
        }
        public override void BaseBotonBuscarClick()
        {
            if(txtClaveAsesor.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN ASESOR...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dtEncabezado = sql_ventas.Gp_RepComisionesAsesor(Convert.ToInt32(txtClaveAsesor.Text.Trim()), dtpInicial.Value, dtpFinal.Value);
            this.grdDetalle.DataSource = dtEncabezado;
          
        }

        private void BtnAsesor_Click(object sender, EventArgs e)
        {
            Busquedas.BuscaAsesores frm = new Busquedas.BuscaAsesores();
            frm.ShowDialog();
            if (frm.LLave_Seleccionado != 0 && frm.Descripcion_Seleccionado != "")
            {
                txtClaveAsesor.Text = frm.LLave_Seleccionado.ToString();
                txtAsesor.Text = frm.Descripcion_Seleccionado.ToString();
            }
        }
    }
}
