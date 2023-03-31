using System;
using System.Collections.Generic;

namespace Pr2_4
{
    class Program
    {
        private static Dictionary<char, int> RomanTranslation = new Dictionary<char, int>
        {
            {'I', 1}, 
            {'V', 5}, 
            {'X', 10}, 
            {'L', 50}, 
            {'C', 100}, 
            {'D', 500}, 
            {'M', 1000}
        };
        public static int ConvertNumber(string line)
        {
            int generalFormNumber = 0, initialStageNumber = 0;
            
            foreach (var symbol in line)
            {
                if (!RomanTranslation.ContainsKey(symbol))
                {
                    return 0;
                }
                var conversionAverage = RomanTranslation[symbol];
                generalFormNumber += conversionAverage;
                
                if (initialStageNumber != 0 && initialStageNumber < conversionAverage)
                {
                    if (initialStageNumber == 1 && (conversionAverage == 5 || conversionAverage == 10)
                        || initialStageNumber == 10 && (conversionAverage == 50 || conversionAverage == 100)
                        || initialStageNumber == 100 && (conversionAverage == 500 || conversionAverage == 1000))
                    {
    
                        generalFormNumber -= 2 * initialStageNumber;
                    }
                    else
                    {
                        return 0;
                    }
                }
                initialStageNumber = conversionAverage;
            }
            return generalFormNumber;
        }
        public static void Main()
        {
            Console.Write("Какие символы существуют: I, V, X, L, C,  D,  M\n"
                          + "                Значения: 1, 5, 10,50,100,500,1000\n" 
                          + "Введите римскую цифру для перевода в целое: ");
            string RomanNumber = Console.ReadLine();
            int Number = ConvertNumber(RomanNumber);
            Console.WriteLine(Number);
        }
    }
}