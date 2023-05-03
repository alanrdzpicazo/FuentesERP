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
    public partial class Frm_Cierra_Oficina : Forma
    {
        int res;
        bool B_Error_Entrar = false;
        Int32 p_K_Oficina { get; set; }
        String p_D_Oficina { get; set; }

        Int32 p_K_Almacen { get; set; }
        String p_D_Almacen { get; set; }

        SQLVentas sql_ventas = new SQLVentas();
        SQLCatalogos sql_catalogos = new SQLCatalogos();
        public Frm_Cierra_Oficina()
        {
            InitializeComponent();
            p_K_Oficina = GlobalVar.K_Oficina;
            p_D_Oficina = GlobalVar.D_Oficina; 
        }

        private void Frm_Cierra_Oficina_Load(object sender, EventArgs e)
        {
            DataTable dt = sql_catalogos.Sk_Almacenes_x_Usuario(GlobalVar.K_Usuario, GlobalVar.K_Oficina, GlobalVar.K_Empresa);

            if (dt != null)
            {
                if(dt.Rows.Count == 0)
                {
                    MessageBox.Show("EL USUARIO NO CUENTA CON ALMACEN ASIGNADO...!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    B_Error_Entrar = true;
                }
                else if (dt.Rows.Count == 1)
                {
                    p_K_Almacen = Convert.ToInt32(dt.Rows[0]["K_Almacen"].ToString());
                    p_D_Almacen = dt.Rows[0]["D_Almacen"].ToString();
                }
                else if (dt.Rows.Count > 1)
                {
                    MessageBox.Show("EL USUARIO CUENTA CON MAS DE UN ALMACEN ASIGNADO...!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    B_Error_Entrar = true;
                }
            }
            else
            {
                MessageBox.Show("EL USUARIO NO CUENTA CON ALMACEN ASIGNADO...!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                B_Error_Entrar = true;
            }


   
        }
        private void Frm_Cierra_Oficina_Shown(object sender, EventArgs e)
        {
            if (!B_Error_Entrar)
            {
                this.Txt_Clave_Oficina.Text = p_K_Oficina.ToString();
                this.Txt_Oficina.Text = p_D_Oficina;

                this.Txt_Clave_Cierre.Text = p_K_Almacen.ToString();
                this.Txt_Almacen.Text = p_D_Almacen;
            }
            else
            {
                this.Close();
            }
        }
        private void Btn_Generar_Click(object sender, EventArgs e)
        {
            Int32 CampoIdentity = 0;
            string msg = string.Empty;

            try
            {
                res = 0;
                res = sql_ventas.Gp_GeneraCierreOficina(Convert.ToInt32(Txt_Clave_Cierre.Text.Trim()), GlobalVar.K_Usuario,ref CampoIdentity,ref msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            if (res == -1)
            {
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MessageBox.Show("Cierre de Oficina " +"["+Txt_Clave_Oficina.Text+"]["+Txt_Oficina.Text+"]"+" Generado Correctamente" + System.Environment.NewLine +
                                "Consecutivo No.  " + CampoIdentity.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

      
    }
}
