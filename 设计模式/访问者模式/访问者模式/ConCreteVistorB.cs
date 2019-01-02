using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 访问者模式
{
    class ConCreteVistorB:Vistor
    {
        public override void VistorConcreteElementA(Element e)
        {
            Console.WriteLine(this.GetType().Name + "访问了" +
                e.Name);
        }

        public override void VistorConcreteElementB(Element e)
        {
            Console.WriteLine(this.GetType().Name + "访问了" +
                e.Name);
        }
    }
}
