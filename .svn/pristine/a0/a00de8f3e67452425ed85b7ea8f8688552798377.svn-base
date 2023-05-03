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

namespace ProbeMedic.CXP
{
    public partial class Frm_CapturaMotivoNoAutoriza : FormaBase
    {
        DataTable dtMotivos = new DataTable();
        SQLCuentasxPagar sQLCXP = new SQLCuentasxPagar();
        int res = 0;
        string msg = string.Empty;

        public Frm_CapturaMotivoNoAutoriza()
        {
            InitializeComponent();
            BaseBotonAfectar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonReporte.Visible = false;

            DataTable dtMotivos = sQLCXP.SK_Motivos_NoAutorizacion();
            if (dtMotivos != null)
            {
                LlenaCombo(dtMotivos, ref cbx_Motivos, "K_Motivos_NoAutorizacion", "D_Motivos_NoAutorizcion", 0);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            res = 0;
            if (cbx_Motivos.SelectedValue == null)
            {
                MessageBox.Show("DEBE SELECCIONAR UN MOTIVO DE CANCELACIÓN...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbx_Motivos.Focus();
                return;
            }
            if (LblClave.Text.Trim() == "")
            {
                MessageBox.Show("DEBE INDICAR EL NUMERO DE CUENTA ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                res = sQLCXP.UP_NoAutoriza_Orden(Convert.ToInt32(cbx_Motivos.SelectedValue), Convert.ToInt32(Lbl_CajaChica.Text),Convert.ToInt32(LblClave.Text), ref msg);


                if (res == 0)
                {
                    MessageBox.Show("LA FACTURA FUE REGISTRADA COMO NO AUTORIZADA ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                }
            }
        }

        //private void Frm_CapturaMotivoNoAutoriza_Load(object sender, EventArgs e)
        //{
        //    LblClave.Text = Convert.ToString(K_Clave);
        //    Lbl_CajaChica.Text = Convert.ToString(K_Caja_Chica);
        //    txtClaveProveedor.Text = Convert.ToString(K_Proveedor);
        //    txtProveedor.Text = D_Proveedor;
        //    txtSerie.Text = Serie;
        //    txtFolio.Text = Folio;
        //}
    }
}
