using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 职责链模式：使多个对象都有机会处理请求，从而避免请求的发送者和接收者之间的耦合关系。
 * 将这个对象连成一条链，并沿着这条链传递该请求，知道有一个对象处理它为止。
 * 
 * 职责链的好处：当客户提交一个请求时，请求是沿链传递直至有一个ConcreteHandler对象负责处理它。
 * 这表明请求者不用管哪个对象来处理，反正该请求会被处理就对了。这使得接收者和发送者都没有对方的明确信息，且链中的对象
 * 并不知道链的结构。结果是职责链可简化对象的相互连接，它们仅需保持一个指向其后继者的引用，而不需要保持它所有的候选接收者的引用。
 * 可以随时地增加或修改处理一个请求的结构。增强了给对象指派职责的灵活性。
 * 但是一个请求极有可能到了链的末端都得不到处理，或者因为没有正确配置而得不到处理。
 */
namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args) {
            CommonManager jinli = new CommonManager("金利");
            Majordomo zongjian = new Majordomo("宗剑");
            GeneralManager zhongjingli = new GeneralManager("钟精励");
            //设置上级，可以根据实际需求来更改设置。
            jinli.SetSuperior(zongjian);
            zongjian.SetSuperior(zhongjingli);

            Request request = new Request();
            request.RequestType = "请假";
            request.RequestContent = "小菜请假";
            request.Number = 1;
            jinli.RequestApplications(request);

            Request request2 = new Request();
            request2.RequestType = "请假";
            request2.RequestContent = "小菜请假";
            request2.Number = 4;
            jinli.RequestApplications(request2);

            Request request3 = new Request();
            request3.RequestType = "加薪";
            request3.RequestContent = "小菜请求加薪";
            request3.Number = 500;
            jinli.RequestApplications(request3);

            Request request4 = new Request();
            request4.RequestType = "加薪";
            request4.RequestContent = "小菜请求加薪";
            request4.Number = 1000;
            jinli.RequestApplications(request4);

            Console.Read();
        }
    }
}
