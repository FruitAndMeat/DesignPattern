using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /// <summary>
    /// 单例模式，这个案例可以在单线程下完美的运行，但是多线程情况下会同时运行GetInstance方法获得多个实例。
    /// </summary>
    internal class SingleTon1
    {
        //定义一个静态变量来保存实例
        private static SingleTon1 uniqueInstance=null;

        //定义一个 私有的 构造函数，使外界不能创建该类的实例
        private SingleTon1() {

        }

        /// <summary>
        /// 定义一个公开方法提供一个全局的访问点，同时也可以定义一个属性来提供全局访问点。
        /// </summary>
        /// <returns></returns>
        public static SingleTon1 GetInstance() {
            //如果类的实例不存在则创建，否则直接返回。
            if (uniqueInstance==null) {
                uniqueInstance = new SingleTon1();
            }
            return uniqueInstance;
        }
    }
}
