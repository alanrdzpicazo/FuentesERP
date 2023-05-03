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
    public partial class Frm_Muestra_Articulos_Por_Caducar : FormaConsulta
    {
        SQLAlmacen sql_almacen = new SQLAlmacen();
        DataTable dtDatos = new DataTable();

        public Frm_Muestra_Articulos_Por_Caducar()
        {
            InitializeComponent();

        }

        public void LlenaDatos()
        {
            dgv_datos.DataSource = null;
            dtDatos = this.sql_almacen.Sk_MercanciaPorCaducar();

            if(dtDatos!=null)
            {
                if(dtDatos.Rows.Count>0)
                {                
                    dtDatos.DefaultView.Sort = "Fecha de caducidad ASC, Cantidad ASC";
                    BaseDtDatos = dtDatos;
                    dgv_datos.DataSource = dtDatos;
                    dgv_datos.Columns["Precio"].Visible = false;
                }
            }
              
       
        }

        private void Frm_Muestra_Articulos_Por_Caducar_Load(object sender, EventArgs e)
        {
            BaseBotonAfectar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonExcel.Visible = true;
            BaseBotonGuardar.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonReporte.Visible = false;
            BaseBotonCancelar.Visible = false;
        }
        public override void BaseBotonExcelClick()
        {
            Cursor = Cursors.WaitCursor;
            base.BaseBotonExcelClick();
            Cursor = Cursors.Default;
        }
    }
}
