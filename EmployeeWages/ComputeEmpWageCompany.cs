using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    public class ComputeEmpWageCompany
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public static int ComputeEmpWage_Company(string company, int empRateHour, int numOfWorkingDays, int maxHoursPerMonth)
        {

            //Variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            //Computation
            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRateHour;
            Console.WriteLine("Total Emp Wage for company : " + company + "is: " + totalEmpWage);
            return totalEmpWage;
            {
                computeEmpWage("Dmart", 20, 2, 10);
                computeEmpWage("Reliance", 10, 4, 20);
            }
        }

        internal static void ComputeEmpWage_Company()
        {
            throw new NotImplementedException();
        }

        private static void computeEmpWage(string v1, int v2, int v3, int v4)
        {
            throw new NotImplementedException();
        }
    }
    
}
