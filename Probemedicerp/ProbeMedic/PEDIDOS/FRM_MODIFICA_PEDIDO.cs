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
using ProbeMedic.CATALOGOS.PACIENTES;

namespace ProbeMedic.PEDIDOS
{
    public partial class FRM_MODIFICA_PEDIDO : FormaBase
    {
        DataTable dtDatos = new DataTable();
        DataTable dtCelulas = new DataTable();
        DataTable dtAlmacen = new DataTable();
        DataTable dtEmpresaEntrega = new DataTable();
        DataTable dtTipoEntrega = new DataTable();
        DataTable dtTiposPago = new DataTable();
        SQLPedidos sqlpedidos = new SQLPedidos();
        SQLCatalogos SQLCatalogos = new SQLCatalogos();

        Int32 K_Oficina;
        Int32 K_Almacen;
        Int32 K_Celula;
        Int32 K_Tipo_Entrega;
        Int32 K_Empresa_Entrega;
        Int32 K_Tipo_PagoCoaseguro;
        Int32 res;

        public Int32 K_PedidoInt { get; set; }
        private Int32 K_Telefono_Int { get; set; }
        private Int32 K_MedicoInt { get; set; }
        private Int32 K_MedicoDic { get; set; }
        private Int32 K_PacienteDireccionInt { get; set; }

        public FRM_MODIFICA_PEDIDO()
        {
            InitializeComponent();
        }

        public override void BaseMetodoInicio()
        {
            BaseBotonBuscar.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonReporte.Visible = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonGuardar.Visible = true;
            BaseBotonAfectar.Visible = false;

            grdDetalle.MultiSelect = false;
            grdDetalle.ReadOnly = true;
            grdDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            grdDetalle.BackgroundColor = Color.White;
            grdDetalle.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 70, 209);
            grdDetalle.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grdDetalle.EnableHeadersVisualStyles = false;

            txtPedido.Text = Convert.ToString(K_PedidoInt);
            if (K_PedidoInt > 0 )
            {

                CargaPedidos();
            }
        }

