﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;
using CrystalDecisions.CrystalReports.Engine;

namespace ProbeMedic
{
    public partial class FormaCatalogo : FormaBase
    {
        public SQLCatalogos CatalogosSQL = new SQLCatalogos();
        public SQLSeguridad SeguridadSQL = new SQLSeguridad();

        //TODO: *****AQUI LAS VARIABLES DE LA FORMA DE CATALOGOS
        #region "Propiedades Globales de Catálogos"
            public string CatalogoPropiedadCampoDescripcion { get; set; }
            public string CatalogoPropiedadCampoClave { get; set; }
            public bool CatalogoPropiedadMuestraColumnaClave { get; set; }
            public bool CatalogoPropiedadEsRegistroNuevo { get; set; }
            public object CatalogoPropiedadId_Identity { get; set; }
            public string CatalogoPropiedadDescripcion { get; set; }
            
            public DataGridView CatalogoGrid
            {
                get { return this.grdDatos; }
            }
            public TextBox CatalogoTxtFiltro
            {
                get { return this.txtFiltro; }
            }
            public Panel CatalogoPnlGrid
            {
                get { return this.pnlGrid; }
            }
        #endregion

            //Form frm;
            //Object ObjFrm;
            //Type tipo;
            //Form Ventana;
            //Panel pnl = new Panel();


        public FormaCatalogo()
        {
            InitializeComponent();
            //frm = (Form)this;
            //tipo = Ensamblado.GetType(Ensamblado.GetName().Name + "." + GlobalVar.NombreForma);
            //ObjFrm = Activator.CreateInstance(tipo);
            //Ventana = (Form)ObjFrm;            
        }

