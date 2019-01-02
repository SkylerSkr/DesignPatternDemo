using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 享元模式
{
    class FlyweightFactory
    {
        private Dictionary<string,Flyweight> dic = new Dictionary<string, Flyweight>();

        public Flyweight GetFlyweight(string key)
        {
            Flyweight f;
            if (!dic.TryGetValue(key,out f))
            {
                f = new ConcreteFlyweight("网站");
                dic.Add(key,new ConcreteFlyweight("网站"));
            }
            return f;

        }

        public int Count()
        {
            return dic.Count;
        }

        public void Play()
        {
            foreach (KeyValuePair<string,Flyweight> f in dic)
            {
                Console.WriteLine("姓名"+f.Key+"   "+f.Value);
            }
        }
    }
}
