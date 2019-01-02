using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 享元模式
{
     abstract class Flyweight
    {
        private string _name;

        public abstract void Operation(User user);

        public Flyweight(string name)
        {
            this.Name = name;
        }

        public string Name { get => _name; set => _name = value; }
    }
}
