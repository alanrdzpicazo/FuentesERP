﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;
using ProbeMedic.AppCode.DCC;
using System.Data.SqlClient;
using System.IO;

namespace ProbeMedic.CATALOGOS.ARTICULOS
{
    public partial class FRM_ARTICULOS: FormaCatalogo
    {
        DateTime FechaInicial = DateTime.Today;
        DateTime FechaFinal = DateTime.Today;

        public Int32 K_Contacto_Proveedor;
        int res = 0;
        string msg = string.Empty;
        SQLCatalogos sql_Catalogos = new SQLCatalogos();
        Funciones fx = new Funciones();

        public FRM_ARTICULOS()
        {
            InitializeComponent();
        }

        public override void BaseMetodoInicio()
        {
            txtFocus = txtClave; //Asignar el textbox que inicia el focus
            PNL.Enabled = false; //NO Borrar
            cbxActiva.Visible = false;


            BaseDtDatos = sql_Catalogos.Sk_Articulos(GlobalVar.K_Empresa);

            if ((GlobalVar.K_Empresa==1)||(GlobalVar.K_Empresa==9))
            {
                CbxVentaSOS.Visible = false;
                CbxEnRenta.Visible = false;
            }
            else
            {
                CbxVentaSOS.Visible = true;
                CbxEnRenta.Visible = true;
            }
 
            CatalogoPropiedadCampoClave = "K_Articulo";
            CatalogoPropiedadCampoDescripcion = "D_Articulo";
            base.BaseMetodoInicio();
            BaseBotonBuscar.Visible = true;
        }

        public override void CatalogoHabilitaPanelControles(bool B_Habilita)
        {
            label1.Enabled = B_Habilita;
            txtClave.Enabled = B_Habilita;
            PNL.Enabled = B_Habilita;
            pnlAdicionales.Enabled = B_Habilita;
        }

        public override void BaseMetodoLimpiaControles()
        {
            txtClave.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtNombreC.Text = string.Empty;
            ucTipoProducto1.txt_TP_D_Tipo_Producto.Text = string.Empty;
            ucTipoProducto1.K_Tipo_Producto = 0;
            ucClase1.txt_C_D_Clase.Text = string.Empty;
            ucClase1.K_Clase = 0;
            ucPresentacion1.txt_P_D_Presentacion.Text = string.Empty;
            ucPresentacion1.K_Presentacion = 0;
            ucFamiliaArticulo1.txt_FA_D_Familia_Articulo.Text = string.Empty;
            ucFamiliaArticulo1.K_Familia_Articulo = 0;
            ucLaboratorio1.txt_L_D_Laboratorio.Text = string.Empty;
            ucLaboratorio1.K_Laboratorio = 0;
            ucSustanciaActiva1.txt_SA_D_Sustancia_Activa.Text = string.Empty;
            ucSustanciaActiva1.K_Sustancia_Activa = 0;
            ucTipoMoneda1.txt_TP_D_Tipo_Moneda.Text = string.Empty;
            ucTipoMoneda1.K_Tipo_Moneda = 0;
            ucGrupoArticulo1.txt_GA_D_Grupo_Articulo.Text = string.Empty;
            ucGrupoArticulo1.K_Grupo_Articulo = 0;
            ucCategoriaArticulo1.txt_CA_D_Categoria_Articulo.Text = string.Empty;
            ucCategoriaArticulo1.K_Categoria_Articulo = 0;
            ucUnidadMedida1.txt_UM_D_Unidad_Medida.Text = string.Empty;
            ucUnidadMedida1.K_Unidad_Medida = 0;
            ucTemperatura1.txt_T_D_Temperatura.Text = string.Empty;
            ucTemperatura1.K_Temperatura = 0;
            cbxActiva.Checked = true;
            txtSKU.Text = string.Empty;
            //txtLOTE.Text = string.Empty;
            //dtpCaducidad.Value = DateTime.Now;
            ucIVA1.txt_IVA_D_TipoIVA.Text = string.Empty;
            ucIVA1.K_Tipo_Iva = 0;
            txtPrecioUnitario.Text = string.Empty;
            txtPrecioMax.Text = string.Empty;
            cbxInventario.Checked = false;
            cbxBBFS.Checked = false;
            cbxSolicitaLote.Checked = false;
            cbxRequiereAutorizacion.Checked = false;
            CbxVentaSOS.Checked = false;
            CbxEnRenta.Checked = false;
            cbxFragil.Checked = false;
            cbxRefrigerado.Checked = false;
            pbImagen.Image = null;
            ucClaveSAT1.K_Clave_SAT = 0;
            ucClaveSAT1.txt_D_Clave_SAT.Text = string.Empty;
            txt_lote.Text = string.Empty;
            dtp_fecha_caducidad.Value  = DateTime.Now;
            txtInvMin.Text = "0";
            txtInvMax.Text = "0";
            ucIeps1.K_Ieps = 0;
            ucIeps1.txt_E_Ieps.Text = string.Empty;

            //PNL.Enabled = false; //NO Borrar        
        }

        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();

