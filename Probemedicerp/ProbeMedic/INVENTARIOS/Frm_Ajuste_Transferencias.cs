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
    public partial class Frm_Ajuste_Transferencias : FormaBase
    {
        DataTable dtArticulos = new DataTable();

        public int Int_K_Oficina_Envio = 0;
        public int Int_K_Almacen_Envio = 0;

        int int_K_Oficina = 0;
        int int_k_Almacen = 0;

        public string Str_Oficina = "";
        public string Str_Almacen = "";

        DataTable dtTransferencia;
        public DataTable dtResultado;
        public DataTable dtTransferidos;
        public DataTable dtValida;
        DataTable dtResultadoDetalle = new DataTable();

        public DataTable _dtRecibe = new DataTable();

        SQLAlmacen sqlAlmacen = new SQLAlmacen();
        SQLRecepcion sQLRecepcion = new SQLRecepcion();
        Funciones fx = new Funciones();
        public Frm_Ajuste_Transferencias()
        {
            BaseGridSinFormato = true;
            InitializeComponent();
        }

        public override void BaseMetodoInicio()
        {
            BaseBotonNuevo.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonAfectar.Visible = false;

            BaseBotonExcel.Visible = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonProceso1.Visible = true;
            txtOficinaEnvio.Text = Str_Oficina;
            txtAlmacenEnvio.Text = Str_Almacen;

            BaseBotonReporte.Visible = false;

            grdDetalle.AutoGenerateColumns = false;


            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaBase));
            //BaseBotonProceso1.Image = ((System.Drawing.Image)(imageList1.Images["disk.png"]));
            BaseBotonProceso1.Text = "Guardar";
            BaseBotonBuscar.Width = 100;

            BuscaAlmacenes(true);

            BaseBotonBuscar.Text = "Busca Articulos";

            this.WindowState = FormWindowState.Normal;

        }

        private void BuscaAlmacenes(bool ComboEnvio)
        {
            int K_AlmacenEnvia = 0;
            if (CbxAlmacenEnvio.Items.Count > 0)
            {
                K_AlmacenEnvia = Convert.ToInt32(CbxAlmacenEnvio.SelectedIndex.ToString());
            }

            DataTable _dt = sqlCatalogos.Sk_Almacenes(GlobalVar.K_Oficina);
            LlenaCombo(_dt, ref CbxAlmacenEnvio, "K_Almacen", "D_Almacen", 0);

            txtOficinaEnvio.Text = GlobalVar.D_Oficina;

        }

        public override void BaseBotonBuscarClick()
        {

            Frm_Ajuste_Transferencia_Seleccion Frm = new Frm_Ajuste_Transferencia_Seleccion();

            Int_K_Almacen_Envio = Convert.ToInt32(CbxAlmacenEnvio.SelectedValue);

            Str_Almacen = CbxAlmacenEnvio.Text;
            Str_Oficina = GlobalVar.D_Oficina;

            Frm.K_Almacen = Int_K_Almacen_Envio;
            Frm.K_Oficina = GlobalVar.K_Oficina;

            Frm.Str_Almacen = Str_Almacen;
            Frm.Str_Oficina = Str_Oficina;

            Frm.dtTransferidos = dtTransferencia;
            Frm.ShowDialog();
            if (Frm.dtResultado != null)
            {
                if (dtTransferencia == null)
                {
                    dtTransferencia = Frm.dtResultado.Clone();
                }
                dtTransferencia.Merge(Frm.dtResultado);
                grdDetalle.DataSource = dtTransferencia;
            }
        }

        private void txtOficinaEnvio_TextChanged(object sender, EventArgs e)
        {

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
                int_K_Oficina = Convert.ToInt16(frm.BusquedaPropiedadReglonRes["K_Oficina"]);
                txtClaveOficina.Text = Convert.ToString(frm.BusquedaPropiedadReglonRes["K_Oficina"]);
                txtOficina.Text = frm.BusquedaPropiedadReglonRes["D_Oficina"].ToString();
          

                _dtRecibe = sqlCatalogos.Sk_Almacenes(int_K_Oficina);
                LlenaCombo(_dtRecibe, ref CbxAlmacenRecibe, "K_Almacen", "D_Almacen", 0);

            }
        }

        private void LlenaAlmacenRecibe()
        {
            if (int_K_Oficina > 0)
            {
                BuscaAlmacenes(true);
                if (CbxAlmacenRecibe.Items.Count > 0)
                {
                    CbxAlmacenRecibe.SelectedIndex = 0;
                    int_k_Almacen = Convert.ToInt32(CbxAlmacenRecibe.SelectedValue.ToString());
                }
                else
                {
                    int_k_Almacen = 0;
                }
            }
            else
            {
                int_k_Almacen = 0;
                CbxAlmacenRecibe.DataSource = null;
                CbxAlmacenRecibe.DisplayMember = null;
                CbxAlmacenRecibe.ValueMember = null;
                //CbxAlmacenRecibe.Items.Clear();
            }
        }

        private void txtClaveOficina_Leave(object sender, EventArgs e)
        {
            int_K_Oficina = 0;
            BuscaEnTablaClaveDescripcion(GlobalVar.dtOficinas, "K_Oficina", "D_Oficina", ref txtClaveOficina, ref txtOficina);
            int_K_Oficina = (txtClaveOficina.Text == "") ? 0 : Convert.ToInt32(txtClaveOficina.Text);
            LlenaAlmacenRecibe();
        }

        private void grdDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow row = grdDetalle.CurrentRow;
                if (row != null)
                {
                    int K_Movimiento_Inventario = Convert.ToInt32(row.Cells["K_Movimiento_Inventario"].Value);

                    DataRow ren = dtTransferencia.AsEnumerable().Where(p => p.Field<int>("K_Movimiento_Inventario") == K_Movimiento_Inventario).FirstOrDefault();
                    if (ren != null)
                        dtTransferencia.Rows.Remove(ren);



                }
            }
        }

        private void CbxAlmacenRecibe_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int_k_Almacen = Convert.ToInt32(CbxAlmacenRecibe.SelectedValue.ToString());
            }
            catch (Exception exe)
            {

            }
        }

        public override void BaseBotonProceso1Click()
        {

            if (int_K_Oficina == 0)
            {
                MessageBox.Show("Seleccione una Oficina para el Envío", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (int_k_Almacen == Int_K_Almacen_Envio)
            {
                MessageBox.Show("El almacen de envio no puede ser el mismo que el almacen de recepción.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (grdDetalle.Rows.Count == 0)
            {
                MessageBox.Show("Seleccione los Artículos para el Envío", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtObservaciones.Text.Trim().Length == 0)
            {
                MessageBox.Show("Capture las Observaciones", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int res = 0;
            string StrMensaje = "";

            DataTable dtDetalles;
            dtDetalles = Generico_Type;

            String mensaje = string.Empty;


            foreach (DataRow row in dtTransferencia.Rows)
            {
                DataRow dr;
                dr = dtDetalles.NewRow();


                if(row["F_Caducidad"].ToString() == "")
                {
                    mensaje = "El Artículo [" + row["K_Articulo"] + "][" + row["D_Articulo"] + "] con LOTE [" + row["No_Lote"] + "] no tiene fecha de caducidad. \n\n";
                    MsgBox msgbox = new MsgBox();
                    msgbox.Show(mensaje, "ERROR");
                    return;
                }

                DateTime F_Actual = DateTime.Now;
                DateTime F_Caducidad = Convert.ToDateTime(row["F_Caducidad"].ToString());

                TimeSpan ts = F_Caducidad - F_Actual;

                int Diferencia_Dias = ts.Days;

                //if ((Diferencia_Dias <= 30) && (Diferencia_Dias>=0))
                //{
                //    mensaje = "El Artículo [" + row["K_Articulo"] + "][" + row["D_Articulo"] + "] con LOTE [" + row["No_Lote"] + "] tiene una fecha de caducidad menor a 30 días. \n\n";
                //    MsgBox msgbox = new MsgBox();
                //    msgbox.Show(mensaje, "ERROR");
                //    return;             
                //}

                if (Diferencia_Dias<0)
                {
                    mensaje = "El Artículo [" + row["K_Articulo"] + "][" + row["D_Articulo"] + "] con LOTE [" + row["No_Lote"] + "] ya esta caducado, \r\n" +
                        "¿Está seguro(a) de transferirlo?";
                    DialogResult result = MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if(result == DialogResult.Yes)
                    {
                        dr["Campo1"] = row["K_Movimiento_Inventario"];
                        dr["Campo2"] = row["Cantidad_Transferir"];

                        dtDetalles.Rows.Add(dr);
                        //int PuntoReOrden = 0;
                        //dtValida = sQLRecepcion.Gp_Valida_PuntoReOrden(Convert.ToInt32(row["K_Articulo"]), PuntoReOrden, Convert.ToInt32(row["Cantidad_Transferir"]));

                        //DataRow rows = dtValida.Rows[0];

                        //PuntoReOrden = Convert.ToInt32(rows["Punto_ReOrden"].ToString());

                        //if (PuntoReOrden < 0)
                        //{
                        //    MsgBox msgbox = new MsgBox();
                        //    msgbox.Show("LA CANTIDAD DE ARTICULOS NO ESTA DISPONIBLE EN EL INVENTARIO", "ERROR");
                        //    return;
                        //}
                        //if (mensaje != "")
                        //{
                        //    MsgBox msgbox = new MsgBox();
                        //    msgbox.Show(mensaje.ToString().ToUpper(), "Aviso");
                        //}
                 
                    }         
                }
                else
                {
                    dr["Campo1"] = row["K_Movimiento_Inventario"];
                    dr["Campo2"] = row["Cantidad_Transferir"];

                    dtDetalles.Rows.Add(dr);
                    //int PuntoReOrden = 0;
                    //dtValida = sQLRecepcion.Gp_Valida_PuntoReOrden(Convert.ToInt32(row["K_Articulo"]), PuntoReOrden, Convert.ToInt32(row["Cantidad_Transferir"]));

                    //DataRow rows = dtValida.Rows[0];

                    //PuntoReOrden = Convert.ToInt32(rows["Punto_ReOrden"].ToString());

                    //if (PuntoReOrden < 0)
                    //{
                    //    MsgBox msgbox = new MsgBox();
                    //    msgbox.Show("LA CANTIDAD DE ARTICULOS NO ESTA DISPONIBLE EN EL INVENTARIO", "ERROR");
                    //    return;
                    //}
                    //if (mensaje != "")
                    //{
                    //    MsgBox msgbox = new MsgBox();
                    //    msgbox.Show(mensaje.ToString().ToUpper(), "Aviso");
                    //}
                }

            }

            int Consecutivo = 0;

            res = sqlAlmacen.Gp_TransfiereAlmacen(int_K_Oficina, int_k_Almacen, txtObservaciones.Text, dtDetalles, GlobalVar.K_Usuario, GlobalVar.PC_Name, ref StrMensaje, ref Consecutivo);

            if (res == 0)
            {
                MessageBox.Show("Transferencia Guardada Correctamente" + System.Environment.NewLine +
                                "Consecutivo No.  " + Consecutivo.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cursor = Cursors.WaitCursor;
                Reporte(Consecutivo);
                Cursor = Cursors.Default;
                Limpiar();
                BaseMetodoInicio();
            }
            else
            {
                MessageBox.Show(StrMensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Limpiar()
        {
            txtObservaciones.Text = "";
            txtOficina.Text = "";
            txtClaveOficina.Text = "";
            Int_K_Oficina_Envio = 0;
            int_k_Almacen = 0;
            _dtRecibe.Rows.Clear();
            dtTransferencia = null;
            grdDetalle.DataSource = null;

        }

        private void txtAlmacenEnvio_TextChanged(object sender, EventArgs e)
        {

        }

        void Reporte(Int32 Consecutivo, Boolean B_Reporte = false)
        {
            DataTable dtResultado = new DataTable();
            dtResultado = sqlAlmacen.Sk_Transferencia_Almacen(Consecutivo,B_Reporte);
            BaseErrorResultado = false;
            if (dtResultado != null)
            {
                ReportDocument rpt = new ProbeMedic.INVENTARIOS.RPT_Comprobante_Traspaso();
                ReporteTitulo = "Traspaso de Artículos";
                ReporteModulo = "INVENTARIOS";
                ConectaReporte(ref rpt, dtResultado, ReporteTitulo, ReporteModulo, "", true);
                ReporteRPT = rpt;

                Frm_Reportes frmReporte = new Frm_Reportes();
                frmReporte.P_Titulo = ReporteTitulo;
                frmReporte.P_ReporteRPT = ReporteRPT;
                frmReporte.P_TablaCorreo = ReportedtCorreo;
                frmReporte.ShowDialog();
            }
        }
    }
}