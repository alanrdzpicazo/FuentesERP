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

namespace ProbeMedic.SERVICIOS
{
    public partial class FRM_GENERAR_SERVICIOS_AMBULANCIA : FormaBase
    {

        int KArticulo = 0;
        decimal PSubtotal = 0;
        decimal PIva = 0;
        decimal PPrecio = 0;
        decimal PPrecioPisoExtra = 0;

        int res = -1;

        string msg = string.Empty;

        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }

        Int32 K_Cliente = 0, _K_Precio_Ambulancia = 0;

        String D_Cliente = string.Empty;

        SQLPrecios sql_precios = new SQLPrecios();

        DataTable dtDatos = new DataTable();

        public FRM_GENERAR_SERVICIOS_AMBULANCIA()
        {
            InitializeComponent();
            grdDatos.MultiSelect = false;
            grdDatos.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            grdDatos.BackgroundColor = Color.White;
            grdDatos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 70, 209);
            grdDatos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grdDatos.EnableHeadersVisualStyles = false;
        }

        private void FRM_GENERAR_SERVICIOS_AMBULANCIA_Load(object sender, EventArgs e)
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

            dtDatos = Articulos_DetalleAmbulancia_Table;
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
            if (cbxSencillo.Checked == false && cbxOxigeno.Checked == false && cbxSegundoPiso.Checked == false)
            {
                MessageBox.Show("FALTA CAPTURAR LAS CARACTERISTICAS DEL SERVICIO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxSencillo.Focus();
                return false;
            }
           
            if (ucExtraeOficinaAmbulancia1.K_Pais == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL PAIS...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucExtraeOficinaAmbulancia1.txt_G_Pais.Focus();
                return false;
            }
            if (ucExtraeOficinaAmbulancia1.K_Estado == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL ESTADO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucExtraeOficinaAmbulancia1.txt_G_Estado.Focus();
                return false;
            }
            if (ucExtraeOficinaAmbulancia1.K_Ciudad == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA CIUDAD...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucExtraeOficinaAmbulancia1.txt_G_Ciudad.Focus();
                return false;
            }
            if (ucExtraeOficinaAmbulancia1.K_Colonia == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA COLONIA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucExtraeOficinaAmbulancia1.txt_G_Ciudad.Focus();
                return false;
            }
            if (ucExtraeOficinaAmbulancia1.K_Oficina == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA OFICINA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucExtraeOficinaAmbulancia1.txt_G_Oficina.Focus();
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
            cbxSencillo.Checked = false;
            cbxOxigeno.Checked = false;
            cbxSegundoPiso.Checked = false;
            cbxExtra.Checked = false;
            cbxPeso.Checked = false;
            ucExtraeOficinaAmbulancia1.K_Pais = 0;
            ucExtraeOficinaAmbulancia1.txt_G_Pais.Text = string.Empty;
            ucExtraeOficinaAmbulancia1.K_Pais = 0;
            ucExtraeOficinaAmbulancia1.txt_G_Estado.Text = string.Empty;
            ucExtraeOficinaAmbulancia1.K_Estado = 0;
            ucExtraeOficinaAmbulancia1.txt_G_Ciudad.Text = string.Empty;
            ucExtraeOficinaAmbulancia1.K_Ciudad = 0;
            ucExtraeOficinaAmbulancia1.txt_G_Colonia.Text = string.Empty;
            ucExtraeOficinaAmbulancia1.K_Colonia = 0;
            ucExtraeOficinaAmbulancia1.txt_G_Oficina.Text = string.Empty;
            ucExtraeOficinaAmbulancia1.K_Oficina = 0;
            ucExtraeOficinaAmbulancia2.K_Pais = 0;
            ucExtraeOficinaAmbulancia2.txt_G_Pais.Text = string.Empty;
            ucExtraeOficinaAmbulancia2.K_Estado = 0;
            ucExtraeOficinaAmbulancia2.txt_G_Estado.Text = string.Empty;
            ucExtraeOficinaAmbulancia2.K_Ciudad = 0;
            ucExtraeOficinaAmbulancia2.txt_G_Ciudad.Text = string.Empty;
            ucExtraeOficinaAmbulancia2.K_Colonia = 0;
            ucExtraeOficinaAmbulancia2.txt_G_Colonia.Text = string.Empty;
            ucExtraeOficinaAmbulancia2.K_Oficina = 0;
            ucExtraeOficinaAmbulancia2.txt_G_Oficina.Text = string.Empty;
            txtCalle.Text = string.Empty;
            txtCalleRecoge.Text = string.Empty;
            btnGuardar.Enabled = false;
            btnRecurrente.Enabled = false;
            PPrecioPisoExtra = 0;
            cbxExtra.Enabled = false;
            _K_Precio_Ambulancia = 0;
            BaseMetodoInicio();
            btnBuscarCliente.Focus();
            lblPrecio.Text = "0.000";

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FILTROS.Frm_Filtra_Cliente filtra = new FILTROS.Frm_Filtra_Cliente(GlobalVar.K_Empresa);
            filtra.ShowDialog();
            K_Cliente = filtra.K_Cliente_Seleccionado;
            D_Cliente = filtra.D_Cliente_Seleccionado;
            txtCliente.Text = Convert.ToString(D_Cliente);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!BaseFuncionValidaciones())
                return;
            BuscaPreciosAmbulancia(cbxSencillo.Checked, ucExtraeOficinaAmbulancia1.B_Local, cbxOxigeno.Checked, cbxSegundoPiso.Checked);
            
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

            res = sql_precios.In_Servicios_ContratadosAmb(ref CampoIdentity,
                K_Cliente,
                ucExtraeOficinaAmbulancia1.K_Oficina,
                ucExtraeOficinaAmbulancia1.K_Pais,
                ucExtraeOficinaAmbulancia1.K_Estado,
                ucExtraeOficinaAmbulancia1.K_Ciudad,
                ucExtraeOficinaAmbulancia1.K_Colonia,
                txtCalle.Text,
                ucExtraeOficinaAmbulancia1.B_Local,
                Convert.ToDecimal(lblPrecio.Text),
                F_Servicio,
                cbxSencillo.Checked,
                cbxOxigeno.Checked,
                cbxSegundoPiso.Checked,
                cbxExtra.Checked,
                cbxPeso.Checked,
                _K_Precio_Ambulancia,
                ucExtraeOficinaAmbulancia2.K_Pais,
                ucExtraeOficinaAmbulancia2.K_Estado,
                ucExtraeOficinaAmbulancia2.K_Ciudad,
                ucExtraeOficinaAmbulancia2.K_Colonia,
                txtCalle.Text,
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

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            BaseMetodoLimpiaControles();
            btnCalcular.Enabled = true;
            dtDatos.Rows.Clear();
            grdDatos.DataSource = dtDatos;
            lblSubtotal.Text = string.Empty;
            lblIva.Text = string.Empty;
            lblPrecio.Text = string.Empty;
            lblSubtotal.Text = "0.000";
            lblIva.Text = "0.000";
            lblPrecio.Text = "0.000";
            gbCaracteristicas.Enabled = true;
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

            res = sql_precios.In_Servicios_RecurrentesAmbulancia(ref CampoIdentity,
                K_Cliente,
                ucExtraeOficinaAmbulancia1.K_Oficina,
                ucExtraeOficinaAmbulancia1.K_Pais,
                ucExtraeOficinaAmbulancia1.K_Estado,
                ucExtraeOficinaAmbulancia1.K_Ciudad,
                ucExtraeOficinaAmbulancia1.K_Colonia,
                ucExtraeOficinaAmbulancia1.B_Local,
                Convert.ToDecimal(lblPrecio.Text),
                F_Servicio,
                cbxSencillo.Checked,
                cbxOxigeno.Checked,
                cbxSegundoPiso.Checked,
                _K_Precio_Ambulancia,
                cbxExtra.Checked,
                cbxPeso.Checked,
                F_Inicio_Servicio,
                F_Fin_Servicio,
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

        private void cbxSegundoPiso_CheckedChanged(object sender, EventArgs e)
        {
          
            if(cbxSegundoPiso.Checked == true)
            {
                cbxExtra.Enabled = true;
            }
          
            if (cbxSegundoPiso.Checked == false)
            {
                if(cbxExtra.Checked == true)
                {
                    cbxExtra.Checked = false;
                }
                cbxExtra.Enabled= false;
            }
            
        }

        private void cbxExtra_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxExtra.Checked == false && cbxSegundoPiso.Checked == false)
            {
                cbxSegundoPiso.Checked = true;
            }

        }

        private void btnBuscarArticulos_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Articulos_SOS frm = new Busquedas.Frm_Busca_Articulos_SOS();
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
            dr["Precio"] = PSubtotal;
            dr["Cantidad"] = Convert.ToDecimal(txtCantidad.Text);
            dr["Total"] = Convert.ToDecimal(PSubtotal * Convert.ToDecimal(txtCantidad.Text)) + Convert.ToDecimal(txtCantidad.Text) * (PIva);
            dr["Subtotal"] = PSubtotal * Convert.ToDecimal(txtCantidad.Text);
            dr["Iva"] = Math.Round(PIva * Convert.ToDecimal(txtCantidad.Text), 2);
         
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


        //ME BUSCA LOS PRECIOS DE ENFERMERIA DE ACUERDO A LAS CARACTERISTICAS SOLICITADAS
        public void BuscaPreciosAmbulancia(bool B_Sencillo, bool B_Local, bool B_Oxigeno, bool B_Segundo_Piso)
        {

            DataTable datos = new DataTable();

            datos = sql_precios.GP_Valida_PreciosAmbulancia(cbxSencillo.Checked, ucExtraeOficinaAmbulancia1.B_Local, cbxOxigeno.Checked, cbxSegundoPiso.Checked);
            if (datos == null)
            {
                MessageBox.Show("NO SE ENCONTRO INFORMACION...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                datos.Clear();
                return;
            }
            if (datos.Rows.Count > 0)
            {
                DataRow row = datos.Rows[0];

                _K_Precio_Ambulancia = Convert.ToInt32(row["K_Precio_Ambulancia"].ToString());

                string error = Convert.ToString(row["Error"].ToString());

                if (error != "")
                {
                    MessageBox.Show(error, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    CalculaPrecioServicio();
                }
            }

        }

        private void cbxSencillo_CheckedChanged(object sender, EventArgs e)
        {
        }

        //CALCULA EL PRECIO TOMANDO COMO PARAMETROS EL DOMICILIO Y EL PRECIO DE AMBULANCIA
        public void CalculaPrecioServicio()
        {

            DataTable datos = new DataTable();

            datos = sql_precios.GP_Extrae_Precio_Ambulancias(Convert.ToBoolean(ucExtraeOficinaAmbulancia1.B_Local), K_Cliente,
                    ucExtraeOficinaAmbulancia1.K_Oficina, ucExtraeOficinaAmbulancia1.K_Pais, ucExtraeOficinaAmbulancia1.K_Estado, ucExtraeOficinaAmbulancia1.K_Ciudad, ucExtraeOficinaAmbulancia1.K_Colonia, _K_Precio_Ambulancia);

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
                    if(cbxExtra.Checked == true)
                    {
                        DataTable dtTercerPiso = sqlCatalogos.Sk_Parametros_Generales();
                        PPrecioPisoExtra = Convert.ToDecimal(dtTercerPiso.Rows[0].ItemArray[5]);
                    }

                    lblSubtotal.Text = Convert.ToString(Math.Round(Convert.ToDecimal(row["Precio"]), 2) +PPrecioPisoExtra+ Convert.ToDecimal(lblSubtotal.Text));
                    lblPrecio.Text = Convert.ToString(Convert.ToDecimal(lblSubtotal.Text) + Convert.ToDecimal(lblIva.Text));
                    btnCalcular.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnRecurrente.Enabled = true;
                    gbCaracteristicas.Enabled = false;
                    gbdestino.Enabled = false;
                    gbRecoge.Enabled = false;
                    btnBuscarArticulos.Focus();
                }
            }

        }


    }
}
