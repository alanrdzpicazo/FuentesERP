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
    public partial class FRM_MENUXUSUARIOS : Forma_Asigna
    {
        SQLSeguridad sqlSeguridad = new SQLSeguridad();
        int res = 0;
        string msg = string.Empty;
        DataTable dtBits = new DataTable();


        public FRM_MENUXUSUARIOS()
        {
            InitializeComponent();
        }


        public override void BaseMetodoInicio()
        {
            P_lblTituloArbol.Text = "USUARIOS";
            dtBits = sqlSeguridad.Sk_MenusxUsuarioBits();
            P_dtArbolBase = sqlSeguridad.Sk_MenusxUsuario();
            P_dtDisponiblesBase = sqlSeguridad.Sk_MenusDisponiblesxUsuario();
            P_dtSeleccionadosBase = sqlSeguridad.Sk_MenusSeleccionadosxUsuario();

            P_SeleccionaTodosSeleccionados.Visible = false;
            P_lbSeleccionados.SelectionMode = SelectionMode.One;

            P_CampoValueMember = "K_Menu";
            P_CampoDisplayMember = "DescripcionMenu";
        }


        public override void BaseBotonGuardarClick()
        {
            res = sqlSeguridad.Up_MenusxUsuario(Convert.ToInt32(P_ClaveBase), Convert.ToInt32(P_lbSeleccionados.SelectedValue), true, true, true, true, true, true, true, ref msg);
            if (res == -1)
            {
                BaseErrorResultado = true;
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                BaseErrorResultado = false;
                MessageBox.Show("INFORMACION GUARDADA CORRECTAMENTE...!", "Avso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BaseMetodoRecarga();
                if ((BaseBotonGuardar.Enabled == false) && (BaseBotonGuardar.Visible == false))
                {
                    BaseBotonGuardar.Enabled = true;
                    BaseBotonGuardar.Visible = true;
                }
            }
        }
        private void HabilitaPuede()
        {
            BaseBotonGuardar.Visible = false;

            if (P_lbSeleccionados.SelectedValue != null)
            {
                LlenaBits();
                BaseBotonGuardar.Visible = true;
                ConfiguraPermisos();
                if ((BaseBotonGuardar.Enabled == false) && (BaseBotonGuardar.Visible == false))
                {
                    BaseBotonGuardar.Enabled = true;
                    BaseBotonGuardar.Visible = true;
                }
            }
        }



        public override void LlenaBits()
        {
            base.LlenaBits();
            DataTable dt = LINQTablaCrucesFiltra(dtBits, Convert.ToInt32(P_ClaveBase), Convert.ToInt32(P_lbSeleccionados.SelectedValue));
        }

        public override void ProcesoAgregar()
        {
            base.ProcesoAgregar();

            sqlSeguridad.In_MenusxUsuario(Convert.ToInt32(P_ClaveBase), Convert.ToInt32(P_ValorListBox));
        }

        public override void ProcesoQuitar()
        {
            base.ProcesoQuitar();

            sqlSeguridad.Dl_MenusxUsuario(Convert.ToInt32(P_ValorListBox), Convert.ToInt32(P_ClaveBase));
        }

        private void Frm_MenusxUsuario_Load(object sender, EventArgs e)
        {
            //Se ejecutora primero el Load de FormaAsigna                            
            TreeView twEmpresas = (TreeView)base.Controls["pnlAbajo"].Controls["pnlIzquierda"].Controls["twEmpresas"];
            TreeNode[] arr = twEmpresas.Nodes.Find(P_ClaveBase, true);
            if (arr.Length > 0)
            {
                twEmpresas.SelectedNode = arr[0];
            }
        }

        public override void AsignaMetodoSeleccionadosCambia()
        {
            String Tipo = string.Empty;
            DataTable dt = LINQTablaFiltra(P_dtArbolBase, P_lbSeleccionados.Text, "Nombre2");
            if (dt.Rows.Count > 0)
                Tipo = dt.Rows[0]["Tipo"].ToString();

            BaseBotonGuardar.Visible = false;
            BaseMetodoLimpiaControles();

            if (Tipo == "PANTALLA")
            {
                LlenaBits();
                BaseBotonGuardar.Enabled = true;
                BaseBotonGuardar.Visible = true;
            }
        }

        public override void twEmpresas_AfterSelect(object sender, TreeViewEventArgs e)
        {
            base.twEmpresas_AfterSelect(sender, e);
            HabilitaPuede();
        }
    }
}
