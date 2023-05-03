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

namespace ProbeMedic.SERVICIOS
{
    public partial class FRM_SERV_CONT_ENF_DETALLE : FormaBase
    {
        public String NoServicio { get; set; }
        public DataTable dtDetalle = new DataTable();
        DataTable dtDatos = new DataTable();
        SQLVentas sqlventas = new SQLVentas();

        public decimal Total_Iva = 0;
        int KArticulo = 0;
        decimal PSubtotal = 0;
        decimal PIva = 0;
        decimal PPrecio = 0;

        bool B_Existe = false;

        public Decimal PPrecio_Servicio { get; set; }

        int res = -1;
        string msg = string.Empty;

        public FRM_SERV_CONT_ENF_DETALLE()
        {
            InitializeComponent();
        }

        private void FRM_SERV_CONT_ENF_DETALLE_Load(object sender, EventArgs e)
        {

        }

        public override void BaseMetodoInicio()
        {
            BaseBotonAfectar.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonReporte.Visible = false;
            BaseBotonBorrar.Visible = false;
            txtNoServicio.Text = NoServicio;
            MtdCargaDetalle();
            dtDatos = Articulos_DetalleEnfermeria_Table;
        }

        void MtdCargaDetalle()
        {
            dtDetalle = sqlventas.SK_Detalle_ArticulosEnfermeria(Convert.ToInt32(NoServicio));

            if (dtDetalle != null)
            {
                foreach (DataColumn col in dtDetalle.Columns)
                {
                    col.ReadOnly = false;

                }
                dtDetalle.AcceptChanges();
                grdDatos.DataSource = dtDetalle;

                //Calculamos el IVA de todos los artículos
                var x = dtDetalle.AsEnumerable().Select(r => Convert.ToDecimal(r.Field<Decimal>("Total_Iva"))).Sum();
             
                //Calculamos el SUBTOTAL de todos los artículos
                var z = dtDetalle.AsEnumerable().Select(r => Convert.ToDecimal(r.Field<Decimal>("Subtotal"))).Sum();           

                //Calculamos el TOTAL del pedido
                decimal totalPedido = x + z;

                PPrecio_Servicio = Convert.ToDecimal(dtDetalle.Rows[0].ItemArray[8].ToString()) - totalPedido;
                lblSubtotal.Text = PPrecio_Servicio.ToString() ;
                lblPrecio.Text = PPrecio_Servicio.ToString();

                Mtd_Calcula_Totales();

                BaseBotonAfectar.Visible = true;
                BaseBotonAfectar.Enabled = true;
            }
            else
            {
                BaseBotonAfectar.Visible = false;
                BaseBotonAfectar.Enabled = false;
            }
        }

        private void Chk_Modificar_CheckedChanged(object sender, EventArgs e)
        {
            if(Chk_Modificar.Checked == true)
            {
                panel5.Enabled = true;
                panel7.Enabled = true;
                panel8.Enabled = true;
                this.grdDatos.Enabled = true;
            }
            else
            {
                panel5.Enabled = false;
                panel7.Enabled = false;
                panel8.Enabled = false;
                this.grdDatos.Enabled = false;
            }
          
        }

