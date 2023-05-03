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

namespace ProbeMedic.CATALOGOS.ENFERMERIA
{

    public partial class FRM_SERVICIOS_CONTRATADOS_ENFERMERIA : FormaBase
    {
        int filaSeleccionada;
        int res;

        SQLVentas sqlventas = new SQLVentas();   
        SQLPrecios sqlPrecios = new SQLPrecios();
        DataTable datos = new DataTable();
        DateTime FechaInicial = DateTime.Today;
        DateTime FechaFinal = DateTime.Today;

        Funciones fx = new Funciones();

        int Servicio, K_Enfermera, K_Motivo;
        string msg = string.Empty;

        public FRM_SERVICIOS_CONTRATADOS_ENFERMERIA()
        {
            InitializeComponent();       
        }

        public override void BaseMetodoInicio()
        {
            BaseMetodoRecarga();
            BaseBotonModificar.Visible = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonReporte.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonGuardar.Enabled = false;
            BaseBotonBuscar.Visible = true;
            BaseBotonBuscar.Enabled = true;
            BaseBotonExcel.Visible = false;
            BaseBotonExcel.Enabled = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonProceso1.Visible = true;
            BaseBotonReporte.Visible = false;
            BaseBotonBorrar.Visible = false;

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaBase));
            BaseBotonProceso1.Image = ((System.Drawing.Image)(imageList1.Images["application_view_detail.png"]));
            BaseBotonProceso1.Text = "Detalle";

