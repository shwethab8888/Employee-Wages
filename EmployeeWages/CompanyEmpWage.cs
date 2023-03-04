﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    public class CompanyEmpWage
    {
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;
        public static void Company_EmpWage()
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.ComputeEmpWage();
        }
        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.setTotalEmpWage = totalEmpWage;
        }
        public string toString()
        {
            return "Total Emp Wage for Company:" + this.company + "is:" + this.totalEmpWage;
        }


        public class EmpWageBuilderArray
        {
            public const int IS_PART_TIME = 1;
            public const int IS_FULL_TIME = 2;

            private int numOfCompany = 0;
            private CompanyEmpWage[] companyEmpWageArray;
            private int maxHoursPerMonth;

            public EmpWageBuilderObject(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
            {
                this.company = company;
                this.empRatePerHour = empRatePerHour;
                this.numOfWorkingDays = numOfWorkingDays;
                this.maxHoursPerMonth = maxHoursPerMonth;
            }

            public EmpWageBuilderArray()
            {
                this.companyEmpWageArray = new CompanyEmpWage[5];
            }

            public void addcomputeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
            {
                companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);

            }
            public void computeEmpWage(CompanyEmpWage)
            {
                for (int i = 0; i < numOfCompany; i++)
                {
                    companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                    Console.WriteLine(this.companyEmpWageArray[i].ToString());
                }
            }
            private int computeEmpWage(CompanyEmpWage companyEmpWage)
            {
                //Variables
                int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
                //Computation
                while (totalEmpHrs <= computeEmpWage.maxHoursPerMonth && totalWorkingDays < computeEmpWage.numOfWorkingDays)
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
                    Console.WriteLine("Days:" + totalWorkingDays + " Emp Hrs:" + empHrs);
                }
                return totalEmpHrs * computeEmpWage.empRateHour;

            }

            internal void ComputeEmpWage()
            {
                throw new NotImplementedException();
            }
        }
    }
}
