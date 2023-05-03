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

namespace ProbeMedic.CATALOGOS.LABORATORIOS
{
    public partial class FRM_PROGRAMA_PACIENTES: FormaBase
    {
        SQLPrecios sql_precios = new SQLPrecios();
        DataTable articulos = new DataTable();
        DataTable articulos_ = new DataTable();
        int res = -1, entra = 1;
        string msg = string.Empty;
        Int32 _K_Programa = 0;
        Int32 _K_Paciente = 0;
        Int32 _K_Aseguradora= 0;

        public FRM_PROGRAMA_PACIENTES()
        {
            InitializeComponent();
            cambia_fuente_controles();
            BaseBotonAfectar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonReporte.Visible = false;
        }

        private void FRM_PROGRAMA_ASEGURADORA_Load(object sender, EventArgs e)
        {
            btnBuscarPrograma.Focus();
            articulos.Columns.Add("K_Articulo", typeof(Int32));
            articulos.Columns.Add("D_Articulo", typeof(string));
            articulos.Columns.Add("D_Programa", typeof(string));
            articulos.Columns.Add("D_Aseguradora", typeof(string));
            articulos.Columns.Add("K_Laboratorio", typeof(Int32));
            articulos.Columns.Add("D_Laboratorio", typeof(string));
            articulos.Columns.Add("B_Asignado", typeof(Boolean));

            limpia();
        }

        public bool CatalogoPropiedadEsRegistroNuevo { get; set; }

        public object CatalogoPropiedadId_Identity { get; set; }
        
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (_K_Aseguradora == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR UNA ASEGURADORA..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscaAseguradora.Focus();
                return;
            }
            if (_K_Programa == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR UN PROGRAMA..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscarPrograma.Focus();
                return;
            }
            if (_K_Paciente == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR UN PACIENTE..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscarPaciente.Focus();
                return;
            }
            if (_K_Programa != 0)

                if (entra == Convert.ToInt32(0))
                {
                    limpia();
                }
            entra = 0;
            LlenaGrid();

            if (dgvDisponibles.DataSource == null)
            {
                MessageBox.Show("NO EXISTEN ARTICULOS ASIGNADO AL PROGRAMA!..", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void BtnAplicar_Click(object sender, EventArgs e)
        {
            if (!BaseFuncionValidaciones())
                return;

            msg = string.Empty;
           
            if (dgvDisponibles.DataSource == null)
            {
                MessageBox.Show("NO EXISTEN ARTICULOS ASIGNADOS AL PROGRAMA!..");
                return;
            }

            if (dgvDisponibles.DataSource!= null)
            {

                foreach (DataGridViewRow row in dgvDisponibles.Rows)
                {
                    
                    res = sql_precios.In_Programas_Pacientes(
                    Convert.ToInt16(_K_Programa),
                    Convert.ToInt32(row.Cells["K_Articulo"].Value),
                    Convert.ToInt32(_K_Aseguradora),
                    Convert.ToInt32(_K_Paciente),
                    Convert.ToInt32(GlobalVar.K_Usuario),
       
                    ref msg);
                    
                    
                }
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


            base.BaseBotonAfectarClick();
            


        }

        private void LlenaGrid()
        {

            articulos_ = sql_precios.Gp_Articulos_Programa_Paciente(_K_Programa,_K_Aseguradora,_K_Paciente);

            if (articulos_ != null)
            {
                foreach (DataRow irow in articulos_.Rows)
                {
                    DataRow dtdRow = articulos.NewRow();
                    dtdRow["K_Articulo"] = Convert.ToInt32(irow["K_Articulo"]);
                    dtdRow["D_Articulo"] = irow["D_Articulo"].ToString();
                    dtdRow["D_Programa"] = irow["D_Programa"].ToString();
                    dtdRow["D_Aseguradora"] = irow["D_Aseguradora"].ToString();
                    dtdRow["K_Laboratorio"] = Convert.ToInt32(irow["K_Laboratorio"].ToString());
                    dtdRow["D_Laboratorio"] = irow["D_Laboratorio"];
                    dtdRow["B_Asignado"] = Convert.ToBoolean(irow["B_Asignado"]);
                    articulos.Rows.Add(dtdRow);

                }
                dgvDisponibles.DataSource = articulos;
            }
        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (_K_Programa == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR UN PROGRAMA..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscarPrograma.Focus();
                return false;
            }
            if (_K_Aseguradora == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR UNA ASEGURADORA..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscaAseguradora.Focus();
                return false;
            }
            if (_K_Paciente == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR UN PACIENTE..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscarPaciente.Focus();
                return false;
            }
       

            BaseErrorResultado = false;
            return true;
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            GlobalVar.dtPreciosAmbulancia = sqlCatalogos.Sk_Pacientes();
            Busquedas.Frm_Busca_Paciente frm = new Busquedas.Frm_Busca_Paciente();
            frm.ShowDialog();
            _K_Paciente = frm.LLave_Seleccionado;
            txtPaciente.Text = frm.Descripcion_Seleccionado;
        }

        private void btnBuscaAseguradora_Click(object sender, EventArgs e)
        {
            GlobalVar.dtPreciosAmbulancia = sqlCatalogos.Sk_Programas();
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

        private void FRM_PROGRAMA_PACIENTES_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            {
                if (!BaseFuncionValidaciones())
                    return;

                msg = string.Empty;

                if (dgvDisponibles.DataSource == null)
                {
                    MessageBox.Show("NO EXISTEN ARTICULOS ASIGNADOS AL PROGRAMA!..");
                    return;
                }

                if (dgvDisponibles.DataSource != null)
                {

                    foreach (DataGridViewRow row in dgvDisponibles.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Autoriza"].Value) == true)
                        {
                            res = sql_precios.In_Programas_Pacientes(
                            Convert.ToInt16(_K_Programa),
                            Convert.ToInt32(row.Cells["K_Articulo"].Value),
                            Convert.ToInt32(_K_Aseguradora),
                            Convert.ToInt32(_K_Paciente),
                            Convert.ToInt32(GlobalVar.K_Usuario),

                            ref msg);
                        }

                    }
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


                base.BaseBotonAfectarClick();
            }

            if (e.KeyCode == Keys.F11)
            {
                if (_K_Aseguradora == 0)
                {
                    MessageBox.Show("FALTA SELECCIONAR UNA ASEGURADORA..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnBuscaAseguradora.Focus();
                    return;
                }
                if (_K_Programa == 0)
                {
                    MessageBox.Show("FALTA SELECCIONAR UN PROGRAMA..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnBuscarPrograma.Focus();
                    return;
                }
                if (_K_Programa != 0)

                    if (entra == Convert.ToInt32(0))
                    {
                        limpia();
                    }
                entra = 0;
                LlenaGrid();

                if (dgvDisponibles.DataSource == null)
                {
                    MessageBox.Show("NO EXISTEN ARTICULOS ASIGNADO AL PROGRAMA!..", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
        }

        private void limpia()
        {

            if (dgvDisponibles.RowCount > 0)
            {
                DataTable dt2 = (DataTable)dgvDisponibles.DataSource;
                dt2.Clear();
            }
        }

     
    }
}
