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

namespace ProbeMedic.CATALOGOS.PRECIOS
{
    public partial class FRM_REPORTE_PRECIOS_RENTA : FormaBase
    {
        Funciones fx = new Funciones();
        SQLPrecios sQLPrecios = new SQLPrecios();
        DataTable excel = new DataTable();
        DataTable datos = new DataTable();
        DataTable datoss = new DataTable();
        
        public FRM_REPORTE_PRECIOS_RENTA()
        {
            InitializeComponent();
        }

        private void FFRM_REPORTE_PRECIOS_RENTA_Load(object sender, EventArgs e)
        {
            BaseBotonNuevo.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonReporte.Text = "Precios Actuales";
            BaseBotonReporte.Width = 120;
            BaseBotonExcel.Visible = true;
            BaseBotonGuardar.Visible = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonBuscar.Visible = false;

     
            datos.Columns.Add("K_Articulo", typeof(int));
            datos.Columns.Add("D_Articulo", typeof(string));
            datos.Columns.Add("Precio_Articulo", typeof(decimal));
            datos.Columns.Add("F_Alta", typeof(DateTime));
            datos.Columns.Add("SKU", typeof(string));

         
            llenaGrid();
        }

        public void llenaGrid()
        {
            datoss = sQLPrecios.Sk_Precios_Renta_Actual();

            if (datos != null)
            {
                foreach (DataRow irow in datoss.Rows)
                {
                    DataRow dtdRow = datos.NewRow();
                    dtdRow["K_Articulo"] = irow["K_Articulo"].ToString();
                    dtdRow["D_Articulo"] = irow["D_Articulo"].ToString();
                    dtdRow["Precio_Articulo"] = irow["Precio"].ToString();
                    dtdRow["F_Alta"] = irow["F_Ultima_Actualizacion"].ToString();
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
