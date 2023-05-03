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
    public partial class Frm_Filtra_Cliente : Frm_Filtro
    {
        public Int32 PropiedadK_Empresa { get; set; }
        public Int32 K_Cliente_Seleccionado;
        public string D_Cliente_Seleccionado;
        public Int32 DiasCredito_Seleccionado;
        public decimal LimiteCredito_Seleccionado;
        public string Tarjeta;
        public decimal Monto;
        Funciones fx = new Funciones();
        SQLCatalogos sql_Catalogos = new SQLCatalogos();
        public DataTable datos = new DataTable();
        public DataTable CLIENTE = new DataTable();
        public DataTable CLIENTESS = new DataTable();

        public Frm_Filtra_Cliente(Int32 k_empresa)
        {
            InitializeComponent();
            PropiedadK_Empresa = k_empresa;
            grDatos.AutoGenerateColumns = false;
            txtClave.valor.KeyPress += new KeyPressEventHandler(valor_KeyPress);

        }
        private void valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                LlenaGrid();
            }
        }
        private void Frm_Filtra_Cliente_Load(object sender, EventArgs e)
        {
            //CLIENTE.Columns.Add("K_Cliente", typeof(int));
            //CLIENTE.Columns.Add("D_Cliente", typeof(string));
            //CLIENTE.Columns.Add("DiasCredito", typeof(int));
            //CLIENTE.Columns.Add("LimiteCredito", typeof(decimal));
            //CLIENTE.Columns.Add("No_Tarjeta", typeof(decimal));
            //CLIENTE.Columns.Add("Monto", typeof(decimal));
        }
     
        private void Entrar_Click(object sender, EventArgs e)
        {
            if (txtClave.valor.Text.Trim().Length == 0 && txtNombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE ESPECIFICAR AL MENOS UN FILTRO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (grDatos.RowCount > 0)
            {
                DataTable dt = (DataTable)grDatos.DataSource;
                dt.Clear();
            }
            LlenaGrid();
        }

        public void LlenaGrid()
        {
            string nombre = txtNombre.Text;
            string clave = txtClave.valor.Text.Trim();
            if (nombre == "")
            {
                nombre = null;
            }
            if (clave == "") 
            {
                clave = "0";
            }
            CLIENTESS = sql_Catalogos.Sk_Clientes_All(Convert.ToInt32(clave),nombre,PropiedadK_Empresa);

            if (CLIENTESS != null)
            {
                if(CLIENTESS.Rows.Count>0)
                {
                    grDatos.DataSource = CLIENTESS;
                    grDatos.Focus();
                }    
            }
            else
            {
                if(grDatos.RowCount>0)
                {
                    DataTable dt = (DataTable)grDatos.DataSource;
                    dt.Clear();
                }
                MessageBox.Show("NO SE ENCONTRO INFORMACION ...");           
            }
        }

        private void grDatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grDatos.CurrentRow != null)
            {
               K_Cliente_Seleccionado = Convert.ToInt32(grDatos.CurrentRow.Cells["K_Cliente"].Value.ToString());
               D_Cliente_Seleccionado = grDatos.CurrentRow.Cells["D_Cliente"].Value.ToString();
               DiasCredito_Seleccionado = Convert.ToInt32(grDatos.CurrentRow.Cells["DiasCredito"].Value.ToString());
               LimiteCredito_Seleccionado = Convert.ToDecimal(grDatos.CurrentRow.Cells["LimiteCredito"].Value.ToString());
               Tarjeta = grDatos.CurrentRow.Cells["No_Tarjeta"].Value != null ? grDatos.CurrentRow.Cells["No_Tarjeta"].Value.ToString() : string.Empty;
               Monto = grDatos.CurrentRow.Cells["Monto1"].Value!= null ?Convert.ToDecimal(grDatos.CurrentRow.Cells["Monto1"].Value.ToString()) :0;
               Close();               
            }
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (txtClave.valor.Text.Trim().Length == 0 && txtNombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE ESPECIFICAR AL MENOS UN FILTRO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (grDatos.RowCount > 0)
            {
                DataTable dt = (DataTable)grDatos.DataSource;
                dt.Clear();
            }
            Cursor = Cursors.WaitCursor;
            LlenaGrid();
            Cursor = Cursors.Default;

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
                K_Cliente_Seleccionado = Convert.ToInt32(grDatos.CurrentRow.Cells["K_Cliente"].Value.ToString());
                D_Cliente_Seleccionado = grDatos.CurrentRow.Cells["D_Cliente"].Value.ToString();
                DiasCredito_Seleccionado = Convert.ToInt32(grDatos.CurrentRow.Cells["DiasCredito"].Value.ToString());
                LimiteCredito_Seleccionado = Convert.ToDecimal(grDatos.CurrentRow.Cells["LimiteCredito"].Value.ToString());
                Tarjeta = grDatos.CurrentRow.Cells["No_Tarjeta"].Value != null? grDatos.CurrentRow.Cells["No_Tarjeta"].Value.ToString() : String.Empty ;
                Monto = grDatos.CurrentRow.Cells["Monto1"].Value != null ? Convert.ToDecimal(grDatos.CurrentRow.Cells["Monto1"].Value.ToString()): 0;
                this.Close();
            }
        }

        private void Frm_Filtra_Cliente_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue== Convert.ToChar(Keys.F11))
            {
                BtnBuscar.PerformClick();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Cursor = Cursors.WaitCursor;
                LlenaGrid();
                Cursor = Cursors.Default;
            }
        }

        private void grDatos_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Tab) || e.KeyValue == 9)
            {
                SendKeys.Send("{Down}");
            }
        }
    }
}
