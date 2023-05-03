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

namespace ProbeMedic.INVENTARIOS
{
    public partial class Frm_Cancela_Solicitud : FormaBase
    {
        DataTable dtMotivos = new DataTable();
        SQLAlmacen sQLAlmacen = new SQLAlmacen();
        SQLCatalogos sQLCatalogos = new SQLCatalogos();
        public int K_Solicitud { get; set; }
        int res = 0;

        public Frm_Cancela_Solicitud()
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

            DataTable dtMotivos = sqlCatalogos.Sk_Motivo_Rechazo_Solicitud();
            if (dtMotivos != null)
            {
                LlenaCombo(dtMotivos, ref cbx_Motivos, "K_Motivo_Rechazo_Solicitud", "D_Motivo_Rechazo_Solicitud", 0);
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
            if (Lbl_No_Solicitud.Text.Trim() == "")
            {
                MessageBox.Show("DEBE INDICAR EL NUMERO DE SOLICITUD ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                res = sQLAlmacen.Up_Solicitud_Transferencia(Convert.ToInt32(Lbl_No_Solicitud.Text), Convert.ToInt32(cbx_Motivos.SelectedValue), txtObservaciones.Text);


                if (res == 0)
                {
                    MessageBox.Show("LA SOLICITUD FUE RECHAZADA ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                }
            }
        }

        private void Frm_Cancela_Solicitud_Load(object sender, EventArgs e)
        {
            Lbl_No_Solicitud.Text = Convert.ToString(K_Solicitud);
        }
    }
}
