using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 备忘录模式：在不破坏封装性的前提下，捕获一个对象的内部状态，并在该对象之外保存这个状态。
 * 这样就可将该对象恢复到原先保存的状态。
 * 把要保存的细节给封装在了Memento中了，哪一天要更改保存的细节也不用影响客户端了。
 * 
 * 应用场景：Memento模式比较适用于功能比较复杂的，但需要维护或记录属性历史的类，或者需要保存的属性只是
 *  众多属性中的一小部分时，Originator可以根据保存的Memento信息还原到前一状态。
 * 如果在某个系统中使用命令模式时，需要实现命令的撤销功能，那么命令模式就可以使用备忘录模式来存储可撤销操作的状态。
 *  有时，一些对象的内部信息必须保存在对象以外的地方，但是必须由对象自己读取，这时使用备忘录模式可以把复杂的对象
 * 内部信息对其他的对象屏蔽起来，从而可以恰当地保持封装的边界。
 *  还有，当角色的状态改变时，有可能这个状态无效，这时候就可以使用暂时存储起来的备忘录将状态复原。
 */
namespace MementoPattern
{
    internal class Program {
        static void Main(string[] args) {
            //大战Boss前
            GameRole lixiaoyao = new GameRole();
            lixiaoyao.GetInitState();
            lixiaoyao.StateDisplay();

            //保存进度时，由于封装在Memento中，因此我们不知道保存了哪些具体的角色数据。
            RoleStateCaretaker stateAdmin = new RoleStateCaretaker();
            stateAdmin.Memento = lixiaoyao.SaveState();

            //大战boss时，损耗严重
            lixiaoyao.Fight();
            lixiaoyao.StateDisplay();

            //恢复之前的状态
            lixiaoyao.RecoveryState(stateAdmin.Memento);
            lixiaoyao.StateDisplay();

            Console.Read();
        }
        
    }
}