        private Panel BuscaPanelControles()
        {
            Object ObjFrm;
            Type tipo = Ensamblado.GetType(Ensamblado.GetName().Name + "." + GlobalVar.NombreForma);
            ObjFrm = Activator.CreateInstance(tipo);
            Form Ventana = (Form)ObjFrm;
            Panel pnl = new Panel();

            try
            {
                pnl = Ventana.Controls.Find("pnlControles", true).FirstOrDefault() as Panel;
            }
            catch
            {
                MessageBox.Show("NO HA DECLARADO EL PANEL PNLCONTROLES EN LA FORMA CATALOGO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return pnl;
        }

        public override void BaseMetodoInicio()
        {
            BasePropiedadB_EsCataLogo = true;
            BaseEtiquetaRefrescar.Visible = true;
            BaseEtiquetaEstatus.Visible = true;
            BaseBotonAfectar.Visible = false;
            BaseBotonReporte.Visible = false;
            GlobalVar.CatalogoPropiedadB_Agregando = false;
            GlobalVar.CatalogoPropiedadB_Editando = false;
            txtFiltro.Text = string.Empty;            
            pnlTitulo.Visible = false;

            base.BaseMetodoInicio();
            CargarDatosInicial();
            CambiaEtiquetaEstatus();
            primer_registro();

            try
            {
                Panel pnlControles = BuscaPanelControles();
                pnlControles.Enabled = false;
            }
            catch
            {

            }
            txtFiltro.Focus();        
        }

        public override void BaseMetodoRecarga()
        {
            string pregunta = string.Empty;
            if (GlobalVar.CatalogoPropiedadB_Editando)            
                pregunta = "ESTA EN MODO EDICION, SE PERDERA LA NUEVA INFORMACION CAPTURADA";
            if (GlobalVar.CatalogoPropiedadB_Agregando)
                pregunta = "ESTA AGREGANDO NUEVA INFORMACION Y SE PERDERAN LOS CAMBIOS";

            if (pregunta.Trim().Length > 0)
            {
                pregunta += "\n¿DESEA CONTINUAR CON EL PROCESO?";
                DialogResult dlg = MessageBox.Show(pregunta, "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.No)
                {
                    return;
                }
            }

            
            BaseBotonCancelarClick();
            BaseMetodoInicio();      
                  
        }


        public override void BaseMetodoLimpiaControles()
        {
            try
            {
                Panel pnlControles = BuscaPanelControles();
                pnlControles.Enabled = false;
            }
            catch
            {
            }
        }

        public virtual void CargarDatosInicial()
        {
            BasedtDatosConFiltro = null;
            DataTable dtDatos = new DataTable();

            dtDatos = PreparaTabla(BaseDtDatos);
            BaseDtFiltra = dtDatos;

            if (dtDatos != null)
            {                
                dtDatos.Columns[0].ColumnName = "Clave";
                dtDatos.Columns[1].ColumnName = "Descripción";

                LlenaGrid(ref grdDatos, dtDatos);
            }
            txtFiltro.Focus();
        }

        public void DeshabilitaPages(ref TabControl tabControl, bool B_Valor)
        {
            foreach (TabPage tab in tabControl.TabPages)
            {
                ((Control)tab).Enabled = B_Valor;
            }
        }
        

        public DataTable PreparaTabla(DataTable dtPrepara)
        {
            string Clave = string.Empty;            
            string Descripcion = string.Empty;
            Clave = CatalogoPropiedadCampoClave;
            Descripcion = CatalogoPropiedadCampoDescripcion;
            
            DataTable dtDatos = new DataTable();            
            dtDatos.Columns.Add(CatalogoPropiedadCampoClave, (typeof(string)));
            dtDatos.Columns.Add(Descripcion, (typeof(string)));

            if (dtPrepara != null)
            {
                foreach (DataRow ren in dtPrepara.Rows)
                {
                    DataRow row = dtDatos.NewRow();
                    row[Clave] = ren[Clave];
                    row[Descripcion] = ren[Descripcion];
                    dtDatos.Rows.Add(row);
                }
            }

            return dtDatos;
        }

        public void LlenaGrid(ref DataGridView grd, DataTable dtGrid, string Titulo = "")
        {
            grd.AutoGenerateColumns = true;
            grd.DataSource = dtGrid;
            grd.MultiSelect = false;
            grd.ReadOnly = true;
            grd.AllowUserToResizeColumns = true;
            grd.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            grd.Refresh();
           

            if (CatalogoPropiedadMuestraColumnaClave)
            {            
                grdDatos.Columns[0].Visible = true;
                grdDatos.Columns[0].Width = 50;
                grdDatos.Columns[1].Width = pnlGrid.Width - 50;             
            }
            else
            {                
                grdDatos.Columns[0].Visible = false;
                grdDatos.Columns[1].Width = pnlGrid.Width;             
            }

            CambiaEtiquetaEstatus();
        }



        //public override void LlenaGrid(ref Form frm, ref DataGridView grd, DataTable dtGrid, string Titulo = "", bool B_SeleccionMultiple = false, bool B_ColumnasEnAutomatico = false, bool B_SoloLectura = true)
        //{
        //    if (CatalogoPropiedadMuestraColumnaClave)
        //    {
        //        if (B_ColumnasEnAutomatico)
        //        {
        //            grdDatos.Columns[0].Visible = true;
        //            grdDatos.Columns[0].Width = 50;
        //            grdDatos.Columns[1].Width = pnlGrid.Width - 50;
        //        }
        //    }
        //    else
        //    {
        //        if (B_ColumnasEnAutomatico)
        //        {
        //            grdDatos.Columns[0].Visible = false;
        //            grdDatos.Columns[1].Width = pnlGrid.Width;
        //        }
        //    }

        //    base.LlenaGrid(ref frm, ref grd, dtGrid, Titulo, B_SeleccionMultiple, B_ColumnasEnAutomatico, B_SoloLectura);
        //}



      
        public override void CambiaEtiquetaEstatus()
        {
            if (grdDatos == null)
                return;            

            BaseEtiquetaEstatus.Text = grdDatos.Rows.Count.ToString();
            if(grdDatos.Rows.Count == 1)
                BaseEtiquetaEstatus.Text += " Registro Encontrado...";
            else
                BaseEtiquetaEstatus.Text += " Registros Encontrados...";
        }


       
        private void BuscaRenglon(string valor)
        {
            BasedtDatosConFiltro = LINQTablaFiltraMultiple(BaseDtDatos, valor, DevuelveCamposBusqueda(BaseDtDatos));            
            
            if(BasedtDatosConFiltro != null)
            {                
                DataTable dtDatos = PreparaTabla(BasedtDatosConFiltro);
                if (dtDatos != null)
                {
                    dtDatos.Columns[0].ColumnName = "Clave";
                    dtDatos.Columns[1].ColumnName = "Descripción";
                    LlenaGrid(ref grdDatos, dtDatos);
                }
            }
        }

        private void cmbBusca_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyValue == 13)
            //{
            //    if (cmbBusca.SelectedText != null)
            //    {
            //        if (cmbBusca.SelectedText.Trim().Length > 0)
            //            BuscaRenglon(cmbBusca.SelectedText);
            //        else
            //            CargarDatosInicial();
            //    }
            //    else
            //        CargarDatosInicial();
            //}
        }

        public override void BaseBotonNuevoClick()
        {            
            CatalogoPropiedadId_Identity = null;
            CatalogoPropiedadDescripcion = string.Empty;
            CatalogoPropiedadEsRegistroNuevo = true;
            GlobalVar.CatalogoPropiedadB_Agregando = true;
            GlobalVar.CatalogoPropiedadB_Editando = false;
            pnlGrid.Enabled = false;
            lblTituloCatalogo.Text = "Agregando Nuevo Registro";
            pnlTitulo.BackColor = Color.FromArgb(0,128,0);
            pnlTitulo.Visible = true;
            CatalogoHabilitaPanelControles(true);
            if(txtFocus != null)
                txtFocus.Focus();
        }

        public override void BaseBotonModificarClick()
        {            
            CatalogoPropiedadEsRegistroNuevo = false;
            GlobalVar.CatalogoPropiedadB_Agregando = false;
            GlobalVar.CatalogoPropiedadB_Editando = true;
            pnlGrid.Enabled = false;
            lblTituloCatalogo.Text = "Modificando Información";
            pnlTitulo.BackColor = Color.RoyalBlue;
            pnlTitulo.Visible = true;
            CatalogoHabilitaPanelControles(true);
            if(txtFocus != null)
                txtFocus.Focus();
        }

        public virtual void CatalogoHabilitaPanelControles(bool B_Habilita)
        {
            Panel pnlControles = BuscaPanelControles();
            pnlControles.Enabled = B_Habilita;
        }
        

        public override void BaseBotonCancelarClick()
        {
            //grdDatos.ClearSelection();
            //BaseBotonModificar.Enabled = false;
            //BaseBotonBorrar.Enabled = false;
            BaseMetodoLimpiaControles();
            GlobalVar.CatalogoPropiedadB_Agregando = false;
            GlobalVar.CatalogoPropiedadB_Editando = false;
            CatalogoPropiedadId_Identity = null;            
            pnlGrid.Enabled = true;
            pnlTitulo.Visible = false;            
            txtFiltro.Text = string.Empty;
            CatalogoHabilitaPanelControles(false);
            grdDatos_Click(null, null);
            txtFiltro.Focus();
        }

        private void grdDatos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = grdDatos.CurrentRow;
            if (row != null)
            {
                FiltraRenglon(row.Cells[0].Value.ToString());                

                CatalogoPropiedadId_Identity = row.Cells[0].Value;
                CatalogoPropiedadDescripcion = row.Cells[1].Value.ToString();
            }
        }

