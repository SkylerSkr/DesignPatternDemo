/**
 * 命令模式
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 命令模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建命令管理者
            Invoker invoker = new Invoker();

            //创建执行者和命令 并指定命令执行者
            Receiver r = new Receiver();//执行者
            ConcreteCommand c1 = new ConcreteCommand();//创建命令
            c1.Receiver = r;//指定执行者
            ConcreteCommandB c2 = new ConcreteCommandB();
            c2.Receiver = r;

            invoker.SetCommand(c1);
            invoker.SetCommand(c2);
            invoker.SetCommand(c1);
            invoker.ExecuteCommand();

            Console.WriteLine("------------------------");

            invoker.RemoveCommand(c2);
            invoker.ExecuteCommand();

            Console.ReadKey();
        }
    }
}
