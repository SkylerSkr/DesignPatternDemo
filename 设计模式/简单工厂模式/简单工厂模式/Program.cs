/**
 * 简单工厂模式
 * 增加复用性 扩展性 便于维护性
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //获取需要运算的数字
                Console.WriteLine("请输入第一个数字");
                double numberA = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("请输入运算符");
                string operate = Console.ReadLine();
                Console.WriteLine("请输入第二个数字");
                double numberB = Convert.ToDouble(Console.ReadLine());

                //判断被除数是否为0
                while (operate == "/" && numberB == 0)
                {
                    Console.WriteLine("被除数不能为0，请重新输入");
                    numberB = Convert.ToDouble(Console.ReadLine());
                }
                //获取对应的工厂
                Operation operation = OperationFactory.CreateOperation(operate);
                operation.Number1 = numberA;
                operation.Number2 = numberB;
                double result = operation.GetResult();
                Console.WriteLine("计算结果是:"+result);
                Console.ReadKey();
            }
        }
    }
}
