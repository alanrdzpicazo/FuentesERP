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


namespace ProbeMedic.CXP
{
    public partial class Frm_Autoriza_CajaChica : FormaBase
    {
        SQLCatalogos sql_Catalogos = new SQLCatalogos();
        SQLCuentasxPagar sql_CxP = new SQLCuentasxPagar();

        DataTable USU_DISPONIBLES = new DataTable();
        DataTable USU_ASIGNADOS = new DataTable();
        DataTable USU_DISPONIBLESS = new DataTable();
        DataTable USU_ASIGNADOSS = new DataTable();


        public bool CatalogoPropiedadEsRegistroNuevo { get; set; }
        public object CatalogoPropiedadId_Identity { get; set; }

        int res = -1;
        string msg = string.Empty;
    
        public Frm_Autoriza_CajaChica()
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
            USU_DISPONIBLES.Columns.Add("K_Usuario", typeof(int));
            USU_DISPONIBLES.Columns.Add("D_Usuario", typeof(string));
            USU_ASIGNADOS.Columns.Add("K_Usuario", typeof(int));
            USU_ASIGNADOS.Columns.Add("D_Usuario", typeof(string));
            llena_Asignado();
            llena_Disponible();

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (!BaseFuncionValidaciones())
                return;
            int K_Usuario_Disp = 0;
            string D_Usuario_Disp = string.Empty;
            DataGridViewRow row = Dgv_Disponibles.CurrentRow;
            if (row == null)
                return;
            K_Usuario_Disp = Convert.ToInt32(row.Cells["K_Usuario2"].Value);
            D_Usuario_Disp = row.Cells["D_Usuario2"].Value.ToString();

            if (K_Usuario_Disp != 0)
            {
                res = sql_CxP.In_Usuario_AutorizaCajaChica(K_Usuario_Disp,GlobalVar.K_Usuario, ref msg);
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
                    llena_Asignado();
                    llena_Disponible();
                }

            }
        }
  
        private void llena_Disponible()
        {
           USU_DISPONIBLESS = sql_CxP.Sk_AutorizaCajaChicaDis();

           if (USU_DISPONIBLESS != null)
            {        
                foreach (DataRow irew in USU_DISPONIBLESS.Rows)
                {
                    DataRow dtdRow2 = USU_DISPONIBLES.NewRow();
                    dtdRow2["K_Usuario"] = Convert.ToInt32(irew["K_Usuario"]);
                    dtdRow2["D_Usuario"] = irew["D_Usuario"].ToString();
                    USU_DISPONIBLES.Rows.Add(dtdRow2);
                }
                Dgv_Disponibles.DataSource = USU_DISPONIBLES;           
            }
        }

        private void llena_Asignado()
        {
            USU_ASIGNADOSS = sql_CxP.Sk_AutorizaCajaChicaAsig();

            if (USU_ASIGNADOSS != null)
            {
                foreach (DataRow irow in USU_ASIGNADOSS.Rows)
                {
                    DataRow dtdRow = USU_ASIGNADOS.NewRow();
                    dtdRow["K_Usuario"] = Convert.ToInt32(irow["K_Usuario"]);
                    dtdRow["D_Usuario"] = irow["D_Usuario"].ToString();
                    USU_ASIGNADOS.Rows.Add(dtdRow);
                }
                Dgv_Asigandos.DataSource = USU_ASIGNADOS;
            }
        }

        private void limpia()
        {
            if (Dgv_Asigandos.RowCount > 0)
            {
                DataTable dt = (DataTable)Dgv_Asigandos.DataSource;
                dt.Clear();
            }
            if (Dgv_Disponibles.RowCount > 0)
            {
                DataTable dt2 = (DataTable)Dgv_Disponibles.DataSource;
                dt2.Clear();
            }
            txtUsuario.Clear();
        }

        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            int K_Usuario_Asig = 0;
            string D_Usuario_Asig = string.Empty;

            DataGridViewRow row = Dgv_Asigandos.CurrentRow;
            if (row == null)
                return;
            K_Usuario_Asig = Convert.ToInt32(row.Cells["K_Usuario"].Value);
            D_Usuario_Asig = row.Cells["D_Usuario"].Value.ToString();
            if (K_Usuario_Asig != 0)
            {
                res =sql_CxP.Dl_Usuario_AutorizaCajaChica(K_Usuario_Asig, ref msg);


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
                    llena_Asignado();
                    llena_Disponible();

                }

            }
        }

        private void btn_BuscarUsuario_Click(object sender, EventArgs e)
        {

            if (Dgv_Disponibles.RowCount > 0)
            {
                DataTable dt2 = (DataTable)Dgv_Disponibles.DataSource;
                dt2.Clear();
            }

            USU_DISPONIBLESS = sql_CxP.Sk_AutorizaCajaChicaDis(txtUsuario);

            if (USU_DISPONIBLESS != null)
            {

                foreach (DataRow irew in USU_DISPONIBLESS.Rows)
                {
                    DataRow dtdRow2 = USU_DISPONIBLES.NewRow();
                    dtdRow2["K_Usuario"] = Convert.ToInt32(irew["K_Usuario"]);
                    dtdRow2["D_Usuario"] = irew["D_Usuario"].ToString();
                    USU_DISPONIBLES.Rows.Add(dtdRow2);
                }
                Dgv_Disponibles.DataSource = USU_DISPONIBLES;
            }
        }
    }
}
