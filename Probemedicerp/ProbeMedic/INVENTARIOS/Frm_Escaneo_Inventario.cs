using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using ProbeMedic.AppCode.BLL;

namespace ProbeMedic.INVENTARIOS
{
    public partial class Frm_Escaneo_Entrada_Almacen : Form
    {
        ImageConverter asd = new ImageConverter();
        ArrayList al_contador_articulo;
        ArrayList al_tablas_lotes;
        private string orden_compra;
        private string clave_proveedor;
        private string nombre_proveedor;
        private string no_factura;
        public DataTable dtDetalle = new DataTable();
        SQLRecepcion sqlRecepcion = new SQLRecepcion();
        SQLCompras sqlCompras = new SQLCompras();
        DataTable dtAlmacen = new DataTable();
        int res = 0;
        string msg = string.Empty;

        public Frm_Escaneo_Entrada_Almacen()
        {
            InitializeComponent();

            //Escaneo
            dgvEscaneoArticulos.Columns.Add("SKU", "SKU");
            dgvEscaneoArticulos.DefaultCellStyle.Font = new Font("Arial", 15);
            dgvEscaneoArticulos.Columns["SKU"].Width = 232;
            dgvEscaneoArticulos.Columns.Add(new DataGridViewImageColumn());
            dgvEscaneoArticulos.Columns[1].Width = 20;

            //Contador y descripción de los artículos
            /* 1) Descripción
             * 2) Cantidad nota
             * 3) Cantidad escaneada 
             * 4) SKU
             * 5) Botón para ingresar los lotes
             * */

            dgv_Escaneo_Contador.Columns.Add("id", "#");
            dgv_Escaneo_Contador.Columns.Add("descripcion", "Descripción");
            dgv_Escaneo_Contador.Columns.Add("cant_nota", "Cantidad Nota");
            dgv_Escaneo_Contador.Columns.Add("cant_escaneada", "Cantidad Escaneo");
            dgv_Escaneo_Contador.Columns.Add("sku", "Sku");
            dgv_Escaneo_Contador.Columns.Add("es_sobrante", "Sobrante");

            dgv_Escaneo_Contador.Columns.Add(new DataGridViewButtonColumn());

            dgv_Escaneo_Contador.Columns["id"].Visible = false;
            dgv_Escaneo_Contador.Columns["descripcion"].Width = 286;
            dgv_Escaneo_Contador.Columns["sku"].Width = 110;
            dgv_Escaneo_Contador.Columns["cant_nota"].Width = 70;
            dgv_Escaneo_Contador.Columns["es_sobrante"].Width = 70;
            dgv_Escaneo_Contador.Columns["cant_escaneada"].Width = 70;

            //Inicializamos la lista
            al_contador_articulo = new ArrayList();
            al_tablas_lotes = new ArrayList();
            //Hacemos foco en el campo del sku
            this.txtbx_entrada.Focus();
            //Datos de la orden

            //REVISAMOS SI 




        }
        //setes getes
        public string Orden_Compra
        {
            get
            {
                return this.orden_compra;
            }
            set
            {
                this.orden_compra = value;
            }
        }

        public string Clave_Proveedor
        {
            get
            {
                return this.clave_proveedor;
            }
            set
            {
                this.clave_proveedor = value;
            }
        }

        public string Numero_Factura
        {
            get
            {
                return this.no_factura;
            }
            set
            {
                this.no_factura = value;
            }
        }

        public string Nombre_Proveedor
        {
            get
            {
                return this.nombre_proveedor;
            }
            set
            {
                this.nombre_proveedor = value;
            }
        }

        private void txtbx_entrada_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("Enter");
        }

        private void txtbx_entrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((txtbx_entrada.Text).Trim().Length > 0)


