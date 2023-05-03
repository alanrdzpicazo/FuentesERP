﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProbeMedic.AppCode.BLL;
using ProbeMedic;
using CrystalDecisions.CrystalReports.Engine;

namespace ProbeMedic
{ 

    public partial class FormaBase : Forma
    {
        Funciones fx = new Funciones();
        SQLSeguridad sqlSeguridad = new SQLSeguridad();
        public SQLCatalogos sqlCatalogos = new SQLCatalogos();
        public enum tipoVentana { CATALOGO, GENERAL, GENERALPANELDESHABILITADO }



        //TODO: *****AQUI TODAS LAS PROPIEDADES GLOBALES
        #region "Propiedades Globales"  
        public tipoVentana TipoVentana { get; set; }
        public bool BasePropiedadB_Agregando = false;
        public bool BasePropiedadB_Editando = false;
        public int BasePropiedadId_Identity = 0;
        public bool BasePropiedadEsRegistroNuevo = false;
        public bool BaseErrorResultado = false;
        public string BasePropiedadCampoClave = string.Empty;
        public string BasePropiedadDescripcion = string.Empty;
        public bool BasePropiedadB_EsCataLogo = true;
        public string BaseSerieFolio = string.Empty;

        #endregion

        public TextBox txtFocus { get; set; }


        //TODO: *****AQUI SE CREAN LOS TIPOS DE SQL        
        #region "Se crean las Tablas Tipo de detalle para SQL"        
        public DataTable BaseTipoGenerico
        {
            get
            {
                System.Data.DataTable dt = new DataTable();
                dt.Columns.Add("Columna1", (typeof(string)));
                dt.Columns.Add("Columna2", (typeof(string)));
                dt.Columns.Add("Columna3", (typeof(string)));
                dt.Columns.Add("Columna4", (typeof(string)));
                dt.Columns.Add("Columna5", (typeof(string)));
                return dt;
            }
        }

        public DataTable DetallePagosCxC_Type
        {
            get
            {
                System.Data.DataTable dt = new DataTable();
                dt.Columns.Add("K_Factura", (typeof(int)));
                dt.Columns.Add("ImportePagar", (typeof(decimal)));

                return dt;
            }
        }

        public DataTable AjustesCalidad_Type
        {
            get
            {
                System.Data.DataTable dt = new DataTable();
                dt.Columns.Add("K_Solicitud_Produccion", (typeof(int)));
                dt.Columns.Add("K_Producto_Solicitud", (typeof(int)));
                dt.Columns.Add("K_Producto", (typeof(int)));
                dt.Columns.Add("K_Articulo", (typeof(int)));
                dt.Columns.Add("Cantidad_Real_KG", (typeof(decimal)));
                dt.Columns.Add("Cantidad_Real_Gr", (typeof(decimal)));
                dt.Columns.Add("Tiempo_Mesclado", (typeof(decimal)));
                dt.Columns.Add("Orden", (typeof(int)));
                dt.Columns.Add("Recomendacion", (typeof(string)));
                return dt;
            }
        }

        public DataTable PruebasCalidad_Type
        {
            get
            {
                System.Data.DataTable dt = new DataTable();
                dt.Columns.Add("Consecutivo", (typeof(int)));
                dt.Columns.Add("Hoja_Produccion", (typeof(int)));
                dt.Columns.Add("K_Estacion", (typeof(int)));
                dt.Columns.Add("K_Producto", (typeof(int)));
                dt.Columns.Add("Identificador", (typeof(int)));
                dt.Columns.Add("K_Prueba_Calidad", (typeof(int)));
                dt.Columns.Add("D_Prueba_Calidad", (typeof(string)));
                dt.Columns.Add("Valor_Inicial", (typeof(decimal)));
                dt.Columns.Add("Valor_Final", (typeof(decimal)));
                dt.Columns.Add("K_Solicitud_Produccion", (typeof(int)));
                dt.Columns.Add("Inspeccion", (typeof(decimal)));

                return dt;
            }
        }

        public DataTable Productos_PruebasCalidad_Type
        {
            get
            {
                System.Data.DataTable dt = new DataTable();
                dt.Columns.Add("B_Seleccionada", (typeof(bool)));
                dt.Columns.Add("K_Producto", (typeof(int)));
                dt.Columns.Add("Identificador", (typeof(int)));
                dt.Columns.Add("K_Prueba_Calidad", (typeof(int)));
                dt.Columns.Add("D_Prueba_Calidad", (typeof(string)));
                dt.Columns.Add("ValorInicial", (typeof(decimal)));
                dt.Columns.Add("ValorFinal", (typeof(decimal)));
                dt.Columns.Add("K_Tipo_Prueba", (typeof(int)));
                dt.Columns.Add("D_Tipo_Prueba", (typeof(string)));
                dt.Columns.Add("D_Clasificacion_Prueba", (typeof(string)));
                dt.Columns.Add("CantidadGramos", (typeof(decimal)));
                dt.Columns.Add("B_ImprimeCalidad", (typeof(bool)));
                dt.Columns.Add("B_ImprimeCertificado", (typeof(bool)));
                dt.Columns.Add("Nota", (typeof(string)));

                return dt;
            }
        }

        public DataTable FacturaDetalle_Type 
        {
            get
            {
                System.Data.DataTable dt = new DataTable();
                dt.Columns.Add("Cantidad", (typeof(int)));
                dt.Columns.Add("K_Tipo_Producto", (typeof(int)));
                dt.Columns.Add("K_Unidad_Medida", (typeof(int)));
                dt.Columns.Add("SKU", (typeof(string)));
                dt.Columns.Add("K_Articulo", (typeof(int)));
                dt.Columns.Add("Precio_Unitario", (typeof(decimal)));
                dt.Columns.Add("PorcentajeDescuento", (typeof(decimal)));
                dt.Columns.Add("Descuento", (typeof(decimal)));
                dt.Columns.Add("Subtotal", (typeof(decimal)));
                dt.Columns.Add("Tasa_IVA", (typeof(decimal)));
                dt.Columns.Add("Total_IVA", (typeof(decimal)));
                dt.Columns.Add("Total_Detalle", (typeof(decimal)));
                dt.Columns.Add("Comentarios", (typeof(string)));
                dt.Columns.Add("B_Facturado", (typeof(bool)));
                dt.Columns.Add("D_Articulo", (typeof(string)));
                dt.Columns.Add("D_Unidad_Medida", (typeof(string)));
                return dt;
            }
        }

