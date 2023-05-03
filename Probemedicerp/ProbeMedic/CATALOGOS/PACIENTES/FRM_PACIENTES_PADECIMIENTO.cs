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
    public partial class FRM_PACIENTES_PADECIMIENTO : FormaBase
    {
        SQLCatalogos sql_Catalogos = new SQLCatalogos();

        int res = 0;
        string msg = string.Empty;
        public int PropiedadK_Paciente { get; set; }
        public string PropiedadD_Paciente { get; set; }

        DataTable padecimiento = new DataTable();
        DataTable _padecimiento = new DataTable();

        Int32 _K_Padecimiento = 0;
        Int32 _K_Padecimiento_Seleccion = 0;

        public FRM_PACIENTES_PADECIMIENTO()
        {
            InitializeComponent();
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

            btnBuscarPadecimiento.Focus();//Asignar el textbox que inicia el focus     

            LlenaGrid(PropiedadK_Paciente);
        }

        public override void BaseMetodoLimpiaControles()
        {
            _K_Padecimiento = 0;
            txtPadecimiento.Text = string.Empty;

            pnlControl.Enabled = false; //NO Borrar        
        }

        public override void BaseBotonBorrarClick()
        {
            if (_K_Padecimiento_Seleccion == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN MEDICO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dlg = MessageBox.Show("SERA ELIMINADO EL REGISTRO CON VALOR:\n" + Convert.ToString(grPadecimientos.CurrentRow.Cells[1].Value.ToString()) + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                res = sql_Catalogos.Dl_Pacientes_Medicos(Convert.ToInt32(grPadecimientos.CurrentRow.Cells[0].Value.ToString()), PropiedadK_Paciente, GlobalVar.K_Usuario, ref msg);
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


                    limpia();

                    LlenaGrid(PropiedadK_Paciente);

                }

            }
        }

        public override void BaseBotonGuardarClick()
        {
            if (!BaseFuncionValidaciones())
                return;

            res = 0;
            msg = string.Empty;



            res = sql_Catalogos.In_Pacientes_Medicos(_K_Padecimiento, PropiedadK_Paciente, ref msg);


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

                limpia();

                LlenaGrid(PropiedadK_Paciente);

            }

        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (txtPadecimiento.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR EL MEDICO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPadecimiento.Focus();
                return false;
            }

            BaseErrorResultado = false;
            return true;
        }

        public override void BaseBotonNuevoClick()
        {
            pnlControl.Enabled = true;

        }

        public override void BaseBotonCancelarClick()
        {
            BaseMetodoInicio();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Padecimientos frm = new Busquedas.Frm_Busca_Padecimientos();
            frm.ShowDialog();

            if (_K_Padecimiento!= frm.LLave_Seleccionado)
            {
                _K_Padecimiento = frm.LLave_Seleccionado;
                txtPadecimiento.Text = frm.Descripcion_Seleccionado;
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            limpia();
            if (txtICD.Text.Trim().Length == 0)
            {
                txtICD.Text = null;
            }
            _padecimiento = sql_Catalogos.Sk_Pacientes_Padecimientos(PropiedadK_Paciente, txtICD.Text, _K_Padecimiento);

            if (_padecimiento != null)
            {
                grPadecimientos.DataSource = _padecimiento;
            }
            else
            {
                if(grPadecimientos.Rows.Count>0)
                {
                    DataTable dt = grPadecimientos.DataSource as DataTable;
                    dt.Rows.Clear();
                    MessageBox.Show("NO SE ENCONTRO INFORMACION!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
   
            }
        }
        private void BtnAplicar_Click(object sender, EventArgs e)
        {
            if (!BaseFuncionValidaciones())
                return;

            res = 0;
            msg = string.Empty;



            res = sql_Catalogos.In_Pacientes_Padecimiento(_K_Padecimiento, PropiedadK_Paciente, GlobalVar.K_Usuario, ref msg);


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

                limpia();

                LlenaGrid(PropiedadK_Paciente);

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_K_Padecimiento_Seleccion == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN MEDICO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dlg = MessageBox.Show("SERA ELIMINADO EL REGISTRO CON VALOR:\n" + Convert.ToString(grPadecimientos.CurrentRow.Cells[1].Value.ToString()) + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                res = sql_Catalogos.Dl_Pacientes_Padecimiento(Convert.ToInt32(grPadecimientos.CurrentRow.Cells[0].Value.ToString()), PropiedadK_Paciente, GlobalVar.K_Usuario, ref msg);
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


                    limpia();

                    LlenaGrid(PropiedadK_Paciente);

                }

            }
        }
        private void limpia()
        {

            if (grPadecimientos.RowCount > 0)
            {
                DataTable dt2 = (DataTable)grPadecimientos.DataSource;
                dt2.Clear();
            }
        }

        private void grDatos_SelectionChanged(object sender, EventArgs e)
        {
            if (grPadecimientos.Rows.Count > 0)
            {
                _K_Padecimiento_Seleccion = Convert.ToInt32(grPadecimientos.CurrentRow.Cells[0].Value.ToString());
                txtPadecimiento.Text = grPadecimientos.CurrentRow.Cells["D_Padecimiento"].Value.ToString();
                txtICD.Text = grPadecimientos.CurrentRow.Cells["ICD"].Value.ToString();
            }
        }

        private void LlenaGrid(Int32 PropiedadK_Paciente)
        {
            try
            {
                _padecimiento = sql_Catalogos.Sk_Pacientes_Padecimientos(PropiedadK_Paciente);

                if (_padecimiento != null)
                {
                    grPadecimientos.DataSource = _padecimiento;

                }
                else
                {
                    if (grPadecimientos.Rows.Count > 0)
                    {
                        DataTable dt = grPadecimientos.DataSource as DataTable;
                        dt.Rows.Clear();
                        MessageBox.Show("NO SE ENCONTRO INFORMACION!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

            

    }
}

