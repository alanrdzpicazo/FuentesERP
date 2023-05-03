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
namespace ProbeMedic.CATALOGOS
{
    public partial class FRM_ZONIFICACION_LOCAL_PRECIOS_AMBULANCIAS : FormaBase
    {
        SQLCatalogos catalogosSQL = new SQLCatalogos();
        SQLPrecios PreciosSQL = new SQLPrecios();

        Funciones fx = new Funciones();

        DataTable datos = new DataTable();

        int K_Precio_Local_Ambulancias=0, K_Pais = 0, K_Estado = 0, K_Ciudad = 0, K_Oficina = 0,K_Colonia=0, K_Precio_Ambulancia = 0;

        DateTime FechaInicial = DateTime.Today;

        DateTime FechaFinal = DateTime.Today;

        string D_Ciudad = string.Empty;

        int res = 0;

        string msg = string.Empty;

        public FRM_ZONIFICACION_LOCAL_PRECIOS_AMBULANCIAS()
        {
            InitializeComponent();
        }

        private void FRM_ZONIFICACION_LOCAL_PRECIOS_AMBULANCIAS_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarCaracteristicas_Click(object sender, EventArgs e)
        {
            BuscaCaracteristicas();
        }

        private void BuscaCaracteristicas()
        {
            GlobalVar.dtPreciosAmbulancia = catalogosSQL.Gp_Precios_Ambulancia();
            Busquedas.Frm_Busca_Caracteristicas frm = new Busquedas.Frm_Busca_Caracteristicas();
            frm.ShowDialog();
            K_Precio_Ambulancia = frm.LLave_Seleccionado;
            txt_Caracteristicas.Text = frm.Descripcion_Seleccionado;

        }

        public void LLenarGrid(int K_Pais, Int32 K_Estado, Int32 K_Ciudad, Int32 K_Precio_Ambulancia, int K_Oficina,int K_Colonia,DateTime FechaInicial,DateTime FechaFinal)
        {
            msg = string.Empty;
            datos = catalogosSQL.SK_Zonificacion_Local_Precios_Ambulancias(Convert.ToInt16(K_Pais), K_Estado, K_Ciudad, K_Precio_Ambulancia, K_Oficina,K_Colonia,FechaInicial, FechaFinal);

            if (datos != null)
            {
                grdDatos.DataSource = datos;
                grdDatos.Columns["D_Pais"].Visible = false;
                grdDatos.Columns["K_Pais"].Visible = false;
                grdDatos.Columns["K_Estado"].Visible = false;
                grdDatos.Columns["K_Ciudad"].Visible = false;
                grdDatos.Columns["K_Oficina"].Visible = false;
                grdDatos.Columns["K_Precio_Local_Ambulancia"].HeaderText = "Clave";
                grdDatos.Columns["K_Colonia"].Visible = false;
                grdDatos.Columns["D_Estado"].HeaderText = "Estado";
                grdDatos.Columns["D_Colonia"].HeaderText = "Colonia";
                grdDatos.Columns["D_Oficina"].HeaderText = "Oficina";
                grdDatos.Columns["D_Ciudad"].HeaderText = "Ciudad";
                grdDatos.Columns["K_Precio_Ambulancia"].Visible = false;
                grdDatos.Columns["B_Sencillo"].HeaderText = "Sencillo";
                grdDatos.Columns["B_Local"].HeaderText = "Local";
                grdDatos.Columns["B_Segundo_Piso"].HeaderText = "Segundo Piso";
                grdDatos.Columns["B_Oxigeno"].HeaderText = "Oxigeno";
                BaseBotonCancelar.Visible = true;
                BaseBotonCancelar.Enabled = true;
                grdDatos.Focus();

            }
            else
            {
                MessageBox.Show("NO SE ENCONTRO INFORMACION...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
      
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //bool IsDec = false;
            //int nroDec = 0;

            //for (int i = 0; i < txtPrecio.Text.Length; i++)
            //{
            //    if (txtPrecio.Text[i] == '.')
            //        IsDec = true;

            //    if (IsDec && nroDec++ >= 2)
            //    {
            //        e.Handled = true;
            //        return;
            //    }


            //}

            //if (e.KeyChar >= 48 && e.KeyChar <= 57)
            //    e.Handled = false;
            //else if (e.KeyChar == 46)
            //    e.Handled = (IsDec) ? true : false;
            //else
            //    e.Handled = true;
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 13)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 46)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!BaseFuncionValidaciones())
                return;

