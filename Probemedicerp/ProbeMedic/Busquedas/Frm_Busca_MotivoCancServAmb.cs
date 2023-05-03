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
namespace ProbeMedic.Busquedas
{
    public partial class Frm_Busca_MotivoCancServAmb :Frm_Buscar
    {
        SQLCatalogos sql = new SQLCatalogos();
        public Frm_Busca_MotivoCancServAmb()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {

            BaseDtDatos = sql.Sk_Motivo_Cancelacion_ServiciosAmbulancia();


            if (BaseDtDatos != null)
            {
                CatalogoPropiedadCampoClave = "K_Motivo_Cancelacion_ServiciosAmbulancia";
                CatalogoPropiedadCampoDescripcion = "D_Motivo_Cancelacion_ServiciosAmbulancia";
                base.BaseMetodoInicio();
            }
            else
            {

                MessageBox.Show("NO SE ENCONTRO INFORMACION", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }
    }
}
