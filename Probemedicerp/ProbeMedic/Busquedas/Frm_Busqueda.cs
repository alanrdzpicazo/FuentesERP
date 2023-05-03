﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbeMedic.Busquedas
{
    public partial class Frm_Busqueda : FormaBase
    {
        public Frm_Busqueda()
        {
            InitializeComponent();
        }
       
        public string BusquedaPropiedadCamposBusqueda { get; set; }
        public DataTable BusquedaPropiedadTablaFiltra { get; set; }
        public string BusquedaPropiedadTitulo { get; set; }
        public DataRow BusquedaPropiedadReglonRes { get; set; }
        public string P_Titulo { get; set; }
        public bool P_B_BuscaEnSql { get; set; }
        public string BusquedaPropiedadNombreColumna { get; set; }
        public bool BusquedaPropiedadEscondeFiltro { get; set; }
        public string campo_busca { get; set; }
        public int LLave_Seleccionado { get; set; }
        public string Descripcion_Seleccionado { get; set; }

        Form frm;
        DataGridView grd = new DataGridView();
        Funciones fx = new Funciones();

        private void Frm_Busqueda_Load(object sender, EventArgs e)
        {
            if (BusquedaPropiedadEscondeFiltro == true)
                pnlFiltro.Visible = false;

            BaseEtiquetaEstatus.Visible = false;
            BaseEtiquetaRefrescar.Visible = false;
            BaseBarraHerramientas.Visible = false;
            if (P_Titulo != null)
                this.Text = P_Titulo;

            if (P_B_BuscaEnSql)
                btnAceptar.Visible = true;
            else
            {
                string Buscar = string.Empty;
                if (BaseValorBuscar != null)
                    Buscar = BaseValorBuscar;
                if (Buscar.Trim().Length > 0)
                    txtBuscar.Text = Buscar;
            }

            frm = (Form)sender;
            foreach (Control c in frm.Controls)
            {
                if (c is DataGridView)
                {
                    grd = (DataGridView)c;
                    grd.DoubleClick += new EventHandler(grd_DoubleClick);
                    grd.KeyDown += new KeyEventHandler(grd_KeyDown);
                }
            }

            if (BusquedaPropiedadTablaFiltra != null)
            {
                if (BusquedaPropiedadTablaFiltra.Rows.Count > 0)
                {
                    BaseDtFiltra = BusquedaPropiedadTablaFiltra;
                    ProcesoFiltrar();
                }
            }

            txtBuscar.Focus();
            txtBuscar.Text = campo_busca;
        } 
        public override void ProcesoSeleccionaRegistro(string NombreColumna = "")
        {
            if (grd.Rows.Count > 0)
            {
                DataGridViewRow row = grd.CurrentRow;

                regresa_seleccion(Convert.ToInt32(row.Cells[0].Value), row.Cells[1].Value.ToString());
                int CampoIdentity = 0;
                CampoIdentity = Convert.ToInt32(row.Cells[0].Value);

                //En algunos casos en el sp el campo llave no es la primera posición por eso envio el nombre
                //if (NombreColumna != null)
                //{
                //    if (NombreColumna.Trim().Length > 0)
                //        PosicionCampo = BusquedaPropiedadTablaFiltra.Columns[NombreColumna].Ordinal +1;
                //}
                if (NombreColumna == null)
                    NombreColumna = BusquedaPropiedadTablaFiltra.Columns[0].ColumnName;
                if (NombreColumna.Trim().Length == 0)
                    NombreColumna = BusquedaPropiedadTablaFiltra.Columns[0].ColumnName;


                DataRow ren = BusquedaPropiedadTablaFiltra.NewRow();
                switch (BusquedaPropiedadTablaFiltra.Columns[NombreColumna].DataType.ToString().Trim().ToUpper())
                {
                    case "SYSTEM.INT16":
                        ren = BusquedaPropiedadTablaFiltra.AsEnumerable().Where(p => p.Field<Int16>(NombreColumna) == CampoIdentity).FirstOrDefault();
                        break;
                    case "SYSTEM.INT32":
                        ren = BusquedaPropiedadTablaFiltra.AsEnumerable().Where(p => p.Field<Int32>(NombreColumna) == CampoIdentity).FirstOrDefault();
                        break;
                    case "SYSTEM.INT64":
                        ren = BusquedaPropiedadTablaFiltra.AsEnumerable().Where(p => p.Field<Int64>(NombreColumna) == CampoIdentity).FirstOrDefault();
                        break;
                    case "SYSTEM.INT":
                        ren = BusquedaPropiedadTablaFiltra.AsEnumerable().Where(p => p.Field<int>(NombreColumna) == CampoIdentity).FirstOrDefault();
                        break;
                }

                if (ren != null)
                {
                    BusquedaPropiedadReglonRes = ren;
                    Close();
                }
            }
        }

        public override bool ProcesoFiltrar()
        {
            BaseTituloPantalla = BusquedaPropiedadTitulo;
            bool res = false;
            res = base.ProcesoFiltrar();
            if (res)
            {
                if (BaseValorBuscar.Trim().Length == 0)
                {
                    MessageBox.Show("FALTA ASIGNAR EL VALOR DEL TEXTBOX DE BUSQUEDA A LA VARIABLE: BaseValorBuscar");
                    return false;
                }
                DataTable dtFiltro = BusquedaPropiedadTablaFiltra.Clone();
                dtFiltro = LINQTablaFiltraMultiple(BusquedaPropiedadTablaFiltra, BaseValorBuscar, BusquedaPropiedadCamposBusqueda);
                if (dtFiltro.Rows.Count > 0)
                    fx.LlenaGrid(ref frm, ref grd, dtFiltro, BaseTituloPantalla);
                else
                {
                    this.Text = BaseTituloPantalla;
                    grd.DataSource = null;
                }

                BaseGridCopiar = grd;
            }

            return res;

        }

        void grd_DoubleClick(object sender, EventArgs e)
        {
            ProcesoSeleccionaRegistro(BusquedaPropiedadNombreColumna);
        }
        public void CambiaTituloBusqueda(string Titulo)
        {
            this.Text = Titulo;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ProcesoBuscar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BaseValorBuscar = txtBuscar.Text;
            if (P_B_BuscaEnSql == false)
            {
                ProcesoFiltrar();
            }
            if (BaseValorBuscar.Trim().Length == 0)
            {
                grd.ClearSelection();
                grd.CurrentCell = null;
            }

        }
        private void grd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Enter))
            {
                grd.EndEdit();             // if you want to preserve the current commit behavior
                e.Handled = true;

                DataGridViewRow row = grd.CurrentRow;
                if (row == null)
                    return;

                regresa_seleccion(Convert.ToInt32(row.Cells[0].Value), row.Cells[1].Value.ToString());

                ProcesoSeleccionaRegistro(BusquedaPropiedadNombreColumna);
                this.Close();
            }
        }
        private void regresa_seleccion(int clave, string desc)
        {
            LLave_Seleccionado = clave;
            Descripcion_Seleccionado = desc;

        }
    }
}
