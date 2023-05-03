using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProbeMedic.AppCode.BLL;
using System.Windows.Forms;

namespace ProbeMedic.SEGURIDAD
{
    public partial class FRMSPID : Form
    {
//        int res = 0;
        string msg = string.Empty;
        SQLSeguridad sqlSeguridad = new SQLSeguridad();

        public FRMSPID()
        {
            InitializeComponent();
        }


        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void FRMSPID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                Close();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            DataTable dt = sqlSeguridad.Gp_ObtieneSPID();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    lblSPID.Text = dt.Rows[0]["SPID"].ToString();
                    GlobalVar.SPID = Convert.ToInt16(lblSPID.Text);
                    Principal mdi = new Principal();
                    mdi.ActualizaSPID();

                }

            }
        }

    }
}