        private void FiltraRenglon(string clave)
        {
            if (BaseDtDatos == null)
                return;

            string ClaveFiltro = string.Empty;

            BasedtDatosConFiltro = BaseDtDatos;
            ClaveFiltro = CatalogoPropiedadCampoClave;
            Type tipo = BasedtDatosConFiltro.Columns[ClaveFiltro].DataType;
            EnumerableRowCollection<DataRow> ren;
            if (tipo == typeof(Int16))
                ren = BasedtDatosConFiltro.AsEnumerable().Where(p => p.Field<Int16>(ClaveFiltro) == Convert.ToInt32(clave));
            else
            {
                if (tipo == typeof(int))
                    ren = BasedtDatosConFiltro.AsEnumerable().Where(p => p.Field<int>(ClaveFiltro) == Convert.ToInt32(clave));
                else
                    ren = BasedtDatosConFiltro.AsEnumerable().Where(p => p.Field<string>(ClaveFiltro) == clave);
            }
            if (ren.Any())
            {
                BaseBotonModificar.Enabled = true;
                BaseBotonBorrar.Enabled = true;
                CatalogoMetodoLlenaControles(ren.CopyToDataTable().Rows[0]);
            }
        }

       


        private void grdDatos_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = grdDatos.CurrentRow;
            if (row == null)
                return;

