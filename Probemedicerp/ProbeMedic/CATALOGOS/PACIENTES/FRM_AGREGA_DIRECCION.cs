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

namespace ProbeMedic.CATALOGOS.PACIENTES
{
    public partial class FRM_AGREGA_DIRECCION : FormaBase
    {
        Int32 _K_Tipo_Direccion = 0;
        int res = 0;
        string msg = string.Empty;
        SQLCatalogos sql_Catalogos = new SQLCatalogos();

        public int PropiedadK_Paciente { get; set; }
        public string PropiedadD_Paciente { get; set; }

        public FRM_AGREGA_DIRECCION()
        {
            InitializeComponent();
            BaseMetodoLimpiaControles();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarTipoDireccion_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_TipoDireccion frm = new Busquedas.Frm_Busca_TipoDireccion();
            frm.ShowDialog();

            if (_K_Tipo_Direccion != frm.LLave_Seleccionado)
            {
                _K_Tipo_Direccion = frm.LLave_Seleccionado;
                txtTipoDireccion.Text = frm.Descripcion_Seleccionado;
            }
        }

        public override void BaseMetodoInicio()
        {
            BaseBotonGuardar.Visible = false;
            BaseBotonBorrar.Visible = false;

            BaseBotonModificar.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonReporte.Visible = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonBuscar.Visible = false;
            lblPac.Text = PropiedadD_Paciente;
        }
        public override void BaseMetodoLimpiaControles()
        {
            _K_Tipo_Direccion = 0;
            txtTipoDireccion.Text = string.Empty;
            geo_Colonia1.K_Pais = 0;
            geo_Colonia1.txt_G_Pais.Text = string.Empty;
            geo_Colonia1.K_Estado = 0;
            geo_Colonia1.txt_G_Estado.Text = string.Empty;
            geo_Colonia1.K_Ciudad = 0;
            geo_Colonia1.txt_G_Ciudad.Text = string.Empty;
            geo_Colonia1.K_Colonia = 0;
            geo_Colonia1.txt_G_Colonia.Text = string.Empty;
            txtCalle.Text = string.Empty;
            txtCP.Text = string.Empty;
            TxtNumExt.Text = string.Empty;
            txtNumInt.Text = string.Empty;
            txtEntreCalles.Text = string.Empty;
            txtEdificio.Text = string.Empty;
            txtPiso.Text = string.Empty;

        }

        private void BtnAplicar_Click(object sender, EventArgs e)
        {
            if (!BaseFuncionValidaciones())
                return;

            res = 0;
            msg = string.Empty;


            res = sql_Catalogos.In_Pacientes_Direcciones( PropiedadK_Paciente, _K_Tipo_Direccion, geo_Colonia1.K_Pais, geo_Colonia1.K_Estado, geo_Colonia1.K_Ciudad, geo_Colonia1.K_Colonia, Convert.ToInt32(txtCP.Text),
                                txtCalle.Text,TxtNumExt.Text,txtNumInt.Text, txtEntreCalles.Text, txtEdificio.Text, Convert.ToInt32(txtPiso.Text),ref msg);


            if (res == -1)
            {
                BaseErrorResultado = true;
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                BaseErrorResultado = false;
                MessageBox.Show("INFORMACION GRABADA CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                BaseMetodoLimpiaControles();
                Close();

            }
        }
        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (txtTipoDireccion.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR UN TIPO DE DATO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTipoDireccion.Focus();
                return false;
            }
            if (geo_Colonia1.K_Pais == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN PAIS...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                geo_Colonia1.txt_G_Ciudad.Focus();
                return false;
            }
            if (geo_Colonia1.K_Estado == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN ESTADO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                geo_Colonia1.txt_G_Estado.Focus();
                return false;
            }
            if (geo_Colonia1.K_Colonia == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA COLONIA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
   
                geo_Colonia1.txt_G_Ciudad.Focus();
                return false;
            }
            if (txtCP.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL CODIGO POSTAL...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCP.Focus();
                return false;
            }
            if (txtCalle.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA CALLE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCP.Focus();
                return false;
            }
            if (TxtNumExt.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL NUMERO EXTERIOR ..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNumExt.Focus();
                return false;
            }
            if (txtNumInt.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL NUMERO INTERIOR ..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumInt.Focus();
                return false;
            }
            if (txtEntreCalles.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LAS ENTRECALLES ..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEntreCalles.Focus();
                return false;
            }
            if (txtPiso.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL PISO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPiso.Focus();
                return false;
            }
            BaseErrorResultado = false;
            return true;
        }

        private void txtCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) &&
        e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void TxtNumExt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) &&
        e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtPiso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) &&
        e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
