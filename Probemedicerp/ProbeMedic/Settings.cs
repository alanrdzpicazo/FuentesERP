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
    public partial class Settings : Form
    {

        public Settings()
        {
            InitializeComponent();
            cmb_Conexion.Text = GlobalVar.Conexion;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == (Keys.Enter))
            {

                CambiaConexion();
                this.Close();
                return true;

            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CambiaConexion();
            this.Close();
        }
        private void CambiaConexion()
        {
            string Conexion = cmb_Conexion.SelectedItem.ToString();

            if (Conexion == "PRUEBAS")
            {
                GlobalVar.Conexion = "PRUEBAS";
            }
            else if (Conexion == "PRODUCCION")
            {
                GlobalVar.Conexion = "PRODUCCION";
            }
            else if(Conexion == "PRUEBAS ALTIS")
            {
                GlobalVar.Conexion = "PRUEBAS ALTIS";
            }
        }
    }
}
