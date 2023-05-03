using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;
using System.Configuration;
using System.Data.SqlClient;
using System.Xml;
//using System.Net.Sockets;
using System.Threading;
using System.IO;


namespace ProbeMedic
{
    public partial class UsuarioAutoriza : Forma
    {
        public string PropiedadClaveUsuario { get; set; }
        public string PropiedadContrasena {get;set;}
        public string PropiedadComentarios { get; set; }
        public int PropiedadK_Usuario { get; set; }
        public bool PropiedadB_EsValido { get; set; }


        Generales Generales = new Generales();
        SQLSeguridad sql = new SQLSeguridad();                
        Funciones fx = new Funciones();

        
        public UsuarioAutoriza()
        {
            InitializeComponent();
        }



        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR USUARIO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }
            if (txtContra.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR CONTRASEÑA", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContra.Focus();
                return;
            }
            if (txtComentarios.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR COMENTARIOS", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtComentarios.Focus();
                return;
            }


            int res = 0;
            string msg = string.Empty;
            res = sql.Gp_ValidaAccesoUsuario(txtUsuario.Text, txtContra.Text, ref msg);
            if (res == -2)
            {
                MessageBox.Show("CONEXIÓN NO DISPONIBLE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (res == -1)
            {
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt = sql.Gp_ValidaAccesoUsuario(txtUsuario.Text, txtContra.Text);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    PropiedadK_Usuario = (Int32)dt.Rows[0]["K_Usuario"];
                    PropiedadClaveUsuario = dt.Rows[0]["Login"].ToString();
                    PropiedadContrasena = dt.Rows[0]["Contrasenia"].ToString();
                    PropiedadB_EsValido = true;
                    Close();
                }
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            PropiedadB_EsValido = false;
            Close();
        }

       

        private void UsuarioAutoriza_Load(object sender, EventArgs e)
        {
           

        }
   
        
    }
}
