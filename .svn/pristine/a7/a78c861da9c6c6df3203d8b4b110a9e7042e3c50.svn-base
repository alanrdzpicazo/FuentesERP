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

namespace ProbeMedic.CATALOGOS.ASEGURADORAS
{
    public partial class FRM_ZONIFICACION_LPENFERMERIA_ASEG : FormaBase
    {
        SQLCatalogos catalogosSQL = new SQLCatalogos();
        SQLPrecios PreciosSQL = new SQLPrecios();
        Funciones fx = new Funciones();

        DataTable datos = new DataTable();
        int K_Precio_Local_Enfermeria = 0, K_Pais = 0, K_Estado = 0, K_Ciudad = 0, K_Oficina = 0,K_Colonia=0, K_Precio_Enfermeria = 0,K_Aseguradora=0;

        DateTime FechaInicial = DateTime.Today;

        DateTime FechaFinal = DateTime.Today;
        string D_Ciudad = string.Empty;

        int res = 0;
        string msg = string.Empty;
        public FRM_ZONIFICACION_LPENFERMERIA_ASEG()
        {
            InitializeComponent();
        }
        private void btnBuscarCaracteristicas_Click(object sender, EventArgs e)
        {
            BuscaEnfermeria();
        }
        private void BuscaEnfermeria()
        {
            GlobalVar.dtPreciosEnfermeria = catalogosSQL.Sk_Precios_Enfermeria();
            Busquedas.Frm_Busca_Enfermeria frm = new Busquedas.Frm_Busca_Enfermeria();
            frm.ShowDialog();
            K_Precio_Enfermeria = frm.LLave_Seleccionado;
            txt_Caracteristicas.Text = frm.Descripcion_Seleccionado;

        }
        public void LLenarGrid(int K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Precio_Enfermeria, int K_Oficina,int K_Colonia, DateTime FechaInicial, DateTime FechaFinal,int K_Aseguradora)
        {
            datos = catalogosSQL.Sk_Zonificacion_LPEnfermeria_Aseg(Convert.ToInt16(K_Pais), K_Estado, K_Ciudad, K_Precio_Enfermeria, K_Oficina,K_Colonia, FechaInicial, FechaFinal,K_Aseguradora);
            msg = string.Empty;

            if (datos != null)
            {
                grdDatos.DataSource = datos;
                grdDatos.Columns["D_Pais"].Visible = false;
                grdDatos.Columns["K_Pais"].Visible = false;
                grdDatos.Columns["K_Estado"].Visible = false;
                grdDatos.Columns["K_Ciudad"].Visible = false;
                grdDatos.Columns["K_Oficina"].Visible = false;
                grdDatos.Columns["K_Colonia"].Visible = false;
                grdDatos.Columns["D_Colonia"].HeaderText = "Colonia";
                grdDatos.Columns["K_Precio_LocAsegu_Enfermeria"].HeaderText = "Clave";
                grdDatos.Columns["D_Estado"].HeaderText = "Estado";
                grdDatos.Columns["D_Oficina"].HeaderText = "Oficina";
                grdDatos.Columns["D_Ciudad"].HeaderText = "Ciudad";
                grdDatos.Columns["K_Precio_Enfermeria"].Visible = false;
                grdDatos.Columns["K_Clase_ServicioEnfermeria"].Visible = false;
                grdDatos.Columns["K_Tipo_Servicio_Enfermeria"].Visible = false;
                grdDatos.Columns["K_Duracion_Servicio"].Visible = false;
                grdDatos.Columns["K_Dias_Servicio"].Visible = false;
                grdDatos.Columns["D_Clase_ServicioEnfermeria"].HeaderText = "Clase ";
                grdDatos.Columns["D_Tipo_Enfermeria"].HeaderText = "Tipo";
                grdDatos.Columns["K_Aseguradora"].Visible = false;
                grdDatos.Columns["D_Aseguradora"].HeaderText = "Aseguradora";
                BaseBotonCancelar.Visible = true;
                BaseBotonCancelar.Enabled = true;
                grdDatos.Focus();
                grdDatos.ScrollBars = ScrollBars.Both;

            }
            else
                MessageBox.Show("NO SE ENCONTRO INFORMACION...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public override void BaseMetodoInicio()
        {
            BaseMetodoRecarga();
            BaseBotonModificar.Visible = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonReporte.Visible = false;
            BaseBotonBorrar.Visible = false;

      

            //PROPIEDADES DEL GRID
            grdDatos.MultiSelect = false;
            grdDatos.ReadOnly = true;
            grdDatos.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            grdDatos.BackgroundColor = Color.White;
            grdDatos.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
            grdDatos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grdDatos.EnableHeadersVisualStyles = false;
            //
        }
        public override void BaseBotonGuardarClick()
        {
            if (!BaseFuncionValidaciones())
                return;

            res = 0;
            msg = string.Empty;

            DateTime FechaInicial = DateTime.Today;
            FechaInicial = dtpInicial.Value;
            DateTime FechaFinal = DateTime.Today;
            FechaFinal = dtpFinal.Value;
            int CampoIdentity = 0;
            try
            {
                res = catalogosSQL.In_Zonificacion_LocAsegu_Precios_Enfermeria(ref CampoIdentity,Convert.ToInt16(zonLE_Oficina1.K_Pais), Convert.ToInt32(zonLE_Oficina1.K_Estado), Convert.ToInt16(zonLE_Oficina1.K_Ciudad), Convert.ToInt32(K_Precio_Enfermeria), Convert.ToInt16(zonLE_Oficina1.K_Oficina),zonLE_Oficina1.K_Colonia, Convert.ToDecimal(txtPrecio.Text), FechaInicial, FechaFinal, Convert.ToInt16(ucAseguradora1.K_Aseguradora), ref msg);
            }
            catch (Exception)
            {
                MessageBox.Show("YA ESTA REGISTRADA LA COBERTURA PARA LA CIUDAD CAPTURADA", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (res == -1)
            {
                BaseErrorResultado = true;
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                BaseErrorResultado = false;
                MessageBox.Show("INFORMACION ACTUALIZADA CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BaseMetodoInicio();
                BaseBotonBuscarClick();

                //ME RECARGA EL GRID CON LO QUE SE ACABA DE GUARDAR

            }

        }
        public override void BaseBotonBuscarClick()
        {

            DateTime FechaInicial = DateTime.Today;
            FechaInicial = dtpInicial.Value;
            DateTime FechaFinal = DateTime.Today;
            FechaFinal = dtpFinal.Value;


            K_Pais = zonLE_Oficina1.K_Pais;
            K_Ciudad = zonLE_Oficina1.K_Ciudad;
            K_Estado = zonLE_Oficina1.K_Estado;
            K_Oficina = zonLE_Oficina1.K_Oficina;
            K_Precio_Enfermeria = Convert.ToInt32(K_Precio_Enfermeria);
            K_Aseguradora = Convert.ToInt16(ucAseguradora1.K_Aseguradora);

            LLenarGrid(K_Pais, K_Estado, K_Ciudad, K_Precio_Enfermeria, K_Oficina,K_Colonia, FechaInicial, FechaFinal,K_Aseguradora);
            BaseBotonGuardar.Visible = false;

            //ME VALIDA QUE AL BUSCAR ME DEVUELVA ALGUN REGISTRO PARA MODIFICARLO
            if (grdDatos.Rows.Count > 0)
            {
                BaseBotonModificar.Visible = true;
                BaseBotonModificar.Enabled = true;
            }


        }
        public override void BaseBotonNuevoClick()
        {
            BaseBotonCancelar.Enabled = true;
            BaseBotonBuscar.Enabled = true;
            BaseBotonBuscar.Visible = true;
            BaseBotonGuardar.Enabled = true;
            BaseBotonGuardar.Visible = true;
            pnlControles.Enabled = true;
            grdDatos.DataSource = null;
            BaseMetodoLimpiaControles();
            base.BaseBotonNuevoClick();
        }
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtPrecio.Text.Length; i++)
            {
                if (txtPrecio.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }


            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;
        }
        private void BtnAgergar_Click(object sender, EventArgs e)
        {
            if (!BaseFuncionValidaciones())
                return;

            res = 0;
            msg = string.Empty;

            DateTime FechaInicial = DateTime.Today;
            FechaInicial = dtpInicial.Value;
            DateTime FechaFinal = DateTime.Today;
            FechaFinal = dtpFinal.Value;
            int CampoIdentity = 0;

            if (CbxTodas.Checked)
            {
                try
                {
                    res = PreciosSQL.In_Zonificacion_LocAsegu_Precios_Enfermeria_All(ref CampoIdentity, Convert.ToInt16(zonLE_Oficina1.K_Pais), Convert.ToInt32(zonLE_Oficina1.K_Estado),
                        Convert.ToInt16(zonLE_Oficina1.K_Ciudad), Convert.ToInt32(K_Precio_Enfermeria), Convert.ToInt16(zonLE_Oficina1.K_Oficina), 
                        Convert.ToDecimal(txtPrecio.Text), FechaInicial, FechaFinal, Convert.ToInt16(ucAseguradora1.K_Aseguradora), ref msg);
                }
                catch (Exception)
                {
                    MessageBox.Show("YA ESTA REGISTRADO EL PRECIO PARA LA CIUDAD CAPTURADA", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (res == -1)
                {
                    BaseErrorResultado = true;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    BaseErrorResultado = false;
                    MessageBox.Show("INFORMACION ACTUALIZADA CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BaseBotonBuscarClick();
                    BaseMetodoInicio();
                   // BaseMetodoLimpiaControles();
                }

            }
            else
            {

                try
                {
                    res = catalogosSQL.In_Zonificacion_LocAsegu_Precios_Enfermeria(ref CampoIdentity, Convert.ToInt16(zonLE_Oficina1.K_Pais), Convert.ToInt32(zonLE_Oficina1.K_Estado), 
                        Convert.ToInt16(zonLE_Oficina1.K_Ciudad), Convert.ToInt32(K_Precio_Enfermeria), Convert.ToInt16(zonLE_Oficina1.K_Oficina), zonLE_Oficina1.K_Colonia,
                        Convert.ToDecimal(txtPrecio.Text), FechaInicial, FechaFinal, Convert.ToInt16(ucAseguradora1.K_Aseguradora), ref msg);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("YA ESTA REGISTRADA LA COBERTURA PARA LA CIUDAD CAPTURADA", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (res == -1)
                {
                    BaseErrorResultado = true;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    BaseErrorResultado = false;
                    MessageBox.Show("INFORMACION ACTUALIZADA CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BaseBotonBuscarClick();
                    BaseMetodoInicio();
                   // BaseMetodoLimpiaControles();

                    //ME RECARGA EL GRID CON LO QUE SE ACABA DE GUARDAR

                }
            }
        }

        private void FRM_ZONIFICACION_LPENFERMERIA_ASEG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            {
                if (!BaseFuncionValidaciones())
                    return;

                res = 0;
                msg = string.Empty;

                DateTime FechaInicial = DateTime.Today;
                FechaInicial = dtpInicial.Value;
                DateTime FechaFinal = DateTime.Today;
                FechaFinal = dtpFinal.Value;
                int CampoIdentity = 0;
                try
                {
                    res = catalogosSQL.In_Zonificacion_LocAsegu_Precios_Enfermeria(ref CampoIdentity, Convert.ToInt16(zonLE_Oficina1.K_Pais), Convert.ToInt32(zonLE_Oficina1.K_Estado), Convert.ToInt16(zonLE_Oficina1.K_Ciudad), Convert.ToInt32(K_Precio_Enfermeria), Convert.ToInt16(zonLE_Oficina1.K_Oficina),zonLE_Oficina1.K_Colonia, Convert.ToDecimal(txtPrecio.Text), FechaInicial, FechaFinal, Convert.ToInt16(ucAseguradora1.K_Aseguradora), ref msg);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("YA ESTA REGISTRADA LA COBERTURA PARA LA CIUDAD CAPTURADA", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (res == -1)
                {
                    BaseErrorResultado = true;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    BaseErrorResultado = false;
                    MessageBox.Show("INFORMACION ACTUALIZADA CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BaseMetodoInicio();
                    BaseBotonBuscarClick();

                    //ME RECARGA EL GRID CON LO QUE SE ACABA DE GUARDAR

                }
            }

            if (e.KeyCode == Keys.F11)
            {

                DateTime FechaInicial = DateTime.Today;
                FechaInicial = dtpInicial.Value;
                DateTime FechaFinal = DateTime.Today;
                FechaFinal = dtpFinal.Value;


                K_Pais = zonLE_Oficina1.K_Pais;
                K_Ciudad = zonLE_Oficina1.K_Ciudad;
                K_Estado = zonLE_Oficina1.K_Estado;
                K_Oficina = zonLE_Oficina1.K_Oficina;
                K_Precio_Enfermeria = Convert.ToInt32(K_Precio_Enfermeria);
                K_Aseguradora = Convert.ToInt16(ucAseguradora1.K_Aseguradora);
                LLenarGrid(K_Pais, K_Estado, K_Ciudad, K_Precio_Enfermeria, K_Oficina,K_Colonia, FechaInicial, FechaFinal, K_Aseguradora);
                BaseBotonGuardar.Visible = false;

                //ME VALIDA QUE AL BUSCAR ME DEVUELVA ALGUN REGISTRO PARA MODIFICARLO
                if (grdDatos.Rows.Count > 0)
                {
                    BaseBotonModificar.Visible = true;
                    BaseBotonModificar.Enabled = true;
                }
            }
         

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            grdDatos.DataSource = null;
            BaseMetodoLimpiaControles();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            grdDatos.DataSource = null;
            BaseMetodoLimpiaControles();
        }

      
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DateTime FechaInicial = DateTime.Today;
            FechaInicial = dtpInicial.Value;
            DateTime FechaFinal = DateTime.Today;
            FechaFinal = dtpFinal.Value;


            K_Pais = zonLE_Oficina1.K_Pais;
            K_Ciudad = zonLE_Oficina1.K_Ciudad;
            K_Estado = zonLE_Oficina1.K_Estado;
            K_Oficina = zonLE_Oficina1.K_Oficina;
            K_Precio_Enfermeria = Convert.ToInt32(K_Precio_Enfermeria);
            K_Aseguradora = Convert.ToInt16(ucAseguradora1.K_Aseguradora);
            LLenarGrid(K_Pais, K_Estado, K_Ciudad, K_Precio_Enfermeria, K_Oficina,K_Colonia,FechaInicial, FechaFinal,K_Aseguradora);
            BaseBotonGuardar.Visible = false;

            //ME VALIDA QUE AL BUSCAR ME DEVUELVA ALGUN REGISTRO PARA MODIFICARLO
            if (grdDatos.Rows.Count > 0)
            {
                BaseBotonModificar.Visible = true;
                BaseBotonModificar.Enabled = true;
            }
        }
        public override void BaseMetodoLimpiaControles()
        {
            zonLE_Oficina1.K_Pais = 0;
            zonLE_Oficina1.K_Estado = 0;
            zonLE_Oficina1.K_Ciudad = 0;
            zonLE_Oficina1.K_Oficina = 0;
            zonLE_Oficina1.K_Colonia = 0;
            zonLE_Oficina1.txt_G_Pais.Text = string.Empty;
            zonLE_Oficina1.txt_G_Estado.Text = string.Empty;
            zonLE_Oficina1.txt_G_Ciudad.Text = string.Empty;
            zonLE_Oficina1.txt_G_Oficina.Text = string.Empty;
            zonLE_Oficina1.txt_G_Colonia.Text = string.Empty;
            ucAseguradora1.K_Aseguradora = 0;
            ucAseguradora1.txt_Z_Aseguradora.Text = string.Empty;
            txt_Caracteristicas.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            dtpInicial.Value = DateTime.Now;
            dtpFinal.Value = DateTime.Now;
            


        }
        public override void BaseBotonExcelClick()
        {
            if (BaseDtDatos == null)
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
                string Hoja = "Datos";
                DataTable dtExcel = datos;
                BorraColumnaCamposBusqueda(ref dtExcel);
                fx.ExportToExcel(dtExcel, saveFileDialog1.FileName, Hoja);
            }
        }
        public override void BaseBotonCancelarClick()
        {
            grdDatos.DataSource = null;
            BaseMetodoLimpiaControles();
        }
        public override void BaseBotonModificarClick()
        {

            BaseBotonGuardar.Enabled = false;
            K_Precio_Local_Enfermeria = int.Parse(grdDatos.CurrentRow.Cells["K_Precio_LocAsegu_Enfermeria"].Value.ToString());
            K_Pais = int.Parse(grdDatos.CurrentRow.Cells["K_Pais"].Value.ToString());
            K_Estado = int.Parse(grdDatos.CurrentRow.Cells["K_Estado"].Value.ToString());
            K_Ciudad = int.Parse(grdDatos.CurrentRow.Cells["K_Ciudad"].Value.ToString());
            K_Oficina = int.Parse(grdDatos.CurrentRow.Cells["K_Oficina"].Value.ToString());
            K_Precio_Enfermeria = int.Parse(grdDatos.CurrentRow.Cells["K_Precio_Enfermeria"].Value.ToString());
            D_Ciudad = grdDatos.CurrentRow.Cells["D_Ciudad"].Value.ToString();
            FechaInicial = Convert.ToDateTime(grdDatos.CurrentRow.Cells["F_Inicio_Vigencia"].Value.ToString());
            FechaFinal = Convert.ToDateTime(grdDatos.CurrentRow.Cells["F_Final"].Value.ToString());
            K_Aseguradora = int.Parse(grdDatos.CurrentRow.Cells["K_Aseguradora"].Value.ToString());
            FRM_ACTUALIZA_ZLP_ENFERMERIA_ASEG actualiza = new FRM_ACTUALIZA_ZLP_ENFERMERIA_ASEG(K_Precio_Local_Enfermeria, K_Pais, K_Ciudad, D_Ciudad, K_Estado, K_Oficina, K_Precio_Enfermeria, Convert.ToDecimal(grdDatos.CurrentRow.Cells["Precio"].Value.ToString()), FechaInicial, FechaFinal,K_Aseguradora);
            actualiza.ShowDialog(this);
            base.BaseBotonModificarClick();
            BaseBotonModificar.Visible = true;
            BaseBotonModificar.Enabled = true;
            grdDatos.DataSource = null;
            LLenarGrid(K_Pais, K_Estado, K_Ciudad, K_Precio_Enfermeria, K_Oficina,K_Colonia, FechaInicial, FechaFinal,K_Aseguradora);
        }
        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (zonLE_Oficina1.txt_G_Pais.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR PAIS...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                zonLE_Oficina1.txt_G_Pais.Focus();
                return false;
            }
            if (zonLE_Oficina1.txt_G_Estado.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR ESTADO..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                zonLE_Oficina1.txt_G_Estado.Focus();
                return false;
            }
            if (zonLE_Oficina1.txt_G_Ciudad.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR CIUDAD...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                zonLE_Oficina1.txt_G_Ciudad.Focus();
                return false;
            }
            if (zonLE_Oficina1.txt_G_Oficina.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR OFICINA..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                zonLE_Oficina1.Focus();
                return false;
            }
            if (txt_Caracteristicas.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LAS CARACTERISTICAS DE ENFERMERIA..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Caracteristicas.Focus();
                return false;
            }
            if (txtPrecio.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL PRECIO..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Caracteristicas.Focus();
                return false;
            }

            BaseErrorResultado = false;
            return true;
        }
    }
}
