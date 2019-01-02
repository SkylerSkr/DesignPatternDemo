/**
 * 抽象工厂模式
 * 因跟工厂方法模式太像了 所以不写了 
 * 写一个反射
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace 抽象工厂模式
{
    class Program
    {

        static void Main(string[] args)
        {
            Person p = (Person)Assembly.Load("抽象工厂模式").CreateInstance("抽象工厂模式.Person");
            Console.WriteLine(p.name);
            Console.ReadKey();
        }
    }

    class Person
    {
        public string name="123";
        //private string _name;

        //public string Name { get => _name; set => _name = value; }

        //public Person(string name)
        //{
        //    this._name = name;
        //}
    }
}
