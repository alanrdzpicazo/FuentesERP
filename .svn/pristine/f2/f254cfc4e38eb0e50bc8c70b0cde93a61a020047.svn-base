using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbeMedic
{
    public partial class Forma_Asigna : FormaBase
    {
        #region "Propiedades Controles"
        public Button AsignaAgregarTodos
        {
            get { return this.btnAgregar; }
        }
        public Button AsignaQuitaTodos
        {
            get { return this.btnQuitarTodo; }
        }
        public Button AsignaAgregar
        {
            get { return this.btnAgregarTodo; }
        }
        public Button AsignaQuitar
        {
            get { return this.btnQuitar; }
        }
        public TreeView twArbolNodosBase
        {
            get { return this.twEmpresas; }
        }
        public Panel AsignaPanelIzquierda
        {
            get { return this.pnlIzquierda; }
        }
        public Panel AsignaPanelDisponibles
        {
            get { return this.pnlDisponibles; }
        }
        public Panel AsignaPanelSeleccionados
        {
            get { return this.pnlSeleccionados; }
        }
        public Panel AsignaPanelDerecha
        {
            get { return this.pnlDerecha; }
        }
        public Panel AsignaPanelAbajo
        {
            get { return this.pnlAbajo; }
        }
        #endregion

        public string CatalogoPropiedadCampoDescripcion { get; set; }
        public bool AsignaPropiedadConModificacion { get; set; }
        public string AsignaPropiedadDescripcion { get; set; }
        public bool AsignaPropiedadDetenerCaptura { get; set; }
        //public string CatalogoPropiedadCampoClave { get; set; }
        //public bool CatalogoPropiedadMuestraColumnaClave { get; set; }
        //public bool CatalogoPropiedadEsRegistroNuevo { get; set; }
        //public object CatalogoPropiedadId_Identity { get; set; }
        //public string CatalogoPropiedadDescripcion { get; set; }

        public ListBox P_lbDisponibles { get { return this.lbDisponibles; } }
        public ListBox P_lbSeleccionados { get { return this.lbSeleccionados; } }
        public Label P_lblTituloArbol { get { return this.lblTituloArbol; } }
        public CheckBox P_SeleccionaTodosSeleccionados { get { return this.cbxTodosSeleccionados; } }
        public CheckBox P_SeleccionaTodosDisponibles { get { return this.cbxTodosDisponibles; } }

        public int AsignaPropiedadNodosHijos { get; set; }
        public string P_ClaveBase { get; set; }
        public string P_CampoValueMember { get; set; }
        public string P_CampoDisplayMember { get; set; }
        public DataTable P_dtArbolBase { get; set; }
        public DataTable P_dtDisponiblesBase { get; set; }
        public DataTable P_dtSeleccionadosBase { get; set; }
        public string P_ValorListBox { get; set; }
        public bool P_QuitandoTodo { get; set; }

        string gsTitulo = string.Empty;

        public Forma_Asigna()
        {
            InitializeComponent();

            this.twEmpresas.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right);

            twEmpresas.AfterSelect += new TreeViewEventHandler(twEmpresas_AfterSelect);
        }



        public virtual void LlenaBits()
        {
            pnlAbajo.Dock = DockStyle.Left;
            pnlDerecha.Dock = DockStyle.Left;
            pnlDisponibles.Width = 345;
            pnlSeleccionados.Width = 366;
        }

        private void BuscaRenglonDisponibles(string valor)
        {
            //La condición que la tabla la columna cero sea el campo llave
            //BasedtDatosConFiltro = LINQTablaFiltra(P_dtDisponiblesBase, valor, P_CampoDisplayMember, P_dtDisponiblesBase.Columns[0].ColumnName, P_ClaveBase);

            DataView view = new System.Data.DataView(P_dtDisponiblesBase);
            DataTable selected =
                    view.ToTable("Selected", false, P_CampoValueMember, P_CampoDisplayMember);

            //BasedtDatosConFiltro = LINQTablaFiltraMultiple(P_dtDisponiblesBase, valor, DevuelveCamposBusqueda(P_dtDisponiblesBase));            
            BasedtDatosConFiltro = LINQTablaFiltra(selected, valor, P_CampoDisplayMember);
            if ((BasedtDatosConFiltro != null) && (BasedtDatosConFiltro.Rows.Count > 0))
            {
                lbDisponibles.DataSource = BasedtDatosConFiltro;
                lbDisponibles.ValueMember = P_CampoValueMember;
                lbDisponibles.DisplayMember = P_CampoDisplayMember;
            }
        }

        private void BuscaRenglonSeleccionados(string valor)
        {
            //La condición que la tabla la columna cero sea el campo llave
            //BasedtDatosConFiltro = LINQTablaFiltra(P_dtSeleccionadosBase, valor, P_CampoDisplayMember, P_dtSeleccionadosBase.Columns[0].ColumnName, P_ClaveBase);

            DataView view = new System.Data.DataView(P_dtSeleccionadosBase);
            DataTable selected =
                    view.ToTable("Selected", false, P_CampoValueMember, P_CampoDisplayMember);

            BasedtDatosConFiltro = LINQTablaFiltra(selected, valor, P_CampoDisplayMember);
            if ((BasedtDatosConFiltro != null) && (BasedtDatosConFiltro.Rows.Count > 0))
            {
                lbSeleccionados.DataSource = BasedtDatosConFiltro;
                lbSeleccionados.ValueMember = P_CampoValueMember;
                lbSeleccionados.DisplayMember = P_CampoDisplayMember;
            }
        }


        public DataTable PreparaTabla(DataTable dtPrepara)
        {
            string Clave = string.Empty;
            string Descripcion = string.Empty;
            Clave = P_CampoValueMember;
            Descripcion = P_CampoDisplayMember;

            DataTable dtDatos = new DataTable();
            dtDatos.Columns.Add(Clave, (typeof(string)));
            dtDatos.Columns.Add(Descripcion, (typeof(string)));

            if (dtPrepara != null)
            {
                foreach (DataRow ren in dtPrepara.Rows)
                {
                    DataRow row = dtDatos.NewRow();
                    row[Clave] = ren[Clave];
                    row[Descripcion] = ren[Descripcion];
                    dtDatos.Rows.Add(row);
                }
            }

            return dtDatos;
        }

        public virtual void twEmpresas_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string Tipo = string.Empty;
            cbxTodosDisponibles.Checked = false;
            cbxTodosSeleccionados.Checked = false;
            if (e.Action == TreeViewAction.ByMouse || e.Action == TreeViewAction.Unknown)
            {
                P_ClaveBase = e.Node.Name;

                AsignaPropiedadNodosHijos = e.Node.GetNodeCount(true);

                string des = e.Node.FullPath;
                if (des.Contains(@"\"))
                {
                    int pos = des.IndexOf(@"\");
                    des = des.Substring(0, pos);
                }
                AsignaPropiedadDescripcion = des;
                FiltraDisponibles(P_ClaveBase, e.Node.FullPath);
                FiltraSeleccionados(P_ClaveBase);

                DataTable dt = LINQTablaFiltra(P_dtArbolBase, e.Node.Text, "Nombre2");
                if (dt.Rows.Count > 0)
                    Tipo = dt.Rows[0]["Tipo"].ToString();

                lbSeleccionados.ClearSelected();
                BaseMetodoLimpiaControles();
                if (Tipo == "PANTALLA")
                {
                    int PosNodo = lbSeleccionados.FindString(e.Node.Text);
                    if (PosNodo >= 0)
                    {
                        lbSeleccionados.SelectedIndex = PosNodo;
                    }
                }

            }
        }


        private void FiltraDisponibles(string Clave, string Descripcion = "")
        {
            lbDisponibles.DataSource = null;
            /*if (Descripcion.Trim().Length == 0)
                this.Text = gsTitulo + "  ( " + Clave + " )";
            else
                this.Text = gsTitulo + "  ( " + Descripcion + " )";
            */

            if (Descripcion.Trim().Length > 0)
                this.Text = gsTitulo + "  ( " + Descripcion + " )";


            if (P_dtDisponiblesBase != null)
            {
                if (P_dtDisponiblesBase.Rows.Count > 0)
                {
                    DataTable dtDisponibles = new DataTable();
                    DataRow ren = P_dtDisponiblesBase.AsEnumerable().Where(p => p.Field<string>(0) == Clave).FirstOrDefault();
                    if (ren != null)
                    {
                        dtDisponibles = P_dtDisponiblesBase.AsEnumerable().Where(p => p.Field<string>(0) == Clave).CopyToDataTable<DataRow>();
                    }
                    if (dtDisponibles != null)
                    {
                        if (dtDisponibles.Rows.Count > 0)
                        {
                            lbDisponibles.DataSource = dtDisponibles;
                            lbDisponibles.ValueMember = P_CampoValueMember;
                            lbDisponibles.DisplayMember = P_CampoDisplayMember;
                        }
                    }
                }
            }
        }

        private void FiltraSeleccionados(string Clave)
        {
            lbSeleccionados.DataSource = null;
            if (P_dtSeleccionadosBase != null)
            {
                if (P_dtSeleccionadosBase.Rows.Count > 0)
                {
                    DataTable dtSeleccionados = new DataTable();
                    //Valida que haya registros, porque marca error el copytable si no genera registros la condición
                    DataRow ren = P_dtSeleccionadosBase.AsEnumerable().Where(p => p.Field<string>(0) == Clave).FirstOrDefault();
                    if (ren != null)
                    {
                        dtSeleccionados = P_dtSeleccionadosBase.AsEnumerable().Where(p => p.Field<string>(0) == Clave).CopyToDataTable<DataRow>();
                    }

                    if (dtSeleccionados != null)
                    {
                        if (dtSeleccionados.Rows.Count > 0)
                        {
                            lbSeleccionados.DataSource = dtSeleccionados;
                            lbSeleccionados.ValueMember = P_CampoValueMember;
                            lbSeleccionados.DisplayMember = P_CampoDisplayMember;
                        }
                    }
                }
            }
        }

        private void CreaArbol()
        {
            TreeNode node;
            DataRow ren;
            string Clave1 = string.Empty;
            string Nombre1 = string.Empty;
            string Clave2 = string.Empty;
            string Nombre2 = string.Empty;
            twArbolNodosBase.Nodes.Clear();
            if (P_dtArbolBase != null)
            {
                if (P_dtArbolBase.Rows.Count > 0)
                {
                    DataTable dtNivel1 = new DataTable();
                    ren = P_dtArbolBase.AsEnumerable().Where(p => p.Field<int>("Nivel") == 1).FirstOrDefault();
                    if (ren != null)
                    {
                        dtNivel1 = P_dtArbolBase.AsEnumerable().Where(p => p.Field<int>("Nivel") == 1).CopyToDataTable<DataRow>();
                        if (dtNivel1.Rows.Count > 0)
                        {
                            foreach (DataRow renNivel1 in dtNivel1.Rows)
                            {
                                Clave1 = renNivel1["Clave1"].ToString();
                                Nombre1 = renNivel1["Nombre1"].ToString();

                                //Agregar Nodo Nivel1                                
                                node = twArbolNodosBase.Nodes.Add(Clave1, Nombre1, 0, 1);

                                DataTable dtNivel2 = new DataTable();
                                ren = P_dtArbolBase.AsEnumerable().Where(p => p.Field<int>("Nivel") == 2 && p.Field<string>("Clave1") == Clave1).FirstOrDefault();
                                if (ren != null)
                                {
                                    dtNivel2 = P_dtArbolBase.AsEnumerable().Where(p => p.Field<int>("Nivel") == 2 && p.Field<string>("Clave1") == Clave1).CopyToDataTable<DataRow>();

                                    if (dtNivel2.Rows.Count > 0)
                                    {
                                        foreach (DataRow renNivel2 in dtNivel2.Rows)
                                        {
                                            //Agregar Nodos Nivel2
                                            Clave2 = Clave1;//renNivel2["Clave2"].ToString();
                                            Nombre2 = renNivel2["Nombre2"].ToString();

                                            node.Nodes.Add(Clave2, Nombre2, 2, 2);
                                        }
                                    }
                                }

                            }
                        }
                    }
                }
            }
        }


        private void CreaArbolFiltrado(DataTable dtArbol)
        {
            TreeNode node;
            DataRow ren;
            string Clave1 = string.Empty;
            string Nombre1 = string.Empty;
            string Clave2 = string.Empty;
            string Nombre2 = string.Empty;
            twArbolNodosBase.Nodes.Clear();
            if (dtArbol != null)
            {
                if (dtArbol.Rows.Count > 0)
                {
                    DataTable dtNivel1 = new DataTable();
                    ren = dtArbol.AsEnumerable().Where(p => p.Field<int>("Nivel") == 1).FirstOrDefault();
                    if (ren != null)
                    {
                        dtNivel1 = dtArbol.AsEnumerable().Where(p => p.Field<int>("Nivel") == 1).CopyToDataTable<DataRow>();
                        if (dtNivel1.Rows.Count > 0)
                        {
                            foreach (DataRow renNivel1 in dtNivel1.Rows)
                            {
                                Clave1 = renNivel1["Clave1"].ToString();
                                Nombre1 = renNivel1["Nombre1"].ToString();

                                //Agregar Nodo Nivel1                                
                                node = twArbolNodosBase.Nodes.Add(Clave1, Nombre1, 0, 1);

                                DataTable dtNivel2 = new DataTable();
                                ren = dtArbol.AsEnumerable().Where(p => p.Field<int>("Nivel") == 2 && p.Field<string>("Clave1") == Clave1).FirstOrDefault();
                                if (ren != null)
                                {
                                    dtNivel2 = dtArbol.AsEnumerable().Where(p => p.Field<int>("Nivel") == 2 && p.Field<string>("Clave1") == Clave1).CopyToDataTable<DataRow>();

                                    if (dtNivel2.Rows.Count > 0)
                                    {
                                        foreach (DataRow renNivel2 in dtNivel2.Rows)
                                        {
                                            //Agregar Nodos Nivel2
                                            Clave2 = Clave1;//renNivel2["Clave2"].ToString();
                                            Nombre2 = renNivel2["Nombre2"].ToString();

                                            node.Nodes.Add(Clave2, Nombre2, 2, 2);
                                        }
                                    }
                                }

                            }
                        }
                    }
                }
            }
        }


        public override void BaseMetodoRecarga()
        {
            BaseMetodoInicio();
            FiltraDisponibles(P_ClaveBase);
            FiltraSeleccionados(P_ClaveBase);
            CreaArbol();
        }

        public virtual void BaseMetodoFiltraDisponibles()
        {
            FiltraDisponibles(P_ClaveBase);
        }

        public virtual void BaseMetodoFiltraSeleccionados()
        {
            FiltraSeleccionados(P_ClaveBase);
        }

        public virtual void ProcesoAgregar()
        {
            if (P_lbDisponibles.SelectedValue == null)
            {
                MessageBox.Show("DEBE SELECCIONAR UN ELEMENTO DE LA LISTA DISPONIBLES PARA AGREGAR", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }


        public virtual void AsignaMetodoSeleccionadosCambia()
        {

        }

        public virtual void AsignaMetodoDisponiblesCambia()
        {

        }

        private void SeleccionaTodos(ref ListBox lb, bool B_Seleccionados)
        {
            for (int i = 0; i < lb.Items.Count; i++)
            {
                lb.SetSelected(i, B_Seleccionados);
            }

        }

        private void Forma_Asigna_Load(object sender, EventArgs e)
        {
            BaseEtiquetaEstatus.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonReporte.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonCorreo.Visible = false;

            if (!AsignaPropiedadConModificacion)
                BaseBotonModificar.Visible = false;
            else
            {
                if (P_dtArbolBase != null)
                {
                    if (P_dtArbolBase.Rows.Count > 0)
                        BaseBotonModificar.Visible = true;
                    else
                        BaseBotonModificar.Visible = false;
                }
                else
                    BaseBotonModificar.Visible = false;
            }

            BaseBotonCancelar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonBuscar.Visible = false;


            pnlAbajo.Dock = DockStyle.Fill;
            pnlDerecha.Dock = DockStyle.Fill;
            pnlDisponibles.Width = pnlDisponibles.Width + 110;
            pnlSeleccionados.Width = pnlSeleccionados.Width + 110;

            gsTitulo = this.Text;
            CreaArbol();

            //Cargamos la primera opción
            if (P_dtArbolBase != null)
            {
                if (P_dtArbolBase.Rows.Count > 0)
                {
                    P_ClaveBase = P_dtArbolBase.Rows[0]["Clave1"].ToString();
                    FiltraDisponibles(P_ClaveBase, P_dtArbolBase.Rows[0]["Nombre1"].ToString());
                    FiltraSeleccionados(P_ClaveBase);
                }
            }
        }


        public virtual void ProcesoQuitar()
        {
            if (!P_QuitandoTodo)
            {
                if (P_lbSeleccionados.SelectedValue == null)
                {
                    MessageBox.Show("DEBE SELECCIONAR UN ELEMENTO DE LA LISTA SELECCIONADOS PARA QUITAR", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                P_ValorListBox = P_lbSeleccionados.SelectedValue.ToString();
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //ProcesoAgregar();
            txtBuscaSeleccionados.Text = string.Empty;
            btnAgregarTodo_Click(null, null);
            BaseMetodoRecarga();
            txtBuscaDisponibles.Text = string.Empty;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            txtBuscaSeleccionados.Text = string.Empty;
            P_QuitandoTodo = false;
            ProcesoQuitar();
            BaseMetodoRecarga();
            txtBuscaSeleccionados.Text = string.Empty;
        }

        private void btnAgregarTodo_Click(object sender, EventArgs e)
        {
            /*foreach (DataRowView drv in lbDisponibles.SelectedItems)
            {                
                P_ValorArbol = drv[P_CampoValueMember].ToString();
            } */


            //var items = new System.Collections.ArrayList(lbDisponibles.SelectedItems);
            //foreach (var item in items) 
            //foreach (var item in lbDisponibles.SelectedItems)
            //for (int x = 0; x <= lbDisponibles.SelectedItems.Count; x++)
            foreach (DataRowView drv in lbDisponibles.SelectedItems)
            {

                if (!AsignaPropiedadDetenerCaptura)
                {
                    //SeleccionaTodos(ref lbDisponibles, false);
                    //lbDisponibles.SelectedItem = item;
                    //P_ValorArbol = lbDisponibles.SelectedValue.ToString();
                    P_ValorListBox = drv[P_CampoValueMember].ToString();


                    ProcesoAgregar();
                    //quitar elemento del listbox
                    //lbDisponibles.Items.Remove(item);
                }
                else
                {
                    AsignaPropiedadDetenerCaptura = false;
                    break;
                }
            }
            lbDisponibles.SelectedItems.Clear();
            BaseMetodoRecarga();
            txtBuscaDisponibles.Text = string.Empty;
        }

        private void btnQuitarTodo_Click(object sender, EventArgs e)
        {
            P_QuitandoTodo = true;
            if (P_lbSeleccionados.SelectionMode == SelectionMode.One)
            {
                foreach (DataRowView drv in lbSeleccionados.Items)
                {
                    P_ValorListBox = drv[P_CampoValueMember].ToString();
                    ProcesoQuitar();
                }
            }
            else
            {
                //var items = new System.Collections.ArrayList(lbSeleccionados.SelectedItems);
                //foreach (var item in items)
                foreach (DataRowView drv in lbSeleccionados.SelectedItems)
                {
                    //lbSeleccionados.SelectedIndex = lbSeleccionados.Items.IndexOf(item);
                    P_ValorListBox = drv[P_CampoValueMember].ToString();
                    ProcesoQuitar();
                }
            }

            txtBuscaSeleccionados.Text = string.Empty;
            BaseMetodoRecarga();
            txtBuscaSeleccionados.Text = string.Empty;
        }

        private void lbSeleccionados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTodosDisponibles.Checked)
            {
                ListBox lb = (ListBox)sender;
                if (lb.Items.Count != lb.SelectedItems.Count)
                    cbxTodosDisponibles.Checked = false;
            }

            AsignaMetodoDisponiblesCambia();
        }

        private void lblSeleccionados_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscaDisponibles_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscaDisponibles.Text.Trim().Length > 0)
                BuscaRenglonDisponibles(txtBuscaDisponibles.Text);
            else
                FiltraDisponibles(P_ClaveBase);
        }

        private void cbxTodosDisponibles_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTodosDisponibles.Checked)
            {
                SeleccionaTodos(ref lbDisponibles, true);
                if (lbDisponibles.Items.Count == lbDisponibles.SelectedItems.Count)
                    cbxTodosDisponibles.Checked = true;
            }
            else
            {
                if (lbDisponibles.Items.Count == lbDisponibles.SelectedItems.Count)
                    SeleccionaTodos(ref lbDisponibles, false);
            }
        }

        private void cbxTodosSeleccionados_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscaOpciones_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscaOpciones.Text.Trim().Length > 0)
            {
                DataView view = new System.Data.DataView(P_dtArbolBase);
                DataTable selected =
                        view.ToTable("Selected", false, "Clave1", "Nombre1", "Clave2", "Nombre2", "Nivel");

                BasedtDatosConFiltro = LINQTablaFiltra(selected, txtBuscaOpciones.Text, "Nombre1");
                if ((BasedtDatosConFiltro != null) && (BasedtDatosConFiltro.Rows.Count > 0))
                {
                    CreaArbolFiltrado(BasedtDatosConFiltro);
                }
            }
            else
                CreaArbol();
        }

     
    }
}
