using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 访问者模式
{
    class ConCreteElementB:Element
    {
        public ConCreteElementB(string name) : base(name)
        {
        }

        public override void Accept(Vistor vistor)
        {
            vistor.VistorConcreteElementB(this);
        }
    }
}