        public DataTable DetalleFactura_Type
        {
            get
            {
                System.Data.DataTable dt = new DataTable();
                dt.Columns.Add("Cantidad", (typeof(decimal)));
                dt.Columns.Add("Unidad", (typeof(string)));
                dt.Columns.Add("Descripcion", (typeof(string)));
                dt.Columns.Add("ValorUnitario", (typeof(decimal)));
                dt.Columns.Add("Importe", (typeof(decimal)));
                dt.Columns.Add("Detalle", (typeof(string)));
                dt.Columns.Add("K_Tipo_Empaque", (typeof(int)));
                dt.Columns.Add("D_Tipo_Empaque", (typeof(string)));
                dt.Columns.Add("CantidadKgs", (typeof(decimal)));
                dt.Columns.Add("Lote", (typeof(string)));
                dt.Columns.Add("K_Producto", (typeof(Int32)));
                dt.Columns.Add("K_Articulo", (typeof(Int32)));
                dt.Columns.Add("FraccionArancelaria", (typeof(string)));

                return dt;
            }
        }

        public DataTable Generico_Type
        {
            get
            {
                System.Data.DataTable dt = new DataTable();
                dt.Columns.Add("Campo1", (typeof(string)));
                dt.Columns.Add("Campo2", (typeof(string)));
                dt.Columns.Add("Campo3", (typeof(string)));
                dt.Columns.Add("Campo4", (typeof(string)));
                dt.Columns.Add("Campo5", (typeof(string)));

                return dt;
            }
        }

        public DataTable Pedido_Inventario_Type
        {
            get
            {
                System.Data.DataTable dt = new DataTable();
                dt.Columns.Add("K_Pedido", (typeof(int)));
                dt.Columns.Add("K_Pedido_Detalle", (typeof(int)));
                dt.Columns.Add("k_Movimiento_Inventario", (typeof(int)));
                dt.Columns.Add("k_Movimiento_InventarioPT", (typeof(int)));
                dt.Columns.Add("K_Producto", (typeof(int)));
                dt.Columns.Add("K_Articulo", (typeof(int)));
                dt.Columns.Add("Cantidad", (typeof(decimal)));
                dt.Columns.Add("Cantidadkgs", (typeof(decimal)));
                dt.Columns.Add("Lote", (typeof(string)));


                return dt;
            }
        }

        public DataTable DetallePagosCxP_Type
        {
            get
            {
                System.Data.DataTable dt = new DataTable();
                dt.Columns.Add("K_Cuenta_Pagar", (typeof(int)));
                dt.Columns.Add("Serie", (typeof(string)));
                dt.Columns.Add("Folio", (typeof(string)));
                dt.Columns.Add("ImportePagar", (typeof(decimal)));

                return dt;
            }
        }

        public DataTable FormulacionAlterna_Type
        {
            get
            {
                System.Data.DataTable dt = new DataTable();
                dt.Columns.Add("ID_Formula", (typeof(Int16)));
                dt.Columns.Add("K_Producto", (typeof(int)));
                dt.Columns.Add("K_Articulo", (typeof(int)));
                dt.Columns.Add("D_Formula", (typeof(string)));
                dt.Columns.Add("Cantidad_PPP", (typeof(decimal)));
                dt.Columns.Add("Tiempo_Mezclado", (typeof(int)));
                dt.Columns.Add("Orden", (typeof(int)));
                dt.Columns.Add("K_Usuario", (typeof(int)));

                return dt;
            }
        }

        public DataTable ProductosFormulacion_Type
        {
            get
            {
                System.Data.DataTable dt = new DataTable();
                dt.Columns.Add("K_Producto", (typeof(int)));
                dt.Columns.Add("K_Articulo", (typeof(int)));
                dt.Columns.Add("Cantidad_PPP", (typeof(decimal)));
                dt.Columns.Add("Tiempo_Mezclado", (typeof(int)));
                dt.Columns.Add("Orden", (typeof(int)));

                return dt;
            }
        }

        public DataTable Temp_Colonias_Type
        {
            get
            {
                System.Data.DataTable dt = new DataTable();
                dt.Columns.Add("d_codigo", (typeof(int)));
                dt.Columns.Add("d_asenta", (typeof(string)));
                dt.Columns.Add("d_tipo_asenta", (typeof(string)));
                dt.Columns.Add("D_mnpio", (typeof(string)));
                dt.Columns.Add("d_estado", (typeof(string)));
                dt.Columns.Add("d_ciudad", (typeof(string)));
                dt.Columns.Add("d_CP", (typeof(int)));
                dt.Columns.Add("c_estado", (typeof(string)));
                dt.Columns.Add("c_oficina", (typeof(string)));
                dt.Columns.Add("c_CP", (typeof(int)));
                dt.Columns.Add("c_tipo_asenta", (typeof(string)));
                dt.Columns.Add("c_mnpio", (typeof(string)));
                dt.Columns.Add("id_asenta_cpcons", (typeof(string)));
                dt.Columns.Add("c_cve_ciudad", (typeof(string)));

                return dt;
            }
        }

        public DataTable DetalleRequisicion_Type
        {
            get
            {
                System.Data.DataTable dt = new DataTable();
                dt.Columns.Add("K_Detalle_Requisicion", (typeof(int)));
                dt.Columns.Add("K_Articulo", (typeof(int)));
                dt.Columns.Add("D_Articulo", (typeof(string)));
                dt.Columns.Add("CantidadRequerida", (typeof(short)));
                dt.Columns.Add("Unitario", (typeof(double)));
                dt.Columns.Add("UMedida", (typeof(string)));
                dt.Columns.Add("SubTotal", (typeof(double)));
                dt.Columns.Add("IVA", (typeof(double)));
                dt.Columns.Add("PrecioTotal", (typeof(double)));
                dt.Columns.Add("ObservacionesDetalle", (typeof(string)));
                dt.Columns.Add("K_Iva", (typeof(int)));
                dt.Columns.Add("K_Ieps", (typeof(int)));
                dt.Columns.Add("IEPS", (typeof(double)));
                return dt;
            }
        }

