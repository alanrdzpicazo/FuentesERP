using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbeMedic.SEGURIDAD
{
    public partial class FRM_USUARIOS : FormaCatalogo
    {
        int res = 0;
        string msg = string.Empty;

        DataTable dtAlmacen = new DataTable();
        DataTable dtAlmacenesXUsuario = new DataTable();

        public FRM_USUARIOS()
        {
            InitializeComponent();
            BaseBotonProceso4.Click += new EventHandler(BaseBotonProceso4_Click);
            this.ucOficinas2.PropertyChanged += new PropertyChangedEventHandler(ucOficinas2_PropertyChanged);
            this.ucEmpresas1.PropertyChanged += new PropertyChangedEventHandler(ucEmpresas1_PropertyChanged);
        }

        private void ucOficinas2_PropertyChanged(object sender, EventArgs e)
        {
            if (ucOficinas2.kOficina > 0)
            {
                CargaAlmacenes();
            }
            else
            {
                if (ucOficinas2.kOficina == 0)
                {
                    dtAlmacen = null;
                }
            }
        }
        private void ucEmpresas1_PropertyChanged(object sender, EventArgs e)
        {
            if (ucEmpresas1.K_Empresa > 0)
            {
                ucOficinas1.K_Oficina = 0;
                ucOficinas1.txt_E_Oficina.Text = string.Empty;
                ucOficinas1.K_Empresa = ucEmpresas1.K_Empresa;
            }
            else
            {
                if (ucEmpresas1.K_Empresa == 0)
                {
                    ucOficinas1.K_Oficina = 0;
                    ucOficinas1.txt_E_Oficina.Text = string.Empty;
                    ucOficinas1.K_Empresa = 0;
                }
            }
        }

        public override void BaseMetodoInicio()
        {
            txtFocus = txtDescripcion; //Asignar el textbox que inicia el focus
            pnlControles.Enabled = false; //NO Borrar
            pnlControles2.Enabled = false;
            panel2.Enabled = false;
            dtAlmacenesXUsuario = Usuarios_Almacenes_Type;
            BaseDtDatos = SeguridadSQL.Sk_Usuario();
            CatalogoPropiedadCampoClave = "K_Usuario";
            CatalogoPropiedadCampoDescripcion = "D_Usuario";

            grdAlmacenesUsuario.AutoGenerateColumns = false;

            tabControl1.SelectedIndex = 0;

            base.BaseMetodoInicio();
        }

        void BaseBotonProceso4_Click(object sender, EventArgs e)
        {
            if (CatalogoPropiedadId_Identity == null)
                return;
            if (CatalogoPropiedadId_Identity.ToString() == "")
                return;
            BaseMetodoInicio();
            BaseBotonCancelarClick();
        }

        public override void CatalogoHabilitaPanelControles(bool B_Habilita)
        {
            pnlControles.Enabled = B_Habilita;
            pnlControles2.Enabled = B_Habilita;
            panel2.Enabled = B_Habilita;
        }

        public override void BaseMetodoLimpiaControles()
        {
            txtClave.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtLogin.Text = string.Empty;
            txtContrasenia.Text = string.Empty;
            ucEmpresas1.txt_G_Empresa.Text = string.Empty;
            ucEmpresas1.K_Empresa = 0;
            ucOficinas1.txt_E_Oficina.Text = string.Empty;
            ucOficinas1.K_Oficina = 0;
            pnlControles.Enabled = false; //NO Borrar  
            ucEmpresas1.Enabled = true;
            ucOficinas1.Enabled = true;
            ucOficinas2.K_Oficina = 0;
            ucOficinas2.kOficina = 0;
            ucOficinas2.txt_E_Oficina.Text = string.Empty;
            dtAlmacen = null;
            cbxAlmacen.DataSource = null;
            cbxAlmacen.Items.Clear();
            cbxAlmacen.AutoCompleteSource = AutoCompleteSource.None;
            cbxAlmacen.AutoCompleteMode = AutoCompleteMode.None;
            cbxCambiaDatosFiscales.Checked = false;
            cbxCambiaSerie.Checked = false;
            cbxNotificacionesTransferencia.Checked = false;
            cbxPermiteAjustes.Checked = false;
            tabControl1.SelectedIndex = 0;
        }

        public override void CatalogoMetodoLlenaControles(DataRow ren)
        {
            BaseMetodoLimpiaControles();
            txtClave.Text = ren["K_Usuario"].ToString();
            txtDescripcion.Text = ren["D_Usuario"].ToString();
            txtLogin.Text = ren["Login"].ToString();
            txtContrasenia.Text = ren["Contrasenia"].ToString();
            txtCorreo.Text = ren["E_Mail"].ToString();
            ucEmpresas1.K_Empresa = Convert.ToInt16(ren["K_Empresa"]);
            ucEmpresas1.txt_G_Empresa.Text = ren["D_Empresa"].ToString();
            ucOficinas1.K_Oficina = Convert.ToInt16(ren["K_Oficina"]);
            ucOficinas1.txt_E_Oficina.Text = ren["D_Oficina"].ToString();
            ucEmpresas1.Enabled = true;
           // ucOficinas1.Enabled = false;

            dtAlmacenesXUsuario = SeguridadSQL.Sk_Usuario_Alamcenes(Convert.ToInt32(txtClave.Text.Trim()));
            if (dtAlmacenesXUsuario != null)
            {
                grdAlmacenesUsuario.DataSource = dtAlmacenesXUsuario;
                grdAlmacenesUsuario.Columns["K_Oficina"].Visible = false;
            }
            else
            {
                grdAlmacenesUsuario.DataSource = null;
                grdAlmacenesUsuario.Columns["K_Oficina"].Visible = false;
            }
            cbxCambiaSerie.Checked = Convert.ToBoolean(ren["B_CambiaSerie"]);
            cbxNotificacionesTransferencia.Checked = Convert.ToBoolean(ren["B_Transferencia"]);
            cbxCambiaDatosFiscales.Checked = Convert.ToBoolean(ren["B_CambiaDatosFiscales"]);
            cbxPermiteAjustes.Checked = Convert.ToBoolean(ren["B_PermiteAjustes"]);
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
                res = SeguridadSQL.Dl_Usuario(Convert.ToInt32(CatalogoPropiedadId_Identity), true, ref msg);

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

            
            DataTable dtDetalle = dtAlmacenesXUsuario.Copy();
            dtDetalle.Columns.Remove("K_Usuario");
            dtDetalle.Columns.Remove("D_Almacen");

            dtDetalle.Columns.Remove("K_Oficina");

            dtDetalle.Columns.Remove("D_Oficina");
            

            if (CatalogoPropiedadEsRegistroNuevo) // Nuevo
            {
                res = SeguridadSQL.In_Usuario(ref CampoIdentity, txtDescripcion.Text, txtLogin.Text, txtContrasenia.Text, txtCorreo.Text, ucEmpresas1.K_Empresa, ucOficinas1.K_Oficina,dtDetalle,cbxCambiaSerie.Checked,cbxNotificacionesTransferencia.Checked,cbxCambiaDatosFiscales.Checked,cbxPermiteAjustes.Checked, ref msg);
                dtAlmacenesXUsuario = SeguridadSQL.Sk_Usuario_Alamcenes(CampoIdentity);

            }
            else //Existe. Update
            {
                CampoIdentity = Convert.ToInt32(CatalogoPropiedadId_Identity);
                res = SeguridadSQL.Up_Usuario(CampoIdentity, txtDescripcion.Text, txtLogin.Text, txtContrasenia.Text, txtCorreo.Text, ucEmpresas1.K_Empresa, ucOficinas1.K_Oficina,dtDetalle,cbxCambiaSerie.Checked,cbxNotificacionesTransferencia.Checked, cbxCambiaDatosFiscales.Checked, cbxPermiteAjustes.Checked, ref msg);
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
                CargaTablasParciales(6);
            
            }

        }

        public override bool BaseFuncionValidaciones()
        {
            BaseErrorResultado = true;

            if (txtDescripcion.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR NOMBRE...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                return false;
            }
            if (txtLogin.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR USUARIO...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLogin.Focus();
                return false;
            }
            if (txtContrasenia.Text.Trim().Length == 0)
            {
                MessageBox.Show("FALTA CAPTURAR CONTRASEÑA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContrasenia.Focus();
                return false;
            }
            if (ucEmpresas1.K_Empresa == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA EMPRESA...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucEmpresas1.Focus();
                return false;
            }
            if (ucOficinas1.K_Oficina == 0)
            {
                MessageBox.Show("FALTA CAPTURAR LA OFICINA..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucOficinas1.Focus();
                return false;
            }

           if(dtAlmacenesXUsuario == null)
            {
                MessageBox.Show("FALTA CAPTURAR LOS ALMACENES..!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            BaseErrorResultado = false;
            return true;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {         
            if (Convert.ToInt32(cbxAlmacen.SelectedValue) == 0)
            {
                MessageBox.Show("SELECCIONE UN ALMACÉN", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ucOficinas2.Focus();
                return;
            }
            if (ucOficinas2.kOficina == 0)
            {
                MessageBox.Show("SELECCIONE UNA OFICINA", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ucOficinas2.Focus();
                return;
            }
    
            if(dtAlmacenesXUsuario != null)
            {
                foreach (DataRow row in dtAlmacenesXUsuario.Rows)
                {
                    if (Convert.ToInt32(row["K_Almacen"]) == Convert.ToInt32(cbxAlmacen.SelectedValue.ToString()))
                    {
                        MessageBox.Show("EL ALMACEN SE ENCUENTRA ASIGNADO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            
            if (dtAlmacenesXUsuario == null)
            {
                dtAlmacenesXUsuario = Usuarios_Almacenes_Type;
            }
            DataRow dr;
            dr = dtAlmacenesXUsuario.NewRow();

            dr["K_Oficina"] = ucOficinas2.kOficina;
            dr["D_Oficina"] = ucOficinas2.txt_E_Oficina.Text;
            dr["K_Almacen"] = cbxAlmacen.SelectedValue.ToString();
            dr["D_Almacen"] = BuscarAlmacen(ucOficinas2.kOficina, Convert.ToInt32(cbxAlmacen.SelectedValue));
            if (txtClave.Text != "")
            {
                dr["K_Usuario"] = Convert.ToInt32(txtClave.Text.Trim());
            }
            else
            {
                dr["K_Usuario"] = 0;
            }
            dtAlmacenesXUsuario.Rows.Add(dr);

            grdAlmacenesUsuario.DataSource = dtAlmacenesXUsuario;

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dtAlmacenesXUsuario != null)
            {
                if (dtAlmacenesXUsuario.Rows.Count > 0)
                {
                    DataGridViewRow row = grdAlmacenesUsuario.CurrentRow;
                    EliminarRegistro(row.Index);
                }
                else
                {
                    MessageBox.Show("NO EXISTEN REGISTROS PARA ELIMNAR", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
            }
            else
            {
                MessageBox.Show("NO EXISTEN REGISTROS PARA ELIMNAR", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (txtClave.Text != "")
            //{
            //    dtAlmacenesXUsuario = SeguridadSQL.Sk_Usuario_Alamcenes(Convert.ToInt32(txtClave.Text.Trim()));
            //    if (dtAlmacenesXUsuario != null)
            //    {
            //        if(dtAlmacenesXUsuario.Rows.Count>0)
            //        {
            //            grdAlmacenesUsuario.DataSource = dtAlmacenesXUsuario;
            //        }          
            //    }
            //}
        }

        public void EliminarRegistro(int index)
        {              
            dtAlmacenesXUsuario.Rows[index].Delete();
            dtAlmacenesXUsuario.AcceptChanges();
        }

        private void CargaAlmacenes()
        {
            dtAlmacen = null;
            cbxAlmacen.DataSource = null;
            cbxAlmacen.Items.Clear();
            cbxAlmacen.AutoCompleteSource = AutoCompleteSource.None;
            cbxAlmacen.AutoCompleteMode = AutoCompleteMode.None;
    
            dtAlmacen = sqlCatalogos.Sk_Almacenes(ucOficinas2.kOficina);
            
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

                dtAlmacen.Columns.Remove("K_Oficina");
                dtAlmacen.Columns.Remove("D_Oficina");

                LlenaCombo(dtAlmacen, ref cbxAlmacen, "K_Almacen", "D_Almacen", indice);

                cbxAlmacen.SelectedIndex = 0;
            }
        }

        private string BuscarAlmacen(Int32 K_Oficina, Int32 K_Alamcen)
        {
            DataTable dtAlmacenSeleccionado = new DataTable();
            dtAlmacenSeleccionado = sqlCatalogos.Sk_Almacenes(K_Oficina,K_Alamcen);

            if(dtAlmacenSeleccionado.Rows.Count > 0)
            {
                DataRow row;
                row = dtAlmacenSeleccionado.Rows[0];
                return row["D_Almacen"].ToString();

            }
            else
            {
                return null;
            }
        }

   


    }
}
