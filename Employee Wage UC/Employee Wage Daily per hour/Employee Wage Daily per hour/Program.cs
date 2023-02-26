namespace Employee_Wage_Daily_per_hour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal wagePerHour = 20;
            int fullDayHour = 8;
            decimal dailyWage = wagePerHour * fullDayHour;

            Console.WriteLine("Daily Wage: " + dailyWage);
        }
    }
}