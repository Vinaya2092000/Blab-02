namespace LineProblem
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            LineEqual emp = new LineEqual();
            emp.LineOne();
            double ans1 = emp.LineOne();
            double ans2 = emp.LineTwo();
            if (ans1 == ans2)
            {
                Console.WriteLine("Lines are equal");
            }
            else
            {
                Console.WriteLine("Lines are not equal");
            }


        }
    }
}