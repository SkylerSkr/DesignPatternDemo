using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 桥接模式
{
    abstract class Abstraction
    {
        protected Implementor implementor;

        public Abstraction(Implementor i)
        {
            this.implementor = i;
        }

        public abstract void Operation();
    }
}
