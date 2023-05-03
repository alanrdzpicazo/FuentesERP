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
using ProbeMedic.Busquedas;
using ProbeMedic.FILTROS;

namespace ProbeMedic.CATALOGOS.ENFERMERIA
{
    public partial class FRM_GENERAR_sERVICIOS_ENFERMERIA : FormaBase
    {
        public FRM_GENERAR_sERVICIOS_ENFERMERIA()
        {
            InitializeComponent();
            grdDatos.MultiSelect = false;
            grdDatos.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            grdDatos.BackgroundColor = Color.White;
            grdDatos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 70, 209);
            grdDatos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grdDatos.EnableHeadersVisualStyles = false;
        }

        Funciones fx = new Funciones();

        DataTable Articulos = new DataTable();
        DataTable dtDatos = new DataTable();
        SQLVentas sqlventas = new SQLVentas();

        Int32 K_Cliente = 0;
        Int32 K_Dias_Servicio, K_Clase_ServicioEnfermeria, K_Tipo_ServicioEnfermeria, K_Duracion_Servicio, K_Precio_Enfermeria;
        String D_Cliente, D_Dias_Servicio, D_Clase_ServicioEnfermeria, D_Tipo_ServicioEnfermeria, D_Duracion_Servicio;

        int KArticulo = 0;
        decimal PSubtotal = 0;
        decimal PIva = 0;
        decimal PPrecio = 0;

        int res = -1;

