/**
 * 装饰模式
 * 当需要添加功能的时候使用 就像穿衣服一样 给已经完成的类添加功能
 * 复合开放闭合原则
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("小明");
            TShirt tShirt = new TShirt();
            BigTrouser bigTrouser = new BigTrouser();
            Tie tie = new Tie();
            LeatherShoes leatherShoes = new LeatherShoes();

            tShirt.Decorate(p);
            tie.Decorate(tShirt);
            bigTrouser.Decorate(tie);
            leatherShoes.Decorate(bigTrouser);

            leatherShoes.Show();
            Console.ReadKey();
        }
    }
}
