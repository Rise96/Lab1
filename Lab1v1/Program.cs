using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            DaysInYear yearConverter = new DaysInYear();
            Console.WriteLine("Пожалуйста, введите год");
            string year = Console.ReadLine();
            int days = yearConverter.NumberOfDaysInYear(year);
            Console.WriteLine($"Число дней в {year} году равно {days}");
            Console.ReadLine();
        }
    }
}

