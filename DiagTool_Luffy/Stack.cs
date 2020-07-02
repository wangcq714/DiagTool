using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagTool_Luffy
{
    class GenericStack
    {
        public GenericStack(object[] Datas)
        {
            this.Depth = Datas.Length;
            this.Datas = Datas;
        }

        public int Depth;
        public object[] Datas;
        public int Top;
        public int Bottom;


        public void InitStack()
        {
            this.Top = 0;
            this.Bottom = 0;           
        }

        public void PushStack(object data)
        {
            if (this.Top < (this.Depth - 1))
            {
                this.Datas[++this.Top] = data;
            }
        }

        public void PopStack(ref object data)
        {
            if (this.Top > this.Bottom)
            {
                data = this.Datas[this.Top--];
            }
        }

        public bool IsFull()
        {
            return (this.Top == this.Depth);
        }

        public bool IsEmpty()
        {
            return (this.Top == this.Bottom);
        }

    }
}
