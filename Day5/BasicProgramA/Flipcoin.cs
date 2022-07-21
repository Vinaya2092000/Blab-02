using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramA
{
    internal class Flipcoin
    {
        public void Flip_percent()
        {
           // variables
            int Head = 0;
            int Tail = 0;

            Console.WriteLine("Enter the number of flips: ");
            int number_of_flips =  Convert.ToInt32(Console.ReadLine());

            while (number_of_flips<=0)
            {
                Console.WriteLine(" Invalid input, enter number greater than 0: ");
                Console.WriteLine("Please enter: ");
                number_of_flips = Convert.ToInt32(Console.ReadLine());  
            }
            for (int i = 0; i < number_of_flips; i++)
            {
                Random flip = new Random();
                int HoT = flip.Next(0, 2);

                if (HoT <0.5)
                {
                    Head++;
                }
                else
                {
                    Tail++;
                }
            }
            float Head_Percent = (float)Head / (float)number_of_flips;
            float Tail_Percent = (float)Tail / (float)number_of_flips;

            Console.WriteLine(Head_Percent + "is the % of times the result is head");
            Console.WriteLine(Tail_Percent + "is the % of times the result is tail");

        }
    }
}
