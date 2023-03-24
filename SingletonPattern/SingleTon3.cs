namespace SingletonPattern
{
    /// <summary>
    /// 这种要在第一次被引用时，才会将自己实例化，所以也被称为懒汉式单例类。
    /// 懒汉式单例类面临着多线程访问的安全性问题，需要做双重锁定的处理才可以保证安全。
    /// </summary>
    internal class SingleTon3
    {
        //定义一个静态的实例来保存类的实例
        private static SingleTon3 uniqueInstance = null;

        //定义一个标识确保线程同步
        private static readonly object locker = new object();

        //构造函数定义为私有，使外界不能创建该实例
        private SingleTon3() {

        }
        #region 使用属性方式返回实例
        //public static SingleTon3 Instance { 
        //    get {
        //        if (uniqueInstance == null) {
        //            lock (locker) {
        //                // 如果类的实例不存在则创建，否则直接返回
        //                if (uniqueInstance == null) {
        //                    uniqueInstance = new SingleTon3();
        //                }
        //            }
        //        }
        //        return uniqueInstance;
        //    } 
        //}
        #endregion

        /// <summary>
        /// 定义公有方法提供一个全局访问点,同时你也可以定义公有属性来提供全局访问点
        /// </summary>
        /// <returns></returns>
        public static SingleTon3 GetInstance() {
            // 当第一个线程运行到这里时，此时会对locker对象 "加锁"，
            // 当第二个线程运行该方法时，首先检测到locker对象为"加锁"状态，该线程就会挂起等待第一个线程解锁
            // lock语句运行完之后（即线程运行完之后）会对该对象"解锁"
            // 双重锁定只需要一句判断就可以了
            if (uniqueInstance == null) {
                lock (locker) {
                    // 如果类的实例不存在则创建，否则直接返回
                    if (uniqueInstance == null) {
                        uniqueInstance = new SingleTon3();
                    }
                }
            }
            return uniqueInstance;
        }
    }
}
