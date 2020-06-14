using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagTool_Luffy
{
    class GenericQueue
    {
        public GenericQueue(object[] Datas)
        {
            this.Depth = Datas.Length;
            this.Datas = Datas;
        }

        public int Depth;
        public byte WritePointer;
        public byte ReadPointer;
        public bool FullFlag;
        public bool EmptyFlag;
        public object[] Datas;

        public void QueueInit()
        {
            this.WritePointer = 0;
            this.ReadPointer = 0;
            this.EmptyFlag = true;
            this.FullFlag = false;
        }

        public void PushQueue(object data)
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
                this.Datas[this.WritePointer] = data;
            }
        }
        public void PopQueue(ref object data)
        {
            if (this.ReadPointer < (this.Depth - 1))
            {
                (this.ReadPointer)++;
            }
            else
            {
                this.ReadPointer = 0x00;
            }

            data = this.Datas[this.ReadPointer];

            if (this.WritePointer == this.ReadPointer)
            {
                this.EmptyFlag = true;
            }
        }
    }
}
