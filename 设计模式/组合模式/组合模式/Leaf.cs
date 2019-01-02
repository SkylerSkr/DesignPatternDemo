using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 组合模式
{
    class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {
        }

        public override void Add(Component c)
        {
            
        }

        public override void DisPlay(int depth)
        {
            Console.WriteLine(new string('-',depth)+"我是子节点"+Name);
        }

        public override void Remove(Component c)
        {
            
        }
    }
}
