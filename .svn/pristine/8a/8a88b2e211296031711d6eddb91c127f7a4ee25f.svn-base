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
//using ProbeMedic.Modelos;

namespace ProbeMedic.INVENTARIOS
{
    public partial class Frm_Consulta_Movimientos_Transito : FormaBase
    {
        SQLCatalogos sqlCatalogo = new SQLCatalogos();
        SQLAlmacen sqlAlmacen = new SQLAlmacen();
        DataTable dtAlmacen = new DataTable();
        DataTable dtAlmacenRecibe = new DataTable();
        DataTable dtInventarioTransito = new DataTable();
        Funciones fx = new Funciones();
        //AlmacenBL blAlmacen = new AlmacenBL();
       // List<MovimientosTransito> lstInventarioTransito = new List<MovimientosTransito>();

        int K_AlmacenEnvia = 0;
        int K_AlmacenRecibe = 0;
        int AnioConsulta = 0;
        short MesConsulta = 0;
        int AnioActual = DateTime.Now.Year;
        int MesActual = DateTime.Now.Month;
        int Consecutivo = 0;
        public Frm_Consulta_Movimientos_Transito()
        {
            InitializeComponent();

            Shown += new EventHandler(Principal_Shown);
            this.sel_OficinaEnvia.PropertyChanged += new PropertyChangedEventHandler(sel_OficinaEnvia_PropertyChanged);
            this.sel_OficinaRecibe.PropertyChanged += new PropertyChangedEventHandler(sel_OficinaRecibe_PropertyChanged);
            if (cBoxFiltroFecha.CanFocus)
                cBoxFiltroFecha.Focus();
        }

        private void Frm_Consulta_Movimientos_Transito_Load(object sender, EventArgs e)
        {

        }

        void Principal_Shown(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Normal;
            BaseBotonReporte.Visible = false;
            BaseBotonReporte.Enabled = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonAfectar.Enabled = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonGuardar.Enabled = false;
            BaseBotonModificar.Visible = false;
            BaseBotonModificar.Enabled = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonCancelar.Enabled = false;
            BaseBotonExcel.Visible = false;
            BaseBotonExcel.Enabled = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonBuscar.Visible = true;
            BaseBotonBuscar.Enabled = true;
            NumericUpDwn.Value = AnioActual;
            cBoxMes.SelectedIndex = MesActual;
            cBoxFiltroFecha.Checked = false;
            cBoxFiltroFecha_CheckedChanged(sender, e);
            cBoxFiltroOficinaEnvia.Checked = false;
            cBoxFiltroOficinaEnvia_CheckedChanged(sender, e);
            cBoxFiltroOficinaRecibe.Checked = false;
            cBoxFiltroOficinaRecibe_CheckedChanged(sender, e);
        }

        private void rbMP_CheckedChanged(object sender, EventArgs e)
        {
            txtConsecutivo.Clear();
            cBoxFiltroFecha.Checked = false;
            cBoxFiltroFecha_CheckedChanged(sender, e);
            cBoxFiltroOficinaEnvia.Checked = false;
            cBoxFiltroOficinaEnvia_CheckedChanged(sender, e);
            cBoxFiltroOficinaRecibe.Checked = false;
            cBoxFiltroOficinaRecibe_CheckedChanged(sender, e);
        }

        private void rbPT_CheckedChanged(object sender, EventArgs e)
        {
            txtConsecutivo.Clear();
            cBoxFiltroFecha.Checked = false;
            cBoxFiltroFecha_CheckedChanged(sender, e);
            cBoxFiltroOficinaEnvia.Checked = false;
            cBoxFiltroOficinaEnvia_CheckedChanged(sender, e);
            cBoxFiltroOficinaRecibe.Checked = false;
            cBoxFiltroOficinaRecibe_CheckedChanged(sender, e);
        }

