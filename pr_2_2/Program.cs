using System;

namespace Pr2_2
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
                case "4":
                    quadrupleTask();
                    break;
                case "5":
                    fifthTask();
                    break;
            }
        }
        static void firstTask()
        {
            STUDENT[] studentInformation =
            {
                new STUDENT("Завидов", "01.07.2005", 612, new int[] { 4, 5, 4, 5, 4 }),
                new STUDENT("Громова", "05.05.2005", 412, new int[] { 5, 5, 5, 5, 5 }),
                new STUDENT("Измайлова", "12.01.2005", 312, new int[] { 2, 3, 2, 4, 3 }),
                new STUDENT("Меркулова", "11.09.2006", 121, new int[] { 4, 5, 5, 4, 5 }),
                new STUDENT("Соловьёв", "31.08.2004", 621, new int[] { 4, 4, 3, 4, 5 })
            };

            foreach (var student in studentInformation)
            {
                System.Console.WriteLine(student);
            }
            Console.Clear();
            Console.Write("Фамилии и дни рождения студентов:\n"
                          + "Завидов - 01.07.2005,\n"
                          + "Громова - 05.05.2005,\n"
                          + "Измайлова - 12.01.2005,\n"
                          + "Меркулова - 11.09.2006,\n"
                          + "Соловьёв - 31.08.2004.\n");
            Console.Write("Введите фамилию студента: ");
            string surnameCheck = Console.ReadLine();
            Console.Write("Введите дату рождения студента: ");
            string DateOfTimeCheck = Console.ReadLine();
            Console.WriteLine(STUDENT.informationOutput(surnameCheck, DateOfTimeCheck, studentInformation) 
			      ?? "Такого студента не существует.");
            Console.Write("Хотите ли вы изменить данные о студенту? (да или нет)\nОтвет: ");

            switch (Console.ReadLine())
            {
                case "да":
                    Change();
                    break;
                case "нет":
                    break;
            }
        }
        public static void Change()
        {
            Console.Write("Введите изменённую фамилию: ");
            string surnameNew = Console.ReadLine();
            Console.Write("Введите изменённую дату рождения: ");
            string DateOfDirthNew = Console.ReadLine();
            Console.Write("Введите изменённый номер группы: ");
            string groupNumberNew = Console.ReadLine();
            Console.Write($"Изменённая фамилия: {surnameNew}\n"
                          + $"Изменённая дата рождения: {DateOfDirthNew}\n"
                          + $"Изменённый номер группы: {groupNumberNew}\n");
        }
        static void secondTask()
        {
            Train[] shippingInformation =
            {
                new Train("Санкт-Петербург", "1015", new DateTime(2023, 7, 1, 05, 50, 0)),
                new Train("Белград", "1016", new DateTime(2023, 7, 5, 12, 30, 0)),
                new Train("Екатеренбург", "1017", new DateTime(2023, 7, 3, 04, 40, 0)),
                new Train("Владивосток", "1018", new DateTime(2023, 7, 11, 14, 10, 0)),
                new Train("Калининград", "1019", new DateTime(2023, 7, 27, 18, 10, 0))
            };

            foreach (var number in shippingInformation)
            {
                System.Console.WriteLine(number);
            }
            Console.Clear();
            Console.Write("Номера поездов: 1015, 1016, 1017, 1018, 1019\n");
            Console.Write("Введите номер поезда : ");
            string trainNumberCheck = Console.ReadLine();
            Console.WriteLine(Train.informationOutput(trainNumberCheck, shippingInformation) 
		              ?? "Поезда с таким номером не существует.");
        }
        public static void thirdTask()
        {
            Console.Write("Выберите и введите следующее действие:\n"
                          + "conclusion - вывод значений на экран\n"
                          + "change - изменение значений\n"
                          + "findSum - найти сумму значений\n"
                          + "greatest - найти наибольшее значение\n");
            string Choice = Convert.ToString(Console.ReadLine());

            switch (Choice)
            {
                case "conclusion":
                    StoringIntegers.Conclusion();
                    break;
                case "change":
                    StoringIntegers.Change();
                    break;
                case "findSum":
                    StoringIntegers.FindSum();
                    break;
                case "greatest":
                    StoringIntegers.Greatest();
                    break;
            }
        }
        public static void quadrupleTask()
        {
            Console.Write("Выберите и введите следующее действие:\n"
                          + "increase - увеличить значение\n"
                          + "decrease - уменьшить значение\n"
                          + "get - получить текущее состояние значения\n");
            string Choice = Convert.ToString(Console.ReadLine());
            
            switch (Choice) 
            {
                case "increase":
                    Counter.increaseValue();
                    break;
                case "decrease":
                    Counter.decreaseValue();
                    break;
                case "get":
                    Counter.getValue();
                    break;
            }
        }
        public static void fifthTask()
        {
            Object Cassowary = new Object("Казуар", 19);
            Object Armadillo = new Object("Броненосец", 12);
            Object Dolphin = new Object("Дельфин", 30);
            Object Axolotl = new Object("Аксототль", 10);
            Object Tamarin = new Object("Тамарин", 15);

            try
            {
                Console.WriteLine($"\nВид животного: {Cassowary.kindOfAnimal}"
                                  + $"\nСреднее проживание на земле в годах: {Cassowary.yearsOfLife}\n");
                Console.WriteLine($"Вид животного: {Armadillo.kindOfAnimal}"
                                  + $"\nСреднее проживание на земле в годах: {Armadillo.yearsOfLife}\n");
                Console.WriteLine($"Вид животного: {Dolphin.kindOfAnimal}"
                                  + $"\nСреднее проживание на земле в годах: {Dolphin.yearsOfLife}\n");
                Console.WriteLine($"Вид животного: {Axolotl.kindOfAnimal}"
                                  + $"\nСреднее проживание на земле в годах: {Axolotl.yearsOfLife}\n");
                Console.WriteLine($"Вид животного: {Tamarin.kindOfAnimal}"
                                  + $"\nСреднее проживание на земле в годах: {Tamarin.yearsOfLife}\n");
            }
            finally
            {
                Cassowary.Dispose();
                Armadillo.Dispose();
                Dolphin.Dispose();
                Axolotl.Dispose();
                Tamarin.Dispose();
            }
        }
    }
}