using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 享元模式
{
    class User
    {
        private string _name;

        public string Name { get => _name; set => _name = value; }
    }
}
