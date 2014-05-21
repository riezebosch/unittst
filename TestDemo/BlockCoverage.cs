using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo
{
    public class BlockCoverage
    {
        public static void Foo(bool p1, bool p2)
        {
            string output = null;

            if (p1)
            {
                output = "p1";
            }

            if (p2)
            {
                output = "p2";
            }

            Console.WriteLine(output.ToString());
        }
    }
}
