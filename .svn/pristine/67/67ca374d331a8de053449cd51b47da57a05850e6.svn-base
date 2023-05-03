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
using ProbeMedic.PEDIDOS;

namespace ProbeMedic.CATALOGOS.PACIENTES
{
    public partial class FRM_PACIENTES_MEDICOS : FormaBase
    {
        public FRM_PACIENTES_MEDICOS()
        {
            InitializeComponent();
        }

        public int PropiedadK_Paciente { get; set; }
        public string PropiedadD_Paciente { get; set; }
        public int K_Medico_Pasa { get; set; }
        public string D_Medico_Pasa { get; set; }
        public bool B_DesdeCatalogo { get; set; }

        Int32 _K_Medico = 0;

        Int32 _K_Medico_Seleccion = 0;
        int res = 0;
        string msg = string.Empty;
        SQLCatalogos sql_Catalogos = new SQLCatalogos();

        DataTable medicos = new DataTable();
        DataTable _medicos = new DataTable();

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

            B_DesdeCatalogo = true;

            btnBuscarMedico.Focus();//Asignar el textbox que inicia el focus    
        }

        private void LlenaGrid(Int32 PropiedadK_Paciente)
        {
            try
            {
                _medicos = sql_Catalogos.Sk_Pacientes_Medicos(PropiedadK_Paciente);

                if (_medicos != null)
                {
                    foreach (DataRow irow in _medicos.Rows)
                    {
                        DataRow dtdRow = medicos.NewRow();
                        dtdRow["K_Medico"] = Convert.ToInt32(irow["K_Medico"]);
                        dtdRow["Medico"] = irow["Medico"].ToString();
                        dtdRow["F_Asignacion"] = irow["F_Asignacion"].ToString();
                        dtdRow["D_Profesion"] = irow["D_Profesion"].ToString();
                        dtdRow["D_Especialidad"] = irow["D_Especialidad"];
                        dtdRow["Correo"] = irow["Correo"].ToString();
                        dtdRow["B_Tratante"] = Convert.ToBoolean(irow["B_Tratante"]);
                        dtdRow["B_Dictaminador"] = Convert.ToBoolean(irow["B_Dictaminador"]);
                        medicos.Rows.Add(dtdRow);

                    }
                    grDatos.DataSource = medicos;    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        public override void BaseMetodoLimpiaControles()
        {
            _K_Medico = 0;
            txtMedico.Text = string.Empty;
            B_DesdeCatalogo = true;

            pnlControl.Enabled = false; //NO Borrar        
        }

        public override void BaseBotonBorrarClick()
        {
            if (_K_Medico_Seleccion == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN MEDICO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
     
            DialogResult dlg = MessageBox.Show("SERA ELIMINADO EL REGISTRO CON VALOR:\n" + Convert.ToString(grDatos.CurrentRow.Cells[1].Value.ToString()) + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                res = sql_Catalogos.Dl_Pacientes_Medicos(Convert.ToInt32(grDatos.CurrentRow.Cells[0].Value.ToString()), PropiedadK_Paciente, GlobalVar.K_Usuario, ref msg);
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
                     
            res = sql_Catalogos.In_Pacientes_Medicos(_K_Medico,PropiedadK_Paciente, ref msg);
         
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

            if (txtMedico.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR EL MEDICO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMedico.Focus();
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
            Busquedas.Frm_Busca_Medico frm = new Busquedas.Frm_Busca_Medico();
            frm.ShowDialog();
            if(frm.LLave_Seleccionado==0)
            {
                _K_Medico = 0;
                txtMedico.Text = string.Empty;
            }
            else
            {
                _K_Medico = frm.LLave_Seleccionado;
                txtMedico.Text = frm.Descripcion_Seleccionado;
            }
        }

        private void FRM_PACIENTES_MEDICOS_Load(object sender, EventArgs e)
        {
            medicos.Columns.Add("K_Medico", typeof(Int32));
            medicos.Columns.Add("Medico", typeof(string));
            medicos.Columns.Add("F_Asignacion", typeof(string));
            medicos.Columns.Add("D_Profesion", typeof(string));
            medicos.Columns.Add("D_Especialidad", typeof(string));
            medicos.Columns.Add("Correo", typeof(string));
            medicos.Columns.Add("B_Tratante", typeof(bool));
            medicos.Columns.Add("B_Dictaminador", typeof(bool));   
            limpia();

            LlenaGrid(PropiedadK_Paciente);

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
            //if (grDatos.Rows.Count > 0)
            //{
            //    _K_Medico_Seleccion = Convert.ToInt32(grDatos.CurrentRow.Cells[0].Value.ToString());
            //     txtMedico.Text = grDatos.CurrentRow.Cells["Medico"].Value.ToString();
            //}
        }

        private void BtnAplicar_Click(object sender, EventArgs e)
        {
            if (!BaseFuncionValidaciones())
                return;

            res = 0;
            msg = string.Empty;

            res = sql_Catalogos.In_Pacientes_Medicos(_K_Medico, PropiedadK_Paciente, ref msg);

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

                int indiceUltimaFila = grDatos.Rows.Count - 1;
                //  grDatos.Rows[indiceUltimaFila].Selected = true;
                DataGridViewSelectedRowCollection filasSeleccionadas = grDatos.SelectedRows;

                grDatos.FirstDisplayedScrollingRowIndex = indiceUltimaFila;

                if(!B_DesdeCatalogo)
                {
                    D_Medico_Pasa = grDatos.Rows[indiceUltimaFila].Cells["Medico"].Value.ToString();
                    K_Medico_Pasa = Convert.ToInt32(grDatos.Rows[indiceUltimaFila].Cells["K_Medico"].Value.ToString());
                    this.Close();
                }
               

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grDatos.CurrentRow==null)
            {
                MessageBox.Show("DEBE SELECCIONAR UN MEDICO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                grDatos.Focus();
                return;
            }

            DialogResult dlg = MessageBox.Show("SERA ELIMINADO EL REGISTRO CON VALOR:\n" + Convert.ToString(grDatos.CurrentRow.Cells[1].Value.ToString()) + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                res = sql_Catalogos.Dl_Pacientes_Medicos(Convert.ToInt32(grDatos.CurrentRow.Cells[0].Value.ToString()), PropiedadK_Paciente, GlobalVar.K_Usuario, ref msg);
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

        private void grDatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!B_DesdeCatalogo)
            {
                K_Medico_Pasa = Convert.ToInt32(grDatos.CurrentRow.Cells["K_Medico"].Value.ToString());
                D_Medico_Pasa = grDatos.CurrentRow.Cells["Medico"].Value.ToString();
                Close();
            }
        }
    }
}
