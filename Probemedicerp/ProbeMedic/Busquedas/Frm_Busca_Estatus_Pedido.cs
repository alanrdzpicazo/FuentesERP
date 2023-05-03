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

namespace ProbeMedic.Busquedas
{
    public partial class Frm_Busca_Estatus_Pedido : Frm_Buscar
    {
        SQLCatalogos sql = new SQLCatalogos();
        private Int32 k_Estatus_Pedido = 0;
        public int K_Estatus_Pedido { get => k_Estatus_Pedido; set => k_Estatus_Pedido = value; }
        public Frm_Busca_Estatus_Pedido()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {

            BaseDtDatos = sql.Sk_Estatus_Pedido();


            if (BaseDtDatos != null)
            {
                CatalogoPropiedadCampoClave = "K_Estatus_Pedido";
                CatalogoPropiedadCampoDescripcion = "D_Estatus_Pedido";
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