        public override void BaseBotonBuscarClick()
        {
          
            #region ValidacionFiltroFecha
            if (cBoxFiltroFecha.Checked)
            {
                if (NumericUpDwn.Value <= DateTime.Now.Month)
                {
                    MessageBox.Show("DEBE INDICAR UN AÑO DE CONSULTA VALIDO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NumericUpDwn.Focus();
                    return;
                }
                AnioConsulta = Convert.ToInt32(NumericUpDwn.Value);

                if (cBoxMes.SelectedValue != null)
                {
                    if (cBoxMes.SelectedValue.ToString() != "System.Data.DataRowView")
                    {
                        MesConsulta = Convert.ToInt16(cBoxMes.SelectedValue);
                    }
                }
                if (cBoxMes.SelectedIndex < 0)
                {
                    MessageBox.Show("FAVOR DE SELECCIONAR EL MES DE CONSULTA", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cBoxMes.Focus();
                    return;
                }
                MesConsulta = Convert.ToInt16(cBoxMes.SelectedIndex);
                if (MesConsulta < 0)
                {
                    MessageBox.Show("DEBE INDICAR EL MES DE CONSULTA", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cBoxMes.Focus();
                    return;
                }
            }
            else
            {
                AnioConsulta = 0;
                MesConsulta = 0;
            }
            #endregion ValidacionFiltroFecha

            #region ValidacionFiltroOficinaEnvia
            if (cBoxFiltroOficinaEnvia.Checked)
            {
                if (sel_OficinaEnvia.K_Oficina == 0)
                {
                    MessageBox.Show("DEBE SELECCIONAR LA OFICINA ENVIA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sel_OficinaEnvia.Focus();
                    return;
                }
                K_AlmacenEnvia = 0;
                if (cbxAlmacenEnvia.SelectedValue != null)
                {
                    if (cbxAlmacenEnvia.SelectedValue.ToString() != "System.Data.DataRowView")
                    {
                        K_AlmacenEnvia = Convert.ToInt32(cbxAlmacenEnvia.SelectedValue);
                    }
                }
            }
            else
            {
                sel_OficinaEnvia.K_Oficina = 0;
                K_AlmacenEnvia = 0;
            }
            #endregion ValidacionFiltroOficinaEnvia

            #region ValidacionFiltroOficinaRecibe
            if (cBoxFiltroOficinaRecibe.Checked)
            {
                if (sel_OficinaRecibe.K_Oficina == 0)
                {
                    MessageBox.Show("DEBE SELECCIONAR LA OFICINA RECIBE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sel_OficinaRecibe.Focus();
                    return;
                }
                K_AlmacenRecibe = 0;
                if (cbxAlmacenRecibe.SelectedValue != null)
                {
                    if (cbxAlmacenRecibe.SelectedValue.ToString() != "System.Data.DataRowView")
                    {
                        K_AlmacenRecibe = Convert.ToInt32(cbxAlmacenRecibe.SelectedValue);
                    }
                }
            }
            else
            {
                sel_OficinaRecibe.K_Oficina = 0;
                K_AlmacenRecibe = 0;
            }
            #endregion ValidacionFiltroOficinaRecibe

            Consecutivo = 0;
            if (txtConsecutivo.Text.ToString().Length > 0)
            {
                Consecutivo = Convert.ToInt32(txtConsecutivo.Text);
            }

            grdDatos.AutoGenerateColumns = false;
            dtInventarioTransito = sqlAlmacen.Sk_ConsultaMovimentosEnTransito(
                sel_OficinaEnvia.K_Oficina, 
                K_AlmacenEnvia, 
                sel_OficinaRecibe.K_Oficina, 
                K_AlmacenRecibe,
                AnioConsulta,
                MesConsulta, 
                Consecutivo
                );
            //lstInventarioTransito = blAlmacen.sps_ConsultaMovimentosEnTransito(B_Producto, sel_OficinaEnvia.K_Oficina, K_AlmacenEnvia, sel_OficinaRecibe.K_Oficina, K_AlmacenRecibe, AnioConsulta, MesConsulta, Consecutivo);
            //dtInventarioTransito = lstInventarioTransito.ToDataTable();

            grdDatos.DataSource = dtInventarioTransito;
            if (dtInventarioTransito != null)
            {
                if (dtInventarioTransito.Rows.Count > 0)
                {
                    grdDatos.AutoGenerateColumns = false;
                    grdDatos.DataSource = dtInventarioTransito;
                    //                    FormatoGrid(ref grdDatos);
                    grdDatos.AutoGenerateColumns = false;
                    grdDatos.ScrollBars = ScrollBars.Both;
                    grdDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    grdDatos.BorderStyle = BorderStyle.None;
                    grdDatos.MultiSelect = false;
                    grdDatos.AllowUserToResizeColumns = true;
                    BaseBotonCancelar.Visible = true;
                    BaseBotonCancelar.Enabled = true;
                    BaseBotonBuscar.Enabled = false;
                    BaseBotonBuscar.Visible = false;
                    //PnlParametros.Enabled = false;
                }
                else
                {
                    MessageBox.Show("NO FUE POSIBLE LOCALIZAR INFORMACION CON LOS PARAMETROS INDICADOS", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("NO SE ENCONTRO INFORMACION CON LOS PARAMETROS INDICADOS", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        public override void BaseBotonCancelarClick()
        {
            DialogResult result = MessageBox.Show("¿DESEA CANCELAR LA BUSQUEDA EN PANTALLA?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    PnlParametros.Enabled = true;
                    if (dtInventarioTransito != null)
                    {
                        if (dtInventarioTransito.Rows.Count > 0)
                        {
                            dtInventarioTransito.Clear();
                        }
                    }
                    grdDatos.DataSource = null;
                }
                finally
                {
                    BaseBotonCancelar.Visible = false;
                    BaseBotonCancelar.Enabled = false;
                    BaseBotonExcel.Visible = false;
                    BaseBotonExcel.Enabled = false;
                    BaseBotonBuscar.Visible = true;
                    BaseBotonBuscar.Enabled = true;
                }
            }
            else
            {
                BaseBotonCancelar.Visible = true;
                BaseBotonCancelar.Enabled = true;
            }
        }

        private void sel_OficinaEnvia_PropertyChanged(object sender, EventArgs e)
        {
            if (sel_OficinaEnvia.K_Oficina > 0)
            {
                MtdCargaAlmacen();
            }
            else
            {
                if (sel_OficinaEnvia.K_Oficina == 0)
                {
                    if(dtAlmacen != null)
                    dtAlmacen.Rows.Clear();
                }
            }
        }

        private void sel_OficinaRecibe_PropertyChanged(object sender, EventArgs e)
        {
            if (sel_OficinaRecibe.K_Oficina > 0)
            {
                MtdCargaAlmacenRecibe();
            }
            else
            {
                if (sel_OficinaRecibe.K_Oficina == 0)
                {
                    if (dtAlmacenRecibe != null)
                        dtAlmacenRecibe.Rows.Clear();
                }
            }
        }

        void MtdCargaAlmacen()
        {
           
            //dtAlmacen.Rows.Clear();
            cbxAlmacenEnvia.DataSource = null;
            cbxAlmacenEnvia.Items.Clear();
            cbxAlmacenEnvia.AutoCompleteSource = AutoCompleteSource.None;
            cbxAlmacenEnvia.AutoCompleteMode = AutoCompleteMode.None;

            if (sel_OficinaEnvia.K_Oficina == 0)
            {
                dtAlmacen.Rows.Clear();
            }
            else
            {
                dtAlmacen = sqlCatalogo.Sk_Almacenes(sel_OficinaEnvia.K_Oficina);
            }

            if(dtAlmacen != null)
            {
                DataRow dr = dtAlmacen.NewRow();

                dr["K_Almacen"] = 0;
                dr["K_Oficina"] = 0;
                dr["D_Oficina"] = "";
                dr["D_Almacen"] = "TODOS";
                dr["B_AceptaDevolucionesCliente"] = false;



                dtAlmacen.Rows.InsertAt(dr, 0);

                dtAlmacen.AcceptChanges();

                int indice = -1;
                indice = 0;
                LlenaCombo(dtAlmacen, ref cbxAlmacenEnvia, "K_Almacen", "D_Almacen", indice);
            }

           
        }

        void MtdCargaAlmacenRecibe()
        {
           
            //dtAlmacenRecibe.Rows.Clear();
            cbxAlmacenRecibe.DataSource = null;
            cbxAlmacenRecibe.Items.Clear();
            cbxAlmacenRecibe.AutoCompleteSource = AutoCompleteSource.None;
            cbxAlmacenRecibe.AutoCompleteMode = AutoCompleteMode.None;

            if (sel_OficinaRecibe.K_Oficina == 0)
            {
                dtAlmacenRecibe.Rows.Clear();
            }
            else
            {
                dtAlmacenRecibe = sqlCatalogo.Sk_Almacenes(sel_OficinaRecibe.K_Oficina);
            }

            if (dtAlmacenRecibe != null)
            {


                DataRow dr = dtAlmacenRecibe.NewRow();

                dr["K_Almacen"] = 0;
                dr["K_Oficina"] = 0;
                dr["D_Oficina"] = "";
                dr["D_Almacen"] = "TODOS";
                dr["B_AceptaDevolucionesCliente"] = false;

                dtAlmacenRecibe.Rows.InsertAt(dr, 0);

                dtAlmacenRecibe.AcceptChanges();

                int indice = -1;
                indice = 0;
                LlenaCombo(dtAlmacenRecibe, ref cbxAlmacenRecibe, "K_Almacen", "D_Almacen", indice);
            }
        }

        private void cBoxFiltroFecha_CheckedChanged(object sender, EventArgs e)
        {
            cBoxMes.SelectedIndex = 0;
            NumericUpDwn.Value = AnioActual;
            if (cBoxFiltroFecha.Checked)
            {
                PnlFiltroFecha.Visible = true;
            }
            else
            {
                PnlFiltroFecha.Visible = false;
            }

        }

        private void cBoxFiltroOficinaEnvia_CheckedChanged(object sender, EventArgs e)
        {
            sel_OficinaEnvia.Enabled = true;
            sel_OficinaEnvia.K_Oficina = 0;
            sel_OficinaEnvia.txt_Oficina.Clear();
            if (GlobalVar.K_Oficina > 1)
            {
                sel_OficinaEnvia.K_Oficina = GlobalVar.K_Oficina;
                sel_OficinaEnvia.txt_Oficina.Text = GlobalVar.D_Oficina;
                sel_OficinaEnvia.Enabled = false;
            }
            sel_OficinaEnvia_PropertyChanged(sender, e);
            if (cBoxFiltroOficinaEnvia.Checked)
            {
                LblOficinaEnvia.Visible = true;
                sel_OficinaEnvia.Visible = true;
                LblAlmacenEnvia.Visible = true;
                cbxAlmacenEnvia.Visible = true;
            }
            else
            {
                LblOficinaEnvia.Visible = false;
                sel_OficinaEnvia.Visible = false;
                LblAlmacenEnvia.Visible = false;
                cbxAlmacenEnvia.Visible = false;
            }
        }

        private void cBoxFiltroOficinaRecibe_CheckedChanged(object sender, EventArgs e)
        {
            sel_OficinaRecibe.Enabled = true;
            sel_OficinaRecibe.K_Oficina = 0;
            sel_OficinaRecibe.txt_Oficina.Clear();
            if (GlobalVar.K_Oficina > 1)
            {
                sel_OficinaRecibe.K_Oficina = GlobalVar.K_Oficina;
                sel_OficinaRecibe.txt_Oficina.Text = GlobalVar.D_Oficina;
                sel_OficinaRecibe.Enabled = false;
            }
            sel_OficinaRecibe_PropertyChanged(sender, e);
            if (cBoxFiltroOficinaRecibe.Checked)
            {
                LblOficinaRecibe.Visible = true;
                sel_OficinaRecibe.Visible = true;
                LblAlmacenRecibe.Visible = true;
                cbxAlmacenRecibe.Visible = true;
            }
            else
            {
                LblOficinaRecibe.Visible = false;
                sel_OficinaRecibe.Visible = false;
                LblAlmacenRecibe.Visible = false;
                cbxAlmacenRecibe.Visible = false;
            }
        }

        private void txtConsecutivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("SOLO SE PERMITEN DIGITAR NUMEROS", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtConsecutivo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            fx.ValidaSeaNumero(ref e);
        }
    }
}
