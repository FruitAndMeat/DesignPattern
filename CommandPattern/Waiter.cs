using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    /// <summary>
    /// 服务员类。即是Invoker类，要求该命令执行这个请求。
    /// </summary>
    internal class Waiter
    {
        private IList<Command> orders=new List<Command>();

        //设置订单
        public void SetOrder(Command command) {
            if (command.ToString()=="CommandPattern.BakeChickenWingCommand") {
                Console.WriteLine("服务员：鸡翅没有了，请点别的烧烤。");
            }
            else {
                orders.Add(command);
                Console.WriteLine("增加订单："+command.ToString()+"时间："+DateTime.Now.ToString());
            }
        }
        //取消订单
        public void CancelOrder(Command command) {
            orders.Remove(command);
            Console.WriteLine("取消订单："+command.ToString()+"时间："+DateTime.Now.ToString());
        }
        //通知全部执行
        public void Notify() {
            foreach (Command command in orders) {
                command.ExecuteCommand();
            }
        }
    }
}
