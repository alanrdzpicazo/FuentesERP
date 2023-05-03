using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ProbeMedic
{
    public partial class Frm_Base_Buscar : Forma
    {

        public DataTable BaseDtDatos = new DataTable("Datos");
        public DataTable BasedtDatosConFiltro = new DataTable();

        


        //TODO: *****AQUI TODAS LAS PROPIEDADES GLOBALES
        #region "Propiedades Globales" 
        public bool BaseErrorResultado = false;
        public string BasePropiedadCampoClave = string.Empty;
        public string BasePropiedadDescripcion = string.Empty;
        #endregion


        //TODO: ***** AQUI SE DECLARAN LOS EVENTOS CLICK DE CADA BOTON DE LA BARRA DE HERRAMIENTAS
        #region "Declara Eventos Click de Cada Botón"

        private void btnSalir_Click(object sender, EventArgs e)
        {
          Close();
        }       

       
        #endregion

        #region
        public virtual void BaseBotonProceso1Click()
        {

        }
        public virtual void BaseBotonProceso2Click()
        {

        }
        public virtual void BaseBotonProceso3Click()
        {

        }      
        public virtual void BaseBotonAfectarClick()
        {

        }
        public virtual void BaseBotonBuscarClick()
        {

        }
        public virtual void BaseBotonRefrescarClick()
        {

            BaseMetodoRecarga();
        }        
        #endregion

        //TODO: ***** AQUI METODOS GENERALES QUE NO SE INVOCAN DESDE BOTON
        #region "Métodos Generales"       
        public virtual void BaseMetodoRecarga()
        {

        }
        public virtual void BaseMetodoLimpiaControles()
        {

        }
        public virtual void BaseMetodoMostrarReporte()
        {

        }
        public virtual void BaseMetodoInicio()
        {                        
            HabilitaBotones(null);
            BaseMetodoLimpiaControles();
            
        }               
        #endregion


        public Frm_Base_Buscar()
        {
            InitializeComponent();                        

        }  

        public void HabilitaBotones(object sender, bool B_Habilitar = true)
        {
                      
            
        }

        private void FormaBase_Load(object sender, EventArgs e)
        {
           
            //BaseEtiquetaRefrescar.Visible = false;
            //BaseEtiquetaEstatus.Visible = false;           
            BaseMetodoInicio();
            //ConfiguraPermisos();
        }

        public void Frm_Base_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

       
            if (keyData == (Keys.Escape))
            {
                this.Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        

       
    }
}
