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

namespace ProbeMedic.SEGURIDAD
{
    public partial class FRM_ASIGNA_USUARIOSERIE : FormaBase
    {
        SQLCatalogos sql_Catalogos = new SQLCatalogos();
        SQLCompras sQLCompras = new SQLCompras();
        DataTable SER_DISPONIBLES = new DataTable();
        DataTable SER_ASIGNADOS = new DataTable();
        DataTable SER_DISPONIBLESS = new DataTable();
        DataTable SER_ASIGNADOSS = new DataTable();

        public bool CatalogoPropiedadEsRegistroNuevo { get; set; }
        public object CatalogoPropiedadId_Identity { get; set; }

        int res = -1;
        string msg = string.Empty;

        public FRM_ASIGNA_USUARIOSERIE()
        {
            InitializeComponent();
            ucUsuarios1.txt_E_Usuario.TextChanged += new EventHandler(txt_E_Usuario_TextChanged);
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
            SER_DISPONIBLES.Columns.Add("D_Serie", typeof(string));
            SER_ASIGNADOS.Columns.Add("D_Serie", typeof(string));
            Llena_Asignado();
            Llena_Disponible();
        }

        private void txt_E_Usuario_TextChanged(object sender, EventArgs e)
        {
            if (dgvDisponibles.RowCount > 0)
            {
                DataTable dt2 = (DataTable)dgvDisponibles.DataSource;
                dt2.Clear();
            }
            if(ucUsuarios1.K_Usuario>0)
            {
                limpia();
                Llena_Disponible();
                Llena_Asignado();
            }
          
        }

        private void FRM_ASIGNACION_USUARIOS_SERIE_Load(object sender, EventArgs e)
        {
            limpia();
         
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
           if(ucUsuarios1.K_Usuario == 0)
            {
                MessageBox.Show("DEBE CAPTURAR USUARIO!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucUsuarios1.Focus();
                return;
            }

            string D_Serie_Disp = string.Empty;
            DataGridViewRow row = dgvDisponibles.CurrentRow;
            if (row == null)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA SERIE!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvDisponibles.Focus();
                return;
            }
                
            D_Serie_Disp = row.Cells["D_SerieDisp"].Value.ToString();

            if (ucUsuarios1.K_Usuario != 0)
            {
                res = sqlCatalogos.In_Usuarios_Serie(ucUsuarios1.K_Usuario,D_Serie_Disp, ref msg);
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
            if(ucUsuarios1.K_Usuario>0)
            {
                SER_DISPONIBLESS = sqlCatalogos.SK_UsuaSerieDisp(ucUsuarios1.K_Usuario);

                if (SER_DISPONIBLESS != null)
                {

                    foreach (DataRow irew in SER_DISPONIBLESS.Rows)
                    {
                        DataRow dtdRow2 = SER_DISPONIBLES.NewRow();
                        dtdRow2["D_Serie"] = irew["D_Serie"].ToString();
                        SER_DISPONIBLES.Rows.Add(dtdRow2);
                    }
                    dgvDisponibles.DataSource = SER_DISPONIBLES;
                }
            }
      
        }

        private void Llena_Asignado()
        {
            if(ucUsuarios1.K_Usuario>0)
            {
                SER_ASIGNADOSS = sqlCatalogos.SK_UsuaSerieAsig(ucUsuarios1.K_Usuario);

                if (SER_ASIGNADOSS != null)
                {
                    foreach (DataRow irow in SER_ASIGNADOSS.Rows)
                    {
                        DataRow dtdRow = SER_ASIGNADOS.NewRow();
                        dtdRow["D_Serie"] = irow["D_Serie"].ToString();
                        SER_ASIGNADOS.Rows.Add(dtdRow);
                    }
                    dgvAsignados.DataSource = SER_ASIGNADOS;
                }
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

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
   
            string D_Serie_Asig = string.Empty;

            DataGridViewRow row = dgvAsignados.CurrentRow;
            if (row == null)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA SERIE!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvAsignados.Focus();
                return;
            }
               
            D_Serie_Asig = row.Cells["D_SerieAsig"].Value.ToString();
            if (ucUsuarios1.K_Usuario != 0)
            {
                res = sqlCatalogos.DL_Usuarios_Serie(ucUsuarios1.K_Usuario,D_Serie_Asig, ref msg);


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

    }
}
