using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;
namespace ProbeMedic.INVENTARIOS
{
    public partial class Frm_Ajuste_Inventario : Forma
    {
        public int K_Oficina = 0;
        public int K_Articulo = 0;
        public int K_Almacen = 0;
        public int K_Movimiento_Inventario = 0;
        
        public string Str_Oficina = "";
        public string Str_Almacen = "";
        public string Str_Articulo = "";
        public string Str_Unidad = "";
        public string Str_Lote = "";

        int res;
        string strMensaje;
        string strCorreos;

        SQLAlmacen sqlAlmacen = new SQLAlmacen();
        Funciones fx = new Funciones();

        private void Frm_Ajuste_Inventario_Load(object sender, EventArgs e)
        {
            txtArticulo.Text = Str_Articulo;
            txtUnidadMedida.Text = Str_Unidad;
            txtLote.Text = Str_Lote;
            this.cbx_motivo_ajuste_inventario1.LlenaDatos();
            RbtnSuma.Checked = true;
        
        }

        public Frm_Ajuste_Inventario()
        {
            InitializeComponent();
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCantidadAjuste.Text.Trim().Length == 0)
            {
                MessageBox.Show("Capture la Cantidad a Ajustar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidadAjuste.Focus();
                return;
            }
            if (txtObservaciones.Text.Trim().Length == 0)
            {
                MessageBox.Show("Capture las Observaciones del Ajuste", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtObservaciones.Focus();
                return;
            }
            if (RbtnSuma.Checked == false)
                if (RbtnResta.Checked == false)
                {
                    MessageBox.Show("Debe indicar el tipo de Ajuste", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    RbtnSuma.Focus();
                    return;
                }

            try
            {
                strMensaje = "";
                res = sqlAlmacen.In_AjusteInventario(K_Movimiento_Inventario, Convert.ToDecimal(txtCantidadAjuste.Text), Convert.ToInt32(this.cbx_motivo_ajuste_inventario1.SelectedValue.ToString()),
                                                     txtObservaciones.Text, K_Oficina, GlobalVar.K_Usuario, GlobalVar.PC_Name, RbtnSuma.Checked, RbtnResta.Checked, ref strMensaje);

                if (res < 0)
                {
                    MessageBox.Show(strMensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Ajuste Realizado Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
                catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
