using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProbeMedic.Controles
{
    public partial class Ctrl_Asignacion : UserControl
    {
        public DataTable dtDisponible ; public DataTable dtAsignado ;

        public string  KAsignado = string.Empty, KDisponible = string.Empty, DAsignado = string.Empty, DDisponible = string.Empty;
        private DataTable dtTabla;

        public Ctrl_Asignacion()
        {
            InitializeComponent();

            
            
        }
        public  void llena_listados()
        {
            lst_Disponible.ValueMember = KDisponible;
            lst_Disponible.DisplayMember = DDisponible;

            lst_Asignado.ValueMember = KAsignado;
            lst_Asignado.DisplayMember = DAsignado;

            if (dtDisponible != null)
            {
                if (dtDisponible.Rows.Count > 0)
                {

                                   
                    lst_Disponible.DataSource = dtDisponible;


                }
            }
            else
            {
                dtDisponible = new DataTable();
                dtDisponible.Columns.Add(KDisponible, typeof(int));
                dtDisponible.Columns.Add(DDisponible, typeof(string));

                
                lst_Disponible.DataSource = dtDisponible;


            }
            if (dtAsignado != null)
            {
                if (dtAsignado.Rows.Count > 0)
                {
                    lst_Asignado.DataSource = dtAsignado;
                }
            }
            else
            {
                dtAsignado = new DataTable();
                dtAsignado.Columns.Add(KAsignado, typeof(int));
                dtAsignado.Columns.Add(DAsignado, typeof(string));
                lst_Asignado.DataSource = dtAsignado;
            }
        }

        private void iDer_Click(object sender, EventArgs e)
        { //Asignado a Disponible         
            
            foreach(DataRow row in dtAsignado.Rows ){
               
                if(row[0].ToString()==lst_Asignado.SelectedValue.ToString()){

                    object[] newRow = new object[2];                    
                    newRow[0] = row[0];
                    newRow[1] = row[1];

                    if (dtDisponible != null)
                    {
                        dtDisponible.LoadDataRow(newRow, true);
                        dtDisponible.DefaultView.Sort = DDisponible + " ASC";
                        dtAsignado.Rows.Remove(row);

                        lst_Asignado.DataSource = dtAsignado;
                        lst_Disponible.DataSource = dtDisponible;
                        break;
                    }
                    else
                    {
                        DataRow dr = dtDisponible.NewRow();

                        dr[KDisponible] = row[0];
                        dr[DDisponible] = row[1];
                        dtDisponible.Rows.Add(dr);

                        dtDisponible.DefaultView.Sort = DDisponible + " ASC";
                        dtAsignado.Rows.Remove(row);

                        lst_Disponible.DataSource = dtDisponible;
                        lst_Asignado.DataSource = dtAsignado;
                        break;
                    }
                }
            }
            
        }

        private void iLeft_Click(object sender, EventArgs e)
        {//Disponible a Asignado
            foreach (DataRow row in dtDisponible.Rows)
            {

                if (row[0].ToString() == lst_Disponible.SelectedValue.ToString())
                {

                    object[] newRow = new object[2];
                    newRow[0] = row[0];
                    newRow[1] = row[1];

                    if (dtAsignado != null)
                    {
                        dtAsignado.LoadDataRow(newRow, true);
                        dtAsignado.DefaultView.Sort = DAsignado + " ASC";
                        dtDisponible.Rows.Remove(row);

                        lst_Disponible.DataSource = dtDisponible;
                        lst_Asignado.DataSource = dtAsignado;
                        break;
                    }
                    else
                    {
                        DataRow dr = dtAsignado.NewRow();                        

                        dr[KAsignado] = row[0];
                        dr[DAsignado] = row[1];
                        dtAsignado.Rows.Add(dr);
                        
                        dtAsignado.DefaultView.Sort = DAsignado + " ASC";
                        dtDisponible.Rows.Remove(row);

                        lst_Disponible.DataSource = dtDisponible;
                        lst_Asignado.DataSource = dtAsignado;
                        break;
                        
                    }
                }
            }
        }

        private void tDer_Click(object sender, EventArgs e)
        {
            dtTabla = dtAsignado.Copy();
            foreach (DataRow row in dtTabla.Rows)
            {               

                    object[] newRow = new object[2];
                    newRow[0] = row[0];
                    newRow[1] = row[1];

                    if (dtDisponible != null)
                    {
                        dtDisponible.LoadDataRow(newRow, true);
                        dtDisponible.DefaultView.Sort = DDisponible + " ASC";
                        
                    }
                    else
                    {
                        DataRow dr = dtDisponible.NewRow();

                        dr[KDisponible] = row[0];
                        dr[DDisponible] = row[1];
                        dtDisponible.Rows.Add(dr);

                        dtDisponible.DefaultView.Sort = DDisponible + " ASC";                                               
                        
                    }
                
            }
            dtAsignado.Clear();
            lst_Asignado.DataSource = dtAsignado;
            lst_Disponible.DataSource = dtDisponible;
           
        }

        private void tLeft_Click(object sender, EventArgs e)
        {
            dtTabla = dtDisponible.Copy();
            foreach (DataRow row in dtTabla.Rows)
            {

                object[] newRow = new object[2];
                newRow[0] = row[0];
                newRow[1] = row[1];

                if (dtAsignado != null)
                {
                    dtAsignado.LoadDataRow(newRow, true);
                    dtAsignado.DefaultView.Sort = DAsignado + " ASC";
                }
                else
                {
                    DataRow dr = dtAsignado.NewRow();

                    dr[KAsignado] = row[0];
                    dr[DAsignado] = row[1];
                    dtAsignado.Rows.Add(dr);

                    dtAsignado.DefaultView.Sort = DAsignado + " ASC";
                }
                

            }
            dtDisponible.Clear();
            lst_Asignado.DataSource = dtAsignado;
            lst_Disponible.DataSource = dtDisponible;
        }


        

       
    }
}
