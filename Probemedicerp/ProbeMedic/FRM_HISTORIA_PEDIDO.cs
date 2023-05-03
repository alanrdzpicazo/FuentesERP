using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbeMedic
{
    public partial class FRM_HISTORIA_PEDIDO : FormaConsulta
    {
        public DataTable datos { get; set; } = new DataTable();
        public FRM_HISTORIA_PEDIDO()
        {
            InitializeComponent();
        }
        public FRM_HISTORIA_PEDIDO(DataTable _datos)
        {
            datos = _datos;
        }

        public override void BaseMetodoInicio()
        {

            BaseBotonNuevo.Visible = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonModificar.Visible = false;
            BaseBotonModificar.Enabled = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonGuardar.Enabled = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonBuscar.Enabled = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonCancelar.Enabled = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonAfectar.Enabled = false;
            BaseBotonReporte.Visible = false;
            BaseBotonReporte.Enabled = false;
        }

        private void FRM_HISTORIA_PEDIDO_Load(object sender, EventArgs e)
        {
            dgv_datos.DataSource = datos;
        }
    }
  
}