            res = 0;
            msg = string.Empty;

            DateTime FechaInicial = DateTime.Today;
            FechaInicial = dtpInicial.Value;
            DateTime FechaFinal = DateTime.Today;
            FechaFinal = dtpFinal.Value;

            if (CbxTodas.Checked)
            {
                try
                {
                    res = PreciosSQL.In_Zonificacion_Local_Precios_Amb_All(Convert.ToInt16(zonLA_Oficina1.K_Pais), Convert.ToInt32(zonLA_Oficina1.K_Estado),
                        Convert.ToInt16(zonLA_Oficina1.K_Ciudad), Convert.ToInt32(K_Precio_Ambulancia), Convert.ToInt16(zonLA_Oficina1.K_Oficina),
                        Convert.ToDecimal(txtPrecio.Text), FechaInicial, FechaFinal, ref msg);
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
                    BaseMetodoInicio();
                    BaseBotonBuscarClick();
                }

            }
            else
            {

                try
                {
                    res = catalogosSQL.In_Zonificacion_Local_Precios_Ambulancias(Convert.ToInt16(zonLA_Oficina1.K_Pais), Convert.ToInt32(zonLA_Oficina1.K_Estado), Convert.ToInt16(zonLA_Oficina1.K_Ciudad), Convert.ToInt32(K_Precio_Ambulancia), Convert.ToInt16(zonLA_Oficina1.K_Oficina), Convert.ToInt32(zonLA_Oficina1.K_Colonia), Convert.ToDecimal(txtPrecio.Text), FechaInicial, FechaFinal, ref msg);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "YA ESTA REGISTRADA LA COBERTURA PARA LA CIUDAD CAPPTURADA", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    BaseMetodoLimpiaControles();
                    //BaseBotonCancelarClick();

                    //ME RECARGA EL GRID CON LO QUE SE ACABA DE GUARDAR

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grdDatos.DataSource = null;
            DateTime FechaInicial = DateTime.Today;
            FechaInicial = dtpInicial.Value;
            DateTime FechaFinal = DateTime.Today;
            FechaFinal = dtpFinal.Value;


            K_Pais = zonLA_Oficina1.K_Pais;
            K_Estado = zonLA_Oficina1.K_Estado;
            K_Ciudad = zonLA_Oficina1.K_Ciudad;
            K_Oficina = zonLA_Oficina1.K_Oficina;
            K_Colonia = zonLA_Oficina1.K_Colonia;
            K_Precio_Ambulancia = Convert.ToInt32(K_Precio_Ambulancia);

            if (zonLA_Oficina1.txt_G_Ciudad.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR CIUDAD...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                zonLA_Oficina1.txt_G_Ciudad.Focus();
                return;
            }

            LLenarGrid(K_Pais, K_Estado, K_Ciudad, K_Precio_Ambulancia, K_Oficina,K_Colonia, FechaInicial, FechaFinal);
            BaseBotonGuardar.Visible = false;

            //ME VALIDA QUE AL BUSCAR ME DEVUELVA ALGUN REGISTRO PARA MODIFICARLO
            if (grdDatos.Rows.Count > 0)
            {
                BaseBotonModificar.Visible = true;
                BaseBotonModificar.Enabled = true;
            }
        }

        private void BtnAgergar_KeyDown(object sender, KeyEventArgs e)
        {
            


        }

        private void FRM_ZONIFICACION_LOCAL_PRECIOS_AMBULANCIAS_KeyDown(object sender, KeyEventArgs e)
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

                try
                {
                    res = catalogosSQL.In_Zonificacion_Local_Precios_Ambulancias(Convert.ToInt16(zonLA_Oficina1.K_Pais), Convert.ToInt32(zonLA_Oficina1.K_Estado), Convert.ToInt16(zonLA_Oficina1.K_Ciudad), Convert.ToInt32(K_Precio_Ambulancia), Convert.ToInt16(zonLA_Oficina1.K_Oficina),Convert.ToInt16(zonLA_Oficina1.K_Colonia), Convert.ToDecimal(txtPrecio.Text), FechaInicial, FechaFinal, ref msg);
                }
                catch (Exception)
                {
                    MessageBox.Show("YA ESTA REGISTRADA LA COBERTURA PARA LA CIUDAD CAPPTURADA", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    //BaseBotonCancelarClick();
                    BaseBotonBuscarClick();
                    //ME RECARGA EL GRID CON LO QUE SE ACABA DE GUARDAR

                }
            }

            if (e.KeyCode == Keys.F11)
            {

                grdDatos.DataSource = null;
                DateTime FechaInicial = DateTime.Today;
                FechaInicial = dtpInicial.Value;
                DateTime FechaFinal = DateTime.Today;
                FechaFinal = dtpFinal.Value;


                K_Pais = zonLA_Oficina1.K_Pais;
                K_Estado = zonLA_Oficina1.K_Estado;
                K_Ciudad = zonLA_Oficina1.K_Ciudad;
                K_Oficina = zonLA_Oficina1.K_Oficina;
                K_Precio_Ambulancia = Convert.ToInt32(K_Precio_Ambulancia);

                LLenarGrid(K_Pais, K_Estado, K_Ciudad, K_Precio_Ambulancia, K_Oficina,K_Colonia, FechaInicial, FechaFinal);
                BaseBotonGuardar.Visible = false;

                //ME VALIDA QUE AL BUSCAR ME DEVUELVA ALGUN REGISTRO PARA MODIFICARLO
                if (grdDatos.Rows.Count > 0)
                {
                    BaseBotonModificar.Visible = true;
                    BaseBotonModificar.Enabled = true;
                }
            }

        }

