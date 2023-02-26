namespace EmployeeWage_P_or_A
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int attendance = random.Next(2); // generates a random integer between 0 and 1

            if (attendance == 1)
            {
                Console.WriteLine("Employee is present.");
            }
            else
            {
                Console.WriteLine("Employee is absent.");
            }
        }
    }
}