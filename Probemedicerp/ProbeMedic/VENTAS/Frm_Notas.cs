﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbeMedic.VENTAS
{
    public partial class Frm_Notas : Form
      {
        public string Observaciones_1 { get; set; }
        public string Observaciones_2 { get; set; }
        public string Observaciones_3 { get; set; }
        public string Observaciones_4 { get; set; }
        public string Observaciones_5 { get; set; }

        public Frm_Notas()
        {
            InitializeComponent();
        }

        private void Frm_Notas_Load(object sender, EventArgs e)
        {
            //txtObservaciones1.Text = "";
            //txtObservaciones2.Text = "";
            //txtObservaciones3.Text = "";
            //txtObservaciones4.Text = "";
            //txtObservaciones5.Text = "";
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Frm_Ventas frm = new Frm_Ventas();
            Observaciones_1  = txtObservaciones1.Text;
            Observaciones_2  = txtObservaciones2.Text;
            Observaciones_3  = txtObservaciones3.Text;
            Observaciones_4  = txtObservaciones4.Text;
            Observaciones_5  = txtObservaciones5.Text;
            this.Close();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}