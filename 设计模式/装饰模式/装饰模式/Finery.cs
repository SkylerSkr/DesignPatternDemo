using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式
{
    class Finery:Person
    {
        private Person _component;


        public void Decorate(Person component)
        {
            this.Component = component;
        }

        public override void Show()
        {

            if (Component != null) Component.Show();
        }

        internal Person Component { get => _component; set => _component = value; }
    }
}
