using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiagTool_Kanwairen
{
    public partial class NRCTableForm : Form
    {
        public NRCTableForm()
        {
            InitializeComponent();
        }

        /*Run before display*/
        private void NRCTableLoad(object sender, EventArgs e)
        {
            int index = 0;

            index = this.NRCDataGridView.Rows.Add();
            this.NRCDataGridView.Rows[index].Cells[0].Value = "1";
            this.NRCDataGridView.Rows[index].Cells[1].Value = "10";
            this.NRCDataGridView.Rows[index].Cells[2].Value = "GeneralReject[GR]";

            index = this.NRCDataGridView.Rows.Add();
            this.NRCDataGridView.Rows[index].Cells[0].Value = "2";
            this.NRCDataGridView.Rows[index].Cells[1].Value = "11";
            this.NRCDataGridView.Rows[index].Cells[2].Value = "ServiceNotSupported[SNS]";

            index = this.NRCDataGridView.Rows.Add();
            this.NRCDataGridView.Rows[index].Cells[0].Value = "3";
            this.NRCDataGridView.Rows[index].Cells[1].Value = "12";
            this.NRCDataGridView.Rows[index].Cells[2].Value = "SubFunctionNotSupported[SFNS]";

            index = this.NRCDataGridView.Rows.Add();
            this.NRCDataGridView.Rows[index].Cells[0].Value = "4";
            this.NRCDataGridView.Rows[index].Cells[1].Value = "13";
            this.NRCDataGridView.Rows[index].Cells[2].Value = "IncorrectMessageLengthOrInvalidFormat[IMLOIF]";

            index = this.NRCDataGridView.Rows.Add();
            this.NRCDataGridView.Rows[index].Cells[0].Value = "5";
            this.NRCDataGridView.Rows[index].Cells[1].Value = "14";
            this.NRCDataGridView.Rows[index].Cells[2].Value = "ReponseTooLong[RTL]";

            index = this.NRCDataGridView.Rows.Add();
            this.NRCDataGridView.Rows[index].Cells[0].Value = "6";
            this.NRCDataGridView.Rows[index].Cells[1].Value = "21";
            this.NRCDataGridView.Rows[index].Cells[2].Value = "BusyRepeatRequest[BRR]";

            index = this.NRCDataGridView.Rows.Add();
            this.NRCDataGridView.Rows[index].Cells[0].Value = "7";
            this.NRCDataGridView.Rows[index].Cells[1].Value = "22";
            this.NRCDataGridView.Rows[index].Cells[2].Value = "ConditionNotCorrect[CNC]";

            index = this.NRCDataGridView.Rows.Add();
            this.NRCDataGridView.Rows[index].Cells[0].Value = "8";
            this.NRCDataGridView.Rows[index].Cells[1].Value = "24";
            this.NRCDataGridView.Rows[index].Cells[2].Value = "RequestSequenceError[RSE]";

            index = this.NRCDataGridView.Rows.Add();
            this.NRCDataGridView.Rows[index].Cells[0].Value = "9";
            this.NRCDataGridView.Rows[index].Cells[1].Value = "25";
            this.NRCDataGridView.Rows[index].Cells[2].Value = "NoResponseFromSubnetComponent[NRFSC]";

            index = this.NRCDataGridView.Rows.Add();
            this.NRCDataGridView.Rows[index].Cells[0].Value = "10";
            this.NRCDataGridView.Rows[index].Cells[1].Value = "26";
            this.NRCDataGridView.Rows[index].Cells[2].Value = "FailurePreventsExcutionOfRequestAction[FPEORA]";

            index = this.NRCDataGridView.Rows.Add();
            this.NRCDataGridView.Rows[index].Cells[0].Value = "11";
            this.NRCDataGridView.Rows[index].Cells[1].Value = "31";
            this.NRCDataGridView.Rows[index].Cells[2].Value = "RequestOutOfRange[ROOD]";

            index = this.NRCDataGridView.Rows.Add();
            this.NRCDataGridView.Rows[index].Cells[0].Value = "12";
            this.NRCDataGridView.Rows[index].Cells[1].Value = "33";
            this.NRCDataGridView.Rows[index].Cells[2].Value = "SecurityAccessDenied[SAD]";

            index = this.NRCDataGridView.Rows.Add();
            this.NRCDataGridView.Rows[index].Cells[0].Value = "13";
            this.NRCDataGridView.Rows[index].Cells[1].Value = "35";
            this.NRCDataGridView.Rows[index].Cells[2].Value = "InvalidKey[IK]";

            index = this.NRCDataGridView.Rows.Add();
            this.NRCDataGridView.Rows[index].Cells[0].Value = "14";
            this.NRCDataGridView.Rows[index].Cells[1].Value = "36";
            this.NRCDataGridView.Rows[index].Cells[2].Value = "ExceedNumberOfAttempt[ENOA]";

            index = this.NRCDataGridView.Rows.Add();
            this.NRCDataGridView.Rows[index].Cells[0].Value = "15";
            this.NRCDataGridView.Rows[index].Cells[1].Value = "37";
            this.NRCDataGridView.Rows[index].Cells[2].Value = "RequiredTimeDelayNotExpired[RTDNE]";

            index = this.NRCDataGridView.Rows.Add();
            this.NRCDataGridView.Rows[index].Cells[0].Value = "16";
            this.NRCDataGridView.Rows[index].Cells[1].Value = "70";
            this.NRCDataGridView.Rows[index].Cells[2].Value = "UploadDownloadNotAccept[UDNA]";

            index = this.NRCDataGridView.Rows.Add();
            this.NRCDataGridView.Rows[index].Cells[0].Value = "17";
            this.NRCDataGridView.Rows[index].Cells[1].Value = "71";
            this.NRCDataGridView.Rows[index].Cells[2].Value = "TransferDataSuspended[TDS]";

            index = this.NRCDataGridView.Rows.Add();
            this.NRCDataGridView.Rows[index].Cells[0].Value = "18";
            this.NRCDataGridView.Rows[index].Cells[1].Value = "72";
            this.NRCDataGridView.Rows[index].Cells[2].Value = "GeneralProgrammingFailure[GPF]";

            index = this.NRCDataGridView.Rows.Add();
            this.NRCDataGridView.Rows[index].Cells[0].Value = "19";
            this.NRCDataGridView.Rows[index].Cells[1].Value = "73";
            this.NRCDataGridView.Rows[index].Cells[2].Value = "WrongBlockSequenceCounter[WBSC]";

            index = this.NRCDataGridView.Rows.Add();
            this.NRCDataGridView.Rows[index].Cells[0].Value = "20";
            this.NRCDataGridView.Rows[index].Cells[1].Value = "78";
            this.NRCDataGridView.Rows[index].Cells[2].Value = "RequestCorrectlyReceived-ResponsePending[RCRRP]";

            index = this.NRCDataGridView.Rows.Add();
            this.NRCDataGridView.Rows[index].Cells[0].Value = "21";
            this.NRCDataGridView.Rows[index].Cells[1].Value = "7E";
            this.NRCDataGridView.Rows[index].Cells[2].Value = "SubFunctionNotSupportedInActiveSession[SFNSIAS]";

            index = this.NRCDataGridView.Rows.Add();
            this.NRCDataGridView.Rows[index].Cells[0].Value = "22";
            this.NRCDataGridView.Rows[index].Cells[1].Value = "7F";
            this.NRCDataGridView.Rows[index].Cells[2].Value = "ServiceNotSupportedInActiveSession[SNSIAS]";

            index = this.NRCDataGridView.Rows.Add();
            this.NRCDataGridView.Rows[index].Cells[0].Value = "23";
            this.NRCDataGridView.Rows[index].Cells[1].Value = "81";
            this.NRCDataGridView.Rows[index].Cells[2].Value = "RpmTooHigh[RPMTH]";

            index = this.NRCDataGridView.Rows.Add();
            this.NRCDataGridView.Rows[index].Cells[0].Value = "24";
            this.NRCDataGridView.Rows[index].Cells[1].Value = "82";
            this.NRCDataGridView.Rows[index].Cells[2].Value = "RpmTooLow[RPMTL]";

            index = this.NRCDataGridView.Rows.Add();
            this.NRCDataGridView.Rows[index].Cells[0].Value = "25";
            this.NRCDataGridView.Rows[index].Cells[1].Value = "83";
            this.NRCDataGridView.Rows[index].Cells[2].Value = "EnginelsRunning[EIR]";

            index = this.NRCDataGridView.Rows.Add();
            this.NRCDataGridView.Rows[index].Cells[0].Value = "26";
            this.NRCDataGridView.Rows[index].Cells[1].Value = "84";
            this.NRCDataGridView.Rows[index].Cells[2].Value = "EnginelsNotRunning[EINR]";

            index = this.NRCDataGridView.Rows.Add();
            this.NRCDataGridView.Rows[index].Cells[0].Value = "27";
            this.NRCDataGridView.Rows[index].Cells[1].Value = "85";
            this.NRCDataGridView.Rows[index].Cells[2].Value = "EngineRunTimeTooLow[ERTTL]";

            index = this.NRCDataGridView.Rows.Add();
            this.NRCDataGridView.Rows[index].Cells[0].Value = "28";
            this.NRCDataGridView.Rows[index].Cells[1].Value = "86";
            this.NRCDataGridView.Rows[index].Cells[2].Value = "TemperatuerTooHigh[TEMPTH]";

            index = this.NRCDataGridView.Rows.Add();
            this.NRCDataGridView.Rows[index].Cells[0].Value = "29";
            this.NRCDataGridView.Rows[index].Cells[1].Value = "87";
            this.NRCDataGridView.Rows[index].Cells[2].Value = "TemperatureTooLow[TEMPTL]";

            index = this.NRCDataGridView.Rows.Add();
            this.NRCDataGridView.Rows[index].Cells[0].Value = "30";
            this.NRCDataGridView.Rows[index].Cells[1].Value = "88";
            this.NRCDataGridView.Rows[index].Cells[2].Value = "VehicleSpeedTooHigh[VSTH]";

            index = this.NRCDataGridView.Rows.Add();
            this.NRCDataGridView.Rows[index].Cells[0].Value = "31";
            this.NRCDataGridView.Rows[index].Cells[1].Value = "89";
            this.NRCDataGridView.Rows[index].Cells[2].Value = "VehicleSpeedTooLow[VSTL]";

            index = this.NRCDataGridView.Rows.Add();
            this.NRCDataGridView.Rows[index].Cells[0].Value = "32";
            this.NRCDataGridView.Rows[index].Cells[1].Value = "8A";
            this.NRCDataGridView.Rows[index].Cells[2].Value = "Throttle/PedalTooHigh[TPTH]";

            index = this.NRCDataGridView.Rows.Add();
            this.NRCDataGridView.Rows[index].Cells[0].Value = "33";
            this.NRCDataGridView.Rows[index].Cells[1].Value = "8B";
            this.NRCDataGridView.Rows[index].Cells[2].Value = "Throttle/PedalTooLow[THTL]";

            index = this.NRCDataGridView.Rows.Add();
            this.NRCDataGridView.Rows[index].Cells[0].Value = "34";
            this.NRCDataGridView.Rows[index].Cells[1].Value = "8C";
            this.NRCDataGridView.Rows[index].Cells[2].Value = "TransmissionRangeNotInNeutral[TRNIN]";

            index = this.NRCDataGridView.Rows.Add();
            this.NRCDataGridView.Rows[index].Cells[0].Value = "35";
            this.NRCDataGridView.Rows[index].Cells[1].Value = "8D";
            this.NRCDataGridView.Rows[index].Cells[2].Value = "TransmissionRangeNotInGear[TRING]";

            index = this.NRCDataGridView.Rows.Add();
            this.NRCDataGridView.Rows[index].Cells[0].Value = "36";
            this.NRCDataGridView.Rows[index].Cells[1].Value = "8F";
            this.NRCDataGridView.Rows[index].Cells[2].Value = "BrakeSwitchNotClosed[BSNC]";

            index = this.NRCDataGridView.Rows.Add();
            this.NRCDataGridView.Rows[index].Cells[0].Value = "37";
            this.NRCDataGridView.Rows[index].Cells[1].Value = "90";
            this.NRCDataGridView.Rows[index].Cells[2].Value = "ShifterLeverNotInPark[SLNIP]";

            index = this.NRCDataGridView.Rows.Add();
            this.NRCDataGridView.Rows[index].Cells[0].Value = "38";
            this.NRCDataGridView.Rows[index].Cells[1].Value = "91";
            this.NRCDataGridView.Rows[index].Cells[2].Value = "TorqueConverterCluthLocked[TCCL]";

            index = this.NRCDataGridView.Rows.Add();
            this.NRCDataGridView.Rows[index].Cells[0].Value = "39";
            this.NRCDataGridView.Rows[index].Cells[1].Value = "92";
            this.NRCDataGridView.Rows[index].Cells[2].Value = "VoltageTooHigh[VTH]";

            index = this.NRCDataGridView.Rows.Add();
            this.NRCDataGridView.Rows[index].Cells[0].Value = "40";
            this.NRCDataGridView.Rows[index].Cells[1].Value = "93";
            this.NRCDataGridView.Rows[index].Cells[2].Value = "VoltageTooLow[VTL]";
        }

        /*Redefine FormClosing action*/
        private void NRCTableFormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
