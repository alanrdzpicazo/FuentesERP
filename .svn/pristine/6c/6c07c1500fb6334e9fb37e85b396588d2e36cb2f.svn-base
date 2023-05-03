using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using ProbeMedic.Entities.Events;

namespace ProbeMedic.INVENTARIOS
{
    public partial class NotaRecepcionGridUC : UserControl
    {

        private NotaRecepcionItemUC[] rows;
 
        private DataTable dtDetalle;

        private int selectedIndex = 0;
        public int SelectedIndex { get { return selectedIndex; } set { selectedIndex = value;
                setSelectedRow();
        } }

        private bool isFactura = false;
        public bool IsFactura
        {
            get { return isFactura; }
            set
            {
                if (isFactura != value)
                {
                    isFactura = value;
                    if (rows != null)
                        foreach (var dr in rows)
                        {
                            dr.IsFactura = isFactura;
                        }
                }
            }
        }

        private void setSelectedRow()
        {
            if (rows != null)
            {
                foreach (var dr in rows)
                {
                    if ((dr.RowIndex == selectedIndex)) // dr.IsSelected !=
                    {
                        if (!dr.IsSelected)
                        {
                            dr.IsSelected = (dr.RowIndex == selectedIndex);
                            Control[] ctrl = dr.Controls.Find("cmbKTipoEmpaque", true);
                            if ((ctrl != null) && (ctrl.Length != 0))
                            {
                                if ((ctrl[0] is ComboBox) && (((ComboBox)ctrl[0]).Enabled))
                                {
                                    ctrl[0].Focus();
                                }
                                else
                                {
                                    Control[] ctrl2 = dr.Controls.Find("txtgCantidadNota", true);
                                    if ((ctrl2[0] is TextBox) && (((TextBox)ctrl2[0]).Enabled))
                                    {
                                        ctrl2[0].Focus();
                                    }
                                }
                            }
                            else
                            {
                                Control[] ctrl2 = dr.Controls.Find("txtgCantidadNota", true);
                                //if ((ctrl2[0] is TextBox) && (((TextBox)ctrl2[0]).Enabled))
                                //{
                                //    ctrl2[0].Focus();
                                //}
                            }
                        }
                    }
                    else
                        dr.IsSelected = false;
                }
            }
        }

        public DataTable DataSource { get { 
            // Get all values
            return dtDetalle; } set {                
                dtDetalle = value; 
                // Set all items
                SetAllItems();
            } }

        private void SetAllItems()
        {
            if (dtDetalle != null)
            {
                this.Controls.Clear();
                IList<NotaRecepcionItemUC> list = new List<NotaRecepcionItemUC>();
                int rowNumber = 0;
                foreach (DataRow dr in dtDetalle.Rows)
                {
                    //onInternalRowEnter
                    var newRow = new NotaRecepcionItemUC() { RowIndex = rowNumber, IsSelected = false }; // (rowNumber == 0)
                    //newRow.ThisRowEnter += onInternalRowEnter;
                    newRow.CantidadNota = this.CantidadNota;
                    newRow.CantidadRecibida = this.CantidadRecibida;
                    newRow.DataSourceRow = dr;

                    newRow.RowHeadSelectedColor = Color.FromArgb(0, 51, 102);
                    newRow.RowHeadColor = Color.White;
                    newRow.IsFactura = isFactura;
                    newRow.DtEmpaque = dtEmpaque;
                    newRow.DisplayMemberEmpaque = displayMemberEmpaque;
                    newRow.SelectedValueMemberEmpaque = selectedValueMemberEmpaque;

                    Application.DoEvents();
                    list.Add(newRow);
                    rowNumber++;
                }
                rows = list.ToArray<NotaRecepcionItemUC>();
                foreach (var row in rows.OrderByDescending(x=>x.RowIndex)) 
                {
                    row.Dock = DockStyle.Top;
                    this.Controls.Add(row);
                }
                Application.DoEvents();
                int internalTabIndex = 40;
                foreach (var row in rows.OrderBy(x => x.RowIndex))
                {
                    row.TabIndex = internalTabIndex;
                    row.InternalTabIndex = internalTabIndex+1;
                    internalTabIndex += 18;
                }


            }
        }

        public Label CantidadNota { get; set; }
        public Label CantidadRecibida { get; set; }

        //private void onInternalRowEnter(object sender, GridEnterRowEventArgs e)
        //{
        //    SelectedIndex = e.SelectedIndex;
        //}

        public NotaRecepcionGridUC()
        {
            InitializeComponent();
        }

        private DataTable dtEmpaque;
        public DataTable DtEmpaque { get { return dtEmpaque; } set {

            if (dtEmpaque != value)
            {
                dtEmpaque = value;
                if (rows != null)
                    foreach (var dr in rows)
                    {
                        dr.DtEmpaque = dtEmpaque;
                    }

            }
        } }

        private string displayMemberEmpaque;
        public string DisplayMemberEmpaque { get { return displayMemberEmpaque; } set {

            if (displayMemberEmpaque != value)
            {
                displayMemberEmpaque = value;
                if (rows != null)
                    foreach (var dr in rows)
                    {
                        dr.DisplayMemberEmpaque = displayMemberEmpaque;
                    }
            }
        
        
        } }
        private string selectedValueMemberEmpaque;
        public string SelectedValueMemberEmpaque { get { return selectedValueMemberEmpaque; } set {

            if (selectedValueMemberEmpaque != value)
            {
                selectedValueMemberEmpaque = value;
                if (rows != null)
                    foreach (var dr in rows)
                    {
                        dr.SelectedValueMemberEmpaque = selectedValueMemberEmpaque;
                    }
            }
        
        } }
    }
}
