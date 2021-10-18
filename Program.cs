using System;
using System.IO;
using System.Linq;

namespace serialization.xml
{
    public class WheatherForecast
    {
        public DateTimeOffset Date { get; set; }
        public int TemperatureCelsius { get; set; }
        public string Summary { get; set; }
        public class Program
        {
            static void Main(string[] args)
            {
                var WeatherForecast = new WheatherForecast
                {
                    Date = DateTime.Parse("2021-10-13"),
                    TemperatureCelsius = 29,
                    Summary = "Delhi weather is extreme either too much hot or cold"
                };
                string weatherString = JsonSerializer.Serialize(WeatherForecast);
                Console.WriteLine("json is {0}")
            }
        }
    }
}
