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

namespace ProbeMedic.INVENTARIOS
{
    public partial class FRM_CONSULTA_REMISIONES : FormaBase
    {
        SQLAlmacen SqlAlmacen = new SQLAlmacen();
        SQLCatalogos SqlCatalogos = new SQLCatalogos();
        SQLVentas SqlVentas= new SQLVentas();

        DataTable DtAlmacen = new DataTable();
        DataTable DtDetalle = new DataTable();

        public FRM_CONSULTA_REMISIONES()
        {
            InitializeComponent();
            GrdDatos.AutoGenerateColumns = false;
            GrdDetalle.AutoGenerateColumns = false;
        }
        public override void BaseMetodoInicio()
        {
            BaseBotonExcel.Visible = false;
            base.BaseMetodoInicio();
            BaseBotonNuevo.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonCancelar.Visible = true;
            BaseBotonBorrar.Visible = false;
            BaseBotonReporte.Visible = false;    
            BaseBotonBuscar.Visible = true;
            BaseBotonAfectar.Visible = false;
            BaseBotonReporte.Visible = true;
            BaseBotonReporte.Enabled = false;
            BaseBotonCancelar.Text = "Limpiar";

            CargaAlmacenes();
         
        }
        public override void BaseBotonBuscarClick()
        {
            if (GrdDatos.RowCount > 0)
            {
                DataTable Dt = (DataTable)GrdDatos.DataSource;
                Dt.Clear();
            }
            Int32 K_Remision = 0;
            Int32 K_Almacen = 0;
            if (TxtK_Remision.Text.Trim().Length > 0)
            {
                K_Remision = Convert.ToInt32(TxtK_Remision.Text.Trim());
            }                
            else
            {
                K_Remision = 0;
            }
            if(Convert.ToInt32(CbxAlmacen.SelectedValue.ToString()) == 0)
            {
                K_Almacen = 0;
            }
            else
            {
                K_Almacen = Convert.ToInt32(CbxAlmacen.SelectedValue.ToString());
            }

            BaseDtDatos= SqlAlmacen.Sk_Remision(K_Remision, K_Almacen, DtpF_Inicial.Value, DtpF_Final.Value);

            if ((BaseDtDatos == null) || (BaseDtDatos.Rows.Count == 0))
            {
                MessageBox.Show("NO SE ENCONTRO INFORMACION!...", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                BaseBotonReporte.Visible = true;
                BaseBotonReporte.Enabled = false;
            }
            else
            {
                GrdDatos.DataSource = BaseDtDatos;
                BaseBotonReporte.Visible = true;
                BaseBotonReporte.Enabled = true;
            }
                  
            base.BaseBotonBuscarClick();
        }
        public override void BaseBotonCancelarClick()
        {
            base.BaseBotonCancelarClick();
            DtpF_Inicial.Value = DateTime.Now;
            DtpF_Final.Value = DateTime.Now;
            TxtK_Remision.Text = string.Empty;
            if (GrdDatos.RowCount > 0)
            {
                DataTable Dt = (DataTable)GrdDatos.DataSource;
                Dt.Clear();
            }
            BaseMetodoInicio();
        }
        public void CargaAlmacenes()
        {
            DtAlmacen = null;
            CbxAlmacen.DataSource = null;
            CbxAlmacen.Items.Clear();
            CbxAlmacen.AutoCompleteSource = AutoCompleteSource.None;
            CbxAlmacen.AutoCompleteMode = AutoCompleteMode.None;

           DtAlmacen = SqlCatalogos.Sk_Almacenes_Empresa();
        

            if (DtAlmacen != null)
            {
                DataRow dr = DtAlmacen.NewRow();

                dr["K_Almacen"] = 0;
                dr["K_Oficina"] = 0;
                dr["D_Oficina"] = "";
                dr["D_Almacen"] = "TODOS";
                dr["B_AceptaDevolucionesCliente"] = false;

                DtAlmacen.Rows.InsertAt(dr, 0);
                DtAlmacen.AcceptChanges();

                int indice = -1;
                indice = 0;
                LlenaCombo(DtAlmacen, ref CbxAlmacen, "K_Almacen", "D_Almacen", indice);
            }
        }

        private void TxtK_Remision_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((Char.IsNumber(e.KeyChar)) || (e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtK_Remision_TextChanged(object sender, EventArgs e)
        {
            if(TxtK_Remision.Text.Trim().Length>0)
            {
                Int32 Valor = 0;

                if (!Int32.TryParse(TxtK_Remision.Text.Trim(), out Valor))
                {
                    MessageBox.Show("VALOR NO VALIDO!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtK_Remision.Text = string.Empty;
                    TxtK_Remision.Focus();
                }
            }
         
        }

        private void GrdDatos_SelectionChanged(object sender, EventArgs e)
        {
       
               
            if(GrdDatos.CurrentRow!=null)
            {
                if(GrdDatos.CurrentRow.Index>-1)
                {
                    Int32 K_Remision = Convert.ToInt32(GrdDatos.CurrentRow.Cells["K_Remision"].Value.ToString());

                    DtDetalle = SqlAlmacen.Gp_Remision_Detalle(K_Remision);

                    GrdDetalle.DataSource = DtDetalle;
                }
            }
        }


        public override void BaseBotonReporteClick()
        {
            Int32 K_Remision = 0;

            if (GrdDatos.Rows.Count > 0)
            {
                if (GrdDatos.CurrentRow != null)
                {
                    if (GrdDatos.CurrentRow.Index >= 0)
                    {
                        K_Remision = Convert.ToInt32(GrdDatos.CurrentRow.Cells["K_Remision"].Value.ToString());
                        Cursor = Cursors.WaitCursor;
                        Imprimir(K_Remision);
                        Cursor = Cursors.Default;
                    }
                }
                else
                {
                    MessageBox.Show("DEBE SELECCIONAR UN REGISTRO!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    GrdDatos.Focus();
                }
                 
            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR UN REGISTRO!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GrdDatos.Focus();
            }




        }
        private void Imprimir(int Consecutivo)
        {
            DataTable dtReporte = new DataTable();
            dtReporte = SqlVentas.Gp_RepRemision(Consecutivo);

            if (dtReporte == null)
            {
                MessageBox.Show("NO SE ENCONTRO INFORMACION CON LOS PARAMETROS SOLICITADOS...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtReporte.Rows.Count <= 0)
            {
                MessageBox.Show("NO FUE POSIBLE LOCALIZAR NINGUN REGISTRO CON LOS PARAMETROS SOLICITADOS...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            BaseErrorResultado = false;

            if (dtReporte != null)
            {
                ReportDocument rpt = new ProbeMedic.INVENTARIOS.RPT_Remision_Pedidos();
                ReporteTitulo = "REMISION DE PEDIDO";
                ReporteModulo = "Almacén";
                ConectaReporte(ref rpt, dtReporte, ReporteTitulo, ReporteModulo, "", true);
                ReporteRPT = rpt;

                Frm_Reportes frmReporte = new Frm_Reportes();
                frmReporte.P_Titulo = ReporteTitulo;
                frmReporte.P_ReporteRPT = ReporteRPT;
                frmReporte.P_TablaCorreo = ReportedtCorreo;
                frmReporte.ShowDialog();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                BaseBotonReporte.Visible = true;
                BaseBotonReporte.Enabled = false;
            }
            else
            {
                BaseBotonReporte.Visible = true;
                BaseBotonReporte.Enabled = true;
            }
        }
    }
}
