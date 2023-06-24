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
using ApiModels;

namespace SunCloud.ViewModel
{
    internal class WeatherPageViewModel : BindingTool
    {

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

        private string _tempMin;

        public string p_tempMin
        {
            get { return _tempMin; }
            set
            {
                _tempMin = value;
                onPropertyChanged();
            }
        }

        private string _tempMax;

        public string p_tempMax
        {
            get { return _tempMax; }
            set
            {
                _tempMax = value;
                onPropertyChanged();
            }
        }

        private string _tempFeel;

        public string p_tempFeel
        {
            get { return _tempFeel; }
            set
            {
                _tempFeel = value;
                onPropertyChanged();
            }
        }

        private string _pressureMain;

        public string p_pressureMain
        {
            get { return _pressureMain; }
            set
            {
                _pressureMain = value;
                onPropertyChanged();
            }
        }

        private string _humidityMain;

        public string p_humidityMain
        {
            get { return _humidityMain; }
            set
            {
                _humidityMain = value;
                onPropertyChanged();
            }
        }

        private string _windSpeed;

        public string p_windSpeed
        {
            get { return _windSpeed; }
            set
            {
                _windSpeed = value;
                onPropertyChanged();
            }
        }

        private string _windDeg;

        public string p_windDeg
        {
            get { return _windDeg; }
            set
            {
                _windDeg = value;
                onPropertyChanged();
            }
        }

        private string _citySet;

        public string p_citySet
        {
            get { return _citySet; }
            set
            {
                _citySet = value;
                onPropertyChanged();
            }
        }

        private List<CustomControlLib.WeatherCard> _weatherCards;
        public List<CustomControlLib.WeatherCard> fictionList = new List<CustomControlLib.WeatherCard>();
        public List<CustomControlLib.WeatherCard> p_weatherCards
        {
            get { return _weatherCards; }
            set { 
                _weatherCards = value;
                onPropertyChanged();
            }
        }


        public WeatherPageViewModel(HourlyForecastObject _hourlyForecast, CurrentWeather _currentWeather)
        {
            foreach(var fore in _hourlyForecast.hourly)
            {
                CustomControlLib.WeatherCard card = new CustomControlLib.WeatherCard();
                DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(fore.dt).ToLocalTime();
                card.TimeTbl.Text = dt.ToString("H:mm");
                card.TempreatureTbl.Text = Math.Round(fore.temp - 273.15, 2).ToString() ;
                card.HumidityPercentTbl.Text = fore.humidity.ToString();
                card.FeelingDegreeTbl.Text = Math.Round(fore.feels_like - 273.15, 2).ToString();
                fictionList.Add(card);
            }

            p_weatherCards = fictionList;

            p_tempMain = Math.Round(_currentWeather.main.temp - 273.15).ToString() + "°";
            p_tempFeel = Math.Round(_currentWeather.main.feels_like - 273.15).ToString() + "°";
            p_tempMin = Math.Round(_currentWeather.main.temp_min - 273.15).ToString() + "°";
            p_tempMax = Math.Round(_currentWeather.main.temp_max - 273.15).ToString() + "°";
            p_pressureMain = _currentWeather.main.pressure.ToString();
            p_humidityMain = _currentWeather.main.humidity.ToString() + "%";
            p_windSpeed = _currentWeather.wind.speed.ToString() + "м/с";
            p_windDeg = _currentWeather.wind.deg.ToString() + "°";




        }

    }
 
}
