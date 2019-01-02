using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 职责链模式
{
    abstract class Handler
    {
        protected Handler handler;
        public void SetHandler(Handler handler)
        {
            this.handler = handler;
        }

        public abstract void HandlerRequest(int request);
    }
}
