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
using ProbeMedic.REPORTES;
namespace ProbeMedic.INVENTARIOS
{
    public partial class FRM_TRANSFERENCIAS_ALMACEN : FormaBase
    {
        // BaseBotonProceso1: Aplicar
        // BaseBotonProceso2: Rechazar
        // BaseBotonProceso3: Cancelar
        // BaseBotonProceso4: Nueva Solicitud

        SQLCatalogos sqlCatalogo = new SQLCatalogos();
        SQLAlmacen sqlAlmacen = new SQLAlmacen();
        DataTable dtAlmacen = new DataTable();
        DataTable dtSolicitudes= new DataTable();
        Funciones fx = new Funciones();
        Int32 K_Oficina = 0;

        SQLAlmacen sql_almacen = new SQLAlmacen();

        DateTime F_Solicitud_Inicial = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        DateTime F_Solicitud_Final = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year,DateTime.Now.Month));

        int filaSeleccionada;

        public FRM_TRANSFERENCIAS_ALMACEN()
        {
            InitializeComponent();
            Shown += new EventHandler(Principal_Shown);

            if (cBoxFiltroFecha.CanFocus)
                cBoxFiltroFecha.Focus();
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
            cBoxFiltroFecha.Checked = false;
            cBoxFiltroFecha_CheckedChanged(sender, e);

            K_Oficina = GlobalVar.K_Oficina;
            txtOficinaSolicita.Text = GlobalVar.D_Oficina;

            MtdCargaAlmacen();

            grdDatos.AutoGenerateColumns = false;

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaBase));
            BaseBotonProceso1.Image = ((System.Drawing.Image)(imageList1.Images["BtnRealizado.Image.png"]));
            BaseBotonProceso1.Text = "Aplicar";
            BaseBotonProceso1.Visible = false;

            BaseBotonProceso2.Image = ((System.Drawing.Image)(imageList1.Images["BtnCancelar.Image.png"]));
            BaseBotonProceso2.Text = "Rechazar";
            BaseBotonProceso2.Visible = false;

            BaseBotonProceso3.Image = ((System.Drawing.Image)(imageList1.Images["if_to-do-list_checked3_15154.png"]));
            BaseBotonProceso3.Text = "Consultar";
            BaseBotonProceso3.Visible = false;

            BaseBotonProceso4.Image = ((System.Drawing.Image)(imageList1.Images["New_icon-icons.com_73694.ico"]));
            BaseBotonProceso4.Text = "Nueva Solicitud";
            BaseBotonProceso4.Width = 100;
            BaseBotonProceso4.Visible = true;


            //DateTime Dia_Actual = new DateTime(DateTime.Today.Day);
            //int dia = Convert.ToInt32(Dia_Actual);
            int dia = DateTime.Now.Day;
            DateTime d = new DateTime(2013, 4,dia);// año mes dia

            dtpInicial.Value = d;


        }

        private void sel_Oficina_PropertyChanged(object sender, EventArgs e)
        {
            if (K_Oficina > 0)
            {
                MtdCargaAlmacen();
            }
            else
            {
                if (K_Oficina == 0)
                {
                    if (dtAlmacen != null)
                        dtAlmacen.Rows.Clear();
                }
            }
        }

        private void cBoxFiltroFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxFiltroFecha.Checked)
            {
                PnlFiltroFecha.Visible = true;
            }
            else
            {
                PnlFiltroFecha.Visible = false;
            }

        }

        void MtdCargaAlmacen()
        {

            //dtAlmacen.Rows.Clear();
            cbxAlmacen.DataSource = null;
            cbxAlmacen.Items.Clear();
            cbxAlmacen.AutoCompleteSource = AutoCompleteSource.None;
            cbxAlmacen.AutoCompleteMode = AutoCompleteMode.None;

            if (K_Oficina == 0)
            {
                dtAlmacen.Rows.Clear();
            }
            else
            {
                dtAlmacen = sqlCatalogo.Sk_Almacenes_x_Usuario(GlobalVar.K_Usuario,GlobalVar.K_Oficina,GlobalVar.K_Empresa);
            }

            if (dtAlmacen != null)
            {
                DataRow dr = dtAlmacen.NewRow();

                dr["K_Almacen"] = 0;
                dr["K_Usuario"] = 0;
                dr["D_Usuario"] = "";
                dr["K_Oficina"] = 0;
                dr["D_Oficina"] = "";
                dr["D_Almacen"] = "[Selecccionar]";
                dr["B_AceptaDevolucionesCliente"] = false;

                dtAlmacen.Rows.InsertAt(dr, 0);

                dtAlmacen.AcceptChanges();

                int indice = -1;
                indice = 0;
                LlenaCombo(dtAlmacen, ref cbxAlmacen, "K_Almacen", "D_Almacen", indice);

                cbxAlmacen.SelectedIndex = 1;
            }


        }

        public override void BaseBotonBuscarClick()
        {
            if(Convert.ToInt32(cbxAlmacen.SelectedValue) == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN ALMACEN", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxAlmacen.Focus();
            }

            #region ValidacionFiltroFecha
            if (cBoxFiltroFecha.Checked)
            {
                grdDatos.AutoGenerateColumns = false;
                dtSolicitudes = sqlAlmacen.Sk_Solicitud_Transferencia(
                    K_Oficina,
                    Convert.ToInt32(cbxAlmacen.SelectedValue),
                    dtpInicial.Value,
                    dtpFinal.Value
                    );

                grdDatos.DataSource =dtSolicitudes;

            }

            else
            {
                grdDatos.AutoGenerateColumns = false;
                dtSolicitudes = sqlAlmacen.Sk_Solicitud_Transferencia(
                    K_Oficina,
                    Convert.ToInt32(cbxAlmacen.SelectedValue),
                    F_Solicitud_Inicial,
                    F_Solicitud_Final
                    );

                grdDatos.DataSource = dtSolicitudes;
            }

            #endregion ValidacionFiltroFecha

            if (dtSolicitudes != null)
            {
                if (dtSolicitudes.Rows.Count > 0)
                {
                    grdDatos.AutoGenerateColumns = false;
                    grdDatos.DataSource = dtSolicitudes;
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
                    BaseBotonProceso1.Visible = true;
                    BaseBotonProceso2.Visible = true;
                    BaseBotonProceso3.Visible = true;                 
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
                    if (dtSolicitudes!= null)
                    {
                        if (dtSolicitudes.Rows.Count > 0)
                        {
                            dtSolicitudes.Clear();
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

                    BaseBotonProceso1.Visible = false;
                    BaseBotonProceso2.Visible = false;
                    BaseBotonProceso3.Visible = false;
                }
            }
            else
            {
                BaseBotonCancelar.Visible = true;
                BaseBotonCancelar.Enabled = true;
            }
        }

        //Aplicar
        public override void BaseBotonProceso1Click()
        {
            if (Convert.ToBoolean(grdDatos.CurrentRow.Cells["B_Rechazada"].Value) == true)
            {
                MessageBox.Show("LA TRANSFERENCIA ESTA RECHAZADA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (Convert.ToBoolean(grdDatos.CurrentRow.Cells["B_Aplicada"].Value) == true)
            {
                MessageBox.Show("LA TRANSFERENCIA ESTA APLICADA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (grdDatos.DataSource != null)
            {

                Frm_Aplicar_Transferencia_Seleccion frm = new Frm_Aplicar_Transferencia_Seleccion();
                frm.PK_Solicitud_Transferencia = Convert.ToInt32(grdDatos.Rows[filaSeleccionada].Cells["K_Solicitud_Transferencia"].Value.ToString());
                frm.PK_Almacen = Convert.ToInt32(cbxAlmacen.SelectedValue);
                frm.PK_Oficina_Solicita = Convert.ToInt32(grdDatos.Rows[filaSeleccionada].Cells["K_Oficina_Solicita"].Value.ToString());
                frm.PD_Oficina_Solicita = grdDatos.Rows[filaSeleccionada].Cells["D_Oficina_Solicita"].Value.ToString();
                frm.PK_Almacen_Solicita = Convert.ToInt32(grdDatos.Rows[filaSeleccionada].Cells["K_Almacen_Solicita"].Value.ToString());
                frm.PD_Almacen_Solicita = grdDatos.Rows[filaSeleccionada].Cells["D_Almacen_Solicita"].Value.ToString();
                frm.PUsuario_Solicita = grdDatos.Rows[filaSeleccionada].Cells["Usuario_Solicito"].Value.ToString();
                frm.PF_Solicitud= Convert.ToDateTime(grdDatos.Rows[filaSeleccionada].Cells["F_Solicitud"].Value.ToString());
                frm.ShowDialog();
                BaseBotonBuscarClick();
               
            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR UNA SOLICITUD...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        //Nueva Solicitud
        public override void BaseBotonProceso4Click()
        {
            Frm_Generar_Solicitud_Transferencia frm = new Frm_Generar_Solicitud_Transferencia();
            frm.ShowDialog();
            BaseBotonBuscarClick();
        }

        public override void BaseBotonProceso3Click()
        {
            Frm_Consulta_Solicitud Frm = new Frm_Consulta_Solicitud();

            Frm.K_Solicitud = Convert.ToInt32(grdDatos.Rows[filaSeleccionada].Cells["K_Solicitud_Transferencia"].Value.ToString()); ;
            Frm.ShowDialog();

        }

        private void SeleccionarRegistro(object sender, DataGridViewCellMouseEventArgs e)
        {
            filaSeleccionada = e.RowIndex;
        }

        public override void BaseBotonProceso2Click()
        {
            if (Convert.ToBoolean(grdDatos.CurrentRow.Cells["B_Rechazada"].Value) == true)
            {
                MessageBox.Show("LA TRANSFERENCIA ESTA RECHAZADA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (Convert.ToBoolean(grdDatos.CurrentRow.Cells["B_Aplicada"].Value) == true)
            {
                MessageBox.Show("LA TRANSFERENCIA ESTA APLICADA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Frm_Cancela_Solicitud Frm = new Frm_Cancela_Solicitud();

            Frm.K_Solicitud = Convert.ToInt32(grdDatos.Rows[filaSeleccionada].Cells["K_Solicitud_Transferencia"].Value.ToString());
            Frm.ShowDialog();
            BaseBotonBuscarClick();

        }

        
    }
}
