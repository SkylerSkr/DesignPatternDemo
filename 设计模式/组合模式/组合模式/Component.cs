using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 组合模式
{
    abstract class Component
    {
        private string _name;

        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void DisPlay(int depth);

        public Component(string name)
        {
            this.Name = name;
        }

        public string Name { get => _name; set => _name = value; }
    }
}