        private void grdDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdDatos.Columns[e.ColumnIndex].Name == "Mas")
            {
                Mtd_Incrementar(sender, e);

            }
            else if (grdDatos.Columns[e.ColumnIndex].Name == "Menos")
            {
                Mtd_Disminuir(sender, e);
            }
        }

        public void Mtd_Incrementar(object sender, DataGridViewCellEventArgs e)
        {
            dtDetalle.AsEnumerable().ToList<DataRow>().ForEach(r => {
                if (dtDetalle.Rows[e.RowIndex] == r)

                r["Cantidad"] = int.Parse(r["Cantidad"].ToString()) + 1;
                r["Subtotal"] = decimal.Parse(r["Cantidad"].ToString()) * decimal.Parse(r["Precio"].ToString());
                r["Total_Iva"] = decimal.Parse(r["Subtotal"].ToString()) * Convert.ToDecimal((0 + (decimal.Parse(r["Iva"].ToString()) / 100)));
                r["Total"] = decimal.Parse(r["Subtotal"].ToString()) + (decimal.Parse(r["Subtotal"].ToString())  *Convert.ToDecimal((0 + (decimal.Parse(r["Iva"].ToString()) / 100))));

            });

            Mtd_Calcula_Totales();

            grdDatos.DataSource = dtDetalle;
        }

        public void Mtd_Disminuir(object sender, DataGridViewCellEventArgs e)
        {
            dtDetalle.AsEnumerable().ToList<DataRow>().ForEach(r => {
                if (dtDetalle.Rows[e.RowIndex] == r)

                r["Cantidad"] = int.Parse(r["Cantidad"].ToString()) - 1;
                r["Subtotal"] = decimal.Parse(r["Cantidad"].ToString()) * decimal.Parse(r["Precio"].ToString());
                r["Total_Iva"] = decimal.Parse(r["Subtotal"].ToString()) * Convert.ToDecimal((0 + (decimal.Parse(r["Iva"].ToString()) / 100)));
                r["Total"] = decimal.Parse(r["Subtotal"].ToString()) + (decimal.Parse(r["Subtotal"].ToString()) *Convert.ToDecimal((0 + (decimal.Parse(r["Iva"].ToString()) / 100))));
                if (int.Parse(r["Cantidad"].ToString()) == 0)
                {
                    dtDetalle.Rows[e.RowIndex].Delete();
                   
                }
            });

            dtDetalle.AcceptChanges();

            Mtd_Calcula_Totales();

            grdDatos.DataSource = dtDetalle;
        }
        void Mtd_Calcula_Totales()
        {
            //Calculamos el IVA de todos los artículos
            if (dtDetalle.Rows.Count ==0)
            {
                lblIva.Text = Math.Round(0.00, 2).ToString("N2").Trim();
                lblSubtotal.Text = Math.Round(PPrecio_Servicio, 2).ToString("N2").Trim();
                lblPrecio.Text = Math.Round(Convert.ToDecimal(lblIva.Text) + Convert.ToDecimal(lblSubtotal.Text), 2).ToString("N2");
                return;
            }         
            var x = dtDetalle.AsEnumerable().Select(r => Convert.ToDecimal(r.Field<Decimal>("Total_Iva"))).Sum();
            if (x.ToString() != "")
            {
                if (x >= 0)
                {
                    lblIva.Text = Math.Round(x, 2).ToString("N2").Trim();
                }
            }

            //Calculamos el SUBTOTAL de todos los artículos
            var z = dtDetalle.AsEnumerable().Select(r => Convert.ToDecimal(r.Field<Decimal>("Subtotal"))).Sum();
            if (z.ToString() != "")
            {
                if (z >= 0)
                {
                    z = PPrecio_Servicio + z;
                    lblSubtotal.Text =Math.Round(z, 2).ToString("N2").Trim();
                }
            }

            //Calculamos el TOTAL del pedido
            decimal totalPedido = x + z;
            lblPrecio.Text = Math.Round(totalPedido, 2).ToString("N2");

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

            foreach(DataRow row in dtDetalle.Rows)
            {
                if (Convert.ToInt32(row["K_Articulo"].ToString()) == KArticulo )
                {
                    //row["Cantidad"] = Convert.ToInt32(row["Cantidad"].ToString()) + Convert.ToInt32(txtCantidad.Text);
                    B_Existe = true;

                    dtDetalle.AsEnumerable().ToList<DataRow>().ForEach(r => {

                            r["Cantidad"] = int.Parse(r["Cantidad"].ToString()) + int.Parse(txtCantidad.Text);
                        r["Subtotal"] = decimal.Parse(r["Cantidad"].ToString()) * decimal.Parse(r["Precio"].ToString());
                        r["Total_Iva"] = decimal.Parse(r["Subtotal"].ToString()) * Convert.ToDecimal((0 + (decimal.Parse(r["Iva"].ToString()) / 100)));
                        r["Total"] = decimal.Parse(r["Subtotal"].ToString()) + (decimal.Parse(r["Subtotal"].ToString()) * Convert.ToDecimal((0 + (decimal.Parse(r["Iva"].ToString()) / 100))));

                    });

                    Mtd_Calcula_Totales();

                    grdDatos.DataSource = dtDetalle;
                    break;
                }

            }


            if (B_Existe == false)
            {

                DataRow dr;
                dr = dtDetalle.NewRow();

                dr["K_Articulo"] = KArticulo;
                dr["D_Articulo"] = txtArticulo.Text;
                dr["Precio"] = PSubtotal;
                dr["Cantidad"] = Convert.ToDecimal(txtCantidad.Text);
                dr["Subtotal"] = PSubtotal * Convert.ToDecimal(txtCantidad.Text);
                dr["Iva"] = PIva;
                dr["Total"] = Convert.ToDecimal(PSubtotal * Convert.ToDecimal(txtCantidad.Text)) + Convert.ToDecimal(txtCantidad.Text) * (PIva);
                dr["Total_Iva"] = Math.Round(PIva * Convert.ToDecimal(txtCantidad.Text), 2);
                dr["Precio_Servicio"] = Math.Round(PPrecio_Servicio, 2);

                subtotal = Math.Round(subtotal, 2);
                iva = Math.Round(iva, 2);
                total = Math.Round(total, 2);

                lblSubtotal.Text = subtotal.ToString();
                lblIva.Text = iva.ToString();
                lblPrecio.Text = total.ToString();

                dtDetalle.Rows.Add(dr);
            }

            grdDatos.DataSource = dtDetalle;

            txtArticulo.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            KArticulo = 0;
            btnBuscarArticulos.Focus();
        }

        public override void BaseBotonAfectarClick()
        {
           
            msg = string.Empty;

            DataTable dtDatos = dtDetalle.Copy();
            dtDatos.Columns.Remove("Subtotal");
            dtDatos.Columns.Remove("Iva");
            dtDatos.Columns.Remove("Total_Iva");
            dtDatos.Columns.Remove("Precio_Servicio");
            res = sqlventas.Gp_Up_Servicios_Contratados_Enfermeria(             
                Convert.ToInt32(txtNoServicio.Text.Trim()),
                Convert.ToDecimal(lblPrecio.Text.Trim()),
                dtDatos,
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
                BaseMetodoInicio();
              
            }
        }

    }
}
