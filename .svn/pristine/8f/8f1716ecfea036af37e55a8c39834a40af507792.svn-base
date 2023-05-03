using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbeMedic.REPORTES
{
    public partial class Frm_EnviaCorreo : FormaBase
    {
        Funciones fx = new Funciones();

        private string P_Archivo { get; set; }

        public Frm_EnviaCorreo()
        {
            InitializeComponent();
            BaseBotonExcel.Visible = false;
        }

        private void Frm_EnviaCorreo_Load(object sender, EventArgs e)
        {

        }

        public override void BaseMetodoInicio()
        {
   
            btn_Adjuntar.Visible = false;
            lbl_Archivos_Seleccionados.Visible = false;

            BaseBotonBuscar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonAfectar.Enabled = false;
            BaseBotonCorreo.Visible = false;
            BaseBotonCorreo.Enabled = false;
            BaseBotonModificar.Visible = false;
            BaseBotonModificar.Enabled = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonCancelar.Enabled = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonGuardar.Enabled = false;
            BaseBotonReporte.Visible = false;
            BaseBotonReporte.Enabled = false;
            BaseBotonCorreo.Visible = true;
            BaseBotonCorreo.Enabled = true;
        }

        public override void BaseBotonCorreoClick()
        {
            if (txt_Para.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL DESTINATARIO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Para.Focus();
                return;
            }
            if (txt_Asunto.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL ASUNTO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Asunto.Focus();
                return;
            }
            if (txt_Titulo.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL TITULO DEL CUERPO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Titulo.Focus();
                return;
            }
            if (txt_Cuerpo.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL CUERPO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Cuerpo.Focus();
                return;
            }
            if (!fx.ValidaEmail(txt_Para.Text.Trim()))
            {
                MessageBox.Show("DEBE CAPTURAR UN CORREO VÁLIDO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Para.Focus();
                return;
            }
            Cursor = Cursors.WaitCursor;
            enviaCorreos();
            Cursor = Cursors.Default;
        }

        private void btn_Adjuntar_Click(object sender, EventArgs e)
        {
            if(CargarArchivo.ShowDialog() == DialogResult.OK)
            {
                P_Archivo = CargarArchivo.FileName;
                lbl_Archivos_Seleccionados.Visible = true;
                lbl_Archivos_Seleccionados.Text = P_Archivo.ToString();
            }
        }

        private void cbx_Adjuntar_CheckedChanged(object sender, EventArgs e)
        {
            if(cbx_Adjuntar.Checked == true)
            {
                btn_Adjuntar.Visible = true;
            }
            else
            {
                btn_Adjuntar.Visible = false;
                lbl_Archivos_Seleccionados.Text = string.Empty;
                lbl_Archivos_Seleccionados.Visible = false;
            }
        }

        private void enviaCorreos()
        {
            string Asunto = txt_Asunto.Text;
            string CorreoDe = System.Configuration.ConfigurationManager.AppSettings["CorreoDe"].ToString();
            string Titulo = txt_Titulo.Text.Trim().Length > 0 ? txt_Titulo.Text.Trim() : "Probemedic Distribuciones S.A, Administración. ";
            string Cuerpo = fx.CuerpoCorreoHTML(txt_Cuerpo.Text.Trim() + " <p/>");

            string Recursos = string.Empty;
            string Archivos = Path.Combine(GlobalVar.rutaExe, "probemedic_login.png");
            string Adjuntos =string.Empty;

            if (cbx_Adjuntar.Checked == true)
            {
                Adjuntos = P_Archivo;
            }
            else
            {
                Adjuntos = "";
            }
            string CorreosConCopia = "";

            if (fx.EnviaCorreo(CorreoDe, txt_Para.Text, Asunto, txt_Titulo.Text, Cuerpo, Adjuntos, Archivos, Recursos, CorreosConCopia))
                Close();
        }
    }
}
