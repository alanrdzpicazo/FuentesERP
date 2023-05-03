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

namespace ProbeMedic.CUENTASXCOBRAR
{
    public partial class FRM_BUSCA_FACTURA : FormaBase
    {
        int res = -1;
        string msg = string.Empty;
        SQLCuentasxCobrar sql_CXC = new SQLCuentasxCobrar();
        public int K_Cliente;
        public string D_Cliente;

        public DataGridViewRow row;

        public FRM_BUSCA_FACTURA()
        {
            InitializeComponent();
        }

        public override void BaseMetodoInicio()
        {  
            BaseBotonReporte.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBuscar.Visible = true;
            BaseBotonCancelar.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonAfectar.Visible = false;

            grd_Datos.AutoGenerateColumns = false;
            base.BaseMetodoInicio();

        }

        private void FRM_BUSCA_FACTURA_Shown(object sender, EventArgs e)
        {
            txtK_Cliente.Text = Convert.ToString(K_Cliente);
            txtD_Cliente.Text = D_Cliente;
            res = 0;
            msg = string.Empty;

            if (txtK_Cliente.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL CLIENTE!...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BaseDtDatos = sql_CXC.Sk_Facturas_PendientesPago(ucOficinas1.K_Oficina, Convert.ToInt32(txtK_Cliente.Text),GlobalVar.K_Empresa);
            grd_Datos.DataSource = BaseDtDatos;
            grd_Datos.Focus();
        }

        private void grd_Datos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            row = grd_Datos.CurrentRow;
            if(row!=null)
            {
               row = grd_Datos.CurrentRow;
            }

            this.Close();

        }

        public override void BaseBotonBuscarClick()
        {
            if (txtK_Cliente.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL CIRCUITO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BaseDtDatos = sql_CXC.Sk_Facturas_PendientesPago(ucOficinas1.K_Oficina, Convert.ToInt32(txtK_Cliente.Text), GlobalVar.K_Empresa);
            
            grd_Datos.DataSource = BaseDtDatos;

        }

        private void txtK_Factura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((EsNumero(e.KeyChar)) ||  e.KeyChar == Convert.ToChar(Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtK_Factura_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtK_Factura.Text.Trim().Length > 0)
                {
                    Int32 Valor = Int32.Parse(txtK_Factura.Text.Trim());
                }
            }
            catch
            {
                MessageBox.Show("VALOR DEMASIADO GRANDE!..." , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtK_Factura.Text = string.Empty;
                return;
            }

            BaseDtDatos.DefaultView.RowFilter = $"Factura  LIKE '%{txtK_Factura.Text}%'";
        }

        private void grd_Datos_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Tab) || e.KeyValue == 9)
            {
                SendKeys.Send("{Down}");
            }
        }

        private void grd_Datos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Enter))
            {
                row = grd_Datos.CurrentRow;
                if (row != null)
                {
                    row = grd_Datos.CurrentRow;
                }

                this.Close();
            }
        }
    }
}
