using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Domain.Abstractions;
using WeatherApp.Domain.Models;

namespace WeatherApp.Service
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly IWeatherForecastRepository _repository; 
        public WeatherForecastService(IWeatherForecastRepository repository) { 
            _repository = repository;
        }
        public List<WeatherForecast> GetProcessedForecasts()
        {
            List<WeatherForecast> forecasts = new List<WeatherForecast>();

            foreach(var item in _repository.GetForeCasts())
            {
                item.TemperatureF = 32 + (int)(item.TemperatureC / 0.5556);
                forecasts.Add(item);
            }
            return forecasts;

        }
    }
}
