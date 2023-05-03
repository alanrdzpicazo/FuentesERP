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
using ProbeMedic.CATALOGOS.LABORATORIOS;

namespace ProbeMedic.CATALOGOS
{
    public partial class FRM_PRECIOS_ARTICULOS_PROGRAMAS : FormaBase
    {
        SQLPrecios sql_Precios= new SQLPrecios();

        DataTable ARTICULOS= new DataTable();
        DataTable ARTICULOSS = new DataTable();

        int res = -1, entra = 1, KPrograma = 0;
        string msg = string.Empty;
       
        public FRM_PRECIOS_ARTICULOS_PROGRAMAS()
        {
            InitializeComponent();

            ucPrograma1.K_Programa = KPrograma;
           
        }

        private void limpia()
        {
            if (dgvArticulosAsignados.RowCount > 0)
            {
                DataTable dt = (DataTable)dgvArticulosAsignados.DataSource;
                dt.Clear();
            }    
        }

        private void llenaGrid()
        {
            DateTime FechaInicial = DateTime.Today;
            FechaInicial = Convert.ToDateTime(dtpInicial.Value.ToString("yyyy/MM/dd"));

            DateTime FechaFinal = DateTime.Today;
            FechaFinal = Convert.ToDateTime(dtpFinal.Value.ToString("yyyy/MM/dd"));
            ARTICULOSS = sql_Precios.Sk_Programas_Articulos_Precios(ucPrograma1.K_Programa, ucAseguradora1.K_Aseguradora, FechaInicial,FechaFinal); // articulos en programa c/s precios 
         
            if (ARTICULOSS != null)
            {
                foreach (DataRow irow in ARTICULOSS.Rows)
                {
                    DataRow dtdRow = ARTICULOS.NewRow();
                    dtdRow["K_Programas_Articulos_Precios"] = irow["K_Programas_Articulos_Precios"].ToString();
                    dtdRow["K_Articulo"] = irow["K_Articulo"].ToString();
                    dtdRow["D_Articulo"] = irow["D_Articulo"].ToString();
                    dtdRow["F_Actualizacion"] = irow["F_Actualizacion"].ToString();
                    dtdRow["Precio"] = irow["Precio"].ToString();
                    ARTICULOS.Rows.Add(dtdRow);
                }
                dgvArticulosAsignados.DataSource = ARTICULOS;
                dgvArticulosAsignados.CurrentCell.Selected = false;
            }
            else
            {
                MessageBox.Show("NO EXISTEN PRECIOS DE ACTUALIZACION EN LA FECHA DE CONSULTA ...");
            }
        }

        private void llenaGridAlta()
        {
            DateTime FechaInicial = DateTime.Today;
            FechaInicial = Convert.ToDateTime(dtpActualizacion.Value.ToString("yyyy/MM/dd"));

            ARTICULOSS = sql_Precios.Sk_Programas_ArticuloS(ucPrograma1.K_Programa);

            if (ARTICULOSS != null)
            {
                foreach (DataRow irow in ARTICULOSS.Rows)
                {
                    DataRow dtdRow = ARTICULOS.NewRow();

                    dtdRow["K_Articulo"] = irow["K_Articulo"].ToString();
                    dtdRow["D_Articulo"] = irow["D_Articulo"].ToString();
                    dtdRow["F_Actualizacion"] = irow["F_Actualizacion"].ToString();
                    dtdRow["Precio"] = Convert.ToString("0.0000");

                    ARTICULOS.Rows.Add(dtdRow);
                }
                dgvArticulosAsignados.DataSource = ARTICULOS;
                dgvArticulosAsignados.CurrentCell.Selected = true;

            }
            else
            {
                if (ucPrograma1.K_Programa != 0)
                {
                    MessageBox.Show("EL PROGRAMA NO CUENTA CON ARTICULOS ASIGNADOS ...");
                }
            }
       
        }
        public override void BaseBotonReporteClick()
        {
            Cursor = Cursors.WaitCursor;
            FRM_REP_PRECIOS_PROG_ACTUAL frmrpa = new FRM_REP_PRECIOS_PROG_ACTUAL();
            frmrpa.llenaGrid();
            if(frmrpa.datos.Rows.Count==0)
            {
                MessageBox.Show("NO SE ENCONTRÓ INFORMACIÓN!..");
                Cursor = Cursors.Default;
                return;
            }
            frmrpa.ShowDialog();
            Cursor = Cursors.Default;
        }

