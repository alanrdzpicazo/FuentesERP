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
    public partial class FRM_PACIENTES_CORREOS : FormaBase
    {
        public int PropiedadK_Paciente { get; set; }
        public string PropiedadD_Paciente { get; set; }

        Int32 _K_Tipo_Dato = 0;

        Int32 _K_Paciente_Correo = 0;

        int res = 0;
        string msg = string.Empty;
        SQLCatalogos sql_Catalogos = new SQLCatalogos();

        DataTable tiposdatos = new DataTable();
        DataTable _tiposdatos = new DataTable();

        private void FRM_PACIENTES_CORREOS_Load(object sender, EventArgs e)
        {
            tiposdatos.Columns.Add("K_Paciente_Correo", typeof(Int32));
            tiposdatos.Columns.Add("D_Tipo_Dato", typeof(string));
            tiposdatos.Columns.Add("Correo", typeof(string));
            tiposdatos.Columns.Add("B_Activo", typeof(Boolean));
            limpia();

            LlenaGrid(PropiedadK_Paciente);
        }

        public FRM_PACIENTES_CORREOS()
        {
            InitializeComponent();
        }

        private void btnBuscaTipoDato_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_TipoDato frm = new Busquedas.Frm_Busca_TipoDato();
            frm.ShowDialog();

            if (_K_Tipo_Dato != frm.LLave_Seleccionado)
            {
                _K_Tipo_Dato = frm.LLave_Seleccionado;
                txtTipoDato.Text = frm.Descripcion_Seleccionado;
            }
        }

        private void BtnAplicar_Click(object sender, EventArgs e)
        {
            if (!BaseFuncionValidaciones())
                return;

            res = 0;
            msg = string.Empty;
            Int32 CampoIdentity = 0; 


            res = sql_Catalogos.In_Pacientes_Correos(ref CampoIdentity, PropiedadK_Paciente, _K_Tipo_Dato,txtCorreo.Text, GlobalVar.K_Usuario, ref msg);


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
            if (_K_Paciente_Correo == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN CORREO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dlg = MessageBox.Show("SERA ELIMINADO EL REGISTRO CON VALOR:\n" + Convert.ToString(grDatos.CurrentRow.Cells[2].Value.ToString()) + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                res = sql_Catalogos.Dl_Pacientes_Correos(PropiedadK_Paciente, Convert.ToInt32(grDatos.CurrentRow.Cells[0].Value.ToString()), GlobalVar.K_Usuario, ref msg);
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

            btnBuscaTipoDato.Focus();//Asignar el textbox que inicia el focus

            lblPac.Text = PropiedadD_Paciente;

        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (_K_Tipo_Dato  == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR EL TIPO DE DATO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscaTipoDato.Focus();
                return false;
            }
            if (txtCorreo.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL CORREO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return false;
            }

            BaseErrorResultado = false;
            return true;
        }

        //METODOS
        private void LlenaGrid(Int32 PropiedadK_Paciente)
        {
            try
            {
                _tiposdatos = sql_Catalogos.Sk_Pacientes_Correos(PropiedadK_Paciente);

                if (_tiposdatos != null)
                {
                    foreach (DataRow irow in _tiposdatos.Rows)
                    {
     
                        DataRow dtdRow = tiposdatos.NewRow();
                        dtdRow["K_Paciente_Correo"] = Convert.ToInt32(irow["K_Paciente_Correo"].ToString());
                        dtdRow["D_Tipo_Dato"] = irow["D_Tipo_Dato"].ToString();
                        dtdRow["Correo"] = irow["Correo"].ToString();
                        dtdRow["B_Activo"] = Convert.ToBoolean(irow["B_Activo"]);
                        tiposdatos.Rows.Add(dtdRow);

                    }
                    grDatos.DataSource = tiposdatos;
                    btnBuscaTipoDato.Focus();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

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
                _K_Paciente_Correo= Convert.ToInt32(grDatos.CurrentRow.Cells[0].Value.ToString());
                txtTipoDato.Text = grDatos.CurrentRow.Cells["D_Tipo_Dato"].Value.ToString();

            }
        }
    }
}
