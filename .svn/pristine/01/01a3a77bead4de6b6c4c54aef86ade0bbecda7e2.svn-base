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
    public partial class Frm_ConsultaCajaChica : FormaBase
    {
        SQLCuentasxPagar sql_cxp = new SQLCuentasxPagar();
        DataTable dtAlmacen = new DataTable();
        public string Caja_Chica { get; set; }

        public Frm_ConsultaCajaChica()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            BaseBotonExcel.Visible = true;
            BaseBotonReporte.Visible = false;
            BaseBotonBuscar.Visible = true;
            BaseBotonAfectar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonNuevo.Visible = false;
            grdDatos.AutoGenerateColumns = false;

            DataTable dtCXP = sql_cxp.Gp_ValidaUsuarioCajaChica(GlobalVar.K_Usuario);
            if ((dtCXP == null) || (dtCXP.Rows.Count == 0))
            {
                BtnUsuario.Enabled = false;
                txtK_Usuario.Text = Convert.ToString(GlobalVar.K_Usuario);
                txtD_Usuario.Text = GlobalVar.D_Usuario;

            }
            else
            {
                DataRow dr = dtCXP.Rows[0];
                txtK_Usuario.Text = dr["K_Usuario"].ToString();
                txtD_Usuario.Text = dr["D_Usuario"].ToString();
                BtnUsuario.Enabled = true;

            }
            CbxCajaChica.Checked = true;

        }

        public override void BaseBotonBuscarClick()
        {
            int K_Usuario = 0;

            if (txtK_Usuario.Text.Trim().Length > 0)
            {
                K_Usuario = Convert.ToInt32(txtK_Usuario.Text);
            }


            DataTable dtCXP = sql_cxp.Sk_Consulta_CajaChica(Convert.ToInt32(cbxAlmacen.SelectedValue), K_Usuario, CbxLiquidada.Checked, CbxCajaChica.Checked,
                                                            CbxViaticos.Checked, CbxReposicion.Checked);

            grdDatos.DataSource = dtCXP;

            if (grdDatos.RowCount == 0)
            {
                MessageBox.Show("NO EXISTEN INFORMACION CON LOS PARAMETROS INDICADOS", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void BtnOficina_Click(object sender, EventArgs e)
        {
            Busquedas.BuscaOficinas frm = new Busquedas.BuscaOficinas();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(GlobalVar.dtOficinas);
            frm.BusquedaPropiedadTablaFiltra = GlobalVar.dtOficinas;
            frm.BusquedaPropiedadTitulo = "Busca Oficinas";
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {
                txtClaveOficina.Text = frm.BusquedaPropiedadReglonRes["K_Oficina"].ToString();
                txtOficina.Text = frm.BusquedaPropiedadReglonRes["D_Oficina"].ToString();
            }
            if (txtClaveOficina.Text != "")
            {
                dtAlmacen = sqlCatalogos.Sk_Almacenes(Convert.ToInt32(txtClaveOficina.Text));
                LlenaCombo(dtAlmacen, ref cbxAlmacen, "K_Almacen", "D_Almacen");
            }
        }
        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            Busquedas.BuscaUsuarios frm = new Busquedas.BuscaUsuarios();
            frm.BusquedaPropiedadTitulo = "Busca Usuarios";
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(GlobalVar.dtUsuarios);
            frm.BusquedaPropiedadTablaFiltra = GlobalVar.dtUsuarios;
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {
                txtK_Usuario.Text = frm.BusquedaPropiedadReglonRes["K_Usuario"].ToString();
                txtD_Usuario.Text = frm.BusquedaPropiedadReglonRes["D_Usuario"].ToString();
            }
        }

        private void grdDatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdDatos.CurrentRow != null)
            {
                DataGridViewRow fila = grdDatos.Rows[e.RowIndex];
                Caja_Chica = Convert.ToString(fila.Cells["K_Caja_Chica"].Value);
                this.Close();

            }
        }
    }
}
