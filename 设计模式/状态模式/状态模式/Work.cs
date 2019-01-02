using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 状态模式
{
    class Work
    {
        private int _hour;

        private State _state;

        private bool _taskFinished = false;

        public void WriteCode()
        {
            State.WriteCode(this);
        }

        public void SetState()
        {
            this.State = new ForenoonState();
        }

        public int Hour { get => _hour; set => _hour = value; }
        public bool TaskFinished { get => _taskFinished; set => _taskFinished = value; }
        internal State State { get => _state; set => _state = value; }
    }
}
