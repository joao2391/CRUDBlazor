using Blazor.Client.Data;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Data
{
    public class WeatherForecastService
    {        

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());
        }

        public void AddWeather()
        {
            //Context _context = new Context();
            //_context.Temperaturas.Add(new WeatherForecast { Date = DateTime.Now, Summary = "teste", Id = 1, TemperatureC = 20 });
            //_context.SaveChanges();
            //var teste = _context.Temperaturas.Count();
            
        }
    }
}
