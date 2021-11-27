using System;
using System.Diagnostics.CodeAnalysis;

namespace UnitOfWorkExample.Dtos
{
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
    public class WeatherForecastItemDto
    {
        public int Id { get; set; }
        
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF { get; set; }

        public string Summary { get; set; }
    }
}