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
using CrystalDecisions.CrystalReports.Engine;
using ProbeMedic.VENTAS;

namespace ProbeMedic.VENTAS
{
    public partial class Frm_RegistraCajaChica : FormaBase
    {
        Funciones fn = new Funciones();
        SQLVentas sQLVentas = new SQLVentas();
        public  int K_Almacen { get; set; }
        public string D_Almacen { get; set; }
        Funciones fx = new Funciones();

        public Frm_RegistraCajaChica()
        {
            InitializeComponent();
            txtMonto.Moneda.TextChanged += new EventHandler(txtMonto_TextChanged);
        }
        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtMonto.Moneda.Text.Trim().Length > 0)
                {
                    if (Convert.ToDecimal(txtMonto.Moneda.Text.Trim()) > 1000000)
                    {
                        MessageBox.Show("VALOR DEMASIADO GRANDE!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMonto.Moneda.Text = "0.00";
                        txtMonto.Formato(txtMonto.Moneda.Text);
                    }
                }

            }
            catch (Exception ex) { }
        }
        private void BtnAplicar_Click(object sender, EventArgs e)
        {
            Int32 CampoIdentity = 0;

            if ( K_Almacen == 0)
            {
                MessageBox.Show("EL USUARIO NO TIENE ASIGNADO UN ALMACEN...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtMonto.Moneda.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE CAPTURA EL MONTO DE CAJA CHICA..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Int32 res = 0;
            string msg = string.Empty;
            res = sQLVentas.Gp_Entrada_CajaChica(ref CampoIdentity, K_Almacen, Convert.ToDecimal(txtMonto.Moneda.Text),ref msg);

            if (res == -1)
            {
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MessageBox.Show("SE REGISTRO EL PAGO SATISFACTORIAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Cursor = Cursors.WaitCursor;
                DataTable dtResultado = new DataTable();
                dtResultado = sQLVentas.Gp_RepCajaChica(GlobalVar.K_Usuario, K_Almacen, CampoIdentity);

                if (dtResultado != null)
                {
                    ReportDocument rpt = new VENTAS.RPT_Caja_Chica();
                    ReporteTitulo = "REPORTE DE CAJA CHICA";
                    ReporteModulo = "Ventas";
                    ConectaReporte(ref rpt, dtResultado, ReporteTitulo, ReporteModulo, "", true);
                    ReporteRPT = rpt;

                    Frm_Reportes frmReporte = new Frm_Reportes();
                    frmReporte.P_Titulo = ReporteTitulo;
                    frmReporte.P_ReporteRPT = ReporteRPT;
                    frmReporte.P_TablaCorreo = ReportedtCorreo;
                    frmReporte.ShowDialog();
                }
                Cursor = Cursors.WaitCursor;
                this.Close();

            }



        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Frm_RegistraCajaChica_Load(object sender, EventArgs e)
        {
            LblAlmacen.Text  = D_Almacen;
            LblEmpleado.Text = GlobalVar.D_Usuario;
            LblOficina.Text = GlobalVar.D_Oficina;
    
        }

        private void Frm_RegistraCajaChica_Shown(object sender, EventArgs e)
        {
            BaseBarraHerramientas.Visible = false;
            BaseBarraHerramientas.Enabled = false;
        }
    }
}
