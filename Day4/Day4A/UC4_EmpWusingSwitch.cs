using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public class UC4_EmpWusingSwitch
    {
        //Constants
        public const int Part_Time = 1;
        public const int Full_Time = 2;
        public const int Emp_Rate_Per_Hr = 20;
        public const int No_of_Working_Days = 2;

        public static void EmpWusingSwitch()
        {
            //Variable
            int empHrs = 0;
            int empWage = 0;

            Random r = new Random();     //generate random num within parameters
            int empCheck = r.Next(0, 3);
            switch (empCheck)
            {
                case Part_Time:
                    empHrs = 4;
                    break;

                case Full_Time:
                    empHrs = 8;
                    break;

                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * Emp_Rate_Per_Hr;
            Console.WriteLine("Emp Wage: " +empWage);
            Console.ReadKey();
        }
    }
}
