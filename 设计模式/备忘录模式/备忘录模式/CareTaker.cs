using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 备忘录模式
{
    class CareTaker
    {
        private Memento _memento;

        internal Memento Memento { get => _memento; set => _memento = value; }
    }
}
