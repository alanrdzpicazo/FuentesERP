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
using ProbeMedic.AppCode.DCC;
using System.Data.OleDb;
using System.IO;

namespace ProbeMedic.PRECIOS
{
    public partial class FRM_EXCEL_PRECIOS_ARTICULOS_PROVEEDOR : FormaBase
    {
        SQLPrecios SqlPrecios = new SQLPrecios();
        DataTable dt = new DataTable();
        string Hoja = string.Empty, Error = string.Empty;
        int res = -1;
        int i = 0;

        bool b_abierto = false;

        public FRM_EXCEL_PRECIOS_ARTICULOS_PROVEEDOR()
        {
            InitializeComponent();
        }

        private void FRM_EXCEL_PRECIOS_ARTICULOS_PROVEEDOR_Load(object sender, EventArgs e)
        {
            lblTiempo1.Invoke((MethodInvoker)delegate
            {

                lblTiempo1.Visible = false;

            });
            TxtRuta.Invoke((MethodInvoker)delegate
            {

                TxtRuta.Text = string.Empty;

            });
        }

        public override void BaseMetodoInicio()
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
            BtnValidar.Enabled = false;
            BtnValidar.Visible = false;
        }

        public override void BaseBotonGuardarClick()
        {
            if (BaseBotonBuscar.Enabled)
                BaseBotonBuscar.Enabled = false;
            backFile2.RunWorkerAsync();
        }