        public DataTable DetalleOCDirecta_Type
        {
            get
            {
                System.Data.DataTable dt = new DataTable();
                dt.Columns.Add("K_Detalle_Compra", (typeof(int)));
                dt.Columns.Add("K_Articulo", (typeof(int)));
                dt.Columns.Add("D_Articulo", (typeof(string)));
                dt.Columns.Add("CantidadRequerida", (typeof(Int32)));
                dt.Columns.Add("Unitario", (typeof(decimal)));
                dt.Columns.Add("IVA", (typeof(decimal)));
                dt.Columns.Add("SubTotal", (typeof(decimal)));
                dt.Columns.Add("PrecioTotal", (typeof(decimal)));
                dt.Columns.Add("ObservacionesDetalle", (typeof(string)));
                dt.Columns.Add("Porcentaje_Descuento", (typeof(decimal)));
                dt.Columns.Add("Monto_Descuento", (typeof(decimal)));
                dt.Columns.Add("Porcentaje_Descuento_2", (typeof(decimal)));
                dt.Columns.Add("Monto_Descuento_2", (typeof(decimal)));
                dt.Columns.Add("IEPS", (typeof(decimal)));
                dt.Columns.Add("Porcentaje_Ieps", (typeof(decimal))); 
                return dt;
            }
        }

        public DataTable DetalleRecepciones_Type
        {
            get
            {
                System.Data.DataTable dt = new DataTable();
                dt.Columns.Add("K_Operacion", (typeof(int)));
                dt.Columns.Add("Cantidad", (typeof(short)));
                dt.Columns.Add("UnidadMedida", (typeof(string)));
                dt.Columns.Add("Concepto", (typeof(string)));
                dt.Columns.Add("PrecioUnitario", (typeof(double)));
                dt.Columns.Add("ImporteTotal", (typeof(double)));

                return dt;
            }
        }

        public DataTable DetalleOrdenCompra_Type
        {
            get
            {
                System.Data.DataTable dt = new DataTable();
                dt.Columns.Add("K_Requisicion", (typeof(int)));
                dt.Columns.Add("K_Detalle_Requisicion", (typeof(int)));
                dt.Columns.Add("K_Articulo", (typeof(int)));
                dt.Columns.Add("Cantidad", (typeof(short)));

                dt.Columns.Add("PrecioUnitario", (typeof(decimal)));
                dt.Columns.Add("TasaIVA", (typeof(decimal)));
                dt.Columns.Add("TotalDetalle", (typeof(decimal)));
                return dt;
            }
        }

        public DataTable DetalleNotaProveedor_Type
        {
            get
            {
                System.Data.DataTable dt = new DataTable();
                dt.Columns.Add("Cantidad", (typeof(short)));
                dt.Columns.Add("UnidadMedida", (typeof(string)));
                dt.Columns.Add("Concepto", (typeof(string)));
                dt.Columns.Add("PrecioUnitario", (typeof(decimal)));
                dt.Columns.Add("ImporteTotal", (typeof(decimal)));
                return dt;
            }
        }

        public DataTable Articulos_DetalleEnfermeria_Table
        {
            get
            {
                System.Data.DataTable dt = new DataTable();
                dt.Columns.Add("K_Articulo", (typeof(int)));
                dt.Columns.Add("D_Articulo", (typeof(string)));
                dt.Columns.Add("Precio", (typeof(double)));
                dt.Columns.Add("Cantidad", (typeof(short)));    
                dt.Columns.Add("Subtotal", (typeof(double)));
                dt.Columns.Add("IVA", (typeof(double)));
                dt.Columns.Add("Total", (typeof(double)));
                return dt;
            }
        }

        public DataTable Detalle_Venta_Table
        {
            get
            {
                System.Data.DataTable dt = new DataTable();
                dt.Columns.Add("K_Articulo", (typeof(int)));
                dt.Columns.Add("D_Articulo", (typeof(string)));
                dt.Columns.Add("SKU", (typeof(string)));
                dt.Columns.Add("Lote", (typeof(string)));
                dt.Columns.Add("F_Caducidad", (typeof(string)));
                dt.Columns.Add("Precio", (typeof(decimal)));
                dt.Columns.Add("Cantidad", (typeof(Int32)));
                dt.Columns.Add("Total", (typeof(decimal)));
                dt.Columns.Add("Subtotal", (typeof(decimal)));
                dt.Columns.Add("IVA", (typeof(decimal)));
                dt.Columns.Add("Precio_Maximo_Publico", (typeof(decimal)));
                dt.Columns.Add("Descuento", (typeof(decimal)));
                dt.Columns.Add("Receta", (typeof(bool)));
                dt.Columns.Add("K_Medico", (typeof(string)));
                dt.Columns.Add("D_Medico", (typeof(string)));
                dt.Columns.Add("Retiene", (typeof(bool)));
                dt.Columns.Add("Porcentaje", (typeof(decimal)));
                return dt;
            }
        }

        public DataTable Detalle_Pagos_Table
        {
            get
            {
                System.Data.DataTable dt = new DataTable();
                dt.Columns.Add("K_Tipo_Pago", (typeof(int)));
                dt.Columns.Add("D_Tipo_Pago", (typeof(string)));
                dt.Columns.Add("Monto_Pago", (typeof(decimal)));
                dt.Columns.Add("K_Banco_Tarjeta",(typeof(Int32)));
                dt.Columns.Add("No_Tarjeta_Credito", (typeof(string)));
                dt.Columns.Add("No_Tarjeta_Debito", (typeof(string)));
                dt.Columns.Add("Aprobacion", (typeof(string)));
                dt.Columns.Add("No_Operacion", (typeof(string)));
                dt.Columns.Add("No_Cheque", (typeof(string)));
                dt.Columns.Add("K_Banco_Cheque", (typeof(Int32)));
                dt.Columns.Add("Cuenta_Cheque", (typeof(string)));
                dt.Columns.Add("No_Transferencia", (typeof(string)));
                dt.Columns.Add("Cuenta_Transferencia", (typeof(string)));
                dt.Columns.Add("K_Banco_Transferencia", (typeof(Int32)));
                dt.Columns.Add("Referencia_Transferencia", (typeof(string)));
                return dt;
            }
        }

