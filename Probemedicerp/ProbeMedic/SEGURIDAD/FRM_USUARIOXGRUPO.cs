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
    public partial class FRM_USUARIOXGRUPO : Forma_Asigna
    {
         SQLSeguridad sqlSeguridad  = new SQLSeguridad();
        //        int res = 0;
        string msg = string.Empty;
        DataTable dtBits = new DataTable();


        public FRM_USUARIOXGRUPO()
        {
            InitializeComponent();
        }


        public override void BaseMetodoInicio()
        {
            P_lblTituloArbol.Text = "GRUPOS";
            P_dtArbolBase = sqlSeguridad.Sk_UsuariosxGrupo();
            P_dtDisponiblesBase = sqlSeguridad.Sk_UsuariosDisponiblesxGrupo();
            P_dtSeleccionadosBase = sqlSeguridad.Sk_UsuariosSeleccionadosxGrupo();

            P_CampoValueMember = "K_Usuario";
            P_CampoDisplayMember = "D_Usuario";
        }



        public override void ProcesoAgregar()
        {
            base.ProcesoAgregar();

            sqlSeguridad.In_UsuarioxGrupo(Convert.ToInt32(P_ValorListBox), Convert.ToInt32(P_ClaveBase));
        }

        public override void ProcesoQuitar()
        {
            base.ProcesoQuitar();

            sqlSeguridad.Dl_UsuarioxGrupo(Convert.ToInt32(P_ValorListBox), Convert.ToInt32(P_ClaveBase));
        }

        private void Frm_UsuariosxGrupo_Load(object sender, EventArgs e)
        {
            //Se ejecutora primero el Load de FormaAsigna                            
            TreeView twArbol = (TreeView)base.Controls["pnlAbajo"].Controls["pnlIzquierda"].Controls["twEmpresas"];
            TreeNode[] arr = twArbol.Nodes.Find(P_ClaveBase, true);
            if (arr.Length > 0)
            {
                twArbol.SelectedNode = arr[0];
            }
        }


        public override void twEmpresas_AfterSelect(object sender, TreeViewEventArgs e)
        {
            base.twEmpresas_AfterSelect(sender, e);
        }


    }
}
