using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    //可以是抽象类，也可以是接口
    /// <summary>
    /// 主题或抽象通知者，在这里代表前台或老板。
    /// </summary>
    internal abstract class Subject
    {
        private IList<Observer> observers = new List<Observer>();

        //增加观察者
        public void Attach(Observer observer) {
            observers.Add(observer);
        }

        //移除观察者
        public void Detach(Observer observer) {
            observers.Remove(observer);
        }

        //通知
        public void Notify() {
            foreach (Observer observer in observers) {
                observer.Update();
            }
        }
    }
}
