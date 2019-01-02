using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建造者模式
{
    class Director
    {
        public Product Construct(Builder b)
        {
            b.BuildPartA();
            b.BuildPartB();
            return b.GetResult();
        }
    }
}
