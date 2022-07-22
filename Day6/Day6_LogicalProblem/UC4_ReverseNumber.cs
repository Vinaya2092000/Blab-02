using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_LogicalProblem
{
    internal class UC4_ReverseNumber
    {
        public void Reverse()
        {
            int n = 0;
            int rev = 0;
            int remainder = 0;
            Console.WriteLine("Number before reverse = " + n);
            n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                remainder = n % 10;
                n = n / 10;
                rev = rev * 10 + remainder;
            }
            Console.WriteLine("Number after reverse  = " + rev);

        }
    }
}