        public override void BaseMetodoLimpiaControles()
        {
            zonLA_Oficina1.K_Pais = 0;
            zonLA_Oficina1.txt_G_Pais.Text = string.Empty;
            zonLA_Oficina1.K_Estado = 0;
            zonLA_Oficina1.txt_G_Estado.Text = string.Empty;
            zonLA_Oficina1.K_Ciudad = 0;
            zonLA_Oficina1.txt_G_Ciudad.Text = string.Empty;
            zonLA_Oficina1.K_Oficina = 0;
            zonLA_Oficina1.txt_G_Oficina.Text = string.Empty;
            zonLA_Oficina1.K_Colonia = 0;
            zonLA_Oficina1.txt_G_Colonia.Text = string.Empty;
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
            K_Precio_Local_Ambulancias = int.Parse(grdDatos.CurrentRow.Cells["K_Precio_Local_Ambulancia"].Value.ToString());
            K_Pais = int.Parse(grdDatos.CurrentRow.Cells["K_Pais"].Value.ToString());
            K_Estado = int.Parse(grdDatos.CurrentRow.Cells["K_Estado"].Value.ToString());
            K_Ciudad = int.Parse(grdDatos.CurrentRow.Cells["K_Ciudad"].Value.ToString());
            K_Colonia = int.Parse(grdDatos.CurrentRow.Cells["K_Colonia"].Value.ToString());
            K_Oficina = int.Parse(grdDatos.CurrentRow.Cells["K_Oficina"].Value.ToString());
            K_Precio_Ambulancia = int.Parse(grdDatos.CurrentRow.Cells["K_Precio_Ambulancia"].Value.ToString());
            D_Ciudad = grdDatos.CurrentRow.Cells["D_Ciudad"].Value.ToString();
            FechaInicial = Convert.ToDateTime(grdDatos.CurrentRow.Cells["F_Inicio"].Value.ToString());
            FechaFinal = Convert.ToDateTime(grdDatos.CurrentRow.Cells["F_Final"].Value.ToString());
            FRM_ACTUALIZA_ZONIFICACION_LOCAL_PRECIOS_AMBULANCIA actualiza = new FRM_ACTUALIZA_ZONIFICACION_LOCAL_PRECIOS_AMBULANCIA(K_Precio_Local_Ambulancias,K_Pais, K_Ciudad, D_Ciudad, K_Estado, K_Oficina, K_Precio_Ambulancia, K_Colonia, Convert.ToDecimal(grdDatos.CurrentRow.Cells["Precio"].Value.ToString()), FechaInicial, FechaFinal);
            actualiza.ShowDialog(this);
            base.BaseBotonModificarClick();
            BaseBotonModificar.Visible = true;
            BaseBotonModificar.Enabled = true;
            grdDatos.DataSource = null;
            LLenarGrid(K_Pais, K_Estado, K_Ciudad, K_Precio_Ambulancia, K_Oficina,K_Colonia, FechaInicial, FechaFinal);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            grdDatos.DataSource = null;
            BaseMetodoLimpiaControles();
    
        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (zonLA_Oficina1.txt_G_Pais.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR PAIS...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                zonLA_Oficina1.txt_G_Pais.Focus();
                return false;
            }
            if (zonLA_Oficina1.txt_G_Estado.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR ESTADO..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                zonLA_Oficina1.txt_G_Estado.Focus();
                return false;
            }
            if (zonLA_Oficina1.txt_G_Ciudad.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR CIUDAD...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                zonLA_Oficina1.txt_G_Ciudad.Focus();
                return false;
            }
            if (zonLA_Oficina1.txt_G_Oficina.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR OFICINA..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                zonLA_Oficina1.Focus();
                return false;
            }
            if (txt_Caracteristicas.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LAS CARACTERISTICAS DE LA AMBULANCIA..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        public override void BaseMetodoInicio()
        {
            BaseMetodoRecarga();
            BaseBotonModificar.Visible = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonReporte.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonCancelar.Enabled = false;
            BaseBotonGuardar.Enabled = false;


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

            try
            {
                res = catalogosSQL.In_Zonificacion_Local_Precios_Ambulancias(Convert.ToInt16(zonLA_Oficina1.K_Pais), Convert.ToInt32(zonLA_Oficina1.K_Estado), Convert.ToInt16(zonLA_Oficina1.K_Ciudad), Convert.ToInt32(K_Precio_Ambulancia), Convert.ToInt16(zonLA_Oficina1.K_Oficina), Convert.ToInt16(zonLA_Oficina1.K_Colonia), Convert.ToDecimal(txtPrecio.Text), FechaInicial, FechaFinal, ref msg);
            }
            catch (Exception)
            {
                MessageBox.Show("YA ESTA REGISTRADA LA COBERTURA PARA LA CIUDAD CAPPTURADA", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                BaseBotonCancelarClick();

                //ME RECARGA EL GRID CON LO QUE SE ACABA DE GUARDAR

            }

        }

        public override void BaseBotonBuscarClick()
        {

            DateTime FechaInicial = DateTime.Today;
            FechaInicial = dtpInicial.Value;
            DateTime FechaFinal = DateTime.Today;
            FechaFinal = dtpFinal.Value;


            K_Pais = zonLA_Oficina1.K_Pais;
            K_Estado = zonLA_Oficina1.K_Estado;
            K_Ciudad = zonLA_Oficina1.K_Ciudad;
            K_Oficina = zonLA_Oficina1.K_Oficina;
            K_Precio_Ambulancia = Convert.ToInt32(K_Precio_Ambulancia);

            LLenarGrid(K_Pais, K_Estado, K_Ciudad, K_Precio_Ambulancia, K_Oficina,K_Colonia, FechaInicial, FechaFinal);
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

            BaseBotonBuscar.Enabled = true;
            BaseBotonBuscar.Visible = true;
            BaseBotonGuardar.Enabled = true;
            BaseBotonGuardar.Visible = true;
            pnlControles.Enabled = true;
            BaseMetodoLimpiaControles();
            base.BaseBotonNuevoClick();
        }



    }


}       

      

    

