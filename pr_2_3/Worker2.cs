using System;

namespace Pr2_3
{
    public class Worker2
    {
        private static string firstName = "Victoria";
        private static string firstSurname = "Pavlova";
        private static int firstRate = 300;
        private static int firstDays = 147;
        private static string secondName = "Anastasia";
        private static string secondSurname = "Nikolenko";
        private static int secondRate = 300;
        private static int secondDays = 567;
        public string FirstName
        {
            get { return firstName;  }
        }
        public string FirstSurname
        {
            get { return firstSurname;  }
        }        
        public int FirstRate
        {
            get { return firstRate;  }
        }
        public int FirstDays
        {
            get { return firstDays;  }
        }
        public string SecondName
        {
            get { return secondName;  }
        }
        public string SecondSurname
        {
            get { return secondSurname;  }
        }
        public int SecondRate
        {
            get { return secondRate;  }
        }
        public int SecondDays
        {
            get { return secondDays;  }
        }
        public static void GetSalary()
        {
            int firstsalary = firstRate * firstDays;
            int secondsalary = secondRate * secondDays;
            Console.Write($"Зарплата первого работника: {firstsalary}\n");
            Console.Write($"Зарплата второго работника: {secondsalary}");
        }
    }
}