using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Domain.Models;

namespace WeatherApp.Domain.Abstractions
{
    public interface IWeatherForecastRepository
    {
        WeatherForecast[] GetForeCasts(); 
    }
}
