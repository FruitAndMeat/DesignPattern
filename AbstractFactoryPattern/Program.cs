using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
//抽象工厂模式: 提供一个创建一系列相关或相互依赖对象的接口，而无需指定它们具体的类。
namespace AbstractFactoryPattern
{
    internal class Program
    {
        static void Main(string[] args) { 
            
            
            //在运行时创建一个具体的工厂类实例，这个具体的工厂再创建具有特定实现的产品对象，
            //也就是说，为创建不同的产品对象，客户端应使用不同的具体工厂。

            //这样的好处是：便于交换产品的系列，由于具体工厂类，即下一行代码。在一个应用中只需要在初始化的时候出现一次，
            //这就使得改变一个应用的具体工厂变得非常容易，它只需要改变具体工厂即可使用不同的产品配置。

            //第二个好处：它让具体的创建实例过程与客户端分离，客户端是通过它们的抽象接口操纵实例，
            //产品的具体类名也被具体工厂的实现分离，不会出现在客户代码中。

            /*抽象工厂的缺点：比如此处，如果需要再增加一个Project表。
             * 则至少需要增加三个类：IProject,AccessProject,SqlServerProject.
             * 同时，需要更改IFactory、AccessFactory、SqlServerFactory三个类。
             * 于是，我们可以使用简单工厂模式简化，即删除三个工厂类，创建一个DataAccess类
             * 同时我们也可以借助 反射特性 和 配置文件实现数据访问程序。见DataAccess类。
             * 
            */
            #region 经过简单工厂简化后时的客户端代码如下

            User user = new User();
            Department department = new Department();

            IUser iu = DataAccess.CreateUser();
            iu.Insert(user);
            iu.GetUser(1);

            IDepartment id = DataAccess.CreateDepartment();
            id.Insert(department);
            id.GetDepartment(1);

            Console.Read();

            #endregion
            //User user = new User();
            //Department department = new Department();
            //IFactory factory = new SqlServerFactory();//如果需要更换数据库 则是new AccessFactory();

            //IUser iu = factory.CreateUser();
            //iu.Insert(user);
            //iu.GetUser(1);

            //IDepartment id=factory.CreateDepartment();
            //id.Insert(department);
            //id.GetDepartment(1);

            //Console.Read();
        }
    }
}
