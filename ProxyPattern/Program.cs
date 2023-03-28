using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*代理模式：为其他对象提供一种代理以控制对这个对象的访问。
 * 应用场景：
 * 1、远程代理：为一个对象在不同的地址空间提供局部代表。这样可以隐藏一个对象存在于不同地址空间的事实。例如：
 * 引用WebService会生成一个WebReference的文件夹和一些文件，
 * 其实它们就是代理，使得客户端程序调用代理就可以解决远程访问的问题。
 * 
 * 2、虚拟代理：是根据需要创建开销很大的对象。通过它来存放实例化需要很长时间的真实对象。可以达到性能的最优化
 * 比如，打开一个很大的网页时，很多的未打开的图片就是通过虚拟代理替代了真实的图片，此时代理存储了真实图片的路径和尺寸。
 * 
 * 3、安全代理：用来控制真实对象访问的权限。一般用于对象应该有不同的访问权限的时候。
 * 4、智能指引：指当调用真实的对象时，代理处理另外一些事情。如计算真实对象的引用次数，当该对象没有引用时，可以自动释放他。
 *  或当第一次引用一个持久对象时，将它装入内存；或在访问一个实际对象前，检查是否已经锁定他，以确保其他对象不能改变他。
 */
namespace ProxyPattern
{
    internal class Program
    {
        static void Main(string[] args) {
            SchoolGirl jiaojiao = new SchoolGirl();
            jiaojiao.Name = "李娇娇";

            Proxy daili=new Proxy(jiaojiao);
            daili.GiveDolls();
            daili.GiveFlowers();
            daili.GiveCholoclate();

            Console.Read();
        }
    }
}
