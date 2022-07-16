namespace EAttendance
{
    internal class Attendance
    {
        public int EmpPresent = 1;
        public void CheckEmpPresentAbsent()
        {
            Random empCheck = new Random(); //Random=class random=obj
            int value = empCheck.Next(0, 2); //next=method

            if (value == EmpPresent)
            {
                Console.WriteLine("Employee Present");
            }

            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
        public static void Main(String[] args)
        {
            Attendance empA = new Attendance();
            empA.CheckEmpPresentAbsent();
        }
    }
}