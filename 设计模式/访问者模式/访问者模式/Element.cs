using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 访问者模式
{
    abstract class Element
    {
        private string _name;

        public string Name { get => _name; set => _name = value; }

        public Element(string name)
        {
            this.Name = name;
        }

        public abstract void Accept(Vistor vistor);
    }
}
