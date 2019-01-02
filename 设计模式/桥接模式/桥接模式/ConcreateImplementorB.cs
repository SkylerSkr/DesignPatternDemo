using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 桥接模式
{
    class ConcreateImplementorB : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("具体实现B的方法");
        }
    }
}
