using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
/*装饰模式：动态的给一个对象添加一些额外的职责，就增加功能来说，装饰模式比生成子类更为灵活。  
* 装饰模式是利用SetComponent来对对象进行包装的，这样每个装饰对象的实现就和如何使用这个对象分离开了。
* 每个装饰对象只关心自己的功能，不需要关心如何被添加到对象链当中。
* 
* 如果只有一个ConcreteComponent类而没有抽象的Component类，那么Decorator类可以是ConcreteComponent类的一个子类。
* 同样道理，如果只有一个ConcreteDecorator类，那就没必要建立一个单独的Decorator类,
* 而可以把Decorator和ConcreteDecorator的责任合并成一个类。
* 
* 装饰模式是为已有功能添加动态地添加更多功能的一种方式。
* 当系统需要新功能时候，是向旧的类中添加新的代码。这些新加的代码通常装饰了原有类的核心职责或主要行为，
* 但这种做法的问题在于，他们在主类（例中的人）加入了新的字段，新的方法和逻辑，从而增加了主类的复杂度，
* 而这些新加的东西仅仅是为了满足一些只在某种特定情况下才会执行的特殊行为的需要。
* 而装饰模式却提供了一个非常好的解决方案，它把每个要装饰的功能放在单独的类中，并让这个类包装它所要装饰的对象，
* 因此，当需要执行特殊行为时，客户代码就可以在运行时根据需要有选择地、按顺序地使用装饰功能包装对象了。
* 装饰模式的优点：把类中的装饰功能从类中搬移去除，这样可以简化原有的类。有效地把类的核心职责和装饰功能区分开了。
* 而且可以去除相关类中重复的装饰逻辑。
* 
*/
namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args) {
            
            Person xc = new Person("小菜");
            Console.WriteLine("\n第一种打扮：");
            TShirts dtx = new TShirts();
            BigTrouser kk=new BigTrouser();
            Sneakers pqx = new Sneakers();

            pqx.Decorate(xc);
            kk.Decorate(pqx);
            dtx.Decorate(kk);
            dtx.Show();

            Console.WriteLine("\n第二种打扮：");
            Suit xz = new Suit();
            Tie ld = new Tie();
            LeatherShoes px = new LeatherShoes();

            px.Decorate(xc);
            ld.Decorate(px);
            xz.Decorate(ld);
            xz.Show();

            Console.Read();

        }
    }

   
}
