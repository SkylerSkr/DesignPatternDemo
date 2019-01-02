using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 访问者模式
{
    abstract class Vistor
    {
        public abstract void VistorConcreteElementA(Element e);
        public abstract void VistorConcreteElementB(Element e);
    }
}
