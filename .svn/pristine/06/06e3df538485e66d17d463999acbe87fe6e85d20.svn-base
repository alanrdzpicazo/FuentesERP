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
    public partial class Frm_Buscar : Frm_Base_Buscar
    {        

        public string CatalogoPropiedadCampoDescripcion { get; set; }
        public string CatalogoPropiedadCampoClave { get; set; }
        public bool CatalogoPropiedadMuestraColumnaClave { get; set; }        

        public int LLave_Seleccionado { get; set; }
        public string Descripcion_Seleccionado { get; set; }

        public string campo_busca { get; set; }
        public bool auto_cierre { get; set; }


        public Frm_Buscar()
        {
            InitializeComponent();
            
        }

        public DataGridView CatalogoGrid
        {
            get { return this.grdDatos; }
        }

        public virtual void CargarDatosInicial()
        {

            DataTable dtDatos = new DataTable();

            dtDatos = PreparaTabla(BaseDtDatos);
            BaseDtFiltra = dtDatos;

            if (dtDatos != null)
            {
                dtDatos.Columns[0].ColumnName = "Clave";
                dtDatos.Columns[1].ColumnName = "Descripción";

                LlenaGrid(ref grdDatos, dtDatos);
            }
            txt_Buscar.Focus();
        }
        public virtual void CatalogoMetodoLlenaControles(DataRow ren)
        {

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
                grdDatos.Columns[1].Width = 50;
                grdDatos.Columns[1].Width = grdDatos.Width - 110;
            }
            else
            {
                grdDatos.Columns[0].Visible = false;

                grdDatos.Columns[1].Width = grdDatos.Width - 60;
            }

        }
        public override void BaseMetodoInicio()
        {            
            CargarDatosInicial();
            base.BaseMetodoInicio();
            txt_Buscar.Focus();

            grdDatos.Focus();

            //if (campo_busca!="")
            //{
            txt_Buscar.Text = campo_busca;


            if (grdDatos.RowCount == 1)
            {
                DataGridViewRow row = grdDatos.Rows[0];
                if (row == null)
                    return;

                regresa_seleccion(Convert.ToInt32(row.Cells[0].Value), row.Cells[1].Value.ToString());
                this.Close();
            }

            //}
            
                
            
        }

        
        
        //Funcion para buscar con Linq
        private void BuscaRenglon(string valor)
        {
            BasedtDatosConFiltro = LINQTablaFiltraMultiple(BaseDtDatos, valor, DevuelveCamposBusqueda(BaseDtDatos));

            if (BasedtDatosConFiltro != null)
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
        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (txt_Buscar.Text.Trim().Length > 0)
            {
                BuscaRenglon(txt_Buscar.Text);
                
            }

            else
            {
                CargarDatosInicial();
            }
        }

        private void Frm_Buscar_Load(object sender, EventArgs e)
        {
            txt_Buscar.CharacterCasing = CharacterCasing.Upper;
        }

        private  void grdDatos_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow row = grdDatos.CurrentRow;
            if (row == null)
                return;
           
            regresa_seleccion(Convert.ToInt32(row.Cells[0].Value), row.Cells[1].Value.ToString());
            this.Close();
        }

        private  void regresa_seleccion(int clave, string desc)
        {
            LLave_Seleccionado = clave;
            Descripcion_Seleccionado = desc;
        }

        private void grdDatos_SelectionChanged(object sender, EventArgs e)
        {
            //DataGridViewRow row = grdDatos.CurrentRow;
            //if (row == null)
            //    return;

            //regresa_seleccion(Convert.ToInt32(row.Cells[0].Value), row.Cells[1].Value.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //if (LLave_Seleccionado > 0)
            //{
            //    this.Close();
            //}
            DataGridViewRow row = grdDatos.CurrentRow;
            if (row == null)
                return;

            regresa_seleccion(Convert.ToInt32(row.Cells[0].Value), row.Cells[1].Value.ToString());
            this.Close();
        }

        private void txt_Buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                DataGridViewRow row = grdDatos.CurrentRow;
                if (row == null)
                    return;

                regresa_seleccion(Convert.ToInt32(row.Cells[0].Value), row.Cells[1].Value.ToString());
                this.Close();

            }
            
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

                regresa_seleccion(Convert.ToInt32(row.Cells[0].Value), row.Cells[1].Value.ToString());
                this.Close();
            }
        }
    }
}
