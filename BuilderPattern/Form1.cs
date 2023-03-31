using System;
using System.Drawing;
using System.Windows.Forms;
/*建造者模式：将一个复杂的对象的构建与它的表示分离，使得同样的构建过程可以创建不同的表示。又叫生成器模式。
* 使用了建造者模式，那么用户就只需要指定需要建造的类型就可以得到它们，而具体建造的过程和细节就不必知道了。
* 
*建造者模式的好处就是使得建造代码与表示代码分离，由于建造者隐藏了该产品是如何组装的。
*所以若需要改变一个产品的内部表示，只需要再定义一个具体的建造者就行了。
*/
namespace BuilderPattern
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
            this.Load += Form1_Load;

        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            Pen p = new Pen(Color.Yellow);
            PersonBuilder ptb = new PersonThinBuilder(pictureBox1.CreateGraphics(), p);
            PersonDirector pdThin = new PersonDirector(ptb);
            pdThin.CreatePerson();

            PersonBuilder pfb = new PersonFatBuilder(pictureBox2.CreateGraphics(), p);
            PersonDirector pdFat = new PersonDirector(pfb);
            pdFat.CreatePerson();
        }
    }
}
