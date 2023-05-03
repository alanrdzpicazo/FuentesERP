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
using ProbeMedic.CATALOGOS;
using ProbeMedic.PEDIDOS;


namespace ProbeMedic.CATALOGOS.PACIENTES
{
    public partial class FRM_PACIENTES_DIRECCIONES : FormaBase
    {
        public int PropiedadK_Paciente { get; set; }
        public string PropiedadD_Paciente { get; set; }
        public string Calle_Pasa { get; set; }
        public string Tipo_Direccion_Pasa { get; set; }
        public string EntreCalles_Pasa { get; set; }
        public string Edificio_Pasa { get; set; }
        public string Colonia_Pasa { get; set; }
        public string Estado_Pasa { get; set; }
        public string Pais_Pasa { get; set; }
        public string Localidad_Pasa { get; set; }
        public string CP_Pasa { get; set; }
        public string Municipio_Pasa { get; set; }
        public int K_Paciente_Dierccion { get; set; }
        public int Numero_Ext { get; set; }
        public string Numero_Int { get; set; }
        public string Piso_Pasa { get; set; }

        public FRM_PACIENTES_DIRECCIONES()
        {
            InitializeComponent();
            grDatos.AutoGenerateColumns = false;
        }
        SQLCatalogos sql_Catalogos = new SQLCatalogos();

        DataTable Direcciones = new DataTable();
        DataTable _Direcciones = new DataTable();

        Int32 _K_Tipo_Direccion = 0;

        int res = 0;
        string msg = string.Empty;

        private void FRM_PACIENTES_DIRECCIONES_Load(object sender, EventArgs e)
        {
            Direcciones.Columns.Add("K_Paciente_Direccion", typeof(Int32));
            Direcciones.Columns.Add("K_Tipo_Direccion", typeof(Int32));
            Direcciones.Columns.Add("D_Tipo_Direccion", typeof(string));
            Direcciones.Columns.Add("D_Pais", typeof(string));
            Direcciones.Columns.Add("D_Estado", typeof(string));
            Direcciones.Columns.Add("D_Ciudad", typeof(string));
            Direcciones.Columns.Add("D_Municipio", typeof(string));
            Direcciones.Columns.Add("D_Colonia", typeof(string));
            Direcciones.Columns.Add("Codigo_Postal", typeof(string));
            Direcciones.Columns.Add("Calle", typeof(string));
            Direcciones.Columns.Add("Numero_Exterior", typeof(string));
            Direcciones.Columns.Add("Numero_Interior", typeof(string));
            Direcciones.Columns.Add("Entre_Calles", typeof(string));
            Direcciones.Columns.Add("Edificio", typeof(string));
            Direcciones.Columns.Add("Piso", typeof(Int32));
            Direcciones.Columns.Add("B_Activo", typeof(Boolean));
            LlenaGrid(PropiedadK_Paciente);
        }
        public override void BaseMetodoInicio()
        {
            BaseBotonGuardar.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonModificar.Visible = false;
            BaseBotonExcel.Visible = false;
            BaseBotonReporte.Visible = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonBuscar.Visible = false;
            limpia();
            btnBuscarTipoDireccion.Focus();//Asignar el textbox que inicia el focus

            lblPac.Text = PropiedadD_Paciente;

        }

