using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProbeMedic.CXP
{
    public partial class Frm_XML : FormaBase
    {
        public XDocument cfdi { get; set; }
        public Frm_XML()
        {
            BaseGridSinFormato = true;
            InitializeComponent();
        }

        private void Frm_XML_Load(object sender, EventArgs e)
        {
            grdAtributos.AutoGenerateColumns = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonReporte.Visible = false;

            try
            {
                var element = cfdi.Descendants();
                element.Attributes("sello").FirstOrDefault().Value = "";
                element.Attributes("selloCFD").FirstOrDefault().Value = "";
                element.Attributes("selloSAT").FirstOrDefault().Value = "";
                element.Attributes("certificado").FirstOrDefault().Value = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            var root = cfdi.Root;
            var x = GetNodes(new TreeNode(root.Name.LocalName), root).ToArray();

            tvXml.Nodes.AddRange(x);
            tvXml.ExpandAll();
            txtXML.Text = cfdi.ToString();
        }

        private IEnumerable<TreeNode> GetNodes(TreeNode node, XElement element)
        {
            return element.HasElements ?
                node.AddRange(from item in element.Elements()
                              let tree = new TreeNode(item.Name.LocalName)
                              from newNode in GetNodes(tree, item)
                              select newNode)
                              :
                new[] { node };
        }

        private void tvXml_AfterSelect(object sender, TreeViewEventArgs e)
        {
            grdAtributos.DataSource = null;
            DataTable table = new DataTable();
            table.Columns.Add("Atributo", typeof(string));
            table.Columns.Add("Valor", typeof(string));
            IEnumerable<XElement> nodos;
            XElement nodo;

            if (e.Node.Text == "Concepto")
            {
                var nodosConceptos = cfdi.Descendants().Where(p => p.Name.LocalName == "Conceptos").Elements();
                nodo = nodosConceptos.ElementAt(e.Node.Index);
            }
            else
            {
                nodos = cfdi.Descendants().Where(p => p.Name.LocalName == e.Node.Text);
                nodo = nodos.FirstOrDefault();
            }



            txtXML.Text = nodo.ToString();
            var atributos = nodo.Attributes().Where(p => p.IsNamespaceDeclaration == false);
            foreach(var atr in atributos)
            {
                DataRow ren = table.NewRow();
                ren["Atributo"] = atr.Name;
                ren["Valor"] = atr.Value;
                table.Rows.Add(ren);
            }

            grdAtributos.DataSource = table;
        }
    }
}
