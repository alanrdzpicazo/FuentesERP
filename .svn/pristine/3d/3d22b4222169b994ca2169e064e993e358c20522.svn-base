using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;
using System.Configuration;
using System.IO;

namespace ProbeMedic.CXP
{
    public partial class Frm_Recepciones_Error : FormaBase
    {

        SQLCatalogos sqlCatalogos = new SQLCatalogos();
        SQLCuentasxPagar sqlCXP = new SQLCuentasxPagar();
        int res = 0;
        string msg = string.Empty;
        DataTable dtDatos = new DataTable();
        DataTable dtRecepciones = new DataTable();

        public Frm_Recepciones_Error()
        {
         
            BaseGridSinFormato = true;
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            
            try
            {
                LlenaCombo(GlobalVar.dtTipoMoneda, ref cmbTipoMoneda, "K_Tipo_Moneda", "D_Tipo_Moneda");

                           grdDetalle.AutoGenerateColumns = false;
                grdRecepciones.AutoGenerateColumns = false;


                int var_mesActual = DateTime.Now.Month; // obtengo el mes actual
                int var_anio = DateTime.Now.Year; // obtengo el año actual
                int var_mesSiguiente = DateTime.Now.Month +1; // obtengo el mes siguiente
                txtFechaInicio.Value = Convert.ToDateTime("01/" + var_mesActual + "/" + var_anio);// pongo el 1 porque siempre es el primer día obvio

                txtFechaFin.Value = Convert.ToDateTime("01/" + var_mesSiguiente + "/" + var_anio).AddDays(-1); //resto un día al mes y con esto obtengo el ultimo día

                

                BuscaRecepciones();

                //LlenaRecepciones();

                base.BaseMetodoInicio();
                //BaseBotonBuscar.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public override void BaseBotonBuscarClick()
        {

            base.BaseBotonBuscarClick();

        }


        private void grdRecepciones_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = grdRecepciones.CurrentRow;
            if (row != null)
            {
                BasePropiedadId_Identity = Convert.ToInt32(row.Cells[0].Value);
                MostrarDetalle(BasePropiedadId_Identity);
            }
        }
        private void txtFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            BuscaRecepciones();
        }
        private void txtFechaFin_ValueChanged(object sender, EventArgs e)
        {
            BuscaRecepciones();
        }
        private void txtProveedor_TextChanged(object sender, EventArgs e)
        {
            //if (txtProveedor.Text.Trim() == "")
            //{
                //txtProveedor.Text = "";
                LlenaRecepciones();

                //BuscaRecepciones();
            //}
            //else
            //{ 
                
            //}
            
        }
        
        private void cmbTipoMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
        
                BuscaRecepciones();
        
        }
        
        private void BuscaRecepciones()
        {
            try
            {
            int K_Tipo_Moneda = 0;
            if (cmbTipoMoneda.SelectedValue != null)
            {
                if (cmbTipoMoneda.SelectedValue.ToString().Trim() != "System.Data.DataRowView")
                    {
                K_Tipo_Moneda = Convert.ToInt32(cmbTipoMoneda.SelectedValue);
                }
            }

            string D_Proveedor = "";
            if (txtProveedor.Text.Trim().Length > 0)
                D_Proveedor = txtProveedor.Text;

            dtRecepciones = sqlCXP.Sk_RecepcionesError_XML(Convert.ToDateTime(txtFechaInicio.Text), Convert.ToDateTime(txtFechaFin.Text), "", K_Tipo_Moneda);
            BasePropiedadCampoClave = "K_Operacion_Error";

            BaseDtDatos = dtRecepciones;
            LlenaRecepciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LlenaRecepciones()
        {
            if (dtRecepciones != null)
            {
                DataTable dt = new DataTable();
                try
                {
                    var res = from c in dtRecepciones.AsEnumerable()
                              select c;
                    res = res.Where(o => o.Field<string>("NombreEmisor").Contains(txtProveedor.Text));
                    if (res.Any())
                    {
                        dt = res.CopyToDataTable();

                    }
                }
                finally
                {
                    grdRecepciones.DataSource = dt;
                }
            }
            else
            {
                grdRecepciones.DataSource = null;
                grdDetalle.DataSource = null;

            }
           


        }
        public void MostrarDetalle(int K_Requisicion)
        {
            dtDatos = DetalleRecepciones_Type;
            //dtDatos.Columns.Add("D_Articulo", typeof(string));


            DataTable dtDetalle = sqlCXP.Sk_RecepcionesDetalleError_XML(BasePropiedadId_Identity);
            foreach (DataRow row in dtDetalle.Rows)
            {
                dtDatos.ImportRow(row);
            }

            grdDetalle.DataSource = dtDatos;
        }

        private void Frm_Recepciones_Error_Load(object sender, EventArgs e)
        {

        }
    }
}
