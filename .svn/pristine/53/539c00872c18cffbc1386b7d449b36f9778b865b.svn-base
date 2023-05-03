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

namespace ProbeMedic.INVENTARIOS
{
    public partial class Frm_ReOrden_Inventario : FormaConsulta
    {
        public int K_Oficina;
        public int K_Almacen;
        SQLCompras sqlCompras = new SQLCompras();
        DataTable dtDatos = new DataTable();

        public Frm_ReOrden_Inventario()
        {
            BaseBarraHerramientas.Visible = false;
            InitializeComponent();        
        }

        public void LlenaDatos()
        {
            if (K_Almacen != 0 && K_Oficina != 0)
            {
                this.dgv_datos.DataSource = null;
                dtDatos = this.sqlCompras.Sk_Inventario_PuntoReOrden(K_Oficina, K_Almacen);
                dgv_datos.DataSource = dtDatos;
            }

        }
        

    }
}
