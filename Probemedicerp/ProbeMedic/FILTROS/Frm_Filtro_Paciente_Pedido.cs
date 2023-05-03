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

namespace ProbeMedic.FILTROS
{
    public partial class Frm_Filtro_Paciente_Pedido : Frm_Filtro
    {
        public string CatalogoPropiedadCampoDescripcion { get; set; }
        public string CatalogoPropiedadCampoClave { get; set; }
        public bool CatalogoPropiedadMuestraColumnaClave { get; set; }
        public int LLave_Seleccionado { get; set; }
        public string Descripcion_Seleccionado { get; set; }

        SQLCatalogos sql_catalogos = new SQLCatalogos();
        DataTable dtPacientes = new DataTable();

        public Frm_Filtro_Paciente_Pedido()
        {
            InitializeComponent();
            sel_Aseguradora.PropertyChanged += new PropertyChangedEventHandler(sel_Aseguradora_PropertyChanged);
        }
        private void Frm_Filtro_Paciente_Pedido_Load(object sender, EventArgs e)
        {
            grdDatos.AutoGenerateColumns = false;
            //grdDatos.DataSource = dtGrid;
            grdDatos.MultiSelect = false;
            grdDatos.ReadOnly = true;
            grdDatos.AllowUserToResizeColumns = true;
            grdDatos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            grdDatos.Refresh();

            if (CatalogoPropiedadMuestraColumnaClave)
            {
                grdDatos.Columns[0].Visible = true;
                grdDatos.Columns[1].Width = 50;
                grdDatos.Columns[1].Width = grdDatos.Width - 110;
            }
            else
            {
                grdDatos.Columns[0].Visible = false;

                grdDatos.Columns[1].Width = grdDatos.Width - 60;
            }
            sel_Aseguradora.Focus();
        }
        void Mtd_Filtra_Pacientes()
        {
            dtPacientes = sql_catalogos.Sk_Pacientes(sel_Aseguradora.K_Aseguradora,GlobalVar.K_Empresa);          
            grdDatos.DataSource = dtPacientes;
            
        }
        private void sel_Aseguradora_PropertyChanged(object sender, EventArgs e)
        {
            if (sel_Aseguradora.K_Aseguradora > 0)
            {
                Cursor = Cursors.WaitCursor;
                Mtd_Filtra_Pacientes();
                Cursor = Cursors.Default;
                txt_Buscar.Focus();
            }
            else
            {
                if (sel_Aseguradora.K_Aseguradora == 0)
                {
                    sel_Aseguradora.Focus();
                }
            }
        }
       
        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            if ((dtPacientes != null) && (dtPacientes.Rows.Count > 0))
            {
                dtPacientes.DefaultView.RowFilter = $"Nombre_Completo LIKE '%{txt_Buscar.Text}%'";
            }
        }

        private void grdDatos_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow row = grdDatos.CurrentRow;
            if (row == null)
                return;
            LLave_Seleccionado = Convert.ToInt32(row.Cells[0].Value);
            Descripcion_Seleccionado = row.Cells[1].Value.ToString();
            Close();
        }

        private void grdDatos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Enter))
            {
                grdDatos.EndEdit();             // if you want to preserve the current commit behavior
                e.Handled = true;

                DataGridViewRow row = grdDatos.CurrentRow;
                if (row == null)
                    return;
                LLave_Seleccionado = Convert.ToInt32(row.Cells[0].Value);
                Descripcion_Seleccionado = row.Cells[1].Value.ToString();
                Close();
            }
        }

        private void grdDatos_SelectionChanged(object sender, EventArgs e)
        {
            //DataGridViewRow row = grdDatos.CurrentRow;
            //if (row == null)
            //    return;

            //LLave_Seleccionado = Convert.ToInt32(row.Cells[0].Value);
            //Descripcion_Seleccionado = row.Cells[1].Value.ToString();
        }
    }
}
