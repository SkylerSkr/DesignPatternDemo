using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 备忘录模式
{
    class Memento
    {
        private State _state;

        public Memento(State state)
        {
            this._state = state;
        }

        internal State State { get => _state; }
    }
}
