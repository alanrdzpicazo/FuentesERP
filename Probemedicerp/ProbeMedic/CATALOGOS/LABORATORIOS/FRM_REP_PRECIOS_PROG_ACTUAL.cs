using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProbeMedic.AppCode.BLL;
using System.Windows.Forms;

namespace ProbeMedic.CATALOGOS.LABORATORIOS
{
    public partial class FRM_REP_PRECIOS_PROG_ACTUAL : FormaBase
    {
        Funciones fx = new Funciones();
        SQLPrecios sql_Precios = new SQLPrecios();
        DataTable excel = new DataTable();
        public DataTable datos = new DataTable();
        DataTable datoss = new DataTable();
        public FRM_REP_PRECIOS_PROG_ACTUAL()
        {
            InitializeComponent();
        }

        private void FRM_REP_PRECIOS_PROG_ACTUAL_Load(object sender, EventArgs e)
        {
            BaseBotonNuevo.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonReporte.Visible = false;
            BaseBotonExcel.Visible = true;
            BaseBotonGuardar.Visible = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonBuscar.Visible = false;

            datos.Columns.Add("K_Programa", typeof(int));
            datos.Columns.Add("D_Programa", typeof(string));
            datos.Columns.Add("K_Articulo", typeof(int));
            datos.Columns.Add("D_Articulo", typeof(string));
            datos.Columns.Add("K_Aseguradora", typeof(int));
            datos.Columns.Add("D_Aseguradora", typeof(string));
            datos.Columns.Add("K_Laboratorio", typeof(int));
            datos.Columns.Add("D_Laboratorio", typeof(string));
            datos.Columns.Add("Precio", typeof(decimal));
            datos.Columns.Add("F_Ultima_Actualizacion", typeof(DateTime)); 
        }

        public void llenaGrid()
        {
            datoss = sql_Precios.Sk_Programas_Articulos_Precios_Actual();
            if (datos != null)
            {
                if(datos.Rows.Count>0)
                {
                    foreach (DataRow irow in datoss.Rows)
                    {
                        DataRow dtdRow = datos.NewRow();
                        dtdRow["K_Programa"] = irow["K_Programa"].ToString();
                        dtdRow["D_Programa"] = irow["D_Programa"].ToString();
                        dtdRow["K_Articulo"] = irow["K_Articulo"].ToString();
                        dtdRow["D_Articulo"] = irow["D_Articulo"].ToString();
                        dtdRow["K_Aseguradora"] = irow["K_Aseguradora"].ToString();
                        dtdRow["D_Aseguradora"] = irow["D_Aseguradora"].ToString();
                        dtdRow["K_Laboratorio"] = irow["K_Laboratorio"].ToString();
                        dtdRow["D_Laboratorio"] = irow["D_Laboratorio"].ToString();
                        dtdRow["Precio"] = irow["Precio"].ToString();
                        dtdRow["F_Ultima_Actualizacion"] = irow["F_Ultima_Actualizacion"].ToString();

                        datos.Rows.Add(dtdRow);
                    }
                    dgvPreciosActuales.DataSource = datos;
                    BaseDtDatos = datos;
                    dgvPreciosActuales.CurrentCell.Selected = false;
                }
             
            }
        }
    }
}
