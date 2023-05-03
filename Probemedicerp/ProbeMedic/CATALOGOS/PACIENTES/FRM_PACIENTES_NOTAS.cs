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
    public partial class FRM_PACIENTES_NOTAS : FormaBase
    {
        public int PropiedadK_Paciente { get; set; }
        public string PropiedadD_Paciente { get; set; }

        Int32 _K_Paciente_Nota_Seleccionado = 0;
        int res = 0;
        string msg = string.Empty;
        SQLCatalogos sql_Catalogos = new SQLCatalogos();

        DataTable pacientesnotas = new DataTable();
        DataTable _pacientesnotas = new DataTable();

        public FRM_PACIENTES_NOTAS()
        {
            InitializeComponent();
        }
        private void FRM_PACIENTES_NOTAS_Load(object sender, EventArgs e)
        {
            pacientesnotas.Columns.Add("K_Paciente_Nota", typeof(Int32));
            pacientesnotas.Columns.Add("Nota", typeof(string));
            pacientesnotas.Columns.Add("F_Registro", typeof(DateTime));
            pacientesnotas.Columns.Add("B_Activo", typeof(Boolean));
            limpia();

            LlenaGrid(PropiedadK_Paciente);
        }

        private void BtnAplicar_Click(object sender, EventArgs e)
        {
            if (!BaseFuncionValidaciones())
                return;

            res = 0;
            msg = string.Empty;
            Int32 CampoIdentity = 0;


            res = sql_Catalogos.In_Pacientes_Notas(ref CampoIdentity, PropiedadK_Paciente, txtNota.Text, GlobalVar.K_Usuario, ref msg);


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

        private void button1_Click(object sender, EventArgs e)
        {
            if (_K_Paciente_Nota_Seleccionado == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA NOTA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dlg = MessageBox.Show("SERA ELIMINADO EL REGISTRO CON VALOR:\n" + Convert.ToString(grDatos.CurrentRow.Cells[1].Value.ToString()) + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                res = sql_Catalogos.Dl_Pacientes_Notas(Convert.ToInt32(grDatos.CurrentRow.Cells[0].Value.ToString()), GlobalVar.K_Usuario, ref msg);
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

            txtNota.Focus();//Asignar el textbox que inicia el focus

            lblPac.Text = PropiedadD_Paciente;

        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (txtNota.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA NOTA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNota.Focus();
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
                _pacientesnotas = sql_Catalogos.Sk_Pacientes_Notas(PropiedadK_Paciente);

                if (_pacientesnotas != null)
                {
                    foreach (DataRow irow in _pacientesnotas.Rows)
                    {

                        DataRow dtdRow = pacientesnotas.NewRow();
                        dtdRow["K_Paciente_Nota"] = Convert.ToInt32(irow["K_Paciente_Nota"].ToString());
                        dtdRow["Nota"] =irow["Nota"].ToString();
                        dtdRow["F_Registro"] = Convert.ToDateTime(irow["F_Registro"].ToString());
                        dtdRow["B_Activo"] = Convert.ToBoolean(irow["B_Activo"]);
                        pacientesnotas.Rows.Add(dtdRow);

                    }
                    grDatos.DataSource = pacientesnotas;
                    txtNota.Focus();

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
            txtNota.Text = String.Empty;
        }

        private void grDatos_SelectionChanged(object sender, EventArgs e)
        {
            if (grDatos.Rows.Count > 0)
            {
                _K_Paciente_Nota_Seleccionado = Convert.ToInt32(grDatos.CurrentRow.Cells[0].Value.ToString());

            }
        }

        private void lblPac_Click(object sender, EventArgs e)
        {

        }
    }
}
