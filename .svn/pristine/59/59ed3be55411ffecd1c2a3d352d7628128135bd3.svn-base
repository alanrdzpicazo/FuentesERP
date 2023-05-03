using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;

namespace ProbeMedic.ADMINISTRACION
{
    public partial class Frm_CorreosClientes : FormaBase
    {
        Funciones fx = new Funciones();
        SQLAdministracion SQLADMINISTRACION = new SQLAdministracion();
        public Frm_CorreosClientes()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            BaseBotonCancelar.Visible = false;
            BaseBotonCancelar.Enabled = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonAfectar.Enabled = false;
            BaseBotonModificar.Visible = false;
            BaseBotonModificar.Enabled = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonGuardar.Enabled = false;
            BaseBotonReporte.Visible = false;
            BaseBotonReporte.Enabled = false;
            BaseBotonExcel.Visible = false;
            BaseBotonExcel.Enabled = false;         
            BaseBotonBuscar.Visible = true;
            BaseBotonBuscar.Enabled = true;
            BaseBotonCorreo.Visible = true;
            BaseBotonCorreo.Enabled = false;
            BaseBotonCorreo.Text = "Enviar Correos";

            this.grdDatos.AutoGenerateColumns = false;

            BaseBotonProceso1.Image = ((System.Drawing.Image)(imageList1.Images["BtnCancelar.Image.png"]));
            BaseBotonProceso1.Text = "Cancelar";
            BaseBotonProceso1.ToolTipText = "Cancelar Captura";
            BaseBotonProceso1.Visible = true;
            BaseBotonProceso1.Enabled = true;
        }
        public override void BaseBotonBuscarClick()
        {
            if(!CbxTodosClientes.Checked && TxtClaveCliente.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN CLIENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscaCliente.Focus();
                return;
            }
            if (!CbxTodoCanal.Checked && ucCanalDistribucionCliente1.K_Canal_Distribucion == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN CANAL DE DISTRIBUCIÓN...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucCanalDistribucionCliente1.Focus();
                return;
            }

            int K_ClienteInt = TxtClaveCliente.Text.Trim().Length>0 ?  Convert.ToInt32(TxtClaveCliente.Text.Trim()) : 0;
            int K_CanalDistribucionInt = this.ucCanalDistribucionCliente1.K_Canal_Distribucion > 0 ? ucCanalDistribucionCliente1.K_Canal_Distribucion : 0;

            DataTable DtDatos = SQLADMINISTRACION.Gp_Contactos_Correos(K_ClienteInt, K_CanalDistribucionInt);

            if((DtDatos!=null))
            {
                DtDatos.Columns.Add("Seleccionar", typeof(bool));
                foreach (DataRow Row in DtDatos.Rows)
                {
                    Row["Seleccionar"] = false;
                    DtDatos.AcceptChanges();
                }
 
                this.grdDatos.DataSource = DtDatos;
                this.grdDatos.EndEdit();
                BaseBotonCorreo.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se encontró información con los parametros capturados...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.grdDatos.DataSource = DtDatos;
                BaseBotonCorreo.Enabled = false;
            }

        }
        public override void BaseBotonCorreoClick()
        {
            if(TxtAsunto.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE CAPTURAR UN ASUNTO DE CORREO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtAsunto.Focus();
                return;
            }
            if (TxtCuerpoCorreo.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE CAPTURAR UN CUERPO DE CORREO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtCuerpoCorreo.Focus();
                return;
            }
            foreach (DataGridViewRow RowGrid in grdDatos.Rows)
            {
                grdDatos.EndEdit();
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)RowGrid.Cells[0];
                if (chk != null)
                    if ((bool)((chk.Value.ToString() == "") ? false : chk.Value) == true)
                    {
                        Cursor = Cursors.WaitCursor;
                        MtdEnviaCorreos(Convert.ToInt32(RowGrid.Cells["K_Cliente"].Value), RowGrid.Cells["D_Cliente"].Value.ToString(), RowGrid.Cells["Correo"].Value.ToString());
                        Cursor = Cursors.Default;
                    }
            }
        }

        private void MtdEnviaCorreos(Int32 K_Cliente, string D_Cliente, string Correo)
        {
            string Asunto = TxtAsunto.Text;
            string CorreoDe = System.Configuration.ConfigurationManager.AppSettings["CorreoDe"].ToString();
            string Cuerpo = fx.CuerpoCorreoHTML("Sr(a) "+TxtCuerpoCorreo.Text.Trim()+ " <p/>");

            string Recursos = "logo";
            string Archivos = Path.Combine(GlobalVar.rutaExe, "probemedic_login.png");

            //if (P_Archivo != null)
            //    P_Archivo = P_Archivo.ToString().Replace("Reporte", NombreReporteOC);
            string Adjuntos = "";// +"," + Archivos;
            string CorreosConCopia = "";

            if (fx.EnviaCorreo(CorreoDe, Correo, Asunto, "Probemedic Distribuciones S.A, Administración / Cuentas por Cobrar.", Cuerpo, Adjuntos, Archivos, Recursos, CorreosConCopia))
                Close();
        }

        //CANCELAR
        public override void BaseBotonProceso1Click()
        {
            BaseMetodoLimpiaControles();
            BaseMetodoInicio();
        }
        public override void BaseMetodoLimpiaControles()
        {
            this.TxtClaveCliente.Text = string.Empty;
            this.TxtCliente.Text = string.Empty;
            this.ucCanalDistribucionCliente1.K_Canal_Distribucion = 0;
            this.ucCanalDistribucionCliente1.txt_E_Canal_Distribucion.Text = string.Empty;
            CbxTodosClientes.Checked = false;
            CbxTodoCanal.Checked = false;
            CbxSeleccionarTodos.Checked = false;
            this.grdDatos.DataSource = null;
      
        }
        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            FILTROS.Frm_Filtra_Cliente filtra = new FILTROS.Frm_Filtra_Cliente(GlobalVar.K_Empresa);
            filtra.ShowDialog();
            this.TxtClaveCliente.Text = Convert.ToString(filtra.K_Cliente_Seleccionado);
            this.TxtCliente.Text = filtra.D_Cliente_Seleccionado;
        }
        private void CbxTodosClientes_CheckedChanged(object sender, EventArgs e)
        {
            if(CbxTodosClientes.Checked)
            {
                TxtClaveCliente.Enabled = false;
                TxtCliente.Enabled = false;

                TxtClaveCliente.Text = string.Empty;              
                TxtCliente.Text = string.Empty;

                btnBuscaCliente.Enabled = false;
             
               
            }
            else if(!CbxTodosClientes.Checked)
            {
                TxtClaveCliente.Enabled = true;
                TxtCliente.Enabled = true;
                btnBuscaCliente.Enabled = true;
            }
        }
        private void CbxTodoCanal_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxTodoCanal.Checked)
            {
                ucCanalDistribucionCliente1.Enabled = false;
                ucCanalDistribucionCliente1.K_Canal_Distribucion = 0;
                ucCanalDistribucionCliente1.txt_E_Canal_Distribucion.Text = string.Empty;
            }
            else if (!CbxTodosClientes.Checked)
            {
                ucCanalDistribucionCliente1.Enabled = true;

            }
        }
        private void CbxSeleccionarTodos_CheckedChanged(object sender, EventArgs e)
        {
            if(CbxSeleccionarTodos.Checked)
            {
                foreach (DataGridViewRow RowGrid in grdDatos.Rows)
                {
                    grdDatos.EndEdit();
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)RowGrid.Cells[0];
                    chk.Value = true;

                    //    if (chk != null)
                    //        if ((bool)((chk.Value.ToString() == "") ? false : chk.Value) == true)
                    //        {
                    //            RowGrid.Cells[0] = chk;
                    //        }
                    //}
                }
            }
            else if (!CbxSeleccionarTodos.Checked)
            {
                foreach (DataGridViewRow RowGrid in grdDatos.Rows)
                {
                    grdDatos.EndEdit();
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)RowGrid.Cells[0];
                    chk.Value = false;

                    //    if (chk != null)
                    //        if ((bool)((chk.Value.ToString() == "") ? false : chk.Value) == true)
                    //        {
                    //            RowGrid.Cells[0] = chk;
                    //        }
                    //}
                }
            }
        }

        private void grdDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.grdDatos.EndEdit();
        }

        private void TxtClaveCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
