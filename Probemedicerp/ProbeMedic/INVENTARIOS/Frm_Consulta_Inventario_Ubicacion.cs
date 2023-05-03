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
    public partial class Frm_Consulta_Inventario_Ubicacion : FormaBase
    {
        public int p_K_Almacen { get; set; }
        public string p_D_Almacen { get; set; }
        public int p_K_Oficina { get; set; }
        public string p_D_Oficina { get; set; }
        public int p_K_Articulo { get; set; }
        public string p_D_Articulo { get; set; }

        SQLVentas sql_ventas = new SQLVentas();

        DataTable dtEncabezado = new DataTable();
        public Frm_Consulta_Inventario_Ubicacion()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            BaseBotonAfectar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonReporte.Visible = false;
            BaseBotonCancelar.Visible = false;

            txtAlmacen.Text = p_D_Almacen.ToString();
            txtOficina.Text = p_D_Oficina.ToString();
            txtArticulo.Text = p_D_Articulo.ToString();

            MtdCargaResultado();
        }
        void MtdCargaResultado()
        {
     
            dtEncabezado = sql_ventas.Sk_Inventario_Ubicacion(p_K_Oficina, p_K_Almacen, p_K_Articulo, cbxSinUbicacion.Checked, cbxCompleta.Checked);

            if (dtEncabezado != null)
            {
                dtEncabezado.DefaultView.Sort = "F_Caducidad ASC";
                LblSaldoDisponible.Text = "0";

                try
                {
                    var x = dtEncabezado.AsEnumerable().Select(r => Convert.ToInt32(r.Field<Int32>("Cantidad_Disponible"))).Sum();
                    if (x.ToString() != "")
                    {
                        if (x != 0)
                        {
                            LblSaldoDisponible.Text = x.ToString("N0").Trim();
                        }
                     
                    }
                }
                catch
                {

                    LblSaldoDisponible.Text = "0";

                }
                grdDetalle.DataSource = dtEncabezado;
                grdDetalle.CurrentCell.Selected = false;
            }
            else
            {
                DataTable dt = (DataTable)grdDetalle.DataSource;
                dt.Clear();
            }

        }

        private void cbxCompleta_CheckedChanged(object sender, EventArgs e)
        {
            MtdCargaResultado();
        }

        private void cbxSinUbicacion_CheckedChanged(object sender, EventArgs e)
        {
            MtdCargaResultado();
        }
    }
}
