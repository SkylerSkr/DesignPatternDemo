using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 代理模式
{
    class SchoolGirl
    {
        private string _name;

        public string Name { get => _name; set => _name = value; }

        public SchoolGirl(string name)
        {
            this.Name = name;
        }
    }
}
