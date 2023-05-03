using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace ProbeMedic.Controles
{
    public partial class SeleccionaArchivoXML : UserControl
    {
        public string PropiedadRuta { get; set; }
        public string[] PropiedadRutas { get; set; }
        public XmlDocument PropiedadXML { get; set; }
        public Comprobante PropiedadFactura { get; set; }
        public bool PropiedadEsRFCValido { get; set; }


        public event UserControlClickHandler LabelAquiClick;
        public delegate void UserControlClickHandler(object sender, EventArgs e);



        public SeleccionaArchivoXML()
        {
            InitializeComponent();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            if (this.LabelAquiClick != null)
            {
                AbrirXML();
                this.LabelAquiClick(sender, e);
            }

            
        }

        private void AbrirXML()
        {
            PropiedadRuta = null;
            PropiedadXML = null;
            PropiedadFactura = null;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Muestra Archivos XML";

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            openFileDialog1.DefaultExt = "xml";
            openFileDialog1.Filter = "Archivos XML (*.xml)|*.xml";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;
            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {              
                //Cuando se seleccionan varios archivos, la propiedad: PropiedadRuta sera la del primer archivo del arreglo.
                PropiedadRuta = openFileDialog1.FileName;

                //Entonces asignamos en un arreglo los archivos seleccionados.
                PropiedadRutas = openFileDialog1.FileNames;

                PropiedadEsRFCValido = false;

                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Comprobante));
                    XmlTextReader reader = new XmlTextReader(@PropiedadRuta);
                    Comprobante Factura = (Comprobante)serializer.Deserialize(reader);
                    PropiedadFactura = Factura;
                    PropiedadXML = new XmlDocument();
                    PropiedadXML.Load(@PropiedadRuta);
                    //if (dtEmpresa.Rows[0]["RFC"].ToString().Trim().ToUpper() == factura.Receptor.rfc.Trim().ToUpper())
                    //    PropiedadEsRFCValido = true;
                    //else
                    //    MessageBox.Show("EL R.F.C. RECEPTOR DEL ARCHIVO XML NO CORRESPONDE AL DE LA EMPRESA...!" , "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ARCHIVO XML NO CUENTA CON FORMATO CORRECTO CORRESPONDIENTE A UN CFDI...!\r\n" + ex.Message,"Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }

            }

        }
    }
}
