using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HelloServiceWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HelloService" in both code and config file together.
    public class HelloService : IHelloServiceChanged
    {
        public string GetNameWithHello(string name)
        {
            return "Hello" + name;
        }
    }
}
