using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 访问者模式
{
    class ConcreteElementA : Element
    {
        public ConcreteElementA(string name) : base(name)
        {
        }

        public override void Accept(Vistor vistor)
        {
            vistor.VistorConcreteElementA(this);
        }
    }
}
