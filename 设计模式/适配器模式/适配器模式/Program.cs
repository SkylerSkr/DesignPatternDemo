/**
 * 适配器模式
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 适配器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Target t = new Target();
            t.Request();

            t = new Adapter();
            t.Request();

            Console.ReadKey();
        }
    }
}
