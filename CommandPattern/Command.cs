using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    /// <summary>
    /// Command类，用来声明执行操作的接口。
    /// </summary>
  internal abstract class Command
  {
        protected Barbecuer receiver;
        public Command(Barbecuer receiver) {
            this.receiver = receiver;
        }
        /// <summary>
        /// 执行命令
        /// </summary>
         public abstract void ExecuteCommand();
    }
}
