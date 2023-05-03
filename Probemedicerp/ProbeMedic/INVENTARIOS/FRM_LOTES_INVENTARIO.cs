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
    public partial class FRM_LOTES_INVENTARIO : FormaBase
    {
        public DataTable dtDetalle;
        SQLAlmacen sqlAlmacen = new SQLAlmacen();

        public Int32 K_Articulo_ { get; set; }
        public Int32 K_Oficina_ { get; set; }
        public FRM_LOTES_INVENTARIO()
        {
            InitializeComponent();
        }

        private void FRM_LOTES_INVENTARIO_Load(object sender, EventArgs e)
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
            BaseBotonExcel.Visible = false;
            BaseBotonReporte.Visible = false;
            BaseBotonBorrar.Visible = false;
            MtdCargaDetalle();
        }

        void MtdCargaDetalle()
        {
            dtDetalle = sqlAlmacen.Sk_Lotes_Inventario(Convert.ToInt32(K_Articulo_),Convert.ToInt32(K_Oficina_));

            if(dtDetalle!=null)
            {
                if(dtDetalle.Rows.Count>0)
                {
                    dtDetalle.DefaultView.Sort = "F_Caducidad ASC,Cantidad_Disponible ASC";
                    grdDatos.DataSource = dtDetalle;
                }
                
            }
                    
        }
    }
}