        public DataTable Detalle_PagosCXP_Table
        {
            get
            {
                System.Data.DataTable dt = new DataTable();
                dt.Columns.Add("K_Caja_Chica", (typeof(int)));
                dt.Columns.Add("K_Tipo_Pago", (typeof(int)));
                dt.Columns.Add("D_Tipo_Pago", (typeof(string)));
                dt.Columns.Add("Monto_Pago", (typeof(decimal)));
                dt.Columns.Add("K_Banco_Tarjeta", (typeof(Int32)));
                dt.Columns.Add("No_Tarjeta_Credito", (typeof(string)));
                dt.Columns.Add("No_Tarjeta_Debito", (typeof(string)));
                dt.Columns.Add("Aprobacion", (typeof(string)));
                dt.Columns.Add("No_Operacion", (typeof(string)));
                dt.Columns.Add("No_Cheque", (typeof(string)));
                dt.Columns.Add("K_Banco_Cheque", (typeof(Int32)));
                dt.Columns.Add("Cuenta_Cheque", (typeof(string)));
                dt.Columns.Add("No_Transferencia", (typeof(string)));
                dt.Columns.Add("Cuenta_Transferencia", (typeof(string)));
                dt.Columns.Add("K_Banco_Transferencia", (typeof(Int32)));
                dt.Columns.Add("Referencia_Transferencia", (typeof(string)));
                return dt;
            }
        }

        public DataTable DetallePagoCxPType
         {
            get
            {
               System.Data.DataTable dt = new DataTable();
               dt.Columns.Add("K_Cuenta_Pagar", (typeof(int)));
               dt.Columns.Add("Serie", (typeof(string)));
               dt.Columns.Add("Folio", (typeof(string)));
               dt.Columns.Add("ImportePagar", (typeof(decimal)));

               return dt;
            }
        }

        public DataTable DetallePagoType
        {
            get
            {
                System.Data.DataTable dt = new DataTable();
                dt.Columns.Add("K_Tipo_Pago", (typeof(int)));
                dt.Columns.Add("D_Tipo_Pago", (typeof(string)));
                dt.Columns.Add("Monto_Pago", (typeof(decimal)));
                dt.Columns.Add("K_Banco_Tarjeta", (typeof(Int32)));
                dt.Columns.Add("No_Tarjeta_Credito", (typeof(string)));
                dt.Columns.Add("No_Tarjeta_Debito", (typeof(string)));
                dt.Columns.Add("Aprobacion", (typeof(string)));
                dt.Columns.Add("No_Operacion", (typeof(string)));
                dt.Columns.Add("No_Cheque", (typeof(string)));
                dt.Columns.Add("K_Banco_Cheque", (typeof(Int32)));
                dt.Columns.Add("Cuenta_Cheque", (typeof(string)));
                dt.Columns.Add("No_Transferencia", (typeof(string)));
                dt.Columns.Add("Cuenta_Transferencia", (typeof(string)));
                dt.Columns.Add("K_Banco_Transferencia", (typeof(Int32)));
                dt.Columns.Add("Referencia_Transferencia", (typeof(string)));
                return dt;
            }
        }

        public DataTable DetalleVentaType
        {
            get
            {
                System.Data.DataTable dt = new DataTable();
                dt.Columns.Add("K_Articulo", (typeof(int)));
                dt.Columns.Add("D_Articulo", (typeof(string)));
                dt.Columns.Add("SKU", (typeof(string)));
                dt.Columns.Add("Lote", (typeof(string)));
                dt.Columns.Add("F_Caducidad", (typeof(string)));
                dt.Columns.Add("Precio", (typeof(decimal)));
                dt.Columns.Add("Cantidad", (typeof(short)));
                dt.Columns.Add("Total", (typeof(decimal)));
                dt.Columns.Add("Subtotal", (typeof(decimal)));
                dt.Columns.Add("IVA", (typeof(decimal)));
                dt.Columns.Add("K_Movimiento_Inventario", (typeof(int)));
                dt.Columns.Add("K_Medico", (typeof(int)));
                dt.Columns.Add("Retiene", (typeof(bool)));
                return dt;
            }
        }

        public DataTable Articulos_DetalleAmbulancia_Table
        {
            get
            {
                System.Data.DataTable dt = new DataTable();
                dt.Columns.Add("K_Articulo", (typeof(int)));
                dt.Columns.Add("D_Articulo", (typeof(string)));
                dt.Columns.Add("Precio", (typeof(double)));
                dt.Columns.Add("Cantidad", (typeof(short)));      
                dt.Columns.Add("Subtotal", (typeof(double)));
                dt.Columns.Add("IVA", (typeof(double)));
                dt.Columns.Add("Total", (typeof(double)));
                return dt;
            }
        }

        public DataTable PedidosDetalle_Type
        {
            get
            {
                System.Data.DataTable dt = new DataTable();
                dt.Columns.Add("K_Articulo", (typeof(int)));
                dt.Columns.Add("Cantidad", (typeof(int)));
                dt.Columns.Add("SKU", (typeof(string)));
                dt.Columns.Add("K_Tipo_Producto", (typeof(int)));
                dt.Columns.Add("K_Unidad_Medida", (typeof(int)));          
                dt.Columns.Add("Precio_Unitario", (typeof(decimal)));
                dt.Columns.Add("PorcentajeDescuento", (typeof(decimal)));
                dt.Columns.Add("Descuento", (typeof(decimal)));
                dt.Columns.Add("Subtotal", (typeof(decimal)));
                dt.Columns.Add("Tasa_IVA", (typeof(decimal)));
                dt.Columns.Add("Total_IVA", (typeof(decimal)));
                dt.Columns.Add("Total_Detalle", (typeof(decimal)));
                dt.Columns.Add("Comentarios", (typeof(string)));
                dt.Columns.Add("B_Facturado", (typeof(bool)));
                dt.Columns.Add("D_Articulo", (typeof(String)));
                dt.Columns.Add("D_Tipo_Producto", (typeof(String)));
                dt.Columns.Add("D_Unidad_Medida", (typeof(String)));
                return dt;
            }
        }

