using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace TestDemo
{
    public class RaceCondition
    {

        public RaceCondition()
        {
            HttpRuntime.Cache["myKey"] = 6;
        }

        public void Foo()
        {
            HttpRuntime.Cache["myKey"] = 
                (int)HttpRuntime.Cache["myKey"] + 3;
            Console.WriteLine(HttpRuntime.Cache["myKey"]);
            
            HttpRuntime.Cache.Remove("myKey");
        }
    }
}