            FiltraRenglon(row.Cells[0].Value.ToString());

            CatalogoPropiedadId_Identity = row.Cells[0].Value.ToString();
            CatalogoPropiedadDescripcion = row.Cells[1].Value.ToString();
        }

        public virtual void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();
        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if(BaseDtDatos!=null)
            if (txtFiltro.Text.Trim().Length > 0)
                BuscaRenglon(txtFiltro.Text);
            else
                CargarDatosInicial();   
        }

        private void grdDatos_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyValue == 113) //F2 Nuevo
            //{
            //    if (BaseBotonNuevo.Visible)
            //    {
            //        sender = BaseBotonNuevo;
            //        CambiaTitulo(sender);
            //        BaseMetodoLimpiaControles();
            //        HabilitaBotones(sender, false);
            //        BaseBotonNuevoClick();    
            //        //btnNuevo_Click(sender, e);
            //    }
            //}
            //if (e.KeyValue == 114) //F3 Modificar
            //{
            //    if (BaseBotonModificar.Visible)
            //    {
            //        sender = BaseBotonModificar;
            //        CambiaTitulo(sender);
            //        HabilitaBotones(sender, false);
            //        BaseBotonModificarClick();
            //        //btnModificar_Click(sender, e);
            //    }
            //}
            //if (e.KeyValue == 115) //F4 Borrar
            //{
            //    if (BaseBotonBorrar.Visible)
            //    {
            //        sender = BaseBotonBorrar;
            //        BaseBotonBorrarClick();
            //        if (!BaseErrorResultado)
            //        {
            //            CambiaTitulo(sender);
            //            HabilitaBotones(sender);
            //        }
            //        //btnBorrar_Click(sender, e);
            //    }
            //}
            //if (e.KeyValue == 116) //F5 Guardar
            //{
            //    if (BaseBotonGuardar.Visible)
            //    {
            //        sender = BaseBotonGuardar;
            //        BaseBotonGuardarClick();
            //        if (!BaseErrorResultado)
            //        {
            //            CambiaTitulo(sender);
            //            HabilitaBotones(sender);
            //        }
            //        //btnGuardar_Click(sender, e);
            //    }
            //}
            //if (e.KeyValue == 117) //F6 Afecta
            //{
            //    if (BaseBotonAfectar.Visible)
            //    {
            //        sender = BaseBotonAfectar;
            //        BaseBotonAfectarClick();
            //        //btnAfectar_Click(sender, e);
            //    }
            //}
            //if (e.KeyValue == 118) //F7  Buscar
            //{
            //    if (BaseBotonBuscar.Visible)
            //    {
            //        sender = BaseBotonBuscar;
            //        BaseBotonBuscarClick();
            //        //btnBuscar_Click(sender, e);
            //    }
            //}

            //if (e.KeyValue == 119) //F8  Reporte
            //{
            //    if (BaseBotonReporte.Visible)
            //    {
            //        sender = BaseBotonReporte;
            //        BaseMetodoMostrarReporte();
            //        Frm_Reportes frmReporte = new Frm_Reportes();
            //        frmReporte.P_Titulo = BasePropiedadTituloReporte;
            //        frmReporte.P_ReporteRPT = BasePropiedadReporteRPT;
            //        frmReporte.ShowDialog();
            //        //btnReporte_Click(sender, e);
            //    }
            //}
            //if (e.KeyValue == 120) //F9 Excel
            //{
            //    if (BaseBotonExcel.Visible)
            //    {
            //        sender = BaseBotonExcel;
            //        BaseBotonExcelClick();
            //        //btnExcel_Click(sender, e);
            //    }
            //}
        }

        private void FormaCatalogo_Load(object sender, EventArgs e)
        {

        }
        public void primer_registro()
        {

            grdDatos.TabIndex = 1;
            grdDatos.TabIndex = 0;

        }
    }
}
