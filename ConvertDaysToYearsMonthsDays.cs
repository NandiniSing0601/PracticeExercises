using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_practiceCodes
{
    internal class ConvertDaysToYearsMonthsDays
    {
        public void ConvertDays(int totalDays)
        {
            int days = totalDays;
            if(days<=0)
            {
                Console.WriteLine("Please enter positive numbers");
                return;
            }
            int years = days / 365;
            int remainingdays = days % 365;
            int months = remainingdays / 30;
            int daysTotal = remainingdays % 30;

            Console.WriteLine($"{days} days is equal to {years} years , {months} months and {daysTotal} days");
        }
    }
}
