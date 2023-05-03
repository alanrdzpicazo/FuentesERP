using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;

namespace ProbeMedic
{
    public partial class FormaConsulta : FormaBase
    {
        public FormaConsulta()
        {
            InitializeComponent();
        }

        public override void BaseMetodoInicio()
        {            
            BasePropiedadB_EsCataLogo = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonModificar.Visible = false;
            //BaseBotonCancelar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonCorreo.Visible = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonReporte.Visible = true;

            Text = Text.ToUpper();

            base.BaseMetodoInicio();
            
            BaseBotonBuscar.Visible = true;

            
        }

        public override void BaseBotonCancelarClick()
        {            
            BaseMetodoLimpiaControles();
            txtFocus.Focus();            
        }

       

    }
}
