using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Voer de geboortedatum in: ");
            var birth = DateTime.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);

            //var age = CalcAge(birth);
            //Console.WriteLine("De leeftijd is: {0}", age);
        }



        public static int CalcAge(DateTime birth)
        {
            var now = DateTime.Now;
            var result = now.Year - birth.Year;

            if (now.Month < birth.Month || 
                (now.Month == birth.Month && now.Day < birth.Day))
            {
                result--;
            }

            return result;
        }
    }
}
