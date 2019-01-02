using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    delegate void EventHandler();
    class Boss : Subject
    {

        private string _name;

        public string Name { get => _name; set => _name = value; }

        public Boss(string name)
        {
            this._name = name;
        }

        public event EventHandler Update;
        public void Notify()
        {
            if (Update != null) Update();
        }
    }
}