        private void CargaPedidos()
        {
            dtDatos = sqlpedidos.Sk_Pedidos_Consulta(Convert.ToInt32(txtPedido.Text));

            K_Oficina = GlobalVar.K_Oficina;

            if ((dtDatos != null) && (dtDatos.Rows.Count != 0))
            {
                BaseDtDatos = dtDatos;
                grdDetalle.AutoGenerateColumns = false;
                grdDetalle.DataSource = dtDatos;

                DataRow row = dtDatos.Rows[0];
                //this.lblFechaNac.Text = row["F_Nacimiento"].ToString();
                this.lblEstatus.Text = row["D_Estatus_Pedido"].ToString();
                //this.lblFolio.Text = row["Folio"].ToString();
                this.lblFechaCreacion.Text = row["FechaPedido"].ToString();
                this.lblCreadoPor.Text = row["D_Usuario"].ToString();
                this.txtPaciente.Text = row["Nombre_Paciente"].ToString();
                this.txtClavePaciente.Text = row["K_Paciente"].ToString();
                this.txtAsesor.Text = row["D_Asesor"].ToString();
                this.txtK_Asesor.Text = row["K_Asesor"].ToString();
                this.lblGenero.Text = row["D_Genero"].ToString();
                this.lblEstadoCivil.Text = row["D_Estado_Civil"].ToString();
                this.lblNacionalidad.Text = row["D_Nacionalidad"].ToString();
                this.lblRFC.Text = row["RFC"].ToString();
                this.lblCURP.Text = row["CURP"].ToString();
                this.lblTipoDeSangre.Text = row["D_Tipo_Sangre"].ToString();
                this.lblTipoPaciente.Text = row["D_Tipo_Paciente"].ToString();
                this.lblAseguradora.Text = row["D_Aseguradora"].ToString();
                this.lblCelula.Text = row["D_Celula"].ToString();
                this.lblTipoDePoliza.Text = row["D_Tipo_Poliza"].ToString();
                this.lblPoliza.Text = row["Poliza"].ToString();
                this.lblSiniestro.Text = row["Siniestro"].ToString();
                this.lblReclamacion.Text = row["Reclamacion"].ToString();
                this.lblCoaseguroPorcentaje.Text = row["Porcentaje_Coaseguro"].ToString();
                this.lblMedico.Text = row["Nombre_Medico"].ToString();
                K_MedicoInt = Convert.ToInt32(row["K_Medico"].ToString());
                this.cbxQuimioterapia.Checked = Convert.ToBoolean(row["B_Quimioterapia"].ToString());

                //direccion 
                this.lblCalle.Text = row["Calle"].ToString();
                this.lblEntreCalles.Text = row["Entre_Calles"].ToString();
                this.lblEdificio.Text = row["Edificio"].ToString();
                this.lblColonia.Text = row["D_Colonia"].ToString();
                this.lblEstado.Text = row["D_Estado"].ToString();
                this.lblPais.Text = row["D_Pais"].ToString();
                this.lblCP.Text = row["Codigo_Postal"].ToString();
                this.LblNumeroExt.Text = Convert.ToString( row["Numero_Exterior"].ToString());
                this.LblNumeroInt.Text = row["Numero_Interior"].ToString();
                this.LblNumeroInt.Text = row["Edificio"].ToString();
                this.LblNumeroInt.Text = row["Piso"].ToString();
                this.Txt_No_Guia.Text = row["Guia"].ToString();
                this.lblTipoDireccion.Text = row["D_Tipo_Direccion"].ToString();
                this.lblMunicipio.Text = row["D_Municipio"].ToString();
                K_PacienteDireccionInt = Convert.ToInt32(row["K_Paciente_Direccion"].ToString());

                //Asignacion de valor
                this.K_Celula  = Convert.ToInt32( row["K_Celula"].ToString());
                CargaCelulas();
                this.K_Almacen = Convert.ToInt32(row["K_Almacen"].ToString());
                this.K_Oficina = Convert.ToInt32(row["K_Oficina"].ToString());
                CargaAlmacen();
                this.K_Empresa_Entrega = row["K_Empresa_Entrega"].ToString() == ""? 0: Convert.ToInt32(row["K_Empresa_Entrega"].ToString());
                MtdCargaEmpresa_Entrega();
                if (K_Empresa_Entrega > 0 )
                {
                    pnlEntregaForanea.Visible = true;
                }
                this.K_Tipo_Entrega = row["K_Tipo_Entrega"].ToString()== "" ? 0: Convert.ToInt32(row["K_Tipo_Entrega"].ToString());
                MtdCargaTipo_Entrega();
                this.K_Tipo_PagoCoaseguro = row["K_Tipo_PagoCoaseguro"].ToString() == "" ? 0 : Convert.ToInt32(row["K_Tipo_PagoCoaseguro"].ToString());
                MtdCargaTiposPago();

                this.lblTelefono.Text = row["Telefono"].ToString();
                this.LblCodigoPais.Text = row["Codigo_Pais"].ToString();
                this.LblLada.Text = row["Lada"].ToString();
                this.txtNota.Text = row["Nota"].ToString();
                this.lblTipoTelefono.Text = row["D_Tipo_Telefono"].ToString();
                K_Telefono_Int = row["K_Paciente_Telefono"].ToString()!="" ? Convert.ToInt32( row["K_Paciente_Telefono"].ToString()) : 0;
                //programacion 
                this.dtpFecha.Text = row["F_Entrgado"].ToString();
                this.txt_HI.Text = row["H_Entrega"].ToString();
                this.txtNombrePacienteCarta.Text = row["PacienteCartaPedido"].ToString();
                this.txtAtencion.Text = row["Carta_Pedido"].ToString();
                this.txtCarta.Text = row["Carta"].ToString();
                this.txtMontoCarta.Text = row["Monto_Carta"].ToString();
                this.txtSiniestro.Text = row["Siniestro_Pedido"].ToString();
                this.txtReclamacion.Text = row["Reclamacion_Pedido"].ToString();
                this.txtPoliza.Text = row["Poliza_Pedido"].ToString();
                if (row["Coaseguro_Porcentaje_Pedido"].ToString() != null)
                {
                    rdbPct.Checked = true;
                    txtCoaseguro.Text = row["Coaseguro_Porcentaje_Pedido"].ToString();
                }
                if (row["Coaseguro_Pedido"].ToString() != null)
                {
                    rdbFijo.Checked = true;
                    txtCoaseguro.Text = row["Coaseguro_Pedido"].ToString();
                }
                if (txtCoaseguro.Text.Trim().Length == 0 )
                {
                    rdbSinCoaseguro.Checked = true;
                }
                this.cbxReqPagoCoaseguro.Checked = Convert.ToBoolean(row["B_CoaCobReq"].ToString());
                if (row["Deduccion_Porcentaje_Pedido"].ToString() != null)
                {
                    rdbDPor.Checked = true;
                    txtDeduccion.Text = row["Deduccion_Porcentaje_Pedido"].ToString();
                }
                if (row["Deduccion_Pedido"].ToString() != null)
                {
                    rdbDF.Checked = true;
                    txtDeduccion.Text = row["Deduccion_Pedido"].ToString();
                }
                if (txtDeduccion.Text.Trim().Length == 0)
                {
                    rdbDSinCoaseguro.Checked = true;
                }

                //medicamentos
                this.txtSubtotal.Text = row["SubTotal"].ToString();
                this.txtSubtotal.Text = TxtImporteToStr(ref txtSubtotal);
                this.txtTotalIVA.Text = row["Total_Iva"].ToString();
                this.txtTotalIVA.Text = TxtImporteToStr(ref txtTotalIVA);
                this.txtDescuento.Text = row["Descuento"].ToString();
                this.txtDescuento.Text = TxtImporteToStr(ref txtDescuento);
                this.txtCoaseguro.Text = row["Coaseguro_Pedido"].ToString();
                this.txtCoaseguro.Text = TxtImporteToStr(ref txtCoaseguro);
                this.txtTotalPedido.Text = row["Total_Pedido"].ToString();
                this.txtTotalPedido.Text = TxtImporteToStr(ref txtTotalPedido);

                //lo que es fijo 
                cbxAlmacen.Enabled = false;
            }
        }

