using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    class StockObserver
    {
        private string _name;

        public string Name { get => _name; set => _name = value; }
        internal Boss Boss { get => _boss; set => _boss = value; }

        private Boss _boss;

        public StockObserver(string name,Boss boss)
        {
            this._name = name;
            this._boss = boss;
        }

        public void Updata()
        {
            Console.WriteLine("我是"+Name+",正在炒股,"+Boss.Name+"来了 我继续工作！");
        }
    }
}
