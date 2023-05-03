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
    public partial class Frm_ConsultaPrecierresPtes : FormaBase
    {
        SQLVentas sqlVentas = new SQLVentas();
        DataTable dtDatos = new DataTable();
        public Frm_ConsultaPrecierresPtes()
        {
            InitializeComponent();
            BaseBarraHerramientas.Visible = false;
        }

        private void Frm_ConsultaPrecierresPtes_Shown(object sender, EventArgs e)
        {
            dtDatos = sqlVentas.Gp_ConsultaPrecierresPendientes();

            if(dtDatos!=null)
            {
                if(dtDatos.Rows.Count>0)
                {
                    grdDatos.DataSource = dtDatos;
                }
                else
                {
                    MessageBox.Show("NO EXISTEN PRECIERRES PENDIENTES!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Close();
                }
            }
            else
            {
                     MessageBox.Show("NO EXISTEN PRECIERRES PENDIENTES!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Close();
            }
        }
    }
}
