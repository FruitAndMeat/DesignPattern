using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*原型模式：用原型实例指定创建对象的种类，并且通过拷贝这些原型创建新的对象。
 * 原型模式其实就是从一个对象再创建另一个可定制的对象，而且不需要知道任何创建的细节。
 * 在.net的System命名空间中提供了ICloneable接口，其中唯一的一个方法Clone(),实现这个接口就可以完成原型模式了。
 * 所以在.net中，那个原型抽象类Prototype是用不着的。
 * 
 * 一般在初始化信息不发生变化的情况下，克隆是最好的办法。这既隐藏了对象创建的细节，又对性能是大大的提高。
 * 原型模式等于是不用重新初始化对象，而是动态地获得对象运行时的状态。
 * 
 * MmeberwiseClone()方法是这样，如果字段是值类型的，则对字段执行逐位复制，如果字段是引用类型的，
 * 则复制引用但不复制引用的对象；因此，原始对象及其复本引用同一对象。即是浅表复制，被复制对象的所有变量都含有与原来的
 * 对象相同的值，而所有的对其他对象的引用都仍然指向原来的对象。
 * 与之相对应的有 深复制：把引用对象的变量指向复制过的新对象，而不是原有的被引用的对象。
 * 深复制需要事先考虑要深入到多少层，而且要当心出现循环引用的问题，比较复杂。这个例子只深入到第一层就好了
 */
namespace PrototypePattern
{
    internal class Program
    {
        static void Main(string[] args) {
            Resume a = new Resume("大鸟");
            a.SetPersonalInfo("男", "29");
            a.SetWorkExperience("1998-2000", "XX公司");

            Resume b=(Resume)a.Clone();
            b.SetWorkExperience("1998-2006", "YY企业");

            Resume c = (Resume)a.Clone();
            c.SetWorkExperience("1998-2003", "ZZ企业");

            a.Display();
            b.Display();
            c.Display();

            Console.Read();
        }
    }
}
