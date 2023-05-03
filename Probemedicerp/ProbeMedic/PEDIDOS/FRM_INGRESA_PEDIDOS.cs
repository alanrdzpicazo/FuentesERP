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
using ProbeMedic.CATALOGOS.PACIENTES;
using ProbeMedic.FILTROS;
namespace ProbeMedic.PEDIDOS
{
    public partial class FRM_INGRESA_PEDIDOS : FormaBase
    {
        int res;
        SQLCatalogos sqlCatalogo = new SQLCatalogos();
        SQLAlmacen sqlAlmacen = new SQLAlmacen();
        SQLRecepcion sQLRecepcion = new SQLRecepcion();
        SQLPedidos sqlPedidos = new SQLPedidos();

        DataTable dtArticulos = new DataTable();
        DataTable dtEncabezado = new DataTable();
        DataTable dtAlmacen = new DataTable();
        DataTable dtAseguradora = new DataTable();
        DataTable dtCelulas = new DataTable();
        DataTable dtValida = new DataTable();
        DataTable dtEmpresaEntrega = new DataTable();
        DataTable dtTipoEntrega = new DataTable();
        DataTable dtPacientes = new DataTable();
        DataTable dtFechasPedido = new DataTable();
        DataTable dtDatosArticulos = new DataTable();
        DataTable dtInventario = new DataTable();
        DataTable dtPagos = new DataTable();

        public bool B_NoEntrar = false;

        Funciones fx = new Funciones();

        List<Modelos.PedidosFechas> lstFechas = new List<Modelos.PedidosFechas>();

        SQLVentas sql_ventas = new SQLVentas();

        private Int32 K_Oficina { get; set; }
        public Int32 K_CotizacionInt { get; set; }
        public Int32 K_PacienteInt { get; set; }
        private Int32 K_AseguradoraInt { get; set; }
        private Int32 K_PacienteDireccionInt { get; set; }
        private Int32 K_MedicoInt { get; set; }
        private Int32 K_Paciente_TelefonoInt { get; set; }
        private Int32 K_MedicoDic { get; set; }
        private Int32 K_ClienteInt { get; set; }
        private Int32 K_Cliente_Domicilio_Fiscal;
        public FRM_INGRESA_PEDIDOS()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            LblOficinaAlmacen.Text = GlobalVar.D_Oficina;
            LblUsuario.Text = GlobalVar.D_Usuario;
            grdDetalle.MultiSelect = false;
            grdDetalle.ReadOnly = true;
            grdDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            grdDetalle.BackgroundColor = Color.White;
            grdDetalle.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 70, 209);
            grdDetalle.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grdDetalle.EnableHeadersVisualStyles = false;

            BaseBotonProceso1.Image = ((System.Drawing.Image)(imageList1.Images["if_icon-111-search_314689.png"]));
            BaseBotonProceso1.Text = "Cotizaciones";
            BaseBotonProceso1.Visible = true;
            BaseBotonProceso1.Enabled = true;
            BaseBotonProceso1.Text = "Cotizaciones";
            BaseBotonProceso1.ToolTipText = "Consulta Cotizaciones..";

            BaseBotonProceso2.Image = ((System.Drawing.Image)(imageList1.Images["btnGuardar.Image.png"]));
            BaseBotonProceso2.Text = "Guardar";
            BaseBotonProceso2.Visible = true;
            BaseBotonProceso2.Enabled = true;
            BaseBotonProceso2.Text = "Guardar";
            BaseBotonProceso2.ToolTipText = "Guardando Información..";

            BaseBotonNuevo.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonExcel.Enabled = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonModificar.Visible = false;
            BaseBotonModificar.Enabled = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonGuardar.Enabled = false;
            BaseBotonBuscar.Text = "Cotizaciones";
            BaseBotonBuscar.Text = "Consulta de Cotizaciones";
            BaseBotonBuscar.Visible = false;
            BaseBotonBuscar.Enabled = false;
            BaseBotonBuscar.Width = 140;
            BaseBotonCancelar.Visible = true;
            BaseBotonCancelar.Enabled = true;
            BaseBotonBorrar.Visible = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonAfectar.Enabled = false;
            BaseBotonReporte.Visible = false;
            BaseBotonReporte.Enabled = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonCancelar.Text = "Limpiar";
            BaseBotonCancelar.ToolTipText = "Limpiar Datos Capturados en Pantalla";

            dtArticulos = PedidosDetalle_Type;

            grdDetalle.AutoGenerateColumns = false;
            rdbPct.Checked = true;

