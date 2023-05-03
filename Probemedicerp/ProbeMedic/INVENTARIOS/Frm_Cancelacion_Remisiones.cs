﻿using System;
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
    public partial class Frm_Cancelacion_Remisiones : FormaBase
    {
        public int PK_Oficina{ get; set; }
        public String PD_Oficina { get; set; }
        DataTable dtResultado = new DataTable();
        SQLAlmacen sql_almacen = new SQLAlmacen();
       
        public Frm_Cancelacion_Remisiones()
        {

            InitializeComponent();

        }

        public override void BaseMetodoInicio()
        {
            BaseBotonBorrar.Visible = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonAfectar.Visible = true;
            BaseBotonAfectar.Enabled = false;
            BaseBotonCorreo.Visible = false;
            BaseBotonCorreo.Enabled = false;
            BaseBotonModificar.Visible = false;
            BaseBotonModificar.Enabled = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonCancelar.Enabled = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonGuardar.Enabled = false;
            BaseBotonReporte.Visible = false;
            BaseBotonReporte.Enabled = false;
            BaseBotonProceso1.Visible = false;
            BaseBotonProceso2.Visible = false;
            BaseBotonProceso2.Enabled = false;
            BaseBotonProceso3.Visible = false;
            BaseBotonProceso3.Enabled = false;
            BaseBotonExcel.Visible = false;
            BaseBotonExcel.Enabled = false;
            BaseBotonBuscar.Enabled = false;
            BaseBotonBuscar.Visible = false;
            this.grdDatos.AutoGenerateColumns = false;
            Txt_Clave_Oficina.Text = GlobalVar.K_Oficina.ToString();
            Txt_Oficina.Text = GlobalVar.D_Oficina;
            MtdCargaResultado();
        }

        void MtdCargaResultado()
        {
            dtResultado = sql_almacen.Sk_Remisiones_Documentadas(Convert.ToInt32(Txt_Clave_Oficina.Text));

            if (dtResultado != null)
            {
                grdDatos.DataSource = dtResultado;
                BaseBotonAfectar.Enabled = true;
               
            }
            else
            {
                MessageBox.Show("LA OFICINA NO CUENTA CON REMISIONES DOCUMENTADAS..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public override void BaseBotonAfectarClick()
        {
            int s_K_Remision = Convert.ToInt32(grdDatos.CurrentRow.Cells["CLAVE_REMISION"].Value);
            DialogResult dlg = MessageBox.Show("SERA CANCELADA LA REMISION CON FOLIO: "  +s_K_Remision+ " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {

                int res = 0;
                string strMensaje = "";

                if (grdDatos.Rows.Count > 0 && !string.IsNullOrEmpty(Txt_Clave_Oficina.Text))
                {
                    res = sql_almacen.Gp_Cancela_Remision(Convert.ToInt32(Txt_Clave_Oficina.Text), Convert.ToInt32(grdDatos.CurrentRow.Cells["CLAVE_REMISION"].Value), GlobalVar.K_Usuario, GlobalVar.PC_Name, Txt_Observaciones.Text.Trim(), ref strMensaje);

                    if (res == 0)
                    {
                        MessageBox.Show("SE CANCELÓ LA REMISION [" + Convert.ToInt32(grdDatos.CurrentRow.Cells["CLAVE_REMISION"].Value) + "] CORRECTAMENTE", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BaseBotonAfectar.Enabled = false;
                        Txt_Observaciones.Text = "";
                        BaseMetodoInicio();
                    }
                    else
                    {
                        MessageBox.Show(strMensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No hay datos para realizar la operación.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }


        }

    }
}
