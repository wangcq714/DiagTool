using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagTool_Luffy
{
    class DiagDataGridViewRowData
    {
        public string type = String.Empty;
        public string id = String.Empty;
        public string len = String.Empty;
        public string data = String.Empty;
        public string ts = String.Empty;
    }

    class DiagDataGridViewRowDataQueue
    {
        public DiagDataGridViewRowDataQueue(DiagDataGridViewRowData[] DiagDataGridViewRowData)
        {
            this.Depth = DiagDataGridViewRowData.Length;
            this.DiagDataGridViewRowData = DiagDataGridViewRowData;
        }

        public int Depth;
        public byte WritePointer;
        public byte ReadPointer;
        public bool FullFlag;
        public bool EmptyFlag;
        public DiagDataGridViewRowData[] DiagDataGridViewRowData;

        public void QueueInit()
        {
            this.WritePointer = 0;
            this.ReadPointer = 0;
            this.EmptyFlag = true;
            this.FullFlag = false;
        }

        public void PushQueue(DiagDataGridViewRowData data)
        {
            byte Writeptr = 0;

            Writeptr = (byte)((this.WritePointer + 1) & ((byte)(this.Depth - 1)));

            if ((Writeptr) == (this.ReadPointer))
            {
                this.FullFlag = true;
            }
            else
            {
                this.EmptyFlag = false;
                this.WritePointer = Writeptr;
                this.DiagDataGridViewRowData[this.WritePointer] = data;
            }
        }
        public void PopQueue(ref DiagDataGridViewRowData data)
        {
            if (this.ReadPointer < (this.Depth - 1))
            {
                (this.ReadPointer)++;
            }
            else
            {
                this.ReadPointer = 0x00;
            }

            data = this.DiagDataGridViewRowData[this.ReadPointer];

            if (this.WritePointer == this.ReadPointer)
            {
                this.EmptyFlag = true;
            }
        }
    }
}
