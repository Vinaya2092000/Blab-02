﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class UC1_EnpAttend
    {
        public static void EmpWage()
        {

            int Full_Time = 1;
            int Emp_Rate_per_Hr = 20;       //variables
            int empHrs = 0;
            int empWage = 0;

            Random r = new Random();   
            //generates a random num within range
            int empCheck = r.Next(0, 2);
            if (empCheck == Full_Time)
                empHrs = 8;
            //else
            //empHrs =0;
            empWage = empHrs * Emp_Rate_per_Hr;
            Console.WriteLine("Emp Wage is " +empWage);
            Console.WriteLine($"Emp Wage is: {empWage}"); 
            //$ is to ensure the writeing of the string along with the local int 
            //Console.
            Console.ReadKey();
        }
    }
}
