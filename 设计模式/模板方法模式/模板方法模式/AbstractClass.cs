using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模板方法模式
{
    abstract class AbstractClass
    {
        public abstract void PrimitiveOperationA();

        public abstract void PrimitiveOperationB();

        public void TemplateMethod()
        {
            PrimitiveOperationA();
            PrimitiveOperationB();
        }
    }
}
