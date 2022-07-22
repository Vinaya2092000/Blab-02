using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_LogicalProblem
{
    internal class UC2_PerfectNumber
    {
        //the Perfect Number is also a special type of
        //positive number.When the number is equal to the sum of its positive divisors
        //excluding the number, it is called a Perfect Number. For example, 28 is the perfect
        //number because when we sum the divisors of 28, it will result in the same number.
        //The divisors of 28 are 1, 2, 4, 7, and 14. So,
        // 28 = 1+2+4+7
        // 28 = 6,28
        // 28 = 28
        public void Perfect()
        {
            int i, j, sum;
            int n, m;

            Console.Write("Input the ending range of number : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the ending range of number : ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("The Perfect numbers within the given range : ");
            for (i = n; i <= m; i++)
            {
                j = 1;
                sum = 0;
                while (j < i)
                {
                    if (i % j == 0)
                        sum = sum + j;
                    j++;
                }
                if (sum == i)
                    Console.Write("{0} ", i);
            }
            Console.Write("\n");
        }
    }
}
