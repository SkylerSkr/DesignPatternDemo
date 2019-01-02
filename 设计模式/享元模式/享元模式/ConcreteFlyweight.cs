using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 享元模式
{
    class ConcreteFlyweight : Flyweight
    {
        public ConcreteFlyweight(string name) : base(name)
        {
        }

        public override void Operation(User user)
        {
            Console.WriteLine("分类"+Name+"，用户"+user.Name);
        }
    }
}
