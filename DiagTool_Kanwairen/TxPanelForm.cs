using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections;

namespace DiagTool_Kanwairen
{
    struct TxPeriodInfoType
    {
        public bool TxEable;     // Enable Tx flag
        public Int64 TimeValue;  // Basetime:1ms
    };

    public partial class TxPanelForm : Form
    {
        /* Define a Txtime Array which can be extended */
        TxPeriodInfoType[] TxPeriodInfoArray = new TxPeriodInfoType[256];

        public TxPanelForm()
        {
            InitializeComponent();
        }

        /*Run before display*/
        private void TxPanelWindowLoad(object sender, EventArgs e)
        {
            this.TxPanelDataGridView.CellContentClick += this.TxPanelDataGridView_CellContentClick;
            this.TxPanelDataGridView.CellValueChanged += this.TxPanelDataGridView_CellValueChanged;
        }

        /*Redefine FormClosing action*/
        private void TxPanelFormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        /* Define Tx function at a time */
        private void TxMsgOneFrame(int RowIndex)
        {
            string msgID = "";
            string msgData = "";
            int msgDataLen = 0;

            /* if not connect device, return */
            if (!Global.passThruWrapper.IsConnectDevice)
                return;

            /* Get ID */
            msgID = TxPanelDataGridView.Rows[RowIndex].Cells["AbrID"].EditedFormattedValue.ToString().Trim();
            /* Get data length */
            msgDataLen = Convert.ToInt32(this.TxPanelDataGridView.Rows[RowIndex].Cells["DLC"].Value.ToString());
            /* Get data */
            for (int i = 0; i < msgDataLen; i++)
            {
                msgData += this.TxPanelDataGridView.Rows[RowIndex].Cells["B" + i.ToString()].Value.ToString().Trim() + " ";
            }
            /* Send message at a time */
            Global.passThruWrapper.TxMsg(msgID, msgData.Trim(), Global.diagUsercontrol.TxRxMsgUpdateDiagDataGridViewCallback);
        }

        /*Run while any cell content is clicked in DataGridView*/
        private void TxPanelDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /* If cell clicked is not header of column. */
            if (e.RowIndex != -1)
            {
                /*Judge if or not TxButton is clicked*/
                if (TxPanelDataGridView.Columns[e.ColumnIndex].Name == "Tx")
                {
                    //MessageBox.Show("行: " + e.RowIndex.ToString() + ", 列: " + e.ColumnIndex.ToString() + "; Button"); // Debug
                    /* Call TxMsgOneTime */
                    TxMsgOneFrame(e.RowIndex);
                }
                /*Judge if or not Period checkbox is selected*/
                else if (TxPanelDataGridView.Columns[e.ColumnIndex].Name == "Auto")
                {
                    //Console.WriteLine("{0},{1}", e.RowIndex.ToString(), e.ColumnIndex.ToString()); // Debug
                    //MessageBox.Show("行: " + e.RowIndex.ToString() + ", 列: " + e.ColumnIndex.ToString() + "; CheckBox:" + TxPanelDataGridView.Rows[e.RowIndex].Cells["Auto"].EditedFormattedValue.ToString()); // Debug
                    TxPeriodInfoArray[e.RowIndex].TxEable = TxPeriodInfoArray[e.RowIndex].TxEable ? false : true;
                    if (!TxPeriodInfoArray[e.RowIndex].TxEable)
                    {
                        TxPeriodInfoArray[e.RowIndex].TimeValue = 0;
                    }
                    //Console.WriteLine("{0}", TxPeriodInfoArray[e.RowIndex].TxEable);
                }
            }

            //Console.WriteLine("ha"); //Debug
        }

