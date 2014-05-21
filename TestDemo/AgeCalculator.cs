using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDemo
{
    public class AgeCalculator
    {
        public int Calc(DateTime birth)
        {
            var now = DateTime.Today;
            int result = now.Year - birth.Year;
            if (now.Month < birth.Month)
            {
                result--;
            }
            else if (now.Month == birth.Month && now.Day < birth.Day)
            {
                result--;
            }

            return result;
        }
    }
}
