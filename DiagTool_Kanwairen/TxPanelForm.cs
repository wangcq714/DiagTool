using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DiagTool_Kanwairen
{
    public partial class TxPanelForm : Form
    {
        public TxPanelForm()
        {
            InitializeComponent();
        }

        /*Run before display*/
        private void TxPanelWindowLoad(object sender, EventArgs e)
        {
            this.TxPanelDataGridView.CellContentClick += this.TxPanelDataGridView_CellContentClick;
        }

        /*Redefine FormClosing action*/
        private void TxPanelFormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        /*Run while any cell content is clicked in DataGridView*/
        private void TxPanelDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*Judge if or not TxButton is clicked*/
            if (TxPanelDataGridView.Columns[e.ColumnIndex].Name == "Tx")
            {
                MessageBox.Show("行: " + e.RowIndex.ToString() + ", 列: " + e.ColumnIndex.ToString() + "; Button"); // Debug
                
                if (Regex.IsMatch(TxPanelDataGridView.Rows[e.RowIndex].Cells["Period"].EditedFormattedValue.ToString(), "^([1-9]{1}[0-9]+)$") &&
                    Regex.IsMatch(TxPanelDataGridView.Rows[e.RowIndex].Cells["AbrID"].EditedFormattedValue.ToString(), "^(([0-9 A-F]{1,2})|([0-7]{1}[0-9 A-Z]{2}))$") &&
                    Regex.IsMatch(TxPanelDataGridView.Rows[e.RowIndex].Cells["Period"].EditedFormattedValue.ToString(), "^([1-9]{1}[0-9]+)$") &&
                    Regex.IsMatch(TxPanelDataGridView.Rows[e.RowIndex].Cells["DLC"].EditedFormattedValue.ToString(), "^[1-8]{1}$") &&
                    Regex.IsMatch(TxPanelDataGridView.Rows[e.RowIndex].Cells["B0"].EditedFormattedValue.ToString(), "^([0-9 A-F]{1,2})?$") &&
                    Regex.IsMatch(TxPanelDataGridView.Rows[e.RowIndex].Cells["B1"].EditedFormattedValue.ToString(), "^([0-9 A-F]{1,2})?$") &&
                    Regex.IsMatch(TxPanelDataGridView.Rows[e.RowIndex].Cells["B2"].EditedFormattedValue.ToString(), "^([0-9 A-F]{1,2})?$") &&
                    Regex.IsMatch(TxPanelDataGridView.Rows[e.RowIndex].Cells["B3"].EditedFormattedValue.ToString(), "^([0-9 A-F]{1,2})?$") &&
                    Regex.IsMatch(TxPanelDataGridView.Rows[e.RowIndex].Cells["B4"].EditedFormattedValue.ToString(), "^([0-9 A-F]{1,2})?$") &&
                    Regex.IsMatch(TxPanelDataGridView.Rows[e.RowIndex].Cells["B5"].EditedFormattedValue.ToString(), "^([0-9 A-F]{1,2})?$") &&
                    Regex.IsMatch(TxPanelDataGridView.Rows[e.RowIndex].Cells["B6"].EditedFormattedValue.ToString(), "^([0-9 A-F]{1,2})?$") &&
                    Regex.IsMatch(TxPanelDataGridView.Rows[e.RowIndex].Cells["B7"].EditedFormattedValue.ToString(), "^([0-9 A-F]{1,2})?$"))
                {

                }
            }
            /*Judge if or not TxButton is clicked*/
            else if (TxPanelDataGridView.Columns[e.ColumnIndex].Name == "Auto")
            {
                //Console.WriteLine("{0}", ((DataGridViewCheckBoxCell)TxPanelDataGridView.Rows[e.RowIndex].Cells["Auto"]).Value);
                MessageBox.Show("行: " + e.RowIndex.ToString() + ", 列: " + e.ColumnIndex.ToString() + "; CheckBox:" + TxPanelDataGridView.Rows[e.RowIndex].Cells["Auto"].EditedFormattedValue.ToString()); // Debug
            }
            //Console.WriteLine("ha"); //Debug
        }
    }    
}
