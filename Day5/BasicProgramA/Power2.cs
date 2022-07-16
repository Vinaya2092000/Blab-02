using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramA
{
    internal class Power2
    {
        public void Power_of_two()     // 2^n operation
        {
            Console.Write("Enter the number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            while (n < 0 || n >= 31 )
            {
                Console.Write("");
            }
        }
    }
}
