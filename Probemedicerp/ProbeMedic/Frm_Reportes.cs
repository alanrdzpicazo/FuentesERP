using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.IO;
using ProbeMedic;

namespace ProbeMedic
{
    public partial class Frm_Reportes : Forma
    {
        public DataTable P_TablaCorreo { get; set; }
        public string P_Titulo { get; set; }
        public ReportDocument P_ReporteRPT { get; set; }
        public string SerieFolio { get; set; }
        public string ArchivoPDF { get; set; }

        public Frm_Reportes()
        {
            InitializeComponent();
        }

        private void Frm_Reportes_Load(object sender, EventArgs e)
        {
            if (P_Titulo != null)
            {
                if (P_Titulo.Trim().Length > 0)
                {
                    this.Text = P_Titulo;
                }
            }
            try
            {
                crystalReportViewer1.ReportSource = P_ReporteRPT;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en Carga de Reporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCorreo_Click(object sender, EventArgs e)
        {
            switch (P_ReporteRPT.ToString())
            {
                case "ProbeMedic.REPORTES.RPT_Orden_Compra":
                    if (P_TablaCorreo != null)
                    {
                        String ArchivoPDF = Path.Combine(GlobalVar.rutaExe, "Orden de Compra.pdf");
                        P_ReporteRPT.ExportToDisk(ExportFormatType.PortableDocFormat, ArchivoPDF);

                        COMPRAS.Frm_CorreoOrdenCompra frmOC = new COMPRAS.Frm_CorreoOrdenCompra();
                        frmOC.P_NombreProveedor = P_TablaCorreo.Rows[0]["D_Proveedor"].ToString();
                        frmOC.P_NombreContacto = P_TablaCorreo.Rows[0]["D_Contacto"].ToString();
                        frmOC.P_CorreoContacto = P_TablaCorreo.Rows[0]["Correo_Contacto"].ToString();
                        frmOC.P_NombreAutoriza = P_TablaCorreo.Rows[0]["D_Usuario"].ToString();
                        frmOC.P_CorreoAutoriza = P_TablaCorreo.Rows[0]["CorreoUsuario"].ToString();
                        frmOC.P_NoOrden = Convert.ToInt32(P_TablaCorreo.Rows[0]["K_Orden_Compra"]);
                        frmOC.P_Archivo = ArchivoPDF;
                        frmOC.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("EL PROVEEDOR NO TIENE CONTACTOS ASIGNADOS. FAVOR DE CAPTURAR LOS CONTACTOS EN EL CATALOGO DE PROVEEDORES. ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);                    
                    }
                    break;
                default:
                    break;


            }
        }
    }
}
