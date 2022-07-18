namespace BasicProgramA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 for Flip Coin");
            Console.WriteLine("2 for Harmonic number");
            Console.WriteLine("3 for Leap Year");
            Console.WriteLine("4 for Power2");
            Console.WriteLine("5 for Prime Factor");

            int Prog = Convert.ToInt32(Console.ReadLine()); 

            switch(Prog)
            {
                case 1:
                    Flipcoin flipcoin = new Flipcoin();
                    flipcoin.Flip_percent();
                    break;

                case 2:
                    HarmonicNumber har = new HarmonicNumber();
                    har.Harmonic();
                    break;

                case 3:
                    Leapyear leap = new Leapyear();
                    leap.LeapYear();
                    break;

                case 4:
                    Power2 pow = new Power2();
                    pow.Power_of_two();
                    break;

                case 5:
                    PrimeFactors prime = new PrimeFactors();
                    prime.Prime();
                    break;
            }
        }
    }
}