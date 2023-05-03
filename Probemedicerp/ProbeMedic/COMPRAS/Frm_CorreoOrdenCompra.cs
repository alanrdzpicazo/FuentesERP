using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace ProbeMedic.COMPRAS
{
    public partial class Frm_CorreoOrdenCompra : FormaConsulta
    {
        public string P_NombreProveedor { get; set; }
        public string P_NombreContacto { get; set; }
        public string P_CorreoContacto { get; set; }
        public string P_NombreAutoriza { get; set; }
        public string P_CorreoAutoriza { get; set; }        
        public int P_NoOrden { get; set; }
        public string P_Archivo { get; set; }

        Funciones fx = new Funciones();

        public Frm_CorreoOrdenCompra()
        {
            InitializeComponent();
        }

        public override void BaseMetodoInicio()
        {
            lblProveedor.Text = P_NombreProveedor;
            txtContacto.Text = P_NombreContacto;
            txtCorreo.Text = P_CorreoContacto;

            base.BaseMetodoInicio();
            BaseBotonCancelar.Visible = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonReporte.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonCorreo.Visible = true;
        }

        public override void BaseBotonCorreoClick()
        {
            if (txtContacto.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR NOMBRE DEL CONTACTO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContacto.Focus();
                return;
            }
            if (txtCorreo.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR CORREO ELECTRONICO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return;
            }
            if (!fx.ValidaEmail(txtCorreo.Text.Trim()))
            {
                MessageBox.Show("CAPTURE UN CORREO ELECTRONICO VALIDO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return;
            }
            string Asunto = "Probemedic Distribuciones S.A, Compras, Orden de Compra / Purchase Order No. " + P_NoOrden.ToString().Trim();
            string CorreoDe = GlobalVar.CorreoDe;
            string Cuerpo = fx.CuerpoCorreoHTML("Envío anexo la siguiente orden de compra. Favor de entregarla en tiempo en el destino especificado. <br/> <p/>" +
                                                "Adjunto encontrará la OC #  " + P_NoOrden.ToString().Trim() + "  ¿Podría confirmar el día del envío ? <br/>" +
                                                "Gracias de antemano");

            string Recursos = "";
            string Archivos = Path.Combine(GlobalVar.rutaExe, "probemedic_login.png");
            string Adjuntos = P_Archivo;// +"," + Archivos;

            string NombreReporteOC = "OrdenCompra " + P_NoOrden.ToString().Trim();
            //if (P_Archivo != null)
            //    P_Archivo = P_Archivo.ToString().Replace("temp", NombreReporteOC);

            string CorreosConCopia = P_CorreoAutoriza.Trim();

            Cursor = Cursors.WaitCursor;
            if (fx.EnviaCorreo(CorreoDe, txtCorreo.Text, Asunto, "Orden de Compra / Purchase Order", Cuerpo, Adjuntos, Archivos, Recursos, P_CorreoAutoriza.Trim()))
                Close();

        }

    }
}
