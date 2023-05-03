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

namespace ProbeMedic.SERVICIOS
{
    public partial class FRM_ASIGNA_ENFERMERA : FormaBase
    {
        public int PropiedadNo_Servicio { get; set; }
        int K_Enfermera;
        int res;
        string Mensaje;
        SQLPrecios sqlPrecios = new SQLPrecios();
        public FRM_ASIGNA_ENFERMERA()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            BaseMetodoRecarga();
            BaseBotonModificar.Visible = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonReporte.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonGuardar.Enabled = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonBuscar.Enabled = false;
            BaseBotonExcel.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonBuscar.Visible = false;

            txtNoServicio.Text = Convert.ToString(PropiedadNo_Servicio);
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {

            Busquedas.Frm_Busca_Enfermera  frm = new Busquedas.Frm_Busca_Enfermera();
            frm.ShowDialog();
            K_Enfermera = frm.LLave_Seleccionado;
            txtEnfermera.Text = frm.Descripcion_Seleccionado;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            res = 0;
            Mensaje = string.Empty;
            if (txtEnfermera.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA ENFERMERA..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (PropiedadNo_Servicio == 0)
            {
                MessageBox.Show("DEBE INDICAR EL NUMERO DE SERVICIO..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            res = sqlPrecios.Up_ServiciosContratados_Empleado(PropiedadNo_Servicio, K_Enfermera, ref Mensaje);
            if (res == -1)
            {

                MessageBox.Show(Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {

                MessageBox.Show("INFORMACION ACTUALIZADA CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
        }
    }
}
