using ProbeMedic.AppCode.BLL;
using ProbeMedic.AppCode.DCC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbeMedic.CATALOGOS
{
    public partial class FRM_OFICINAS : FormaCatalogo
    {
        public FRM_OFICINAS()
        {
            InitializeComponent();
            btnGoogle.Enabled = true;
        }

        int res = 0;
        string msg = string.Empty;
        int K_JefeOficina = 0;
        Funciones fx = new Funciones();

        public override void BaseMetodoInicio()
        {
          
            txtFocus = txtDescripcion; //Asignar el textbox que inicia el focus
            //pnlControles.Enabled = false; //NO Borrar
            DeshabilitaPages(ref tcControles, false);
            //cbxActiva.Enabled = false;
            BaseBotonBorrar.Visible = false;
            BaseBotonBorrar.Enabled = false;

            BaseDtDatos = sqlCatalogos.Sk_Oficina();
            CatalogoPropiedadCampoClave = "K_Oficina";
            CatalogoPropiedadCampoDescripcion = "D_Oficina";


            base.BaseMetodoInicio();
        }

        public override void CatalogoHabilitaPanelControles(bool B_Habilita)
        {
            //pnlControles.Enabled = B_Habilita;
            DeshabilitaPages(ref tcControles, B_Habilita);
            //cbxActiva.Enabled = B_Habilita;
        }

        public override void BaseMetodoLimpiaControles()
        {
            K_JefeOficina = 0;
            txtClave.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtCorto.Text = string.Empty;
            txtCentroCosto.Text = string.Empty;
            txtJefeOficina.Text = string.Empty;
            cbxFrontera.Checked = false;
           // cbxActiva.Checked = true;
            geo_Colonia1.K_Pais = 0;
            geo_Colonia1.txt_G_Pais.Text = string.Empty;
            geo_Colonia1.K_Estado = 0;
            geo_Colonia1.txt_G_Estado.Text = string.Empty;
            geo_Colonia1.K_Ciudad = 0;
            geo_Colonia1.txt_G_Ciudad.Text = string.Empty;
            geo_Colonia1.K_Colonia = 0;
            geo_Colonia1.txt_G_Colonia.Text = string.Empty;

            txtCalle.Text = string.Empty;
            txtNumInt.Text = "";
            TxtNumExt.Text = "";
            txtLongitud.Text = string.Empty;
            txtCP.Text = string.Empty;
            txtLatitud.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtTelefono2.Text = string.Empty;
            txtFax.Text = string.Empty;
            tcControles.SelectTab(tpGenerales);
            ucEmpresas1.K_Empresa = 0;
            ucEmpresas1.txt_G_Empresa.Text = string.Empty;
            txt_HF.Value = DateTime.Now;
            txt_HI.Value = DateTime.Now;
            CbxServicioSOS.Checked = false;
            cbxSucursal.Checked = false;
            DeshabilitaPages(ref tcControles, false);
            //cbxActiva.Enabled = false;
            ///pnlControles.Enabled = false; //NO Borrar        
        }

        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();
            txtClave.Text = ren["K_Oficina"].ToString();
            txtDescripcion.Text = ren["D_Oficina"].ToString();
            if (ren["K_Jefe_Oficina"].ToString().Trim().Length > 0)
                K_JefeOficina = Convert.ToInt32(ren["K_Jefe_Oficina"]);


            txtCorto.Text = ren["C_Oficina"].ToString();
            txtCentroCosto.Text = ren["Centro_Costos"].ToString();
            txtJefeOficina.Text = ren["D_Jefe_Oicina"].ToString();

           
            cbxFrontera.Checked = Convert.ToBoolean(ren["B_Frontera"]);
            //cbxActiva.Checked = Convert.ToBoolean(ren["B_Activa"]);

            geo_Colonia1.K_Pais = Convert.ToInt32(ren["K_Pais"]);
            geo_Colonia1.K_Estado = Convert.ToInt32(ren["K_Estado"]);
            geo_Colonia1.K_Ciudad = Convert.ToInt32(ren["K_Ciudad"]);
            geo_Colonia1.K_Colonia = Convert.ToInt32(ren["K_Colonia"]);

            geo_Colonia1.txt_G_Pais.Text = ren["D_Pais"].ToString();
            geo_Colonia1.txt_G_Estado.Text = ren["D_Estado"].ToString();
            geo_Colonia1.txt_G_Ciudad.Text = ren["D_Ciudad"].ToString();
            geo_Colonia1.txt_G_Colonia.Text = ren["D_Colonia"].ToString();

            txtCalle.Text = ren["Calle"].ToString();
            TxtNumExt.Text = ren["NumExterior"].ToString();
            txtNumInt.Text = ren["NumInterior"].ToString();
            txtCP.Text = ren["Codigo_Postal"].ToString();
            txtLatitud.Text = ren["Latitud"].ToString();
            txtLongitud.Text = ren["Longitud"].ToString();
            txtTelefono.Text = ren["Telefono"].ToString();
            txtTelefono2.Text = ren["Telefono2"].ToString();
            txtFax.Text = ren["Fax"].ToString();
            cbxSucursal.Checked = Convert.ToBoolean(ren["B_Sucursal"]);
            CbxServicioSOS.Checked = Convert.ToBoolean(ren["B_Servicio_SOS"]);
            txt_HI.Value = Convert.ToDateTime( ren["Horario_Inicial"].ToString());
            txt_HF.Value = Convert.ToDateTime(ren["Horario_Final"].ToString());
            ucEmpresas1.K_Empresa = Convert.ToInt32(ren["K_Empresa"]);
            ucEmpresas1.txt_G_Empresa.Text = ren["D_Empresa"].ToString();
        }

        public override void BaseBotonBorrarClick()
        {
            if (txtClave.Text.Trim().Length == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN REGISTRO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dlg = MessageBox.Show("SERA ELIMINADO EL REGISTRO CON VALOR:\n" + txtDescripcion.Text.Trim() + " \n¿DESEA CONTINUAR?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                res = sqlCatalogos.Dl_Oficina(Convert.ToInt32(CatalogoPropiedadId_Identity), ref msg);

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
            int CampoIdentity = 0;
            int CP = 0;

            string[] cadena = dtt_Fecha.Value.ToString().Split(' ');

            DateTime fi = txt_HI.Value;
            DateTime ff = txt_HF.Value;
            if ((txt_HI.Text.Substring(txt_HI.Text.Length - 5, 5) == "a. m.") || (txt_HI.Text.Substring(txt_HI.Text.Length - 5, 5) == "p. m."))
            {
                fi = Convert.ToDateTime(cadena[0] + " " + txt_HI.Text.Substring(0, 7));
                ff = Convert.ToDateTime(cadena[0] + " " + txt_HF.Text.Substring(0, 7));
            }
            else
            {

                fi = Convert.ToDateTime(cadena[0] + " " + txt_HI.Text.Substring(0, 5));
                ff = Convert.ToDateTime(cadena[0] + " " + txt_HF.Text.Substring(0, 5));
            }


            if (txtCP.Text.Trim().Length > 0)
                CP = Convert.ToInt32(txtCP.Text);

            if (CatalogoPropiedadEsRegistroNuevo) // Nuevo
            {
                res = sqlCatalogos.In_oficina(ref CampoIdentity, txtDescripcion.Text, txtCorto.Text, Convert.ToInt16(geo_Colonia1.K_Pais), Convert.ToInt32(geo_Colonia1.K_Estado), Convert.ToInt32(geo_Colonia1.K_Ciudad), Convert.ToInt32(geo_Colonia1.K_Colonia), txtCalle.Text, TxtNumExt.Text, txtNumInt.Text, Convert.ToInt32(txtCP.Text), txtTelefono.Text, txtTelefono2.Text, txtFax.Text, K_JefeOficina, txtCentroCosto.Text,cbxFrontera.Checked,
                                   cbxSucursal.Checked, CbxServicioSOS.Checked, fi, ff, Convert.ToInt32(ucEmpresas1.K_Empresa), txtLatitud.Text, txtLongitud.Text, ref msg);
            }
            else //Existe. Update
            {
                CampoIdentity = Convert.ToInt16(CatalogoPropiedadId_Identity);
                res = sqlCatalogos.Up_Oficina(CampoIdentity, txtDescripcion.Text, txtCorto.Text, Convert.ToInt16(geo_Colonia1.K_Pais), Convert.ToInt32(geo_Colonia1.K_Estado), Convert.ToInt32(geo_Colonia1.K_Ciudad), Convert.ToInt32(geo_Colonia1.K_Colonia), txtCalle.Text, TxtNumExt.Text, txtNumInt.Text, Convert.ToInt32(txtCP.Text), txtTelefono.Text, txtTelefono2.Text, txtFax.Text, K_JefeOficina, txtCentroCosto.Text, cbxFrontera.Checked,
                                    cbxSucursal.Checked, CbxServicioSOS.Checked, fi, ff, Convert.ToInt32(ucEmpresas1.K_Empresa), txtLatitud.Text, txtLongitud.Text,ref msg);
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
                CargaTablasParciales(4);
            }

        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (txtDescripcion.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR DESCRIPCION...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                return false;
            }
            if (txtCorto.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR DESCRIPCION CORTA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorto.Focus();
                return false;
            }
            if (geo_Colonia1.K_Pais == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN PAIS...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tcControles.SelectTab(tpDomicilio);
                geo_Colonia1.txt_G_Ciudad.Focus();
                return false;
            }
            if (geo_Colonia1.K_Estado == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN ESTADO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tcControles.SelectTab(tpDomicilio);
                geo_Colonia1.txt_G_Estado.Focus();
                return false;
            }
            if (geo_Colonia1.K_Colonia== 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA COLONIA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tcControles.SelectTab(tpDomicilio);
                geo_Colonia1.txt_G_Ciudad.Focus();
                return false;
            }

            if (txtCalle.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR CALLE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tcControles.SelectTab(tpDomicilio);
                txtCalle.Focus();
                return false;
            }
            //TODO: Habilitar cuando ya sea obligatorio el campo en la tabla
            //if (K_JefeOficina == 0)
            //{
            //    MessageBox.Show("DEBE SELECCIONAR UN JEFE DE OFICINA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtJefeOficina.Focus();
            //    return false;
            //}
            if (txtCentroCosto.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR CENTRO DE COSTO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCentroCosto.Focus();
                return false;
            }
            if (txtCalle.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA CALLE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCalle.Focus();
                return false;
            }
            if (TxtNumExt.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL NUMERO EXTERIOR...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNumExt.Focus();
                return false;
            }
            if (txtLatitud.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LATITUD...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLatitud.Focus();
                return false;
            }
            if (txtLongitud.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LONGITUD...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLongitud.Focus();
                return false;
            }
            //if (txtNumInt.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("FALTA CAPTURAR EL NUMERO INTERIOR..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtNumInt.Focus();
            //    return false;
            //}
            if (txtCP.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR EL CODIGO POSTAL..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumInt.Focus();
                return false;
            }

            if (txt_HF.Value.Hour == txt_HI.Value.Hour)
            {
                MessageBox.Show("LA HORA FINAL DEBE SER MAYOR A LA INICIAL ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            BaseErrorResultado = false;
            return true;
        }

        public override void BaseMetodoRecarga()
        {
            GlobalVar.dtEmpleados = sqlCatalogos.Sk_Empleado();
            base.BaseMetodoRecarga();
        }
       
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Busquedas.Frm_Busca_Empleado frm = new Busquedas.Frm_Busca_Empleado();
            frm.BusquedaPropiedadCamposBusqueda = DevuelveCamposBusqueda(GlobalVar.dtEmpleados);
            frm.BusquedaPropiedadTablaFiltra = GlobalVar.dtEmpleados;
            frm.BusquedaPropiedadTitulo = "Busca Empleados";
            frm.ShowDialog();
            if (frm.BusquedaPropiedadReglonRes != null)
            {
                K_JefeOficina = Convert.ToInt16(frm.BusquedaPropiedadReglonRes["K_Empleado"]);
                txtJefeOficina.Text = frm.BusquedaPropiedadReglonRes["D_Empleado"].ToString();
            }
        }

        private void TxtNumExt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

         
        }

        private void txtCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnGoogle_Click(object sender, EventArgs e)
        {
            if (geo_Colonia1.K_Colonia == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA COLONIA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tcControles.SelectTab(tpDomicilio);
                geo_Colonia1.txt_G_Ciudad.Focus();
                return;
            }

            if (txtCalle.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR CALLE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tcControles.SelectTab(tpDomicilio);
                txtCalle.Focus();
                return;
            }

            if (CatalogoPropiedadEsRegistroNuevo)
            {
                FRM_GEO frm = new FRM_GEO(Convert.ToDouble("25.756322"), Convert.ToDouble("-100.404066"), txtCalle.Text + " "+ geo_Colonia1.txt_G_Colonia.Text, true);
                frm.ShowDialog();
                txtLatitud.Text = frm.txtLatitud.Text;
                txtLongitud.Text = frm.txtLongitud.Text;
                frm.Dispose();
            }
            else
            {
                FRM_GEO frm = new FRM_GEO(Convert.ToDouble(txtLatitud.Text),Convert.ToDouble(txtLongitud.Text),txtCalle.Text  +" "+ geo_Colonia1.txt_G_Colonia.Text, false);
                frm.ShowDialog();
                txtLatitud.Text = frm.txtLatitud.Text;
                txtLongitud.Text = frm.txtLongitud.Text;
                frm.Dispose();
                   
            }
                     
        }

       
    }
}
