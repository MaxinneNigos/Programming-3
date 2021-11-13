using System;

namespace PROG3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Time Keeping Feature!");
            Console.WriteLine($"Today's Date:  {DateTime.Today.ToShortDateString()}");

            Console.WriteLine("To log your time-in, enter your employee ID: ");
            string employeeId = Console.ReadLine();

            TimeSpan timeIn = new TimeSpan(8, 0, 0);
            Console.WriteLine($"Employee {employeeId}, Your log-in time is recorded: {timeIn}");

            Console.WriteLine("*****************************************");
            Console.WriteLine("To log your time-out, enter your employee ID: ");
            employeeId = Console.ReadLine();

            TimeSpan timeOut = new TimeSpan(16, 35, 0);
            Console.WriteLine($"Employee {employeeId}, Your log-out time is recorded: {timeOut}");

            TimeSpan lunchBreakDuration = new TimeSpan(1, 0, 0);
            TimeSpan totalHours = (timeOut - timeIn) - lunchBreakDuration;

            Console.WriteLine($"You have worked with a total hours of: {totalHours} ");

            TimeSpan regularHoursStart = new TimeSpan(8, 0, 0);
            TimeSpan regularHoursEnd = new TimeSpan(17, 0, 0);
            TimeSpan lateIn = new TimeSpan(0, 0, 0);
            TimeSpan earlyOut = new TimeSpan(0, 0, 0);
            TimeSpan underTime = new TimeSpan(1, 30, 0);

            if (timeIn > regularHoursStart)
            {
                lateIn = timeIn-regularHoursStart;
            }

            if (timeOut > regularHoursEnd)
            {
                underTime = timeOut-regularHoursEnd;
            }

            Console.WriteLine($"WARNING: Employee {employeeId} have worked undertime. The total amount of undertime hours is: {underTime}");
            Console.ReadLine();
        }
    }
}