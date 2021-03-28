using PS.Entities.WeatherForecast;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Service
{
    public interface IWeatherForecastService
    {
        public IEnumerable<WeatherForecast> GetAllWeatherForecast();

    }
}
