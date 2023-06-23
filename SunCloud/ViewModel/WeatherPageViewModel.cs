using SunCloud.ViewModel.HelpTools;
using SunCloud.View.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using SunCloud.ViewModel.HelpTools;
using SunCloud.View.Windows;
using SunCloud.ViewModel.HelpTools;
using SunCloud.View.Windows;
using System;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using SunCloud.Model;
using SunCloud.ViewModel.HelpTool;
using WeatherLib;
using HourlyForecastModel;
using LiveCharts;
using LiveCharts.SeriesAlgorithms;
using LiveCharts.Wpf;
using ApiModels;

namespace SunCloud.ViewModel
{
    public class WeatherPageViewModel : BindingTool
    {

        private List<CustomControlLib.WeatherCard> _forecastCards = new List<CustomControlLib.WeatherCard>();
        private List<CustomControlLib.WeatherCard> _fictionList = new List<CustomControlLib.WeatherCard>();
        //public ISeries[] Series { get; set; }
        public List<CustomControlLib.WeatherCard> p_forecastCards
        {
            get { return _forecastCards; }
            set { 
                _forecastCards = value;
                onPropertyChanged();
            }
        }

        private SeriesCollection _seriesCollection;

        public SeriesCollection p_seriesCollection
        {
            get { return _seriesCollection; }
            set { 
                _seriesCollection = value;
                onPropertyChanged();
            }
        }

        private string _tempMain;

        public string p_tempMain
        {
            get { return _tempMain; }
            set 
            { 
                _tempMain = value; 
                onPropertyChanged();
            }
        }

        private string _tempFeelsLike;

        public string p_tempFeelsLike
        {
            get { return _tempFeelsLike; }
            set 
            { 
                _tempFeelsLike = value; 
                onPropertyChanged();
            }
        }


        private string _minTemp;
        public string p_minTemp
        {
            get { return _minTemp; }
            set { 
                _minTemp = value;
                onPropertyChanged();
            }
        }

        private string _maxTemp;
        public string p_maxTemp
        {
            get { return _maxTemp; }
            set
            {
                _maxTemp = value;
                onPropertyChanged();
            }
        }

        private string _pressureCurr;
        public string p_pressureCurr
        {
            get { return _pressureCurr; }
            set
            {
                p_pressureCurr = value;
                onPropertyChanged();
            }
        }

        private string _humidityCurr;
        public string p_humidityCurr
        {
            get { return _humidityCurr; }
            set
            {
                p_humidityCurr = value;
                onPropertyChanged();
            }
        }

        private string _windSpeed;
        public string p_windSpeed
        {
            get { return _windSpeed; }
            set
            {
                p_windSpeed = value;
                onPropertyChanged();
            }
        }

        private string _windDeg;
        public string p_windDeg
        {
            get { return _windDeg; }
            set
            {
                p_windDeg = value;
                onPropertyChanged();
            }
        }

        public WeatherPageViewModel(HourlyForecastObject _hourlyForecst, CurrentWeather currentWeather) 
        {
            List<double> temps = new List<double>();
            for (int i = 0; i < _hourlyForecst.hourly.Count; i++)
            {
                temps.Add(_hourlyForecst.hourly[i].temp);
            }

            //Hourly current;
            _tempMain = (Math.Round(currentWeather.main.temp - 273.15)).ToString() + "°";
            _tempFeelsLike = (Math.Round(currentWeather.main.feels_like - 273.15, 2)).ToString() + "°";
            _minTemp = (Math.Round(currentWeather.main.temp_min - 273.15, 2)).ToString() + "°";
            _maxTemp = (Math.Round(currentWeather.main.temp_max - 273.15, 2)).ToString() + "°";
            _pressureCurr = currentWeather.main.pressure.ToString();
            _humidityCurr = currentWeather.main.humidity.ToString();
            _windSpeed = currentWeather.wind.speed.ToString();
            _windDeg = currentWeather.wind.deg.ToString();
            //for (int i = 0; i < _hourlyForecst.hourly.Count)
            for (int i = 0; i < _hourlyForecst.hourly.Count; i++) 
            {
                int timestmp = _hourlyForecst.hourly[i].dt;
                var time = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(timestmp).ToLocalTime();

                CustomControlLib.WeatherCard weatherCard = new CustomControlLib.WeatherCard();
                weatherCard.TimeTbl.Text = time.ToString("H:mm");
                weatherCard.TempreatureTbl.Text = (Math.Round(_hourlyForecst.hourly[i].temp - 273.15, 2)).ToString() + "°";
                weatherCard.HumidityPercentTbl.Text = _hourlyForecst.hourly[i].humidity.ToString() + "%";
                weatherCard.FeelingDegreeTbl.Text = (Math.Round(_hourlyForecst.hourly[i].feels_like - 273.15, 2)).ToString();
                _fictionList.Add(weatherCard);
            }

            p_forecastCards = _fictionList;
        }


    }

}