        public DataTable Detalle_Articulos_Devolucion_Table
        {
            get
            {
                System.Data.DataTable dt = new DataTable();
                dt.Columns.Add("K_Articulo", (typeof(int)));
                dt.Columns.Add("Precio_Unitario", (typeof(decimal)));
                dt.Columns.Add("Cantidad", (typeof(int)));
                dt.Columns.Add("SubTotal", (typeof(decimal)));
                dt.Columns.Add("Porcentaje_Iva", (typeof(decimal)));
                dt.Columns.Add("IVA", (typeof(decimal)));
                dt.Columns.Add("Monto_Total", (typeof(decimal)));
                return dt;
            }
        }

        public DataTable TDetalles //Transferencias de Artículos
        {
            get
            {
                System.Data.DataTable dt = new DataTable();
                dt.Columns.Add("K_Articulo", (typeof(int)));
                dt.Columns.Add("Cantidad", (typeof(int)));
                dt.Columns.Add("K_Movimiento_Inventario", (typeof(int)));
                dt.Columns.Add("Lote", (typeof(String)));
                dt.Columns.Add("F_Caducidad", (typeof(DateTime)));
                dt.Columns.Add("D_Articulo", (typeof(String)));
                dt.Columns.Add("D_Unidad_Medida", (typeof(String)));
                dt.Columns.Add("SKU", (typeof(String)));
                return dt;
            }
        }

        public DataTable Usuarios_Almacenes_Type
        {
            get
            {
                System.Data.DataTable dt = new DataTable();
                dt.Columns.Add("K_Usuario", (typeof(int)));
                dt.Columns.Add("K_Almacen", (typeof(int)));
                dt.Columns.Add("D_Almacen", typeof(String));
                dt.Columns.Add("K_Oficina", typeof(int));
                dt.Columns.Add("D_Oficina", typeof(String));       
                return dt;
            }
        }

        public DataTable PDF_Inventario_Type
        {
            get
            {
                System.Data.DataTable dt = new DataTable();
                dt.Columns.Add("K_Factura", (typeof(int)));
                dt.Columns.Add("K_Factura_Detalle", (typeof(int)));
                dt.Columns.Add("k_Movimiento_Inventario", (typeof(int)));
                dt.Columns.Add("k_Movimiento_InventarioPT", (typeof(int)));
                dt.Columns.Add("K_Producto", (typeof(int)));
                dt.Columns.Add("K_Articulo", (typeof(int)));
                dt.Columns.Add("Cantidad", (typeof(decimal)));
                dt.Columns.Add("Lote", (typeof(string)));


                return dt;
            }
        }

        public DataTable PagoPrecierreType
        { 
            get
            {
                System.Data.DataTable dt = new DataTable();
                dt.Columns.Add("K_Tipo_Pago", (typeof(int)));
                dt.Columns.Add("Monto_Pago", (typeof(string)));
                return dt;
            }
        }

        public DataTable DetallePagoCXCType
        {
            get
            {
                System.Data.DataTable dt = new DataTable();
                dt.Columns.Add("K_Factura", (typeof(int)));
                dt.Columns.Add("Serie", (typeof(string)));
                dt.Columns.Add("K_Tipo_Pago", (typeof(int)));
                dt.Columns.Add("Total_Factura", (typeof(decimal)));
                dt.Columns.Add("Monto_Pago", (typeof(decimal)));
                dt.Columns.Add("K_Banco_Tarjeta", (typeof(int)));
                dt.Columns.Add("No_Tarjeta_Credito", (typeof(string)));
                dt.Columns.Add("No_Tarjeta_Debito", (typeof(string)));
                dt.Columns.Add("Aprobacion", (typeof(string)));
                dt.Columns.Add("No_Operacion", (typeof(string)));
                dt.Columns.Add("No_Cheque", (typeof(string)));
                dt.Columns.Add("K_Banco_Cheque", (typeof(int)));
                dt.Columns.Add("Cuenta_Cheque", (typeof(string)));
                dt.Columns.Add("No_Transferencia", (typeof(string)));
                dt.Columns.Add("Cuenta_Transferencia", (typeof(string)));
                dt.Columns.Add("K_Banco_Transferencia", (typeof(Int32)));
                dt.Columns.Add("Referencia_Transferencia", (typeof(string)));
                dt.Columns.Add("K_Anticipo", (typeof(Int32)));
                return dt;
            }
        }

        public DataTable DetallePagoCXCTypeMultiCliente
        {
            get
            {
                System.Data.DataTable dt = new DataTable();
                dt.Columns.Add("K_Oficina", (typeof(int)));
                dt.Columns.Add("K_Cliente", (typeof(int)));
                dt.Columns.Add("K_Liquidacion_CXC", (typeof(int)));
                dt.Columns.Add("K_Cuenta_Cliente", (typeof(int)));
                dt.Columns.Add("K_Cuenta_Empresa", (typeof(int)));
                dt.Columns.Add("K_Factura", (typeof(int)));
                dt.Columns.Add("K_Tipo_Pago", (typeof(int)));
                dt.Columns.Add("Total_Factura", (typeof(decimal)));
                dt.Columns.Add("Monto_Pago", (typeof(decimal)));
                dt.Columns.Add("K_Banco_Tarjeta", (typeof(int)));
                dt.Columns.Add("No_Tarjeta_Credito", (typeof(string)));
                dt.Columns.Add("No_Tarjeta_Debito", (typeof(string)));
                dt.Columns.Add("Aprobacion", (typeof(string)));
                dt.Columns.Add("No_Operacion", (typeof(string)));
                dt.Columns.Add("No_Cheque", (typeof(string)));
                dt.Columns.Add("K_Banco_Cheque", (typeof(int)));
                dt.Columns.Add("Cuenta_Cheque", (typeof(string)));
                dt.Columns.Add("No_Transferencia", (typeof(string)));
                dt.Columns.Add("Cuenta_Transferencia", (typeof(string)));
                dt.Columns.Add("K_Banco_Transferencia", (typeof(Int32)));
                dt.Columns.Add("Referencia_Transferencia", (typeof(string)));
                dt.Columns.Add("K_Anticipo", (typeof(Int32)));
                dt.Columns.Add("Serie", (typeof(string)));
                return dt;
            }
        }