        private void BytenValueChanged(int RowIndex, string BytenStr)
        {
            /* If input value is invalid */
            if (!Regex.IsMatch(TxPanelDataGridView.Rows[RowIndex].Cells[BytenStr].EditedFormattedValue.ToString(), "^(0[x,X]{1})?[0-9 A-F a-f]{1,2}$"))
            {
                /* Set default value*/
                this.TxPanelDataGridView.Rows[RowIndex].Cells[BytenStr].Value = "0x0";
            }
            else
            {
                /* If input value is 0x* */
                if (Regex.IsMatch(TxPanelDataGridView.Rows[RowIndex].Cells[BytenStr].EditedFormattedValue.ToString(), "^(0[x,X]{1})"))
                {
                    /* If input value is 0x0* */
                    if (Regex.IsMatch(TxPanelDataGridView.Rows[RowIndex].Cells[BytenStr].EditedFormattedValue.ToString(), "^(0[x,X]{1}0[0-9 A-F a-f]{1})"))
                    {
                        this.TxPanelDataGridView.Rows[RowIndex].Cells[BytenStr].Value = "0x" + TxPanelDataGridView.Rows[RowIndex].Cells[BytenStr].EditedFormattedValue.ToString().Substring(3).ToUpper();
                    }
                    else
                    {
                        this.TxPanelDataGridView.Rows[RowIndex].Cells[BytenStr].Value = "0x" + TxPanelDataGridView.Rows[RowIndex].Cells[BytenStr].EditedFormattedValue.ToString().Substring(2).ToUpper();
                    }

                }
                else
                {
                    this.TxPanelDataGridView.Rows[RowIndex].Cells[BytenStr].Value = "0x" + TxPanelDataGridView.Rows[RowIndex].Cells[BytenStr].EditedFormattedValue.ToString().ToUpper();
                }
            }
        }

