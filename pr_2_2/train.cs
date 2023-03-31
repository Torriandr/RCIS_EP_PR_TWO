using System;
using System.Linq;

namespace Pr2_2
{
    public class Train
    {
        public string destinationName;
        public string TrainNumber;
        public DateTime departureTime;
        public Train(string destinationName, string TrainNumber, DateTime departureTime) 
        {
            this.destinationName = destinationName;
            this.TrainNumber = TrainNumber;
            this.departureTime = departureTime;
        }
        public static string informationOutput(string trainNumberType, Train[] informationLine)
        {
            string return_information = null;
            var trainInformation = from view in informationLine
                where view.TrainNumber == trainNumberType
                select view;

            foreach (var view in trainInformation)
            {
                return_information = $"Поезд №: {view.TrainNumber}" 
                                     + $"\nПункт назначения: {view.destinationName}"
                                     + $"\nВремя: {view.departureTime.ToString("hh:mm" + " dd.MM.yyyy")}";
            }

            return return_information;
        }
    }
}