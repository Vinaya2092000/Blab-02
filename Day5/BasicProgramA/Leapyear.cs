using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramA
{
    internal class Leapyear
    {
        public void LeapYear()
        {
            Console.WriteLine("Enter the year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            while (year < 1000 || year >9999)
            {
                Console.WriteLine("Enter a 4 digit year: ");
                year = Convert.ToInt32(Console.ReadLine());
            }

            if (((year % 4 ==0 ) && (year % 100 != 0) || (year %400 ==0)))
            {
                Console.WriteLine(year +" is a leap year");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year");
            }
        }
    }
}

