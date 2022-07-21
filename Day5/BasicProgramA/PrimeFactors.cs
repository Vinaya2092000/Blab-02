using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramA
{
    internal class PrimeFactors
    {
        public void Facto()
        {
            int num;

            Console.WriteLine("Enter the Number: ");
#pragma warning disable CS8604 // Possible null reference argument.
            num = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.

            for (int i = 0; i * i
                            <= num; i++)
            {
                if(num%i == 0)
                {
                    Console.WriteLine("", i);
                }
            }
            Console.WriteLine("Prime factor for " + num, "are: ", num);

        }
    }
}
