using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourlyForecastModel
{

    public class Hourly
    {
        public int dt { get; set; }
        public double temp { get; set; }
        public double feels_like { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }
        public double dew_point { get; set; }
        public double uvi { get; set; }
        public int clouds { get; set; }
        public int visibility { get; set; }
        public double wind_speed { get; set; }
        public int wind_deg { get; set; }
        public double wind_gust { get; set; }
        public List<Weather> weather { get; set; }
        public int pop { get; set; }
    }


    /// <summary>
    /// Данная структура содержит информацию о прогнозе погоды по часам.
    /// 
    /// Подробная информация о погоде на определенный час хранится в структуре Hourly
    /// 
    /// Прогноз погоды на ближайшие 48 часов хранится в атрибуте hourly
    /// </summary>
    public class HourlyForecastObject
    {
        public double lat { get; set; }
        public double lon { get; set; }
        public string timezone { get; set; }
        public int timezone_offset { get; set; }
        public List<Hourly> hourly { get; set; }
    }

    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }
}
