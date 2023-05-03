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


namespace ProbeMedic.COMPRAS
{
    public partial class FRM_USUARIO_AUTORIZAREQ : FormaBase
    {
        SQLCatalogos sql_Catalogos = new SQLCatalogos();
        SQLCompras sQLCompras = new SQLCompras();
        DataTable AR_DISPONIBLES = new DataTable();
        DataTable AR_ASIGNADOS = new DataTable();
        DataTable AR_DISPONIBLESS = new DataTable();
        DataTable AR_ASIGNADOSS = new DataTable();


        public bool CatalogoPropiedadEsRegistroNuevo { get; set; }
        public object CatalogoPropiedadId_Identity { get; set; }
        int res = -1;


        string msg = string.Empty;
    
        public FRM_USUARIO_AUTORIZAREQ()
        {
            InitializeComponent();

            cambia_fuente_controles();
            BaseBotonAfectar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonReporte.Visible = false;
            limpia();
            AR_DISPONIBLES.Columns.Add("K_Usuario", typeof(int));
            AR_DISPONIBLES.Columns.Add("D_Usuario", typeof(string));
            AR_ASIGNADOS.Columns.Add("K_Usuario", typeof(int));
            AR_ASIGNADOS.Columns.Add("D_Usuario", typeof(string));
            AR_ASIGNADOS.Columns.Add("B_Autoriza", typeof(bool));
            AR_ASIGNADOS.Columns.Add("B_Autoriza_2", typeof(bool));
            Llena_Asignado();
            Llena_Disponible();

        }



        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (!BaseFuncionValidaciones())
                return;

            int K_Usuario_Disp = 0;
            string D_Usuario_Disp = string.Empty;
            DataGridViewRow row = dgvDisponibles.CurrentRow;
            if (row == null)
                return;
            K_Usuario_Disp = Convert.ToInt32(row.Cells["K_Usuario2"].Value);
            D_Usuario_Disp = row.Cells["D_Usuario2"].Value.ToString();

            if (K_Usuario_Disp != 0)
            {
                res = sQLCompras.In_Usuario_AutorizaRequisicion(K_Usuario_Disp,cbxNivel1.Checked,cbxNivel2.Checked, ref msg);
                if (res == -1)
                {
                    BaseErrorResultado = true;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    MessageBox.Show("INFORMACION ACTUALIZADA CORRECTAMENTE", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpia();
                    Llena_Asignado();
                    Llena_Disponible();
                }

            }
        }
  
        private void Llena_Disponible()
        {

            AR_DISPONIBLESS = sQLCompras.Sk_UsuariosxAutorizaArticulos();

           if (AR_DISPONIBLESS!= null)
            {
               
                foreach (DataRow irew in AR_DISPONIBLESS.Rows)
                {
                    DataRow dtdRow2 = AR_DISPONIBLES.NewRow();
                    dtdRow2["K_Usuario"] = Convert.ToInt32(irew["K_Usuario"]);
                    dtdRow2["D_Usuario"] = irew["D_Usuario"].ToString();
                    AR_DISPONIBLES.Rows.Add(dtdRow2);
                }
                dgvDisponibles.DataSource = AR_DISPONIBLES;           
            }
        }

        private void Llena_Asignado()
        {

            AR_ASIGNADOSS = sQLCompras.Sk_SeleccionadosxUsuario();

            if (AR_ASIGNADOSS != null)
            {
                foreach (DataRow irow in AR_ASIGNADOSS.Rows)
                {
                    DataRow dtdRow = AR_ASIGNADOS.NewRow();
                    dtdRow["K_Usuario"] = Convert.ToInt32(irow["K_Usuario"]);
                    dtdRow["D_Usuario"] = irow["D_Usuario"].ToString();
                    dtdRow["B_Autoriza"] = Convert.ToBoolean(irow["B_Autoriza"]);
                    dtdRow["B_Autoriza_2"] = Convert.ToBoolean(irow["B_Autoriza_2"]);
                    AR_ASIGNADOS.Rows.Add(dtdRow);
                }
                dgvAsignados.DataSource = AR_ASIGNADOS;
            }
        }

        private void limpia()
        {
            if (dgvAsignados.RowCount > 0)
            {
                DataTable dt = (DataTable)dgvAsignados.DataSource;
                dt.Clear();
            }
            if (dgvDisponibles.RowCount > 0)
            {
                DataTable dt2 = (DataTable)dgvDisponibles.DataSource;
                dt2.Clear();
            }
            txtUsuario.Clear();
        }

        private void FRM_USUARIO_AUTORIZAREQ_Load(object sender, EventArgs e)
        {
    
          /*  AR_DISPONIBLES.Columns.Add("K_Usuario", typeof(int));
            AR_DISPONIBLES.Columns.Add("D_Usuario", typeof(string));

            AR_ASIGNADOS.Columns.Add("K_Usuario", typeof(int));
            AR_ASIGNADOS.Columns.Add("D_Usuario", typeof(string));*/


            limpia();
            Llena_Asignado();
            Llena_Disponible();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int K_Usuario_Asig = 0;
            string D_Usuario_Asig = string.Empty;


            DataGridViewRow row = dgvAsignados.CurrentRow;
            if (row == null)
                return;
            K_Usuario_Asig = Convert.ToInt32(row.Cells["K_Usuario"].Value);
            D_Usuario_Asig = row.Cells["D_Usuario"].Value.ToString();
            if (K_Usuario_Asig != 0)
            {
                res = sQLCompras.Dl_Usuario_AutorizaRequisicion(K_Usuario_Asig, ref msg);


                if (res == -1)
                {
                    BaseErrorResultado = true;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {

                    MessageBox.Show("INFORMACION ACTUALIZADA CORRECTAMENTE", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpia();
                    Llena_Asignado();
                    Llena_Disponible();



                }

            }
        }

        private void btnBuscarArticulo_Click(object sender, EventArgs e)
        {
            if (dgvDisponibles.RowCount > 0)
            {
                DataTable dt2 = (DataTable)dgvDisponibles.DataSource;
                dt2.Clear();
            }

            AR_DISPONIBLESS = sQLCompras.Sk_UsuariosxAutorizaArticulos(txtUsuario.Text);

            if (AR_DISPONIBLESS != null)
            {

                foreach (DataRow irew in AR_DISPONIBLESS.Rows)
                {
                    DataRow dtdRow2 = AR_DISPONIBLES.NewRow();
                    dtdRow2["K_Usuario"] = Convert.ToInt32(irew["K_Usuario"]);
                    dtdRow2["D_Usuario"] = irew["D_Usuario"].ToString();
                    AR_DISPONIBLES.Rows.Add(dtdRow2);
                }
                dgvDisponibles.DataSource = AR_DISPONIBLES;
            }
        }

        private void cbxNivel2_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxNivel2.Checked == true)
            {
                cbxNivel1.Checked = true;
            }
            if(cbxNivel2.Checked == false)
            {
                cbxNivel1.Checked = false;
            }

        }

        private void cbxNivel1_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxNivel2.Checked == true)
            {
                cbxNivel1.Checked = true;
            }
        }
    }
}
