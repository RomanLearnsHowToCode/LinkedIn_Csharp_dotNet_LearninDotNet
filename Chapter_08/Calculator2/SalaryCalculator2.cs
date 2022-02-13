using System;

namespace Calculator2
{
    public class SalaryCalculator2
    {
        public decimal GetAnnualSalary(decimal hourlyWage)
        {
            const int HoursInYear = 2080;
            decimal annualSalary = hourlyWage * HoursInYear;
            return 0; // annualSalary;
        }
    }
}
}