            txtClave.Text = ren["K_Articulo"].ToString();
            txtNombre.Text = ren["D_Articulo"].ToString();
            txtNombreC.Text = ren["C_Articulo"].ToString();
            string cadena = ren["Imagen"].ToString();

            if (cadena != "")
            {
                // Convert Base64 String to byte[]
                byte[] imageBytes = Convert.FromBase64String(cadena);
                MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
                // Convert byte[] to Image
                ms.Write(imageBytes, 0, imageBytes.Length);
                Image image = Image.FromStream(ms, true);
                pbImagen.Image = image;
                pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            ucTipoProducto1.K_Tipo_Producto = Convert.ToInt32(ren["K_Tipo_Producto"].ToString());
            ucTipoProducto1.txt_TP_D_Tipo_Producto.Text = ren["D_Tipo_Producto"].ToString();
            ucClase1.K_Clase = Convert.ToInt32(ren["K_Clase"].ToString());
            ucClase1.txt_C_D_Clase.Text = ren["D_Clase"].ToString();
            ucPresentacion1.K_Presentacion = Convert.ToInt32(ren["K_Presentacion"].ToString());
            ucPresentacion1.txt_P_D_Presentacion.Text = ren["D_Presentacion"].ToString();
            ucFamiliaArticulo1.K_Familia_Articulo = Convert.ToInt32(ren["K_Familia_Articulo"].ToString());
            ucFamiliaArticulo1.txt_FA_D_Familia_Articulo.Text = ren["D_Familia"].ToString();
            //ucLaboratorio1.K_Laboratorio = Convert.ToInt32(ren["K_Laboratorio"].ToString());
            //ucLaboratorio1.txt_L_D_Laboratorio.Text = ren["D_Laboratorio"].ToString();
            ucSustanciaActiva1.K_Sustancia_Activa = Convert.ToInt32(ren["K_Sustancia_Activa"].ToString());

            if (ren["K_Laboratorio"].ToString() != DBNull.Value.ToString() || ren["K_Laboratorio"].ToString() != "")
            {
                ucLaboratorio1.K_Laboratorio = Convert.ToInt32(ren["K_Laboratorio"].ToString());
                ucLaboratorio1.txt_L_D_Laboratorio.Text = ren["D_Laboratorio"].ToString();
            }

            ucSustanciaActiva1.txt_SA_D_Sustancia_Activa.Text = ren["D_Sustancia_Activa"].ToString();
            ucTipoMoneda1.K_Tipo_Moneda = Convert.ToInt32(ren["K_Tipo_Moneda"].ToString());
            ucTipoMoneda1.txt_TP_D_Tipo_Moneda.Text = ren["D_Tipo_Moneda"].ToString();
            ucGrupoArticulo1.K_Grupo_Articulo = Convert.ToInt32(ren["K_Grupo_Articulo"].ToString());
            ucGrupoArticulo1.txt_GA_D_Grupo_Articulo.Text = ren["D_Grupo_Articulo"].ToString();
            ucCategoriaArticulo1.K_Categoria_Articulo = Convert.ToInt32(ren["K_Categoria_Articulo"].ToString());
            ucCategoriaArticulo1.txt_CA_D_Categoria_Articulo.Text = ren["D_Categoria_Articulo"].ToString();
            ucUnidadMedida1.K_Unidad_Medida = Convert.ToInt32(ren["K_Unidad_Medida"].ToString());
            ucUnidadMedida1.txt_UM_D_Unidad_Medida.Text = ren["D_Unidad_Medida"].ToString();
            ucTemperatura1.K_Temperatura = Convert.ToInt32(ren["K_Temperatura"].ToString());
            ucTemperatura1.txt_T_D_Temperatura.Text = ren["D_Temperatura"].ToString();
            cbxActiva.Checked = Convert.ToBoolean(ren["B_Activo"]);
            if (ren["SKU"].ToString() != DBNull.Value.ToString() || ren["SKU"].ToString() != "")
            {
                txtSKU.Text = ren["SKU"].ToString();
            }
            if (ren["K_Iva"].ToString() != "")
            {
                ucIVA1.K_Tipo_Iva = Convert.ToInt32(ren["K_Iva"].ToString());
                ucIVA1.txt_IVA_D_TipoIVA.Text = ren["D_Iva"].ToString();
            }
            txtPrecioUnitario.Text = ren["Precio_Unitario"].ToString();
            txtPrecioMax.Text = ren["Precio_Maximo_Publico"].ToString();
            cbxInventario.Checked = Convert.ToBoolean(ren["B_Requiere_Inventario"]);
            cbxBBFS.Checked = Convert.ToBoolean(ren["B_BFFS"]);
            cbxSolicitaLote.Checked = Convert.ToBoolean(ren["B_SolicitaCaducidad"]);
            cbxRequiereAutorizacion.Checked = Convert.ToBoolean(ren["B_Requiere_Autorizacion"]);
            CbxVentaSOS.Checked = Convert.ToBoolean(ren["B_VentaSOS"]);
            CbxEnRenta.Checked = Convert.ToBoolean(ren["B_EnRenta"]);
            cbxFragil.Checked = Convert.ToBoolean(ren["B_Fragil"]);
            cbxRefrigerado.Checked = Convert.ToBoolean(ren["B_Refrigerado"]);
            if (ren["K_Clave_SAT"].ToString() != "")
            {
                ucClaveSAT1.K_Clave_SAT = Convert.ToInt32(ren["K_Clave_SAT"].ToString());
                ucClaveSAT1.txt_D_Clave_SAT.Text = ren["D_Clave_SAT"].ToString();
            }            
            this.txt_lote.Text = ren["Lote"].ToString();

            txtInvMin.Text = ren["Inventario_Minimo"].ToString()!= "" ?ren["Inventario_Minimo"].ToString():"";
            txtInvMax.Text = ren["Inventario_Maximo"].ToString()!="" ? ren["Inventario_Maximo"].ToString():"";
            if (ren["K_Ieps"].ToString() != "")
            {
                ucIeps1.K_Ieps = Convert.ToInt32(ren["K_Ieps"].ToString());
                ucIeps1.txt_E_Ieps.Text = ren["D_Ieps"].ToString();
            }
        }

