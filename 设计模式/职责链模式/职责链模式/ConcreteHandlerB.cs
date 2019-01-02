using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 职责链模式
{
    class ConcreteHandlerB : Handler
    {
        public override void HandlerRequest(int request)
        {
            if (request < 100)
            {
                Console.WriteLine("没问题 我是老二 我有权利");
            }
            else
            {
                handler.HandlerRequest(request);
            }
        }

    }
}