        /*Run while any cell content is changed in DataGridView*/
        private void TxPanelDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            /*Judge if or not Period is changed*/
            if (TxPanelDataGridView.Columns[e.ColumnIndex].Name == "Period")
            {
                //MessageBox.Show("行: " + e.RowIndex.ToString() + ", 列: " + e.ColumnIndex.ToString() + "; Value changed"); // Debug
                /* If input value is invalid */
                if (!Regex.IsMatch(TxPanelDataGridView.Rows[e.RowIndex].Cells["Period"].EditedFormattedValue.ToString(), "^([1-9]{1}[0-9]*)$"))
                {
                    //MessageBox.Show("行: " + e.RowIndex.ToString() + ", 列: " + e.ColumnIndex.ToString() + "; Invalid value"); // Debug
                    /* Set default value*/
                    this.TxPanelDataGridView.Rows[e.RowIndex].Cells["Period"].Value = "100";
                }
            }
            /*Judge if or not AbrID is changed*/
            else if (TxPanelDataGridView.Columns[e.ColumnIndex].Name == "AbrID")
            {
                /* If input value is invalid */
                if (!Regex.IsMatch(TxPanelDataGridView.Rows[e.RowIndex].Cells["AbrID"].EditedFormattedValue.ToString(), "^(([8-9 A-F a-f]{1}[0-9 A-F a-f]{0,1})|([1-7]{1}[0-9 A-F a-f]{0,2}))$"))
                {
                    /* Set default value*/
                    this.TxPanelDataGridView.Rows[e.RowIndex].Cells["AbrID"].Value = "1";
                }
                else
                {
                    this.TxPanelDataGridView.Rows[e.RowIndex].Cells["AbrID"].Value = TxPanelDataGridView.Rows[e.RowIndex].Cells["AbrID"].EditedFormattedValue.ToString().ToUpper();
                }
            }
            /*Judge if or not DLC is changed*/
            else if (TxPanelDataGridView.Columns[e.ColumnIndex].Name == "DLC")
            {
                /* If input value is invalid */
                if (!Regex.IsMatch(TxPanelDataGridView.Rows[e.RowIndex].Cells["DLC"].EditedFormattedValue.ToString(), "^[1-8]{1}$"))
                {
                    /* Set default value*/
                    this.TxPanelDataGridView.Rows[e.RowIndex].Cells["DLC"].Value = "8";
                }
            }
            /*Judge if or not B0 is changed*/
            else if (TxPanelDataGridView.Columns[e.ColumnIndex].Name == "B0")
            {
                BytenValueChanged(e.RowIndex, "B0");
            }
            /*Judge if or not B1 is changed*/
            else if (TxPanelDataGridView.Columns[e.ColumnIndex].Name == "B1")
            {
                BytenValueChanged(e.RowIndex, "B1");
            }
            /*Judge if or not B2 is changed*/
            else if (TxPanelDataGridView.Columns[e.ColumnIndex].Name == "B2")
            {
                BytenValueChanged(e.RowIndex, "B2");
            }
            /*Judge if or not B3 is changed*/
            else if (TxPanelDataGridView.Columns[e.ColumnIndex].Name == "B3")
            {
                BytenValueChanged(e.RowIndex, "B3");
            }
            /*Judge if or not B4 is changed*/
            else if (TxPanelDataGridView.Columns[e.ColumnIndex].Name == "B4")
            {
                BytenValueChanged(e.RowIndex, "B4");
            }
            /*Judge if or not B5 is changed*/
            else if (TxPanelDataGridView.Columns[e.ColumnIndex].Name == "B5")
            {
                BytenValueChanged(e.RowIndex, "B5");
            }
            /*Judge if or not B6 is changed*/
            else if (TxPanelDataGridView.Columns[e.ColumnIndex].Name == "B6")
            {
                BytenValueChanged(e.RowIndex, "B6");
            }
            /*Judge if or not B7 is changed*/
            else if (TxPanelDataGridView.Columns[e.ColumnIndex].Name == "B7")
            {
                BytenValueChanged(e.RowIndex, "B7");
            }
        }

        /* When click mouse right key, further click add message , this function run */
        private void AddMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.TxPanelDataGridView.Rows.Count < 256)
            {
                DataGridViewRow dataRow = new DataGridViewRow();
                dataRow.CreateCells(this.TxPanelDataGridView);
                /* Add a row msg in the first line. */
                //this.TxPanelDataGridView.Rows.Insert(0, dataRow);
                /* Add a row msg in the end. */
                this.TxPanelDataGridView.Rows.Add(dataRow);

                /* Init default value */
                this.TxPanelDataGridView.Rows[this.TxPanelDataGridView.Rows.Count - 1].Cells["Period"].Value = "100";
                this.TxPanelDataGridView.Rows[this.TxPanelDataGridView.Rows.Count - 1].Cells["AbrID"].Value = "1";
                this.TxPanelDataGridView.Rows[this.TxPanelDataGridView.Rows.Count - 1].Cells["DLC"].Value = "8";
                this.TxPanelDataGridView.Rows[this.TxPanelDataGridView.Rows.Count - 1].Cells["B0"].Value = "0x0";
                this.TxPanelDataGridView.Rows[this.TxPanelDataGridView.Rows.Count - 1].Cells["B1"].Value = "0x0";
                this.TxPanelDataGridView.Rows[this.TxPanelDataGridView.Rows.Count - 1].Cells["B2"].Value = "0x0";
                this.TxPanelDataGridView.Rows[this.TxPanelDataGridView.Rows.Count - 1].Cells["B3"].Value = "0x0";
                this.TxPanelDataGridView.Rows[this.TxPanelDataGridView.Rows.Count - 1].Cells["B4"].Value = "0x0";
                this.TxPanelDataGridView.Rows[this.TxPanelDataGridView.Rows.Count - 1].Cells["B5"].Value = "0x0";
                this.TxPanelDataGridView.Rows[this.TxPanelDataGridView.Rows.Count - 1].Cells["B6"].Value = "0x0";
                this.TxPanelDataGridView.Rows[this.TxPanelDataGridView.Rows.Count - 1].Cells["B7"].Value = "0x0";

                TxPeriodInfoType TxPeriodInfo;
                TxPeriodInfo.TxEable = false;
                TxPeriodInfo.TimeValue = 0;
                TxPeriodInfoArray[this.TxPanelDataGridView.Rows.Count - 1] = TxPeriodInfo;
            }
            else
            {
                MessageBox.Show("The message counts is up to Maxium."); // Debug
            }


        }

        /* Millisecond Timer callback */
        public void MMTimerCBFunc(uint uTimerID, uint uMsg, UIntPtr dwUser, UIntPtr dw1, UIntPtr dw2)
        {
            /* Callback from the MMTimer API that fires the Timer event. Note we are in a different thread here */
            int msgPeriod = 0;

            for (int i = 0; i < this.TxPanelDataGridView.Rows.Count; i++)
            {
                if ((TxPeriodInfoArray[i]).TxEable == true)
                {
                    TxPeriodInfoArray[i].TimeValue += 2;
                    msgPeriod = Convert.ToInt32(this.TxPanelDataGridView.Rows[this.TxPanelDataGridView.Rows.Count - 1].Cells["Period"].Value);
                    msgPeriod = (msgPeriod % 2 == 0) ? msgPeriod : msgPeriod +1;
                    if (TxPeriodInfoArray[i].TimeValue % msgPeriod == 0)
                    {
                        TxMsgOneFrame(i);
                    }
                    Console.WriteLine("Timer{0}:{1}", i, ((TxPeriodInfoType)TxPeriodInfoArray[i]).TimeValue);
                }
            }
        }
    }
}
