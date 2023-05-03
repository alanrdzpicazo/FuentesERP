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

namespace ProbeMedic.CATALOGOS.ENFERMERIA
{
    public partial class FRM_ZONIFICACION_LOCAL_ENF : FormaBase
    {
        SQLCatalogos sql_Catalogos = new SQLCatalogos();
        SQLPrecios sql_Precios = new SQLPrecios();
        DataTable CD_Disponibless = new DataTable();
        DataTable CD_Asignadass = new DataTable();
        DataTable CD_Disponibles = new DataTable();
        DataTable CD_Asignadas = new DataTable();


        public bool CatalogoPropiedadEsRegistroNuevo { get; set; }
        public object CatalogoPropiedadId_Identity { get; set; }
        int KOficina = 0, KPais = 0, KEdo = 0, KCd = 0, KCol, res = -1, entra = 1;


        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            int K_Colonia_Asig = 0;
            string D_Colonia_Asig = string.Empty;


            DataGridViewRow row = dtCD_Asignadas.CurrentRow;
            if (row == null)
                return;
            if (CbxTodas.Checked)
            {
                res = sql_Precios.Dl_Zonificacion_Local_Enf_All(ucOficinas1.K_Oficina, geo_Ciudades1.K_Pais, geo_Ciudades1.K_Estado, geo_Ciudades1.K_Ciudad, GlobalVar.K_Usuario, ref msg);
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
            else
            {
                K_Colonia_Asig = Convert.ToInt32(row.Cells["K_Ciudad"].Value);
                D_Colonia_Asig = row.Cells["D_Ciudad"].Value.ToString();
                if (K_Colonia_Asig != 0)
                {
                    res = sql_Catalogos.Dl_Zonificacion_Local_Enfermeria(ucOficinas1.K_Oficina, geo_Ciudades1.K_Pais, geo_Ciudades1.K_Estado, geo_Ciudades1.K_Ciudad, K_Colonia_Asig, GlobalVar.K_Usuario, ref msg);


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

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            int K_Colonia_Disp = 0;
            string D_Colonia_Disp = string.Empty;

            DataGridViewRow row = dtCD_Disponible.CurrentRow;
            if (row == null)
                return;
            if (CbxTodas.Checked)  
            {
                res = sql_Precios.In_Zonificacion_Local_Enf_All(ucOficinas1.K_Oficina, geo_Ciudades1.K_Pais, geo_Ciudades1.K_Estado, geo_Ciudades1.K_Ciudad, GlobalVar.K_Usuario, ref msg);
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
            else
            { 
            K_Colonia_Disp = Convert.ToInt32(row.Cells["K_Ciudad2"].Value);
            D_Colonia_Disp = row.Cells["D_Ciudad2"].Value.ToString();

                if (K_Colonia_Disp != 0)
                {
                    res = sql_Catalogos.In_Zonificacion_Local_Enfermeria(ucOficinas1.K_Oficina, geo_Ciudades1.K_Pais, geo_Ciudades1.K_Estado, geo_Ciudades1.K_Ciudad, K_Colonia_Disp, GlobalVar.K_Usuario, ref msg);
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

        string DOficina = string.Empty, DPais = string.Empty, DEdo = string.Empty, DCd = string.Empty;


        private void FRM_ZONIFICACION_LOCAL_ENF_Load(object sender, EventArgs e)
        {
            CD_Disponibles.Columns.Add("K_Colonia", typeof(int));
            CD_Disponibles.Columns.Add("D_Colonia", typeof(string));

            CD_Asignadas.Columns.Add("K_Colonia", typeof(int));
            CD_Asignadas.Columns.Add("D_Colonia", typeof(string));



            limpia();
            Llena_Asignado();
            Llena_Disponible();
        }

        string msg = string.Empty;
        public FRM_ZONIFICACION_LOCAL_ENF()
        {
            InitializeComponent();
            ucOficinas1.K_Oficina = KOficina;
            ucOficinas1.txt_E_Oficina.Text = DOficina;
            geo_Ciudades1.K_Pais = KPais;
            geo_Ciudades1.txt_G_Pais.Text = DPais;
            geo_Ciudades1.K_Estado = KEdo;
            geo_Ciudades1.txt_G_Estado.Text = DEdo;
            geo_Ciudades1.K_Ciudad = KCd;
            geo_Ciudades1.txt_G_Ciudad.Text = DCd;
            cambia_fuente_controles();

            BaseBotonAfectar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonReporte.Visible = false;


            geo_Ciudades1.txt_G_Ciudad.TextChanged += new System.EventHandler(txt_G_Ciudad_TextChanged);
            ucOficinas1.txt_E_Oficina.TextChanged += new System.EventHandler(this.txt_E_Oficina_TextChanged);
        }
        private void Llena_Disponible()
        {

            CD_Disponibless = sql_Catalogos.Sk_Ciudades_Disp_LocalEnfermeria(ucOficinas1.K_Oficina, geo_Ciudades1.K_Pais, geo_Ciudades1.K_Estado, geo_Ciudades1.K_Ciudad);

            if (CD_Disponibless != null)
            {
                foreach (DataRow irew in CD_Disponibless.Rows)
                {
                    DataRow dtdRow2 = CD_Disponibles.NewRow();
                    dtdRow2["K_Colonia"] = Convert.ToInt32(irew["K_Colonia"]);
                    dtdRow2["D_Colonia"] = irew["D_Colonia"].ToString();
                    CD_Disponibles.Rows.Add(dtdRow2);
                }
                dtCD_Disponible.DataSource = CD_Disponibles;
            }
        }

        private void Llena_Asignado()
        {

            CD_Asignadass = sql_Catalogos.SK_Zonificacion_Local_Enfermeria_Asig(ucOficinas1.K_Oficina, geo_Ciudades1.K_Pais, geo_Ciudades1.K_Estado, geo_Ciudades1.K_Ciudad);

            if (CD_Asignadass != null)
            {
                foreach (DataRow irow in CD_Asignadass.Rows)
                {
                    DataRow dtdRow = CD_Asignadas.NewRow();
                    dtdRow["K_Colonia"] = Convert.ToInt32(irow["K_Colonia"]);
                    dtdRow["D_Colonia"] = irow["D_Colonia"].ToString();
                    CD_Asignadas.Rows.Add(dtdRow);
                }
                dtCD_Asignadas.DataSource = CD_Asignadas;
            }
        }

        private void limpia()
        {
            if (dtCD_Asignadas.RowCount > 0)
            {
                DataTable dt = (DataTable)dtCD_Asignadas.DataSource;
                dt.Clear();
            }
            if (dtCD_Disponible.RowCount > 0)
            {
                DataTable dt2 = (DataTable)dtCD_Disponible.DataSource;
                dt2.Clear();
            }
        }
        private void txt_G_Ciudad_TextChanged(object sender, EventArgs e)
        {
            if (geo_Ciudades1.K_Estado != 0)

                if (entra == Convert.ToInt32(0))
                {
                    limpia();

                }
            entra = 0;
            Llena_Asignado();
            Llena_Disponible();
        }
        private void txt_E_Oficina_TextChanged(object sender, EventArgs e)
        {
            geo_Ciudades1.K_Pais = 0;
            geo_Ciudades1.txt_G_Pais.Clear();
            geo_Ciudades1.K_Estado = 0;
            geo_Ciudades1.txt_G_Estado.Clear();
            limpia();
        }

    }
}
