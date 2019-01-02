using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 状态模式
{
    class RestState : State
    {
        public override void WriteCode(Work w)
        {
            Console.WriteLine("当前时间{0}点，下班了舒服", w.Hour);

        }
    }
}
