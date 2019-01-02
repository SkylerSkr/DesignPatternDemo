using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式
{
    class Person
    {
        private string _name;

        public Person() { }

        public Person(string name)
        {
            this.Name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine("装扮的"+Name);
        }

        public string Name { get => _name; set => _name = value; }
    }
}
