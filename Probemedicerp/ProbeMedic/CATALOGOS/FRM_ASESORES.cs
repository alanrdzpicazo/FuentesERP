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

namespace ProbeMedic.CATALOGOS
{
    public partial class FRM_ASESORES : FormaCatalogo
    {
        int res = 0;
        string msg = string.Empty;
        SQLCatalogos CatalogoSQL = new SQLCatalogos();
        DataTable _Comisiones = new DataTable();

        public FRM_ASESORES()
        {
            InitializeComponent();
        }

        public override void BaseMetodoInicio()
        {
            txtFocus = txtClave; //Asignar el textbox que inicia el focus
            pnlControles.Enabled = false; //NO Borrar

            BaseDtDatos = CatalogosSQL.Sk_Asesores();
            CatalogoPropiedadCampoClave = "K_Asesor";
            CatalogoPropiedadCampoDescripcion = "Nombre";

            dbgDias.AutoGenerateColumns = false;

            base.BaseMetodoInicio();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))
            {                            
                e.Handled = false;               
            }
            else
            {

                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))
            {
                e.Handled = false;
            }
            else
            {              
                e.Handled = true;              
            }
        }

        public override void BaseBotonGuardarClick()
        {
            if (!BaseFuncionValidaciones())
                return;

            res = 0;
            msg = string.Empty;
            Int32 CampoIdentity = 0; //ESTE ME DEVOLVERA LA CLAVE DEL PAIS YA QUE ES IDENTITY

            if (CatalogoPropiedadEsRegistroNuevo) // Nuevo
            {
                res = sqlCatalogos.In_Asesores(ref CampoIdentity, ucUsuarios1.K_Usuario, txtDescripcion.Text, ref msg);

            }
            else //Existe. Update
            {
                CampoIdentity = Convert.ToInt16(CatalogoPropiedadId_Identity);
                res = sqlCatalogos.Up_Asesores(CampoIdentity,
                    txtDescripcion.Text, ucUsuarios1.K_Usuario, ref msg);
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

        public override void BaseBotonBorrarClick()
        {
            if (txtClave.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN ASESOR...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dlg = MessageBox.Show("SERA ELIMINADO EL REGISTRO CON VALOR:\n" + txtDescripcion.Text.Trim() + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                res = sqlCatalogos.Dl_Asesores(Convert.ToInt16(CatalogoPropiedadId_Identity), GlobalVar.K_Usuario, ref msg);

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
                    BaseMetodoInicio();
                    BaseBotonCancelarClick();
                }

            }
        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (txtDescripcion.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR DESCRIPCION...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                return false;
            }

            BaseErrorResultado = false;
            return true;
        }

        public override void CatalogoHabilitaPanelControles(bool B_Habilita)
        {
            pnlControles.Enabled = B_Habilita;
            if (txtClave.Text.Trim().Length == 0)
            {
                txtDias.Enabled = false;
                txtPorcentaje.Enabled = false;
                BtnAgregar.Enabled = false;
                BtnEliminar.Enabled = false;
            }
            else
            {
                txtDias.Enabled = true;
                txtPorcentaje.Enabled = true;
                BtnAgregar.Enabled = true;
                BtnEliminar.Enabled = true;
            }
            txtDescripcion.Focus();
        }

        public override void BaseMetodoLimpiaControles()
        {
            txtClave.Text = string.Empty;
            ucUsuarios1.K_Usuario = 0;
            ucUsuarios1.txt_E_Usuario.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtPorcentaje.Text = string.Empty;
            txtDias.Text = string.Empty;
            dbgDias.DataSource = null;
            pnlControles.Enabled = false; //NO Borrar        
        }

        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            txtClave.Text = ren["K_Asesor"].ToString();
            ucUsuarios1.K_Usuario = Convert.ToInt32(ren["K_Usuario"].ToString());
            ucUsuarios1.txt_E_Usuario.Text = ren["D_Usuario"].ToString();
            txtDescripcion.Text = ren["Nombre"].ToString();

            //Consulta grid si clave es mayor a cero 
            if (txtClave.Text.Trim().Length > 0)
            {
                LlenaGrid(Convert.ToInt32(txtClave.Text));
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //Insert y luego consulta 
            if (txtClave.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN ASESOR...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtDias.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE INDICAR EN LOS DIAS...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPorcentaje.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE INDICAR EL PORCENTAJE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToDecimal( txtPorcentaje.Text) < 0)
            {
                MessageBox.Show("DEBE INDICAR EL PORCENTAJE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            res = sqlCatalogos.In_Asesores_TipoComision (Convert.ToInt32(txtClave.Text), Convert.ToInt32(txtDias.Text), Convert.ToDecimal(txtPorcentaje.Text), ref msg);
            if (res == -1)
            {
                BaseErrorResultado = true;
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LlenaGrid(Convert.ToInt32(txtClave.Text));
        }

        private void LlenaGrid(Int32 PropiedadK_Asesor)
        {
            _Comisiones = sqlCatalogos.Sk_Asesores_TipoComision(PropiedadK_Asesor);
         
            if(_Comisiones!=null)
            {
                if(_Comisiones.Rows.Count>0)
                {
                    dbgDias.DataSource = _Comisiones;
                }
                else
                {
                    dbgDias.DataSource = null;
                }
            }
            else
            {
                dbgDias.DataSource = null;
            }

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //Elimina y luego consulta 

            if(dbgDias.CurrentRow!=null)
            {
                res = sqlCatalogos.Dl_Asesores_TIpoComision(Convert.ToInt32(txtClave.Text), Convert.ToInt32(dbgDias.CurrentRow.Cells["Dias"].Value.ToString()), ref msg);

                if (res == -1)
                {
                    BaseErrorResultado = true;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                LlenaGrid(Convert.ToInt32(txtClave.Text));
            }
                       
        }
      
        private void txtDias_TextChanged(object sender, EventArgs e)
        {
            if (txtDias.Text.Trim().Length > 0)
                if (Convert.ToInt32(txtDias.Text.Trim()) > 365)
                {
                    MessageBox.Show("VALOR DEMASIADO GRANDE!..." , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDias.Text = string.Empty;
                }
        }

        private void txtPorcentaje_TextChanged(object sender, EventArgs e)
        {
            if (txtPorcentaje.Text.Trim().Length > 0)
                if (Convert.ToInt32(txtPorcentaje.Text.Trim()) > 100)
                {
                    MessageBox.Show("VALOR DEMASIADO GRANDE!..." , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPorcentaje.Text = string.Empty;
                }
        }
    }
}