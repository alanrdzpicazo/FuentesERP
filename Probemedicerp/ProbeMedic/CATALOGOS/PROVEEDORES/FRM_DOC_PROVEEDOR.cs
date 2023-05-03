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
using System.IO;


namespace ProbeMedic.CATALOGOS
{
    public partial class FRM_DOC_PROVEEDOR : FormaCatalogo
    {
        public Int32 K_Documentos_Requeridos;
        public TextBox txt_DP_Documentos_Requeridos
        {
            get { return this.txtDocReq; }
        }
        public int PropiedadK_Proveedor { get; set; }
        public string PropiedadD_Proveedor { get; set; }
        int res = 0;
        string msg = string.Empty;

        SQLCatalogos sql_Catalogos = new SQLCatalogos();

        public FRM_DOC_PROVEEDOR()
        {
            InitializeComponent();
        }

        public override void BaseMetodoInicio()
        {
            btnBuscar.Focus(); //Asignar el textbox que inicia el focus
            pnlControles.Enabled = false; //NO Borrar

            BaseDtDatos = sql_Catalogos.Sk_Documentos_Proveedor(PropiedadK_Proveedor);
            CatalogoPropiedadCampoClave = "K_Documento_Proveedor";
            CatalogoPropiedadCampoDescripcion = "D_Documento";

            lblProveedor.Text = PropiedadD_Proveedor;

            base.BaseMetodoInicio();
        }

        public override void CatalogoHabilitaPanelControles(bool B_Habilita)
        {
            pnlControles.Enabled = B_Habilita;
        }

        public override void BaseMetodoLimpiaControles()
        {
            txtClave.Text = string.Empty;
            txtDocReq.Text = string.Empty;
            K_Documentos_Requeridos = 0;
            cbxResguardado.Checked = false;
            txtObservaciones.Text = string.Empty;
            pnlImagen.Visible = false;
            pbImagen.Image = null;
            pnlControles.Enabled = false; //NO Borrar        
        }

        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();
            txtClave.Text = ren["K_Documento_Proveedor"].ToString(); 
            K_Documentos_Requeridos = Convert.ToInt32(ren["K_Documentos_Requeridos"].ToString());
            txtDocReq.Text = ren["D_Documento"].ToString();
            txtObservaciones.Text = ren["Observaciones"].ToString();
            cbxResguardado.Checked = Convert.ToBoolean(ren["B_Resguardado"]);

