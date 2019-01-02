using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 状态模式
{
    abstract class State
    {
        public abstract void WriteCode(Work w);
    }
}
