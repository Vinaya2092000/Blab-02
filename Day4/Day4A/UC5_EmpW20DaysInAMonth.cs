using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class UC5_EmpW20DaysInAMonth
    {
        //Constants
        public const int Part_Time = 1;
        public const int Full_Time = 2;
        public const int Emp_Rate_Per_Hr = 20;
        public const int No_of_Working_Days = 2;
        UC4_EmpWusingSwitch obj=new UC4_EmpWusingSwitch();
        public static void EmpW20DaysInAMonth()
        {
            //Variable
            int empHrs = 0;
            int empWage = 0;
            int TotalWage = 0;
            for(int day =0;day<=No_of_Working_Days;day++)
            {
                Random r = new Random();
                int empCheck = r.Next(0, 3);
                switch(empCheck)
                {
                    case Part_Time:
                        empHrs=4;
                        break;

                    case Full_Time:
                        empHrs = 8;
                        break;
                    
                    default:
                        empHrs=0;
                        break;
                }

                empWage = empHrs * obj.Emp_Rate_Per_Hr;
            }
           
        }
    }
}
