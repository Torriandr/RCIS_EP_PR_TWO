using System.Linq;

namespace Pr2_2
{
    public class STUDENT
    {
        public string surname;
        public string DateOfBirth;
        public int group;
        public int[] performance = new int[5];
        public STUDENT(string surname, string DateOfBirth, int group, int[] performance)
        {
            this.surname = surname;
            this.DateOfBirth = DateOfBirth;
            this.group = group;
            this.performance = performance;
        }
        public static string informationOutput(string surnameType, string DateOfTimeType, STUDENT[] informationLine)
        {
            string return_information = null;
            var studentInformation = from view in informationLine
                where (view.surname) == surnameType
                where (view.DateOfBirth) == DateOfTimeType
                select view;

            foreach (var view in studentInformation)
            {
                return_information = $"Фамилия: {view.surname}" 
                                     + $"\nДата рождения: {view.DateOfBirth}\nНомер группы: {view.group}"
                                     + $"\nУспеваемость: {view.performance[0]},{view.performance[1]},{view.performance[2]},{view.performance[3]},{view.performance[4]}";
            }

            return return_information;
        }
    }
}