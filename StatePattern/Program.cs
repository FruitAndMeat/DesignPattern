using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 状态模式：当一个对象的内在状态改变时允许改变其行为，这个对象看起来像是改变了其类。
 * 状态模式主要解决的是当控制一个对象状态转换的条件表达式过于复杂的情况。
 * 把状态的判断逻辑转移到不同状态的一系列类当中，可以把复杂的判断逻辑简化。
 * 
 * 好处：将与特定状态相关的行为局部化，并且将不同状态的行为分割开来。就是将特定的状态相关的行为都放入一个对象中，
 * 由于所有与状态相关的代码都存在于某个ConcreteState中，所以通过定义新的子类可以很容易地增加新的状态和转换。
 * 这样做的目的是“消除庞大的条件分支语句”。状态模式通过把各种状态转移逻辑分布到State的子类之间，来减少相互间的依赖。
 * 
 * 使用场景：当一个对象的行为取决于它的状态，并且它必须在运行时刻根据状态改变它的行为时，就可以考虑使用状态模式。
 */
namespace DesignPattern
{
    internal class Program
    {
        
        static void Main(string[] args) {
            Work emergencyProjects=new Work();
            emergencyProjects.Hour = 9;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 10;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 12;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 13;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 14;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 17;
            emergencyProjects.TaskFinished = true;

            emergencyProjects.WriteProgram();

            emergencyProjects.Hour = 19;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 22;
            emergencyProjects.WriteProgram();


            Console.ReadLine();
        }
    }
    //抽象状态
    public abstract  class State {
        public abstract void WirteProgram(Work w);
    }
    //上午工作状态
    public class ForenoonState : State
    {
        public override void WirteProgram(Work w) {
            if (w.Hour<12) {
                Console.WriteLine("当前时间：{0}点 上午工作，精神百倍",w.Hour);
            }
            else {
                w.SetState(new NoonState());w.WriteProgram();
            }
        }
    }
    //中午工作状态
    public class NoonState : State
    {
        public override void WirteProgram(Work w) {
            if (w.Hour < 13) {
                Console.WriteLine("当前时间：{0}点 饿了，午饭；犯困，午休", w.Hour);
            }
            else {
                w.SetState(new AfternoonState()); w.WriteProgram();
            }
        }
    }
    //下午工作状态
    public class AfternoonState : State
    {
        public override void WirteProgram(Work w) {
            if (w.Hour < 17) {
                Console.WriteLine("当前时间：{0}点 下午状态不错，继续努力", w.Hour);
            }
            else {
                w.SetState(new EveningState()); w.WriteProgram();
            }
        }
    }

    public class EveningState : State
    {
        public override void WirteProgram(Work w) {
            if (w.TaskFinished) {
                w.SetState(new RestState());
                w.WriteProgram();
            }
            else {
                if (w.Hour<21) {
                    Console.WriteLine("当前时间：{0}点 加班哦，疲惫至极", w.Hour);
                }
                else {
                    w.SetState(new SleepingState());
                    w.WriteProgram();
                }
            }
        }
    }

    public class RestState : State
    {
        public override void WirteProgram(Work w) {
            Console.WriteLine("当前时间：{0}点 下班回家了", w.Hour);
        }
    }

    public class SleepingState : State
    {
        public override void WirteProgram(Work w) {
            Console.WriteLine("当前时间：{0}点不行了，睡着了", w.Hour);
        }
    }

    

    public class Work
    {
        private State current;
        public Work() {
            //初始化为早上状态
            current=new ForenoonState();
        }

        private double hour;
        public double Hour {
            get { return hour; }
            set { hour = value; }
        }

        private bool finish;
        /// <summary>任务完成属性</summary>
        public bool TaskFinished {
            get { return finish; }
            set { finish = value; }
        }

        public void SetState(State s) {
            current = s;
        }

        public void WriteProgram() {
            current.WirteProgram(this);
        }
    }
}
