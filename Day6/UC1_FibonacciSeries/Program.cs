namespace UC1_FibonacciSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Nth number of the Fibonacci Series : ");
            int Nnumber = int.Parse(Console.ReadLine());

            //Decrement the Nth Number by 1. This is because the series starts with 0
            Nnumber = Nnumber - 1;
            Console.Write(NFibonacciNumber(Nnumber));
            Console.ReadKey();

        }

        private static int NFibonacciNumber(int number)
        {
            if ((number == 0) || (number == 1))
            {
                return number;
            }
            else
            {
                return (NFibonacciNumber(number - 1) + NFibonacciNumber(number - 2));
            }
        }
    }
}
        }
    }
}