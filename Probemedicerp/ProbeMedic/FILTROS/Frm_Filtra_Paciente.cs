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

namespace ProbeMedic.FILTROS
{
    public partial class Frm_Filtra_Paciente : Frm_Filtro
    {
        public DataTable dtFiltra = new DataTable();
        public DataTable dtFiltra2 = new DataTable();
        SQLCatalogos sql_catalogo = new SQLCatalogos();
        public Frm_Filtra_Paciente()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (dtFiltra != null)
            {
                if (dtFiltra.Rows.Count > 0)
                {
                    dtFiltra.Rows.Clear();
                }
            }


            //if ((txt_Nombre.Text.Trim().Length>0) || (ucTPacientes1.K_TipoPaciente > 0) || (ucTipoSangre1.K_TipoSangre > 0) || (ucNacionalidad1.K_Nacionalidad > 0)|| (ucEstadoCivil1.K_Estado_Civil>0) ||(ucGeneros1.K_Genero>0))
            //{

            dtFiltra = sql_catalogo.Sk_Pacientes_Top(ucAseguradora1.K_Aseguradora, 0, txt_Nombre.Text.Trim(),txtClave.Text.Trim().Length>0 ? Convert.ToInt32(txtClave.Text.Trim()):0, ucTPacientes1.K_TipoPaciente, ucGeneros1.K_Genero, ucNacionalidad1.K_Nacionalidad, ucEstadoCivil1.K_Estado_Civil, ucTipoSangre1.K_TipoSangre);

            try
            {
                if ((dtFiltra != null))
                {
                    if(dtFiltra.Rows.Count > 0)
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("NO EXISTEN PACIENTES CON LOS PARAMETROS INDICADOS ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("NO EXISTEN PACIENTES CON LOS PARAMETROS INDICADOS ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch { }
         
            //}
            //else
            //{
            //    MessageBox.Show("DEBE INDICAR AL MENOS UN FILTRO ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void Frm_Filtra_Paciente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                BtnBuscar.PerformClick();

            }
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((Char.IsNumber(e.KeyChar)) ||(e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            if (txtClave.Text.Trim().Length > 0)
            {
                Int32 valor = 0;

                if(!Int32.TryParse(txtClave.Text.Trim(),out valor))
                {
                    MessageBox.Show("VALOR NO VALIDO!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClave.Text = string.Empty;
                    txtClave.Focus();
                }
            }
        }
    }
}
