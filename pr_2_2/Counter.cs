using System;

namespace Pr2_2
{
    public class Counter
    {
        public static int initialValue = 1;
        public static int finalValue = 15;
        public static int GetValue 
        {
            get { return initialValue; }
        }
        public static void increaseValue() 
        {
            Console.WriteLine("Введите значение в диапазоне от 1 до 15: ");
            int value = Convert.ToInt32(Console.ReadLine());
            
            if ((value >= initialValue) && (value <= finalValue)) 
            {
                value++;
            }
            Console.WriteLine($"Значение, увеличенное на единицу: {value}");
        }
        public static void decreaseValue() 
        {
            Console.Write("Введите значение в диапазоне от 1 до 15: ");
            int value = Convert.ToInt32(Console.ReadLine());
            
            if ((value >= initialValue) && (value <= finalValue)) 
            {
                value--;
            }
            Console.Write($"Значение, уменьшенное на единицу: {value}");
        }
        public static void getValue() 
        {
            Console.Write($"Текущее состояние значения: {GetValue}");
        }
    }
}