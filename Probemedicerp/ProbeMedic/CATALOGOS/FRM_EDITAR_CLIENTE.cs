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

namespace ProbeMedic.CATALOGOS
{
    public partial class FRM_EDITAR_CLIENTE : FormaBase
    {
        public Int32 K_Cliente { get; set; }
        public string Nombre_Actual { get; set; }
        public string Nombre_Nuevo { get; set; }
        public string RFC_Actual { get; set; }

        SQLCatalogos sqlCatalogos = new SQLCatalogos();
        int res = 0;
        string msg = string.Empty;
        public FRM_EDITAR_CLIENTE()
        {
            InitializeComponent();
        }

        private void FRM_EDITAR_CLIENTE_Load(object sender, EventArgs e)
        {

        }
        public override void BaseMetodoInicio()
        {
            BaseBotonNuevo.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonExcel.Enabled = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonModificar.Visible = false;
            BaseBotonModificar.Enabled = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonGuardar.Enabled = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonBuscar.Enabled = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonCancelar.Enabled = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonAfectar.Visible = true;
            BaseBotonAfectar.Enabled = true;
            BaseBotonReporte.Visible = false;
            BaseBotonReporte.Enabled = false;

            txt_K_Cliente.Text = K_Cliente.ToString();
            txt_D_Cliente.Text = Nombre_Actual;
            txt_RFC.Text = RFC_Actual;
        }

        public override void BaseBotonAfectarClick()
        {
            DialogResult result = MessageBox.Show("SERAN CAMBIADOS LOS DATOS FISCALES AL CLIENTE: \r\n [" + K_Cliente + "] - " + Nombre_Actual + " CON RFC " + RFC_Actual + ". \r\n \r\n" +
                "Nombre Nuevo: " + txt_D_Cliente_Nuevo.Text.Trim() + "\r\n" +
                "RFC Nuevo: " + txt_RFC_Cliente.Text.Trim() + "\r\n \r\n" +
                "¿ESTA SEGURO(A) DE CONTINUAR?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (txt_D_Cliente_Nuevo.Text.Trim().Length == 0)
                {
                    MessageBox.Show("DEBE INDICAR EL NOMBRE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_D_Cliente_Nuevo.Focus();
                    return;
                }
                if (txt_RFC_Cliente.Text.Trim().Length == 0)
                {
                    MessageBox.Show("DEBE INDICAR EL NUEVO RFC...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_RFC_Cliente.Focus();
                    return;
                }
                res = 0;
                msg = string.Empty;

                string Nombre = string.Empty;

                res = sqlCatalogos.Gp_ActualizaNombreCliente(K_Cliente, txt_D_Cliente_Nuevo.Text.Trim(), ref Nombre, txt_RFC_Cliente.Text.Trim(), GlobalVar.K_Usuario, GlobalVar.K_Menu, ref msg);

                if (res == -1)
                {
                    BaseErrorResultado = true;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Nombre_Nuevo = string.Empty;
                    return;
                }
                else
                {
                    BaseErrorResultado = false;
                    MessageBox.Show("INFORMACION ACTUALIZADA CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Nombre_Nuevo = Nombre;
                    Close();
                }
            }
            else
            {
                Close();
            }         
        }
    }
}
