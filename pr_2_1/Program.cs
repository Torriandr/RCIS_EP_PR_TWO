using System;
using System.Collections.Generic;
using System.Linq;

namespace Pr2_1
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
            Console.Write("Введите строку с драгоценностями: ");
            string J = Console.ReadLine();
            Console.Write("Введите строку с камнями: ");
            string S = Console.ReadLine();
            int quantity = 0;

            foreach (char symbol in S)
            {
                if (J.IndexOf(symbol) >= 0)
                {
                    quantity++;
                }
            }

            Console.WriteLine($"Количество камней, являющиеся драгоценностями: {quantity}");
        }
        public static void secondTask() 
        {
            Console.Write("Введите размерность массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] candidates = new int[n];
    
            for (int i = 0; i < candidates.Length; i++)
            {
                Console.Write("Введите {0}-й элемент массива: ", i + 1);
                candidates[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Введите числовую цель: ");
            int target = Convert.ToInt32(Console.ReadLine());
    
            var combinations = transferringSortingCombinations(candidates, target);
    
            foreach (var result in combinations) 
            {
                Console.WriteLine(string.Join(",", result));
            }
        }
        public static void thirdTask()
        {
            Console.Write("Введите размерность массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] Numbers = new int[n];

            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.Write("Введите {0}-й элемент массива: ", i + 1);
                Numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("nums = ");

            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.Write(Numbers[i] + " ");
            }
            Console.Write(repetitionCheck(Numbers));
        }
        public static IList<IList<int>> transferringSortingCombinations(int[] candidates, int target) 
        {
            Array.Sort(candidates);
            IList<IList<int>> combinations = new List<IList<int>>();
            transferringSortingCombinations(candidates, target, 0, new List<int>(), combinations);
            
            return combinations;
        }
        public static void transferringSortingCombinations(int[] candidates, int target, int zero, IList<int> now, IList<IList<int>> combinations) 
        {
            if (target == 0) 
            {
                combinations.Add(new List<int>(now));
                 
                return;
            }
    
            for (int i = zero; i < candidates.Length && candidates[i] <= target; i++) 
            {
                if (i > zero && candidates[i] == candidates[i - 1]) 
                {
                    continue; 
                }
                now.Add(candidates[i]);
                transferringSortingCombinations(candidates, target - candidates[i], i + 1, now, combinations);
                now.RemoveAt(now.Count - 1);
            }
        }
        static bool repetitionCheck(int[] nums)
        {
            bool array = nums.GroupBy(value => value).Any(arrayType => arrayType.Count() > 1);
            
            return array;
        }
    }
}