using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*命令模式：将一个请求封装为一个对象，从而使你可用不同的请求对客户进行参数化；
 * 对请求排队或记录请求日志，以及支持可撤销的操作。
 * 命令模式的优点：1、他能较容易地设计一个命令队列；2、在需要的情况下，可以较容易地将命令记入日志。
 * 3、允许接收请求的一方决定是否要否决要求。4、可以容易地实现对请求的撤销和重做。
 * 5、由于加进新的具体命令类不影响其他的类，因此增加新的具体命令类很容易。
 * 6、命令模式把请求一个操作的对象与知道怎么执行一个操作的对分割开。
 */
namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args) {
            //开店前的准备
            Barbecuer boy=new Barbecuer();
            Command bakeMuttonCommand1 = new BakeMuttonCommand(boy);
            Command bakeMuttonCommand2 = new BakeMuttonCommand(boy);
            Command bakeChickenWingCommand1 = new BakeChickenWingCommand(boy);

            Waiter girl=new Waiter();

            //开门营业 顾客点菜
            girl.SetOrder(bakeMuttonCommand1);
            girl.SetOrder(bakeMuttonCommand2);
            girl.SetOrder(bakeChickenWingCommand1);

            //点菜完毕，通知厨房
            girl.Notify();
            Console.Read();

        }
    }
}
