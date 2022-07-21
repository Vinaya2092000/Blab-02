namespace UC8_EvenOrOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.Write(num + " is an even number.");
            }
            else if (num % 2 == 1)
            {
                Console.Write(num + " is an odd number.");
            }
        }
    }
}