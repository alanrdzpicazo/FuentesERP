﻿using System;
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
    public partial class FRM_PACIENTES_TELEFONOS : FormaBase
    {
        SQLCatalogos sql_Catalogos = new SQLCatalogos();
        int res = 0;
        string msg = string.Empty;

        public int PropiedadK_Paciente { get; set; }
        public string PropiedadD_Paciente { get; set; }
        public string Tipo_Telefono { get; set; }
        public string Telefono_Pasa { get; set; }
        public int Lada_Pasa { get; set; }
        public int Codigo_Pais_Pasa { get; set; }
        public int K_Telefono_Pasa { get; set; }

        Int32 _K_Tipo_Dato = 0;

        DataTable Telefonos = new DataTable();
        DataTable _Telefonos = new DataTable();

        public FRM_PACIENTES_TELEFONOS()
        {
            InitializeComponent();
        }

        private void FRM_PACIENTES_TELEFONOS_Load(object sender, EventArgs e)
        {
            Telefonos.Columns.Add("K_Paciente_Telefono", typeof(Int32));
            Telefonos.Columns.Add("K_Tipo_Dato", typeof(Int32));
            Telefonos.Columns.Add("D_Tipo_Dato", typeof(string));
            Telefonos.Columns.Add("Codigo_Pais", typeof(string));
            Telefonos.Columns.Add("Lada", typeof(Int32));
            Telefonos.Columns.Add("Telefono", typeof(Int32));
            Telefonos.Columns.Add("B_Activo", typeof(Boolean));
            limpia();
            LlenaGrid(PropiedadK_Paciente);
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

            btnBuscarTipoDato.Focus();//Asignar el textbox que inicia el focus

            lblPac.Text = PropiedadD_Paciente;

        }
        public override void BaseBotonBorrarClick()
        {
            if (Convert.ToInt32(grDatos.CurrentRow.Cells[0].Value.ToString()) == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN TELEFONO..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dlg = MessageBox.Show("SERA ELIMINADO EL REGISTRO CON VALOR:\n" + Convert.ToString(grDatos.CurrentRow.Cells[1].Value.ToString()) + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                res = sql_Catalogos.Dl_Pacientes_Telefonos(Convert.ToInt32(grDatos.CurrentRow.Cells[0].Value.ToString()), ref msg);
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
        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (txtTipoDato.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR UN TIPO DE DATO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTipoDato.Focus();
                return false;
            }
            if (txtCodigo.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL CODIGO DEL PAIS...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
                return false;
            }
            if (txtLada.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA LADA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLada.Focus();
                return false;
            }
            if (txtTelefono.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL TELEFONO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return false;
            }
            BaseErrorResultado = false;
            return true;
        }
        public override void BaseMetodoLimpiaControles()
        {
            _K_Tipo_Dato = 0;
            txtTipoDato.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            txtLada.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            pnlControl.Enabled = false; //NO Borrar        
        }
        private void BtnAplicar_Click(object sender, EventArgs e)
        {
            if (!BaseFuncionValidaciones())
                return;

            res = 0;
            msg = string.Empty;



            res = sql_Catalogos.In_Pacientes_Telefonos( PropiedadK_Paciente, _K_Tipo_Dato, txtCodigo.Text, Convert.ToInt32(txtLada.Text), Convert.ToInt32(txtTelefono.Text), ref msg);


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


                FRM_INGRESA_PEDIDOS frm2 = new FRM_INGRESA_PEDIDOS();
                FRM_MODIFICA_PEDIDO frmMod2 = new FRM_MODIFICA_PEDIDO();
                Telefono_Pasa = grDatos.Rows[indiceUltimaFila].Cells["Telefono"].Value.ToString();
                Lada_Pasa = Convert.ToInt32( grDatos.Rows[indiceUltimaFila].Cells["Lada"].Value.ToString());
                Codigo_Pais_Pasa = Convert.ToInt32(grDatos.Rows[indiceUltimaFila].Cells["Codigo_Pais"].Value.ToString());
                K_Telefono_Pasa = Convert.ToInt32(grDatos.Rows[indiceUltimaFila].Cells["K_Paciente_Telefono"].Value.ToString());
                this.Close();

            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(grDatos.CurrentRow.Cells[0].Value.ToString()) == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA TELEFONO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dlg = MessageBox.Show("SERA ELIMINADO EL REGISTRO CON VALOR:\n" + Convert.ToString(grDatos.CurrentRow.Cells[1].Value.ToString()) + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                res = sql_Catalogos.Dl_Pacientes_Telefonos( Convert.ToInt32(grDatos.CurrentRow.Cells[0].Value.ToString()), ref msg);
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
        private void btnBuscarTipoDato_Click(object sender, EventArgs e)
        {

            Busquedas.Frm_Busca_TipoDato frm = new Busquedas.Frm_Busca_TipoDato();
            frm.ShowDialog();

            if (_K_Tipo_Dato != frm.LLave_Seleccionado)
            {
                _K_Tipo_Dato = frm.LLave_Seleccionado;
                txtTipoDato.Text = frm.Descripcion_Seleccionado;
            }
        }
        private void grDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grDatos.CurrentRow != null)
            {
                if (Convert.ToInt32(grDatos.CurrentRow.Index) > -1)
                {
                    Tipo_Telefono = grDatos.CurrentRow.Cells["D_Tipo_Dato"].Value.ToString();
                    Telefono_Pasa = grDatos.CurrentRow.Cells["Telefono"].Value.ToString();
                    Lada_Pasa = Convert.ToInt32(grDatos.CurrentRow.Cells["Lada"].Value.ToString());
                    Codigo_Pais_Pasa = Convert.ToInt32(grDatos.CurrentRow.Cells["Codigo_Pais"].Value.ToString());
                    K_Telefono_Pasa = Convert.ToInt32(grDatos.CurrentRow.Cells["K_Paciente_Telefono"].Value.ToString());
                    this.Close();
                }
            }
        }
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) &&
                    e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtLada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) &&
                 e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) &&
                 e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }
        private void LlenaGrid(Int32 PropiedadK_Paciente)
        {
            try
            {
                _Telefonos = sql_Catalogos.Sk_Pacientes_Telefonos(PropiedadK_Paciente);

                if (_Telefonos != null)
                {
                    foreach (DataRow irow in _Telefonos.Rows)
                    {
                        DataRow dtdRow = Telefonos.NewRow();
                        dtdRow["K_Paciente_Telefono"] = Convert.ToInt32(irow["K_Paciente_Telefono"].ToString());
                        dtdRow["K_Tipo_Dato"] = Convert.ToInt32(irow["K_Tipo_Dato"].ToString());
                        dtdRow["D_Tipo_Dato"] = irow["D_Tipo_Dato"].ToString();
                        dtdRow["Codigo_Pais"] = irow["Codigo_Pais"].ToString(); 
                        dtdRow["Lada"] = Convert.ToInt32(irow["Lada"].ToString());
                        dtdRow["Telefono"] = Convert.ToInt32(irow["Telefono"].ToString());
                        dtdRow["B_Activo"] = Convert.ToBoolean(irow["B_Activo"].ToString());

                        Telefonos.Rows.Add(dtdRow);

                    }
                    grDatos.DataSource = Telefonos;

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


    }
}