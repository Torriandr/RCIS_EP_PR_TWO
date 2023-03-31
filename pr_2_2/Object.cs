using System;

namespace Pr2_2
{
    public class Object: IDisposable
    {
        public string kindOfAnimal { get; set; }
        public int yearsOfLife { get; set; }
        public Object(string kindOfAnimal, int yearsOfLife)
        {
            this.kindOfAnimal = kindOfAnimal;
            this.yearsOfLife = yearsOfLife;
        }
        public void Dispose()
        {
            Console.WriteLine($"Удаление объекта {kindOfAnimal} прошло успешно.");
        }
    }
}