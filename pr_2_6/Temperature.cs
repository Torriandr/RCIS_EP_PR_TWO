using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Text.RegularExpressions;

namespace Pr_2_6
{
    public class Temperature
    {
        public int temperature { get; }
        public int pressure { get; }
        public int feelingNow { get; }
        public int temperatureGreat { get; }
        public int temperatureLeast { get; }
        public int humidity { get; }
        public Temperature(int temperature, int pressure, int feelingNow, int temperatureGreat,
            int temperatureLeast, int humidity)
        {
            this.temperature = temperature - 273;
            this.pressure = pressure;
            this.feelingNow = feelingNow - 273;
            this.temperatureGreat = temperatureGreat - 273;
            this.temperatureLeast = temperatureLeast - 273;
            this.humidity = humidity;
        }
    }
}