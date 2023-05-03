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

namespace ProbeMedic.CATALOGOS.ARTICULOS
{
    public partial class FRM_REPORTE_PRECIOS_ACTUALESPROG : FormaBase
    {
        Funciones fx = new Funciones();
        SQLCatalogos sql_Catalogos = new SQLCatalogos();
        DataTable excel = new DataTable();
        DataTable datos = new DataTable();
        DataTable datoss = new DataTable();
        
        public FRM_REPORTE_PRECIOS_ACTUALESPROG()
        {
            InitializeComponent();
        }

        private void FRM_REPORTE_PRECIOS_ACTUALESPROG_Load(object sender, EventArgs e)
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

     
            datos.Columns.Add("K_Articulo", typeof(int));
            datos.Columns.Add("D_Articulo", typeof(string));
            datos.Columns.Add("K_Proveedor", typeof(int));
            datos.Columns.Add("D_Proveedor", typeof(string));
            datos.Columns.Add("Precio_Articulo", typeof(decimal));
            datos.Columns.Add("F_Alta", typeof(DateTime));
            datos.Columns.Add("SKU", typeof(string));

         
            llenaGrid();
        }

        public void llenaGrid()
        {
            datoss = sql_Catalogos.Sk_Proveedores_Articulos();

            if (datos != null)
            {
                foreach (DataRow irow in datoss.Rows)
                {
                    DataRow dtdRow = datos.NewRow();
                    dtdRow["K_Articulo"] = irow["K_Articulo"].ToString();
                    dtdRow["D_Articulo"] = irow["D_Articulo"].ToString();
                    dtdRow["K_Proveedor"] = irow["K_Proveedor"].ToString();
                    dtdRow["D_Proveedor"] = irow["D_Proveedor"].ToString();
                    dtdRow["Precio_Articulo"] = irow["Precio_Articulo"].ToString();
                    dtdRow["F_Alta"] = irow["F_Alta"].ToString();
                    dtdRow["SKU"] = irow["SKU"].ToString();
        
                    datos.Rows.Add(dtdRow);
                }
                dgvPreciosActuales.DataSource = datos;
                dgvPreciosActuales.CurrentCell.Selected = false;
            }
        }

        public override void BaseBotonExcelClick()
        {
            if (BaseDtDatos == null)
            {
                MessageBox.Show("NO EXISTE INFORMACION PARA EXPORTAR...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Archivos Excel (*.xlsx)|*.xlsx";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string Hoja = "Datos";
                DataTable dtExcel = datos;
                BorraColumnaCamposBusqueda(ref dtExcel);
                fx.ExportToExcel(dtExcel, saveFileDialog1.FileName, Hoja);
            }
            
        }
    }
}