        public DataTable Clientes_Type
        {
            get
            {
                System.Data.DataTable dt = new DataTable();
                dt.Columns.Add("K_Cliente", (typeof(int)));
                return dt;
            }
        }

        public DataTable Almacenes_Type
        {
            get
            {
                System.Data.DataTable dt = new DataTable();
                dt.Columns.Add("K_Almacen", (typeof(int)));
                return dt;
            }
        }

        public DataTable Laboratorios_Type
        {
            get
            {
                System.Data.DataTable dt = new DataTable();
                dt.Columns.Add("K_Laboratorio", (typeof(int)));
                return dt;
            }
        }

        public DataTable DetalleVentaPrivadaType
        {
            get
            {
                System.Data.DataTable dt = new DataTable();
                dt.Columns.Add("K_Factura", (typeof(Int32)));
                dt.Columns.Add("K_Factura_Detalle", (typeof(Int32)));
                dt.Columns.Add("K_Movimiento_Inventario", (typeof(Int32)));
                dt.Columns.Add("K_Articulo", (typeof(Int32)));
                dt.Columns.Add("Cantidad", (typeof(Int32)));
                dt.Columns.Add("Lote", (typeof(string)));
                return dt;
            }
        }

        #endregion


        #region "Se crean todas las tablas globales"
        //public static System.Data.DataTable dtModulos = new System.Data.DataTable();  
        public DataTable BaseDtDatos = new DataTable("Datos");
        public DataTable BasedtDatosConFiltro = new DataTable();
        public DataTable BaseDtPermisos = new DataTable();
        #endregion


        //TODO: *****AQUI SE DECLARAN LOS BOTONES DE LA BARRA DE HERRAMIENTAS
        #region "Declaración de Controles"
        public ToolStrip BaseBarraHerramientas
        {
            get { return this.BarraHerramientas; }
        }


        public ToolStripStatusLabel BaseEtiquetaEstatus
        {
            get { return this.lblEstatus; }
        }
        public ToolStripStatusLabel BaseEtiquetaRefrescar
        {
            get { return this.lblRefrescar; }
        }
        public ToolStripButton BaseBotonNuevo
        {
            get { return this.btnNuevo; }
        }
        public ToolStripButton BaseBotonModificar
        {
            get { return this.btnModificar; }
        }
        public ToolStripButton BaseBotonCancelar
        {
            get { return this.btnCancelar; }
        }
        public ToolStripButton BaseBotonBorrar
        {
            get { return this.btnBorrar; }
        }
        public ToolStripButton BaseBotonGuardar
        {
            get { return this.btnGuardar; }
        }
        public ToolStripButton BaseBotonReporte
        {
            get { return this.btnReporte; }
        }
        public ToolStripButton BaseBotonExcel
        {
            get { return this.btnExcel; }
        }
        public ToolStripButton BaseBotonEscanear
        {
            get { return this.btnEscanear; }
        }

        public ToolStripButton BaseBotonEtiqueta
        {
            get { return this.btnEtiqueta; }
        }

        public ToolStripButton BaseBotonProceso1
        {
            get { return this.btnProceso1; }
        }
        public ToolStripButton BaseBotonProceso2
        {
            get { return this.btnProceso2; }
        }
        public ToolStripButton BaseBotonProceso3
        {
            get { return this.btnProceso3; }
        }
        public ToolStripButton BaseBotonProceso4
        {
            get { return this.btnProceso4; }
        }
        public ToolStripButton BaseBotonProceso5
        {
            get { return this.btnProceso5; }
        }
        public ToolStripButton BaseBotonProceso6
        {
            get { return this.btnProceso6; }
        }
        public ToolStripButton BaseBotonProceso7
        {
            get { return this.btnProceso7; }
        }
        public ToolStripButton BaseBotonCorreo
        {
            get { return this.btnCorreo; }
        }
        public ToolStripButton BaseBotonAfectar
        {
            get { return this.btnAfectar; }
        }
        public ToolStripButton BaseBotonBuscar
        {
            get { return this.btnBuscar; }
        }
        public ToolStripButton BaseBotonImpresora
        {
            get { return this.btnImpresora; }
        }
        #endregion


        //TODO: ***** AQUI SE DECLARAN LOS EVENTOS CLICK DE CADA BOTON DE LA BARRA DE HERRAMIENTAS
        #region "Declara Eventos Click de Cada Botón"

        private void btnSalir_Click(object sender, EventArgs e)
        {
            BaseMetodoSalir();
        }

