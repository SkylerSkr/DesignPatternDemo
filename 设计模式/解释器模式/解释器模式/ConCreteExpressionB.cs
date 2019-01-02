using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 解释器模式
{
    class ConCreteExpressionB : Expression
    {
        public override void Excute(string key, string value)
        {
            string str = "";
            switch (key)
            {
                case "A":
                    str += "大写A";
                    break;
                case "B":
                    str += "大写B";
                    break;
                case "C":
                    str += "大写C";
                    break;
            }
            Console.Write(str + value);
        }
    }
}