            if(cbxResguardado.Checked == true)
            {
                pnlImagen.Visible = true;

                string cadena = ren["Documento"].ToString();

                if (cadena != "")
                {
                    // Convert Base64 String to byte[]
                    byte[] imageBytes = Convert.FromBase64String(cadena);
                    MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
                    // Convert byte[] to Image
                    ms.Write(imageBytes, 0, imageBytes.Length);
                    Image image = Image.FromStream(ms, true);
                    pbImagen.Image = image;
                    pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        public override void BaseBotonBorrarClick()
        {
            if (txtDocReq.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN REGISTRO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dlg = MessageBox.Show("SERA ELIMINADO EL REGISTRO CON VALOR:\n" + txtDocReq.Text.Trim() + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                res = sql_Catalogos.Dl_Documentos_Proveedor(K_Documentos_Requeridos,Convert.ToInt32(PropiedadK_Proveedor), GlobalVar.K_Usuario, ref msg);
                if (res == -1)
                {
                    BaseErrorResultado = true;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    BaseErrorResultado = false;
                    MessageBox.Show("INFORMACION ELIMINADA CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BaseMetodoInicio();
                    BaseBotonCancelarClick();
                }

            }
        }

        public override void BaseBotonGuardarClick()
        {
            if (!BaseFuncionValidaciones())
                return;

            res = 0;
            msg = string.Empty;
            //int CampoIdentity = 0;

            if (CatalogoPropiedadEsRegistroNuevo) // Nuevo
            {
                res = sql_Catalogos.In_Documentos_Proveedor(K_Documentos_Requeridos,PropiedadK_Proveedor,cbxResguardado.Checked, GlobalVar.K_Usuario,txtObservaciones.Text,pbImagen, ref msg);
            }
        
            else //Existe. Update
            {
                res = sql_Catalogos.Up_Documentos_Proveedor(
                    Convert.ToInt32(txtClave.Text.Trim()),
                    K_Documentos_Requeridos,
                    PropiedadK_Proveedor,
                    cbxResguardado.Checked,
                    GlobalVar.K_Usuario,
                    DateTime.Now,
                    txtObservaciones.Text.Trim(),
                    pbImagen,
                    ref msg);
            }

            if (res == -1)
            {
                BaseErrorResultado = true;
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                BaseErrorResultado = false;
                MessageBox.Show("INFORMACION ACTUALIZADA CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BaseMetodoInicio();
                BaseBotonCancelarClick();
            }

        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (txtDocReq.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL DOCUMENTO REQUERIDO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDocReq.Focus();
                return false;
            }
            BaseErrorResultado = false;
            return true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Documentos_Requeridos_Proveedor frm = new Busquedas.Frm_Busca_Documentos_Requeridos_Proveedor();
            frm.ShowDialog();

            if (K_Documentos_Requeridos != frm.LLave_Seleccionado)
            {
                K_Documentos_Requeridos = frm.LLave_Seleccionado;
                txtDocReq.Text = frm.Descripcion_Seleccionado;
            }
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {

            openFileDialog1.Multiselect = true;
            openFileDialog1.Title = "Seleccione los documentos a subir";

            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.

            if (result == DialogResult.OK) // Test result.
            {

                Cursor = Cursors.WaitCursor;
                ftp ftpClient = new ftp(@"ftp://altisremoto.doesntexist.com", "uProbemedic", "MsVRT64dRpTXULdsOYlxbQ");
                string dir = string.Empty, dircompleto = string.Empty;
                string[] Nombre = null;
                string[] nCompleto = null;
                try
                {

                    nCompleto = openFileDialog1.FileNames;

                    Nombre = openFileDialog1.SafeFileNames;

                    dir = "Documentos/" + txtClave.Text;

                    dircompleto = dir + "/" +txtClave.Text+"/";
                    ftpClient.createDirectory(dir);
                    ftpClient.createDirectory(dir + "/" + txtClave.Text + "/");


                    if (Nombre.Length > 1)
                    {
                        int i = 0;
                        foreach (String file in Nombre)
                        {

                            ftpClient.upload(dircompleto + file, nCompleto[i]);
                            i++;
                        }
                    }
                    else
                    {
                        ftpClient.upload(dircompleto + openFileDialog1.SafeFileName, openFileDialog1.FileName);
                    }
                }
                catch (Exception ex)
                {
                    Cursor = Cursors.Default;
                    MessageBox.Show(ex.ToString(), "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                Cursor = Cursors.Default;

                MessageBox.Show("ARCHIVOS SUBIDOS CORRECTAMENTE", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

            Cursor = Cursors.Default;
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();


            if (result == DialogResult.OK)
            {

                Cursor = Cursors.WaitCursor;

                try
                {
                    ftp ftpClient = new ftp(@"ftp://altisremoto.doesntexist.com", "uProbemedic", "MsVRT64dRpTXULdsOYlxbQ");

                    string dir = string.Empty, dircompleto = string.Empty;

                    dir = "Documentos/" + txtClave.Text;

                    string[] Archivos;

                    dircompleto = dir + "/" + txtClave.Text + "/";

                     Archivos = ftpClient.directoryListSimple(dircompleto);

                    foreach (String file in Archivos)
                    {
                        if (file == "-1")
                        {
                            //Le dieron cancelar
                            Cursor = Cursors.Default;
                            return;
                        }

                        if (Archivos[0].Length > 0)
                        {
                            ftpClient.download(dircompleto + file, folderBrowserDialog1.SelectedPath + "/" + file);
                        }
                        else
                        {
                            Cursor = Cursors.Default;
                            MessageBox.Show("NO EXISTEN EVIDENCIAS CARGADAS PARA ESTE PROVEEDOR", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                }
                catch (IOException ex)
                {
                    Cursor = Cursors.Default;
                    MessageBox.Show(ex.ToString(), "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                Cursor = Cursors.Default;
                MessageBox.Show("ARCHIVOS DESCARGADOS CORRECTAMENTE", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Cursor = Cursors.Default;
        }

        private void cbxResguardado_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxResguardado.Checked == true)
            {
                pnlImagen.Visible = true;
            }
            else if(cbxResguardado.Checked == false)
            {
                pnlImagen.Visible = false;

            }
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files(*.jpg) | *.jpg";
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                List<String> listaExtensiones = new List<string>() { ".jpg" };
                if (listaExtensiones.Contains(Path.GetExtension(dialog.FileName)))
                {
                    pbImagen.Image = Image.FromFile(dialog.FileName);
                }
                else
                {
                    MessageBox.Show("La extensión del archivo no es válido.");
                }
            }
        }

        public byte[] StrToByteArray(string str)
        {
            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
            return encoding.GetBytes(str);

        }
    }
}
