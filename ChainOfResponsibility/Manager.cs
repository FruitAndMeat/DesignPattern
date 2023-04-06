using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    /// <summary>
    /// 管理者。即Handler
    /// </summary>
    internal abstract class Manager
    {
        protected string name;
        //管理者的上级
        protected Manager superior;

        public Manager(string name) {
            this.name = name;
        }

        //设置管理者的上级
        public void SetSuperior(Manager superior) {
            this.superior = superior;
        }
        //申请请求
        abstract public void RequestApplications(Request request);
    }
}
