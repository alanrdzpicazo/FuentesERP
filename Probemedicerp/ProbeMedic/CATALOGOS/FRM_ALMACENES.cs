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
    public partial class FRM_ALMACENES : FormaCatalogo
    {
        int res = 0;
        string msg = string.Empty;
        SQLCatalogos CatalogoSQL = new SQLCatalogos();
        public FRM_ALMACENES()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            txtFocus = txtClave; //Asignar el textbox que inicia el focus
            pnlControles.Enabled = false; //NO Borrar

            BaseDtDatos = CatalogosSQL.Sk_Almacenes();
            CatalogoPropiedadCampoClave = "K_Almacen";
            CatalogoPropiedadCampoDescripcion = "D_Almacen";

            //System.Windows.Forms.Integration.ElementHost elementHost1 = new System.Windows.Forms.Integration.ElementHost();

            //System.Windows.Controls.TextBox textBox = new System.Windows.Controls.TextBox();

            //textBox.SpellCheck.IsEnabled = true;
            //textBox.Text = "HOLA";
            //elementHost1.Child = textBox;
            //elementHost1.Location = new Point(492,252);
            //this.Controls.Add(elementHost1);
            base.BaseMetodoInicio();
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
                res = sqlCatalogos.In_Almacenes(ref CampoIdentity,ucOficinas.K_Oficina, txtDescripcion.Text,
                    cbxDevoluciones.Checked,GlobalVar.K_Usuario,TxtCuenta.Text,txtCorto.Text.Trim(),ref msg);

            }
            else //Existe. Update
            {
                CampoIdentity = Convert.ToInt16(CatalogoPropiedadId_Identity);
                res = sqlCatalogos.Up_Almacenes(CampoIdentity,ucOficinas.K_Oficina,
                    txtDescripcion.Text,cbxDevoluciones.Checked,GlobalVar.K_Usuario,TxtCuenta.Text, txtCorto.Text.Trim(), ref msg);
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
                MessageBox.Show("DEBE SELECCIONAR UN REGISTRO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dlg = MessageBox.Show("SERA ELIMINADO EL REGISTRO CON VALOR:\n" + txtDescripcion.Text.Trim() + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                res = sqlCatalogos.Dl_Almacenes(Convert.ToInt16(CatalogoPropiedadId_Identity),GlobalVar.K_Usuario, ref msg);

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
            if (txtDescripcion.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR DESCRIPCION CORTA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                return false;
            }

            BaseErrorResultado = false;
            return true;
        }
        public override void CatalogoHabilitaPanelControles(bool B_Habilita)
        {
            pnlControles.Enabled = B_Habilita;
        }
        public override void BaseMetodoLimpiaControles()
        {
            txtClave.Text = string.Empty;
            ucOficinas.K_Oficina = 0;
            ucOficinas.txt_E_Oficina.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtCorto.Text = string.Empty;
            cbxDevoluciones.Checked = false;

            pnlControles.Enabled = false; //NO Borrar        
        }
        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();
            txtClave.Text = ren["K_Almacen"].ToString();
            ucOficinas.K_Oficina = Convert.ToInt32(ren["K_Oficina"].ToString());
            ucOficinas.txt_E_Oficina.Text = ren["D_Oficina"].ToString();
            txtDescripcion.Text = ren["D_Almacen"].ToString();
            txtCorto.Text = ren["C_Almacen"].ToString();
            cbxDevoluciones.Checked = Convert.ToBoolean(ren["B_AceptaDevolucionesCliente"].ToString());
            TxtCuenta.Text = ren["Cuenta"].ToString();

        }
        private void TxtCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((EsNumero(e.KeyChar) || (e.KeyChar == Convert.ToChar(Keys.Back))))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtCuenta_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TxtCuenta.Text.Trim().Length > 0)
                {
                    Int32 Valor = Int32.Parse(TxtCuenta.Text.Trim());
                }
            }
            catch
            {
                MessageBox.Show("VALOR DEMASIADO GRANDE!..." , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCuenta.Text = string.Empty;
                return;
            }
        }

       
    }
}