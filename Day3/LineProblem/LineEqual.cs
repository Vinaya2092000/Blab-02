using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineProblem
{
    internal class LineEqual
    {
        public double LineOne()
        {
            Console.WriteLine("Enter the coordinates of Line One");
            Console.WriteLine("Enter the value for X1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for Y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Value for x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for Y2");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double r1 = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y2) ^ 2);
            Console.WriteLine("The Length Of Line one is: " + r1);
            return r1;
        }


        public double LineTwo()
        {
            Console.WriteLine("Enter the coordinates of Line Two");
            Console.WriteLine("Enter the value for X1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for Y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Value for x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for Y2");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double r2 = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y2) ^ 2);
            Console.WriteLine("The Length Of Line one is: " + r2);
            return r2;
        }
    }
}
