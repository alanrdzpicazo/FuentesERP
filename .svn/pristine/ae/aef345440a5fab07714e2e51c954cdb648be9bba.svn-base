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
    public partial class FRM_PACIENTES_INSTITUCIONES : FormaBase
    {
        public FRM_PACIENTES_INSTITUCIONES()
        {
            InitializeComponent();
        }

        public int PropiedadK_Paciente { get; set; }
        public string PropiedadD_Paciente { get; set; }

        Int32 _K_Institucion = 0;

        Int32 _K_Institucion_Seleccion = 0;
        int res = 0;
        string msg = string.Empty;
        SQLCatalogos sql_Catalogos = new SQLCatalogos();

        DataTable instituciones = new DataTable();
        DataTable _instituciones = new DataTable();

        private void btnBuscarInstitucion_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Institucion frm = new Busquedas.Frm_Busca_Institucion();
            frm.ShowDialog();

            if (_K_Institucion != frm.LLave_Seleccionado)
            {
                _K_Institucion = frm.LLave_Seleccionado;
                txtInstitucion.Text = frm.Descripcion_Seleccionado;
            }
        }

        private void BtnAplicar_Click(object sender, EventArgs e)
        {
            if (!BaseFuncionValidaciones())
                return;

            res = 0;
            msg = string.Empty;



            res = sql_Catalogos.In_Pacientes_Instituciones(PropiedadK_Paciente,_K_Institucion,GlobalVar.K_Usuario, ref msg);


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
            if (_K_Institucion_Seleccion == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA INSTITUCION...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dlg = MessageBox.Show("SERA ELIMINADO EL REGISTRO CON VALOR:\n" + Convert.ToString(grDatos.CurrentRow.Cells[1].Value.ToString()) + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                res = sql_Catalogos.Dl_Pacientes_Instituciones(PropiedadK_Paciente, Convert.ToInt32(grDatos.CurrentRow.Cells[0].Value.ToString()), GlobalVar.K_Usuario, ref msg);
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

            btnBuscarInstitucion.Focus();//Asignar el textbox que inicia el focus

            lblPac.Text = PropiedadD_Paciente;

        }

        private void LlenaGrid(Int32 PropiedadK_Paciente)
        {
            try
            {
                _instituciones= sql_Catalogos.Sk_Pacientes_Instituciones(PropiedadK_Paciente);

                if (_instituciones != null)
                {
                    foreach (DataRow irow in _instituciones.Rows)
                    {
                        DataRow dtdRow = instituciones.NewRow();
                        dtdRow["K_Institucion"] = Convert.ToInt32(irow["K_Institucion"].ToString());
                        dtdRow["D_Institucion"] = irow["D_Institucion"].ToString();
                        dtdRow["C_Institucion"] = irow["C_Institucion"].ToString();
                        dtdRow["RFC_Institucion"] = irow["RFC_Institucion"].ToString();
                        instituciones.Rows.Add(dtdRow);

                    }
                    grDatos.DataSource = instituciones;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public override void BaseMetodoLimpiaControles()
        {
            _K_Institucion = 0;
            txtInstitucion.Text = string.Empty;

            pnlControl.Enabled = false; //NO Borrar        
        }

        public override void BaseBotonBorrarClick()
        {
            if (_K_Institucion_Seleccion == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA INSTITUCION...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dlg = MessageBox.Show("SERA ELIMINADO EL REGISTRO CON VALOR:\n" + Convert.ToString(grDatos.CurrentRow.Cells[1].Value.ToString()) + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                res = sql_Catalogos.Dl_Pacientes_Instituciones(PropiedadK_Paciente,Convert.ToInt32(_K_Institucion_Seleccion), GlobalVar.K_Usuario, ref msg);
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



            res = sql_Catalogos.In_Pacientes_Instituciones(PropiedadK_Paciente,_K_Institucion,GlobalVar.K_Usuario, ref msg);


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

            if (txtInstitucion.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR LA INSTITUCION...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscarInstitucion.Focus();
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

        private void limpia()
        {

            if (grDatos.RowCount > 0)
            {
                DataTable dt2 = (DataTable)grDatos.DataSource;
                dt2.Clear();
            }
        }

        private void grDatos_SelectionChanged(object sender, EventArgs e)
        {
            if (grDatos.Rows.Count > 0)
            {
                _K_Institucion_Seleccion = Convert.ToInt32(grDatos.CurrentRow.Cells[0].Value.ToString());
                txtInstitucion.Text = grDatos.CurrentRow.Cells["D_Institucion"].Value.ToString();

            }
        }

        private void FRM_PACIENTES_INSTITUCIONES_Load(object sender, EventArgs e)
        {
            instituciones.Columns.Add("K_Institucion", typeof(Int32));
            instituciones.Columns.Add("D_Institucion", typeof(string));
            instituciones.Columns.Add("C_Institucion", typeof(string));
            instituciones.Columns.Add("RFC_Institucion", typeof(string));
            limpia();

            LlenaGrid(PropiedadK_Paciente);
        }

        private void txtInstitucion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
