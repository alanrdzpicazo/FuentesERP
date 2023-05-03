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

namespace ProbeMedic.INVENTARIOS
{
    public partial class Frm_Consulta_Solicitud : FormaBase
    {
        DataTable dtMotivos = new DataTable();
        SQLAlmacen sQLAlmacen = new SQLAlmacen();
        public int K_Solicitud { get; set; }
      

        public Frm_Consulta_Solicitud()
        {
            InitializeComponent();
            BaseBotonAfectar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonReporte.Visible = false;
        }

        private void Frm_Consulta_Solicitud_Load(object sender, EventArgs e)
        {

            LblSolicitud.Text = Convert.ToString(K_Solicitud);

            DataTable dtSolicitud = sQLAlmacen.Sk_Solicitud_Articulos(K_Solicitud);

            if ((dtSolicitud == null) || (dtSolicitud.Rows.Count == 0))
            {
                Close();

            }
            else
            {
                DataRow dr = dtSolicitud.Rows[0];
                LblMotivoSolicitud.Text = dr["D_Motivo_Transferencia"].ToString(); ;
                txtFecha.Text = dr["F_Solicitud"].ToString();
                txtOficinaEnvio.Text = dr["D_Oficina_Tranfiere"].ToString();
                txtAlmacen_Envio.Text = dr["D_Almacen_Transfiere"].ToString();
                txtUsuario_Aplico.Text = dr["D_Usuario_Aplico"].ToString();
                txtUsuarioRechazo.Text = dr["D_Usuario_Rechazo"].ToString();
                txtObservaciones.Text = dr["Observaciones"].ToString();
                txtOficinaRecepcion.Text = dr["D_Oficina_Solicita"].ToString();
                txtAlmacenRecepcion.Text = dr["D_Almacen_Solicita"].ToString();
                txtUsuarioSolicito.Text = dr["Usuario_Solicito"].ToString();
                txtMotivoRechazo.Text = dr["D_Motivo_Rechazo_Solicitud"].ToString();
                cbx_Aplicada.Checked = Convert.ToBoolean(dr["B_Aplicada"]);
                cbxRechazada.Checked = Convert.ToBoolean(dr["B_Rechazada"]);

                dtSolicitud.Columns.Remove("K_Solicitud_Transferencia");
                dtSolicitud.Columns.Remove("K_Oficina_Solicita");
                dtSolicitud.Columns.Remove("K_Almacen_Solicita");
                dtSolicitud.Columns.Remove("D_Oficina_Solicita"); 
                dtSolicitud.Columns.Remove("D_Almacen_Solicita");
                dtSolicitud.Columns.Remove("K_Oficina_Origen");
                dtSolicitud.Columns.Remove("D_Oficina_Tranfiere");
                dtSolicitud.Columns.Remove("K_Almacen_Origen");
                dtSolicitud.Columns.Remove("D_Almacen_Transfiere");
                dtSolicitud.Columns.Remove("K_Usuario_Solicito");
                dtSolicitud.Columns.Remove("Usuario_Solicito");
                dtSolicitud.Columns.Remove("K_Motivo_Transferencia");
                dtSolicitud.Columns.Remove("F_Solicitud");
                dtSolicitud.Columns.Remove("D_Motivo_Transferencia");
                dtSolicitud.Columns.Remove("B_Aplicada");
                dtSolicitud.Columns.Remove("K_Usuario_Aplico");
                dtSolicitud.Columns.Remove("D_Usuario_Aplico");
                dtSolicitud.Columns.Remove("F_Aplica");
                dtSolicitud.Columns.Remove("B_Rechazada");
                dtSolicitud.Columns.Remove("D_Motivo_Rechazo_Solicitud");
                dtSolicitud.Columns.Remove("D_Usuario_Rechazo");
                dtSolicitud.Columns.Remove("K_Usuario_Rechazo");
                dtSolicitud.Columns.Remove("F_Rechazada");
                dtSolicitud.Columns.Remove("Observaciones");
                dtSolicitud.Columns.Remove("K_Laboratorio");
 
                grdArticulos.DataSource = dtSolicitud;

            }

        }
    }
}