        private void CargaCelulas()
        {
            dtCelulas.Rows.Clear();
            cbxCelula.DataSource = null;
            cbxCelula.Items.Clear();
            cbxCelula.AutoCompleteSource = AutoCompleteSource.None;
            cbxCelula.AutoCompleteMode = AutoCompleteMode.None;

            dtCelulas = sqlCatalogos.Sk_Celulas();

            if (dtCelulas != null)
            {
                DataRow dr = dtCelulas.NewRow();

                dr["K_Celula"] = 0;
                dr["C_Celula"] = "";
                dr["D_Celula"] = "[Seleccionar]";
                dr["K_Aseguradora"] = 0;
                dr["D_Aseguradora"] = "";
                dtCelulas.Rows.InsertAt(dr, 0);

                dtCelulas.AcceptChanges();

                int indice = 0;
                LlenaCombo(dtCelulas, ref cbxCelula, "K_Celula", "D_Celula", indice);
                cbxCelula.SelectedValue = K_Celula;
            }
            
        }

        private void CargaAlmacen()
        {
            if (K_Oficina == 0)
            {
                dtAlmacen.Rows.Clear();
            }
            else
            {
                dtAlmacen = sqlCatalogos.Sk_Almacenes(K_Oficina);
            }

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

                cbxAlmacen.SelectedValue = K_Almacen;
            }
        }

        private void btnTelefonos_Click(object sender, EventArgs e)
        {
            FRM_PACIENTES_TELEFONOS frm = new FRM_PACIENTES_TELEFONOS();
            frm.btnEliminar.Visible = false;
            frm.btnEliminar.Enabled = false;
            frm.PropiedadK_Paciente = Convert.ToInt32(txtClavePaciente.Text);
            frm.PropiedadD_Paciente = txtPaciente.Text;
            frm.ShowDialog();
            lblTipoTelefono.Text = frm.Tipo_Telefono;
            lblTelefono.Text = frm.Telefono_Pasa;
            LblLada.Text = Convert.ToString(frm.Lada_Pasa);
            LblCodigoPais.Text = Convert.ToString(frm.Codigo_Pais_Pasa);
            K_Telefono_Int = frm.K_Telefono_Pasa;
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            FRM_PACIENTES_MEDICOS frm = new FRM_PACIENTES_MEDICOS();
            frm.btnEliminar.Visible = false;
            frm.btnEliminar.Enabled = false;
            frm.PropiedadK_Paciente = Convert.ToInt32(txtClavePaciente.Text);
            frm.PropiedadD_Paciente = txtPaciente.Text;
            frm.ShowDialog();
            lblMedico.Text = frm.D_Medico_Pasa;
            K_MedicoInt = frm.K_Medico_Pasa;


        }

        private void btnDictaminador_Click(object sender, EventArgs e)
        {
            FRM_PACIENTES_MEDICOS frm = new FRM_PACIENTES_MEDICOS();
            frm.btnEliminar.Visible = false;
            frm.btnEliminar.Enabled = false;
            frm.PropiedadK_Paciente = Convert.ToInt32(txtClavePaciente.Text);
            frm.PropiedadD_Paciente = txtPaciente.Text;
            frm.ShowDialog();
            lblDictaminador.Text = frm.D_Medico_Pasa;
            K_MedicoDic = frm.K_Medico_Pasa;
        }

       
        void MtdCargaTipo_Entrega()
        {
            dtTipoEntrega.Rows.Clear();
            Cbx_Tipo_Entrega.DataSource = null;
            Cbx_Tipo_Entrega.Items.Clear();
            Cbx_Tipo_Entrega.AutoCompleteSource = AutoCompleteSource.None;
            Cbx_Tipo_Entrega.AutoCompleteMode = AutoCompleteMode.None;


            dtTipoEntrega = sqlCatalogos.Sk_Tipo_Entrega();


            if (dtTipoEntrega != null)
            {
                DataRow dr = dtTipoEntrega.NewRow();

                dr["K_Tipo_Entrega"] = 0;
                dr["D_Tipo_Entrega"] = "";

                dtTipoEntrega.Rows.InsertAt(dr, 0);

                dtTipoEntrega.AcceptChanges();

                int indice = -1;
                indice = 0;
                LlenaCombo(dtTipoEntrega, ref Cbx_Tipo_Entrega, "K_Tipo_Entrega", "D_Tipo_Entrega", -1);
                Cbx_Tipo_Entrega.SelectedValue = K_Tipo_Entrega;
            }
        }

        void MtdCargaEmpresa_Entrega()
        {
            dtEmpresaEntrega.Rows.Clear();
            Cbx_Empresa.DataSource = null;
            Cbx_Empresa.Items.Clear();
            Cbx_Empresa.AutoCompleteSource = AutoCompleteSource.None;
            Cbx_Empresa.AutoCompleteMode = AutoCompleteMode.None;


            dtEmpresaEntrega = sqlCatalogos.Sk_Empresa_Entrega();


            if (dtEmpresaEntrega != null)
            {
                DataRow dr = dtEmpresaEntrega.NewRow();

                dr["K_Empresa_Entrega"] = 0;
                dr["D_Empresa_Entrega"] = "[Seleccionar]";

                dtEmpresaEntrega.Rows.InsertAt(dr, 0);

                dtEmpresaEntrega.AcceptChanges();

                int indice = -1;
                indice = 0;
                LlenaCombo(dtEmpresaEntrega, ref Cbx_Empresa, "K_Empresa_Entrega", "D_Empresa_Entrega", indice);
                Cbx_Empresa.SelectedValue = K_Empresa_Entrega;
            }
        }

        void MtdCargaTiposPago()
        {
            dtTiposPago.Rows.Clear();
            cbxMetodoPagoCoaseguro.DataSource = null;
            cbxMetodoPagoCoaseguro.Items.Clear();
            cbxMetodoPagoCoaseguro.AutoCompleteSource = AutoCompleteSource.None;
            cbxMetodoPagoCoaseguro.AutoCompleteMode = AutoCompleteMode.None;


            dtTiposPago = sqlCatalogos.Sk_Tipos_Pago(true);

                int indice=  1 ;
                LlenaCombo(dtTiposPago, ref cbxMetodoPagoCoaseguro, "K_Tipo_Pago", "D_Tipo_Pago", indice);
                cbxMetodoPagoCoaseguro.SelectedValue = K_Tipo_PagoCoaseguro;
        }

        private void Cbx_Tipo_Entrega_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Cbx_Tipo_Entrega.SelectedValue != null)
            {
                if (Cbx_Tipo_Entrega.SelectedValue.ToString() == "1") //FORANEA
                {
                    pnlEntregaForanea.Visible = true;
                    MtdCargaEmpresa_Entrega();
                }
                else if (Cbx_Tipo_Entrega.SelectedText.ToString() != "2") //LOCAL
                {
                    pnlEntregaForanea.Visible = false;
                }
                else
                {
                    pnlEntregaForanea.Visible = false;
                }
            }
        }

        public override void BaseBotonGuardarClick()
        {
            if (!BaseFuncionValidaciones())
                return;

            string msg = string.Empty;


            String errores = String.Empty;
            if (txtMontoCarta.Text ==   "")
            {
                txtMontoCarta.Text = "0";
            }
            if (txtCoaseguro.Text == "")
            {
                txtCoaseguro.Text = "0";
            }
            if (txtPorcentajeDescuento.Text == "")
            {
                txtPorcentajeDescuento.Text = "0";
            }
            if (txtDeduccion.Text == "")
            {
                txtDeduccion.Text = "0";
            }
            res = 0;
            res = sqlpedidos.Up_Pedidos(K_PedidoInt, K_PacienteDireccionInt, K_MedicoInt, Convert.ToInt32(cbxCelula.SelectedValue),
                   Convert.ToDateTime(dtpFecha.Value), Convert.ToInt32(Cbx_Tipo_Entrega.SelectedValue), Convert.ToInt32(Cbx_Empresa.SelectedValue), Txt_No_Guia.Text.Trim(),
                  Convert.ToDateTime(txt_HI.Value), txtNota.Text, cbxQuimioterapia.Checked, K_Telefono_Int, txtReclamacion.Text, txtCarta.Text, Convert.ToDecimal(txtMontoCarta.Text), txtSiniestro.Text,
                  txtReclamacion.Text, Convert.ToDecimal(txtCoaseguro.Text.Replace("$","")), Convert.ToDecimal(txtCoaseguro.Text.Replace("$","")), txtPoliza.Text, rdbSinCoaseguro.Checked, Convert.ToInt32(cbxMetodoPagoCoaseguro.SelectedValue),
                  txtNombrePacienteCarta.Text, txtSiniestro.Text, txtAtencion.Text, cbxReqPagoCoaseguro.Checked, Convert.ToInt32(cbxCelula.SelectedValue), Convert.ToDecimal(txtPorcentajeDescuento.Text.Replace("$","")),
                  Convert.ToDecimal(txtDeduccion.Text.Replace("$","")), rdbDSinCoaseguro.Checked, ref msg);

            if (res == -1)
            {
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (errores != string.Empty)
            {
              //  BaseErrorResultado = true;
                MessageBox.Show("ALGUNAS FECHAS NO SE REALIZARON CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
              //  BaseErrorResultado = false;
                MessageBox.Show("LA TRANSACCION SE REALIZO CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (Convert.ToInt32(cbxAlmacen.SelectedValue) == 0)
            {
                MessageBox.Show("FALTA SELECCIONAR UN ALMACEN...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxAlmacen.Focus();
                return false;
            }

            if (txtClavePaciente.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR PACIENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClavePaciente.Focus();
                return false;
            }
            //SI ES FORANEA Y LA GUIA ESTA VACIA
            if (Convert.ToInt32(Cbx_Empresa.SelectedValue.ToString()) == 1 && Txt_No_Guia.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR NUMERO DE GUIA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_No_Guia.Focus();
                return false;
            }

           // BaseErrorResultado = false;
            return true;
        }

        private void btnDirecciones_Click(object sender, EventArgs e)
        {
            if (txtClavePaciente.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN PACIENTE", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPaciente.Focus();
                return;
            }
            FRM_PACIENTES_DIRECCIONES frm = new FRM_PACIENTES_DIRECCIONES();
            frm.BtnBorrar.Visible = false;
            frm.BtnBorrar.Enabled = false;
            frm.PropiedadK_Paciente = Convert.ToInt32(txtClavePaciente.Text);
            frm.PropiedadD_Paciente = txtPaciente.Text;
            frm.ShowDialog();
            lblCalle.Text = frm.Calle_Pasa;
            LblNumeroInt.Text = frm.Numero_Int;
            LblNumeroExt.Text = Convert.ToString(frm.Numero_Ext);
            lblTipoDireccion.Text = frm.Tipo_Direccion_Pasa;
            lblEntreCalles.Text = frm.EntreCalles_Pasa;
            lblEdificio.Text = frm.Edificio_Pasa;
            LblPiso.Text = frm.Piso_Pasa;
            lblColonia.Text = frm.Colonia_Pasa;
            lblEstado.Text = frm.Estado_Pasa;
            lblPais.Text = frm.Pais_Pasa;
            lblLocalidad.Text = frm.Localidad_Pasa;
            lblCP.Text = Convert.ToString(frm.CP_Pasa);
            lblMunicipio.Text = frm.Municipio_Pasa;
            K_PacienteDireccionInt = frm.K_Paciente_Dierccion;


        }
    }
}