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


namespace ProbeMedic.CATALOGOS

{
    public partial class FRM_ASIGNAARTICULO_KIT : FormaBase
    {
        SQLCatalogos sql_Catalogos = new SQLCatalogos();
        SQLCompras sQLCompras = new SQLCompras();
        DataTable AR_DISPONIBLES = new DataTable();
        DataTable AR_ASIGNADOS = new DataTable();
        DataTable AR_DISPONIBLESS = new DataTable();
        DataTable AR_ASIGNADOSS = new DataTable();


        public bool CatalogoPropiedadEsRegistroNuevo { get; set; }
        public object CatalogoPropiedadId_Identity { get; set; }
        int res = -1;
        int K_Clase_ServicioEnfermeria, K_Tipo_Servicio_Enfermeria;


        string msg = string.Empty;
    
        public FRM_ASIGNAARTICULO_KIT()
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
            AR_DISPONIBLES.Columns.Add("K_Articulo", typeof(int));
            AR_DISPONIBLES.Columns.Add("D_Articulo", typeof(string));
            AR_ASIGNADOS.Columns.Add("K_Articulo", typeof(int));
            AR_ASIGNADOS.Columns.Add("D_Articulo", typeof(string));
            AR_ASIGNADOS.Columns.Add("Cantidad", typeof(int));
            txtClase.Clear();
            txtServicios.Clear();
            K_Clase_ServicioEnfermeria = 0;
            K_Tipo_Servicio_Enfermeria = 0;


        }



        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (!BaseFuncionValidaciones())
                return;
            int K_Articulo = 0;
            string D_Articulo = string.Empty;
            DataGridViewRow row = dgvDisponibles.CurrentRow;
            if (row == null)
                return;
            K_Articulo = Convert.ToInt32(row.Cells["K_Articulo2"].Value);
            D_Articulo = row.Cells["D_Articulo2"].Value.ToString();

            if (K_Articulo != 0)
            {
                res = sqlCatalogos.In_Kits_Enfermeria(K_Clase_ServicioEnfermeria,K_Tipo_Servicio_Enfermeria,K_Articulo, Convert.ToInt32(txtCantidad.Text), ref msg);
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

            AR_DISPONIBLESS = sqlCatalogos.SK_Kits_Enfermeria_Disponiblesbulancias(K_Clase_ServicioEnfermeria, K_Tipo_Servicio_Enfermeria);

           if (AR_DISPONIBLESS!= null)
            {
               
                foreach (DataRow irew in AR_DISPONIBLESS.Rows)
                {
                    DataRow dtdRow2 = AR_DISPONIBLES.NewRow();
                    dtdRow2["K_Articulo"] = Convert.ToInt32(irew["K_Articulo"]);
                    dtdRow2["D_Articulo"] = irew["D_Articulo"].ToString();
                    AR_DISPONIBLES.Rows.Add(dtdRow2);
                }
                dgvDisponibles.DataSource = AR_DISPONIBLES;           
            }
        }

        private void Llena_Asignado()
        {

            AR_ASIGNADOSS = sqlCatalogos.SK_Kits_Enfermeria(K_Clase_ServicioEnfermeria, K_Tipo_Servicio_Enfermeria);

            if (AR_ASIGNADOSS != null)
            {
                foreach (DataRow irow in AR_ASIGNADOSS.Rows)
                {
                    DataRow dtdRow = AR_ASIGNADOS.NewRow();
                    dtdRow["K_Articulo"] = Convert.ToInt32(irow["K_Articulo"]);
                    dtdRow["D_Articulo"] = irow["D_Articulo"].ToString();
                    dtdRow["Cantidad"] = Convert.ToInt32(irow["Cantidad"]);
                    AR_ASIGNADOS.Rows.Add(dtdRow);
                }
                dgvAsignados.DataSource = AR_ASIGNADOS;
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
            txtCantidad.Clear();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int K_Articulo_Asig = 0;
            string D_Articulo_Asig = string.Empty;


            DataGridViewRow row = dgvAsignados.CurrentRow;
            if (row == null)
                return;
            K_Articulo_Asig = Convert.ToInt32(row.Cells["K_Articulo"].Value);
            D_Articulo_Asig = row.Cells["D_Articulo"].Value.ToString();
            if (K_Articulo_Asig != 0)
            {
                res = sqlCatalogos.Dl_Kits_Enfermeria(K_Clase_ServicioEnfermeria, K_Tipo_Servicio_Enfermeria, K_Articulo_Asig, ref msg);


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
        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (txtClase.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA CLASIFICACION DEL SERVICIO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClase.Focus();
                return false;
            }

            if (K_Clase_ServicioEnfermeria == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA CLASIFICACION DEL SERVICIO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnClase.Focus();
                return false;
            }

            if (K_Tipo_Servicio_Enfermeria == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL TIPO DE SERVICIO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnServicios.Focus();
                return false;
            }

            if (txtCantidad.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA CANTIDAD ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidad.Focus();
                return false;
            }

            BaseErrorResultado = false;
            return true;
        }

        private void BtnServicios_Click(object sender, EventArgs e)
        {
            if (txtClase.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA CLASIFICACION DEL SERVICIO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnClase.Focus();
                return;
            }

            GlobalVar.dtServicios = sql_Catalogos.Sk_Tipos_Servicios_Enfermeria();
            Busquedas.Frm_Busca_Tipo_Servicio_Enfermeria frm = new Busquedas.Frm_Busca_Tipo_Servicio_Enfermeria();
            frm.ShowDialog();
            K_Tipo_Servicio_Enfermeria = frm.LLave_Seleccionado;
            txtServicios.Text = frm.Descripcion_Seleccionado;
            
            if (K_Tipo_Servicio_Enfermeria != 0)
            {
                limpia();
                Llena_Asignado();
                Llena_Disponible();
            }
        }

        private void BtnClase_Click(object sender, EventArgs e)
        {
            txtServicios.Clear();
            GlobalVar.dtServicios = sql_Catalogos.Sk_Clasificacion_Servicios_Enfermeria();
            Busquedas.Frm_Busca_Clase_Servicios_Enf frm = new Busquedas.Frm_Busca_Clase_Servicios_Enf();
            frm.ShowDialog();
            K_Clase_ServicioEnfermeria = frm.LLave_Seleccionado;
            txtClase.Text = frm.Descripcion_Seleccionado;

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 13)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 46)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

    }
}
