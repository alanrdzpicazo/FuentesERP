﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;
using System.Configuration;
using System.IO;

namespace ProbeMedic.COMPRAS
{
    public partial class Frm_Requisicion : FormaBase
    {
        int res = 0;
        string msg = string.Empty;

        Funciones fx = new Funciones();
        SQLCatalogos sQLCatalogos = new SQLCatalogos();
        SQLCompras sqlCompras = new SQLCompras();
        SQLRecepcion sQLRecepcion = new SQLRecepcion();

        int KArticulo = 0, K_Requisicion_Modifica = 0, K_Iva = 0, K_Ieps = 0;
        int K_Almacen = 0;
        decimal PArticulo = 0;
        decimal Porcentaje= 0;
        decimal PorcentajeIEPS = 0;

        DataTable dtDatos = new DataTable();
        DataTable dtValida = new DataTable();
        DataTable dtRequisiciones = new DataTable();
        DataTable dtAlmacen = new DataTable();

        bool B_NoEntrar;
        String strKeyPress = "";

        public Frm_Requisicion()
        {
            BaseGridSinFormato = true;
            InitializeComponent();
        }

        public override void BaseMetodoInicio()
        {
            BaseMetodoRecarga();
            BaseBotonReporte.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonAfectar.Visible = false;

            BaseBotonCancelar.Text = "Limpiar";
            BaseBotonCancelar.ToolTipText = "Limpiar Datos Capturados en Pantalla";

            BaseBotonBorrar.Text = "Cancelar";
            BaseBotonBorrar.ToolTipText = "Cancelar Requisición...!";

            grdDetalle.AutoGenerateColumns = false;
            grdDetalle.Columns[4].ReadOnly = true;
            gvDetalleRequisicionPendiente.AutoGenerateColumns = false;
            grdRequisiciones.AutoGenerateColumns = false;

            BaseErrorResultado = true;
            BaseBotonModificar.Enabled = false;
            LblUnidadMedida.Text = "";
            tcControl.SelectTab(tpPendientes);
            
            BaseEtiquetaEstatus.Visible = false;
            cbxAlmacen.Focus();

            dtRequisiciones = sqlCompras.Sk_Requisicion(GlobalVar.K_Usuario);
            BasePropiedadCampoClave = "K_Requisicion";       
            BaseDtDatos = dtRequisiciones;
            dtDatos = DetalleRequisicion_Type;
            //dtDatos.Columns.Add("D_Articulo", typeof(string));
                            
            LlenaRequisiciones();
            CargaTiposRequisicion();
            CargaAlmacenes();
            AddButtonColumn();

            base.BaseMetodoInicio();
        }

        public override void BaseBotonNuevoClick()
        {
            grdRequisiciones.ClearSelection();
            tcControl.SelectTab(tpDetalle);
            pnlRequisiciones.Enabled = false;
            pnlEncabezado.Enabled = true;
            pnlDetalle.Enabled = true;
            BaseBotonModificar.Enabled = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonAfectar.Enabled = false;

            BasePropiedadEsRegistroNuevo = true;
            BasePropiedadId_Identity = 0;
            BasePropiedadB_Agregando = true;
            BasePropiedadB_Editando = false;

            txtObservaciones.Text = string.Empty;
            txtArticulo.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            txtDetalles.Text = string.Empty;
            txtSubtotal.Text = "0.0000";
            txtDescuento.Text = "0.0000";
            txtIEPS.Text = "0.0000";
            txtIVA.Text = "0.0000";
            txtTotal.Text = "0.0000";
    
            cbxTipoRequisicion.SelectedValue = 1;
            cbxAlmacen.SelectedValue = 0;

            grdDetalle.DataSource = null;
            grdDetalle.DataSource = null;
            dtDatos.Rows.Clear();

            cbxAlmacen.Focus();



        
        }

