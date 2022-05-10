using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;

namespace Api_consol_M
{
    class Program
    {
        static void Main(string[] args)

        {
            var key = "yAcKGRAiuMyc0ejQenZ43QYsFZsmzoGG"; //мой Api ключ


            WebClient webClient = new WebClient();
            string jsonUrl = $"http://dataservice.accuweather.com/forecasts/v1/daily/1day/295863?apikey={key}&&language=ru&metric=true";
            jsonUrl = webClient.DownloadString(jsonUrl);
            RootWeather weatherData = JsonSerializer.Deserialize<RootWeather>(jsonUrl);
            


            foreach (var item in weatherData.DailyForecasts)
            {
                Console.WriteLine("Минимальная температура: " +item.Temperature.Minimum.Value);
                Console.WriteLine("Максимальная температура: " + item.Temperature.Maximum.Value);
            }
            

        }

    }



}
