using System;

namespace Pr2_3
{
    class Program
    {    
        public static void Main()
        {
            Console.Write("Введите номер задания: ");

            switch (Console.ReadLine())
            {
                case "1":
                    firstTask();
                    break;
                case "2":
                    secondTask();
                    break;
                case "3":
                    thirdTask();
                    break;
            }
        }
        public static void firstTask()
        {
            Worker2 worker = new Worker2();
            Console.Write($"Имя первого работника: {worker.FirstName}\n");
            Console.Write($"Фамилия первого работника: {worker.FirstSurname}\n");
            Console.Write($"Ставка за день работы: {worker.FirstRate}\n");
            Console.Write($"Количество отработанных дней: {worker.FirstDays}\n");
            Console.Write($"Имя второго работника: {worker.SecondName}\n");
            Console.Write($"Фамилия второго работника: {worker.SecondSurname}\n");
            Console.Write($"Ставка за день работы6 {worker.SecondRate}\n");
            Console.Write($"Количество отработанных дней: {worker.SecondDays}\n");
            Worker2.GetSalary();
        }
        public static void secondTask()
        {
            Console.Write($"Имя первого работника: {Worker.firstName}" +
                          $"\nФамилия первого работника: {Worker.firstSurname}" +
                          $"\nСтавка за день работы: {Worker.firstRate}" +
                          $"\nКоличество отработанных дней: {Worker.firstDays}" +
                          $"\nИмя второго работника: {Worker.secondName}" +
                          $"\nФамилия второго работника: {Worker.secondSurname}" +
                          $"\nСтавка за день работы: {Worker.secondRate}" +
                          $"\nКоличество отработанных дней: {Worker.secondDays}\n");
            Worker.GetSalary();
        }
        public static void thirdTask()
        {
            Console.Write("Выберите и введите действие:\n"
                          + "change - изменение значения свойства\n"
                          + "add- прибавление символа в конец строки\n"
                          + "concle- вывод значения свойства\n"
                          + "get - получение последнего символа\n"
                          + "delete - удаление последнего символа из строки\n");
            string Choice = Convert.ToString(Console.ReadLine());

            switch (Choice)
            {
                case "change":
                    Calculation.SetCalculationLine();
                    break;
                case "add":
                    Calculation.SetLastSymbolCalculationLine();
                    break;
                case "concle":
                    Calculation.GetCalculationLine();
                    break;
                case "get":
                    Calculation.GetLastSymbol();
                    break;
                case "delete":
                    Calculation.DeleteLastSymbol();
                    break;
            }
        }
    }
}