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
    public partial class FRM_PACIENTES_MEDICAMENTOS : FormaBase
    {
        public int PropiedadK_Paciente { get; set; }
        public string PropiedadD_Paciente { get; set; }

        Int32 _K_Paciente_Medicamento_Seleccion= 0;
        Int32 _K_Articulo = 0;
        string _D_Articulo;
        int res = 0;
        string msg = string.Empty;
        SQLCatalogos sql_Catalogos = new SQLCatalogos();

        DataTable pacientesmedicamentos = new DataTable();
        DataTable _pacientesmedicamentos = new DataTable();

        public FRM_PACIENTES_MEDICAMENTOS()
        {
            InitializeComponent();
        }

        private void FRM_PACIENTES_MEDICAMENTOS_Load(object sender, EventArgs e)
        {
            pacientesmedicamentos.Columns.Add("K_Paciente_Medicamento", typeof(Int32));
            pacientesmedicamentos.Columns.Add("K_Articulo", typeof(Int32));
            pacientesmedicamentos.Columns.Add("D_Articulo", typeof(string));
            pacientesmedicamentos.Columns.Add("Cantidad", typeof(Int32));
            pacientesmedicamentos.Columns.Add("B_Activo", typeof(Boolean));
            limpia();

            LlenaGrid(PropiedadK_Paciente);
        }

        private void btnBuscaArticulo_Click(object sender, EventArgs e)
        {
            FILTROS.Frm_Filtro_Articulo frm = new FILTROS.Frm_Filtro_Articulo();
            frm.ShowDialog();
            _K_Articulo = frm.LLave_Seleccionado;
            txtArticulo.Text = frm.Descripcion_Seleccionado;
        }

        private void BtnAplicar_Click(object sender, EventArgs e)
        {
            if (!BaseFuncionValidaciones())
                return;

            res = 0;
            msg = string.Empty;
            Int32 CampoIdentity = 0;


            res = sql_Catalogos.In_Pacientes_Medicamentos(ref CampoIdentity, PropiedadK_Paciente, _K_Articulo, Convert.ToInt32(txtCantidad.Text), GlobalVar.K_Usuario, ref msg);


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
            if (_K_Paciente_Medicamento_Seleccion == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN MEDICAMENTO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dlg = MessageBox.Show("SERA ELIMINADO EL REGISTRO CON VALOR:\n" + Convert.ToString(grDatos.CurrentRow.Cells[2].Value.ToString()) + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                res = sql_Catalogos.Dl_Pacientes_Medicamentos(PropiedadK_Paciente, Convert.ToInt32(grDatos.CurrentRow.Cells[0].Value.ToString()), GlobalVar.K_Usuario, ref msg);
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

        private void grDatos_SelectionChanged(object sender, EventArgs e)
        {
            if(grDatos.Rows.Count > 0)
            {
                _K_Paciente_Medicamento_Seleccion = Convert.ToInt32(grDatos.CurrentRow.Cells[0].Value.ToString());
                txtArticulo.Text = grDatos.CurrentRow.Cells["D_Articulo"].Value.ToString();

            }
        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (_K_Articulo== 0)
            {
                MessageBox.Show("FALTA SELECCIONAR EL ARTICULO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscaArticulo.Focus();
                return false;
            }
            if (txtCantidad.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA CANTIDAD...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidad.Focus();
                return false;
            }

            BaseErrorResultado = false;
            return true;
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

            btnBuscaArticulo.Focus();//Asignar el textbox que inicia el focus

            lblPac.Text = PropiedadD_Paciente;

        }
        //METODOS
        private void LlenaGrid(Int32 PropiedadK_Paciente)
        {
            try
            {
                _pacientesmedicamentos= sql_Catalogos.Sk_Pacientes_Medicamentos(PropiedadK_Paciente);

                if (_pacientesmedicamentos != null)
                {
                    foreach (DataRow irow in _pacientesmedicamentos.Rows)
                    {

                        DataRow dtdRow = pacientesmedicamentos.NewRow();
                        dtdRow["K_Paciente_Medicamento"] = Convert.ToInt32(irow["K_Paciente_Medicamento"].ToString());
                        dtdRow["K_Articulo"] = Convert.ToInt32(irow["K_Articulo"].ToString());
                        dtdRow["D_Articulo"] = irow["D_Articulo"].ToString();
                        dtdRow["Cantidad"] = irow["Cantidad"].ToString();
                        dtdRow["B_Activo"] = Convert.ToBoolean(irow["B_Activo"]);
                        pacientesmedicamentos.Rows.Add(dtdRow);

                    }
                    grDatos.DataSource = pacientesmedicamentos;
                    btnBuscaArticulo.Focus();

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

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((EsNumero(e.KeyChar.ToString()) || e.KeyChar ==  (Convert.ToChar(Keys.Back))))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            Int32 valor = 0;
            if(txtCantidad.Text.Trim().Length>0)
            {
                if(!Int32.TryParse(txtCantidad.Text.Trim(),out valor))
                {
                    MessageBox.Show("VALOR NO VALIDO!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCantidad.Text = string.Empty;
                    txtCantidad.Focus();
                }
            }
        }
    }
}
