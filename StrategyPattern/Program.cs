using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 策略模式：它定义了算法家族，分别封装起来，让它们之间可以相互替换。此模式让算法的变化，不会影响到使用算法的客户。
 * 从概念上看，所有这些算法完成的都是相同的工作，只是实现不同，它可以以相同的方式调用所有的算法，
 * 减少了各种算法类与使用算法类之间的耦合。
 * 优点：1、策略模式的Strategy类层次为Context定义了一系列的可供重用的算法或行为。继承有助于析取出这些算法中的公共功能。
 * 2、简化了单元测试，因为每个算法都有自己的类，可以通过自己的接口单独测试。
 * 
 * 当不同的行为堆砌在一个类中时，就很难避免使用条件语句来选择合适的行为。将这些行为封装在一个个独立的Strategy类中，
 * 可以在使用这些行为的类中消除条件语句。
 * 
 * 策略模式就是用来封装算法的，但在实践中，我们可以发现它用来封装几乎任何类型的规则，
 * 只要在分析过程中听到需要在不同时间应用不同的业务规则，就可以考虑使用策略模式处理这种变化的可能性。
 * 
 * 但在基本的策略模式中，选择所用具体实现的职责由客户对象承担，并转给策略模式的Context对象。
 */
namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args) {
            CashContext cc = null;
            Console.WriteLine("请输入打折类型：1、正常收费，2、满300返100，3、打8折");
            //这里可以和简单工厂模式综合起来，直接在CashContext构造函数传入字符串，
            //实例化CashContext类内部的打折类型即CashSuper类。再调用GetResult直接返回价格。

            switch (Console.ReadLine()) {
                case "正常收费":cc = new CashContext(new CashNormal());break;
                case "满300返100":cc=new CashContext(new CashReturn("300","100"));break;
                case "打8折":cc = new CashContext(new CashRebate("0.8"));break;
            }
            Console.WriteLine("请输入总价：");
            string price = Console.ReadLine();
            double totalPrices = cc.GetResult(Convert.ToDouble(price));
            Console.WriteLine($"你一共需要支付{totalPrices}元");
            Console.Read();
        }
    }
}