            //PROPIEDADES DEL GRID
            grdDatos.MultiSelect = false;
            grdDatos.ReadOnly = true;
            grdDatos.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            grdDatos.BackgroundColor = Color.White;
            grdDatos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 70, 209);
            grdDatos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grdDatos.EnableHeadersVisualStyles = false;
            txtMotivoCanc.Text = string.Empty;
            rdbNoRealizado.Checked = true;

            int var_mesActual = DateTime.Now.Month; // obtengo el mes actual
            int var_anio = DateTime.Now.Year; // obtengo el año actual 
            int var_totalDiasMes = DateTime.DaysInMonth(var_anio,var_mesActual);
            dtpInicial.Value = Convert.ToDateTime(var_mesActual + "/01" + "/" + var_anio);// pongo el 1 porque siempre es el primer día obvio
            dtpFinal.Value = Convert.ToDateTime(var_mesActual + "/"+var_totalDiasMes + "/" + var_anio); //resto un día al mes y con esto obtengo el ultimo día
        }

        public override void BaseBotonBuscarClick()
        {
            BaseBotonExcel.Visible = false;
            BaseBotonExcel.Enabled = false;

            DateTime FechaInicial = DateTime.Today;
            FechaInicial = dtpInicial.Value;
            DateTime FechaFinal = DateTime.Today;
            FechaFinal = dtpFinal.Value;

            bool B_Realizado = false;
            if (rdbRealizad.Checked == true)
            {
                B_Realizado = true;
            }
            else
            {
                B_Realizado = false;
            }

            LlenarGrid(B_Realizado,FechaInicial,FechaFinal,this.Rdb_Pagado.Checked,this.Rdb_Cancelado.Checked);
        }

        public void LlenarGrid(bool B_Realizado,DateTime F_Inicial, DateTime F_Final,bool B_Pagado, bool B_Cancelado)
        {
         
            datos = sqlventas.SK_Servicios_Enfermeria(B_Realizado,F_Inicial, F_Final,ucClientes1.K_Cliente,B_Pagado,B_Cancelado);
            if (datos == null)
            {
                MessageBox.Show("NO SE ENCONTRO INFORMACION...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpia();
                return;
            }
            else { 
                grdDatos.DataSource = datos;
                OrdenarColumnasGrid();
                filaSeleccionada = 0;
                BaseBotonExcel.Visible = true;
                BaseBotonExcel.Enabled = true;            
            }
            
        }

        private void limpia()
        {
            if (grdDatos.RowCount > 0)
            {
                DataTable dt = (DataTable)grdDatos.DataSource;
                dt.Clear();
            }
            txtMotivoCanc.Text = string.Empty;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            FRM_GENERAR_sERVICIOS_ENFERMERIA genera = new FRM_GENERAR_sERVICIOS_ENFERMERIA();
            genera.FechaInicial = Convert.ToDateTime(dtpInicial.Value.ToString("yyyy/MM/dd"));
            genera.FechaFinal = Convert.ToDateTime(dtpFinal.Value.ToString("yyyy/MM/dd"));
            genera.ShowDialog();
            
            LlenarGrid(false, genera.FechaInicial, genera.FechaFinal,false,false);
        }

        private void BtnAsignaEnf_Click(object sender, EventArgs e)
        {
            if (grdDatos.RowCount > 0)
            {
                if (Convert.ToBoolean(grdDatos.CurrentRow.Cells["B_Cancelado"].Value) == true)
                {
                    MessageBox.Show("EL SERVICIO ESTA CANCELADO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (Convert.ToBoolean(grdDatos.CurrentRow.Cells["B_Pagado"].Value) == false)
                {
                    MessageBox.Show("EL SERVICIO NO ESTA PAGADO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    if ((grdDatos.CurrentRow.Cells["K_Empleado"].Value == null) || (grdDatos.CurrentRow.Cells["K_Empleado"].Value == DBNull.Value))

                    {
                        Servicio = int.Parse(grdDatos.CurrentRow.Cells["K_Servicio_Contratado_Enfermeria"].Value.ToString());
                        SERVICIOS.FRM_ASIGNA_ENFERMERA frm = new SERVICIOS.FRM_ASIGNA_ENFERMERA();
                        frm.PropiedadNo_Servicio = Servicio;
                        frm.ShowDialog();
                        limpia();
                        BaseBotonBuscarClick();

                    }
                    else
                    {

                        MessageBox.Show("EL SERVICIO TIENE UNA ENFERMERA ASIGNADA..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;

                    }
                }
            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR UN SERVICIO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(grdDatos.CurrentRow.Cells["B_Cancelado"].Value) == true)
            {
                MessageBox.Show("EL SERVICIO ESTA CANCELADO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMotivoCanc.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN MOTIVO DE CANCELACIÓN..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (grdDatos.RowCount > 0)
            {
                if ((grdDatos.CurrentRow.Cells["D_Empleado"].Value == null) || (grdDatos.CurrentRow.Cells["K_Empleado"].Value == DBNull.Value))
                {
                    if (Convert.ToBoolean(grdDatos.CurrentRow.Cells["B_Pagado"].Value) == true)
                    {
                        MessageBox.Show("EL SERVICIO ESTA PAGADO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    Servicio = int.Parse(grdDatos.CurrentRow.Cells["K_Servicio_Contratado_Enfermeria"].Value.ToString());
    
                    res = sqlPrecios.Gp_Cancelacion_ServiciosEnferemeria(Servicio, K_Motivo, ref msg);
                    if (res == -1)
                    {

                        MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {

                        MessageBox.Show("INFORMACION ACTUALIZADA CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpia();
                        BaseBotonBuscarClick();

                    }
                }
                else
                {
                    MessageBox.Show("EL SERVICIO TIENE ASIGNADA UNA ENFERMERA..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }
            }

                txtMotivoCanc.Text = string.Empty;
        }

        private void BtnRealizado_Click(object sender, EventArgs e)
        {
            if (grdDatos.RowCount > 0)
            {

                if (Convert.ToBoolean(grdDatos.CurrentRow.Cells["B_Cancelado"].Value) == true)
                {
                    MessageBox.Show("EL SERVICIO ESTA CANCELADO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if ((grdDatos.CurrentRow.Cells["K_Empleado"].Value == null) || (grdDatos.CurrentRow.Cells["K_Empleado"].Value == DBNull.Value))

                {
                    MessageBox.Show("EL SERVICIO NO TIENE UNA ENFERMERA ASIGNADA..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }
                else
                {
                    Servicio = int.Parse(grdDatos.CurrentRow.Cells["K_Servicio_Contratado_Enfermeria"].Value.ToString());

                    res = sqlPrecios.Up_Realiza_ServicioEnfermeria(Servicio, ref msg);
                    if (res == -1)
                    {

                        MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {

                        MessageBox.Show("INFORMACION ACTUALIZADA CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpia();
                        BaseBotonBuscarClick();

                    }


                }
            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR UN SERVICIO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
        }

        private void SeleccionarRegistro(object sender, DataGridViewCellMouseEventArgs e)
        {      
            filaSeleccionada = e.RowIndex;         
        }

        private void btnBuscarmMotivo_Click(object sender, EventArgs e)
        {
            K_Motivo = 0;

            Busquedas.Frm_Busca_MotivoCancServ frm = new Busquedas.Frm_Busca_MotivoCancServ();
            frm.ShowDialog();
            K_Motivo = frm.LLave_Seleccionado;
            txtMotivoCanc.Text = frm.Descripcion_Seleccionado;

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(grdDatos.CurrentRow.Cells["B_Cancelado"].Value) == true)
            {
                MessageBox.Show("EL SERVICIO ESTA CANCELADO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (grdDatos.DataSource != null)
            {
           
                SERVICIOS.FRM_PAGO_SERV_ENF frm = new SERVICIOS.FRM_PAGO_SERV_ENF();
                frm.NumServicio = Convert.ToInt32(grdDatos.Rows[filaSeleccionada].Cells["K_Servicio_Contratado_Enfermeria"].Value.ToString());
                frm.D_Cliente = grdDatos.Rows[filaSeleccionada].Cells["D_Cliente"].Value.ToString();
                frm.Monto = Convert.ToDecimal(grdDatos.Rows[filaSeleccionada].Cells["Precio"].Value.ToString());
                frm.ShowDialog();
                
                if(Convert.ToBoolean(grdDatos.Rows[filaSeleccionada].Cells["B_Pagado"].Value.ToString()) == false)
                {
                    BaseBotonBuscarClick();
                }
            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR UN SERVICIO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(grdDatos.CurrentRow.Cells["B_Cancelado"].Value) == true)
            {
                MessageBox.Show("EL SERVICIO ESTA CANCELADO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            res = 0;
            msg = string.Empty;
        
            if (grdDatos.RowCount > 0)
            {
                if ((grdDatos.CurrentRow.Cells["D_Empleado"].Value == null) || (grdDatos.CurrentRow.Cells["K_Empleado"].Value == DBNull.Value))
                {
                    MessageBox.Show("EL SERVICIO NO TIENE ASIGNADO UN EMPLEADO..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    Servicio = int.Parse(grdDatos.CurrentRow.Cells["K_Servicio_Contratado_Enfermeria"].Value.ToString());
                    K_Enfermera = int.Parse(grdDatos.CurrentRow.Cells["K_Empleado"].Value.ToString());

                    res = sqlPrecios.Dl_Elimina_Empleado(Servicio, K_Enfermera, ref msg);
                    if (res == -1)
                    {

                        MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {

                        MessageBox.Show("INFORMACION ACTUALIZADA CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpia();
                        BaseBotonBuscarClick();

                    }

                }
            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR UN SERVICIO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
        }

        public override void BaseBotonProceso1Click()
        {
            if (grdDatos.RowCount > 0)
            {
                SERVICIOS.FRM_SERV_CONT_ENF_DETALLE frm = new SERVICIOS.FRM_SERV_CONT_ENF_DETALLE();
                frm.NoServicio = grdDatos.Rows[filaSeleccionada].Cells[0].Value.ToString();
                frm.ShowDialog();
                BaseBotonBuscarClick();
            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR UN SERVICIO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        
        }

        public override void BaseBotonExcelClick()
        {
        
            DataTable dtExcel_ = datos.Copy();
            dtExcel_.Columns.Remove("K_Oficina");
            dtExcel_.Columns.Remove("K_Pais");
            dtExcel_.Columns.Remove("K_Estado");
            dtExcel_.Columns.Remove("K_Ciudad");
            dtExcel_.Columns.Remove("K_Colonia");
            dtExcel_.Columns.Remove("K_Dias_Servicio");
            dtExcel_.Columns.Remove("K_Clase_ServicioEnfermeria");
            dtExcel_.Columns.Remove("K_Tipo_ServicioEnfermeria");
            dtExcel_.Columns.Remove("K_Duracion_Servicio");
            dtExcel_.Columns.Remove("K_Precio_Enfermeria");

            dtExcel_.Columns["K_Servicio_Contratado_Enfermeria"].ColumnName = "No. Servicio";
            dtExcel_.Columns["K_Cliente"].ColumnName = "Num. Cliente";
            dtExcel_.Columns["D_Cliente"].ColumnName = "Cliente";
            dtExcel_.Columns["D_Oficina"].ColumnName = "Oficina";   
            dtExcel_.Columns["D_Pais"].ColumnName = "País";
            dtExcel_.Columns["D_Estado"].ColumnName = "Estado";
            dtExcel_.Columns["D_Ciudad"].ColumnName = "Ciudad";
            dtExcel_.Columns["D_Colonia"].ColumnName = "Colonia";
            dtExcel_.Columns["K_Empleado"].ColumnName = "No. Empleado";
            dtExcel_.Columns["CalleNumero"].ColumnName = "Calle";
            dtExcel_.Columns["B_Local"].ColumnName = "Local";   
            dtExcel_.Columns["TelefonoContacto"].ColumnName = "Teléfono de Contacto";          
            dtExcel_.Columns["B_Masculino"].ColumnName = "Masculino";
            dtExcel_.Columns["B_Mas120Kilos"].ColumnName = "¿Mas de 120 Kg?";
            dtExcel_.Columns["Precio"].ColumnName = "Precio";
            dtExcel_.Columns["F_Alta"].ColumnName = "Fecha de Alta";
            dtExcel_.Columns["F_Servicio"].ColumnName = "Fecha de Servicio";
            dtExcel_.Columns["B_Realizado"].ColumnName = "Realizado";
            dtExcel_.Columns["B_Pagado"].ColumnName = "Pagado";
            dtExcel_.Columns["B_Cancelado"].ColumnName = "Cancelado";
            dtExcel_.Columns["F_Cancelado"].ColumnName = "Fecha de Cancelado";
            dtExcel_.Columns["B_App"].ColumnName = "Aplicación";        
            dtExcel_.Columns["D_Clase_ServicioEnfermeria"].ColumnName = "Clasificación Servicio Enferméria";
            dtExcel_.Columns["Descripcion_Servicio"].ColumnName = "Descripción Servicio";
            dtExcel_.Columns["D_Tipo_Enfermeria"].ColumnName = "Tipo de Enfermeria";

            if (dtExcel_ == null)
            {
                MessageBox.Show("NO EXISTE INFORMACION PARA EXPORTAR...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Archivos Excel (*.xlsx)|*.xlsx";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Cursor = Cursors.WaitCursor;
                string Hoja = "Datos";
                DataTable dtExcel = dtExcel_;
                BorraColumnaCamposBusqueda(ref dtExcel);
                fx.ExportToExcel(dtExcel, saveFileDialog1.FileName, Hoja);
            }
            Cursor = Cursors.Default;
        }

        void OrdenarColumnasGrid()
        {
            grdDatos.Columns["K_Servicio_Contratado_Enfermeria"].DisplayIndex = 0;
            grdDatos.Columns["K_Cliente"].DisplayIndex = 1;
            grdDatos.Columns["D_Cliente"].DisplayIndex = 2;
            grdDatos.Columns["D_Oficina"].DisplayIndex = 3;
            grdDatos.Columns["D_Pais"].DisplayIndex = 4;
            grdDatos.Columns["D_Estado"].DisplayIndex = 5;
            grdDatos.Columns["D_Ciudad"].DisplayIndex = 6;
            grdDatos.Columns["D_Colonia"].DisplayIndex = 7;
            grdDatos.Columns["Calle"].DisplayIndex = 8;
            grdDatos.Columns["B_Local"].DisplayIndex = 9;
            grdDatos.Columns["TelefonoContacto"].DisplayIndex = 10;
            grdDatos.Columns["Precio"].DisplayIndex = 11;
            grdDatos.Columns["K_Empleado"].DisplayIndex = 12;
            grdDatos.Columns["D_Empleado"].DisplayIndex = 13;
            grdDatos.Columns["F_Alta"].DisplayIndex = 14;
            grdDatos.Columns["B_Masculino"].DisplayIndex = 15;
            grdDatos.Columns["B_Mas120Kilos"].DisplayIndex = 16;
            grdDatos.Columns["F_Servicio"].DisplayIndex = 17;
            grdDatos.Columns["B_Realizado"].DisplayIndex = 18;
            grdDatos.Columns["B_Pagado"].DisplayIndex = 19;
            grdDatos.Columns["B_Cancelado"].DisplayIndex = 20;
            grdDatos.Columns["F_Cancelado"].DisplayIndex = 21;
            grdDatos.Columns["B_App"].DisplayIndex = 22;
            grdDatos.Columns["D_Clase_ServicioEnfermeria"].DisplayIndex = 23;
            grdDatos.Columns["Descripcion_Servicio"].DisplayIndex = 24;
            grdDatos.Columns["D_Tipo_Enfermeria"].DisplayIndex = 25;
        }
    }

    
}