                if ((e.KeyChar == (char)13) || (e.KeyChar == (char)11))
                {
                    agrega_Codigo_Barras(txtbx_entrada.Text);
                    //limpiamos el control
                    txtbx_entrada.Text = "";

                }

        }

        private Boolean agrega_Codigo_Barras(string aux)
        {
            Boolean b_agregado = true;



            b_agregado = agrega_articulo_contador(aux.Trim());




            return b_agregado;
        }

        private Boolean agrega_articulo_contador(string sku)
        {
            int index;
            int index_sobrante;
            string descp_articulo = "";
            int cantidad_nota = 0;
            int cont = 0;

            //Buscamos la descripción  del artículo de acuerdo a al orden de compra
            descp_articulo = (string)busca_valor_dt(this.dtDetalle, "D_Articulo", "SKU = " + "'" + sku + "'");

            if (descp_articulo.Length > 0)
            {
                lbl_nombre_producto.Text = descp_articulo;
                cantidad_nota = (int)busca_valor_dt(this.dtDetalle, "Cantidad_Nota", "SKU = " + "'" + sku + "'");

                dgvEscaneoArticulos.Rows.Insert(0, sku, asd.ConvertTo(Properties.Resources.Eliminar, System.Type.GetType("System.Byte[]")));
            }

            else
            {
                MessageBox.Show("El artículo escaneado no se encuentra en la orden de compra");
                return false;
            }


            //OJO: checar en bd que el SKU esté en las tablas

            //Si es la primera vez y un artículo válido lo ingresamos
            if (dgv_Escaneo_Contador.RowCount == 0)
            {
                dgv_Escaneo_Contador.Rows.Insert(0, al_contador_articulo.Count, descp_articulo, cantidad_nota, 1, sku, "NO", "Ingresar lote");
                dgv_Escaneo_Contador.Sort(this.dgv_Escaneo_Contador.Columns["id"], ListSortDirection.Ascending);

                al_contador_articulo.Add(sku);
                al_tablas_lotes.Add(new DataTable());

                index = al_contador_articulo.IndexOf(sku);
                cont = (int)dgv_Escaneo_Contador.Rows[index].Cells["cant_escaneada"].Value;

                if (cont > cantidad_nota)
                {
                    dgv_Escaneo_Contador.Rows[index].Cells["es_sobrante"].Value = "SI";
                }

            }
            else
            {
                //si hay datos está verificamos que no exista para agregarlo 
                index = al_contador_articulo.IndexOf(sku);


                if (index == -1)
                {
                    dgv_Escaneo_Contador.Rows.Insert(0, al_contador_articulo.Count, descp_articulo, cantidad_nota, 1, sku, "NO", "Ingresar lote");
                    dgv_Escaneo_Contador.Sort(this.dgv_Escaneo_Contador.Columns["id"], ListSortDirection.Ascending);

                    al_contador_articulo.Add(sku);
                    al_tablas_lotes.Add(new DataTable());



                }

                else
                {
                    //SI YA ESTÁ , PERO ES SOBRANTE 
                    cont = (int)dgv_Escaneo_Contador.Rows[index].Cells["cant_escaneada"].Value + 1;

                    if (cont > cantidad_nota)
                    {
                        index_sobrante = al_contador_articulo.LastIndexOf(sku);


                        //SI SE VA A INSERTAR UN SOBRANTE POR PRIMERA VEZ
                        if (index == index_sobrante)
                        {

                            dgv_Escaneo_Contador.Rows.Insert(0, al_contador_articulo.Count, descp_articulo, cantidad_nota, 1, sku, "SI", "Ingresar lote");
                            dgv_Escaneo_Contador.Sort(this.dgv_Escaneo_Contador.Columns["id"], ListSortDirection.Ascending);

                            al_contador_articulo.Add(sku);
                            al_tablas_lotes.Add(new DataTable());

                            // CAMBIAMOS COLOR DE FONDO CUANDO SEA SOBRANTE
                            index_sobrante = al_contador_articulo.LastIndexOf(sku);
                            dgv_Escaneo_Contador.Rows[index_sobrante].DefaultCellStyle.BackColor = Color.PaleVioletRed;

                        }
                        else
                        {
                            //SI YA EXISTE EL SOBRANTE HAY QUE INCREMENTAR
                            cont = (int)dgv_Escaneo_Contador.Rows[index_sobrante].Cells["cant_escaneada"].Value + 1;
                            dgv_Escaneo_Contador.Rows[index_sobrante].Cells["cant_escaneada"].Value = cont;



                        }

                    }
                    else
                    {
                        dgv_Escaneo_Contador.Rows[index].Cells["cant_escaneada"].Value = cont;
                        //Si hay datos en la tabla de lotes
                        if (((DataTable)al_tablas_lotes[index]).Rows.Count > 0)
                        {
                            dgv_Escaneo_Contador.Rows[index].DefaultCellStyle.BackColor = Color.LightGreen;
                        }
                        else
                            dgv_Escaneo_Contador.Rows[index].DefaultCellStyle.BackColor = Color.White;

                    }



                }


            }



            return true;
        }

        //Procedimiento que regresa la primer coincidencia dependiendo el criterio de un DataTable
        private object busca_valor_dt(DataTable tabla, string campo, string criterio)
        {
            object resultado;

            if (tabla.Rows.Count == 0)
            {

                return "";
            }

            DataRow[] registros;


            // Use the Select method to find all rows matching the filter.
            registros = tabla.Select(criterio);



            // Print column 0 of each returned row.
            if (registros.Length > 0)
                resultado = (object)registros[0][campo];
            else
                resultado = "";

            return resultado;

        }

        private void Frm_Escaneo_Entrada_Almacen_Load(object sender, EventArgs e)
        {
            // Datos de la orden de compra
            this.txtNoOrden.Text = this.Orden_Compra;
            this.txtClaveProveedor.Text = this.Clave_Proveedor;
            this.txtProveedor.Text = this.Nombre_Proveedor;
            this.txtNoDocto.Text = this.Numero_Factura;
            this.txtbx_entrada.Focus();

            // REVISAMOS SI EXISTE DATOS ESCANEADOS PREVIAMENTE
            DataTable tabla_almacenada = new DataTable();

            tabla_almacenada = Tabla_Escaneo_OrdenCompra_Almacenada(Convert.ToInt32(this.orden_compra.Trim()));


            if ((tabla_almacenada != null) && (tabla_almacenada.Rows.Count > 0))
            {
                //lamamos al método para agregar registros al datagrid y al array
                Agrega_Pre_Escaneo(tabla_almacenada);
                //ahora verificamos si hay registros para iluninar
            }

        }

        private bool Agrega_Pre_Escaneo(DataTable tabla)
        {
            bool resultado = true;
            int index;
            int index_sobrante;
            //K_Registro_Escaneo_NRecepcion, K_Orden_Compra, Factura , REN.K_Articulo , D_Articulo,  REN.SKU , F_Registro,K_Usuario_Registro, PC_Name,  
            //Cantidad_Requerida, Cantidad_Escaneada ,Cantidad_Lote, REN.Lote  ,REN.F_Caducidad,B_Sobrante

            try
            {
                foreach (DataRow dr in tabla.Rows)
                {
                    //Verificamos que el sku del artículo no se encuentre en la lista
                    if (al_contador_articulo.IndexOf(dr["SKU"].ToString()) == -1)
                    {
                        agrega_registros_dgv(Convert.ToInt32(dr["Cantidad_Escaneada"].ToString()), dr["SKU"].ToString());

                        //agregamos ahora la tabla en la lista al_tablas_lotes 
                        al_tablas_lotes[al_tablas_lotes.Count - 1] = Tabla_Lotes_Por_SKU(tabla, dr["SKU"].ToString(), Convert.ToInt32(dr["B_Sobrante"].ToString() == "False" ? 0 : 1));


                        int aux_index = al_contador_articulo.IndexOf(dr["SKU"].ToString());

                        //AQUÍ ARREGLAMOS LO DE ILUMINAR EN VERDE CUANDO YA TENGAN LOTES PRECARGADOS

                        if (((DataTable)al_tablas_lotes[aux_index]).Rows.Count > 0)
                        {
                            dgv_Escaneo_Contador.Rows[aux_index].DefaultCellStyle.BackColor = Color.LightGreen;
                        }
                        else
                            dgv_Escaneo_Contador.Rows[aux_index].DefaultCellStyle.BackColor = Color.White;


                    }
                    else
                    {
                        //si si hay que verificar si es sobrante
                        if (Convert.ToInt32(dr["B_Sobrante"].ToString() == "False" ? 0 : 1) == 1)
                        {
                            // si es la primera vez q se inserta el sobrante
                            index = al_contador_articulo.IndexOf(dr["SKU"].ToString());
                            index_sobrante = al_contador_articulo.LastIndexOf(dr["SKU"].ToString());

                            if (index == index_sobrante)
                            {
                                agrega_registros_dgv(Convert.ToInt32(dr["Cantidad_Escaneada"].ToString()), dr["SKU"].ToString());

                                //agregamos ahora la tabla en la lista al_tablas_lotes 
                                al_tablas_lotes[al_tablas_lotes.Count - 1] = Tabla_Lotes_Por_SKU(tabla, dr["SKU"].ToString(), Convert.ToInt32(dr["B_Sobrante"].ToString() == "False" ? 0 : 1));
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL MOSTRAR ESCANEO PREVIO " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                resultado = false;
            }




            return resultado;
        }

        private DataTable Tabla_Lotes_Por_SKU(DataTable dt_articulos, string sku, int b_sobrante)
        {
            DataTable tabla = new DataTable();
            DataRow[] registros;


            registros = dt_articulos.Select("SKU = '" + sku + "' AND B_Sobrante = " + Convert.ToString(b_sobrante));

            tabla.Columns.Add("lote");
            tabla.Columns.Add("cantidad");
            tabla.Columns.Add("fecha_caducidad");

            foreach (DataRow dr in registros)
            {
                tabla.Rows.Add(dr["Lote"].ToString(), dr["Cantidad_Lote"].ToString(), dr["F_Caducidad"].ToString());
            }

            return tabla;
        }


        private void dgv_Escaneo_Contador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;

                DataTable datos = (DataTable)al_tablas_lotes[index];
                Frm_Captura_Lotes frm_Captura_lote = new Frm_Captura_Lotes(datos);



                if (dgv_Escaneo_Contador.CurrentCell.Value.ToString() == "Ingresar lote")
                {

                    llama_form_lotes(frm_Captura_lote, index);
                }
            }
            catch (Exception)
            {

            }


        }

        private void llama_form_lotes(Frm_Captura_Lotes form, int index)
        {


            //Llenamos los registros (si tiene) del datagrid de los lotes
            //DataTable datos = (DataTable)al_tablas_lotes[index];
            form.txt_articulo.Text = (string)dgv_Escaneo_Contador.Rows[dgv_Escaneo_Contador.CurrentRow.Index].Cells["descripcion"].Value;
            form.txt_sku.Text = (string)dgv_Escaneo_Contador.Rows[dgv_Escaneo_Contador.CurrentRow.Index].Cells["sku"].Value;
            form.Cantidad_Escaneada = (int)dgv_Escaneo_Contador.Rows[dgv_Escaneo_Contador.CurrentRow.Index].Cells["cant_escaneada"].Value;

            form.ShowDialog();



            //si guardo algo iluminamos de verde
            if (form.Datos_Tabla.Rows.Count > 0)
            {
                if (dgv_Escaneo_Contador.Rows[index].Cells["es_sobrante"].Value.ToString() == "NO")
                    dgv_Escaneo_Contador.Rows[index].DefaultCellStyle.BackColor = Color.LightGreen;
                //guardamos el datatable
                al_tablas_lotes[index] = (DataTable)form.Datos_Tabla;
            }
            else
            {
                if (dgv_Escaneo_Contador.Rows[index].Cells["es_sobrante"].Value.ToString() == "NO")
                    dgv_Escaneo_Contador.Rows[index].DefaultCellStyle.BackColor = Color.White;
            }



        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            DataTable tabla_total = merge_tablas_lotes();

            Int32 Cantidad_Escaneada = 0;
            decimal Cont_CantLotes = 0;

            foreach (DataRow row in tabla_total.Rows)
            {
                if (row["b_sobrante"].ToString() == "1")
                {
                    Cantidad_Escaneada = Convert.ToInt32(row["canatidad_escaneada"].ToString());
                    Cont_CantLotes = Cont_CantLotes + Convert.ToInt32(row["cantidad_lote"].ToString());
                }

            }

            if (Cont_CantLotes < Cantidad_Escaneada)
            {
                MessageBox.Show("FALTAN LOTES POR ASIGNAR A ARTÍCULOS SOBRANTES \r\n" +
                    "Cantidad sobrantes escaneada: " + Cantidad_Escaneada + "\r\n" +
                    "Cantidad asignada lotes: " + Cont_CantLotes + ".", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tabla_total.Rows.Count > 0)
            {
                res = sqlRecepcion.In_Registro_Escaneo_NRecepcion(Convert.ToInt32(txtNoOrden.Text), txtNoDocto.Text, tabla_total);

                if (res == -1)
                {
                    MessageBox.Show("EXISTEN ESCANEADOS ARTICULOS DE LA ORDEN DE COMPRA", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Registro almacenado correctamente");
                    COMPRAS.FRM_MuestraSobFaltantes frm = new COMPRAS.FRM_MuestraSobFaltantes();
                    frm.K_Orden_Compra_ = Convert.ToInt32(txtNoOrden.Text);
                    frm.ShowDialog();
                    this.Close();
                }
            }
        }

        private DataTable merge_tablas_lotes()
        {
            DataTable tabla = new DataTable();
            int K_Orden_Compra = Convert.ToInt32(orden_compra);
            string Factura = no_factura;
            string sku;
            int k_articulo = 1;
            int cantidad_requerida;
            int cantidad_escaneada;
            int cantidad_lote;
            string lote;
            string fecha_caducidad;
            int b_sobrante;

            //Agregamos las columnas

            tabla.Columns.Add("k_orden_compra");
            tabla.Columns.Add("factura");
            tabla.Columns.Add("sku");
            tabla.Columns.Add("k_articulo");
            tabla.Columns.Add("cantidad_requerida");
            tabla.Columns.Add("canatidad_escaneada");
            tabla.Columns.Add("cantidad_lote");
            tabla.Columns.Add("lote");
            tabla.Columns.Add("fecha_caducidad");
            tabla.Columns.Add("b_sobrante");

            foreach (DataGridViewRow row in this.dgv_Escaneo_Contador.Rows)
            {
                //recorremos la lista al_tablas_lotes
                sku = row.Cells["sku"].Value.ToString();
                k_articulo = 1;
                cantidad_requerida = Convert.ToInt32(row.Cells["cant_nota"].Value.ToString());
                cantidad_escaneada = Convert.ToInt32(row.Cells["cant_escaneada"].Value.ToString());
                b_sobrante = row.Cells["es_sobrante"].Value.ToString() == "SI" ? 1 : 0;

                //foreach (DataRow dr in dt.Rows)

                // checamos si hay lotes almacenados mandamos msj de error
                if (((DataTable)al_tablas_lotes[row.Index]).Rows.Count == 0)
                {
                    MessageBox.Show("El artículo " + row.Cells["descripcion"].Value.ToString() + " " + (b_sobrante == 1 ? "(sobrante)" : " ") + " no tiene capturado los lotes favor de capturar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new DataTable();
                }


                foreach (DataRow dr in ((DataTable)al_tablas_lotes[row.Index]).Rows)
                {
                    cantidad_lote = Convert.ToInt32(dr["cantidad"].ToString());
                    lote = dr["lote"].ToString();
                    fecha_caducidad = dr["fecha_caducidad"].ToString();
                    string year = fecha_caducidad.Split('/')[2].ToString(), month = fecha_caducidad.Split('/')[1].ToString(), day = fecha_caducidad.Split('/')[0].ToString();
                    DateTime date_fecha_caducidad = new DateTime(Convert.ToInt32(fecha_caducidad.Split('/')[2].ToString()), Convert.ToInt32(fecha_caducidad.Split('/')[1].ToString()), Convert.ToInt32(fecha_caducidad.Split('/')[0].ToString()));

                    //agregamos la tabla
                    tabla.Rows.Add(K_Orden_Compra, Factura, sku, k_articulo, cantidad_requerida, cantidad_escaneada, cantidad_lote, lote, date_fecha_caducidad, b_sobrante);
                }


            }

            return tabla;
        }

        private void txtMultiplicador_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)13) == true ? true : false;

            if (e.KeyChar == (char)13 || e.KeyChar == (char)Keys.Tab)
            {
                agrega_registros_dgv(Convert.ToInt32(txtMultiplicador.Text), this.txtbx_entrada.Text);
                this.txtMultiplicador.Text = "";
                this.GetNextControl(ActiveControl, false).Focus();
            }
        }

        private bool agrega_registros_dgv(int num_registros, string sku)
        {
            bool res = true;

            //if (this.dgvIngresaLote.DataSource == null && this.Datos_Tabla.Rows.Count == 0)
            //    agrega_columnas_iniciales();
            if (sku.Trim() == "")
            {
                MessageBox.Show("No se ha ingresado el SKU");
                return false;

            }

            for (int i = 0; i < num_registros; i++)
            {
                agrega_Codigo_Barras(sku);
                //limpiamos el control

            }

            txtbx_entrada.Text = "";
            return res;

        }

        private DataTable Tabla_Escaneo_OrdenCompra_Almacenada(int num_orden_compra)
        {
            DataTable tabla = new DataTable();

            // aquí llamamos a el sp Sk_Registro_Escaneo_NRecepcion
            tabla = sqlRecepcion.Sk_Registro_Escaneo_NRecepcion(num_orden_compra);

            return tabla;
        }

        private void dgv_Escaneo_Contador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Enter))
            {
                if (blnCeldaImportes())
                {
                    int index = Convert.ToInt32(dgv_Escaneo_Contador.CurrentRow.Index);

                    DataTable datos = (DataTable)al_tablas_lotes[index];
                    Frm_Captura_Lotes frm_Captura_lote = new Frm_Captura_Lotes(datos);

                    if (dgv_Escaneo_Contador.CurrentCell.Value.ToString() == "Ingresar lote")
                    {

                        llama_form_lotes(frm_Captura_lote, index);
                    }
                }
            }
        }
        private bool blnCeldaImportes()
        {
            if (dgv_Escaneo_Contador.CurrentCell == null)
                return false;
            //if (B_NoEntrar == false)
            //    return false;

            return (dgv_Escaneo_Contador.CurrentCell.ColumnIndex == 6);
        }

        private void dgvEscaneoArticulos_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Skip the Column and Row headers
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            var dataGridView = (sender as DataGridView);
            //Check the condition as per the requirement casting the cell value to the appropriate type
            if (e.ColumnIndex == 1)//&& (string)dataGridView.Rows[e.RowIndex].Cells[0].Value == "2")
                dgvEscaneoArticulos.Cursor = Cursors.Hand;
            else
                dgvEscaneoArticulos.Cursor = Cursors.Default;
        }

        private void dgvEscaneoArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
                elimina_registros_dgv(dgvEscaneoArticulos.CurrentRow.Cells["sku"].Value.ToString());
        }

        private void elimina_registros_dgv(string sku)
        {
            elimina_Codigo_Barras(sku);
        }
        private bool valida_hay_sobrante(string sku)
        {
            foreach (DataGridViewRow row in dgv_Escaneo_Contador.Rows)
            {
                if ((string)row.Cells["sku"].Value == sku && (string)row.Cells["es_sobrante"].Value == "SI")
                {
                    return true;
                }
            }
            return false;
        }
        private bool elimina_Codigo_Barras(string sku)
        {
            int index;
            int index_sobrante;
            string descp_articulo = "";
            int cantidad_nota = 0;
            int cont = 0;
            bool B_EliminarRegistro = false;

            //Buscamos la descripción  del artículo de acuerdo a al orden de compra
            descp_articulo = (string)busca_valor_dt(this.dtDetalle, "D_Articulo", "SKU = " + "'" + sku + "'");

            if (descp_articulo.Length > 0)
            {
                cantidad_nota = (int)busca_valor_dt(this.dtDetalle, "Cantidad_Nota", "SKU = " + "'" + sku + "'");

                dgvEscaneoArticulos.Rows.RemoveAt(dgvEscaneoArticulos.CurrentRow.Index);
            }

            else
            {
                MessageBox.Show("El artículo seleccionado no se encuentra en la orden de compra");
                return false;
            }

            if (dgv_Escaneo_Contador.RowCount == 0)
            {
                return false;
                //dgv_Escaneo_Contador.Rows.Insert(0, al_contador_articulo.Count, descp_articulo, cantidad_nota, 1, sku, "NO", "Ingresar lote");
                //dgv_Escaneo_Contador.Sort(this.dgv_Escaneo_Contador.Columns["id"], ListSortDirection.Ascending);

                //al_contador_articulo.Add(sku);
                //al_tablas_lotes.Add(new DataTable());

                //index = al_contador_articulo.IndexOf(sku);
                //cont = (int)dgv_Escaneo_Contador.Rows[index].Cells["cant_escaneada"].Value;

                //if (cont > cantidad_nota)
                //{
                //    dgv_Escaneo_Contador.Rows[index].Cells["es_sobrante"].Value = "SI";
                //}

            }
            else
            {
                index = -1;
                index_sobrante = -1;
                int index_x = 0;
                if (valida_hay_sobrante(sku))
                {
                              
                    foreach (DataGridViewRow row in dgv_Escaneo_Contador.Rows)
                    {
                        cont = (int)row.Cells["cant_escaneada"].Value;
                        if (((string)row.Cells["sku"].Value == sku) && ((string)row.Cells["es_sobrante"].Value == "SI"))
                        {
                            row.Cells["cant_escaneada"].Value = cont - 1;
                            if((int)row.Cells["cant_escaneada"].Value ==0)
                            {
                                index_x = row.Index;
                                B_EliminarRegistro = true;
                        
                            }
                            index_sobrante = al_contador_articulo.LastIndexOf(sku);

                            break;
                        }
                    }

                }
                else
                {
                    foreach (DataGridViewRow row in dgv_Escaneo_Contador.Rows)
                    {
                        cont = (int)row.Cells["cant_escaneada"].Value;
                        if (((string)row.Cells["sku"].Value == sku) && ((string)row.Cells["es_sobrante"].Value == "NO"))
                        {
                            row.Cells["cant_escaneada"].Value = cont - 1;
                            if ((int)row.Cells["cant_escaneada"].Value == 0)
                            {
                                index_x = row.Index;
                                B_EliminarRegistro = true;
      
                            }
                            index= al_contador_articulo.LastIndexOf(sku);
                        }
                    }
                }
                if (B_EliminarRegistro)
                {
                    dgv_Escaneo_Contador.Rows.RemoveAt(index_x);
                }
                if (index > -1)
                    al_contador_articulo.RemoveAt(index);
                else if(index_sobrante>-1)
                    al_contador_articulo.RemoveAt(index_sobrante);



            }

            return true;
        }
    }
}
