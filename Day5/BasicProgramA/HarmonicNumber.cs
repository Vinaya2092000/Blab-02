using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramA
{
    internal class HarmonicNumber
    {
        public void Harmonic()
        {

            Console.WriteLine("Enter value of the N for the Nth Harmonic: ");
            int N = Convert.ToInt32(Console.ReadLine());
            while (N == 0)
            {
                Console.WriteLine();
            }

        }
    }
}
