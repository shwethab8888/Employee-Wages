using System;

namespace Employee_Wage_working_hr_or_day_in_a_month
{
    internal class Program
    {
        static void Main()
        {
            decimal wagePerHour = 20;
            int fullDayHour = 8;
            int partTimeHour = 4;
            int workingDayPerMonth = 20;
            int maxWorkingHourPerMonth = 100;

            decimal fullDayWage = wagePerHour * fullDayHour;
            decimal partTimeWage = wagePerHour * partTimeHour;

            int fullDayCount = 0;
            int partTimeCount = 0;
            int totalWorkingHour = 0;
            decimal totalWage = 0;

            for (int day = 1; day <= workingDayPerMonth; day++)
            {
                if (totalWorkingHour >= maxWorkingHourPerMonth)
                {
                    break;
                }

                if (totalWorkingHour + fullDayHour <= maxWorkingHourPerMonth)
                {
                    totalWorkingHour += fullDayHour;
                    totalWage += fullDayWage;
                    fullDayCount++;
                }
                else if (totalWorkingHour + partTimeHour <= maxWorkingHourPerMonth)
                {
                    totalWorkingHour += partTimeHour;
                    totalWage += partTimeWage;
                    partTimeCount++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("Total Full Day: " + fullDayCount);
            Console.WriteLine("Total Part Time: " + partTimeCount);
            Console.WriteLine("Total Working Hour: " + totalWorkingHour);
            Console.WriteLine("Total Wage: " + totalWage);
        }
    }

}