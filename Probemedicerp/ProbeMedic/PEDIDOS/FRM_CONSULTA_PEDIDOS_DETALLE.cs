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

namespace ProbeMedic.PEDIDOS
{
    public partial class FRM_CONSULTA_PEDIDOS_DETALLE : FormaBase
    {
        SQLVentas sql_ventas = new SQLVentas();
        DataTable dtDatos = new DataTable();
        public Int32 K_PedidoInt { get; set; }
        public FRM_CONSULTA_PEDIDOS_DETALLE()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            this.lblID.Text = K_PedidoInt.ToString();
            if (lblID.Text.Trim().Length > 0)
            {
                BaseBotonBuscar.Visible = false;
                BaseBotonNuevo.Visible = false;
                BaseBotonModificar.Visible = false;
                BaseBotonBorrar.Visible = false;
                BaseBotonExcel.Visible = false;
                BaseBotonReporte.Visible = false;
                BaseBotonCancelar.Visible = false;
                BaseBotonGuardar.Visible = false;
                BaseBotonAfectar.Visible = false;
                MtdCargaPedidos();
            }


        }
        void MtdCargaPedidos()
        {
            dtDatos = sql_ventas.Sk_Pedidos_Consulta(K_PedidoInt);
               
            if ((dtDatos != null) && (dtDatos.Rows.Count != 0))
            {
                BaseDtDatos = dtDatos;
                grdDetalle.AutoGenerateColumns = false;
                grdDetalle.DataSource = dtDatos;
               
                DataRow row = dtDatos.Rows[0];
                this.lblEstatus.Text = row["D_Estatus_Pedido"].ToString();
                this.lblFolio.Text = row["Folio"].ToString();
                this.lblFechaCreacion.Text = row["FechaPedido"].ToString();
                this.lblCreadoPor.Text = row["D_Usuario"].ToString();
                this.lblFechaEntrega.Text = row["F_Entrgado"].ToString();
                this.lblHora.Text = row["H_Entrega"].ToString();
                this.lblPaciente.Text = row["Nombre_Paciente"].ToString();
                this.lblRFC.Text = row["RFC"].ToString();
                this.lblCURP.Text = row["CURP"].ToString();

                this.lblCalle.Text = row["Calle"].ToString();
                this.lblEntreCalles.Text = row["Entre_Calles"].ToString();
                this.lblEdificio.Text = row["Edificio"].ToString();
                this.lblColonia.Text = row["D_Colonia"].ToString();
                this.lblEstado.Text = row["D_Estado"].ToString();
                this.lblPais.Text = row["D_Pais"].ToString();
                this.lblCP.Text = row["Codigo_Postal"].ToString();
                this.lblTelefono.Text = row["Telefono"].ToString();

                this.lblAseguradora.Text = row["D_Aseguradora"].ToString();
                this.lblCelula.Text = row["D_Celula"].ToString();
                this.lblTipoDePoliza.Text = row["D_Tipo_Poliza"].ToString();
                this.lblPoliza.Text = row["Poliza"].ToString();
                this.lblSiniestro.Text = row["Siniestro"].ToString();
                this.lblReclamacion.Text = row["Reclamacion"].ToString();
                this.lblCoaseguroPorcentaje.Text = row["Porcentaje_Coaseguro"].ToString();

         
                this.lblMedico.Text = row["Nombre_Medico"].ToString();
                this.lblNota.Text = row["Nota"].ToString();
                //this.lblMetodoPagoCoaseguro = row["Nota"].ToString();
                this.lblPaqueteria.Text = row["D_Empresa_Paqueteria"].ToString() == ""?"NO APLICA": row["D_Empresa_Paqueteria"].ToString();
                this.lblNOGUIA.Text = row["Guia"].ToString() == "" ? "NO APLICA" : row["Guia"].ToString();
                this.lblQuimioterapia.Text = Convert.ToBoolean(row["B_Quimioterapia"].ToString()) == true ? "SI" : "NO";

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

            }

        }
    }
}