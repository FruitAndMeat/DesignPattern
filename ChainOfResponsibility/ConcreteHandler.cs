using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class CommonManager : Manager
    {
        public CommonManager(string name):base(name) {

        }

        public override void RequestApplications(Request request) {
            if (request.RequestType=="请假"&&request.Number<=2) {
                Console.WriteLine($"{name}:{request.RequestContent}数量{request.Number}被批准。");
            }
            else {
                if (superior!=null) {
                    superior.RequestApplications(request);
                }
            }
        }

    }
    internal class Majordomo : Manager
    {
        public Majordomo(string name) : base(name) {

        }

        public override void RequestApplications(Request request) {
            if (request.RequestType == "请假" && request.Number <= 5) {
                Console.WriteLine($"{name}:{request.RequestContent}数量{request.Number}被批准。");
            }
            else {
                if (superior != null) {
                    superior.RequestApplications(request);
                }
            }
        }

    }
    internal class GeneralManager : Manager
    {
        public GeneralManager(string name) : base(name) {

        }

        public override void RequestApplications(Request request) {
            if (request.RequestType == "请假" ) {
                Console.WriteLine($"{name}:{request.RequestContent}数量{request.Number}被批准。");
            }
            else if(request.RequestType == "加薪" && request.Number <= 500) {
                Console.WriteLine($"{name}:{request.RequestContent}数量{request.Number}被批准。");
            }
            else if (request.RequestType == "加薪" && request.Number > 500) {
                Console.WriteLine($"{name}:{request.RequestContent}数量{request.Number}再说吧。");
            }
        }

    }


}
