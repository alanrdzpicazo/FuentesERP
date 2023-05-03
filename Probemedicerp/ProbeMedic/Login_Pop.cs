using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ProbeMedic
{
    public partial class Login_Pop : Form
    {
        
        public Login_Pop()
        {

            
       
            InitializeComponent();
           

            //para que el formulario aparesca de modo maximizado
            this.WindowState = FormWindowState.Maximized;
            //para que el icono del form no aparesca en la barra de tareas
            this.ShowInTaskbar = false;


        }
        
        private void POP_UP_Load(object sender, EventArgs e)
        {
            
            //creamos una instancia del formulario
            Login Instancia = new Login();
            //Mostramos la instancia, es decir el formulario del loging
            Instancia.ShowDialog();
            //al iniciar secion oculte este form
            //no debe cerrarlo porque la aplicacion se cerraria por completo
            //ya que asignamos este form "POP_UP" como form principal en el Program.cs
            this.Hide();
            
        }
       
    }
}
