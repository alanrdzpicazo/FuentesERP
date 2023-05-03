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
    public partial class Frm_Aplicar_Transferencia_Seleccion : FormaBase
    {

        int K_ArticulofilaSeleccionada = 0;
        int CantidadSolicitada;
        String D_ArticuloSeleccionado = string.Empty;
        int filaSeleccionada;

        int res = 0;
        public Int32 PK_Solicitud_Transferencia{ get; set; }
        public Int32 PK_Oficina_Solicita { get; set; }
        public String PD_Oficina_Solicita { get; set; }
        public Int32 PK_Almacen_Solicita { get; set; }
        public String PD_Almacen_Solicita { get; set; }
        public String PUsuario_Solicita { get; set; }
        public DateTime PF_Solicitud { get; set; }
        public Int32 PK_Almacen { get; set; }
        SQLAlmacen sql_almacen = new SQLAlmacen();

        DataTable dtSolicitados = new DataTable();
        DataTable dtInventario = new DataTable();
      
        public Frm_Aplicar_Transferencia_Seleccion()
        {
            InitializeComponent();
            
        }

        private void Frm_Aplicar_Transferencia_Seleccion_Load(object sender, EventArgs e)
        {
           
        }

        public override void BaseMetodoInicio()
        {
            BaseBotonNuevo.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonExcel.Enabled = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonModificar.Visible = false;
            BaseBotonModificar.Enabled = false;
            BaseBotonGuardar.Visible = true;
            BaseBotonGuardar.Enabled = true;
            BaseBotonBuscar.Visible = false;
            BaseBotonBuscar.Enabled = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonCancelar.Enabled = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonAfectar.Enabled = false;
            BaseBotonReporte.Visible = false;
            BaseBotonReporte.Enabled = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonNuevo.Visible = false;
            grdInventario.AutoGenerateColumns = false;
            grdSolicitados.AutoGenerateColumns = false;      
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaBase));
            this.Text = "Solicitud de Transferencia por Autorizar de la Oficina [" + PD_Oficina_Solicita + "]";
            txtSolicitud.Text = PK_Solicitud_Transferencia.ToString();
            txtClaveOficina.Text = PK_Oficina_Solicita.ToString();
            txtOficinaSolicita.Text = PD_Oficina_Solicita.ToString();
            txtClaveAlmacen.Text = PK_Almacen_Solicita.ToString();
            txtAlmacenSolicita.Text = PD_Almacen_Solicita;
            txtUsuario.Text = PUsuario_Solicita;
            dtpFecha.Value = PF_Solicitud;
            Mtd_Carga_Solicitados();
            Mtd_Carga_Inventario();

            //grdSolicitados.CurrentCell.Selected = false;
            grdSolicitados.MultiSelect = false;
            grdSolicitados.ReadOnly = true;
            grdSolicitados.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            grdSolicitados.BackgroundColor = Color.White;
            grdSolicitados.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 70, 209);
            grdSolicitados.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grdSolicitados.EnableHeadersVisualStyles = false;

            //grdInventario.CurrentCell.Selected = false;
            grdInventario.MultiSelect = false;
            grdInventario.ReadOnly = false;
            grdInventario.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            grdInventario.BackgroundColor = Color.White;
            grdInventario.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 70, 209);
            grdInventario.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grdInventario.EnableHeadersVisualStyles = false;

            //dtAutorizados = TDetalles;
        }

        void Mtd_Carga_Solicitados()
        {
            grdSolicitados.AutoGenerateColumns = false;
            dtSolicitados = sql_almacen.Sk_Solicitud_Articulos(
         PK_Solicitud_Transferencia
                );

            grdSolicitados.DataSource = dtSolicitados;

            grdSolicitados.EditMode = DataGridViewEditMode.EditOnEnter;

            grdSolicitados.MultiSelect = false;
        }

        void Mtd_Carga_Inventario()
        {
            grdInventario.AutoGenerateColumns = false;
            dtInventario = sql_almacen.Gp_Solicitud_Inventario(
                GlobalVar.K_Oficina,
                PK_Almacen,
         PK_Solicitud_Transferencia
                );

            grdInventario.DataSource = dtInventario;

            foreach (DataGridViewRow row in grdInventario.Rows)
            {
                row.Cells["Cantidad_Autorizada"].Value = "0";
            }

        }

        private void SeleccionarRegistro(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                filaSeleccionada = e.RowIndex;
            }
            catch (Exception)
            {

                MessageBox.Show("Favor de seleccionar una celda válida...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
            if(filaSeleccionada == -1)
            {
                MessageBox.Show("Favor de seleccionar una celda válida...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            K_ArticulofilaSeleccionada= Convert.ToInt32(grdSolicitados.Rows[filaSeleccionada].Cells["K_Articulo1"].Value.ToString());
            D_ArticuloSeleccionado = grdSolicitados.Rows[filaSeleccionada].Cells["D_Articulo1"].Value.ToString();
            CantidadSolicitada = Convert.ToInt32(grdSolicitados.Rows[filaSeleccionada].Cells["Cantidad_Solicitada1"].Value.ToString());

            foreach (DataGridViewRow row in grdInventario.Rows)
            {
                int fila = int.Parse(row.Index.ToString());
                if (Convert.ToInt32(row.Cells["K_Articulo"].Value.ToString()) == K_ArticulofilaSeleccionada)
                {        
                    grdInventario.Rows[fila].DefaultCellStyle.BackColor = Color.LightGreen;
             
                }
                else
                {

                    grdInventario.Rows[fila].DefaultCellStyle.BackColor = Color.White;
                }
            }

        }

        public override void BaseBotonGuardarClick()
        {
            Int32 Consecutivo = 0;
            string msg = string.Empty;
            res = 0;
            DataTable dtDetalle = Mtd_LLenar_Detalle_Autorizados();
            BaseBotonGuardar.Enabled = true;
            if (dtDetalle != null)
            {

                dtDetalle.Columns.Remove("D_Articulo");
                dtDetalle.Columns.Remove("D_Unidad_Medida");
                dtDetalle.Columns.Remove("SKU");
                try
                {
                    if (!BaseFuncionValidaciones())
                        return;

                   
                    res = sql_almacen.Gp_TransfiereAlmacen_Solicitud(
                        PK_Oficina_Solicita,
                        PK_Almacen_Solicita,
                        txtObservaciones.Text.Trim(),
                        dtDetalle,
                        GlobalVar.K_Usuario,
                        GlobalVar.PC_Name,
                        PK_Solicitud_Transferencia,
                        ref Consecutivo,
                        ref msg
                        );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                if (res == -1)
                {
                    BaseErrorResultado = true;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    BaseErrorResultado = false;
                    MessageBox.Show("SE REALIZO LA TRANSFERENCIA CORRECTAMENTE CON CONSECUTIVO [" + Consecutivo + "]...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        public DataTable Mtd_LLenar_Detalle_Autorizados()
        {
            DataTable dtAutorizados = new DataTable();
            dtAutorizados = TDetalles;

            int row_K_Articulo = 0;
            int row_Cantidad;
            int row_K_Movimiento_Inventario = 0;
            string row_Lote = string.Empty;
            DateTime row_F_Caducidad;

            foreach (DataGridViewRow row in this.grdInventario.Rows)
            {
           
                row_K_Articulo = int.Parse(row.Cells["K_Articulo"].Value.ToString());
                row_Cantidad = int.Parse(row.Cells["Cantidad_Autorizada"].Value.ToString());
                row_K_Movimiento_Inventario = Convert.ToInt32(row.Cells["K_Movimiento_Inventario1"].Value.ToString());
                row_Lote = row.Cells["No_Lote1"].Value.ToString();
                row_F_Caducidad = Convert.ToDateTime(row.Cells["F_Caducidad1"].Value.ToString());

                if (row_Cantidad > CantidadSolicitada)
                {
                    MessageBox.Show("La cantidad autorizada del artículo "+"["+D_ArticuloSeleccionado+"]"+" no puede ser mayor a la solicitada, verifique...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }
                if (row_Cantidad > 0)
                {
                    dtAutorizados.Rows.Add(row_K_Articulo, row_Cantidad, row_K_Movimiento_Inventario,row_Lote,row_F_Caducidad);
                }
                


            }

            return dtAutorizados;
        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;


            if (txtObservaciones.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR OBSERVACIONES.!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtObservaciones.Focus();
                return false;
            }
          
            BaseErrorResultado = false;
            return true;
        }


    }
}
