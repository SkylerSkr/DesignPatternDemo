using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 组合模式
{
    class Composite : Component
    {
        private List<Component> list = new List<Component>();

        public Composite(string name) : base(name)
        {
        }

        public override void Add(Component c)
        {
            list.Add(c);
        }

        public override void DisPlay(int depth)
        {
            Console.WriteLine(new string('-',depth)+ "这是根节点"+Name);

            foreach (Component c in list)
            {
                c.DisPlay(depth+2);
            }
        }

        public override void Remove(Component c)
        {
            list.Remove(c);
        }
    }
}
