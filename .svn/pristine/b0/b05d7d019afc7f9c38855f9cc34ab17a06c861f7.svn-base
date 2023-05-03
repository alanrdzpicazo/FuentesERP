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
using System.Collections;
using System.Reflection;

namespace ProbeMedic.SEGURIDAD
{
    public partial class FRM_MENUS : FormaCatalogo
    {
        DataTable dtMenus = new DataTable();
        DataTable dtMenusPadre = new DataTable();
        SQLSeguridad sqlSeguridad = new SQLSeguridad();
        ArrayList ListaFormas = new ArrayList();

        public FRM_MENUS()
        {
            InitializeComponent();
            BaseBotonProceso1.Click += new EventHandler(BaseBotonProceso1_Click);
        }

        void BaseBotonProceso1_Click(object sender, EventArgs e)
        {
            //Frm_MenusxGrupo frm = new Frm_MenusxGrupo();
            //frm.ShowDialog();
        }

        public override void BaseMetodoInicio()
        {
            txtFocus = txtMenu; //Asignar el textbox que inicia el focus
            pnlControles.Enabled = false; //NO borrar

            //BaseBotonProceso1.Visible = true;
            BaseBotonProceso1.ToolTipText = "Menús Asignados al Grupo";
            BaseBotonProceso1.Text = "Menús x Grupo";
            BaseBotonProceso1.Width = 130;


            dtMenus = sqlSeguridad.Gp_MenusOrdenado();
            BaseDtDatos = dtMenus; //Se ocupa para poder mandar a Excel
            CatalogoPropiedadCampoClave = "K_Menu";
            CatalogoPropiedadCampoDescripcion = "Opcion";

            //grdMenus.AutoGenerateColumns = false;
            //grdMenus.DataSource = dtMenus;
            //grdMenus.AllowUserToResizeColumns = true;
            //grdMenus.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            //grdMenus.Refresh();

            if (dtMenus != null)
            {
                if (dtMenus.Rows.Count > 0)
                {
                    dtMenusPadre = dtMenus.AsEnumerable().Where(p => p.Field<int>("Nivel") < 3).CopyToDataTable<DataRow>();
                    LlenaComboMenusPadre();
                }
            }


            //Leer Formularios
            Assembly SampleAssembly = Assembly.GetExecutingAssembly();
            Type[] ts = SampleAssembly.GetTypes();
            //             string text = "";
            for (int i = 0; i < ts.Length; i++)
            {
                if (ts[i].IsSubclassOf(typeof(Form)) || (ts[i]).GetType() == typeof(Form))
                {
                    //text += ts[i].FullName + "\r\n";
                    if (ts[i].FullName.Contains("Frm_"))
                    {
                        ListaFormas.Add(ts[i].FullName.Replace("PROBEMEDIC.", ""));

                    }

                }
            }
            cmbPantallas.DataSource = ListaFormas;


            //**AQUI SI HAY QUE LLENAR COMBOS
            //LlenaClasificaciones();


            base.BaseMetodoInicio();
        }

        public override void BaseMetodoLimpiaControles()
        {
            txtMenu.Text = string.Empty;
            txtPosicion.Text = string.Empty;
            txtClave.Text = string.Empty;

            txtClave.Text = string.Empty;
            pnlControles.Enabled = false; //NO Borrar
        }

        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();

            if (ren != null) //No encontró Sección
            {
                txtClave.Text = ren["K_Menu"].ToString();
                cmbMenusPadre.SelectedValue = Convert.ToInt32(ren["K_MenuPadre"]);
                txtMenu.Text = ren["DescripcionMenu"].ToString();
                txtPosicion.Text = ren["PosicionMenu"].ToString();
                cmbPantallas.Text = ren["FormularioAsociado"].ToString();
                cmbTipo.Text = ren["Tipo"].ToString();
            }
        }

        //TODO: Ver si podemos pasar este metodo a la clase
        public override void CatalogoHabilitaPanelControles(bool B_Habilita)
        {
            pnlControles.Enabled = B_Habilita;
        }

        private void LlenaComboMenusPadre()
        {
            if (dtMenusPadre != null)
            {
                if (dtMenusPadre.Rows.Count > 0)
                {
                    cmbMenusPadre.DataSource = dtMenusPadre;
                    cmbMenusPadre.ValueMember = "K_Menu";
                    cmbMenusPadre.DisplayMember = "Opcion";
                    AutoCompletar(ref cmbMenusPadre, dtMenusPadre, "Opcion");
                }
            }
        }


        public override void BaseBotonBorrarClick()
        {
            if (txtClave.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN REGISTRO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dlg = MessageBox.Show("SERA ELIMINADO EL REGISTRO CON VALOR:\n" + CatalogoPropiedadDescripcion + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                int res = 0;
                string msg = string.Empty;
                res = sqlSeguridad.Dl_Menus(Convert.ToInt32(CatalogoPropiedadId_Identity), ref msg);
                if (res == -1)
                {
                    BaseErrorResultado = true;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    BaseErrorResultado = false;
                    MessageBox.Show("MENU BORRADO CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BaseMetodoInicio();
                    BaseBotonCancelarClick();
                }
            }
        }

        public override void BaseBotonGuardarClick()
        {
            if (!BaseFuncionValidaciones())
                return;

            int res = 0;
            string msg = string.Empty;
            int KMenuPadre = 0;
            int Posicion = 0;
            if (cmbMenusPadre.SelectedValue != null)
            {
                KMenuPadre = Convert.ToInt32(cmbMenusPadre.SelectedValue);
            }
            if (txtPosicion.Text.Trim().Length > 0)
                Posicion = Convert.ToInt32(txtPosicion.Text);


            if (CatalogoPropiedadEsRegistroNuevo) // Nuevo
            {
                res = sqlSeguridad.Gp_CreaMenu(KMenuPadre, txtMenu.Text, Posicion, cmbPantallas.Text, cmbTipo.Text, ref msg);
                if (res == -1)
                {
                    BaseErrorResultado = true;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    BaseErrorResultado = false;
                    MessageBox.Show("MENU CREADO CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else //Existe. Update
            {
                int IdMenu = Convert.ToInt32(CatalogoPropiedadId_Identity);
                res = sqlSeguridad.Up_CreaMenu(IdMenu, KMenuPadre, txtMenu.Text, Posicion, cmbPantallas.Text, cmbTipo.Text, ref msg);


            }

            BaseMetodoInicio();
            BaseBotonCancelarClick();
        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (txtMenu.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR NOMBRE DE MENU..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbTipo.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR UN TIPO DE OPCION..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            BaseErrorResultado = false;
            return true;
        }

        private void txtPosicion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
