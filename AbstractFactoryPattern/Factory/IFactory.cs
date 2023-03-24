using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// IFactory是一个抽象工厂接口，它里面应该包含所有的产品创建的抽象方法。
    /// 而SqlserFactory和AccessFactory就是具体（Concrete)的工厂了
    /// </summary>
    internal interface IFactory
    {
        IUser CreateUser();
        IDepartment CreateDepartment();
    }
}
