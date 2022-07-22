using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

//here we use System.Diagnostics to create
//INITIALIZE NEW INSTANCE obj (sto) from THE VAR or method Stopwatch  
namespace Day6_LogicalProblem
{
    internal class UC6_StopwatchProgram
    {
        public void Watch()
        {
            // Create new stopwatch.
            Stopwatch sto = new Stopwatch();

            // Begin timing.
            sto.Start();

            // Do something.
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(1);
            }

            // Stop timing.
            sto.Stop();

            // Write result.
            Console.WriteLine("Time elapsed: {0}", sto.Elapsed);
        }
    }
}
