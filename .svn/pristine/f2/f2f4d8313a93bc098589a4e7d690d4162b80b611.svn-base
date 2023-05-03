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
    public partial class FRM_PACIENTE_PROGRAMA : FormaBase
    {
        int res = 0;
        string msg = string.Empty;
        Int32 _K_Articulo = 0, _K_Aseguradora = 0, _K_Programa = 0, _K_Paciente = 0;
        public FRM_PACIENTE_PROGRAMA()
        {
            InitializeComponent();
        }

        private void FRM_PACIENTE_PROGRAMA_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarArticulo_Click(object sender, EventArgs e)
        {
            GlobalVar.dtPreciosAmbulancia = sqlCatalogos.Sk_Articulos();
            Busquedas.Frm_Busca_Articulos frm = new Busquedas.Frm_Busca_Articulos();
            frm.ShowDialog();
            _K_Articulo = frm.LLave_Seleccionado;
            txtArticulo.Text = frm.Descripcion_Seleccionado;
        }

        private void btnBuscarAseguradora_Click(object sender, EventArgs e)
        {
            GlobalVar.dtPreciosAmbulancia = sqlCatalogos.Sk_Aseguradora();
            Busquedas.Frm_Busca_Aseguradora frm = new Busquedas.Frm_Busca_Aseguradora();
            frm.ShowDialog();
            _K_Aseguradora = frm.LLave_Seleccionado;
            txtAseguradora.Text = frm.Descripcion_Seleccionado;
        }

        private void btnBuscarPrograma_Click(object sender, EventArgs e)
        {
            GlobalVar.dtPreciosAmbulancia = sqlCatalogos.Sk_Programas();
            Busquedas.Frm_Busca_Programa frm = new Busquedas.Frm_Busca_Programa();
            frm.ShowDialog();
            _K_Programa = frm.LLave_Seleccionado;
            txtPrograma.Text = frm.Descripcion_Seleccionado;
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            GlobalVar.dtPreciosAmbulancia = sqlCatalogos.Sk_Aseguradora();
            Busquedas.Frm_Busca_Paciente frm = new Busquedas.Frm_Busca_Paciente();
            frm.ShowDialog();
            _K_Paciente = frm.LLave_Seleccionado;
            txtPaciente.Text = frm.Descripcion_Seleccionado;
        }

        private void BtnAplicar_Click(object sender, EventArgs e)
        {
            if (!BaseFuncionValidaciones())
                return;

            res = 0;
            msg = string.Empty;

            res = sqlCatalogos.In_Programas_Pacientes
                   (
                   _K_Programa, _K_Articulo, _K_Aseguradora, _K_Paciente, GlobalVar.K_Usuario, ref msg);

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

            if (txtArticulo.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR ARTICULO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscarArticulo.Focus();
                return false;
            }
            if (txtAseguradora.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR ASEGURADORA..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscarAseguradora.Focus();
                return false;
            }
            if (txtPrograma.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR PROGRAMA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscarPrograma.Focus();
                return false;
            }
            if (txtPaciente.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR PACIENTE..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscarPaciente.Focus();
                return false;
            }
           

            BaseErrorResultado = false;
            return true;
        }
    }
}
