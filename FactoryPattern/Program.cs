using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//简单工厂模式
namespace FactoryPattern
{
    /*  简单工厂模式又叫静态方法模式，由一个工厂类根据传入的参数决定创建出哪一种产品类的实例。
     *  
    /// 有简单工厂（餐馆）的时候，消费者降低了对菜（具体对象）的依赖程度，依赖关系从直接变为间接的。
    /// 这样就实现了面向对象的另一个原则----降低对象之间的耦合。
    /// 简单工厂的缺点：比如想新加具体对象（菜）时，只是把变化移动到了工厂类当中，修改的时候还是需要修改工厂类中的方法
    /// （也就是多加case语句，没用简单工厂之前，修改的是客户类）----这个缺点可以在工厂方法模式中很好的解决。
    ///     
    /// 简单工厂的优点：
    /// 1、简单工厂模式解决了客户端直接依赖于具体对象的问题，客户端可以消除直接创建对象的责任，而仅仅消费产品。实现了责任的分割
    /// 2、简单工厂也有代码复用的作用，如果另一个客户端也需要使用这个工厂创建对象可以直接使用。
    ///     但这也是简单工厂模式的缺点---因为工厂类中集中了所有的产品的创建逻辑，一旦不能正常工作，整个系统都会被影响。
    ///     
    /// 简单工厂的应用场景：
    /// 1、当工厂类负责创建的对象比较少的时候可以考虑使用简单工厂模式
    /// 2、客户端只知道传入的工厂类的参数，对于如何创建对象的逻辑不关心时可以考虑使用简单工厂模式。


    */

    /// <summary>
    /// 顾客充当客户端，负责调用简单工厂来生产对象
    /// 即客户点菜，厨师（相当于简单工厂）负责烧菜(生产的对象)
    /// </summary>
    class Customer {
        static void Main(string[] args) {
            IFood food1 = FoodSimpleFactory.CreateFood("番茄炒蛋");
            food1.Print();

            IFood food2 = FoodSimpleFactory.CreateFood("土豆肉丝");
            food2.Print();

            Console.Read();
        }
    }

    /// <summary>
    /// 菜的抽象类
    /// </summary>
    public interface IFood {
        /// <summary>
        /// 输出点了什么菜
        /// </summary>
         void Print();
    }
    /// <summary>
    /// 番茄炒蛋这道菜
    /// </summary>
    public class TomatoScrambleEggs : IFood
    {
        public void Print() {
            Console.WriteLine("一份番茄炒蛋");
        }
    }
    /// <summary>
    /// 土豆肉丝这道菜
    /// </summary>
    public class ShreddedPorkWithPotatoes : IFood {
        public void Print() {
            Console.WriteLine("一份炒土豆肉丝");
        }
    }
    /// <summary>
    /// 简单工厂类，负责炒菜
    /// </summary>
    public class FoodSimpleFactory {
        public static  IFood CreateFood(string foodName) {
            IFood food = null;
            switch (foodName) {
                case "土豆肉丝": food=new ShreddedPorkWithPotatoes(); break;
                case "番茄炒蛋": food = new TomatoScrambleEggs(); break;
                default: break;
            }
            return food;
        }
        
    }
}
