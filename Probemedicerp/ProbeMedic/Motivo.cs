using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProbeMedic
{
    public partial class Motivo : Form
    {
        public string P_Motivo { get; set; }
        public string P_Titulo { get; set; }        

        public Motivo()
        {
            InitializeComponent();
        }

        private void Motivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                Close();
        }
    
        private void Motivo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtMotivo.Text.Trim().Length == 0)
                P_Motivo = string.Empty;
            else
                P_Motivo = txtMotivo.Text;
        }

        private void Motivo_Load(object sender, EventArgs e)
        {
            if (P_Motivo.Trim().Length > 0)
                txtMotivo.Text = P_Motivo;

            if (P_Titulo.Trim().Length == 0)
                this.Text = "Motivo";
            else
                this.Text = P_Titulo;

            if (P_Titulo.Contains("Observaciones"))
                txtMotivo.CharacterCasing = CharacterCasing.Normal;

            txtMotivo.Focus();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
