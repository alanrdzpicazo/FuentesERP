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


namespace ProbeMedic.VENTAS
{
    public partial class Frm_Datos_Tarjeta : FormaBase
    {
        SQLVentas sql_Ventas = new SQLVentas();
        int res;
        string msg = "";

        public Frm_Datos_Tarjeta()
        {
            InitializeComponent();
        }

        private void Frm_Datos_Tarjeta_Load(object sender, EventArgs e)
        {
            BaseBotonNuevo.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonReporte.Visible = false;
            BaseBotonExcel.Visible = true;
            BaseBotonGuardar.Visible = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonExcel.Visible = false;

            //BaseBotonBuscar.Visible = true;
            //BaseBotonBuscar.Enabled = true;
            //BaseBotonBuscar.ToolTipText = "Buscar Artículos";
            //BaseBotonBuscar.Text = "Buscar";
            //BaseBotonBuscar.Width = 120;
            
        }

        private void txtAsignaCliente_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            res = sql_Ventas.Gp_Up_ClientesTarjeta(Convert.ToDecimal(txtTarjetaCliente.Text), Convert.ToInt32(txtK_Cliente.Text), txtDescripcion.Text, txtRFC.Text, txtCorreo.Text, 0, ref msg);
    
            if (res != -1)
            {
                //regreso numero de tarjeta y cierro 
                MessageBox.Show("LA ASIGNACION SE REALIZO CORRECTAMENTE'", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Frm_Ventas frm = new Frm_Ventas();
                frm.txtNo_Tarjeta.Text = txtTarjetaCliente.Text;
                this.Close();
                return;
            }

            if (res == -1)
            {
                BaseErrorResultado = true;
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        private void Frm_Datos_Tarjeta_Shown(object sender, EventArgs e)
        {
            //if (txtRFC.Text.Trim().Length != 0)
            //{
            //    PnlAlta.Enabled = false;

            //}
            //else
            //{
            //    PnlAlta.Enabled = true;
            //}
        }

        private void BtnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void Frm_Datos_Tarjeta_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F8)
            {
                BtnSalir.PerformClick();
            }
        }

        private void txtTarjetaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((EsNumero(e.KeyChar)) || (e.KeyChar==Convert.ToChar(Keys.Back)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtTarjetaCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
