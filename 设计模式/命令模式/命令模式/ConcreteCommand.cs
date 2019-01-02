using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 命令模式
{
    class ConcreteCommand : Command
    {
        public override void Excute()
        {
            Receiver.Action("执行请求A");
        }
    }
}
