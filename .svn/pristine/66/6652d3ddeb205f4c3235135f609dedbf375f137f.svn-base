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
    public partial class FRM_EDITAR_PACIENTE : FormaBase
    {
        public Int32 K_Paciente { get; set; }
        public string Nombre_Actual { get; set; }
        public string Nombre_Nuevo { get; set; }

        SQLCatalogos sql_catalogos = new SQLCatalogos();
        int res = 0;
        string msg = string.Empty;
        public FRM_EDITAR_PACIENTE()
        {
            InitializeComponent();
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

            txtClavePaciente.Text = K_Paciente.ToString();
            txtNombreActual.Text = Nombre_Actual;
        }

        public override void BaseBotonAfectarClick()
        {
            if (txtNombre.Text.Trim().Length== 0)
            {
                MessageBox.Show("DEBE INDICAR EL NOMBRE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }
            if (txtApePat.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE INDICAR EL APELLIDO PATERNO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApePat.Focus();
                return;
            }
            if (txtApeMat.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE INDICAR EL APELLIDO MATERNO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApeMat.Focus();
                return;
            }
            res = 0;
            msg = string.Empty;

            string Nombre = string.Empty;

            res = sqlCatalogos.Gp_ActualizaNombrePaciente(K_Paciente,txtNombre.Text.Trim(),txtApePat.Text.Trim(),txtApeMat.Text.Trim(),ref Nombre,ref msg);

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
    }
}
