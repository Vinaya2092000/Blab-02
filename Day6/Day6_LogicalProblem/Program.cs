namespace Day6_LogicalProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 for Fibonacci Series");
            Console.WriteLine("2 for Perfect number");
            Console.WriteLine("3 for Prime Number");
            Console.WriteLine("4 for Reverse Number");
            Console.WriteLine("5 for Coupon Number");
            Console.WriteLine("6 for Stop Watch");

            int Prog1 = Convert.ToInt32(Console.ReadLine());
            NewMethod(Prog1);
        }

        private static void NewMethod(int Prog1)
        {
            switch (Prog1)
            {
                case 1:
                    UC1_FibonacciSeries ser = new UC1_FibonacciSeries();
                    ser.Series();
                    break;

                case 2:
                    UC2_PerfectNumber pnum = new UC2_PerfectNumber();
                    pnum.Perfect();
                    break;

                case 3:
                    UC3_PrimeNumber pri = new UC3_PrimeNumber();
                    pri.Prime();
                    break;

                case 4:
                    UC4_ReverseNumber rev = new UC4_ReverseNumber();
                    rev.Reverse();
                    break;

                case 5:
                    UC5_CouponNumber cou = new UC5_CouponNumber();
                    cou.Coupon();
                    break;

                case 6:
                    UC6_StopwatchProgram pwa = new UC6_StopwatchProgram();
                    pwa.Watch();
                    break;
            }
        }


    }
}