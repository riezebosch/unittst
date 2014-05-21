using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo
{
    public class StringHelper
    {
        /// <summary>
        /// Reverses a string ignoring the surrogate pairs.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static string Reverse(string p)
        {
            if (p == null)
            {
                throw new ArgumentNullException("p");
            }

            var sb = new StringBuilder();
            for (int i = p.Length - 1; i >= 0; i--)
            {
                sb.Append(p[i]);
            }

            return sb.ToString();
        }
    }
}
