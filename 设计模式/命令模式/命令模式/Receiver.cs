using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 命令模式
{
    class Receiver
    {
        public void Action(string command)
        {
            Console.WriteLine(command);
        }
    }
}
