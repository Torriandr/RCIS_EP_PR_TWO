using System.Text.Json.Serialization;
using System.Text.Json;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;

namespace Pr_2_6
{
    public class Program
    {
        public static void Main()
        {
            var lat = "55.25848";
            var lon = "85.598";            
            var key = "eb4078956cb7b284d57b504a39b53410";
            var request = new Requests($"https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&appid={key}");
            request.Launch();
            var conclusion = request.Response;
            var json = JObject.Parse(conclusion);
            var temperatures = json["main"];
            Temperature temperature = new Temperature((int)temperatures["temperature"],
                (int)temperatures["feels_like"],
                (int)temperatures["temp_min"],
                (int)temperatures["temp_max"],
                (int)temperatures["pressure"],
                (int)temperatures["humidity"]);
            string Town = (string)json["name"];
            Console.WriteLine($"Погода: {Town}");
            Console.WriteLine($"Температура: {temperature.temperature}°C\n"
                              + $"Ощущается как: {temperature.feelingNow}°C\n"
                              + $"Минимальная температура: {temperature.temperatureLeast}°C\n"
                              + $"Максимальная температура: {temperature.temperatureGreat}°C\n"
                              + $"Давление: {temperature.pressure}мм рт.ст.\n"
                              + $"Влажность: {temperature.humidity}%");
            var windConclusion = json["wind"];
            WindyWeather wind = new WindyWeather((int)windConclusion["speedWind"], (int)windConclusion["temperature"]);
            Console.WriteLine($"Ветер: {wind.temperature}\n"
                              + $"Скорость ветра: {wind.speedWind} м/с");
            var cloudConclusion = json["clouds"];
            skyWeather cloud = new skyWeather((int)cloudConclusion["all"]);
            Console.WriteLine($"Погода на небе: {cloud.SkyWeather}");
        }
    }
}