        public override void BaseBotonAfectarClick()
        {
            if (BasePropiedadId_Identity == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA REQUISICION...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dlg = MessageBox.Show("SERA AUTORIZADA LA REQUISICION CON FOLIO: " + BasePropiedadId_Identity.ToString() + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                res = sqlCompras.Gp_ApruebaCancelaRequisicion(BasePropiedadId_Identity, GlobalVar.K_Usuario, true, false, 1, "", ref msg);

                if (res == -1)
                {
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    MessageBox.Show("SE AUTORIZÓ LA REQUISICIÓN CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BaseMetodoInicio();
                    BaseBotonCancelarClick();
                }

            }
        }

        public override void BaseBotonModificarClick()
        {
            grdRequisiciones.ClearSelection();
            tcControl.SelectTab(tpDetalle);
            pnlRequisiciones.Enabled = false;
            pnlEncabezado.Enabled = true;
            pnlDetalle.Enabled = true;
            BaseBotonModificar.Enabled = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonAfectar.Enabled = false;
            DataGridViewRow row = grdRequisiciones.CurrentRow;
            if (row != null)
            {
                K_Requisicion_Modifica = Convert.ToInt32(row.Cells[0].Value);
            }
            BasePropiedadId_Identity = K_Requisicion_Modifica;
            BasePropiedadEsRegistroNuevo = false;
            BasePropiedadB_Agregando = false;
            BasePropiedadB_Editando = true;
            ObtieneInfoReq(K_Requisicion_Modifica);
            btnBuscarArticulos.Focus();
        }

        public override void BaseBotonGuardarClick()
        {
            if (!BaseFuncionValidaciones())
                return;
            grdDetalle.EndEdit();
            res = 0;
            msg = string.Empty;
            int CampoIdentity = 0;
            DataTable dtDetalle = null;
            dtDetalle = dtDatos.Copy();
            dtDetalle.Columns.Remove("D_Articulo");
            dtDetalle.Columns.Remove("UMedida");
            // dtDetalle.Columns.Remove("D_Tipo_Empaque");

            if (BasePropiedadEsRegistroNuevo) // Nuevo
            {
                res = sqlCompras.Gp_InsertaRequisicion(ref CampoIdentity, GlobalVar.K_Oficina, Convert.ToInt16(cbxAlmacen.SelectedValue), Convert.ToInt16(cbxTipoRequisicion.SelectedValue), GlobalVar.K_Usuario, Convert.ToDecimal(txtTotal.Text), txtObservaciones.Text, dtDetalle, ref msg);
                if (res == 0)
                {
                    msg = "REQUISICION GENERADA CORRECTAMENTE CON FOLIO...: " + CampoIdentity.ToString().Trim();
                }
                Calcula();
            }
            else //Existe. Update
            {
                CampoIdentity = Convert.ToInt32(BasePropiedadId_Identity);
                res = sqlCompras.Gp_ActualizaRequisicion(CampoIdentity, GlobalVar.K_Oficina, GlobalVar.K_Usuario, txtObservaciones.Text, Convert.ToDecimal(txtTotal.Text), dtDetalle, ref msg);
                if (res == 0)
                {
                    msg = "REQUISICION ACTUALIZADA CORRECTAMENTE CON FOLIO...: " + CampoIdentity.ToString().Trim();
                }
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
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BaseMetodoInicio();
                BaseBotonCancelarClick();
            }

        }

        public override void BaseBotonBorrarClick()
        {
            if (BasePropiedadId_Identity == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA REQUISICION...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dlg = MessageBox.Show("SERA CANCELADA LA REQUISICION CON FOLIO: " + BasePropiedadId_Identity.ToString() + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                res = sqlCompras.Gp_ApruebaCancelaRequisicion(BasePropiedadId_Identity, GlobalVar.K_Usuario, false, true, 1, "", ref msg);

                if (res == -1)
                {
                    BaseErrorResultado = true;
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    BaseErrorResultado = false;

                    //Enviar Correo al usuario que realiza requisición:                    
                    DataTable dt = new DataTable();
                    var resul = from c in dtRequisiciones.AsEnumerable()
                                select c;
                    resul = resul.Where(o => o.Field<int>("K_Requisicion") == BasePropiedadId_Identity);
                    if (resul.Any())
                        dt = resul.CopyToDataTable();


                    string Correo = string.Empty;
                    if (dt.Rows[0]["E_MailRequiere"] != null)
                        Correo = dt.Rows[0]["E_MailRequiere"].ToString().Trim();

                    if (Correo.Trim().Length > 0)
                    {
                        /*  string Asunto = "Productos Eiffel, Cancelación de Requisición No. " + BasePropiedadId_Identity.ToString().Trim();
                          string CorreoDe = ConfigurationManager.AppSettings["CorreoDe"].ToString();
                          string Cuerpo = fx.CuerpoCorreoHTML("Se notifica que la requisición que usted solicito ha sido cancelada.");
                          string Recursos = "logo";
                          string Archivos = Path.Combine(GlobalVar.rutaExe, "Imagenes/LogoEiffel.png"); //+ "," + Path.Combine(GlobalVar.rutaExe, "Imagenes/Bottom.png");
                          string Adjuntos = "";

                          fx.EnviaCorreo(CorreoDe, Correo, Asunto, "Requisición Cancelada", Cuerpo, Adjuntos, Archivos, Recursos,"",false); */

                    }



                    MessageBox.Show("SE CANCELÓ LA REQUISICIÓN CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BaseMetodoInicio();
                    BaseBotonCancelarClick();
                }

            }
        }

        public override void BaseBotonCancelarClick()
        {
            tcControl.SelectTab(tpPendientes);
            pnlRequisiciones.Enabled = true;
            grdDetalle.DataSource = null;
            gvDetalleRequisicionPendiente.DataSource = null;
            BaseBotonModificar.Enabled = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonAfectar.Enabled = false;
            BaseMetodoLimpiaControles();
            BasePropiedadB_Agregando = false;
            BasePropiedadB_Editando = false;
            BasePropiedadId_Identity = 0;
            grdRequisiciones.ClearSelection();
        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (Convert.ToInt32(cbxTipoRequisicion.SelectedValue) == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR TIPO DE REQUISICION...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxTipoRequisicion.Focus();
                return false;
            }

            if (Convert.ToInt32(cbxAlmacen.SelectedValue) == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR ALMACEN...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxAlmacen.Focus();
                return false;
            }
            if (grdDetalle.Rows.Count == 0)
            {
                MessageBox.Show("DEBE AGREGAR AL MENOS UN ARTICULO A LA REQUISICION...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscarArticulos.Focus();
                return false;
            }
            for (int i = 0; i <= grdDetalle.Rows.Count - 1; i++)
            {
                if (((DataGridView)grdDetalle).CurrentCell.GetEditedFormattedValue(i, DataGridViewDataErrorContexts.Display).ToString() == "")
                {
                    MessageBox.Show("DEBE ESPECIFICAR UN VALOR PARA CANTIDAD Y ESTE SER MAYOR A CERO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (((DataGridView)grdDetalle).CurrentCell.GetEditedFormattedValue(i, DataGridViewDataErrorContexts.Display).ToString() == "0")
                {
                    MessageBox.Show("DEBE ESPECIFICAR UN VALOR PARA CANTIDAD MAYOR A CERO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            BaseErrorResultado = false;
            return true;
        }

        public override void BaseMetodoLimpiaControles()
        {
            pnlEncabezado.Enabled = false;
            pnlDetalle.Enabled = false;            
            txtObservaciones.Text = string.Empty;
            txtArticulo.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            txtDetalles.Text = string.Empty;
            cbxTipoRequisicion.SelectedValue = 1;
            cbxAlmacen.SelectedValue = 0;
            grdDetalle.DataSource = null;
            KArticulo = 0;

            txtSubtotal.Text = "0.0000";
            txtDescuento.Text = "0.0000";
            txtIEPS.Text = "0.0000";
            txtIVA.Text = "0.0000";
            txtTotal.Text = "0.0000";
        }

        public override void BaseMetodoRecarga()
        {
            GlobalVar.dtTipoRequisicion = sqlCatalogos.Sk_Tipo_Requisicion();
            base.BaseMetodoRecarga();
        }

        private void LlenaRequisiciones()
        {
            DataTable dt = new DataTable();
            try
            {
                if (dtRequisiciones != null)
                {
                    var res = from c in dtRequisiciones.AsEnumerable()
                              select c;
                    res = res.Where(o => o.Field<int>("K_Oficina_Requiere") == GlobalVar.K_Oficina && o.Field<int>("K_Estatus_Compra") == 1 && o.Field<bool>("B_Cancelada") == false);
                    if (res.Any())
                    {
                        dt = res.CopyToDataTable();
                    }
                }
            }
            finally
            {
                grdRequisiciones.DataSource = dt;
                BaseDtDatos = dt;
            }
        }

        private void btnBuscarArticulos_Click(object sender, EventArgs e)
        {        
            FILTROS.Frm_Filtro_Articulo frm = new FILTROS.Frm_Filtro_Articulo();
            frm.ShowDialog();

            KArticulo = frm.LLave_Seleccionado;
            txtArticulo.Text = frm.Descripcion_Seleccionado;
            PArticulo = frm.Precio;
            K_Iva = frm.K_Iva_Seleccionado;
            Porcentaje = frm.IVA;
            K_Ieps = frm.K_Ieps_Seleccionado;
            PorcentajeIEPS = frm.IEPS;
            LblUnidadMedida.Text = frm.Unidad_Medida;

            txtCantidad.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtArticulo.Text.Trim().Length == 0)
            {
                MessageBox.Show("SELECCIONE UN ARTICULO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtArticulo.Focus();
                return;
            }
            if (txtCantidad.Text.Trim().Length == 0)
            {
                MessageBox.Show("CAPTURE LA CANTIDAD", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCantidad.Focus();
                return;
            }
            //if (PArticulo == 0)
            //{
            //    MessageBox.Show("CAPTURE EL PRECIO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtCantidad.Focus();
            //    return;
            //}
            //int PuntoReOrden = 0;
            //dtValida = sQLRecepcion.Gp_Valida_PuntoReOrden(KArticulo, Convert.ToInt32(txtCantidad.Text), PuntoReOrden);

            //DataRow row = dtValida.Rows[0];

            // 11/ENERO/2019
            /* POR EL MOMENTO SE DEJARA COMENTARIZADA ESTA PARTE
             * DESPUES SE VOLVERA A ESTABLECER */

            //PuntoReOrden = Convert.ToInt32(row["Punto_ReOrden"].ToString());

            //if (PuntoReOrden < 0)
            //{
            //    MsgBox msgbox = new MsgBox();
            //    msgbox.Show("EL ARTICULO EXCEDE EL INVENTARIO MAXIMO", "ERROR");
            //    txtCantidad.Focus();
            //}8184600716
          
            int Consecutivo = 1;
            DataRow dr;
            dr = dtDatos.NewRow();

            if (dtDatos.Rows.Count > 0)
            {
                var maxVal = dtDatos.AsEnumerable()
                        .Max(r => r.Field<int>("K_Detalle_Requisicion"));
                Consecutivo = Convert.ToInt32(maxVal) + 1;
            }
           
            dr["K_Detalle_Requisicion"] = Consecutivo;
            dr["K_Articulo"] = KArticulo;
            dr["D_Articulo"] = txtArticulo.Text;
            dr["CantidadRequerida"] = Convert.ToDecimal(txtCantidad.Text);
            dr["UMedida"] = LblUnidadMedida.Text;
            dr["Unitario"] = PArticulo;
            dr["SubTotal"] = PArticulo * Convert.ToDecimal(txtCantidad.Text);
            dr["PrecioTotal"] = (PArticulo * Convert.ToDecimal(txtCantidad.Text))  +
               ( Convert.ToDecimal(txtCantidad.Text) * (PArticulo * (Porcentaje / 100) ) ) +
               ( Convert.ToDecimal(txtCantidad.Text) * (PArticulo * (PorcentajeIEPS / 100)));
            dr["IVA"] = Convert.ToDecimal(txtCantidad.Text) * (PArticulo*(Porcentaje/100));
            dr["ObservacionesDetalle"] = txtDetalles.Text;
            dr["K_Iva"] = K_Iva;
            dr["K_Ieps"] = K_Ieps;
            dr["IEPS"] = Convert.ToDecimal(txtCantidad.Text) * (PArticulo * (PorcentajeIEPS / 100));
            if (ChecaMismoArticulo(dtDatos, KArticulo))
            {
                MessageBox.Show("YA EXISTE AGREGADO EL ARTÍCULO " + txtArticulo.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
                dtDatos.Rows.Add(dr);
  
            grdDetalle.DataSource = dtDatos;

            txtArticulo.Text = string.Empty;
            txtDetalles.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            KArticulo = 0;
            LblUnidadMedida.Text = "";
            Porcentaje = 0;
            K_Iva = 0;
            PorcentajeIEPS = 0;
            K_Ieps = 0;
            PArticulo = 0;
            Calcula();
            btnBuscarArticulos.Focus();
        }

        private void grdRequisiciones_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = grdRequisiciones.CurrentRow;
            if (row != null)
            {
                FiltraRenglon(row.Cells[0].Value.ToString());

                BasePropiedadId_Identity = Convert.ToInt32(row.Cells[0].Value);                
            }
        }

        private void FiltraRenglon(string clave)
        {            
            string ClaveFiltro = string.Empty;

            BasedtDatosConFiltro = BaseDtDatos;
            ClaveFiltro = BasePropiedadCampoClave;
            Type tipo = BasedtDatosConFiltro.Columns[ClaveFiltro].DataType;
            EnumerableRowCollection<DataRow> ren;
            if (tipo == typeof(Int16))
                ren = BasedtDatosConFiltro.AsEnumerable().Where(p => p.Field<Int16>(ClaveFiltro) == Convert.ToInt32(clave));
            else
            {
                if (tipo == typeof(int))
                    ren = BasedtDatosConFiltro.AsEnumerable().Where(p => p.Field<int>(ClaveFiltro) == Convert.ToInt32(clave));
                else
                    ren = BasedtDatosConFiltro.AsEnumerable().Where(p => p.Field<string>(ClaveFiltro) == clave);
            }
            if (ren.Any())
            {
                BaseBotonModificar.Enabled = true;
                BaseBotonBorrar.Enabled = true;
                BaseBotonAfectar.Enabled = true;
                MetodoLlenaControles(ren.CopyToDataTable().Rows[0]);
            }
        }

        private void MetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();

            cbxTipoRequisicion.SelectedValue = Convert.ToInt32(ren["K_Tipo_Requisicion"]);
            cbxAlmacen.SelectedValue = Convert.ToInt32(ren["K_Almacen"]);
            txtObservaciones.Text = ren["Observaciones"].ToString();
            BasePropiedadId_Identity = Convert.ToInt32(ren["K_Requisicion"]);

            dtDatos = DetalleRequisicion_Type;
            //dtDatos.Columns.Add("D_Articulo", typeof(string));
            DataTable dtDetalle = sqlCompras.Sk_RequisicionDetalle(BasePropiedadId_Identity);

            //if(dtDetalle!=null)
            //{
            //    if(dtDetalle.Rows.Count>0)
            //    {
            //        if (grdDetalle.ReadOnly)
            //            grdDetalle.ReadOnly = false;

            //        if (grdDetalle.Columns[4].ReadOnly)
            //            grdDetalle.Columns[4].ReadOnly = false;
            //    }
            //}


            DataRow dr;
            foreach (DataRow row in dtDetalle.Rows)
            {
                dr = dtDatos.NewRow();
                
                dr["K_Detalle_Requisicion"] = row["K_Detalle_Requisicion"];
                dr["K_Articulo"] = row["K_Articulo"];
                dr["D_Articulo"] = row["D_Articulo"];
                dr["CantidadRequerida"] = row["CantidadRequerida"];
                dr["UMedida"] = row["D_Unidad_Medida"];
                dr["IVA"] = row["IVA"];
                dr["SubTotal"] = row["SubTotal"];
                dr["Unitario"] = row["Unitario"];
                dr["PrecioTotal"] = row["PrecioTotal"];
                dr["ObservacionesDetalle"] = row["ObservacionesDetalle"];
                dr["IEPS"] = row["IEPS"];
                dtDatos.Rows.Add(dr);
                B_NoEntrar = true;
                //dtDatos.ImportRow(row);
            }
            
            grdDetalle.DataSource = dtDatos;

            grdDetalle.EditMode = DataGridViewEditMode.EditOnEnter;
            grdDetalle.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            grdDetalle.MultiSelect = false;
            grdDetalle.Columns[4].ReadOnly = false;

            gvDetalleRequisicionPendiente.DataSource = dtDetalle;
        }

        private void grdRequisiciones_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = grdRequisiciones.CurrentRow;
            if (row != null)
            {
                FiltraRenglon(row.Cells[0].Value.ToString());

                BasePropiedadId_Identity = Convert.ToInt32(row.Cells[0].Value);
            }
        }

        private void grdDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
       {
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow row = grdDetalle.CurrentRow;
                if (row != null)
                {
                    int K_Detalle_Requisicion = Convert.ToInt32(row.Cells[1].Value);

                    DataRow ren = dtDatos.AsEnumerable().Where(p => p.Field<int>("K_Detalle_Requisicion") == K_Detalle_Requisicion).FirstOrDefault();
                    if(ren != null)
                        dtDatos.Rows.Remove(ren);

                    Calcula();               
                }
            }

        }

        private void grdRequisiciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BaseBotonModificar.Enabled = true;           
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))
            {
                e.Handled = false;
            }
            else
            {

                e.Handled = true;
            }
        }

        private void ObtieneInfoReq(int K_Req_Mod)
        {
            dtRequisiciones = sqlCompras.Sk_Requisicion_Mod(K_Req_Mod);

            DataRow row = dtRequisiciones.Rows[0];

            txtObservaciones.Text = row["Observaciones"].ToString();
            cbxTipoRequisicion.Text = row["D_Tipo_Requisicion"].ToString();
            cbxAlmacen.Text = row["D_Almacen"].ToString();
            decimal total = Convert.ToDecimal(row["TotalRequisicion"]);
            total = Math.Round(total, 2);
            txtTotal.Text = total.ToString();
           
            dtDatos = DetalleRequisicion_Type;
          
            DataTable dtDetalle = sqlCompras.Sk_RequisicionDetalle(K_Requisicion_Modifica);
            DataRow dr;

            foreach (DataRow Drow in dtDetalle.Rows)
            {
               dr = dtDatos.NewRow();
               dr["K_Detalle_Requisicion"] = Drow["K_Detalle_Requisicion"];
               dr["K_Articulo"] = Drow["K_Articulo"];
               dr["D_Articulo"] = Drow["D_Articulo"];
               dr["CantidadRequerida"] = Drow["CantidadRequerida"];
               dr["UMedida"] = Drow["D_Unidad_Medida"];
               dr["Unitario"] = Drow["Unitario"];
               dr["IVA"] = Drow["IVA"];
               dr["SubTotal"] = Drow["SubTotal"];
               dr["PrecioTotal"] = Drow["PrecioTotal"];
               dr["ObservacionesDetalle"] = Drow["ObservacionesDetalle"];
               dr["IEPS"] = Drow["IEPS"];
               dtDatos.Rows.Add(dr);
               //dtDatos.ImportRow(Drow);
            }
            grdDetalle.DataSource = dtDatos;
            Calcula();
        }

        private void grdDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (grdDetalle.Columns[e.ColumnIndex].Index == 11)
            {
                COMPRAS.FRM_Inventario_Articulo frm = new COMPRAS.FRM_Inventario_Articulo();
                frm.K_Articulo_ = Convert.ToInt32(grdDetalle.CurrentRow.Cells["K_Articulo"].Value);
                frm.ShowDialog();
            }

        }

        private void txtArticulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddButtonColumn()
        {
            DataGridViewButtonColumn buttons = new DataGridViewButtonColumn();
            {
                buttons.HeaderText = "Inventario";
                buttons.Text = "-";
                buttons.UseColumnTextForButtonValue = true;
                buttons.AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.AllCells;
                buttons.FlatStyle = FlatStyle.Standard;
                buttons.CellTemplate.Style.BackColor = Color.Honeydew;
                buttons.DisplayIndex = 14;
            }
            bool B_Existe=false;
            foreach(DataGridViewColumn column in grdDetalle.Columns)
            {
                if (column.HeaderText == "Inventario")
                    B_Existe = true;
            }
            if(!B_Existe)
                 grdDetalle.Columns.Add(buttons);
        }

        private bool blnCeldaImportes()
        {
            if (grdDetalle.CurrentCell == null)
                return false;
            if (B_NoEntrar == false)
                return false;

            return (grdDetalle.CurrentCell.ColumnIndex == 4);
        }

        private void grdDetalle_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (blnCeldaImportes())
            {
                if (((DataGridView)sender).CurrentCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Display).ToString() == "")
                {
                    MessageBox.Show("DEBE ESPECIFICAR UN VALOR PARA CANTIDAD Y ESTE SER MAYOR A CERO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
                if (((DataGridView)sender).CurrentCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Display).ToString() == "0")
                {
                    MessageBox.Show("DEBE ESPECIFICAR UN VALOR PARA CANTIDAD MAYOR A CERO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
        }

        private void grdDetalle_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(grdDetalle_KeyPress);
            e.Control.TextChanged += new EventHandler(grdDetalle_TextChanged); 
            e.Control.KeyDown += new KeyEventHandler(grdDetalle_KeyDown);
        }

        private void grdDetalle_KeyDown(object sender, KeyEventArgs e)
        {
            strKeyPress = e.KeyCode.ToString();
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void grdDetalle_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBox textBox = (TextBox)sender;
                if (textBox.Text.Trim().Length > 0)
                {
                    if (Convert.ToDecimal(textBox.Text.Trim().Replace("$", "")) >1000)
                    {
                        MessageBox.Show("VALOR DEMASIADO GRANDE!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox.Text = string.Empty;
                    }
                }
            }
            catch
            {

            }
        }

        private void grdDetalle_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow ren = grdDetalle.CurrentRow;
            if (ren != null)
            {
                if (blnCeldaImportes())
                {
                    CambiaCantidades(e.ColumnIndex, ren, e.RowIndex);
                }
            }
        }

        private void CambiaCantidades(Int32 IndiceColumna, DataGridViewRow ren, Int32 IndiceRegistro)
        {
            if (!EsNumero(Convert.ToDecimal(ren.Cells["CantidadRequerida"].Value)))
            {
                MessageBox.Show("LA COLUMNA PRECIO UNITARIO SOLO ACEPTA NUMEROS", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                grdDetalle.Rows[IndiceRegistro].Cells[IndiceColumna].Value = "0";
                return;
            }

            int CantidadRequerida=0;

            if (ren.Cells["CantidadRequerida"].Value != null)
                CantidadRequerida= int.Parse(ren.Cells["CantidadRequerida"].Value.ToString());
   
            ren.Cells["CantidadRequerida"].Value =Convert.ToInt16(CantidadRequerida);
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidad.Text.Trim().Length > 0)
            {
                if (Convert.ToDecimal(txtCantidad.Text.Trim()) > 1000)
                {
                    MessageBox.Show("VALOR DEMASIADO GRANDE!... \r\n" +
                        "EL VALOR MÁXIMO PERMITDO ES DE: " + "1000", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCantidad.Text = string.Empty;
                }
            }          
        }

        private void grdDetalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (blnCeldaImportes())
            {
                if (!grdDetalle.CurrentCell.IsInEditMode)
                {
                    //grdDetalle.CurrentCell.ed = true;
                    grdDetalle.BeginEdit(true);
                    return;
                }
                if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                {
                    TextBox textBox = (TextBox)sender;

                    if (Convert.ToDecimal((Boolean)(textBox.Text.Length == 0) ? "0" : textBox.Text.Replace("$", "0")) == 0)
                    {
                        //Si entra
                        e.Handled = false;
                        return;
                    }

                    string[] parts = textBox.Text.Split('.'); // result.Split('.');

                    if (parts.Length > 1)
                    {
                        if ((parts[1].Length > 1 && parts.Length > 2) && e.KeyChar != (char)Keys.Back)
                        {
                            e.Handled = true;
                        }
                        if (e.KeyChar == '.')
                        {
                            e.Handled = true;
                        }
                    }              
                }
                else
                    e.Handled = true;
            }
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            if (txtCantidad.Text.Trim().Length > 0)
            {
                if (Convert.ToDecimal(txtCantidad.Text.Trim()) == 0)
                {
                    MessageBox.Show("VALOR NO VÁLIDO!...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCantidad.Text = string.Empty;
                    txtCantidad.Focus();
                }
            }
        }

        private bool ChecaMismoArticulo(DataTable dt, int K_Articulo)
        {
            bool b_mismo = false;
            foreach (DataRow dr in dt.Rows)
            {
                if (Convert.ToInt32(dr["K_Articulo"].ToString()) == K_Articulo)
                {
                    b_mismo = true;
                    break;
                }
            }
            return b_mismo;
        }

        private void CargaAlmacenes()
        {
            DataTable dtAlmacen = sqlCatalogos.Sk_Almacenes(GlobalVar.K_Oficina);

            if (dtAlmacen != null)
            {
                DataRow dr = dtAlmacen.NewRow();

                dr["K_Almacen"] = 0;
                dr["K_Oficina"] = 0;
                dr["D_Oficina"] = "";
                dr["D_Almacen"] = "";
                dr["B_AceptaDevolucionesCliente"] = false;

                dtAlmacen.Rows.InsertAt(dr, 0);

                dtAlmacen.AcceptChanges();

                int indice = -1;
                indice = 0;
                LlenaCombo(dtAlmacen, ref cbxAlmacen, "K_Almacen", "D_Almacen", indice);

                cbxAlmacen.SelectedValue = 0;
            }
        }

        private void CargaTiposRequisicion()
        {
            GlobalVar.dtTipoRequisicion = sqlCatalogos.Sk_Tipo_Requisicion();

            if(GlobalVar.dtTipoRequisicion!=null)
            {
                DataRow dr = GlobalVar.dtTipoRequisicion.NewRow();

                dr["K_Tipo_Requisicion"] = 0;
                dr["D_Tipo_Requisicion"] = "";

                GlobalVar.dtTipoRequisicion.Rows.InsertAt(dr, 0);
   
                GlobalVar.dtTipoRequisicion.AcceptChanges();

                int indice = -1;
                indice = 0;
                LlenaCombo(GlobalVar.dtTipoRequisicion, ref cbxTipoRequisicion, "K_Tipo_Requisicion", "D_Tipo_Requisicion", indice);

                cbxTipoRequisicion.SelectedValue = 1;
            }
        }

        private void Calcula()
        {
            if(dtDatos!=null)
            {
                if (dtDatos.Rows.Count > 0)
                {
                    var x = dtDatos.AsEnumerable().Select(r => Convert.ToDouble(r.Field<double>("SubTotal"))).Sum();
                    if (x.ToString() != "")
                    {
                        if (x >= 0)
                        {
                            double Total_Subtotal = Convert.ToDouble(x);
                            txtSubtotal.Text = Math.Round(Total_Subtotal, 4).ToString("N4").Trim();
                        }
                    }
                    var ff = dtDatos.AsEnumerable().Select(r => Convert.ToDouble(r.Field<double>("IEPS"))).Sum();
                    if (ff.ToString() != "")
                    {
                        if (ff >= 0)
                        {
                            double Total_IEPS = Convert.ToDouble(ff);
                            txtIEPS.Text = Math.Round(Total_IEPS, 4).ToString("N4").Trim();
                        }
                    }                
                    var y = dtDatos.AsEnumerable().Select(r => Convert.ToDouble(r.Field<double>("IVA"))).Sum();
                    if (y.ToString() != "")
                    {
                        if (y >= 0)
                        {
                            double Total_IVA = Convert.ToDouble(y);
                            txtIVA.Text = Math.Round(Total_IVA, 4).ToString("N4").Trim();
                        }
                    }
                    var z = dtDatos.AsEnumerable().Select(r => Convert.ToDouble(r.Field<double>("PrecioTotal"))).Sum();
                    if (z.ToString() != "")
                    {
                        if (z >= 0)
                        {
                            double PrecioTotal = Convert.ToDouble(z);
                            txtTotal.Text = Math.Round(PrecioTotal, 4).ToString("N4").Trim();
                        }
                    }
                }
            }                  
        }
    }
}