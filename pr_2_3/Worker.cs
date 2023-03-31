using System;

namespace Pr2_3
{
    public class Worker
    {
        public static string firstName = "Victoria";
        public static string firstSurname = "Pavlova";
        public static int firstRate = 300;
        public static int firstDays = 147;
        public static string secondName = "Anastasia";
        public static string secondSurname = "Nikolenko";
        public static int secondRate = 300;
        public static int secondDays = 567;
        public static void GetSalary()
        {
            int firstsalary = firstRate * firstDays;
            int secondsalary = secondRate * secondDays;
            Console.Write($"Зарплата первого работника: {firstsalary}\n");
            Console.Write($"Зарплата второго работника: {secondsalary}");
        }
    }
}