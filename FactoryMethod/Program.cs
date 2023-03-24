using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//工厂方法模式
namespace FactoryMethod
{
    #region 学雷锋的大学生--工厂方法模式

    //internal class Program
    //{
    //    static void Main(string[] args) {
    //        //定义一个用户创建对象的接口，让子类决定实例化哪一个类。工厂方法使一个类的实例化延迟到其子类。
    //        IFactory factory = new UndergraduateFactory();
    //        LeiFeng student = factory.CreateLeiFeng();
    //        student.BuyRise();
    //        student.Sweep();
    //        student.Wash();
    //        Console.ReadLine();
    //    }
    //}
    ////雷锋工厂
    //class LeiFeng
    //{
    //    public void Sweep() {
    //        Console.WriteLine("扫地");
    //    }
    //    public void Wash() {
    //        Console.WriteLine("洗衣");
    //    }
    //    public void BuyRise() {
    //        Console.WriteLine("买米");
    //    }
    //}

    //interface IFactory
    //{
    //    LeiFeng CreateLeiFeng();
    //}
    ////学雷锋的大学生工厂
    //class UndergraduateFactory : IFactory
    //{
    //    public LeiFeng CreateLeiFeng() {
    //        return new Undergraduate();
    //    }
    //}
    ////学雷锋的志愿者工厂
    //class VolunterFactory : IFactory
    //{
    //    public LeiFeng CreateLeiFeng() {
    //        return new Volunter();
    //    }
    //}

    ////学雷锋的大学生
    //class Undergraduate : LeiFeng
    //{

    //}
    ////社区志愿者
    //class Volunter : LeiFeng
    //{

    //}

    //class SimpleFactory
    //{
    //    public static LeiFeng CreateLeiFeng(string type) {
    //        LeiFeng result = null;
    //        switch (type) {
    //            case "学雷锋的大学生":
    //                result = new Undergraduate();
    //                break;
    //            case "社区志愿者":
    //                result = new Volunter();
    //                break;
    //        }
    //        return result;
    //    }
    //} 
    #endregion


    /*工厂方法模式之所以可以解决简单工厂模式的缺点，是因为它的实现把具体产品的创建推迟到子类中，
     * 此时工厂类不再负责所有产品的创建，而只是给出具体工厂必须实现的接口，
     * 这样工厂方法模式就可以允许系统不修改工厂类逻辑的情况下来添加产品，这样也就克服了简单工厂模式的缺点。
     *
     *工厂方法模式中，工厂类和具体产品类具有平行的等级结构，他们之间是一一对应的。
     *
     *工厂方法模式的缺点：每增加一个产品，就需要加一个产品工厂的类，增加了额外的开发量。
     */


    /*  使用抽象类或接口都是有效的实现工厂方法模式的方式，它们的选择往往取决于具体的需求和设计上下文。
     *  
            使用抽象类的优点是可以实现一些默认的行为，同时也可以在抽象类中定义抽象方法，使得子类必须实现这些方法。
        在此例中，如果需要为所有的菜品类提供一些共同的属性和方法，那么将Food抽象类作为父类比较合适。

            使用接口的优点是可以使得类更加灵活，可以实现多重继承，而抽象类只能够实现单继承。
        在此例中，如果想要让一个类同时具有多个“工厂方法”功能，或者需要在一个类中同时实现其它接口的方法，
        那么将Creator和Food定义为接口可能更为合适。
        总之，选择抽象类还是接口取决于具体情况，需要根据实际需求来决定。
     */

    class Client {
        static void Main(string[] args) {
            //初始化做菜的两个工厂，
            //需要哪个对象就实例化哪个对象。
            ICreator tomatoScrambleEggsFactory = new TomatoScrambleEggsFactory();
            ICreator shreddedPorkWithPotatoesFactory=new ShreddedPorkWithPotatoesFactory();

            //这里写了两个示例。
            IFood tomatoScrambleEggs=tomatoScrambleEggsFactory.CreateFoodFactory();
            tomatoScrambleEggs.Print();

            IFood shreddedPorkWithPotatoes =shreddedPorkWithPotatoesFactory.CreateFoodFactory();
            shreddedPorkWithPotatoes.Print();

            //修改为创建肉末茄子
            //创建肉末茄子工厂
            ICreator minceMeatEggplantsFactory = new MinceMeatEggplantFactory();
            IFood minceMeatEggplants = minceMeatEggplantsFactory.CreateFoodFactory();
            minceMeatEggplants.Print();

            Console.Read();
        }
    }



    /// <summary>
    /// 菜(具体对象）的接口
    /// </summary>
    public interface IFood {
        /// <summary>
        /// 输出点了什么菜
        /// </summary>
        void Print();
    }
    /// <summary>
    /// 番茄炒蛋
    /// </summary>
    public class TomatoScrambleEggs : IFood {
        public void Print() {
            Console.WriteLine("番茄炒蛋做好了");
        }
    }
    /// <summary>
    /// 土豆肉丝
    /// </summary>
    public class ShreddedPorkWithPotatoes : IFood {
        public  void Print() {
            Console.WriteLine("土豆肉丝做好了");
        }
    }

    /// <summary>
    /// 抽象工厂类
    /// </summary>
    public interface  ICreator {
         IFood CreateFoodFactory();
    }
    /// <summary>
    /// 番茄炒蛋工厂类
    /// </summary>
    public class TomatoScrambleEggsFactory : ICreator
    {
        public IFood CreateFoodFactory() {
            return new TomatoScrambleEggs();
        }
    }
    /// <summary>
    /// 土豆肉丝工厂类
    /// </summary>
    public class ShreddedPorkWithPotatoesFactory : ICreator
    {
        public IFood CreateFoodFactory() {
            return new ShreddedPorkWithPotatoes();
        }
    }

    #region 扩展一个肉末茄子

    /*我们需要扩展时只需要定义一个对象类 以及一个创造对象的工厂类就可以，不用像简单工厂模式那样去修改工厂类的实现。
     *
     */
    /// <summary>
    /// 一个肉末茄子的类。
    /// </summary>
    public class MinceMeatEggplant : IFood
    {
        public void Print() {
            Console.WriteLine("肉末茄子做好了");
        }
    }
    /// <summary>
    /// 肉末茄子类的工厂类，负责创建肉末茄子类
    /// </summary>
    public class MinceMeatEggplantFactory : ICreator
    {
        public IFood CreateFoodFactory() {
            return new MinceMeatEggplant();
        }
    }
    #endregion
}
