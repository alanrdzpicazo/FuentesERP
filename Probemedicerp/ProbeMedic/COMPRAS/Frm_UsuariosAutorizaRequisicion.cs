using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;

namespace ProbeMedic.SEGURIDAD
{
    public partial class Frm_UsuariosAutorizaRequisicion : Forma_Asigna
    {        
        SQLSeguridad sqlSeguridad = new SQLSeguridad();
        SQLCompras sqlCompras = new SQLCompras();

//        int res = 0;
        string msg = string.Empty;
        DataTable dtBits = new DataTable();


        public Frm_UsuariosAutorizaRequisicion()
        {
            InitializeComponent();
        }


        public override void BaseMetodoInicio()
        {            
            P_lblTituloArbol.Text = "USUARIO";
            P_dtArbolBase = sqlCompras.Sk_SeleccionadosxUsuario();
            P_dtDisponiblesBase = sqlCompras.Sk_UsuariosxAutorizaArticulos();
            P_dtSeleccionadosBase = sqlCompras.Sk_UsuariosxAutorizaArticulos();

            P_CampoValueMember = "K_Usuario";
            P_CampoDisplayMember = "D_Usuario";
        }


        
        public override void ProcesoAgregar()
        {
            base.ProcesoAgregar();

          //  sqlCompras.In_Usuario_AutorizaRequisicion(Convert.ToInt32(P_ClaveBase), ref msg);
        }

        public override void ProcesoQuitar()
        {
            base.ProcesoQuitar();

            sqlCompras.Dl_Usuario_AutorizaRequisicion( Convert.ToInt32(P_ClaveBase), ref msg);
        }

        private void Frm_UsuariosAutorizaRequisicion_Load(object sender, EventArgs e)
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
