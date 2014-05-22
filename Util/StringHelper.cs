using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Util
{
    public class StringHelper
    {
        public string Reverse(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input mag niet niks zijn");
            }

            var sb = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                sb.Append(input[i]);
            }

            return sb.ToString();
        }
    }
}
