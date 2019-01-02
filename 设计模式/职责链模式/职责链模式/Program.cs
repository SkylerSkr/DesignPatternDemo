/**
 * 职责链模式
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 职责链模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建几个处理机制 并设置好等级
            ConcreteHandler c1 = new ConcreteHandler();
            ConcreteHandlerB c2 = new ConcreteHandlerB();
            ConcreteHandlerC c3 = new ConcreteHandlerC();
            c1.SetHandler(c2);
            c2.SetHandler(c3);

            c1.HandlerRequest(5);
            c1.HandlerRequest(10);
            c1.HandlerRequest(200);
            c1.HandlerRequest(50000);
            c1.HandlerRequest(20);

            Console.ReadKey();
        }
    }
}
