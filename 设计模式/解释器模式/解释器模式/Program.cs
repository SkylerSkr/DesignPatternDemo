/**
 * 解释器模式
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 解释器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "a3b4c6b7A8b9B9C4c3";
            PlayContext pc = new PlayContext(str);
            while(pc.Text.Length!=0)
            {
                Expression e= new ConCreteExpressionA();
                switch (pc.Text.Substring(0, 1))
                {
                    case "A":
                    case "B":
                    case "C":
                        e = new ConCreteExpressionB();
                        break;
                }
                e.InterPret(pc);
            }
            Console.Read();
        }
    }
}
