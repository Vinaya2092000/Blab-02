namespace EmpSwitch
{
    internal class Program
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int IS_ABSENT = 0;

        public const int DailyWage = 0;
        //public float TotalMage = 0;
        int Empwage = 20;
        public int IsEmployeePresent()
        {
            return new Random().Next(0, 3);
        }

        //Randon random= new Randon); 
        //int value = ranoda.next(0,3)
        public void CalculateEmpwage()
        {

            // int DayNumber = 1;
            int EmpworkingHrs = 0;
            //int TotalworkingHrs = 0;

            switch (IsEmployeePresent())
            {
                case IS_ABSENT:
                    EmpworkingHrs = 0;
                    break;

                case IS_PART_TIME:
                    EmpworkingHrs = 4;
                    break;


                case IS_FULL_TIME:
                    EmpworkingHrs = 8;
                    break;

            }
            int DailyWage = EmpworkingHrs * Empwage; //TotalMage + EmpDailywage;
                                                 // DayNumber++;                                                 // TotalWorkingHrs += EmpWorkingHrs;
        }
        static void Main(string[] args)
        {
            EmpworkingHrs.CalculateEmpwage();
            Console.WriteLine("Daily Wage: " +DailyWage);
        }
    }
}