        public void btnNuevo_Click(object sender, EventArgs e)
        {
            CambiaTitulo(sender);
            BaseMetodoLimpiaControles();
            HabilitaBotones(sender, false);
            BaseBotonNuevoClick();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CambiaTitulo(sender);
            HabilitaBotones(sender, false);
            BaseBotonModificarClick();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CambiaTitulo(sender);
            HabilitaBotones(sender);
            BaseBotonCancelarClick();

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            BaseBotonBorrarClick();
            if (!BaseErrorResultado)
            {
                CambiaTitulo(sender);
                HabilitaBotones(sender);
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BaseBotonGuardarClick();
            if (!BaseErrorResultado)
            {
                CambiaTitulo(sender);
                HabilitaBotones(sender);
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            BaseBotonReporteClick();

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            BaseBotonExcelClick();
        }
        private void btnProceso1_Click(object sender, EventArgs e)
        {
            BaseBotonProceso1Click();
        }
        private void btnPtoceso2_Click(object sender, EventArgs e)
        {
            BaseBotonProceso2Click();
        }
        private void btnProceso3_Click(object sender, EventArgs e)
        {
            BaseBotonProceso3Click();
        }
        private void btnAfectar_Click(object sender, EventArgs e)
        {
            BaseBotonAfectarClick();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BaseBotonBuscarClick();
        }
        private void lblRefrescar_Click(object sender, EventArgs e)
        {
            CambiaTitulo(sender);
            BaseBotonRefrescarClick();
        }
        #endregion

        //TODO: ***** AQUI LOS METODOS QUE SE INVOCAN CON CADA CLICK DE LOS BOTONES DE LA BARRA DE HERRAMIENTAS
        #region "Métodos Click de los Botones de la Barra de Herramientas"
        public virtual void BaseBotonNuevoClick()
        {
            
        }
        public virtual void BaseBotonModificarClick()
        {

        }
        public virtual void BaseBotonCancelarClick()
        {

        }
        public virtual void BaseBotonBorrarClick()
        {

        }
        public virtual void BaseBotonGuardarClick()
        {

        }
        public virtual bool BaseFuncionValidaciones()
        {
            bool bREs = true;

            return bREs;
        }
        public virtual void BaseBotonReporteClick()
        {
            //Form frmPadre = (Form)((ToolStripButton)sender).GetCurrentParent().GetContainerControl();
            BaseMetodoMostrarReporte();
            if (!BaseErrorResultado)
            {
                Frm_Reportes frmReporte = new Frm_Reportes();
                frmReporte.P_Titulo = ReporteTitulo;
                //frmReporte.P_ReporteRPT = ReporteRPT;
                frmReporte.P_TablaCorreo = ReportedtCorreo;
                frmReporte.SerieFolio = BaseSerieFolio;
                frmReporte.ShowDialog();
            }
        }
        public virtual void BaseBotonExcelClick()
        {
            if (BaseDtDatos == null)
            {
                MessageBox.Show("NO EXISTE INFORMACION PARA EXPORTAR...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Archivos Excel (*.xls)|*.xls";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string Hoja = "Datos";
                DataTable dtExcel = BaseDtDatos;
                //BorraColumnaCamposBusqueda(ref dtExcel);
                //fx.ExportToExcel(dtExcel, saveFileDialog1.FileName, Hoja);
                fx.ExportToOpenExcel(dtExcel, saveFileDialog1.FileName, Hoja);
            }
        }
        public virtual void BaseBotonEscanearClick()
        {

        }
        public virtual void BaseBotonEtiquetaClick()
        {

        }
        public virtual void BaseBotonProceso1Click()
        {

        }
        public virtual void BaseBotonProceso2Click()
        {

        }
        public virtual void BaseBotonProceso3Click()
        {

        }
        public virtual void BaseBotonProceso4Click()
        {

        }
        public virtual void BaseBotonProceso5Click()
        {

        }
        public virtual void BaseBotonProceso6Click()
        {

        }
        public virtual void BaseBotonProceso7Click()
        {

        }
        public virtual void BaseBotonCorreoClick()
        {

        }

        public virtual void BaseBotonAfectarClick()
        {

        }
        public virtual void BaseBotonBuscarClick()
        {

        }
        public virtual void BaseBotonRefrescarClick()
        {
            BaseMetodoRecarga();
        }

        public virtual void BaseBotonImpresoraClick()
        {

        }

        #endregion

        //TODO: ***** AQUI METODOS GENERALES QUE NO SE INVOCAN DESDE BOTON
        #region "Métodos Generales"

        public void MostrarReporte(ReportDocument rpt,string titulo = "")
        {
            if (titulo.Trim().Length > 0)
                ReporteTitulo = titulo;
            Frm_Reportes frmReporte = new Frm_Reportes();
            frmReporte.P_Titulo = ReporteTitulo;
            frmReporte.P_ReporteRPT = rpt;
            frmReporte.ShowDialog();
        }
        public void MostrarTodosBotones(bool B_Mostrar = true )
        {
            foreach (ToolStripButton button in BarraHerramientas.Items)
            {
                if (button.Name != "btnSalir")
                    button.Visible = B_Mostrar;
            }
        }
 
        public void MostrarBotones(string listaBotones,bool B_Mostrar = true)
        {
            var botones = listaBotones.Split(',');

            foreach(var item in botones)
            {
                string boton = item;
                if (!boton.Contains("btn"))
                    boton = "btn" + boton.Trim();

                ToolStripButton bot = (ToolStripButton)BarraHerramientas.Items.Find(boton,true).FirstOrDefault();
                if(bot != null)
                    bot.Visible = B_Mostrar;
            }
        }

        public override void CargaTablasGlobales()
        {
            try
            {
                BaseDtPermisos = sqlSeguridad.Sk_Permisos();
            }
            catch
            {

            }
        }
        public virtual void BaseMetodoRecarga()
        {

        }
        public virtual void BaseMetodoLimpiaControles()
        {


        }
        public virtual void BaseMetodoMostrarReporte()
        {

        }
        public virtual void BaseMetodoInicio()
        {
            btnBuscar.Visible = false;
            HabilitaBotones(null);
            BaseMetodoLimpiaControles();
            //Text = Text.ToUpper();
        }

        #endregion


        public FormaBase()
        {
            InitializeComponent();
            //MessageBox.Show("Inciando..");

        }
        private void FormaBase_Shown(object sender, EventArgs e)
        {
            //MessageBox.Show("Abriendo..");
        }
        private void FormaBase_Load(object sender, EventArgs e)
        {
            if (TipoVentana == tipoVentana.GENERAL)
                MostrarTodosBotones(false);
            BaseEtiquetaRefrescar.Visible = false;
            BaseEtiquetaEstatus.Visible = false;
            CargaTablasGlobales();
            BaseMetodoInicio();
            ConfiguraPermisos();
        }
        public void ConfiguraPermisos()
        {
            DataTable dtPermisos = LINQTablaCrucesFiltra(BaseDtPermisos, GlobalVar.K_Usuario, GlobalVar.K_Menu);
            if (dtPermisos.Rows.Count > 0)
            {
                if (btnNuevo.Visible)
                    btnNuevo.Visible = Convert.ToBoolean(dtPermisos.Rows[0]["B_Nuevo"]);
                if (btnModificar.Visible)
                    btnModificar.Visible = Convert.ToBoolean(dtPermisos.Rows[0]["B_Modificar"]);
                if (btnBorrar.Visible)
                    btnBorrar.Visible = Convert.ToBoolean(dtPermisos.Rows[0]["B_Borrar"]);
                if (btnGuardar.Visible)
                    btnGuardar.Visible = Convert.ToBoolean(dtPermisos.Rows[0]["B_Guardar"]);
                if (btnAfectar.Visible)
                    btnAfectar.Visible = Convert.ToBoolean(dtPermisos.Rows[0]["B_Afectar"]);
                if (btnReporte.Visible)
                    btnReporte.Visible = Convert.ToBoolean(dtPermisos.Rows[0]["B_Reporte"]);
                if (btnExcel.Visible)
                    btnExcel.Visible = Convert.ToBoolean(dtPermisos.Rows[0]["B_Excel"]);
            }
        }

        private void FormaBase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 113) //F2 Nuevo
            {
                if (BaseBotonNuevo.Visible && BaseBotonNuevo.Enabled)
                {
                    sender = btnNuevo;
                    btnNuevo_Click(sender, e);
                }
            }
            if (e.KeyValue == 114) //F3 Modificar
            {
                if (BaseBotonModificar.Visible && BaseBotonModificar.Enabled)
                {
                    sender = btnModificar;
                    btnModificar_Click(sender, e);
                }
            }
            if (e.KeyValue == 115) //F4 Borrar
            {
                if (BaseBotonBorrar.Visible && BaseBotonBorrar.Enabled)
                {
                    sender = btnBorrar;
                    btnBorrar_Click(sender, e);
                }
            }
            if (e.KeyValue == 116) //F5 Guardar
            {
                if (BaseBotonGuardar.Visible && BaseBotonGuardar.Enabled)
                {
                    sender = btnGuardar;
                    btnGuardar_Click(sender, e);
                }
            }
            if (e.KeyValue == 117) //F6 Afecta
            {
                if (BaseBotonAfectar.Visible && BaseBotonAfectar.Enabled)
                {
                    sender = btnAfectar;
                    btnAfectar_Click(sender, e);
                }
            }
            if (e.KeyValue == 118) //F7  Buscar
            {
                if (BaseBotonBuscar.Visible && BaseBotonBuscar.Enabled)
                {
                    sender = btnBuscar;
                    btnBuscar_Click(sender, e);
                }
            }

            if (e.KeyValue == 119) //F8  Reporte
            {
                if (BaseBotonReporte.Visible && BaseBotonReporte.Enabled)
                {
                    sender = btnReporte;
                    btnReporte_Click(sender, e);
                }
            }
            if (e.KeyValue == 120) //F9 Excel
            {
                if (BaseBotonExcel.Visible && BaseBotonExcel.Enabled)
                {
                    sender = btnExcel;
                    btnExcel_Click(sender, e);
                }
            }
            if (e.KeyData == (Keys.Delete))
            {
                e.Handled = true;
            }
        }

        public void CambiaTitulo(object sender, bool B_ExisteRen = false)
        {
            string tipo = string.Empty;
            string objeto = sender.GetType().Name;
            Form forma = new Form();

            if (sender.GetType().Name.Trim() == "ToolStripStatusLabel")
            {
                ToolStripStatusLabel lbl = (ToolStripStatusLabel)sender;
                tipo = string.Empty;
                forma = (Form)lbl.GetCurrentParent().Parent;
            }

            if (sender.GetType() == base.GetType())
            {
                forma = (Form)sender;
                tipo = "NUEVO";
            }

            if (B_ExisteRen == true)
                tipo = "";

            if (sender.GetType().Name == "ToolStripButton")
            {
                ToolStripButton btn = (ToolStripButton)sender;
                if (btn.GetCurrentParent() != null)
                {
                    forma = (Form)btn.GetCurrentParent().Parent;//.Parent.Parent;
                    switch (btn.Name)
                    {
                        case "btnModificar":
                            tipo = "MODIFICAR";
                            break;
                        case "btnNuevo":
                            tipo = "NUEVO";
                            break;
                        case "btnCancelar":
                            tipo = "CANCELAR";
                            break;
                    }
                }
            }

            if (sender.GetType().Name == "Button")
            {
                tipo = ""; //No es Nuevo
                Button btn = (Button)sender;
                forma = (Form)btn.Parent.Parent.Parent;
            }

            forma.Text = forma.Text.Replace("(Nuevo Registro)", "").Trim();
            forma.Text = forma.Text.Replace("(Modificar Registro)", "").Trim();
            if (tipo == "NUEVO")
                forma.Text = forma.Text + "  (Nuevo Registro)";
            if (tipo == "MODIFICAR")
                forma.Text = forma.Text + "  (Modificar Registro)";
        }

        public override void CambiaEtiquetaEstatus()
        {

        }

        public void HabilitaBotones(object sender, bool B_Habilitar = true)
        {
            if (BasePropiedadB_EsCataLogo)
            {
                btnCancelar.Visible = false;
                btnCancelar.Visible = !B_Habilitar;
            }

            btnGuardar.Enabled = !B_Habilitar;
            btnReporte.Enabled = B_Habilitar;
            btnExcel.Enabled = B_Habilitar;
            btnAfectar.Enabled = B_Habilitar;
            btnBuscar.Enabled = B_Habilitar;

            btnNuevo.Enabled = B_Habilitar;

            if (BaseDtDatos == null)
            {
                btnModificar.Enabled = false;
                btnBorrar.Enabled = false;
            }
            else
            {
                if (BaseDtDatos.Rows.Count == 0)
                {
                    btnModificar.Enabled = false;
                    btnBorrar.Enabled = false;
                }
                else
                {
                    btnModificar.Enabled = B_Habilitar;
                    btnBorrar.Enabled = B_Habilitar;
                }
            }

        }

        

        private void btnCorreo_Click(object sender, EventArgs e)
        {
            BaseBotonCorreoClick();
        }

        private void btnEscanear_Click(object sender, EventArgs e)
        {
            BaseBotonEscanearClick();
        }

        private void btnProceso4_Click(object sender, EventArgs e)
        {
            BaseBotonProceso4Click();
        }

        private void btnProceso5_Click(object sender, EventArgs e)
        {
            BaseBotonProceso5Click();
        }

        private void btnProceso6_Click(object sender, EventArgs e)
        {
            BaseBotonProceso6Click();

        }

        private void btnProceso7_Click(object sender, EventArgs e)
        {
            BaseBotonProceso7Click();
        }

        private void btnEtiqueta_Click(object sender, EventArgs e)
        {
            BaseBotonEtiquetaClick();
        }

        private void btnImpresora_Click(object sender, EventArgs e)
        {
            BaseBotonImpresoraClick();
        }
    }
}