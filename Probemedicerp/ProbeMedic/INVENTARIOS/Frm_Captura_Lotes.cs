﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbeMedic.INVENTARIOS
{
    public partial class Frm_Captura_Lotes : Form
    {

        private DataTable dt_datos_lote;
        private int cantidad_escaneada;

        public Frm_Captura_Lotes()
        {
            InitializeComponent();
            dt_datos_lote = new DataTable();
            



        }
        public Frm_Captura_Lotes(DataTable dt)
        {
            InitializeComponent();
            dt_datos_lote = dt;
            int index = 0;

            if (dt_datos_lote.Rows.Count > 0)
            {
                agrega_columnas_iniciales();
                foreach(DataRow dr in dt_datos_lote.Rows)
                {
                    dgvIngresaLote.Rows.Insert(index,dr["lote"].ToString(), dr["cantidad"].ToString(), dr["fecha_caducidad"].ToString());
                    index++;
                }
                
            }
        }

        public int Cantidad_Escaneada
        {
            get
            {
                return this.cantidad_escaneada;
            }
            set
            {
                this.cantidad_escaneada = value;
            }
        }

        public DataTable Datos_Tabla {
            get
            {
                return this.dt_datos_lote;
            }
            set
            {
                this.dt_datos_lote = value;
            }
        }
        private void txt_no_lotes_KeyPress(object sender, KeyPressEventArgs e)
        {

          

            e.Handled = !(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)13) == true ? true:false;

            if (e.KeyChar == (char)13 || e.KeyChar == (char)Keys.Tab)
            {
                agrega_registros_dgv(Convert.ToInt32(txt_no_lotes.Text));
                this.GetNextControl(ActiveControl, true).Focus();
            }

        }
        private bool  agrega_registros_dgv(int num_registros)
        {
            bool res = true;

            if (num_registros > this.cantidad_escaneada )
            {
                MessageBox.Show("No puede haber un número mayor de lotes que la cantidad escaneada");
                return false;
            }

            //borramos registros del dgv si tiene
            if (this.dgvIngresaLote.Rows.Count > 0)
            {
                if (dt_datos_lote.Rows.Count > 0)
                {
                    dgvIngresaLote.DataSource = null;
                    agrega_columnas_iniciales();
                    dt_datos_lote.Clear();
                   
                }
                dgvIngresaLote.Rows.Clear();
                dgvIngresaLote.Columns.Clear();
                agrega_columnas_iniciales();
            }
                
            //if (this.dgvIngresaLote.DataSource == null && this.Datos_Tabla.Rows.Count == 0)
            //    agrega_columnas_iniciales();

            for (int i = 0;i<num_registros;i++)
                {
                    dgvIngresaLote.Rows.Insert(i, "", "", "01/01/1970");
                   
                }

            return res; 
            
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
           if(valida_campos())
            {
                guarda_dgv_a_data_table();
                this.Close();
            }
       
        }

        private bool guarda_dgv_a_data_table()
        {
            dt_datos_lote = new DataTable();

            this.dt_datos_lote = Dgv_to_datatable(this.dgvIngresaLote);



            return true;
        }

        public DataTable Dgv_to_datatable(DataGridView dgv,bool IgnoreHideColumns = false)
        {
            try
            {
                if (dgv.ColumnCount == 0) return null;
                DataTable dtSource = new DataTable();
                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    if (IgnoreHideColumns & !col.Visible) continue;
                    if (col.Name == string.Empty) continue;
                    dtSource.Columns.Add(col.Name);
                    dtSource.Columns[col.Name].Caption = col.HeaderText;
                }
                if (dtSource.Columns.Count == 0) return null;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    DataRow drNewRow = dtSource.NewRow();
                    foreach (DataColumn col in dtSource.Columns)
                    {
                        drNewRow[col.ColumnName] = row.Cells[col.ColumnName].Value;
                    }
                    dtSource.Rows.Add(drNewRow);
                }
                return dtSource;
            }
            catch { return null; }
        }

        private void Frm_Captura_Lotes_Load(object sender, EventArgs e)
        {
            if (this.dt_datos_lote.Rows.Count == 0)
                agrega_columnas_iniciales();


        }

        private void Frm_Captura_Lotes_Shown(object sender, EventArgs e)
        {
            
        }

        private void agrega_columnas_iniciales()
        {
            dgvIngresaLote.Columns.Add("lote", "Lote");
            dgvIngresaLote.Columns.Add("cantidad", "Cantidad");
            dgvIngresaLote.Columns.Add(new DataGridViewButtonColumn());
            dgvIngresaLote.Columns[2].Name = "fecha_caducidad";
            dgvIngresaLote.Columns[2].HeaderText = "Fecha Caducidad";

            //dgvIngresaLote.Columns.Add("fecha_caducidad", "FECHA CADUCIDAD");
            dgvIngresaLote.Columns["fecha_caducidad"].DefaultCellStyle.Format = "dd/MM/yyyy";
           

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool valida_campos()
        {
            bool validado = true;
            DateTime fecha;
            string aux;
            int suma = 0;

            foreach(DataGridViewRow row in this.dgvIngresaLote.Rows)
            {
                //validamos fecha
                try
                {
                    fecha = DateTime.ParseExact(row.Cells["fecha_caducidad"].Value.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                }
                catch (Exception)
                {
                    MessageBox.Show("El formato de fecha no corresponde con la forma 'dd/MM/yyyy' favor de ingresar el formato correcto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validado = false;
                    continue;
                }

                // No menor a la actual

                if (fecha < System.DateTime.Now)
                {
                    MessageBox.Show("LA FECHA NO PUEDE SER MENOR A LA ACTUAL", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }


                //validamos campos vacíos

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value.ToString().Trim() == "")
                    {
                        MessageBox.Show("Existen campos vacíos");
                        validado = false;
                        break; 
                    }

                   

                }

                //validamos que la cantidad sea un campo numérico

                aux = row.Cells["cantidad"].Value.ToString();

                try
                {
                    suma += Convert.ToInt32(aux);
                }
                catch (Exception)
                {
                  
                    MessageBox.Show("El campo 'cantidad' no es numérico", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validado = false;
                    break;
                }
                
            }

            if (suma > this.cantidad_escaneada)
            {
              
                MessageBox.Show("La cantidad total de los lotes es MAYOR a la escaneada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if(suma < this.cantidad_escaneada )
                {
                    MessageBox.Show("La cantidad total de los lotes es MENOR a la escaneada, favor de capturar todos los lotes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                  
            }
               

            return validado;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvIngresaLote_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvIngresaLote.Columns[e.ColumnIndex].Name == "fecha_caducidad")
            {
                string fecha = Prompt_Fecha("Ingresar fecha", "Fecha de caducidad");

                dgvIngresaLote.Rows[e.RowIndex].Cells["fecha_caducidad"].Value  = fecha;
            }
        }

        private string Ingresa_fecha_caducidad(int row_index)
        {
            string str_fecha = "";

            return str_fecha;
        }
        public static string Prompt_Fecha(string text, string caption)
        {
            Form prompt = new Form();
            prompt.Width = 300;
            prompt.Height = 135;
            prompt.Text = caption;
            prompt.StartPosition = FormStartPosition.CenterScreen;
            prompt.FormBorderStyle = FormBorderStyle.FixedSingle;
            prompt.MaximizeBox = false;
            Label textLabel = new Label() { Left = 90, Top = 5, Text = text };
            MaskedTextBox inputBox = new MaskedTextBox() { Left = 90, Top = 30, Width = 100 };
            inputBox.TextAlign = HorizontalAlignment.Center;
            inputBox.Focus();
            inputBox.Select();
            inputBox.Mask = "00/00/0000";
            inputBox.ValidatingType = typeof(System.DateTime);
            DateTime fecha = new DateTime();
            bool validado = true;
            Button confirmation = new Button() { Text = "Aceptar", Left = 90, Width = 100, Top = 60 };
            confirmation.Click += (sender, e) => {
                //validamos fecha
                try
                {
                    fecha = DateTime.ParseExact(inputBox.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                    validado = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("El formato de fecha no corresponde con la forma 'dd/MM/yyyy' favor de ingresar el formato correcto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validado = false;
                    
                }

                if (fecha < System.DateTime.Now)
                {
                    MessageBox.Show("LA FECHA NO PUEDE SER MENOR A LA ACTUAL", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validado = false; 
                }


                if (validado)
                 prompt.Close();
            };
           
            
            inputBox.KeyPress += (sender, e) => {
                if (e.KeyChar == (char)13)
                {
                    try
                    {
                        fecha = DateTime.ParseExact(inputBox.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                        validado = true;
                    }
                    catch (Exception)
                    {
                     
                        MessageBox.Show("El formato de fecha no corresponde con la forma 'dd/MM/yyyy' favor de ingresar el formato correcto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        validado = false;

                    }

                    if (fecha < System.DateTime.Now)
                    {
                        MessageBox.Show("LA FECHA NO PUEDE SER MENOR A LA ACTUAL", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        validado = false;
                    }
                    if (validado)
                        prompt.Close();
                }
               
            };
            inputBox.TabIndex = 0;
            inputBox.TabStop = true;
            confirmation.TabIndex = 1;
            confirmation.TabStop = true;
            textLabel.TabIndex = 100;

            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBox);
            prompt.ShowDialog();
            return inputBox.Text ;
        }

        private void dgvIngresaLote_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check the value of the e.ColumnIndex property if you want to apply this formatting only so some rcolumns.
            if (e.Value != null)
            {
                e.Value = e.Value.ToString().ToUpper();
                e.FormattingApplied = true;
            }

        }

        private void dgvIngresaLote_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvIngresaLote_CellContentClick(sender, e);
        }

        private void Frm_Captura_Lotes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            {
                if (valida_campos())
                {
                    guarda_dgv_a_data_table();
                    this.Close();
                }
            }
        }
    }
}