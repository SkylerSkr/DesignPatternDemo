using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例模式
{
    class Singleton1
    {
        //普通单例模式 需要写锁来防止多线程派生
        private static Singleton1 singleton1;
        private static Object o=new Object();

        private string _name;

        private Singleton1() { }

        public string Name { get => _name; set => _name = value; }

        public static Singleton1 GetInstance()
        {
            if (singleton1 == null)
            {
                lock (o)
                {
                    if (singleton1==null)
                    {
                        singleton1 = new Singleton1();
                    }
                }
            }
            return singleton1;
        }
    }
}
