using System;

namespace Employee_Wage_for_a_Month
{
    internal class Program
    {
        static void Main()
        {
            decimal wagePerHour = 20;
            int fullDayHour = 8;
            int partTimeHour = 4;
            int workingDayPerMonth = 20;

            decimal fullDayWage = wagePerHour * fullDayHour;
            decimal partTimeWage = wagePerHour * partTimeHour;

            decimal monthlyWage = (16 * fullDayWage) + (4 * partTimeWage);
            Console.WriteLine("Monthly Wage: " + monthlyWage);
        }
    }

}