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
    public partial class Frm_ConsultaArticulosReservados : FormaBase
    {
        SQLAlmacen sqlAlmacen = new SQLAlmacen();

        public Int32 K_Articulo_ { get; set; }
        public Int32 K_Oficina_ { get; set; }
        public Int32 K_Almacen_ { get; set; }

        public Frm_ConsultaArticulosReservados()
        {
            InitializeComponent();
            grdDatos.AutoGenerateColumns = false;
        }

        private void Frm_ConsultaArticulosReservados_Load(object sender, EventArgs e)
        {
            MtdCargaDetalle();
        }
        public override void BaseMetodoInicio()
        {
            BaseBotonAfectar.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonReporte.Visible = false;
            BaseBotonBorrar.Visible = false;
            MtdCargaDetalle();
        }

        void MtdCargaDetalle()
        {
            BaseDtDatos = sqlAlmacen.Gp_ArticulosReservadosInventario( Convert.ToInt32(K_Oficina_),Convert.ToInt32(K_Articulo_), Convert.ToInt32(K_Almacen_));

            if (BaseDtDatos != null)
            {
                if (BaseDtDatos.Rows.Count > 0)
                {
                    grdDatos.DataSource = BaseDtDatos;
                }

            }

        }

    }
}
