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

namespace ProbeMedic.INVENTARIOS
{
    public partial class Frm_ActualizaEstatusDevolucion : FormaBase
    {
        public Int32 pK_Devolucion{get;set;}
        int K_Estatus_Devolucion = 0;
        public DataTable dtEstatus = new DataTable();
        SQLCatalogos sql_cat = new SQLCatalogos();
        SQLAlmacen sql_alm = new SQLAlmacen();
        public Frm_ActualizaEstatusDevolucion()
        {
            InitializeComponent();
        }
        public override void BaseMetodoInicio()
        {
            BaseBotonProceso2.Visible = false;
            BaseBotonProceso3.Visible = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBorrar.Enabled = false;
            BaseBotonAfectar.Visible = false;
            BaseBotonAfectar.Enabled = false;
            BaseBotonCorreo.Visible = false;
            BaseBotonCorreo.Enabled = false;
            BaseBotonModificar.Visible = false;
            BaseBotonModificar.Enabled = false;
            BaseBotonNuevo.Visible = false;
            BaseBotonNuevo.Enabled = false;
            BaseBotonCancelar.Visible = false;
            BaseBotonCancelar.Enabled = false;
            BaseBotonGuardar.Visible = true;
            BaseBotonGuardar.Enabled = true;
            BaseBotonReporte.Visible = false;
            BaseBotonReporte.Enabled = false;
            BaseBotonProceso1.Visible = false;
            BaseBotonProceso2.Visible = false;
            BaseBotonProceso3.Visible = false;
            BaseBotonBuscar.Visible = false;
            BaseBotonExcel.Visible = false;
            txtDevolucion.Text = pK_Devolucion.ToString();
            MtdCargaEstatus();
        }
        public override void BaseBotonGuardarClick()
        {
            BaseBotonGuardar.Enabled = true;
            if (cmbEstatus.SelectedValue != null)
            {
                if (cmbEstatus.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    K_Estatus_Devolucion = Convert.ToInt32(cmbEstatus.SelectedValue);
                }
            }
            if (K_Estatus_Devolucion <= 0)
            {
                MessageBox.Show("SELECCIONE UN ESTATUS VALIDO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbEstatus.Focus();
                BaseBotonGuardar.Enabled = true;
                return;
            }
            MtdActualizaSeguimiento(pK_Devolucion, K_Estatus_Devolucion, txtObservaciones.Text, GlobalVar.K_Usuario, GlobalVar.PC_Name);
        }

        //Función que actualizara el seguimiento de la devolución una vez que se suban los archvos XML y PDF
        void MtdActualizaSeguimiento(Int32 K_Devolucion, Int32 K_Estatus_Devolucion, string Observaciones, Int32 K_Usuario, string PC_Name)
        {
   

            string msg = string.Empty;
            Int32 CampoIdentity = 0;
            int res = 0;

            res = sql_alm.In_Seguimiento_Devolucion(ref CampoIdentity, K_Devolucion, K_Estatus_Devolucion, txtObservaciones.Text, GlobalVar.K_Usuario, PC_Name, ref msg);
            if (res == -1)
            {
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MessageBox.Show("INFORMACION ACTUALIZADA CORRECTAMENTE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
        
            }
        }

        void MtdCargaEstatus()
        {    
            dtEstatus= sql_cat.Sk_Estatus_Devolucion();
           
            if (dtEstatus != null)
            {
                DataRow dr = dtEstatus.NewRow();

                dr["K_Estatus_Devolucion"] = 0;
                dr["D_Estatus_Devolucion"] = "SELECCIONAR";

                dtEstatus.Rows.InsertAt(dr, 0);
                dtEstatus.AcceptChanges();

                int indice = -1;
                indice = 0;
                LlenaCombo(dtEstatus, ref cmbEstatus, "K_Estatus_Devolucion", "D_Estatus_Devolucion", indice);
            }
        }


    }
}
