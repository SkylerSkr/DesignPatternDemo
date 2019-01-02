using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 解释器模式
{
    class ConCreteExpressionA : Expression
    {
        public override void Excute(string key, string value)
        {
            string str="";
            switch (key)
            {
                case "a":
                    str += "小写a";
                    break;
                case "b":
                    str += "小写b";
                    break;
                case "c":
                    str += "小写c";
                    break;
            }
            Console.Write(str+value);
        }
    }
}
