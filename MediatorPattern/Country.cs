namespace MediatorPattern
{
    /// <summary>
    /// 国家类，相当于Colleague类
    /// </summary>
    internal abstract class Country
    {
        protected UnitedNations mediator;
        public Country(UnitedNations mediator) {
            this.mediator = mediator;
        }
    }
    /// <summary>
    /// 美国
    /// </summary>
    internal class USA : Country
    {
        public USA(UnitedNations mediator) : base(mediator) {
        }
        //声明
        public void Declare(string message) {
            mediator.Declare(message, this);
        }
        //获得消息
        public void GetMessage(string message) {
            System.Console.WriteLine("美国获得对方消息："+message);
        }
    }
    /// <summary>
    /// 伊拉克
    /// </summary>
    internal class Iraq : Country
    {
        public Iraq(UnitedNations mediator) : base(mediator) {
        }
        //声明
        public void Declare(string message) {
            mediator.Declare(message, this);
        }
        //获得消息
        public void GetMessage(string message) {
            System.Console.WriteLine("伊拉克获得对方消息：" + message);
        }
    }
}