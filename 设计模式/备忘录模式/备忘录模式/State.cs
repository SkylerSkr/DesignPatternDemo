using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 备忘录模式
{
    class State
    {
        private string _name;
        private int _age;
        private int _heigth;

        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public int Heigth { get => _heigth; set => _heigth = value; }
    }
}
