using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    /// <summary>
    /// ConcretePattern类，将一个接收者对象绑定于一个动作，调用接收者相应的操作，以实现Execute。
    /// </summary>
    internal class BakeMuttonCommand : Command
    {
        public BakeMuttonCommand(Barbecuer receiver):base(receiver) {

        }
        public override void ExecuteCommand() {
            receiver.BakeMutton();
        }
    }

    internal class BakeChickenWingCommand : Command
    {
        public BakeChickenWingCommand(Barbecuer receiver) : base(receiver) {

        }
        public override void ExecuteCommand() {
            receiver.BakeChickenWing();
        }
    }
}
