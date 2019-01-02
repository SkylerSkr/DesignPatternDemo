using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 职责链模式
{
    class ConcreteHandlerC : Handler
    {
        public override void HandlerRequest(int request)
        {
            if (request < 1000)
            {
                Console.WriteLine("没问题 我是老大 我觉的ok");
            }
            else
            {
                Console.WriteLine("我是老大 但是我不同意");
            }
        }
    }
}
