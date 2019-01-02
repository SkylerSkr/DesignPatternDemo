using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂模式
{
    class Operation
    {
        private double _number1;
        private double _number2;
        public Operation() { }
        public Operation(double n1, double n2)
        {
            this._number1 = n1;
            this._number2 = n2;
        }

        public virtual double GetResult()
        {
            return 0d;
        }

        public double Number1 { get => _number1; set => _number1 = value; }
        public double Number2 { get => _number2; set => _number2 = value; }
    }
}
