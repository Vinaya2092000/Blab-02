namespace UC4_ReverseANumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = 0;
            int rev = 0;
            int remainder = 0;
            Console.WriteLine("Number before reverse = " + n);
            n=Convert.ToInt32(ReadLine());
            while(n > 0)
            {
                remainder = n % 10;
                n = n / 10;
                rev = rev * 10 + remainder;
            }
            Console.WriteLine("Number after reverse  = "+ rev);
      
        }
    }
}