using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_LogicalProblem
{
    internal class UC3_PrimeNumber
    {
        public void Prime()
        {
            int n1;

            Console.WriteLine("Accept number:");
            n1 = Convert.ToInt32(Console.ReadLine());
            if (n1 == 0 || n1 == 1)
            {
                Console.WriteLine(n1 + " is not prime number");
                Console.ReadLine();
            }
            else
            {
                for (int i = 2; i <= n1 / 2; i++)
                {
                    if (n1 % i == 0)
                    {
                        Console.WriteLine(n1 + " is not prime number");
                        return;
                    }

                }
                Console.WriteLine(n1 + " is a prime number");
                Console.ReadLine();
            }
        }
    }
}
