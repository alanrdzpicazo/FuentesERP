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
using System.Data.SqlClient;
using System.IO;


namespace ProbeMedic.CATALOGOS
{
    public partial class Frm_ImagenesVenta : FormaCatalogo
    {
        int res = 0;
        string msg = string.Empty;
        SQLCatalogos sql_Catalogos = new SQLCatalogos();
        Funciones fx = new Funciones();

        public Frm_ImagenesVenta()
        {
            InitializeComponent();
            BaseBotonExcel.Visible = false;
        }
        public override void BaseMetodoInicio()
        {
            txtFocus = txtDescripcion; //Asignar el textbox que inicia el focus
            PNL.Enabled = false; //NO Borrar

            BaseDtDatos = sql_Catalogos.Sk_Imagenes_Venta();
            CatalogoPropiedadCampoClave = "K_Imagen_Venta";
            CatalogoPropiedadCampoDescripcion = "D_Imagen_Venta";

            base.BaseMetodoInicio();
        }
        public override void CatalogoHabilitaPanelControles(bool B_Habilita)
        {
            PNL.Enabled = B_Habilita;
        }
        public override void BaseMetodoLimpiaControles()
        {
            txtClave.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            pbImagen.Image = null;
            PNL.Enabled = false; //NO Borrar        
        }
        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();

            txtClave.Text = ren["K_Imagen_Venta"].ToString();
            txtDescripcion.Text = ren["D_Imagen_Venta"].ToString();
            string cadena = ren["Imagen"].ToString();

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
        public override void BaseBotonBorrarClick()
        {

            if (txtClave.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN REGISTRO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dlg = MessageBox.Show("SERA ELIMINADO EL REGISTRO CON VALOR:\n" + txtDescripcion.Text.Trim() + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                res = sql_Catalogos.Dl_Imagenes_Venta(Convert.ToInt16(txtClave.Text), ref msg);
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
            short CampoIdentity = 0;

            DateTime Caducidad = DateTime.Today;
            PictureBox pb = this.pbImagen;

            if (CatalogoPropiedadEsRegistroNuevo) // Nuevo
            {
                res = sql_Catalogos.In_Imagenes_Venta(ref CampoIdentity, txtDescripcion.Text, this.pbImagen, ref msg);
            }

            else //Existe. Update
            {
                CampoIdentity = Convert.ToInt16(CatalogoPropiedadId_Identity);
                res = CatalogosSQL.Up_Imagenes_Venta(Convert.ToInt16(txtClave.Text), txtDescripcion.Text,  this.pbImagen, ref msg);
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

            if (txtDescripcion.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA DESCRIPCION...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                return false;
            }

            if (pbImagen.Image == null)
            {
                MessageBox.Show("FALTA CAPTURAR LA IMAGEN ..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioMax.Focus();
                return false;
            }

            BaseErrorResultado = false;
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
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
