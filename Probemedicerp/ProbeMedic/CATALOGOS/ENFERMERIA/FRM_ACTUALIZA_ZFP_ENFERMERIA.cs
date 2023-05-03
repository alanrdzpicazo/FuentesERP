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

namespace ProbeMedic.CATALOGOS.ENFERMERIA
{
    public partial class FRM_ACTUALIZA_ZFP_ENFERMERIA : FormaBase
    {
        SQLCatalogos catalogosSQL = new SQLCatalogos();

        int res = 0;
        string msg = string.Empty;

        //VARIABLES QUE SE RECIBIRAN DE LA FORMA ZONIFICACION FORANEO PRECIOS AMBULANCIA Y SE ASIGNARAN EN EL CONSTRUCTOR
        int K_Precio_Foraneo_Enfermeria = 0, K_Pais = 0, K_Estado = 0, K_Ciudad = 0, K_Oficina = 0, K_Precio_Enfermeria = 0;

        private void FRM_ACTUALIZA_ZFP_ENFERMERIA_Load(object sender, EventArgs e)
        {
            txtCiudad.Text = Convert.ToString(D_Ciudad);
            txtPrecio.Text = Convert.ToString(Precio);
            dtpFinal.Value = FechaFinal;
            dtpInicial.Value = FechaInicial;
        }

        string D_Ciudad = string.Empty;

        DateTime FechaInicial = DateTime.Today;
        DateTime FechaFinal = DateTime.Today;


        decimal Precio;
        public FRM_ACTUALIZA_ZFP_ENFERMERIA(int K_Precio_Foraneo_Enfermeria, int _K_Pais, int _K_Ciudad, string _D_Ciudad, int _K_Estado, int _K_Oficina, int K_Precio_Enfermeria, decimal _Precio, DateTime _FechaInicio, DateTime _FechaFinal)
        {
            InitializeComponent();
            K_Pais = _K_Pais;
            K_Estado = _K_Estado;
            K_Ciudad = _K_Ciudad;
            K_Oficina = _K_Oficina;
            K_Precio_Enfermeria = K_Precio_Enfermeria;
            D_Ciudad = _D_Ciudad;
            Precio = _Precio;
            FechaInicial = _FechaInicio;
            FechaFinal = _FechaFinal;
            K_Precio_Foraneo_Enfermeria = K_Precio_Foraneo_Enfermeria;
        }
        public override void BaseMetodoInicio()
        {
            BaseMetodoRecarga();

            //ME DESHABILITA LOS BOTONES U OPCIONES
            BaseBotonNuevo.Visible = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonReporte.Visible = false;
            BaseBotonExcel.Visible = false;
            //

        }
        public override void BaseBotonGuardarClick()
        {
            res = 0;
            msg = string.Empty;
            DateTime FechaInicial = DateTime.Today;
            FechaInicial = dtpInicial.Value;
            DateTime FechaFinal = DateTime.Today;
            FechaFinal = dtpFinal.Value;

            try
            {
                res = catalogosSQL.Up_Zonificacion_Foranea_Precios_Enfermeria(Convert.ToInt16(K_Precio_Foraneo_Enfermeria), Convert.ToInt16(K_Pais), K_Estado, K_Ciudad, K_Precio_Enfermeria, K_Oficina, Convert.ToDecimal(txtPrecio.Text), FechaInicial, FechaFinal, ref msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("YA EXISTEN PRECIOS ASIGNADOS... ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (res == -1)
            {

                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {

                MessageBox.Show("INFORMACION ACTUALIZADA CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }

            base.BaseBotonGuardarClick();
            this.Close();
        }
        public override void BaseBotonBorrarClick()
        {
            if (K_Ciudad == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN REGISTRO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dlg = MessageBox.Show("SERA ELIMINADO EL REGISTRO SELECCIONADO:\n" + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                res = catalogosSQL.Dl_Zonificacion_Foranea_Precios_Enfermeria(Convert.ToInt16(K_Precio_Foraneo_Enfermeria), Convert.ToInt16(K_Pais), K_Estado, K_Ciudad, K_Precio_Enfermeria, K_Oficina, ref msg);

                if (res == -1)
                {

                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {

                    MessageBox.Show("INFORMACION ELIMINADA CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
            base.BaseBotonBorrarClick();


        }
    }
}
