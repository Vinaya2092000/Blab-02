using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_LogicalProblem
{
    internal class UC1_FibonacciSeries
    {
        public void Series()
        {   //next number is the sum of previous two numbers
            //for example 0, 1, 1, 2, 3, 5, 8, 13, 21 etc.
            int n1 = 0, n2 = 1, n3, i, num;

            Console.Write("Enter the number of elements: ");
            num = int.Parse(Console.ReadLine());
            
            Console.Write(n1 + " " + n2 + " "); //printing 0 and 1    
            for (i = 2; i < num; ++i)          
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }

        }
    }
}