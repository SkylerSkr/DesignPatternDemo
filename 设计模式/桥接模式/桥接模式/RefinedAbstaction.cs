using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 桥接模式
{
    class RefinedAbstaction : Abstraction
    {
        public RefinedAbstaction(Implementor i) : base(i)
        {
        }

        public override void Operation()
        {
            implementor.Operation();
        }
    }
}
