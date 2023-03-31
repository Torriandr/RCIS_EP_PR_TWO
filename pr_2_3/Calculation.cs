using System;

namespace Pr2_3
{
    public class Calculation
    {
        public static string calculationLine = "Sleep is the meaning of life";
        
        public static void SetCalculationLine()
        {
            Console.Write($"Текущее значение свойства: {calculationLine}\n");
            Console.Write("Введите изменённое значение свойства: ");
            string calculationLineNow = Convert.ToString(Console.ReadLine());
            Console.Write($"Изменённое значение свойства: {calculationLineNow}");
        }
        public static void SetLastSymbolCalculationLine()
        {
            Console.Write($"Текущее значение свойства: {calculationLine}\n");
            calculationLine += 'z';
            Console.Write($"Строка с добавленным в конец символом: {calculationLine}");
        }
        public static void GetCalculationLine()
        {
            Console.Write($"Значение свойства: {calculationLine}");
        }
        public static void GetLastSymbol()
        {
            Console.Write($"Текущее значение свойства: {calculationLine}\n");
            char lastSymbol = calculationLine[calculationLine.Length - 1];
            Console.Write($"Последний символ: {lastSymbol}");
        }
        public static void DeleteLastSymbol()
        {
            Console.Write($"Текущее значение свойства: {calculationLine}\n");
            int lastSymbol = calculationLine.Length - 1;
            calculationLine = calculationLine.Remove(lastSymbol);
            Console.Write($"Значение свойства с удалённым в конце символом: {calculationLine}");
        }
    }
}