        public override void BaseBotonBorrarClick()
        {


            if (txtClave.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN REGISTRO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dlg = MessageBox.Show("SERA ELIMINADO EL REGISTRO CON VALOR:\n" + txtNombre.Text.Trim() + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                res = sql_Catalogos.Dl_Articulos(Convert.ToInt32(txtClave.Text), GlobalVar.K_Usuario, ref msg);
                if (res == -1)
                {
                    BaseErrorResultado = true;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    BaseErrorResultado = false;
                    MessageBox.Show("INFORMACION ELIMINADA CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BaseMetodoInicio();
                    BaseBotonCancelarClick();
                }

            }
        }

        public override void BaseBotonGuardarClick()
        {
            if (!BaseFuncionValidaciones())
                return;

            res = 0;
            msg = string.Empty;
            Int32 CampoIdentity = 0;

            DateTime Caducidad = DateTime.Today;
            PictureBox pb = this.pbImagen;

            if (CatalogoPropiedadEsRegistroNuevo) // Nuevo
            {
               res = sql_Catalogos.In_Articulos(ref CampoIdentity, txtNombre.Text, txtNombreC.Text, Convert.ToInt32(ucTipoProducto1.K_Tipo_Producto), Convert.ToInt32(ucClase1.K_Clase),
                   Convert.ToInt32(ucPresentacion1.K_Presentacion), Convert.ToInt32(ucFamiliaArticulo1.K_Familia_Articulo), Convert.ToInt32(ucLaboratorio1.K_Laboratorio),
                   Convert.ToInt32(ucSustanciaActiva1.K_Sustancia_Activa), Convert.ToInt32(ucTipoMoneda1.K_Tipo_Moneda), Convert.ToInt32(ucGrupoArticulo1.K_Grupo_Articulo),
                   Convert.ToInt32(ucIVA1.K_Tipo_Iva), Convert.ToInt32(ucCategoriaArticulo1.K_Categoria_Articulo), Convert.ToInt32(ucUnidadMedida1.K_Unidad_Medida),
                   Convert.ToInt32(ucTemperatura1.K_Temperatura), txtSKU.Text, Convert.ToDecimal(txtPrecioUnitario.Text), Convert.ToDecimal(txtPrecioMax.Text), cbxActiva.Checked,
                   cbxInventario.Checked, cbxBBFS.Checked, cbxSolicitaLote.Checked, cbxSolicitaCad.Checked, GlobalVar.K_Usuario, this.pbImagen, cbxRequiereAutorizacion.Checked,
                   CbxVentaSOS.Checked, CbxEnRenta.Checked, ucClaveSAT1.K_Clave_SAT, this.txt_lote.Text, txtInvMin.Text.Trim().Length > 0 ? Convert.ToInt32(this.txtInvMin.Text) : 0, txtInvMax.Text.Trim().Length > 0 ? Convert.ToInt32(this.txtInvMax.Text) : 0,
                   this.dtp_fecha_caducidad.Value, cbxRefrigerado.Checked, cbxFragil.Checked,ucIeps1.K_Ieps, ref msg);
            }

            else //Existe. Update
            {
                CampoIdentity = Convert.ToInt32(CatalogoPropiedadId_Identity);
                res = CatalogosSQL.Up_Articulos(Convert.ToInt32(txtClave.Text), txtNombre.Text, txtNombreC.Text, Convert.ToInt32(ucTipoProducto1.K_Tipo_Producto),
                    Convert.ToInt32(ucClase1.K_Clase), Convert.ToInt32(ucPresentacion1.K_Presentacion), Convert.ToInt32(ucFamiliaArticulo1.K_Familia_Articulo),
                    Convert.ToInt32(ucLaboratorio1.K_Laboratorio), Convert.ToInt32(ucSustanciaActiva1.K_Sustancia_Activa), Convert.ToInt32(ucTipoMoneda1.K_Tipo_Moneda),
                    Convert.ToInt32(ucGrupoArticulo1.K_Grupo_Articulo), Convert.ToInt32(ucIVA1.K_Tipo_Iva), Convert.ToInt32(ucCategoriaArticulo1.K_Categoria_Articulo),
                    Convert.ToInt32(ucUnidadMedida1.K_Unidad_Medida), Convert.ToInt32(ucTemperatura1.K_Temperatura), txtSKU.Text, Convert.ToDecimal(txtPrecioUnitario.Text),
                    Convert.ToDecimal(txtPrecioMax.Text), cbxActiva.Checked, cbxInventario.Checked, cbxBBFS.Checked, cbxSolicitaLote.Checked, cbxSolicitaCad.Checked,
                    GlobalVar.K_Usuario, this.pbImagen, cbxRequiereAutorizacion.Checked, CbxVentaSOS.Checked, CbxEnRenta.Checked, ucClaveSAT1.K_Clave_SAT, this.txt_lote.Text,
                    txtInvMin.Text.Trim().Length>0? Convert.ToInt32(this.txtInvMin.Text):0,  txtInvMax.Text.Trim().Length>0 ? Convert.ToInt32(this.txtInvMax.Text):0, this.dtp_fecha_caducidad.Value, cbxRefrigerado.Checked, cbxFragil.Checked,ucIeps1.K_Ieps,ref msg);
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
            }

        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (txtNombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL NOMBRE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }
            //if (txtNombreC.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("FALTA CAPTURAR EL NOMBRE CORTO ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtNombreC.Focus();
            //    return false;
            //}
            if (ucTipoProducto1.txt_TP_D_Tipo_Producto.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL TIPO DE ARTICULO ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucTipoProducto1.txt_TP_D_Tipo_Producto.Focus();
                return false;
            }
            if (ucClase1.txt_C_D_Clase.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA CLASIFICACION ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucClase1.txt_C_D_Clase.Focus();
                return false;
            }
            if (ucPresentacion1.txt_P_D_Presentacion.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA PRESENTACION...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucPresentacion1.txt_P_D_Presentacion.Focus();
                return false;

            }
            if (ucFamiliaArticulo1.txt_FA_D_Familia_Articulo.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA FAMILIA DEL ARTICULO ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucTipoProducto1.txt_TP_D_Tipo_Producto.Focus();
                return false;
            }
            if (ucLaboratorio1.txt_L_D_Laboratorio.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL LABORATORIO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucClase1.txt_C_D_Clase.Focus();
                return false;
            }
            if (ucSustanciaActiva1.txt_SA_D_Sustancia_Activa.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA SUSTANCIA ACTIVA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucSustanciaActiva1.txt_SA_D_Sustancia_Activa.Focus();
                return false;
            }
            if (ucTipoMoneda1.txt_TP_D_Tipo_Moneda.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL TIPO DE MONEDA ...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucTipoProducto1.txt_TP_D_Tipo_Producto.Focus();
                return false;
            }
            if (ucGrupoArticulo1.txt_GA_D_Grupo_Articulo.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL GRUPO DEL ARTICULO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucGrupoArticulo1.txt_GA_D_Grupo_Articulo.Focus();
                return false;
            }
            if (ucCategoriaArticulo1.txt_CA_D_Categoria_Articulo.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA CATEGORIA DEL ARTICULO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucCategoriaArticulo1.txt_CA_D_Categoria_Articulo.Focus();
                return false;
            }
            if (ucUnidadMedida1.txt_UM_D_Unidad_Medida.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA UNIDAD DE MEDIDA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucUnidadMedida1.txt_UM_D_Unidad_Medida.Focus();
                return false;
            }
            if (ucTemperatura1.txt_T_D_Temperatura.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA TEMPERATURA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucGrupoArticulo1.txt_GA_D_Grupo_Articulo.Focus();
                return false;
            }
            if (txtSKU.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL SKU...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSKU.Focus();
                return false;
            }
            //if (txt_inventario_max.Value == 0)
            //{
            //    MessageBox.Show("FALTA CAPTURAR EL INVENTARIO MAXIMO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txt_inventario_max.Focus();
            //    return false;
            //}
            //if (txt_inventario_min.Value == 0)
            //{
            //    MessageBox.Show("FALTA CAPTURAR EL INVENTARIO MINIMO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txt_inventario_min.Focus();
            //    return false;
            //}
            //if (txtLOTE.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("FALTA CAPTURAR EL LOTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtLOTE.Focus();
            //    return false;
            //}
            //if (ucIVA1.txt_IVA_D_TipoIVA.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("FALTA CAPTURAR EL TIPO DE IVA..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    ucIVA1.txt_IVA_D_TipoIVA.Focus();
            //    return false;
            //}
            if (txtPrecioUnitario.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL PRECIO UNITARIO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioUnitario.Focus();
                return false;
            }
            if (txtPrecioMax.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL PRECIO MAXIMO PUBLICO..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioMax.Focus();
                return false;
            }
            //if (pbImagen.Image == null)
            //{
            //    MessageBox.Show("FALTA CAPTURAR LA IMAGEN ..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtPrecioMax.Focus();
            //    return false;
            //}
            if((GlobalVar.K_Empresa ==10) && ((!CbxEnRenta.Checked)&&(!CbxVentaSOS.Checked)))
            {
                MessageBox.Show("FALTA SELECCIONAR SI EL ARTICULO ESTA EN RENTA Y/O EN VENTA..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (ucIeps1.K_Ieps == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL TIPO DE IEPS...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucIeps1.Focus();
                return false;
            }
            BaseErrorResultado = false;
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files(*.jpg) | *.jpg";
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                List<String> listaExtensiones = new List<string>() { ".jpg" };
                if (listaExtensiones.Contains(Path.GetExtension(dialog.FileName)))
                {
                    pbImagen.Image = Image.FromFile(dialog.FileName);
                }
                else
                {
                    MessageBox.Show("La extensión del archivo no es válido.");
                }
            }        
            
        }

        public byte[] StrToByteArray(string str)
        {
            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
            return encoding.GetBytes(str);

        }

        private void txtPrecioUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            fx.ValidaSeaNumero(ref e);
        }

        private void txtPrecioMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            fx.ValidaSeaNumero(ref e);
        }

        private void txt_inventario_min_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)13) == true ? true : false;

            if (e.KeyChar == (char)13 || e.KeyChar == (char)Keys.Tab)
            {
               
                this.GetNextControl(ActiveControl, true).Focus();
            }
        }

        private void txt_inventario_max_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)13) == true ? true : false;

            if (e.KeyChar == (char)13 || e.KeyChar == (char)Keys.Tab)
            {

                this.GetNextControl(ActiveControl, true).Focus();
            }
        }

        public override void BaseBotonBuscarClick()
        {
            FILTROS.Frm_Filtra_Articulo_Catalogo frm = new FILTROS.Frm_Filtra_Articulo_Catalogo();
            frm.ShowDialog();

            if (frm.dtFiltra != null)
            {
                if (frm.dtFiltra.Rows.Count > 0)
                {
                    BaseDtDatos = frm.dtFiltra;
                    CatalogoPropiedadCampoClave = "K_Articulo";
                    CatalogoPropiedadCampoDescripcion = "D_Articulo";
                    base.BaseMetodoInicio();
                    BaseBotonBuscar.Visible = true;
                }
            }       
        }

       
    }
}
