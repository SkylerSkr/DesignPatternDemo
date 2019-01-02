using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 命令模式
{
    abstract class Command
    {
        private Receiver receiver;

        public Receiver Receiver { get => receiver; set => receiver = value; }

        public abstract void Excute();
    }
}
