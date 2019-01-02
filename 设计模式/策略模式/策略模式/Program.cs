/**
 * 策略模式
 * 封装算法 不让客户端知道使怎么算的
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("请输入商品价值");
                double money = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("请选择折扣类型 1.无优惠 2.满500减100 3.全场8折");
                string operate = "";
                switch (Console.ReadLine())
                {
                    case "1":
                        operate = "无优惠";
                        break;
                    case "2":
                        operate = "满500减100";
                        break;
                    case "3":
                        operate = "全场8折";
                        break;
                }
                CashContext cs = new CashContext(operate);
                Console.WriteLine("优惠后价格为："+cs.GetResult(money));
                Console.ReadKey();
            }
        }
    }
}
