namespace UC9_VowelOrConsonants
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            
            Console.Write("Enter an Alphabet : ");
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            ch = Convert.ToChar(Console.ReadLine().ToLower());
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            
            int i = ch;
            if (i >= 48 && i <= 57)
            {
                Console.Write("You entered a number, Please enter an alpahbet.");
            }
            else
            {
                switch (ch)
                {
                    case 'a':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'i':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'o':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'u':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'e':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    default:
                        Console.WriteLine("The Alphabet is a Consonant");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}