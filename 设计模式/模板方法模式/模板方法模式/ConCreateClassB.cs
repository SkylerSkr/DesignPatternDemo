/**
 * 模板方法模型
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模板方法模式
{
    class ConCreateClassB : AbstractClass
    {
        public override void PrimitiveOperationA()
        {
            Console.WriteLine("具体类B的行为A");
        }

        public override void PrimitiveOperationB()
        {
            Console.WriteLine("具体类B的行为B");
        }
    }
}
