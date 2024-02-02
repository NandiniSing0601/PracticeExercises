// See https://aka.ms/new-console-template for more information
using DSA_practiceCodes;

Console.WriteLine("Hello, World!");


// Example cases to Convert Roman into integer
RomanToInteger integer = new RomanToInteger();
Console.WriteLine(integer.RomanToInt("III"));      // Output: 3
Console.WriteLine(integer.RomanToInt("LVIII"));    // Output: 58
Console.WriteLine(integer.RomanToInt("MCMXCIV"));  // Output: 1994

// Convert Days to years , months and days
int days = Convert.ToInt32(Console.ReadLine());
ConvertDaysToYearsMonthsDays convertDays = new ConvertDaysToYearsMonthsDays();
convertDays.ConvertDays(days);
Console.ReadLine();