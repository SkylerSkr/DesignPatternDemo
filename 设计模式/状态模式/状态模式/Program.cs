/**
 * 状态模式
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 状态模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Work w = new Work();
            w.SetState();

            w.Hour = 10;
            w.WriteCode();

            w.Hour = 12;
            w.WriteCode();

            w.Hour = 15;
            w.WriteCode();

            w.Hour = 18;
            w.WriteCode();

            w.TaskFinished = true;
            w.WriteCode();

            Console.ReadKey();
        }
    }
}
