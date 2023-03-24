using System;

namespace ObserverPattern
{
    /// <summary>
    /// 抽象观察者，为所有的具体观察者提供一个接口，在得到主题的通知时更新自己，这个接口叫更新接口
    /// 一般使用一个抽象类或者一个接口实现。更新接口通常包含一个Update()方法，叫做更新方法。
    /// </summary>
    internal abstract class Observer
    {
        public abstract void Update();
    }
}