        public override void BaseBotonBuscarClick()
        {
            openFile.Filter = "Excel Files |*.xlsx";
            openFile.Title = "Seleccione el archivo de Excel";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                TxtRuta.Text = openFile.FileName;
            }
        }

        private void TxtRuta_TextChanged(object sender, EventArgs e)
        {
            if (TxtRuta.Text.Length > 0)
            {
                BtnValidar.Visible = true;
                BtnValidar.Enabled = true;
            }
        }

        private void BtnValidar_Click(object sender, EventArgs e)
        {
            BtnValidar.Visible = false;
            BaseBotonBuscar.Enabled = false;
            TxtRuta.Text = string.Empty;
            backFile.RunWorkerAsync();
        }

        private void backFile_DoWork(object sender, DoWorkEventArgs e)
        {
            Boolean B_Error_valida = false;
            dt = new DataTable();
            try
            {
                List<string> Lista = new System.Collections.Generic.List<string>();
                Lista = ListSheetInExcel(openFile.FileName);
                Hoja = Lista[0];
                Hoja = Hoja.Substring(0, Hoja.Length - 1);
                dt = selectExcel(openFile.FileName, Hoja);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                backFile.ReportProgress(0);
                backFile.CancelAsync();
                BaseBarraHerramientas.Invoke((MethodInvoker)delegate
                {
                    BaseBotonBuscar.Enabled = true;
                    BaseBotonGuardar.Enabled = false;
                });
                return;
            }

            if (dt != null)
            {
                lblTiempo1.Invoke((MethodInvoker)delegate
                {
                    lblTiempo1.Text = "Cargando...";

                });
                lblTiempo1.Invoke((MethodInvoker)delegate
                {

                    lblTiempo1.Visible = true;

                });



                try
                {
                    backFile.ReportProgress(100);
                    lblTiempo1.Invoke((MethodInvoker)delegate
                    {
                        if (B_Error_valida == true)
                        {
                            lblTiempo1.Text = "Validación: Existe un error en al menos un registro, esta guia no se generará.";
                        }
                        else
                        {
                            lblTiempo1.Text = "Validación: Correcta";
                        }


                    });
                }
                catch { }
            }
            else
            {
                MessageBox.Show("EL ARCHIVO NO SE CARGO CORRECTAMENTE", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void backFile_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbarFiles.Value = e.ProgressPercentage;
        }

        private void backFile_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BaseBotonBuscar.Visible = true;
            BaseBotonBuscar.Enabled = true;
            if (b_abierto == false)
            {
                BtnValidar.Enabled = false;

                BaseBotonGuardar.Visible = false;
                BaseBotonGuardar.Enabled = false;
            }

        }

        private void backFile2_DoWork(object sender, DoWorkEventArgs e)
        {
            string pmsMsg = string.Empty;
            int res = 0;


            lblTiempo1.Invoke((MethodInvoker)delegate
            {

                lblTiempo1.Visible = false;
                BaseBotonBuscar.Enabled = false;
                BaseBotonGuardar.Enabled = false;

            });
            TxtRuta.Invoke((MethodInvoker)delegate
            {

                TxtRuta.Text = string.Empty;

            });

            backFile2.ReportProgress(0);

            lblTiempo1.Invoke((MethodInvoker)delegate
            {
                lblTiempo1.Visible = true;
                lblTiempo1.Text = "Cargando Artículos...";
            });

            try
            {
                int cont = 1;
                int prog = 1;
                int valor = 0;
                bool B_Error_Valida = false;
                foreach (DataRow row in dt.Rows)
                {
                    lblTiempo1.Invoke((MethodInvoker)delegate
                    {
                        lblTiempo1.Text = "Cargando Artículo " + cont + " de " + Convert.ToString(dt.Rows.Count - 1) + "...";
                        int total = dt.Rows.Count;

                        if (cont == (total / 100))
                        {
                            backFile2.ReportProgress(prog);
                            prog += 1;
                            valor = (total / 100) * 2;

                        }
                        else
                        {
                            if (cont == valor)
                            {
                                backFile2.ReportProgress(prog);
                                prog += 1;
                                valor = valor + (total / 100);
                            }
                        }



                    });
                    try
                    {
                        Int32 K_Proveedor = Convert.ToInt32(row["No# Proveedor"].ToString());
                    }
                    catch (Exception ex)
                    {
                        Error = "ERROR EN ARCHIVO CAMPO: ('No. Proveedor'), LINEA: (" + cont + ") VERIFIQUE EL ARCHIVO ANTES DE CONTINUAR!...";
                        //backFile.ReportProgress(0);
                        //backFile.CancelAsync();
                        B_Error_Valida = true;
                        break;
                    }
                    try
                    {
                        string SKU = row["SKU"].ToString();
                    }
                    catch (Exception ex)
                    {
                        Error = "ERROR EN ARCHIVO CAMPO: ('SKU'), LINEA: (" + cont + ") VERIFIQUE EL ARCHIVO ANTES DE CONTINUAR!...";
                        //backFile.ReportProgress(0);
                        //backFile.CancelAsync();
                        B_Error_Valida = true;
                        break;
                    }
                    try
                    {
                        decimal Precio_Articulo = Convert.ToDecimal(row["P# Unitario"].ToString());
                    }
                    catch (Exception ex)
                    {
                        Error = "ERROR EN ARCHIVO CAMPO: ('P. Unitario'), LINEA: (" + cont + ") VERIFIQUE EL ARCHIVO ANTES DE CONTINUAR!...";
                        //backFile.ReportProgress(0);
                        //backFile.CancelAsync();
                        B_Error_Valida = true;
                        break;
                    }
                    try
                    {
                        decimal Porcentaje_Descuento = Convert.ToDecimal(row["Porcentaje Descuento"].ToString());
                    }
                    catch (Exception ex)
                    {
                        Error = "ERROR EN ARCHIVO CAMPO: ('Porcentaje Descuento), LINEA: (" + cont + ") VERIFIQUE EL ARCHIVO ANTES DE CONTINUAR!...";
                        //backFile.ReportProgress(0);
                        //backFile.CancelAsync();
                        B_Error_Valida = true;
                        break;
                    }
                    string Archivo_Subio = TxtRuta.Text.Length > 0 ? TxtRuta.Text : "NO ESPECIFICADO";

                    Int32 K_Proveedor_Sube = Convert.ToInt32(row["No# Proveedor"].ToString());
                    string SKU_Sube = row["SKU"].ToString();
                    decimal Precio_Articulo_Sube = row["P# Unitario"].ToString() != "" ? Convert.ToDecimal(row["P# Unitario"].ToString()) : 0;
                    string Archivo_Subio_Sube = TxtRuta.Text.Length > 0 ? TxtRuta.Text : "NO ESPECIFICADO";
                    decimal Porcentaje_Descuento_Sube = row["Porcentaje Descuento"].ToString() != "" ? Convert.ToDecimal(row["Porcentaje Descuento"].ToString()) : 0;

                    res = SqlPrecios.Gp_Carga_ArticulosProvedor(K_Proveedor_Sube, SKU_Sube, Precio_Articulo_Sube, Archivo_Subio_Sube, Porcentaje_Descuento_Sube);

                    cont += 1;
                }

                if ((B_Error_Valida) && (Error.Length > 0))
                {
                    MessageBox.Show(Error.ToString());

                    lblTiempo1.Invoke((MethodInvoker)delegate
                    {
                        lblTiempo1.Visible = false;
                        lblTiempo1.Text = string.Empty;
                    });
                    backFile2.ReportProgress(0);
                    backFile2.CancelAsync();
                    return;
                }

                lblTiempo1.Invoke((MethodInvoker)delegate
                {
                    lblTiempo1.Visible = false;
                    lblTiempo1.Text = string.Empty;
                });

                lblTiempo1.Invoke((MethodInvoker)delegate
                {
                    lblTiempo1.Visible = true;
                    lblTiempo1.Text = "Subiendo precios, espere por favor...";
                });

                res = SqlPrecios.Gp_Sube_ArticulosProvedor();

                backFile2.ReportProgress(100);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                backFile2.ReportProgress(100);
                return;
            }

            lblTiempo1.Invoke((MethodInvoker)delegate
            {

                lblTiempo1.Text = "";

            });
            pbarFiles.Invoke((MethodInvoker)delegate
            {
                pbarFiles.Value = 0;
            });
        }

        private void backFile2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbarFiles.Value = e.ProgressPercentage;
        }

        private void backFile2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            MessageBox.Show("PROCESO FINALIZADO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BaseBotonGuardar.Visible = false;
            BaseBotonBuscar.Enabled = true;
        }

        public static DataTable selectExcel(string Arch, string Hoja)
        {
            Hoja = Hoja.Replace("'", "");
            if (Hoja.Substring(Hoja.Length - 1, 1) == "$")
            {
                Hoja = Hoja.Substring(0, Hoja.Length - 1);
            }
            OleDbConnection Conex = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Arch + ";Extended Properties=Excel 12.0;");
            //OleDbConnection Conex = new System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Arch + ";Extended Properties='Excel 8.0;HDR=NO;IMEX=1'");
            //OleDbConnection Conex = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Arch + ";Extended Properties=Excel 12.0;");
            OleDbCommand CmdOle = new OleDbCommand();

            CmdOle.Connection = Conex;
            CmdOle.CommandType = CommandType.Text;
            CmdOle.CommandText = "Select * from [" + Hoja + "$] WHERE [SKU] > 0";

            OleDbDataAdapter AdaptadorOle = new OleDbDataAdapter(CmdOle.CommandText, Conex);

            DataTable dt = new DataTable();

            AdaptadorOle.Fill(dt);

            return dt;
        }

        private void FRM_EXCEL_PRECIOS_ARTICULOS_PROVEEDOR_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((backFile2.IsBusy) || (backFile.IsBusy))
            {
                DialogResult result = MessageBox.Show("SE ESTÁ EJECUTANDO UNA TAREA EN SEGUNDO PLANO, \r\n" +
                    "SI CIERRA EL FORMULARIO SE PERDERA TODO EL PROGRESO, \r\n" +
                    "¿REALMENTE DESEA CERRAR EL FORMULARIO?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    if (backFile.IsBusy)
                    {
                        backFile.CancelAsync();
                    }
                    if (backFile2.IsBusy)
                    {
                        backFile2.CancelAsync();

                    }


                }
                else
                {
                    e.Cancel = true;
                }

            }
        }

        public List<string> ListSheetInExcel(string filePath)
        {
            OleDbConnectionStringBuilder sbConnection = new OleDbConnectionStringBuilder();
            String strExtendedProperties = String.Empty;
            sbConnection.DataSource = filePath;
            if (Path.GetExtension(filePath).Equals(".xls")) //for 97-03 Excel file 
            {
                sbConnection.Provider = "Microsoft.Jet.OLEDB.4.0";
                strExtendedProperties = "Excel 8.0;HDR=Yes;IMEX=1";//HDR=ColumnHeader,IMEX=InterMixed 
            }
            else if (Path.GetExtension(filePath).Equals(".xlsx")) //for 2007 Excel file 
            {
                sbConnection.Provider = "Microsoft.ACE.OLEDB.12.0";
                strExtendedProperties = "Excel 12.0;HDR=Yes;IMEX=1";
            }

            sbConnection.Add("Extended Properties", strExtendedProperties);

            List<string> listSheet = new List<string>();

            using (OleDbConnection conn = new OleDbConnection(sbConnection.ToString()))
            {
                try
                {
                    conn.Open(); DataTable dtSheet = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                    foreach (DataRow drSheet in dtSheet.Rows)
                    {
                        if (drSheet["TABLE_NAME"].ToString().Contains("$"))//checks whether row contains '_xlnm#_FilterDatabase' or sheet name(i.e. sheet name always ends with $ sign) 
                        {
                            listSheet.Add(drSheet["TABLE_NAME"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //b_abierto = true; 
                }
            }
            return listSheet;
        }





        //OleDbConnection conn;
        //OleDbDataAdapter MyDataAdapter;
        //DataTable dt;

        //DataTable DT_Carga_PreciosProveedor = new DataTable();

        ////public bool CargaCompleta=true;
        //public bool Mtd_GP_Carga_PreciosProveedor(DataTable DT_Carga_PreciosProveedor)
        //{
        //    try
        //    {
        //        if (DT_Carga_PreciosProveedor != null)
        //        {
        //            foreach (DataRow irew in DT_Carga_PreciosProveedor.Rows)
        //            {
        //                sqlCatalogos.GP_Carga_PreciosProveedor(
        //                    Convert.ToInt32(irew["K_Proveedor"]),
        //                     irew["SKU"].ToString(),
        //                     Convert.ToDecimal(irew["Precio_Articulo"]),
        //                     txtRuta.Text, 
        //                     Convert.ToDateTime(irew["F_Actualizacion"]),
        //                     GlobalVar.K_Usuario,
        //                     Convert.ToDecimal(irew["Porcentaje_Descuento"]),
        //                     GlobalVar.PC_Name);
        //            }
        //            return true;
        //        }
        //        return false;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return false;
        //    }
        //}


        //public override void BaseBotonBuscarClick()
        //{

        //    Cursor = Cursors.WaitCursor;
        //    txtRuta.Text = importarExcel("Hoja1");
        //    if (dt != null)
        //    {
        //        if (Mtd_GP_Carga_PreciosProveedor(dt))
        //        {
        //            lblStatus.Text = "Se cargaron los precios del archivo de Excel, si esta de acuerdo de click en Afectar para guardarlos";
        //            lblStatus.ForeColor = Color.Blue;
        //            lblStatus.BackColor = Color.Silver;
        //            Cursor = Cursors.Default;
        //            BaseBotonAfectar.Visible = true;
        //            BaseBotonAfectar.Enabled = true;
        //        }
        //        else
        //        {
        //            Cursor = Cursors.Default;
        //            lblStatus.Text = "Ocurrió un problema al cargar el archvio de excel, verifique!";
        //            lblStatus.ForeColor = Color.White;
        //            lblStatus.BackColor = Color.Red;
        //        }
        //    }      
        //}

        //public override void BaseBotonAfectarClick()
        //{
        //    String errores = "";
        //    try
        //    {
        //        sqlCatalogos.Gp_Sube_PreciosProvedor(GlobalVar.K_Usuario, GlobalVar.PC_Name);
        //    }
        //    catch (Exception ex)
        //    {
        //        errores += ex;
        //    }
        //    if (errores != "")
        //    {
        //        MessageBox.Show("Ocurrió un problema al subir los precios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
        //        lblStatus.ForeColor = Color.White;
        //        lblStatus.BackColor = Color.Red;
        //    }
        //    else
        //    {
        //        MessageBox.Show("INFORMACION ACTUALIZADA CORRECTAMENTE ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        lblStatus.Text = "Información Actualizada Correctamente";
        //        BaseBotonAfectar.Visible = false;
        //        BaseBotonBuscar.Visible = false;
        //        lblStatus.ForeColor = Color.Blue;
        //        lblStatus.BackColor = Color.Silver;
        //    }

            
        //}

      

        //public string importarExcel(String nombreHoja)
        //{
        //    String ruta = "";
        //    try
        //    {
        //        OpenFileDialog openfile1 = new OpenFileDialog();
        //        openfile1.Filter = "Excel Files |*.xlsx";
        //        openfile1.Title = "Seleccione el archivo de Excel";
        //        if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //        {
        //            if (openfile1.FileName.Equals("") == false)
        //            {
        //                ruta = openfile1.FileName;
        //            }
        //        }

        //        if (ruta.Length == 0)
        //        {
        //            return null;
        //        }
        //        conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=" + ruta + ";Extended Properties='Excel 12.0 Xml;HDR=Yes'");
        //        MyDataAdapter = new OleDbDataAdapter("Select * from [" + nombreHoja + "$] WHERE [SKU] <> ''", conn);
        //        dt = new DataTable();
        //        MyDataAdapter.Fill(dt);
        //        return ruta;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //        return null;
        //    }
        //}
    }
}