            MtdCargaOficinaInicial();
            MtdCargaAlmacen();
            MtdCargaTipo_Entrega();
            //this.WindowState = FormWindowState.Maximized;
        }
        public override void BaseBotonProceso1Click()
        {
            VENTAS.Frm_Cotizaciones_Capturadas frm = new VENTAS.Frm_Cotizaciones_Capturadas();
            frm.B_DesdePedidos = true;
            frm.ShowDialog();
            
            txtCotizacion.Text = Convert.ToString(frm.K_CotizacionPasa);
            if (txtCotizacion.Text.Trim().Length > 0 && Convert.ToInt32(txtCotizacion.Text) >0 )
            {
                txtClavePaciente.Text = Convert.ToString(frm.K_PacientePasa);
                txtPaciente.Text = frm.D_PacientePasa;
                MtdCargarPacientes();
            }
        }
        public override void BaseBotonProceso2Click()
        {
            if (FuncionValidaciones())
            {
                Int32 CampoIdentity = 0;
                Int32 CotizacionIdentity = 0;
                string msg = string.Empty;

                DataTable dtDetalle = dtArticulos.Copy();
                dtDetalle.Columns.Remove("D_Articulo");
                dtDetalle.Columns.Remove("D_Tipo_Producto");
                dtDetalle.Columns.Remove("D_Unidad_Medida");
                dtDetalle.Columns.Remove("K_Familia_Articulo");
                dtDetalle.Columns.Remove("D_Familia");
                dtDetalle.Columns.Remove("K_Sustancia_Activa");
                dtDetalle.Columns.Remove("D_Sustancia_Activa");
                dtDetalle.Columns.Remove("K_Laboratorio");
                dtDetalle.Columns.Remove("D_Laboratorio");
                dtDetalle.Columns["K_Articulo"].SetOrdinal(0);
                dtDetalle.Columns["Cantidad"].SetOrdinal(1);
                dtDetalle.Columns["SKU"].SetOrdinal(2);
                dtDetalle.Columns["K_Tipo_Producto"].SetOrdinal(3);
                dtDetalle.Columns["K_Unidad_Medida"].SetOrdinal(4);
                dtDetalle.Columns["Precio_Unitario"].SetOrdinal(5);
                dtDetalle.Columns["PorcentajeDescuento"].SetOrdinal(6);
                dtDetalle.Columns["Descuento"].SetOrdinal(7);
                dtDetalle.Columns["Subtotal"].SetOrdinal(8);
                dtDetalle.Columns["Tasa_IVA"].SetOrdinal(9);
                dtDetalle.Columns["Total_IVA"].SetOrdinal(10);
                dtDetalle.Columns["Total_Detalle"].SetOrdinal(11);

                dtDetalle.AcceptChanges();
                String errores = String.Empty;
                foreach (Modelos.PedidosFechas item in lstFechas)
                {
                    if (item.B_Programado == false)
                    {
                        res = 0;
                        res = sqlPedidos.In_Pedidos(
                              ref CampoIdentity, K_CotizacionInt, "", K_Oficina, Convert.ToInt32(cbxAlmacen.SelectedValue), Convert.ToInt32(txtClavePaciente.Text.Trim()),
                              K_PacienteDireccionInt, K_MedicoInt, Convert.ToInt32(cbxCelula.SelectedValue), K_AseguradoraInt, 2, //PEDIDO REGISTRADO
                              Convert.ToDateTime(item.F_Entrega), K_ClienteInt, K_Cliente_Domicilio_Fiscal, Convert.ToDecimal(txtPorcentajeDescuento.Text),
                              Convert.ToDecimal(txtDescuento.Text), Convert.ToDecimal(txtSubtotal.Text), Convert.ToDecimal(txtTasaIVA.Text), Convert.ToDecimal(txtTotalIVA.Text),
                              Convert.ToDecimal(txtTotalPedido.Text), 1, 1, GlobalVar.K_Usuario, dtDetalle, GlobalVar.PC_Name, false, //B_PedidoCero
                              Convert.ToInt32(cbxTipo_Entrega.SelectedValue), Convert.ToInt32(cbxEmpresa.SelectedValue), txtNoGuia.Text.Trim(),
                              Convert.ToDateTime(item.H_Entrega), txtNota.Text.Trim(), item.B_Parcial, cbxQuimioterapia.Checked, item.B_Programado,
                              K_Paciente_TelefonoInt, item.Reclamacion_Pedido, Convert.ToInt32(txtK_Asesor.Text), item.Carta_Pedido, item.Monto_Carta, item.Siniestro_Pedido,
                              item.Reclamacion_Pedido, item.Coaseguro_Pedido, item.Coaseguro_Pedido, item.Poliza_Pedido, item.B_ConCoaseguro, 1, item.PacienteCartaPedido,
                              item.Siniestro_Pedido, item.Carta_Pedido, item.B_CoaCobReq, Convert.ToInt32(cbxCelula.SelectedValue),true, ref msg);

                        if (res == -1)
                        {
                            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            BaseErrorResultado = false;
                            return;

                        }
                    }
                    else
                    {
                        res = sqlPedidos.In_Cotizacion(ref CotizacionIdentity, K_ClienteInt, Convert.ToInt32(txtClavePaciente.Text.Trim()),
                              Convert.ToDecimal(txtDescuento.Text), Convert.ToDecimal(txtSubtotal.Text), Convert.ToDecimal(txtTasaIVA.Text),
                              Convert.ToDecimal(txtTotalIVA.Text), Convert.ToDecimal(txtTotalPedido.Text), GlobalVar.K_Usuario, Convert.ToDateTime(item.F_Entrega),
                              "Credito", 1, txtNota.Text, dtDetalle, true, ref msg);

                        if (res == -1)
                        {
                            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            return;
                        }

                    }

                    if (errores != string.Empty)
                    {
                        MessageBox.Show("ALGUNAS FECHAS NO SE REALIZARON CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return;
                    }
                    else
                    {
                        MessageBox.Show("LA TRANSACCION SE REALIZO CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            

        }
        public bool FuncionValidaciones()
        {

            if (Convert.ToInt32(cbxAlmacen.SelectedValue) == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR UN ALMACEN...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxAlmacen.Focus();
                return false;
            }
           
            if (txtClavePaciente.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR PACIENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClavePaciente.Focus();
                return false;
            }
            if (K_PacienteDireccionInt == 0)
            {
                MessageBox.Show("FALTA CAPTURAR DIRECCION DEL PACIENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnDirecciones.Focus();
                return false;
            }
            if (txtK_Asesor.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR AGENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnAsesor.Focus();
                return false;
            }
            //SI ES FORANEA Y LA GUIA ESTA VACIA
            if (Convert.ToInt32(cbxTipo_Entrega.SelectedValue.ToString()) == 1 && txtNoGuia.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR NUMERO DE GUIA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoGuia.Focus();
                return false;
            }
                          
            if (grdDetalle.DataSource == null)
            {
                MessageBox.Show("FALTA AGREGAR ARTICULOS AL PEDIDO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscarArticulos.Focus();
                return false;
            }
            if ((dgvFechas.Rows.Count  == 0) || ((dgvFechas.DataSource == null)))
            {
                MessageBox.Show("FALTA AGREGAR FECHAS AL PEDIDO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public override void BaseBotonCancelarClick()
        {  
            K_Oficina = 0;  
            txtSubtotal.Text = string.Empty;
            txtTotalIVA.Text = string.Empty;
            txtDescuento.Text = string.Empty;
            txtTotalPedido.Text = string.Empty;          
            txtClavePaciente.Text = string.Empty;
            txtPaciente.Text = string.Empty;
            lblCalle.Text = "";
            LblNumeroInt.Text = "";
            LblNumeroExt.Text = "";
            lblTipoDireccion.Text = "";
            lblEntreCalles.Text = "";
            lblEdificio.Text = "";
            LblPiso.Text = "";
            lblColonia.Text = "";
            lblEstado.Text = "";
            lblPais.Text = "";
            lblLocalidad.Text = "";
            lblCP.Text = "";
            lblMunicipio.Text = "";
            K_PacienteDireccionInt = 0;
            K_PacienteInt = 0;
            this.lblGenero.Text = "";
            this.lblEstadoCivil.Text = "";
            this.lblNacionalidad.Text = "";
            this.lblRFC.Text = "";
            this.lblCURP.Text = "";
            this.lblTipoDeSangre.Text = "";
            this.lblTipoPaciente.Text = "";
            this.K_AseguradoraInt =  0;
            this.lblAseguradora.Text = "";
            this.lblCelula.Text = "";
            this.lblTipoDePoliza.Text = "";
            this.lblPoliza.Text = "";
            this.lblSiniestro.Text = "";
            this.lblReclamacion.Text = "";
            this.lblCoaseguroPorcentaje.Text = "";
            this.K_ClienteInt = 0;
            this.K_Paciente_TelefonoInt = 0;
            this.lblTipoTelefono.Text = "";
            this.lblTelefono.Text = "";
            this.LblCodigoPais.Text = "";
            this.LblLada.Text = "";
            K_MedicoInt = 0;
            this.lblMedico.Text = "";
            txtK_Asesor.Text = "";
            txtAsesor.Text = "";
            this.lblDictaminador.Text = "";
            txtNoGuia.Text = "";
            txtNota.Text = "";

            MtdCargaOficinaInicial();
            MtdCargaAlmacen();          
            Mtd_Limpia_Informacion_Articulo();
            dtArticulos = null;
            grdDetalle.DataSource = dtArticulos;
            BaseMetodoInicio();
        }
        private void btnBuscarArticulos_Click(object sender, EventArgs e)
        {
            if(txtClavePaciente.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR PACIENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FILTROS.Frm_Filtro_Articulo_Pedido frm = new FILTROS.Frm_Filtro_Articulo_Pedido();
            frm.K_Paciente = Convert.ToInt32(txtClavePaciente.Text);

            frm.dtTransferidos = dtArticulos;
            frm.ShowDialog();
            if (frm.dtResultado != null)
            {                     
                if (dtArticulos == null)
                {
                    dtArticulos = frm.dtResultado.Clone();
                }
                dtArticulos.Rows.Clear();
                dtArticulos.Merge(frm.dtResultado);
                grdDetalle.DataSource = dtArticulos;
                Mtd_Calcula_Totales();
                B_NoEntrar = true;
            }

        }
        private void grdDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdDetalle.Columns[e.ColumnIndex].Name == "Mas")
            {
                Mtd_Incrementar(sender, e);
            }
            else if(grdDetalle.Columns[e.ColumnIndex].Name == "Menos")
            {
                Mtd_Disminuir(sender, e);
            }
        }
        #region FUNCIONES
        void MtdCargaOficinaInicial()
        {
            K_Oficina = GlobalVar.K_Oficina;
            //txtClaveOficina.Text = Convert.ToString(K_Oficina);

            //txtOficina.Text = GlobalVar.D_Oficina;
            //BuscaEnTablaClaveDescripcion(GlobalVar.dtOficinas, "K_Oficina", "D_Oficina", ref txtClaveOficina, ref txtOficina);
            //K_Oficina = (txtClaveOficina.Text == "") ? 0 : Convert.ToInt32(txtClaveOficina.Text);
        }
        void MtdCargaAlmacen()
        {
            if (K_Oficina == 0)
            {
                dtAlmacen.Rows.Clear();
            }
            else
            {
                dtAlmacen = sqlCatalogo.Sk_Almacenes_Empresa();
            }

            if (dtAlmacen != null)
            {
                if(dtAlmacen.Rows.Count>0)
                {
                    DataRow dr = dtAlmacen.NewRow();

                    dr["K_Almacen"] = 0;
                    dr["K_Oficina"] = 0;
                    dr["D_Oficina"] = "";
                    dr["D_Almacen"] = "";
                    dr["B_AceptaDevolucionesCliente"] = false;

                    dtAlmacen.Rows.InsertAt(dr, 0);
                    dtAlmacen.AcceptChanges();

                    int indice = -1;
                    indice = 0;
                    LlenaCombo(dtAlmacen, ref cbxAlmacen, "K_Almacen", "D_Almacen", indice);

                    cbxAlmacen.SelectedIndex = 0;
                }
              
            }
        }
        void MtdCargaAseguradora()
        {
            //if (K_Celula == 0)
            //{
            //    dtAseguradora.Rows.Clear();
            //}
            //else
            //{
            //    dtAseguradora = sqlCatalogo.Sk_Celulas(K_Celula);
            //}

            //if (dtAseguradora != null)
            //{
            //    DataRow dr = dtAseguradora.NewRow();

            //    dr["K_Aseguradora"] = 0;
            //    dr["D_Aseguradora"] = "[SELECCIONAR]";
            //    dr["C_Celula"] = string.Empty;
            //    dr["D_Celula"] = string.Empty;

            //    dtAseguradora.Rows.InsertAt(dr, 0);
            //    dtAseguradora.AcceptChanges();

            //    int indice = -1;
            //    indice = 0;
            //    LlenaCombo(dtAseguradora, ref cbxAseguradora, "K_Aseguradora", "D_Aseguradora", indice);
            //}
        }
        void Mtd_Limpia_Informacion_Articulo()
        {
            txtArticulo.Text = string.Empty;
        }
        void Mtd_Calcula_Totales()
        {
            
            //Calculamos el IVA de todos los artículos
            var x = dtArticulos.AsEnumerable().Select(r => Convert.ToDecimal(r.Field<Decimal>("Total_IVA"))).Sum();
            if (x.ToString() != "")
            {
                if (x >= 0)
                {
                    txtTotalIVA.Text = Math.Round(x,2).ToString("N2").Trim();
                }
            }

            //Calculamos el SUBTOTAL de todos los artículos
            var z = dtArticulos.AsEnumerable().Select(r => Convert.ToDecimal(r.Field<Decimal>("Subtotal"))).Sum();
            if (z.ToString() != "")
            {
                if (z >= 0)
                {
                    txtSubtotal.Text = Math.Round(z,2).ToString("N2").Trim();
                }
            }

            //Calculamos el TOTAL del pedido
            decimal totalPedido = x + z;
            txtTotalPedido.Text = Math.Round(totalPedido,2).ToString("N2");
         
        }
        void MtdCargaTipo_Entrega()
        {
            dtTipoEntrega.Rows.Clear();
            cbxTipo_Entrega.DataSource = null;
            cbxTipo_Entrega.Items.Clear();
            cbxTipo_Entrega.AutoCompleteSource = AutoCompleteSource.None;
            cbxTipo_Entrega.AutoCompleteMode = AutoCompleteMode.None;


           dtTipoEntrega = sqlCatalogo.Sk_Tipo_Entrega();

            
            if (dtTipoEntrega != null)
            {
                DataRow dr = dtTipoEntrega.NewRow();

                dr["K_Tipo_Entrega"] = 0;    
                dr["D_Tipo_Entrega"] = "";
            
                dtTipoEntrega.Rows.InsertAt(dr, 0);

                dtTipoEntrega.AcceptChanges();

                int indice = -1;
                indice = 0;
                LlenaCombo(dtTipoEntrega, ref cbxTipo_Entrega, "K_Tipo_Entrega", "D_Tipo_Entrega", -1);
                cbxTipo_Entrega.SelectedValue = 2;
            }
        }
        void MtdCargaEmpresa_Entrega()
        {
            dtEmpresaEntrega.Rows.Clear();
            cbxEmpresa.DataSource = null;
            cbxEmpresa.Items.Clear();
            cbxEmpresa.AutoCompleteSource = AutoCompleteSource.None;
            cbxEmpresa.AutoCompleteMode = AutoCompleteMode.None;


            dtEmpresaEntrega = sqlCatalogo.Sk_Empresa_Entrega();


            if (dtEmpresaEntrega != null)
            {
                DataRow dr = dtEmpresaEntrega.NewRow();

                dr["K_Empresa_Entrega"] = 0;
                dr["D_Empresa_Entrega"] = "";

                dtEmpresaEntrega.Rows.InsertAt(dr, 0);

                dtEmpresaEntrega.AcceptChanges();

                int indice = -1;
                indice = 0;
                LlenaCombo(dtEmpresaEntrega, ref cbxEmpresa, "K_Empresa_Entrega", "D_Empresa_Entrega", indice);
                cbxEmpresa.SelectedValue = 2;
            }
        }
        void MtdCargaCelulas()
        {
            dtCelulas.Rows.Clear();
            cbxCelula.DataSource = null;
            cbxCelula.Items.Clear();
            cbxCelula.AutoCompleteSource = AutoCompleteSource.None;
            cbxCelula.AutoCompleteMode = AutoCompleteMode.None;

            dtCelulas = sqlCatalogo.Sk_Celulas();

            if (dtCelulas != null)
            {
                DataRow dr = dtCelulas.NewRow();

                dr["K_Celula"] = 0;
                dr["C_Celula"] = "";
                dr["D_Celula"] = "[Seleccionar]";
                dr["K_Aseguradora"] = 0;
                dr["D_Aseguradora"] = "";
                dtCelulas.Rows.InsertAt(dr, 0);

                dtCelulas.AcceptChanges();

                int indice = -1;
                indice = 0;
                LlenaCombo(dtCelulas, ref cbxCelula, "K_Celula", "D_Celula", indice);
                cbxCelula.SelectedIndex = 1;
            }
        }
        private void MtdCargarPacientes()
        {
            if (txtClavePaciente.Text.Trim().Length > 0)
            {
                int K_PacienteInt = Convert.ToInt32(txtClavePaciente.Text.Trim());

                dtPacientes = sql_ventas.Sk_Consulta_Paciente(K_PacienteInt);

                if ((dtPacientes != null) && (dtPacientes.Rows.Count > 0))
                {
                    DataRow row = dtPacientes.Rows[0];
                    //this.lblFechaNac.Text = row["F_Nacimiento"].ToString();
                    this.lblGenero.Text = row["D_Genero"].ToString();
                    this.lblEstadoCivil.Text = row["D_Estado_Civil"].ToString();
                    this.lblNacionalidad.Text = row["D_Nacionalidad"].ToString();
                    this.lblRFC.Text = row["RFC"].ToString();
                    this.lblCURP.Text = row["CURP"].ToString();
                    this.lblTipoDeSangre.Text = row["D_Tipo_Sangre"].ToString();
                    this.lblTipoPaciente.Text = row["D_Tipo_Paciente"].ToString();
                    this.K_AseguradoraInt = Convert.ToInt32(row["K_Aseguradora"].ToString());
                    this.lblAseguradora.Text = row["D_Aseguradora"].ToString();
                    this.lblCelula.Text = row["D_Celula"].ToString();
                    this.lblTipoDePoliza.Text = row["D_Tipo_Poliza"].ToString();
                    this.lblPoliza.Text = row["Poliza"].ToString();
                    this.lblSiniestro.Text = row["Siniestro"].ToString();
                    this.lblReclamacion.Text = row["Reclamacion"].ToString();
                    this.lblCoaseguroPorcentaje.Text = row["Porcentaje_Coaseguro"].ToString();
                    if (Convert.ToDecimal(lblCoaseguroPorcentaje.Text) > 0)
                    {
                    }
                    this.K_ClienteInt = Convert.ToInt32(row["K_Cliente"].ToString());
                    this.K_Cliente_Domicilio_Fiscal = row["K_Cliente_Domicilio_Fiscal"].ToString() !=""? Convert.ToInt32(row["K_Cliente_Domicilio_Fiscal"].ToString()) : 0;
                    this.K_PacienteDireccionInt = row["K_Paciente_Direccion"].ToString() != "" ? Convert.ToInt32(row["K_Paciente_Direccion"].ToString()) : Convert.ToInt32(0);
                    this.lblTipoDireccion.Text = row["D_Tipo_Direccion"].ToString();
                    this.lblCalle.Text = row["Calle"].ToString();
                    this.lblEntreCalles.Text = row["Entre_Calles"].ToString();
                    this.lblEdificio.Text = row["Edificio"].ToString();
                    this.lblColonia.Text = row["D_Colonia"].ToString();
                    this.lblMunicipio.Text = row["D_Municipio"].ToString();
                    this.lblEstado.Text = row["D_Estado"].ToString();
                    this.lblPais.Text = row["D_Pais"].ToString();
                    this.lblCP.Text = row["Codigo_Postal"].ToString();
                    this.LblNumeroInt.Text = row["Piso"].ToString();

                    this.K_Paciente_TelefonoInt = row["K_Paciente_Telefono"].ToString() != "" ? Convert.ToInt32(row["K_Paciente_Telefono"].ToString()) : Convert.ToInt32(0);
                    this.lblTipoTelefono.Text = row["D_Tipo_Telefono"].ToString();
                    this.lblTelefono.Text = row["Telefono"].ToString();
                    this.LblCodigoPais.Text = row["Codigo_Pais"].ToString();
                    this.LblLada.Text = row["Lada"].ToString();

                    K_MedicoInt = row["K_Medico"].ToString() != "" ? Convert.ToInt32(row["K_Medico"].ToString()) : Convert.ToInt32(0);
                    this.lblMedico.Text = row["Nombre_Medico"].ToString();

                    //this.lblDictaminador.Text = row["Nombre_Medico"].ToString();

                    MtdCargaCelulas();
                    MtdCargaArticulos();
                }
            }
        }
        public void Mtd_Incrementar(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataColumn col in dtArticulos.Columns)
            {
                col.ReadOnly = false;
            }

            dtArticulos.AsEnumerable().ToList<DataRow>().ForEach(r => {
                if (dtArticulos.Rows[e.RowIndex] == r)                
                r["Cantidad"] = int.Parse(r["Cantidad"].ToString()) + 1;
                r["Subtotal"] = decimal.Parse(r["Cantidad"].ToString()) * decimal.Parse(r["Precio_Unitario"].ToString());
                r["Total_IVA"] = decimal.Parse(r["Subtotal"].ToString()) * Convert.ToDecimal((0 + (decimal.Parse(r["Tasa_IVA"].ToString()) / 100)));
                r["Total_Detalle"] = decimal.Parse(r["Subtotal"].ToString()) + decimal.Parse(r["Total_IVA"].ToString());
            });

            Mtd_Calcula_Totales();

            grdDetalle.DataSource = dtArticulos;
        }
        public void Mtd_Disminuir(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataColumn col in dtArticulos.Columns)
            {
                col.ReadOnly = false;

            }
            dtArticulos.AsEnumerable().ToList<DataRow>().ForEach(r => {
                if (dtArticulos.Rows[e.RowIndex] == r)
                r["Cantidad"] = int.Parse(r["Cantidad"].ToString()) - 1;
                r["SubTotal"] = decimal.Parse(r["Cantidad"].ToString()) * decimal.Parse(r["Precio_Unitario"].ToString());
                r["Total_IVA"] = decimal.Parse(r["SubTotal"].ToString()) * Convert.ToDecimal((0 + (decimal.Parse(r["Tasa_IVA"].ToString()) / 100)));
                r["Total_Detalle"] = decimal.Parse(r["SubTotal"].ToString()) + decimal.Parse(r["Total_IVA"].ToString());
                if (int.Parse(r["Cantidad"].ToString()) == 0)
                {
                    dtArticulos.Rows[e.RowIndex].Delete();
                    dtArticulos.AcceptChanges();
                }
            });


            Mtd_Calcula_Totales();

            grdDetalle.DataSource = dtArticulos;
        }
        #endregion
        private void txtTasaIVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            fx.ValidaSeaNumero(ref e);
        }
        private void txtPorcentajeDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            fx.ValidaSeaNumero(ref e);
        }
        private void Cbx_Tipo_Entrega_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbxTipo_Entrega.SelectedValue != null)
            {
                if (cbxTipo_Entrega.SelectedValue.ToString() == "1") //FORANEA
                {
                    pnlEntregaForanea.Visible = true;
                    MtdCargaEmpresa_Entrega();
                }
                else if (cbxTipo_Entrega.SelectedText.ToString() != "2") //LOCAL
                {
                    pnlEntregaForanea.Visible = false;
                }
                else
                {
                    pnlEntregaForanea.Visible = false;
                }
            }
        }
        private void btnBuscaPaciente_Click(object sender, EventArgs e)
        {
            FILTROS.Frm_Filtro_Paciente_Pedido frm = new FILTROS.Frm_Filtro_Paciente_Pedido();
            frm.ShowDialog();
            if (frm.LLave_Seleccionado != 0 && frm.Descripcion_Seleccionado != "")
            {
                txtClavePaciente.Text = frm.LLave_Seleccionado.ToString();
                txtPaciente.Text = frm.Descripcion_Seleccionado.ToString();
            }
        }
        private void txtClavePaciente_TextChanged(object sender, EventArgs e)
        {
            MtdCargarPacientes();
        }
        private void rdbPct_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbPct.Checked)
            {
                this.lblCoaseguro.Text = "Porcentaje";
                this.txtCoaseguro2.Enabled = true;
                this.cbxMetodoPagoCoaseguro.Enabled = true;
            }
        }
        private void rdbFijo_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbFijo.Checked)
            {
                this.lblCoaseguro.Text = "Importe";
                this.txtCoaseguro2.Enabled = true;
                this.cbxMetodoPagoCoaseguro.Enabled = true;
            }
        }
        private void rdbSinCoaseguro_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbSinCoaseguro.Checked)
            {
                this.lblCoaseguro.Text = "Sin Coaseguro";
                this.txtCoaseguro2.Enabled = false;
                this.cbxMetodoPagoCoaseguro.Enabled = false;
            }
        }
        private void btnAgregarFecha_Click(object sender, EventArgs e)
        {
            if (txtClavePaciente.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN PACIENTE", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPaciente.Focus();
                return;
            }
            if (Convert.ToInt32(cbxCelula.SelectedValue.ToString())== 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA CELULA", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxCelula.Focus();
                return;
            }

            Modelos.PedidosFechas obFechasPedido = new Modelos.PedidosFechas();

            int año = Convert.ToInt16(this.dtpFecha.Value.Year);
            int mes = Convert.ToInt16(this.dtpFecha.Value.Month.ToString().Trim().PadLeft(2, '0'));
            int dia = Convert.ToInt16(this.dtpFecha.Value.Day.ToString().Trim().PadLeft(2, '0'));
            DateTime f = new DateTime(año, mes, dia);
            obFechasPedido.F_Entrega =  f.ToString("dd/MMM/yyyy"); 
            obFechasPedido.H_Entrega = this.txt_HI.Value.ToShortTimeString();
            obFechasPedido.B_Parcial = this.cbxPedidoParcial.Checked;
            obFechasPedido.B_Programado = this.lstFechas.Count == 0 ? false : true;
            obFechasPedido.PacienteCartaPedido = this.txtNombrePacienteCarta.Text.Trim().ToString() != "" ? txtNombrePacienteCarta.Text.Trim().ToString() : "";
            obFechasPedido.Atencion =this.txtAtencion.Text.Trim().ToString() != "" ? txtAtencion.Text.Trim().ToString() : "";
            obFechasPedido.Carta_Pedido= this.txtCarta.Text.Trim().ToString() != "" ? txtCarta.Text.Trim().ToString() : "";
            obFechasPedido.Monto_Carta = Convert.ToDecimal(this.txtMontoCarta.Moneda.Text.Trim().ToString() != "" ? Convert.ToDecimal(txtMontoCarta.Moneda.Text.Trim().ToString()) :0);
            obFechasPedido.Siniestro_Pedido = this.txtSiniestro.Text.Trim().ToString() != "" ? txtSiniestro.Text.Trim().ToString() : "";
            obFechasPedido.Reclamacion_Pedido = this.txtReclamacion.Text.Trim().ToString() != "" ? txtReclamacion.Text.Trim().ToString() : "";
            obFechasPedido.Poliza_Pedido = this.txtPoliza.Text.Trim().ToString() != "" ? txtPoliza.Text.Trim().ToString() : "";
            obFechasPedido.K_Celula_Pedido = Convert.ToInt32(this.cbxCelula.SelectedValue.ToString()) != 0 ? Convert.ToInt32(this.cbxCelula.SelectedValue.ToString()) : 0;
            obFechasPedido.Coaseguro_Pedido= this.txtCoaseguro2.Text.Trim().ToString() != "" ? Convert.ToDecimal(txtCoaseguro2.Text.Trim().ToString()) : 0;
            obFechasPedido.B_CoaCobReq = this.cbxReqPagoCoaseguro.Checked; 

            lstFechas.Add(obFechasPedido);

            DataRow dr;
            dr = dtFechasPedido.NewRow();

            dr["Fecha"] = obFechasPedido.F_Entrega;
            dr["Hora"] = obFechasPedido.H_Entrega;
            dr["B_Parcial"] = obFechasPedido.B_Parcial;
            dr["Carta"] = obFechasPedido.Carta_Pedido;
            dr["Siniestro"] = obFechasPedido.Siniestro_Pedido;
            dr["Reclamacion"] = obFechasPedido.Reclamacion_Pedido;
            dr["Coaseguro"] = obFechasPedido.Coaseguro_Pedido;
            dr["Poliza"] = obFechasPedido.Poliza_Pedido;
  
            dtFechasPedido.Rows.Add(dr);

            this.dgvFechas.Visible = true;
            this.dgvFechas.DataSource = dtFechasPedido;
    
        }
        private void dgvFechas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFechas.Columns[e.ColumnIndex].Name == "MenosFechas")
            {
                lstFechas.RemoveAt(Convert.ToInt32(e.RowIndex));

                dtFechasPedido.AsEnumerable().ToList<DataRow>().ForEach(r => {
                    dtFechasPedido.Rows[e.RowIndex].Delete();
                });

                this.dgvFechas.DataSource = dtFechasPedido;
            }     
        }
        private void BtnAsesor_Click(object sender, EventArgs e)
        {
            Busquedas.BuscaAsesores  frm = new Busquedas.BuscaAsesores();
            frm.ShowDialog();
            if (frm.LLave_Seleccionado != 0 && frm.Descripcion_Seleccionado != "")
            {
                txtK_Asesor.Text = frm.LLave_Seleccionado.ToString();
                txtAsesor.Text = frm.Descripcion_Seleccionado.ToString();
            }
        }
        private void btnDirecciones_Click(object sender, EventArgs e)
        {
            if (txtClavePaciente.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN PACIENTE", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPaciente.Focus();
                return;
            }
            FRM_PACIENTES_DIRECCIONES frm = new FRM_PACIENTES_DIRECCIONES();
            frm.BtnBorrar.Visible = false;
            frm.BtnBorrar.Enabled = false;
            frm.PropiedadK_Paciente = Convert.ToInt32(txtClavePaciente.Text);
            frm.PropiedadD_Paciente = txtPaciente.Text;
            frm.ShowDialog();
            lblCalle.Text = frm.Calle_Pasa;
            LblNumeroInt.Text = frm.Numero_Int;
            LblNumeroExt.Text = Convert.ToString(frm.Numero_Ext);
            lblTipoDireccion.Text = frm.Tipo_Direccion_Pasa;
            lblEntreCalles.Text = frm.EntreCalles_Pasa;
            lblEdificio.Text = frm.Edificio_Pasa;
            LblPiso.Text = frm.Piso_Pasa;
            lblColonia.Text = frm.Colonia_Pasa;
            lblEstado.Text = frm.Estado_Pasa;
            lblPais.Text = frm.Pais_Pasa;
            lblLocalidad.Text =  frm.Localidad_Pasa;
            lblCP.Text = Convert.ToString(frm.CP_Pasa);
            lblMunicipio.Text = frm.Municipio_Pasa;
            K_PacienteDireccionInt =  frm.K_Paciente_Dierccion;
        }
        private void btnTelefonos_Click(object sender, EventArgs e)
        {
            if (txtClavePaciente.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN PACIENTE", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPaciente.Focus();
                return;
            }
            FRM_PACIENTES_TELEFONOS frm = new FRM_PACIENTES_TELEFONOS();
            frm.btnEliminar.Visible = false;
            frm.btnEliminar.Enabled = false;
            frm.PropiedadK_Paciente = Convert.ToInt32(txtClavePaciente.Text);
            frm.PropiedadD_Paciente = txtPaciente.Text;
            frm.ShowDialog();
            lblTipoTelefono.Text = frm.Tipo_Telefono;
            lblTelefono.Text = frm.Telefono_Pasa;
            LblLada.Text = Convert.ToString(frm.Lada_Pasa);
            LblCodigoPais.Text = Convert.ToString(frm.Codigo_Pais_Pasa);
            K_Paciente_TelefonoInt = frm.K_Telefono_Pasa;

        }
        private void btnMedicos_Click(object sender, EventArgs e)
        {
            FRM_PACIENTES_MEDICOS frm = new FRM_PACIENTES_MEDICOS();
            frm.btnEliminar.Visible = false;
            frm.btnEliminar.Enabled = false;
            frm.PropiedadK_Paciente = Convert.ToInt32(txtClavePaciente.Text);
            frm.PropiedadD_Paciente = txtPaciente.Text;
            frm.ShowDialog();
            lblMedico.Text = frm.D_Medico_Pasa;
            K_MedicoInt = frm.K_Medico_Pasa;

        }
        private void btnDictaminador_Click(object sender, EventArgs e)
        {
            FRM_PACIENTES_MEDICOS frm = new FRM_PACIENTES_MEDICOS();
            frm.btnEliminar.Visible = false;
            frm.btnEliminar.Enabled = false;
            frm.PropiedadK_Paciente = Convert.ToInt32(txtClavePaciente.Text);
            frm.PropiedadD_Paciente = txtPaciente.Text;
            frm.ShowDialog();
            lblDictaminador.Text = frm.D_Medico_Pasa;
            K_MedicoDic = frm.K_Medico_Pasa;

        }
        private void MtdCargaArticulos()
        {
            dtArticulos = null;
            grdDetalle.DataSource = null;

            if (K_CotizacionInt > 0)
            {
                grdDetalle.MultiSelect = false;
                grdDetalle.ReadOnly = true;
                grdDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Both;
                grdDetalle.BackgroundColor = Color.White;
                grdDetalle.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 70, 209);
                grdDetalle.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                grdDetalle.EnableHeadersVisualStyles = false;

                dtArticulos = sqlPedidos.Sk_Detalle_Cotizacion(K_CotizacionInt);

                if ((dtArticulos != null) && (dtArticulos.Rows.Count != 0))
                {
                    grdDetalle.AutoGenerateColumns = false;
                    grdDetalle.DataSource = dtArticulos;
                    Mtd_Calcula_Totales();
                }

            }
            else
            {
                grdDetalle.MultiSelect = false;
                grdDetalle.ReadOnly = true;
                grdDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Both;
                grdDetalle.BackgroundColor = Color.White;
                grdDetalle.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 70, 209);
                grdDetalle.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                grdDetalle.EnableHeadersVisualStyles = false;

                dtArticulos = sqlPedidos.Sk_Pacientes_ArticulosProg(Convert.ToInt32(txtClavePaciente.Text.Trim()));

                if ((dtArticulos != null) && (dtArticulos.Rows.Count != 0))
                {
                    grdDetalle.AutoGenerateColumns = false;
                    grdDetalle.DataSource = dtArticulos;
                    Mtd_Calcula_Totales();
                }
            }

        }

        private void FRM_INGRESA_PEDIDOS_Load(object sender, EventArgs e)
        {
            dtFechasPedido.Columns.Add("Fecha", typeof(string));
            dtFechasPedido.Columns.Add("Hora", typeof(string));
            dtFechasPedido.Columns.Add("B_Parcial", typeof(bool));
            dtFechasPedido.Columns.Add("Carta", typeof(string));
            dtFechasPedido.Columns.Add("Siniestro", typeof(string));
            dtFechasPedido.Columns.Add("Reclamacion", typeof(string));
            dtFechasPedido.Columns.Add("Coaseguro", typeof(string));
            dtFechasPedido.Columns.Add("Poliza", typeof(string));
            txtK_Asesor.Text = GlobalVar.K_Asesor.ToString();
            txtAsesor.Text = GlobalVar.D_Asesor;

            dtPagos.Rows.Clear();
            cbxMetodoPagoCoaseguro.DataSource = null;
            cbxMetodoPagoCoaseguro.Items.Clear();
            cbxMetodoPagoCoaseguro.AutoCompleteSource = AutoCompleteSource.None;
            cbxMetodoPagoCoaseguro.AutoCompleteMode = AutoCompleteMode.None;
            dtPagos = sql_ventas.Sk_Tipos_PagoVenta();
            if (dtPagos != null)
            {
                int indice = -1;
                indice = 0;
                LlenaCombo(dtPagos, ref cbxMetodoPagoCoaseguro, "K_Tipo_Pago", "D_Tipo_Pago", indice);

            }

        }

        private void grdDetalle_SelectionChanged(object sender, EventArgs e)
        {
            grdDatos.AutoGenerateColumns = false;
            if (grdDetalle.Rows.Count > 0)
            {
                if (grdDetalle.CurrentRow.Cells["K_Articulo"].Value != null)
                {
                    dtInventario = sqlAlmacen.Sk_Lotes_Inventario(Convert.ToInt32(grdDetalle.CurrentRow.Cells["K_Articulo"].Value));


                    if (dtInventario != null)
                    {
                        grdDatos.DataSource = dtInventario;
                    }
                    else
                    {
                        grdDatos.DataSource = null;
                    }
                }
            }
        }

    
    }
}

