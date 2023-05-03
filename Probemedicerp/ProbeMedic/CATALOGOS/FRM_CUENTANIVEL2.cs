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
    public partial class FRM_CUENTANIVEL2 : FormaCatalogo
    {
        int res = 0;
        string msg = string.Empty;
        SQLCatalogos sql_Catalogos = new SQLCatalogos();
        Funciones fx = new Funciones();

        public FRM_CUENTANIVEL2()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            txtFocus = this.txtClave; //Asignar el textbox que inicia el focus
            pnlControles.Enabled = false; //NO Borrar

            BaseDtDatos = sql_Catalogos.Sk_Cuenta_Nivel2();
            CatalogoPropiedadCampoClave = "K_Cuenta";
            CatalogoPropiedadCampoDescripcion = "D_Cuenta";
            BaseBotonNuevo.Enabled = true;

            base.BaseMetodoInicio();

            BaseBotonBorrar.Visible = false;
        }
        public override void BaseBotonGuardarClick()
        {
            if (!BaseFuncionValidaciones())
                return;

            res = 0;
            msg = string.Empty;


            if (CatalogoPropiedadEsRegistroNuevo) // Nuevo
            {
                res = sqlCatalogos.In_Cuenta_Nivel2(ucCuentaMayor1.K_Cuenta_Mayor, Convert.ToInt32(txtClave.Text), txtDescripcion.Text, txtCuenta.Text, ref msg);

            }
            else //Existe. Update
            {
                res = sqlCatalogos.Up_Cuenta_Nivel2(ucCuentaMayor1.K_Cuenta_Mayor, Convert.ToInt32(txtClave.Text), txtDescripcion.Text.Trim(), txtCuenta.Text, ref msg);
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


        public override void CatalogoHabilitaPanelControles(bool B_Habilita)
        {
            pnlControles.Enabled = B_Habilita;
        }

        public override void BaseMetodoLimpiaControles()
        {
            this.txtClave.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;
            this.txtCuenta.Text = string.Empty;
            ucCuentaMayor1.K_Cuenta_Mayor = 0;
            ucCuentaMayor1.txt_G_Cuenta.Text = "";
            txtClave.Text = "";
            pnlControles.Enabled = false; //NO Borrar        
        }

        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();
            this.ucCuentaMayor1.K_Cuenta_Mayor = Convert.ToInt32(ren["K_Cuenta_Mayor"].ToString());
            this.ucCuentaMayor1.txt_G_Cuenta.Text = ren["D_Cuenta_Mayor"].ToString();
            this.txtClave.Text = ren["K_Cuenta"].ToString();
            this.txtDescripcion.Text = ren["D_Cuenta"].ToString();
            this.txtCuenta.Text = ren["Cuenta"].ToString();

        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (this.ucCuentaMayor1.txt_G_Cuenta.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA CUENTA MAYOR ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClave.Focus();
                return false;
            }

            if (this.txtClave.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL NUMERO DE CUENTA ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClave.Focus();
                return false;
            }
            if (this.txtDescripcion.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR DESCRIPCION ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                return false;
            }
            if (this.txtCuenta.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA CUENTA ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCuenta.Focus();
                return false;
            }

            BaseErrorResultado = false;
            return true;
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((fx.EsDatoNumerico(e.KeyChar.ToString())) || (e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}