        private void FRM_PRECIOS_ARTICULOS_PROGRAMAS_Load(object sender, EventArgs e)
        {
            BaseBotonNuevo.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonReporte.Text = "Precios Actuales";
            BaseBotonReporte.Width = 100;
            ARTICULOS.Columns.Add("K_Programas_Articulos_Precios", typeof(int));
            ARTICULOS.Columns.Add("K_Articulo", typeof(int));
            ARTICULOS.Columns.Add("D_Articulo", typeof(string));
            ARTICULOS.Columns.Add("F_Actualizacion", typeof(DateTime));
            ARTICULOS.Columns.Add("Precio", typeof(decimal));
            limpia();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (ucPrograma1.K_Programa == 0)
            {
                MessageBox.Show("DEBE INDICAR EL PROGRAMA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucPrograma1.Focus();
                return;
            }
            if (ucAseguradora1.K_Aseguradora == 0)
            {
                MessageBox.Show("DEBE INDICAR LA ASEGURADORA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucAseguradora1.Focus();
                return;
            }
            if (ucPrograma1.K_Programa != 0)
            {
                if (entra == Convert.ToInt32(0))
                {
                    limpia();
                }
            }
               
            entra = 0;
            limpia();
            llenaGrid();
            gbFiltros.Enabled = true;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
           
            gbFiltros.Enabled = false;
            pnlAlta.Enabled = true;
            BtnAplicar.Enabled = true;
  
            if (ucPrograma1.K_Programa == 0)
            {
                MessageBox.Show("DEBE INDICAR EL PROGRAMA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucPrograma1.Focus();
                return;

            }
            if (ucAseguradora1.K_Aseguradora== 0)
            {
                MessageBox.Show("DEBE INDICAR LA ASEGURADORA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucAseguradora1.Focus();
                return;

            }
            if (ucPrograma1.K_Programa != 0)

                if (entra == Convert.ToInt32(0))
                {
                    limpia();
                }
            entra = 0;
            llenaGridAlta();
        }

        private void BtnAplicar_Click(object sender, EventArgs e)
        {
            Int32 CampoIdentity = 0;
            msg = string.Empty;

            if (dgvArticulosAsignados.DataSource == null)
            {
                MessageBox.Show("NO EXISTEN ARTICULOS PARA ACTUALIZAR!..");
                return;
            }

            foreach (DataGridViewRow row in dgvArticulosAsignados.Rows)
            {
                res = sql_Precios.In_Programas_Articulos_Precios(ref CampoIdentity,
                Convert.ToInt16(ucPrograma1.K_Programa),
                Convert.ToInt32(row.Cells["K_Articulo"].Value),
                Convert.ToInt32(ucAseguradora1.K_Aseguradora),
                Convert.ToDecimal(row.Cells["Precio"].Value),
                Convert.ToDateTime(dtpActualizacion.Value.ToString("yyyy/MM/dd")),
                Convert.ToInt32(GlobalVar.K_Usuario),
                Convert.ToInt32(GlobalVar.K_Usuario),
                ref msg);
            }
            if (res == -1)
            {
                BaseErrorResultado = true;
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                BaseErrorResultado = false;
                MessageBox.Show("INFORMACION ACTUALIZADA CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpia();
                BaseMetodoInicio();
                BaseBotonCancelarClick();
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            msg = string.Empty;

            if (dgvArticulosAsignados.DataSource == null)
            {
                MessageBox.Show("NO EXISTEN ARTICULOS PARA ACTUALIZAR!..");
                return;
            }
            foreach (DataGridViewRow row in dgvArticulosAsignados.Rows)
            {
                res = sql_Precios.Up_Programas_Articulos_Precios(
                Convert.ToInt32(row.Cells["K_Programas_Articulos_Precios"].Value),
                Convert.ToInt32(ucPrograma1.K_Programa),
                Convert.ToInt32(row.Cells["K_Articulo"].Value),
                Convert.ToInt32(ucAseguradora1.K_Aseguradora),
                Convert.ToDecimal(row.Cells["Precio"].Value),
                Convert.ToInt32(GlobalVar.K_Usuario),
                ref msg);
            }
            if (res == -1)
            {
                BaseErrorResultado = true;
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                BaseErrorResultado = false;
                MessageBox.Show("INFORMACION ACTUALIZADA CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpia();
                llenaGrid();
            }
        }
    }
}
