namespace UC2_PerfectNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i,j,sum;
            int mn=1,mx;   
   
            Console.Write("Input the ending range of number : ");
            mx = Convert.ToInt32(Console.ReadLine());  
            Console.Write("The Perfect numbers within the given range : ");
            for(i=mn;i<=mx;i++)
            {
                j=1;
                sum = 0;
                while(j<i)
	            {
                    if(i%j==0)
                    sum=sum+j;
                    j++;
                }
                if(sum==n) 
                Console.Write("{0} ",i);
            }
            Console.Write("\n");
        }
    }
}