        private void LlenaGrid(Int32 PropiedadK_Paciente)
        {
            try
            {
                _Direcciones = sql_Catalogos.Sk_Pacientes_Direcciones(PropiedadK_Paciente);

                if (_Direcciones != null)
                {
                    if(_Direcciones.Rows.Count>0)
                    {
                        foreach (DataRow irow in _Direcciones.Rows)
                        {
                            DataRow dtdRow = Direcciones.NewRow();
                            dtdRow["K_Paciente_Direccion"] = Convert.ToInt32(irow["K_Paciente_Direccion"].ToString());
                            dtdRow["K_Tipo_Direccion"] = Convert.ToInt32(irow["K_Tipo_Direccion"].ToString());
                            dtdRow["D_Tipo_Direccion"] = irow["D_Tipo_Direccion"].ToString();
                            dtdRow["D_Pais"] = irow["D_Pais"].ToString();
                            dtdRow["D_Estado"] = irow["D_Estado"].ToString();
                            dtdRow["D_Ciudad"] = irow["D_Ciudad"].ToString();
                            dtdRow["D_Municipio"] = irow["D_Municipio"].ToString();
                            dtdRow["D_Colonia"] = irow["D_Colonia"].ToString();
                            dtdRow["Codigo_Postal"] = irow["Codigo_Postal"].ToString();
                            dtdRow["Calle"] = irow["Calle"].ToString();
                            dtdRow["Numero_Exterior"] = irow["Numero_Exterior"].ToString();
                            dtdRow["Numero_Interior"] = irow["Numero_Interior"].ToString();
                            dtdRow["Entre_Calles"] = irow["Entre_Calles"].ToString();
                            dtdRow["Edificio"] = irow["Edificio"].ToString();
                            dtdRow["Piso"] = Convert.ToInt32(irow["Piso"].ToString());
                            dtdRow["B_Activo"] = Convert.ToBoolean(irow["B_Activo"].ToString());
                            Direcciones.Rows.Add(dtdRow);

                        }

                        grDatos.DataSource = Direcciones;
                    }
             

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void limpia()
        {

            if (grDatos.RowCount > 0)
            {
                DataTable dt2 = (DataTable)grDatos.DataSource;
                dt2.Clear();
            }
        }

        private void BtnAgergar_Click(object sender, EventArgs e)
        {
            CATALOGOS.PACIENTES.FRM_AGREGA_DIRECCION frm = new CATALOGOS.PACIENTES.FRM_AGREGA_DIRECCION();
            frm.PropiedadK_Paciente = Convert.ToInt32(PropiedadK_Paciente);
            frm.PropiedadD_Paciente = PropiedadD_Paciente;
            limpia();
            frm.ShowDialog();
            
            LlenaGrid(PropiedadK_Paciente);

            if(grDatos.Rows.Count>0)
            {
                int indiceUltimaFila = grDatos.Rows.Count - 1;
                //  grDatos.Rows[indiceUltimaFila].Selected = true;
                DataGridViewSelectedRowCollection filasSeleccionadas = grDatos.SelectedRows;
                grDatos.FirstDisplayedScrollingRowIndex = indiceUltimaFila;
                FRM_INGRESA_PEDIDOS frm2 = new FRM_INGRESA_PEDIDOS();
                FRM_MODIFICA_PEDIDO frmMod2 = new FRM_MODIFICA_PEDIDO();
                Calle_Pasa = grDatos.Rows[indiceUltimaFila].Cells["Calle"].Value.ToString();
                Numero_Int = grDatos.Rows[indiceUltimaFila].Cells["Numero_Interior"].Value.ToString();
                Numero_Ext = Convert.ToInt32(grDatos.Rows[indiceUltimaFila].Cells["Numero_Exterior"].Value.ToString());
                Tipo_Direccion_Pasa = grDatos.Rows[indiceUltimaFila].Cells["D_Tipo_Direccion"].Value.ToString();
                EntreCalles_Pasa = grDatos.Rows[indiceUltimaFila].Cells["Entre_Calles"].Value.ToString();
                Edificio_Pasa = grDatos.Rows[indiceUltimaFila].Cells["Edificio"].Value.ToString();
                Piso_Pasa = grDatos.Rows[indiceUltimaFila].Cells["Piso"].Value.ToString();
                Colonia_Pasa = grDatos.Rows[indiceUltimaFila].Cells["D_Colonia"].Value.ToString();
                Estado_Pasa = grDatos.Rows[indiceUltimaFila].Cells["D_Estado"].Value.ToString();
                Pais_Pasa = grDatos.Rows[indiceUltimaFila].Cells["D_Pais"].Value.ToString();
                Localidad_Pasa = grDatos.Rows[indiceUltimaFila].Cells["D_Ciudad"].Value.ToString();
                CP_Pasa = grDatos.Rows[indiceUltimaFila].Cells["Codigo_Postal"].Value.ToString();
                Municipio_Pasa = grDatos.Rows[indiceUltimaFila].Cells["D_Municipio"].Value.ToString();
                K_Paciente_Dierccion = Convert.ToInt32(grDatos.Rows[indiceUltimaFila].Cells["K_Paciente_Direccion"].Value.ToString());
                this.Close();
            }               
        }

        private void btnBuscarTipoDireccion_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_TipoDireccion frm = new Busquedas.Frm_Busca_TipoDireccion();
            frm.ShowDialog();

            if (_K_Tipo_Direccion != frm.LLave_Seleccionado)
            {
                _K_Tipo_Direccion = frm.LLave_Seleccionado;
                txtTipoDireccion.Text = frm.Descripcion_Seleccionado;
            }

        }

        public override void BaseBotonBorrarClick()
        {
            if (Convert.ToInt32(grDatos.CurrentRow.Cells[0].Value.ToString()) == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN TELEFONO..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dlg = MessageBox.Show("SERA ELIMINADO EL REGISTRO CON VALOR:\n" + Convert.ToString(grDatos.CurrentRow.Cells[1].Value.ToString()) + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                res = sql_Catalogos.Dl_Pacientes_Direcciones(Convert.ToInt32(grDatos.CurrentRow.Cells[0].Value.ToString()), ref msg);
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


                    limpia();

                    LlenaGrid(PropiedadK_Paciente);

                }

            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            BaseBotonBorrarClick();
            LlenaGrid(PropiedadK_Paciente);
        }

        private void txtTipoDireccion_TextChanged(object sender, EventArgs e)
        {
            limpia();
            if (_K_Tipo_Direccion != 0)
            {
                try
                {
                    _Direcciones = sql_Catalogos.Sk_Pacientes_Direcciones(PropiedadK_Paciente, _K_Tipo_Direccion);

                    if (_Direcciones != null)
                    {
                        foreach (DataRow irow in _Direcciones.Rows)
                        {
                            DataRow dtdRow = Direcciones.NewRow();
                            dtdRow["K_Paciente_Direccion"] = Convert.ToInt32(irow["K_Paciente_Direccion"].ToString());
                            dtdRow["K_Tipo_Direccion"] = Convert.ToInt32(irow["K_Tipo_Direccion"].ToString());
                            dtdRow["D_Tipo_Direccion"] = irow["D_Tipo_Direccion"].ToString();
                            dtdRow["D_Pais"] = irow["D_Pais"].ToString();
                            dtdRow["D_Estado"] = irow["D_Estado"].ToString();
                            dtdRow["D_Ciudad"] = irow["D_Ciudad"].ToString();
                            dtdRow["D_Municipio"] = irow["D_Municipio"].ToString();
                            dtdRow["D_Colonia"] = irow["D_Colonia"].ToString();
                            dtdRow["Codigo_Postal"] = irow["Codigo_Postal"].ToString();
                            dtdRow["Calle"] = irow["Calle"].ToString();
                            dtdRow["Numero_Exterior"] = irow["Numero_Exterior"].ToString();
                            dtdRow["Numero_Interior"] = irow["Numero_Interior"].ToString();
                            dtdRow["Entre_Calles"] = irow["Entre_Calles"].ToString();
                            dtdRow["Edificio"] = irow["Edificio"].ToString();
                            dtdRow["Piso"] = Convert.ToInt32(irow["Piso"].ToString());
                            dtdRow["B_Activo"] = Convert.ToBoolean(irow["B_Activo"].ToString());
                            Direcciones.Rows.Add(dtdRow);

                        }
                        grDatos.DataSource = Direcciones;

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void grDatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(grDatos.CurrentRow!=null)
            {
                if(grDatos.CurrentRow.Index>-1)
                {
                    Calle_Pasa = grDatos.CurrentRow.Cells["Calle"].Value.ToString();
                    Numero_Int = grDatos.CurrentRow.Cells["Numero_Interior"].Value.ToString();
                    Numero_Ext = Convert.ToInt32(grDatos.CurrentRow.Cells["Numero_Exterior"].Value.ToString());
                    Tipo_Direccion_Pasa = grDatos.CurrentRow.Cells["D_Tipo_Direccion"].Value.ToString();
                    EntreCalles_Pasa = grDatos.CurrentRow.Cells["Entre_Calles"].Value.ToString();
                    Edificio_Pasa = grDatos.CurrentRow.Cells["Edificio"].Value.ToString();
                    Piso_Pasa = grDatos.CurrentRow.Cells["Piso"].Value.ToString();
                    Colonia_Pasa = grDatos.CurrentRow.Cells["D_Colonia"].Value.ToString();
                    Estado_Pasa = grDatos.CurrentRow.Cells["D_Estado"].Value.ToString();
                    Pais_Pasa = grDatos.CurrentRow.Cells["D_Pais"].Value.ToString();
                    Localidad_Pasa = grDatos.CurrentRow.Cells["D_Ciudad"].Value.ToString();
                    CP_Pasa = grDatos.CurrentRow.Cells["Codigo_Postal"].Value.ToString();
                    Municipio_Pasa = grDatos.CurrentRow.Cells["D_Municipio"].Value.ToString();
                    K_Paciente_Dierccion = Convert.ToInt32(grDatos.CurrentRow.Cells["K_Paciente_Direccion"].Value.ToString());
                    this.Close();
                }
            }

        }
    }
}
