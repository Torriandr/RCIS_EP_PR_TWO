using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Pr_2_6
{
    public class skyWeather
    {
        public string SkyWeather { get; }
        public skyWeather(int sky)
        {
            if (sky >= 8 && sky <= 10)
            {
                this.SkyWeather = "Пасмурное небо";
            }
            if (sky >= 3 && sky <= 7)
            {
                this.SkyWeather = "Переменная облачность";
            }
            if (sky >= 0 && sky <= 3)
            {
                this.SkyWeather = "Ясное небо";
            }
        }
    }
}