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

namespace ProbeMedic.ADMINISTRACION
{
    public partial class Frm_PresupuestoEgresos : FormaBase
    {
        bool PropiedadEsRegistroNuevo = false;
        
        int res = 0;
        string msg = string.Empty;

        SQLAdministracion SqlAdministracion = new SQLAdministracion();
        public Frm_PresupuestoEgresos()
        {
            InitializeComponent();
            this.grdDatos.AutoGenerateColumns = false;
           
        }


        public override void BaseMetodoInicio()
        {       
            BaseBotonModificar.Visible = false;
            BaseBotonModificar.Enabled = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonBuscar.Enabled = false;
            BaseBotonGuardar.Enabled = false;
            BaseBotonGuardar.Visible = false;
            BaseBotonCancelar.Enabled = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonAfectar.Enabled = false;
            BaseBotonReporte.Visible = false;
            BaseBotonReporte.Enabled = false;
            BaseBotonExcel.Visible = false;
            BaseBotonExcel.Enabled = false;

            pnlEncabezado.Enabled = true;
            pnlMeses.Enabled = false;

            NumericUpDwn.Value = DateTime.Now.Year;

            DateTime dInicial = new DateTime(DateTime.Now.Year - 5, 1, 1);// año mes dia
            DateTime dFinal = new DateTime(DateTime.Now.Year + 5, 1, 1);// año mes dia
            this.dtpInicio.Value = dInicial;
            this.dtpFinal.Value = dFinal;

            PropiedadEsRegistroNuevo = false;

            BaseBotonProceso1.Image = ((System.Drawing.Image)(imageList1.Images["btnNuevo.Image.png"]));
            BaseBotonProceso1.Text = "Nuevo";
            BaseBotonProceso1.ToolTipText = "Nuevo";
            BaseBotonProceso1.Visible = true;
            BaseBotonProceso1.Enabled = true;

            BaseBotonProceso2.Image = ((System.Drawing.Image)(imageList1.Images["btnGuardar.Image.png"]));
            BaseBotonProceso2.Text = "Guardar";
            BaseBotonProceso2.ToolTipText = "Guardar Presupuesto";
            BaseBotonProceso2.Visible = true;
            BaseBotonProceso2.Enabled = false;

            BaseBotonProceso3.Image = ((System.Drawing.Image)(imageList1.Images["BtnCancelar.Image.png"]));
            BaseBotonProceso3.Text = "Cancelar";
            BaseBotonProceso3.ToolTipText = "Cancelar Captura";
            BaseBotonProceso3.Visible = true;
            BaseBotonProceso3.Enabled = true;

            BaseBotonProceso4.Image = ((System.Drawing.Image)(imageList1.Images["btnModificar.Image.png"]));
            BaseBotonProceso4.Text = "Modificar";
            BaseBotonProceso4.ToolTipText = "Modificar";
            BaseBotonProceso4.Visible = true;
            BaseBotonProceso4.Enabled = false;
    
            BaseBotonBuscar.Visible = true;
            BaseBotonBuscar.Enabled = true;

            txtEnero.Text = "0.00";
            txtEnero.Text = TxtImporteToStr(txtEnero);
            txtFebrero.Text = "0.00";
            txtFebrero.Text = TxtImporteToStr(txtFebrero);
            txtMarzo.Text = "0.00";
            txtMarzo.Text = TxtImporteToStr(txtMarzo);
            txtAbril.Text = "0.00";
            txtAbril.Text = TxtImporteToStr(txtAbril);
            txtMayo.Text = "0.00";
            txtMayo.Text = TxtImporteToStr(txtMayo);
            txtJunio.Text = "0.00";
            txtJunio.Text = TxtImporteToStr(txtJunio);
            txtJulio.Text = "0.00";
            txtJulio.Text = TxtImporteToStr(txtJulio);
            txtAgosto.Text = "0.00";
            txtAgosto.Text = TxtImporteToStr(txtAgosto);
            txtSeptiembre.Text = "0.00";
            txtSeptiembre.Text = TxtImporteToStr(txtSeptiembre);
            txtOctubre.Text = "0.00";
            txtOctubre.Text = TxtImporteToStr(txtOctubre);
            txtNoviembre.Text = "0.00";
            txtNoviembre.Text = TxtImporteToStr(txtNoviembre);
            txtDiciembre.Text = "0.00";
            txtDiciembre.Text = TxtImporteToStr(txtDiciembre);

            this.grdDatos.AutoGenerateColumns = false;
            this.grdDatos.ScrollBars = ScrollBars.Both;
            //this.WindowState = FormWindowState.Maximized;

            //BaseBotonBuscarClick();

        }
        private void txtEnero_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaSeaNumeroDecimal(ref sender, ref e);
        }
        private void txtFebrero_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaSeaNumeroDecimal(ref sender, ref e);
        }
        private void txtMarzo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaSeaNumeroDecimal(ref sender, ref e);
        }
        private void txtAbril_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaSeaNumeroDecimal(ref sender, ref e);
        }
        private void txtMayo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaSeaNumeroDecimal(ref sender, ref e);
        }
        private void txtJunio_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaSeaNumeroDecimal(ref sender, ref e);
        }
        private void txtJulio_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaSeaNumeroDecimal(ref sender, ref e);
        }
        private void txtAgosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaSeaNumeroDecimal(ref sender, ref e);
        }
        private void txtSeptiembre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaSeaNumeroDecimal(ref sender, ref e);
        }
        private void txtOctubre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaSeaNumeroDecimal(ref sender, ref e);
        }
        private void txtNoviembre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaSeaNumeroDecimal(ref sender, ref e);
        }
        private void txtDiciembre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaSeaNumeroDecimal(ref sender, ref e);
        }
        private void txtEnero_Leave(object sender, EventArgs e)
        {
            txtEnero.Text = TxtImporteToStr(txtEnero);
        }
        private void txtFebrero_Leave(object sender, EventArgs e)
        {
            txtFebrero.Text = TxtImporteToStr(txtFebrero);
        }
        private void txtMarzo_Leave(object sender, EventArgs e)
        {
            txtMarzo.Text = TxtImporteToStr(txtMarzo);
        }
        private void txtAbril_Leave(object sender, EventArgs e)
        {
            txtAbril.Text = TxtImporteToStr(txtAbril);
        }
        private void txtMayo_Leave(object sender, EventArgs e)
        {
            txtMayo.Text = TxtImporteToStr(txtMayo);
        }
        private void txtJunio_Leave(object sender, EventArgs e)
        {
            txtJunio.Text = TxtImporteToStr(txtJunio);
        }
        private void txtJulio_Leave(object sender, EventArgs e)
        {
            txtJulio.Text = TxtImporteToStr(txtJulio);
        }
        private void txtAgosto_Leave(object sender, EventArgs e)
        {
            txtAgosto.Text = TxtImporteToStr(txtAgosto);
        }
        private void txtSeptiembre_Leave(object sender, EventArgs e)
        {
            txtSeptiembre.Text = TxtImporteToStr(txtSeptiembre);
        }
        private void txtOctubre_Leave(object sender, EventArgs e)
        {
            txtOctubre.Text = TxtImporteToStr(txtOctubre);
        }
        private void txtNoviembre_Leave(object sender, EventArgs e)
        {
            txtNoviembre.Text = TxtImporteToStr(txtNoviembre);
        }
        private void txtDiciembre_Leave(object sender, EventArgs e)
        {
            txtDiciembre.Text = TxtImporteToStr(txtDiciembre);
        }

        private string TxtImporteToStr(TextBox txtImporte)
        {
            Double dblImporte = 0;
            dblImporte = Convert.ToDouble(TxtImporteToDec(txtImporte));
            //if (dblImporte == 0)
            //{
            //    return "";
            //}
            //else
            //{
                return dblImporte.ToString("C");
            //}
        }
        private string TxtImporteToDec(TextBox txtImporte)
        {
            if (txtImporte.Text.Trim().Length == 0)
            {
                return "0";
            }
            else
            {
                return txtImporte.Text.Replace("$", "").Replace(",", "");
            }
        }
        private void FiltraHistorial()
        {
            DataTable DtHistorial = SqlAdministracion.Sk_Historico_Presupuesto_Egresos(sel_OficinaHistoria.K_Oficina, ucDepartamentos2.K_Departamento,
                ucTipoMovCajaChica2.K_Tipo_MovCchica, ucProyecto2.K_Proyecto, (int)numericUpDown1.Value, dtpInicio.Value, dtpFinal.Value);

            if ((DtHistorial== null) || (DtHistorial.Rows.Count == 0))
            {
                MessageBox.Show("NO SE ENCONTRO INFORMACION..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    
            }
            this.grdDatos.DataSource = DtHistorial;
        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (sel_Oficina1.K_Oficina == 0)
            {
                MessageBox.Show("FALTA CAPTURAR OFICINA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                sel_Oficina1.Focus();
                return false;
            }
            if (ucDepartamentos1.K_Departamento== 0)
            {
                MessageBox.Show("FALTA CAPTURAR DEPARTAMENTO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucDepartamentos1.Focus();
                return false;
            }
            if (ucTipoMovCajaChica1.K_Tipo_MovCchica == 0)
            {
                MessageBox.Show("FALTA CAPTURAR TIPO DE MOVIMIENTO CAJA CHICA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucTipoMovCajaChica1.Focus();
                return false;
            }
            if (ucProyecto1.K_Proyecto == 0)
            {
                MessageBox.Show("FALTA CAPTURAR PROYECTO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucProyecto1.Focus();
                return false;
            }

            BaseErrorResultado = false;
            return true;
        }
        public override void BaseMetodoLimpiaControles()
        {
            //txtEnero.Text = string.Empty;
            //txtFebrero.Text = string.Empty;
            //txtMarzo.Text = string.Empty;
            //txtAbril.Text = string.Empty;
            //txtMayo.Text = string.Empty;
            //txtJunio.Text = string.Empty;
            //txtJulio.Text = string.Empty;
            //txtAgosto.Text = string.Empty;
            //txtSeptiembre.Text = string.Empty;
            //txtOctubre.Text = string.Empty;
            //txtNoviembre.Text = string.Empty;
            //txtDiciembre.Text = string.Empty;

            txtEnero.Text = "0.00";
            txtEnero.Text = TxtImporteToStr(txtEnero);
            txtFebrero.Text = "0.00";
            txtFebrero.Text = TxtImporteToStr(txtFebrero);
            txtMarzo.Text = "0.00";
            txtMarzo.Text = TxtImporteToStr(txtMarzo);
            txtAbril.Text = "0.00";
            txtAbril.Text = TxtImporteToStr(txtAbril);
            txtMayo.Text = "0.00";
            txtMayo.Text = TxtImporteToStr(txtMayo);
            txtJunio.Text = "0.00";
            txtJunio.Text = TxtImporteToStr(txtJunio);
            txtJulio.Text = "0.00";
            txtJulio.Text = TxtImporteToStr(txtJulio);
            txtAgosto.Text = "0.00";
            txtAgosto.Text = TxtImporteToStr(txtAgosto);
            txtSeptiembre.Text = "0.00";
            txtSeptiembre.Text = TxtImporteToStr(txtSeptiembre);
            txtOctubre.Text = "0.00";
            txtOctubre.Text = TxtImporteToStr(txtOctubre);
            txtNoviembre.Text = "0.00";
            txtNoviembre.Text = TxtImporteToStr(txtNoviembre);
            txtDiciembre.Text = "0.00";
            txtDiciembre.Text = TxtImporteToStr(txtDiciembre);

            sel_Oficina1.K_Oficina = 0;
            sel_Oficina1.txt_ClaveOficina.Text = string.Empty;
            sel_Oficina1.txt_Oficina.Text = string.Empty;
            ucDepartamentos1.K_Departamento = 0;
            ucDepartamentos1.txt_E_Departamento.Text = string.Empty;
            ucTipoMovCajaChica1.K_Tipo_MovCchica = 0;
            ucTipoMovCajaChica1.txt_E_TipoMovCchica.Text = string.Empty;
            ucProyecto1.K_Proyecto = 0;
            ucProyecto1.txt_E_Proyecto.Text = string.Empty;
            NumericUpDwn.Value = DateTime.Now.Year;

            sel_OficinaHistoria.K_Oficina = 0;
            sel_OficinaHistoria.txt_ClaveOficina.Text = string.Empty;
            sel_OficinaHistoria.txt_Oficina.Text = string.Empty;
            ucDepartamentos2.K_Departamento = 0;
            ucDepartamentos2.txt_E_Departamento.Text = string.Empty;
            ucTipoMovCajaChica2.K_Tipo_MovCchica = 0;
            ucTipoMovCajaChica2.txt_E_TipoMovCchica.Text = string.Empty;
            ucProyecto2.K_Proyecto = 0;
            ucProyecto2.txt_E_Proyecto.Text = string.Empty;
            numericUpDown1.Value = DateTime.Now.Year;

            this.grdDatos.DataSource = null;
            base.BaseMetodoLimpiaControles();
        }

        //NUEVO
        public override void BaseBotonProceso1Click()
        {
            BaseMetodoLimpiaControles();
            PropiedadEsRegistroNuevo = true;
            pnlMeses.Enabled= true;
            BaseBotonProceso1.Enabled = false;
            BaseBotonProceso3.Visible = false;
            BaseBotonProceso3.Visible = true;
            BaseBotonProceso2.Visible = false;
            BaseBotonProceso2.Visible = true;
            BaseBotonProceso2.Enabled = true;
            BaseBotonProceso4.Enabled = false;

        }
        //GUARDAR
        public override void BaseBotonProceso2Click()
        {

            if (!BaseFuncionValidaciones())
                return;
            res = 0;
            msg = string.Empty;

            List<PresupuestoMensual> LstMeses = new List<PresupuestoMensual>();

            if (txtEnero.Text.Trim().Length > 0)
            {
                PresupuestoMensual ob = new PresupuestoMensual();
                ob.Mes = 1;
                ob.Monto = Convert.ToDecimal(TxtImporteToDec(txtEnero));
                LstMeses.Add(ob);
            }
            if (txtFebrero.Text.Trim().Length > 0)
            {
                PresupuestoMensual ob = new PresupuestoMensual();
                ob.Mes = 2;
                ob.Monto = Convert.ToDecimal(TxtImporteToDec(txtFebrero));
                LstMeses.Add(ob);
            }
            if (txtMarzo.Text.Trim().Length > 0)
            {
                PresupuestoMensual ob = new PresupuestoMensual();
                ob.Mes = 3;
                ob.Monto = Convert.ToDecimal(TxtImporteToDec(txtMarzo));
                LstMeses.Add(ob);
            }
            if (txtAbril.Text.Trim().Length > 0)
            {
                PresupuestoMensual ob = new PresupuestoMensual();
                ob.Mes = 4;
                ob.Monto = Convert.ToDecimal(TxtImporteToDec(txtAbril));
                LstMeses.Add(ob);
            }
            if (txtMayo.Text.Trim().Length > 0)
            {
                PresupuestoMensual ob = new PresupuestoMensual();
                ob.Mes = 5;
                ob.Monto = Convert.ToDecimal(TxtImporteToDec(txtMayo));
                LstMeses.Add(ob);
            }
            if (txtJunio.Text.Trim().Length > 0)
            {
                PresupuestoMensual ob = new PresupuestoMensual();
                ob.Mes = 6;
                ob.Monto = Convert.ToDecimal(TxtImporteToDec(txtJunio));
                LstMeses.Add(ob);
            }
            if (txtJulio.Text.Trim().Length > 0)
            {
                PresupuestoMensual ob = new PresupuestoMensual();
                ob.Mes = 7;
                ob.Monto = Convert.ToDecimal(TxtImporteToDec(txtJulio));
                LstMeses.Add(ob);
            }
            if (txtAgosto.Text.Trim().Length > 0)
            {
                PresupuestoMensual ob = new PresupuestoMensual();
                ob.Mes = 8;
                ob.Monto = Convert.ToDecimal(TxtImporteToDec(txtAgosto));
                LstMeses.Add(ob);
            }
            if (txtSeptiembre.Text.Trim().Length > 0)
            {
                PresupuestoMensual ob = new PresupuestoMensual();
                ob.Mes = 9;
                ob.Monto = Convert.ToDecimal(TxtImporteToDec(txtSeptiembre));
                LstMeses.Add(ob);
            }
            if (txtOctubre.Text.Trim().Length > 0)
            {
                PresupuestoMensual ob = new PresupuestoMensual();
                ob.Mes = 10;
                ob.Monto = Convert.ToDecimal(TxtImporteToDec(txtOctubre));
                LstMeses.Add(ob);
            }
            if (txtNoviembre.Text.Trim().Length > 0)
            {
                PresupuestoMensual ob = new PresupuestoMensual();
                ob.Mes = 11;
                ob.Monto = Convert.ToDecimal(TxtImporteToDec(txtNoviembre));
                LstMeses.Add(ob);
            }
            if (txtDiciembre.Text.Trim().Length > 0)
            {
                PresupuestoMensual ob = new PresupuestoMensual();
                ob.Mes = 12;
                ob.Monto = Convert.ToDecimal(TxtImporteToDec(txtDiciembre));
                LstMeses.Add(ob);
            }
            if (LstMeses.Count < 12)
            {
                MessageBox.Show("DEBE CAPTURAR TODOS LOS PRESUPUESTOS MENSUALES..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEnero.Focus();
                return;
            }
            if (PropiedadEsRegistroNuevo) // Nuevo
            {
                foreach (var item in LstMeses)
                {
                    res = SqlAdministracion.In_Presupuestos_Egresos(sel_Oficina1.K_Oficina, ucDepartamentos1.K_Departamento,
                        ucTipoMovCajaChica1.K_Tipo_MovCchica, ucProyecto1.K_Proyecto, (int)NumericUpDwn.Value, item.Mes, GlobalVar.K_Usuario, DateTime.Now,
                        item.Monto, ref msg);

                    if (res == -1)
                    {
                        BaseErrorResultado = true;
                        MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                MessageBox.Show("PROCESO TERMINADO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else //Existe. Update
            {
                foreach (var item in LstMeses)
                {
                    res = SqlAdministracion.Up_Presupuestos_Egresos(sel_Oficina1.K_Oficina, ucDepartamentos1.K_Departamento,
                        ucTipoMovCajaChica1.K_Tipo_MovCchica, ucProyecto1.K_Proyecto, (int)NumericUpDwn.Value, item.Mes, GlobalVar.K_Usuario, DateTime.Now,
                        item.Monto, ref msg);

                    if (res == -1)
                    {
                        BaseErrorResultado = true;
                        MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                MessageBox.Show("PROCESO TERMINADO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            BaseBotonBuscarClick();
            BaseBotonModificarClick();
            BaseMetodoLimpiaControles();
            BaseMetodoInicio();
            base.BaseBotonProceso1Click();
        }
        //CANCELAR
        public override void BaseBotonProceso3Click()
        {
            BaseMetodoLimpiaControles();
            BaseMetodoInicio();
        }
        //MODIFICAR
        public override void BaseBotonProceso4Click()
        {
            BaseBotonProceso1.Enabled = false;
            BaseBotonProceso2.Enabled = true;
            BaseBotonProceso4.Enabled = false;
            PropiedadEsRegistroNuevo = false;
            pnlMeses.Enabled = true;
            pnlEncabezado.Enabled = false;
         }

        public override void BaseBotonBuscarClick()
        {          
            DataTable DtPresupuestos = SqlAdministracion.Sk_Presupuestos_Egresos(sel_Oficina1.K_Oficina, ucDepartamentos1.K_Departamento,
                ucTipoMovCajaChica1.K_Tipo_MovCchica, ucProyecto1.K_Proyecto, (int)NumericUpDwn.Value, 0);

            if((DtPresupuestos == null) || (DtPresupuestos.Rows.Count == 0))
            {
                MessageBox.Show("NO SE ENCONTRO INFORMACION..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRow row = DtPresupuestos.Rows[0];
            sel_Oficina1.K_Oficina= Convert.ToInt32(row["K_Oficina"].ToString());
            sel_Oficina1.txt_ClaveOficina.Text = row["K_Oficina"].ToString();
            sel_Oficina1.txt_Oficina.Text = row["D_Oficina"].ToString();
            ucDepartamentos1.K_Departamento = Convert.ToInt32(row["K_Departamento"].ToString());
            ucDepartamentos1.txt_E_Departamento.Text = row["D_Departamento"].ToString();
            ucTipoMovCajaChica1.K_Tipo_MovCchica= Convert.ToInt32(row["K_Tipo_MovCchica"].ToString());
            ucTipoMovCajaChica1.txt_E_TipoMovCchica.Text = row["D_Tipo_MovCchica"].ToString();
            ucProyecto1.K_Proyecto = Convert.ToInt32(row["K_Proyecto"].ToString());
            ucProyecto1.txt_E_Proyecto.Text = row["D_Proyecto"].ToString();
            NumericUpDwn.Value= Convert.ToInt32(row["Year"].ToString());
            txtEnero.Text = row["Enero"].ToString();
            txtEnero.Text = TxtImporteToStr(txtEnero);
            txtFebrero.Text = row["Febrero"].ToString();
            txtFebrero.Text = TxtImporteToStr(txtFebrero);
            txtMarzo.Text = row["Marzo"].ToString();
            txtMarzo.Text = TxtImporteToStr(txtMarzo);
            txtAbril.Text = row["Abril"].ToString();
            txtAbril.Text = TxtImporteToStr(txtAbril);
            txtMayo.Text = row["Mayo"].ToString();
            txtMayo.Text = TxtImporteToStr(txtMayo);
            txtJunio.Text = row["Junio"].ToString();
            txtJunio.Text = TxtImporteToStr(txtJunio);
            txtJulio.Text = row["Julio"].ToString();
            txtJulio.Text = TxtImporteToStr(txtJulio);
            txtAgosto.Text = row["Agosto"].ToString();
            txtAgosto.Text = TxtImporteToStr(txtAgosto);
            txtSeptiembre.Text = row["Septiembre"].ToString();
            txtSeptiembre.Text = TxtImporteToStr(txtSeptiembre);
            txtOctubre.Text = row["Octubre"].ToString();
            txtOctubre.Text = TxtImporteToStr(txtOctubre);
            txtNoviembre.Text = row["Noviembre"].ToString();
            txtNoviembre.Text = TxtImporteToStr(txtNoviembre);
            txtDiciembre.Text = row["Diciembre"].ToString();
            txtDiciembre.Text = TxtImporteToStr(txtDiciembre);
            BaseBotonProceso4.Enabled = true;
    
            base.BaseBotonBuscarClick();
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            FiltraHistorial();
        }

        private void Frm_PresupuestoEgresos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {

                FiltraHistorial();
            }
        }

        private void txtEnero_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBox textBox = (TextBox)sender;
                if (textBox.Text.Trim().Length > 0)
                {
                    if (Convert.ToDecimal(textBox.Text.Trim().Replace("$", "")) >= 100000000000)
                    {
                        MessageBox.Show("VALOR DEMASIADO GRANDE!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox.Text = string.Empty;
                    }
                }
            }
            catch(Exception ex) { }
            
        }

        private void txtFebrero_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBox textBox = (TextBox)sender;
                if (textBox.Text.Trim().Length > 0)
                {
                    if (Convert.ToDecimal(textBox.Text.Trim().Replace("$", "")) >= 100000000000)
                    {
                        MessageBox.Show("VALOR DEMASIADO GRANDE!..." ,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex) { }
        }
        private void txtMarzo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBox textBox = (TextBox)sender;
                if (textBox.Text.Trim().Length > 0)
                {
                    if (Convert.ToDecimal(textBox.Text.Trim().Replace("$", "")) >= 100000000000)
                    {
                        MessageBox.Show("VALOR DEMASIADO GRANDE!..." , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex) { }
        }
        private void txtAbril_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBox textBox = (TextBox)sender;
                if (textBox.Text.Trim().Length > 0)
                {
                    if (Convert.ToDecimal(textBox.Text.Trim().Replace("$", "")) >= 100000000000)
                    {
                        MessageBox.Show("VALOR DEMASIADO GRANDE!..." , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void txtMayo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBox textBox = (TextBox)sender;
                if (textBox.Text.Trim().Length > 0)
                {
                    if (Convert.ToDecimal(textBox.Text.Trim().Replace("$", "")) >= 100000000000)
                    {
                        MessageBox.Show("VALOR DEMASIADO GRANDE!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void txtJunio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBox textBox = (TextBox)sender;
                if (textBox.Text.Trim().Length > 0)
                {
                    if (Convert.ToDecimal(textBox.Text.Trim().Replace("$", "")) >= 100000000000)
                    {
                        MessageBox.Show("VALOR DEMASIADO GRANDE!..." , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void txtJulio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBox textBox = (TextBox)sender;
                if (textBox.Text.Trim().Length > 0)
                {
                    if (Convert.ToDecimal(textBox.Text.Trim().Replace("$", "")) >= 100000000000)
                    {
                        MessageBox.Show("VALOR DEMASIADO GRANDE!..." , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void txtAgosto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBox textBox = (TextBox)sender;
                if (textBox.Text.Trim().Length > 0)
                {
                    if (Convert.ToDecimal(textBox.Text.Trim().Replace("$", "")) >= 100000000000)
                    {
                        MessageBox.Show("VALOR DEMASIADO GRANDE!..." , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void txtSeptiembre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBox textBox = (TextBox)sender;
                if (textBox.Text.Trim().Length > 0)
                {
                    if (Convert.ToDecimal(textBox.Text.Trim().Replace("$", "")) >= 100000000000)
                    {
                        MessageBox.Show("VALOR DEMASIADO GRANDE!..." , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void txtOctubre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBox textBox = (TextBox)sender;
                if (textBox.Text.Trim().Length > 0)
                {
                    if (Convert.ToDecimal(textBox.Text.Trim().Replace("$", "")) >= 100000000000)
                    {
                        MessageBox.Show("VALOR DEMASIADO GRANDE!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void txtNoviembre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBox textBox = (TextBox)sender;
                if (textBox.Text.Trim().Length > 0)
                {
                    if (Convert.ToDecimal(textBox.Text.Trim().Replace("$", "")) >= 100000000000)
                    {
                        MessageBox.Show("VALOR DEMASIADO GRANDE!..." , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void txtDiciembre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBox textBox = (TextBox)sender;
                if (textBox.Text.Trim().Length > 0)
                {
                    if (Convert.ToDecimal(textBox.Text.Trim().Replace("$", "")) >= 100000000000)
                    {
                        MessageBox.Show("VALOR DEMASIADO GRANDE!..." , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex) { }
        }
    }
    public class PresupuestoMensual
    {
        public int Mes { get; set; }
        public decimal Monto { get; set; }
    }
}
