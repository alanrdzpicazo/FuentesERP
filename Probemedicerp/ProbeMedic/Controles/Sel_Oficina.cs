using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbeMedic.Controles
{
    public partial class Sel_Oficina : UserControl
    {
        string strValorEntrada = "";
        private int _oficina;

        public int K_Oficina
        {
            get { return _oficina; }
            set
            {
                _oficina = value;
                SendPropertyChanged("K_Oficina");
            }
        }

        public Sel_Oficina()
        {
            InitializeComponent();
            K_Oficina = 0;
        }

        public TextBox txt_Oficina
        {
            get { return this.txtOficina; }
        }
        public TextBox txt_ClaveOficina
        {
            get { return this.txtClaveOficina; }
        }

        private void btnBuscarOficina_Click(object sender, EventArgs e)
        {
            Busquedas.BuscaOficinas frm = new Busquedas.BuscaOficinas();
            frm.BusquedaPropiedadCamposBusqueda = "K_Oficina,D_Oficina";
            frm.BusquedaPropiedadTablaFiltra = GlobalVar.dtOficinas;
            frm.BusquedaPropiedadTitulo = "Busca Oficinas";
            frm.ShowDialog();
            if(frm.LLave_Seleccionado > 0)
            {
                K_Oficina = frm.LLave_Seleccionado;
                txtOficina.Text = frm.Descripcion_Seleccionado;
                txtClaveOficina.Text = frm.LLave_Seleccionado.ToString();
            }
            
        }

        private void txtOficina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Busquedas.BuscaOficinas frm = new Busquedas.BuscaOficinas();
                frm.BusquedaPropiedadCamposBusqueda = "K_Oficina,D_Oficina";
                frm.BusquedaPropiedadTablaFiltra = GlobalVar.dtOficinas;
                frm.BusquedaPropiedadTitulo = "Busca Oficinas";
                frm.campo_busca = txtOficina.Text;
                frm.ShowDialog();
                if (frm.LLave_Seleccionado > 0)
                {
                    K_Oficina = frm.LLave_Seleccionado;
                    txtOficina.Text = frm.Descripcion_Seleccionado;
                    txtClaveOficina.Text = frm.LLave_Seleccionado.ToString();
                }
            }
        }

        private void SendPropertyChanged(string property)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        private void txtOficina_TextChanged(object sender, EventArgs e)
        {
            if (txtOficina.Text.Length == 0)
            {
                K_Oficina = 0;
                txtClaveOficina.Text = "";
            }
        }

        public System.Data.DataTable BuscaEnTablaClaveDescripcion(System.Data.DataTable dtBusca, string CampoClave, string CampoDescripcion, ref System.Windows.Forms.TextBox txtClave, ref System.Windows.Forms.TextBox txtDescripcion)
        {
            bool B_BusquedaExacta = false;
            System.Data.DataTable dt = new System.Data.DataTable();

            if (dtBusca == null)
            {
                txtDescripcion.Text = string.Empty;
                return dt;
            }
            if (dtBusca.Rows.Count == 0)
            {
                txtDescripcion.Text = string.Empty;
                return dt;
            }
            if (txtClave.Text.Trim().Length == 0)
            {
                txtDescripcion.Text = string.Empty;
                return dt;
            }
            if (CampoClave.Trim().Length == 0)
            {
                MessageBox.Show("FALTA VALOR PARA CAMPO CLAVE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripcion.Text = string.Empty;
                return dt;
            }
            if (CampoDescripcion.Trim().Length == 0)
            {
                MessageBox.Show("FALTA VALOR PARA CAMPO DESCRIPCION...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripcion.Text = string.Empty;
                return dt;
            }


            if (txtClave.Text.Trim().Length > 0)
            { B_BusquedaExacta = true; }
            //LUIS REYES  06Ene2015
            if (B_BusquedaExacta == true)
            { dt = LINQTablaFiltroExactoMultiple(dtBusca, txtClave.Text, CampoClave); }
            else
            { dt = LINQTablaFiltraMultiple(dtBusca, txtClave.Text, CampoClave); }
            if (dt.Rows.Count > 0)
                txtDescripcion.Text = dt.Rows[0][CampoDescripcion].ToString();
            else
            {
                txtClave.Text = string.Empty;
                txtDescripcion.Text = string.Empty;
            }

            return dt;
        }

        public System.Data.DataTable LINQTablaFiltroExactoMultiple(System.Data.DataTable dtAFiltrar, string ValorBuscar, string CamposBusqueda = "")
        {
            System.Data.DataTable dtRes = dtAFiltrar.Clone();
            string[] campos = CamposBusqueda.Split(',');

            var cols = dtAFiltrar.Columns.Cast<DataColumn>().Where(c => campos.Contains(c.ColumnName)); //Valida que existan los campos a buscar
            if (cols.Any())
            {
                var fuente = from c in TablaColumnasTipoString(dtAFiltrar).AsEnumerable()
                             select c;

                var filtro = fuente;

                for (int a = 0; a < campos.Length; a++)
                {
                    filtro = fuente.Where(o => o.Field<string>(campos[a]) != null && o.Field<string>(campos[a]).Equals(ValorBuscar.ToUpper()));
                    if (filtro.Any())
                    {
                        foreach (var row in filtro)
                        {
                            dtRes.ImportRow(row);
                        }
                    }
                }

            }

            if (dtRes.Rows.Count > 0)
                dtRes = dtRes.DefaultView.ToTable(true);
            return dtRes;
        }

        public System.Data.DataTable TablaColumnasTipoString(System.Data.DataTable dt)
        {
            System.Data.DataTable dtRes = dt.Clone();
            foreach (DataColumn col in dtRes.Columns)
                col.DataType = typeof(string);

            foreach (DataRow ren in dt.Rows)
                dtRes.ImportRow(ren);

            return dtRes;
        }

        public System.Data.DataTable LINQTablaFiltraMultiple(System.Data.DataTable dtAFiltrar, string ValorBuscar, string CamposBusqueda = "")
        {
            System.Data.DataTable dtRes = dtAFiltrar.Clone();
            string[] campos = CamposBusqueda.Split(',');

            var cols = dtAFiltrar.Columns.Cast<DataColumn>().Where(c => campos.Contains(c.ColumnName)); //Valida que existan los campos a buscar
            if (cols.Any())
            {
                var fuente = from c in TablaColumnasTipoString(dtAFiltrar).AsEnumerable()
                             select c;

                var filtro = fuente;

                for (int a = 0; a < campos.Length; a++)
                {
                    filtro = fuente.Where(o => o.Field<string>(campos[a]) != null && o.Field<string>(campos[a]).Contains(ValorBuscar.ToUpper()));
                    if (filtro.Any())
                    {
                        foreach (var row in filtro)
                        {
                            dtRes.ImportRow(row);
                        }
                    }
                }

            }
            if (dtRes.Rows.Count > 0)
                dtRes = dtRes.DefaultView.ToTable(true);
            //dtRes = dtRes.AsEnumerable().Distinct().CopyToDataTable(); NO marca error, pero hace el distinct
            return dtRes;
        }

        private void txtClaveOficina_Leave(object sender, EventArgs e)
        {

        }

        private void txtClaveOficina_Enter(object sender, EventArgs e)
        {
            strValorEntrada = txtClaveOficina.Text;
        }

    }
}
