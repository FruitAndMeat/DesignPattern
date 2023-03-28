using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    internal class Resume : ICloneable
    {
        private string name;
        private string sex;
        private string age;
        private WorkExperience work;

        public Resume(string name) {
            this.name = name;
            this.work=new WorkExperience();
        }
        /// <summary>
        /// 提供Clone方法调用的私有构造函数，以便克隆“工作经历”的数据。
        /// </summary>
        /// <param name="work"></param>
        private Resume(WorkExperience work) {
            this.work=(WorkExperience)work.Clone();
        }

        //设置个人信息
        public void SetPersonalInfo(string sex, string age) {
            this.age = age;
            this.sex = sex;
        }

        //设置工作经历
        public void SetWorkExperience(string workDate,string company) {
            this.work.WorkDate = workDate;
            this.work.Company = company;
        }

        //显示
        public void Display() {
            Console.WriteLine($"{name} {sex} {age}");
            Console.WriteLine($"工作经历：{work.WorkDate}  {work.Company}");
        }

        public object Clone() {
            //调用私有的构造方法，让“工作经历”克隆完成，然后再给这个“简历”对象的相关字段赋值，
            //最终返回一个深复制的简历对象。
            Resume obj = new Resume(this.work);
            obj.name = this.name;
            obj.sex = this.sex;
            obj.age = this.age;
            return obj;
        }
    }
}
