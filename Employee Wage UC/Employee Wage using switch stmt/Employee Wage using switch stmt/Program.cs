using System;

namespace Employee_Wage_using_switch_stmt
{
    internal class Program
    {
        static void Main()
        {
            decimal wagePerHour = 20;
            int workHour;
            decimal dailyWage;

            Console.WriteLine("Enter work hour:");
            workHour = Convert.ToInt32(Console.ReadLine());

            switch (workHour)
            {
                case 8:
                    dailyWage = wagePerHour * workHour;
                    Console.WriteLine("Full Day Wage: " + dailyWage);
                    break;

                case 4:
                    dailyWage = wagePerHour * workHour;
                    Console.WriteLine("Part Time Wage: " + dailyWage);
                    break;

                default:
                    Console.WriteLine("Invalid work hour!");
                    break;
            }
        }
    }

}