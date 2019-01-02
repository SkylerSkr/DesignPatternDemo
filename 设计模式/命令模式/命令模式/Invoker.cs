using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 命令模式
{
    class Invoker
    {
        private List<Command> list = new List<Command>();

        public void SetCommand(Command command)
        {
            list.Add(command);
        }

        public void RemoveCommand(Command command)
        {
            list.Remove(command);
        }

        public void ExecuteCommand()
        {
            foreach (Command c in list)
            {
                c.Excute();
            }
        }
    }
}
