using System;

namespace Pr2_2
{
    public class StoringIntegers
    {
        public static int firstNumber = 3;
        public static int secondNumber = 17;
        public static void Conclusion()
        {
            Console.Write($"Первая переменная: {firstNumber}"
                          + $"\nВторая переменная: {secondNumber}");
        }
        public static void Change()
        {
            Console.Write("Введите первое изменённое значение: ");
            int firstNewNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе изменённое значение: ");
            int secondNewNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Первое изменённое значение: {firstNewNumber}" 
                          + $"\nВторое изменённое значение: {secondNewNumber}");
        }
        public static void FindSum()
        {
            Console.Write($"Первая переменная: {firstNumber}"
                          + $"\nВторая переменная: {secondNumber}");
            int addition = firstNumber + secondNumber;
            Console.Write($"\nСумма значений: {addition}");
        }
        public static void Greatest()
        {
            Console.Write($"Первая переменная: {firstNumber}"
                          + $"\nВторая переменная: {secondNumber}");
            int maxNumber = 0;
            string NotFound = "Значения равны";

            if (firstNumber > secondNumber)
            {
                maxNumber = firstNumber;
            }
            else if (firstNumber < secondNumber)
            {
                maxNumber = secondNumber;
            }
            else
            {
                Console.Write(NotFound);
            }
            Console.Write($"\nНаибольшее значение: {maxNumber}");
        }
    }
}