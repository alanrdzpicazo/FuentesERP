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

namespace ProbeMedic.CATALOGOS.PROVEEDORES
{
    public partial class FRM_PROVEEDORES_CUENTAS_BANCARIAS : FormaCatalogo
    {
        public TextBox txt_PB_Banco
        {
            get { return this.txtBanco; }
        }
        public Int32 K_Banco;
        int Cuenta = 0;
        int res = 0;
        string msg = string.Empty;
        SQLCatalogos sql_Catalogos = new SQLCatalogos();
        Funciones fx = new Funciones();
        public int PropiedadK_Proveedor { get; set; }
        public string PropiedadD_Proveedor { get; set; }
        public FRM_PROVEEDORES_CUENTAS_BANCARIAS()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Banco_SinParametro frm = new Busquedas.Frm_Busca_Banco_SinParametro();
            frm.ShowDialog();

            if (K_Banco != frm.LLave_Seleccionado)
            {
                K_Banco = frm.LLave_Seleccionado;
                txtBanco.Text = frm.Descripcion_Seleccionado;
            }
        }
        public override void BaseMetodoInicio()
        {
            BaseBotonModificar.Visible = false;

            btnBuscar.Focus(); //Asignar el textbox que inicia el focus
            pnlControles.Enabled = false; //NO Borrar

            BaseDtDatos = sql_Catalogos.Sk_proveedores_cuentas_bancarias(PropiedadK_Proveedor);
            CatalogoPropiedadCampoClave = "K_Banco";
            CatalogoPropiedadCampoDescripcion = "D_Banco";

            lblProveedor.Text = PropiedadD_Proveedor;

            base.BaseMetodoInicio();
        }

        public override void CatalogoHabilitaPanelControles(bool B_Habilita)
        {
            pnlControles.Enabled = B_Habilita;
            btnBuscar.Focus();
        }

        public override void BaseMetodoLimpiaControles()
        {
            K_Banco = 0;
            txtBanco.Text = string.Empty;
            txtCuenta.Text = string.Empty;
            txtClabe.Text = String.Empty;

            cbxCheque.Checked = false;
            cbxDolares.Checked = false;
            cbxTransferencia.Checked = false;      
            pnlControles.Enabled = false; //NO Borrar        
        }

        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();
            txtClave.Text = ren["K_Cuenta_Proveedor"].ToString();
            txtBanco.Text = ren["D_Banco"].ToString();
            txtCuenta.Text = ren["Numero_Cuenta"].ToString();
            txtClabe.Text = ren["Cuenta_Clabe"].ToString();
            cbxCheque.Checked = Convert.ToBoolean(ren["B_Cheque"]);
            cbxTransferencia.Checked = Convert.ToBoolean(ren["B_Transferencia"]);
            cbxDolares.Checked = Convert.ToBoolean(ren["B_Dolares"]);
        }

        public override void BaseBotonBorrarClick()
        {
            if (txtBanco.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN REGISTRO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dlg = MessageBox.Show("SERA ELIMINADO EL REGISTRO CON VALOR:\n" + txtBanco.Text.Trim() + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                res = sql_Catalogos.Dl_Proveedores_Cuentas_Bancarias(Convert.ToInt32(txtClave.Text.Trim()),GlobalVar.K_Usuario, ref msg);
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

        public override void BaseBotonGuardarClick()
        {
            if (!BaseFuncionValidaciones())
                return;

            res = 0;
            msg = string.Empty;
            int CampoIdentity = 0;

            if (CatalogoPropiedadEsRegistroNuevo) // Nuevo
            {
                res = sql_Catalogos.In_Proveedores_Cuentas_Bancarias(
                    ref CampoIdentity,
                    K_Banco,
                    PropiedadK_Proveedor, 
                    Convert.ToString(txtCuenta.Text.Trim()),
                    Convert.ToString(txtClabe.Text.Trim()),
                    cbxTransferencia.Checked,
                    cbxCheque.Checked,
                    cbxDolares.Checked,
                    GlobalVar.K_Usuario,
                    ref msg);
            }
            else //Existe. Update
            {
                CampoIdentity = Convert.ToInt16(CatalogoPropiedadId_Identity);
                res = sql_Catalogos.Up_Proveedores_Cuentas_Bancarias(
                    CampoIdentity, 
                    K_Banco,
                    PropiedadK_Proveedor,
                    Convert.ToInt32(txtCuenta.Text.Trim()),
                    Convert.ToInt32(txtClabe.Text.Trim()),
                    cbxTransferencia.Checked,
                    cbxCheque.Checked,
                    cbxDolares.Checked,
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

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (txtBanco.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL BANCO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBanco.Focus();
                return false;
            }
            if (txtCuenta.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR CUENTA ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCuenta.Focus();
                return false;
            }
            if (txtClabe.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR CLABE INTERBANCARIA ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCuenta.Focus();
                return false;
            }
            BaseErrorResultado = false;
            return true;
        }

        private void txtCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            fx.ValidaSeaNumero(ref e);
        }

        private void txtClabe_KeyPress(object sender, KeyPressEventArgs e)
        {
            fx.ValidaSeaNumero(ref e);
        }
    }
}
