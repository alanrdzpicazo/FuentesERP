using System;
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
    public partial class Frm_FiltraArticuloNombre : Frm_Filtro
    {
        Funciones fx = new Funciones();
        SQLCatalogos sql_Catalogos = new SQLCatalogos();

        public Int32 K_Articulo_Seleccionado;
        public string D_Articulo_Seleccionado;

        public DataTable datos = new DataTable();
        public DataTable ARTICULO = new DataTable();
        public DataTable ARTICULOS = new DataTable();

        public Frm_FiltraArticuloNombre()
        {
            InitializeComponent();
        }

        private void Frm_FiltraArticuloNombre_Load(object sender, EventArgs e)
        {
            ARTICULO.Columns.Add("K_Articulo", typeof(int));
            ARTICULO.Columns.Add("D_Articulo", typeof(string));
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE ESPECIFICAR NOMBRE DE UN ARTICULO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (grDatos.RowCount > 0)
            {
                DataTable dt = (DataTable)grDatos.DataSource;
                dt.Clear();
            }
            LlenaGrid();
        }

        private void grDatos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Enter))
            {
                grDatos.EndEdit();             // if you want to preserve the current commit behavior
                e.Handled = true;

                DataGridViewRow row = grDatos.CurrentRow;
                if (row == null)
                    return;
                K_Articulo_Seleccionado = Convert.ToInt32(grDatos.CurrentRow.Cells["K_Articulo"].Value.ToString());
                D_Articulo_Seleccionado = grDatos.CurrentRow.Cells["D_Articulo"].Value.ToString();
                this.Close();
            }
        }

        private void Frm_FiltraArticuloNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                BtnBuscar.PerformClick();
            }
        }

        public void LlenaGrid()
        {
            string nombre = txtNombre.Text;
            if (nombre == "")
            {
                nombre = null;
            }
            ARTICULOS = sql_Catalogos.Sk_Articulos_All(nombre);

            if (ARTICULOS != null)
            {
                foreach (DataRow irow in ARTICULOS.Rows)
                {
                    DataRow dtdRow = ARTICULO.NewRow();
                    dtdRow["K_Articulo"] = irow["K_Articulo"].ToString();
                    dtdRow["D_Articulo"] = irow["D_Articulo"].ToString();
                    ARTICULO.Rows.Add(dtdRow);
                }
                grDatos.DataSource = ARTICULO;
            }
            else
            {
                MessageBox.Show("NO SE ENCONTRO INFORMACION ...");
            }
        }

        private void grDatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            grDatos.EndEdit();             
            DataGridViewRow row = grDatos.CurrentRow;
            if (row == null)
                return;
            K_Articulo_Seleccionado = Convert.ToInt32(grDatos.CurrentRow.Cells["K_Articulo"].Value.ToString());
            D_Articulo_Seleccionado = grDatos.CurrentRow.Cells["D_Articulo"].Value.ToString();
            this.Close();
        }
    }
}
