namespace Employee_Wage_Part_time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal wagePerHour = 20;
            int fullDayHour = 8;
            int partTimeHour = 4;

            decimal fullDayWage = wagePerHour * fullDayHour;
            decimal partTimeWage = wagePerHour * partTimeHour;

            Console.WriteLine("Full Day Wage: " + fullDayWage); 
            Console.WriteLine("Part Time Wage: " + partTimeWage);
        }
    }
}