using System.Threading.Tasks;
using System.Net;

namespace Pr_2_6
{
    public class WindyWeather
    {
        public int speedWind { get; }
        public string temperature { get; }
        public WindyWeather(int speedWind, int temperature)
        {
            this.speedWind = speedWind;
            if (temperature == 0 || temperature == 360)
            {
                this.temperature = "Сторона света - Север";
            }
            if (temperature == 90)
            {
                this.temperature = "Сторона света - Восток";
            }
            if (temperature == 180)
            {
                this.temperature = "Сторона света - Юг";
            }
            if (temperature == 270)
            {
                this.temperature = "Сторона света - Запад";
            }
            if (temperature > 270 && temperature < 360)
            {
                this.temperature = "Северо-западный ветер";
            }   
            if (temperature > 180 && temperature < 270)
            {
                this.temperature = "Юго-западный ветер";
            }
            if (temperature > 90 && temperature < 180)
            {
                this.temperature = "Юго-восточный ветер";
            }                
            if (temperature > 0 && temperature < 90)
            {
                this.temperature = "Северо-восточный ветер";
            }
        }
    }
}