        string msg = string.Empty;

        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }

        private void FRM_GENERAR_sERVICIOS_ENFERMERIA_Load(object sender, EventArgs e)
        {

        }

        public override void BaseMetodoInicio()
        {
            btnBuscarCliente.Focus();
            BaseMetodoRecarga();
            BaseBotonModificar.Visible = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonReporte.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonGuardar.Enabled = false;
            BaseBotonBuscar.Visible = true;
            BaseBotonBuscar.Enabled = true;
            BaseBotonExcel.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonBuscar.Visible = false;
            dtDatos = Articulos_DetalleEnfermeria_Table;
        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (K_Cliente == 0 || txtCliente.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR UN CLIENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscarCliente.Focus();
                return false;
            }
            if (K_Tipo_ServicioEnfermeria== 0 || txtTipoServicio.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL TIPO DEL SERVICIO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscaTipoServicio.Focus();
                return false;
            }
            if (K_Dias_Servicio == 0 || txtDias.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LOS DIAS DEL SERVICIO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscaDias.Focus();
                return false;
            }
            if (K_Duracion_Servicio == 0 || txtDuracion.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA DURACION DEL SERVICIO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscaDuracion.Focus();
                return false;
            }
            if (K_Clase_ServicioEnfermeria == 0 || txtClasificacion.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA CLASIFICACION DEL SERVICIO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscaClasificacion.Focus();
                return false;
            }
            if (rdbHombre.Checked == false && rdbMujer.Checked == false)
            {
                MessageBox.Show("FALTA SELECCIONAR EL GENERO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rdbHombre.Focus();
                return false;
            }
            if (ucExtraeOficinaEnfermeria1.K_Pais == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL PAIS...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucExtraeOficinaEnfermeria1.btn_G_Pais.Focus();
                return false;
            }
            if (ucExtraeOficinaEnfermeria1.K_Estado== 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL ESTADO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucExtraeOficinaEnfermeria1.btn_G_Estado.Focus();
                return false;
            }
            if (ucExtraeOficinaEnfermeria1.K_Ciudad == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA CIUDAD...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucExtraeOficinaEnfermeria1.btn_G_Ciudad.Focus();
                return false;
            }
            if (ucExtraeOficinaEnfermeria1.K_Colonia == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA COLONIA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucExtraeOficinaEnfermeria1.btn_G_Colonia.Focus();
                return false;
            }
            if (ucExtraeOficinaEnfermeria1.K_Oficina== 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA OFICINA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucExtraeOficinaEnfermeria1.btn_G_Colonia.Focus();
                return false;
            }
            if (txtTelefono.Text.Trim() == "")
            {
                MessageBox.Show("FALTA CAPTURAR EL TELEFONO..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return false;
            }
            BaseErrorResultado = false;
            return true;
        }

        public override void BaseMetodoLimpiaControles()
        {
            txtCliente.Text = string.Empty;
            K_Cliente = 0;
            txtTipoServicio.Text = string.Empty;
            K_Tipo_ServicioEnfermeria = 0;
            txtDias.Text = string.Empty;
            K_Dias_Servicio = 0;
            txtDuracion.Text = string.Empty;
            K_Duracion_Servicio = 0;
            txtClasificacion.Text = string.Empty;
            K_Clase_ServicioEnfermeria = 0;
            ucExtraeOficinaEnfermeria1.K_Pais = 0;
            ucExtraeOficinaEnfermeria1.txt_G_Pais.Text = string.Empty;
            ucExtraeOficinaEnfermeria1.K_Pais = 0;
            ucExtraeOficinaEnfermeria1.txt_G_Estado.Text = string.Empty;
            ucExtraeOficinaEnfermeria1.K_Estado = 0;
            ucExtraeOficinaEnfermeria1.txt_G_Ciudad.Text = string.Empty;
            ucExtraeOficinaEnfermeria1.K_Ciudad = 0;
            ucExtraeOficinaEnfermeria1.txt_G_Colonia.Text = string.Empty;
            ucExtraeOficinaEnfermeria1.K_Colonia = 0;
            ucExtraeOficinaEnfermeria1.txt_G_Oficina.Text = string.Empty;
            ucExtraeOficinaEnfermeria1.K_Oficina = 0;
            txtCalle.Text = String.Empty;
            txtTelefono.Text = String.Empty;
            K_Precio_Enfermeria = 0;
            dtpFecha.Value = DateTime.Now;
            cbxPeso.Checked = false;
            rdbHombre.Checked = false;
            rdbMujer.Checked = false;
            btnGenerar.Enabled = false;
            btnRecurrente.Enabled = false;
            BaseMetodoInicio();
            btnBuscarCliente.Focus();
       

        }

        private void btnBuscarArticulos_Click(object sender, EventArgs e)
        {
            Frm_Busca_Articulos_SOS frm = new Frm_Busca_Articulos_SOS();
            frm.ShowDialog();
            KArticulo = frm.LLave_Seleccionado;
            txtArticulo.Text = frm.Descripcion_Seleccionado;
            PSubtotal = frm.Subtotal_Seleccionado;
            PIva = frm.Iva_Seleccionado;
            PPrecio = frm.Precio_Seleccionado;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtArticulo.Text.Trim().Length == 0)
            {
                MessageBox.Show("SELECCIONE UN ARTICULO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtArticulo.Focus();
                return;
            }
            if (txtCantidad.Text.Trim().Length == 0)
            {
                MessageBox.Show("CAPTURE LA CANTIDAD", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCantidad.Focus();
                return;
            }

            Decimal subtotal = PSubtotal * Convert.ToDecimal(txtCantidad.Text) + Convert.ToDecimal(lblSubtotal.Text);
            Decimal iva = Math.Round(PIva * Convert.ToDecimal(txtCantidad.Text), 2) + Convert.ToDecimal(lblIva.Text);
            Decimal total = Convert.ToDecimal(PSubtotal * Convert.ToDecimal(txtCantidad.Text)) + Convert.ToDecimal(txtCantidad.Text) * (PIva) + Convert.ToDecimal(lblPrecio.Text);
            
            DataRow dr;
            dr = dtDatos.NewRow();

            dr["K_Articulo"] = KArticulo;
            dr["D_Articulo"] = txtArticulo.Text;
            dr["Cantidad"] = Convert.ToDecimal(txtCantidad.Text);
            dr["Precio"] =PSubtotal;
            dr["Subtotal"] = PSubtotal * Convert.ToDecimal(txtCantidad.Text);
            dr["Iva"] = Math.Round(PIva * Convert.ToDecimal(txtCantidad.Text),2);
            dr["Total"] = Convert.ToDecimal(PSubtotal * Convert.ToDecimal(txtCantidad.Text)) + Convert.ToDecimal(txtCantidad.Text) * (PIva);

            subtotal = Math.Round(subtotal, 2);
            iva = Math.Round(iva, 2);
            total = Math.Round(total, 2);

            lblSubtotal.Text = subtotal.ToString();
            lblIva.Text = iva.ToString();
            lblPrecio.Text = total.ToString();

            dtDatos.Rows.Add(dr);

            grdDatos.DataSource = dtDatos;

            txtArticulo.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            KArticulo = 0;
            btnBuscarArticulos.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!BaseFuncionValidaciones())
                return;

            DateTime F_Servicio = DateTime.Today;
            F_Servicio = Convert.ToDateTime(dtpFecha.Value.ToString("yyyy/MM/dd"));

            Int32 CampoIdentity = 0;
            msg = string.Empty;

            DataTable dtDetalle = dtDatos.Copy();
            dtDetalle.Columns.Remove("Subtotal");
            dtDetalle.Columns.Remove("Iva");

            res = sqlventas.In_Servicios_Contratados(ref CampoIdentity,
                K_Cliente,
                ucExtraeOficinaEnfermeria1.K_Oficina,
                ucExtraeOficinaEnfermeria1.K_Pais,
                ucExtraeOficinaEnfermeria1.K_Estado,
                ucExtraeOficinaEnfermeria1.K_Ciudad,
                ucExtraeOficinaEnfermeria1.K_Colonia,
                ucExtraeOficinaEnfermeria1.B_Local,
                Convert.ToDecimal(lblPrecio.Text),
                F_Servicio,
                K_Dias_Servicio,
                K_Clase_ServicioEnfermeria,
                K_Tipo_ServicioEnfermeria,
                K_Duracion_Servicio, K_Precio_Enfermeria,
                txtCalle.Text,
                rdbHombre.Checked == true ? true : false,
                cbxPeso.Checked,
                txtTelefono.Text,
                dtDetalle,
                ref msg);

            if (res == -1)
            {
                BaseErrorResultado = true;
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                BaseErrorResultado = false;
                MessageBox.Show("INFORMACION ACTUALIZADA CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FechaInicial = F_Servicio;
                FechaFinal = F_Servicio;
                this.Close();


            }


        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!BaseFuncionValidaciones())
                return;
            CalculaPrecioServicio();
          
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            gbCaracteristicas.Enabled = true;
            gbDomicilio.Enabled = true;
            button4.Enabled = true;
            BaseMetodoLimpiaControles();
            dtDatos.Rows.Clear();
            grdDatos.DataSource = dtDatos;
            lblSubtotal.Text = string.Empty;
            lblIva.Text = string.Empty;
            lblPrecio.Text = string.Empty;
            lblSubtotal.Text = "0.000";
            lblIva.Text = "0.000";
            lblPrecio.Text = "0.000";
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            fx.ValidaSeaNumero(ref e);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaSeaNumeroDecimal(ref sender, ref e);
        }

        private void btnRecurrente_Click(object sender, EventArgs e)
        {

            if (!BaseFuncionValidaciones())
                return;

            DateTime F_Servicio = DateTime.Today;
            F_Servicio = Convert.ToDateTime(dtpFecha.Value.ToString("yyyy/MM/dd"));

            DateTime F_Inicio_Servicio = DateTime.Today;
            F_Inicio_Servicio = Convert.ToDateTime(dtpInicio.Value.ToString("yyyy/MM/dd"));

            DateTime F_Fin_Servicio = DateTime.Today;
            F_Fin_Servicio = Convert.ToDateTime(dtpFin.Value.ToString("yyyy/MM/dd"));

            Int32 CampoIdentity = 0;
            msg = string.Empty;

            res = sqlventas.In_Servicios_RecurrentesEnfermeria(ref CampoIdentity,
                K_Cliente,
                ucExtraeOficinaEnfermeria1.K_Oficina,
                ucExtraeOficinaEnfermeria1.K_Pais,
                ucExtraeOficinaEnfermeria1.K_Estado,
                ucExtraeOficinaEnfermeria1.K_Ciudad,
                ucExtraeOficinaEnfermeria1.K_Colonia,
                ucExtraeOficinaEnfermeria1.B_Local,
                Convert.ToDecimal(lblPrecio.Text),
                F_Servicio,
                K_Dias_Servicio,
                K_Clase_ServicioEnfermeria,
                K_Tipo_ServicioEnfermeria,
                K_Duracion_Servicio, K_Precio_Enfermeria,
                F_Inicio_Servicio,
                F_Fin_Servicio,
                cbxPeso.Checked,
                rdbHombre.Checked == true ? true : false,
                ref msg);

            if (res == -1)
            {
                BaseErrorResultado = true;
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                BaseErrorResultado = false;
                MessageBox.Show("INFORMACION ACTUALIZADA CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FILTROS.Frm_Filtra_Cliente filtra = new FILTROS.Frm_Filtra_Cliente(GlobalVar.K_Empresa);
            filtra.ShowDialog();
            K_Cliente = filtra.K_Cliente_Seleccionado;
            D_Cliente = filtra.D_Cliente_Seleccionado;
            txtCliente.Text = Convert.ToString(D_Cliente);
           
        }

        private void btnBuscaTipoServicio_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Tipo_Servicio_Enfermeria busca = new Busquedas.Frm_Busca_Tipo_Servicio_Enfermeria();
            busca.ShowDialog();
            K_Tipo_ServicioEnfermeria = busca.LLave_Seleccionado;
            D_Tipo_ServicioEnfermeria = busca.Descripcion_Seleccionado;
            txtTipoServicio.Text = Convert.ToString(D_Tipo_ServicioEnfermeria);
        }

        private void btnBuscaDuracion_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Duracion_Servicios_Enf busca = new Busquedas.Frm_Busca_Duracion_Servicios_Enf();
            busca.ShowDialog();
            K_Duracion_Servicio = busca.LLave_Seleccionado;
            D_Duracion_Servicio = busca.Descripcion_Seleccionado;
            txtDuracion.Text = Convert.ToString(D_Duracion_Servicio);
        }

        private void btnBuscaDias_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Buscar_Dias_Servicio_Enfermeria busca = new Busquedas.Frm_Buscar_Dias_Servicio_Enfermeria();
            busca.ShowDialog();
            K_Dias_Servicio = busca.LLave_Seleccionado;
            D_Dias_Servicio = busca.Descripcion_Seleccionado;
            txtDias.Text = Convert.ToString(D_Dias_Servicio);
        }

        private void btnBuscaClasificacion_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Clase_Servicios_Enf busca = new Busquedas.Frm_Busca_Clase_Servicios_Enf();
            busca.ShowDialog();
            K_Clase_ServicioEnfermeria = busca.LLave_Seleccionado;
            D_Clase_ServicioEnfermeria = busca.Descripcion_Seleccionado;
            txtClasificacion.Text = Convert.ToString(D_Clase_ServicioEnfermeria);

            BuscaPreciosEnfermeria(K_Dias_Servicio, K_Clase_ServicioEnfermeria, K_Tipo_ServicioEnfermeria, K_Duracion_Servicio);

           
        }

        //ME BUSCA LOS PRECIOS DE ENcFERMERIA DE ACUERDO A LAS CARACTERISTICAS SOLICITADAS
        public void BuscaPreciosEnfermeria(Int32 K_Dias_Servicion,Int32 K_Clase_ServicioEnfermeria,Int32 K_Tipo_Servicio_Enfermeria,Int32 K_Duracion_Servicio)
        {
            
            DataTable datos = new DataTable();

            datos = sqlventas.GP_Valida_PreciosEnfermeria(K_Dias_Servicio,K_Clase_ServicioEnfermeria,K_Tipo_Servicio_Enfermeria,K_Duracion_Servicio);
            if (datos == null)
            {
                MessageBox.Show("NO SE ENCONTRO INFORMACION...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                datos.Clear();
                return;
            }
            if (datos.Rows.Count > 0)
            {
                DataRow row = datos.Rows[0];

                K_Precio_Enfermeria = Convert.ToInt32(row["K_Precio_Enfermeria"].ToString());
              
                if(K_Precio_Enfermeria == 0)
                {
                    MessageBox.Show("NO HAY SERVICIOS DISPONIBLES CON ESTAS CARACTERISTICAS...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        //CALCULA EL PRECIO TOMANDO COMO PARAMETROS EL DOMICILIO Y EL PRECIO DE ENFERMERIA
        public void CalculaPrecioServicio()
        {

            DataTable datos = new DataTable();

            datos = sqlventas.GP_Extrae_Precio_Enfermeria(Convert.ToBoolean(ucExtraeOficinaEnfermeria1.B_Local), K_Cliente,
                ucExtraeOficinaEnfermeria1.K_Pais,ucExtraeOficinaEnfermeria1.K_Oficina, ucExtraeOficinaEnfermeria1.K_Estado,ucExtraeOficinaEnfermeria1.K_Ciudad, ucExtraeOficinaEnfermeria1.K_Colonia, K_Precio_Enfermeria);
            if (datos == null)
            {
                MessageBox.Show("NO SE ENCONTRO INFORMACION...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                datos.Clear();
                return;
            }
            if (datos.Rows.Count > 0)
            {

                DataRow row = datos.Rows[0];
                string error = Convert.ToString(row["Error"].ToString());

                if (error != "")
                {
                    MessageBox.Show(error, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    lblSubtotal.Text = Convert.ToString(Math.Round(Convert.ToDecimal(row["Precio"]), 2) + Convert.ToDecimal(lblSubtotal.Text));
                    lblPrecio.Text = Convert.ToString(Convert.ToDecimal(lblSubtotal.Text) + Convert.ToDecimal(lblIva.Text));
                    button4.Enabled = false;
                    btnGenerar.Enabled = true;
                    btnRecurrente.Enabled = true;
                    btnBuscarArticulos.Focus();
                    gbCaracteristicas.Enabled = false;
                    gbDomicilio.Enabled = false;

                }
           
               
            }

        }


       
    

    }
}
