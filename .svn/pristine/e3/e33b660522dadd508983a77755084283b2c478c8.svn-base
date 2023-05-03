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

namespace ProbeMedic
{
    public partial class FRM_CONSULTA_PEDIDOS : FormaConsulta
    {
        DataTable dtAlmacen = new DataTable();
        Int32 K_Oficina = 0;
        SQLCatalogos sqlCatalogo = new SQLCatalogos();
        DataTable dtAseguradora = new DataTable();
        SQLPedidos sqlpedidos = new SQLPedidos();

        public FRM_CONSULTA_PEDIDOS()
        {
            InitializeComponent();
            MtdCargaAseguradora();
            cbxAlmacen.Enabled = false;
        }

        private void btnBuscarOficina_Click(object sender, EventArgs e)
        {
            Busquedas.BuscaOficinas frm = new Busquedas.BuscaOficinas();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(GlobalVar.dtOficinas);
            frm.BusquedaPropiedadTablaFiltra = GlobalVar.dtOficinas;
            frm.BusquedaPropiedadTitulo = "Busca Oficinas";
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {
                K_Oficina = Convert.ToInt16(frm.BusquedaPropiedadReglonRes["K_Oficina"]);
                txtClaveOficina.Text = Convert.ToString(frm.BusquedaPropiedadReglonRes["K_Oficina"]);
                txtOficina.Text = frm.BusquedaPropiedadReglonRes["D_Oficina"].ToString();
                MtdCargaAlmacen();
            }
        }
        void MtdCargaAlmacen()
        {
            if (K_Oficina == 0)
            {
                dtAlmacen.Rows.Clear();
            }
            else
            {
                dtAlmacen = sqlCatalogo.Sk_Almacenes(K_Oficina);
            }

            if (dtAlmacen != null)
            {
                DataRow dr = dtAlmacen.NewRow();

                dr["K_Almacen"] = 0;
                dr["K_Oficina"] = 0;
                dr["D_Oficina"] = "";
                dr["D_Almacen"] = "[SELECCIONAR]";
                dr["B_AceptaDevolucionesCliente"] = false;

                dtAlmacen.Rows.InsertAt(dr, 0);
                dtAlmacen.AcceptChanges();

                int indice = -1;
                indice = 0;
                LlenaCombo(dtAlmacen, ref cbxAlmacen, "K_Almacen", "D_Almacen", indice);
            }
        }

        void MtdCargaAseguradora()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = sqlCatalogo.Sk_Aseguradora();
                cbxAseguradora.DataSource = dt;
                cbxAseguradora.DisplayMember = "D_Aseguradora";
                cbxAseguradora.ValueMember = "K_Aseguradora";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }



        }

        private void txtClaveOficina_TextChanged(object sender, EventArgs e)
        {
            if (txtClaveOficina.Text.Length > 0)
                cbxAlmacen.Enabled = true;
            else
                cbxAlmacen.Enabled = false;
        }
        public override void BaseBotonBuscarClick()
        {

            DataTable dt = sqlpedidos.Sk_Pedidos(Convert.ToInt32(txtNoPedido.Text.Length > 0 ? txtNoPedido.Text:"0"),Convert.ToInt32(txtClaveOficina.Text.Length > 0? txtClaveOficina.Text:"0"),Convert.ToInt32(cbxAlmacen.SelectedValue == null? 0 : cbxAlmacen.SelectedValue) , checkBoxCancelado.Checked,checkBoxRemisionado.Checked, ucPacientes1.K_Paciente,Convert.ToInt32 (cbxAseguradora.SelectedValue==null? 0: cbxAseguradora.SelectedValue), ucClientes1.K_Cliente , dtp_inicial.Value, dtp_final.Value );
            BaseDtDatos = dt;
            dgv_datos .AutoGenerateColumns = false;
            dgv_datos.DataSource = dt;

           

            if ((dt != null) && (dt.Rows.Count != 0))
            {
                BaseBotonCancelar.Visible = true;
                BaseBotonExcel.Visible = true;
            }
            else
            {
                MessageBox.Show("NO existen datos con los parámetros seleccionados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public override void BaseMetodoInicio()
        {

            BaseBotonNuevo.Visible = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonModificar.Visible = false;
            BaseBotonModificar.Enabled = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonGuardar.Enabled = false;
            BaseBotonBuscar.Visible = true;
            BaseBotonBuscar.Enabled = true;
            BaseBotonCancelar.Visible = false;
            BaseBotonCancelar.Enabled = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonAfectar.Enabled = false;
            BaseBotonReporte.Visible = false;
            BaseBotonReporte.Enabled = false;
        }

        public bool Valida_Entradas()
        {
            bool validado = false;


            return validado;
        }
    }
}
