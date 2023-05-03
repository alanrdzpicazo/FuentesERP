using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProbeMedic.AppCode.DCC;
//ME PERMITEN IMPORTAR DE EXCEL A C#
using System.Data.OleDb;

namespace ProbeMedic.CATALOGOS.ARTICULOS
{
    public partial class FRM_EXCEL_PRECIOS_ARTICULOS_PROVEEDOR : FormaBase
    {
        OleDbConnection conn;
        OleDbDataAdapter MyDataAdapter;
        DataTable dt;

        DataTable DT_Carga_PreciosProveedor = new DataTable();

        //public bool CargaCompleta=true;

        public FRM_EXCEL_PRECIOS_ARTICULOS_PROVEEDOR()
        {
            InitializeComponent();
            lblStatus.Text = "";
        }

        private void FRM_EXCEL_PRECIOS_ARTICULOS_PROVEEDOR_Load(object sender, EventArgs e)
        {
            BaseBotonNuevo.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonReporte.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonBuscar.Visible = true;
            BaseBotonBuscar.Enabled = true;
        }

        public bool Mtd_GP_Carga_PreciosProveedor(DataTable DT_Carga_PreciosProveedor)
        {
            try
            {
                if (DT_Carga_PreciosProveedor != null)
                {
                    foreach (DataRow irew in DT_Carga_PreciosProveedor.Rows)
                    {
                        sqlCatalogos.GP_Carga_PreciosProveedor(
                            Convert.ToInt32(irew["K_Proveedor"]),
                             irew["SKU"].ToString(),
                             Convert.ToDecimal(irew["Precio_Articulo"]),
                             txtRuta.Text, 
                             Convert.ToDateTime(irew["F_Actualizacion"]),
                             GlobalVar.K_Usuario,
                             Convert.ToDecimal(irew["Porcentaje_Descuento"]),
                             GlobalVar.PC_Name);
                    }
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        public override void BaseBotonBuscarClick()
        {

            Cursor = Cursors.WaitCursor;
            txtRuta.Text = importarExcel("Hoja1");
            if (dt != null)
            {
                if (Mtd_GP_Carga_PreciosProveedor(dt))
                {
                    lblStatus.Text = "Se cargaron los precios del archivo de Excel, si esta de acuerdo de click en Afectar para guardarlos";
                    lblStatus.ForeColor = Color.Blue;
                    lblStatus.BackColor = Color.Silver;
                    Cursor = Cursors.Default;
                    BaseBotonAfectar.Visible = true;
                    BaseBotonAfectar.Enabled = true;
                }
                else
                {
                    Cursor = Cursors.Default;
                    lblStatus.Text = "Ocurrió un problema al cargar el archvio de excel, verifique!";
                    lblStatus.ForeColor = Color.White;
                    lblStatus.BackColor = Color.Red;
                }
            }      
        }

        public override void BaseBotonAfectarClick()
        {
            String errores = "";
            try
            {
                sqlCatalogos.Gp_Sube_PreciosProvedor(GlobalVar.K_Usuario, GlobalVar.PC_Name);
            }
            catch (Exception ex)
            {
                errores += ex;
            }
            if (errores != "")
            {
                MessageBox.Show("Ocurrió un problema al subir los precios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                lblStatus.ForeColor = Color.White;
                lblStatus.BackColor = Color.Red;
            }
            else
            {
                MessageBox.Show("INFORMACION ACTUALIZADA CORRECTAMENTE ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblStatus.Text = "Información Actualizada Correctamente";
                BaseBotonAfectar.Visible = false;
                BaseBotonBuscar.Visible = false;
                lblStatus.ForeColor = Color.Blue;
                lblStatus.BackColor = Color.Silver;
            }

            
        }

        public string importarExcel(String nombreHoja)
        {
            String ruta = "";
            try
            {
                OpenFileDialog openfile1 = new OpenFileDialog();
                openfile1.Filter = "Excel Files |*.xlsx";
                openfile1.Title = "Seleccione el archivo de Excel";
                if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openfile1.FileName.Equals("") == false)
                    {
                        ruta = openfile1.FileName;
                    }
                }

                if (ruta.Length == 0)
                {
                    return null;
                }
                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=" + ruta + ";Extended Properties='Excel 12.0 Xml;HDR=Yes'");
                MyDataAdapter = new OleDbDataAdapter("Select * from [" + nombreHoja + "$] WHERE [SKU] <> ''", conn);
                dt = new DataTable();
                MyDataAdapter.Fill(dt);
                return ruta;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
    }
}
