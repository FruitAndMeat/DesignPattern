using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    /// <summary>
    /// 具体观察者，实现抽象观察者角色所要求的更新接口，以便使本身的状态与主题的状态相协调。
    /// 具体观察者角色可以保存一个指向具体主题对象的引用。具体观察者角色通常用一个具体子类实现。
    /// </summary>
    internal class ConcreteObserver : Observer
    {
        private string name;
        private string observerState;
        private ConcreteSubject subject;

        public ConcreteObserver(ConcreteSubject subject,string name) {
            this.Subject = subject;
            this.name = name;
        }

        internal ConcreteSubject Subject { get => subject; set => subject = value; }

        public override void Update() {
            observerState=Subject.SubjectState;
            Console.WriteLine("观察者{0}的新状态是{1}",name,observerState);
        }
    }
}
