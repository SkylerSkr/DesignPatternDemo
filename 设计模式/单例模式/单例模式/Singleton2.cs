using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例模式
{

    //静态初始化
     sealed class Singleton2
    {
        private static readonly Singleton2 singleton2 = new Singleton2();

        private string _name="李四";

        private Singleton2() { }

        public static Singleton2 GetInStance()
        {
            return singleton2;
        }

        public string Name { get => _name; set => _name = value; }
    }
}
