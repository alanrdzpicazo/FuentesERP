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
    public partial class FRM_CAMBIA_EMPRESA : FormaBase
    {
        SQLCatalogos sql_catalogos = new SQLCatalogos();

        DataTable dtOficina = new DataTable();
        int res = 0;
        string msg = string.Empty;
        public FRM_CAMBIA_EMPRESA()
        {
            InitializeComponent();
            ucEmpresas1.PropertyChanged += new PropertyChangedEventHandler(ucEmpresas1_PropertyChanged);
        }
        private void ucEmpresas1_PropertyChanged(object sender, EventArgs e)
        {
            if(ucEmpresas1.K_Empresa>0)
            {
                CargaOficinas(ucEmpresas1.K_Empresa);
                cbxOficina.Enabled = true;
            }
            else
            {
                dtOficina = null;
                cbxOficina.DataSource = null;
                cbxOficina.Items.Clear();
                cbxOficina.AutoCompleteSource = AutoCompleteSource.None;
                cbxOficina.AutoCompleteMode = AutoCompleteMode.None;
                cbxOficina.Enabled = false;
            }

        }
        public override void BaseMetodoInicio()
        {
            ucEmpresas1.Focus();
            BaseBotonNuevo.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonExcel.Enabled = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonModificar.Visible = false;
            BaseBotonModificar.Enabled = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonGuardar.Enabled = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonBuscar.Enabled = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonCancelar.Enabled = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonAfectar.Visible = true;
            BaseBotonAfectar.Enabled = true;
            BaseBotonReporte.Visible = false;
            BaseBotonReporte.Enabled = false;
            cbxOficina.Enabled = false;

            txtClaveUsuario.Text = GlobalVar.K_Usuario.ToString();
            txtUsuario.Text = GlobalVar.D_Usuario;
            txtClaveActual.Text = GlobalVar.K_Empresa.ToString();
            txtActual.Text = GlobalVar.D_Empresa;


        }

        public override void BaseBotonAfectarClick()
        {
            if (ucEmpresas1.K_Empresa == 0)
            {
                MessageBox.Show("DEBE INDICAR LA EMPRESA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucEmpresas1.Focus();
                return;
            }
            if (Convert.ToInt32(cbxOficina.SelectedValue.ToString()) == 0)
            {
                MessageBox.Show("DEBE INDICAR LA OFICINA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxOficina.Focus();
                return;
            }

            res = 0;
            msg = string.Empty;

            res = sqlCatalogos.Gp_CambiaEmpresa(GlobalVar.K_Usuario, GlobalVar.K_Empresa,
                  ucEmpresas1.K_Empresa,Convert.ToInt32(cbxOficina.SelectedValue.ToString()), ref msg);

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
                Application.ExitThread();
                Application.Exit();

            }
        }

        private void CargaOficinas(Int32 K_Empresa)
        {
            dtOficina = null;
            cbxOficina.DataSource = null;
            cbxOficina.Items.Clear();
            cbxOficina.AutoCompleteSource = AutoCompleteSource.None;
            cbxOficina.AutoCompleteMode = AutoCompleteMode.None;

            dtOficina = sqlCatalogos.Sk_Oficina(K_Empresa);

            if (dtOficina != null)
            {
                //DataRow dr = dtOficina.NewRow();

                //dr["K_Oficina"] = 0;
                //dr["D_Oficina"] = "";

                //dtOficina.Rows.InsertAt(dr, 0);

                //dtOficina.AcceptChanges();

                int indice = -1;
                indice = 0;

                //dtAlmacen.Columns.Remove("K_Oficina");
                //dtAlmacen.Columns.Remove("D_Oficina");

                LlenaCombo(dtOficina, ref cbxOficina, "K_Oficina", "D_Oficina", indice);

                cbxOficina.SelectedIndex = 0;
            }
        }
    }
}
