using System;
/*观察者模式又叫做发布-订阅（Publish-Subscribe)模式:定义了一种一对多的依赖关系，
 * 让多个观察者对象（看股票、NBA的同事）同时监听某一个主题对象（前台、老板）。
 * 这个主题对象（前台、老板）在状态发生变化时，会通知所有观察者对象（看股票、NBA的同事），使他们能够自动更新自己。
 * 使用场景：当一个对象的改变需要同时改变其他对象的时候，而且它不知道具体有多少对象有待改变时，应该考虑使用观察者模式。
 * 观察者模式所做的工作其实是在接触耦合，让耦合的双方都依赖于抽象，而不是依赖于具体。
 * 从而使得各自的变化不会影响另一边的变化。
 * 
 * 可以使用委托实现通知，来调用观察者对象自己的更新接口。可以不在主题对象的通知方法里遍历观察者的更新方法。
 * 
 * 将一个系统分割成一系列的相互协作的类有一个很不好的副作用，那就是需要维护相关对象间的一致性。
 * 我们不希望为了维持一致性而使各类紧密耦合，这样会维护、扩展和重用都带来不便。
 */
namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args) {
            ConcreteSubject subject = new ConcreteSubject();
            subject.Attach(new ConcreteObserver(subject, "X"));
            subject.Attach(new ConcreteObserver(subject, "Y"));
            subject.Attach(new ConcreteObserver(subject, "Z"));

            subject.SubjectState = "ABC";
            subject.Notify();

            Console.Read();
        }
    }
}
