using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    /// <summary>
    /// 联合国机构类，相当于Mediator类。
    /// </summary>
    internal abstract class UnitedNations
    {
        //声明
        public abstract void Declare(string message, Country colleague);
    }

    internal class UnitedNationsSecurityCouncil : UnitedNations
    {
        private USA colleague1;
        private Iraq colleague2;

        internal USA Colleague1 {set => colleague1 = value; }
        internal Iraq Colleague2 {set => colleague2 = value; }
        //重写声明方法，实现两个对象间的通信。
        public override void Declare(string message, Country colleague) {
            if (colleague==colleague1) {
                colleague2.GetMessage(message);
            }
            else {
                colleague1.GetMessage(message);
            }
        }
    }
}
