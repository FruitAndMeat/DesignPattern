using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{

    /// <summary>
    /// 这种在自己被加载时就将自己实例化，被称为饿汉式单例类。这种方式会提前占用系统资源。
    /// 标记为sealed 阻止发生派生，派生会增加实例
    /// </summary>
    internal sealed class SingleTon4
    {
        //在第一次引用类的任何成员时创建实例。公共语言运行库（CLR）负责处理变量初始化。
        private static readonly SingleTon4 uniqueInstance = new SingleTon4();
        private SingleTon4() {

        }

        public static SingleTon4 GetInstance() {
            return uniqueInstance;
        }
    }
}
