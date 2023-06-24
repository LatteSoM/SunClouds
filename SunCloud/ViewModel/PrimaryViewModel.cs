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
using SunCloud.View.Pages;
using SunCloud.ViewModel;
using WeatherLib;
using HourlyForecastModel;
using ApiModels;

namespace SunCloud.ViewModel
{
    internal class PrimaryViewModel : BindingTool
    {
        private Style _closeWindowBtnStyleKey;
        private Style _maximizeWindowBtnStyleKey;
        private Style _minimizeWindowBtnStyleKey;
        private Style _mainWindowCurrCityTbStyleKey;
        private Style _currCityTbxStyleKey;
        private Style _whatWeatherBtnStyleKey;
        private Style _whatWeatherBtnLabelStyleKey;
        private Style _windowBackgroundStyleKey;
        private Style _changePageBtnStyleKey;
        private Theme _currentTheme;
        private Style _currCityTbStyleKey;
        private readonly ThemeService _themeService;
        public Style CloseWindowBtnStyleKey
        {
            get { return _closeWindowBtnStyleKey; }
            set
            {
                _closeWindowBtnStyleKey = value;
                onPropertyChanged(nameof(CloseWindowBtnStyleKey));
            }
        }
        public Style MaximizeWindowBtnStyleKey
        {
            get { return _maximizeWindowBtnStyleKey; }
            set
            {
                _maximizeWindowBtnStyleKey = value;
                onPropertyChanged(nameof(MaximizeWindowBtnStyleKey));
            }
        }
        public Style MinimizeWindowBtnStyleKey
        {
            get { return _minimizeWindowBtnStyleKey; }
            set
            {
                _minimizeWindowBtnStyleKey = value;
                onPropertyChanged(nameof(MinimizeWindowBtnStyleKey));
            }
        }

        public Style MainWindowCurrCityTbStyleKey
        {
            get { return _mainWindowCurrCityTbStyleKey; }
            set
            {
                _mainWindowCurrCityTbStyleKey = value;
                onPropertyChanged(nameof(MainWindowCurrCityTbStyleKey));
            }
        }
        public Style CurrCityTbxStyleKey
        {
            get { return _currCityTbxStyleKey; }
            set
            {
                _currCityTbxStyleKey = value;
                onPropertyChanged(nameof(CurrCityTbxStyleKey));
            }
        }
        public Style WhatWeatherBtnStyleKey
        {
            get { return _whatWeatherBtnStyleKey; }
            set
            {
                _whatWeatherBtnStyleKey = value;
                onPropertyChanged(nameof(WhatWeatherBtnStyleKey));
            }
        }
        public Style WhatWeatherBtnLabelStyleKey
        {
            get { return _whatWeatherBtnLabelStyleKey; }
            set
            {
                _whatWeatherBtnLabelStyleKey = value;
                onPropertyChanged(nameof(WhatWeatherBtnLabelStyleKey));
            }
        }
        public Style WindowBackgroundStyleKey
        {
            get { return _windowBackgroundStyleKey; }
            set
            {
                _windowBackgroundStyleKey = value;
                onPropertyChanged(nameof(WindowBackgroundStyleKey));
            }
        }
        public Style ChangePageBtnStyleKey
        {
            get { return _changePageBtnStyleKey; }
            set
            {
                _changePageBtnStyleKey = value;
                onPropertyChanged(nameof(ChangePageBtnStyleKey));
            }
        }
        public Style CurrCityTbStyleKey
        {
            get { return _currCityTbStyleKey; }
            set
            {
                _currCityTbStyleKey = value;
                onPropertyChanged(nameof(CurrCityTbStyleKey));
            }
        }

        private Page _pageFrameContent;

        public Page p_pageFrameContent
        {
            get { return _pageFrameContent; }
            set { 
                _pageFrameContent = value; 
                onPropertyChanged();
            }
        }

        private string _opacityNow;

        public string p_opacityNow
        {
            get { return _opacityNow; }
            set
            {
                _opacityNow = value;
                onPropertyChanged();
            }
        }

        private string _opacityPlusOne;

        public string p_opacityPlusOne
        {
            get { return _opacityPlusOne; }
            set
            {
                _opacityPlusOne = value;
                onPropertyChanged();
            }
        }

        private string _opacityPlusTwo;

        public string p_opacityPlusTwo
        {
            get { return _opacityPlusTwo; }
            set
            {
                _opacityPlusTwo = value;
                onPropertyChanged();
            }
        }

        private string _opacityPlusThree;

        public string p_opacityPlusThree
        {
            get { return _opacityPlusThree; }
            set
            {
                _opacityPlusThree = value;
                onPropertyChanged();
            }
        }


        private string _graduceNow;

        public string p_graduceNow
        {
            get { return _graduceNow; }
            set
            {
                _graduceNow = value;
                onPropertyChanged();
            }
        }

        private string _graducePlusOneHour;

        public string p_graducePlusOneHour
        {
            get { return _graducePlusOneHour; }
            set
            {
                _graducePlusOneHour = value;
                onPropertyChanged();
            }
        }

        private string _graducePlusTwoHour;

        public string p_graducePlusTwoHour
        {
            get { return _graducePlusTwoHour; }
            set
            {
                _graducePlusTwoHour = value;
                onPropertyChanged();
            }
        }

        private string _graducePlusThreeHour;

        public string p_graducePlusThreeHour
        {
            get { return _graducePlusThreeHour; }
            set
            {
                _graducePlusThreeHour = value;
                onPropertyChanged();
            }
        }

        private string _feelsLikeNow;

        public string p_feelsLikeNow
        {
            get { return _feelsLikeNow; }
            set
            {
                _feelsLikeNow = value;
                onPropertyChanged();
            }
        }

        private string _hourPlusOne;

        public string p_hourPlusOne
        {
            get { return _hourPlusOne; }
            set
            {
                _hourPlusOne = value;
                onPropertyChanged();
            }
        }

        private string _hourPlusTwo;

        public string p_hourPlusTwo
        {
            get { return _hourPlusTwo; }
            set
            {
                _hourPlusTwo = value;
                onPropertyChanged();
            }
        }

        private string _hourPlusThree;

        public string p_hourPlusThree
        {
            get { return _hourPlusThree; }
            set
            {
                _hourPlusThree = value;
                onPropertyChanged();
            }
        }

        private string _feelsLikeOne;

        public string p_feelsLikeOne
        {
            get { return _feelsLikeOne; }
            set
            {
                _feelsLikeOne = value;
                onPropertyChanged();
            }
        }

        private string _feelsLikeTwo;

        public string p_feelsLikeTwo
        {
            get { return _feelsLikeTwo; }
            set
            {
                _feelsLikeTwo = value;
                onPropertyChanged();
            }
        }

        private string _feelsLikeThree;

        public string p_feelsLikeThree
        {
            get { return _feelsLikeThree; }
            set
            {
                _feelsLikeThree = value;
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

        public PrimaryWindow primaryWindow = Application.Current.Windows.OfType<PrimaryWindow>().FirstOrDefault();
        public HourlyForecastObject hourlyForecast;
        public CurrentWeather currentWeather;

        public PrimaryViewModel(HourlyForecastObject _hourlyForecast, CurrentWeather _currentWeather) 
        {
            p_opacityNow = "ясно";
            p_graduceNow = "21";
            p_feelsLikeNow = "25";
            p_hourPlusOne = "16:00";
            p_hourPlusTwo = "17:00";
            p_hourPlusThree = "18:00";

            p_opacityPlusTwo = "пассмурно";
            p_opacityPlusThree = "тучно";
            p_opacityPlusOne = "хуй знает";

            p_graducePlusTwoHour = "21";
            p_graducePlusOneHour = "21";
            p_graducePlusThreeHour = "21";

            p_feelsLikeOne = "25";
            p_feelsLikeTwo = "25";
            p_feelsLikeThree = "25";

            //DateTime dt =  ;
            //card.TimeTbl.Text = dt.ToString("H:mm");
            p_hourPlusOne = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(_hourlyForecast.hourly[1].dt).ToLocalTime().ToString("H:mm");
            p_hourPlusTwo = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(_hourlyForecast.hourly[2].dt).ToLocalTime().ToString("H:mm");
            p_hourPlusThree = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(_hourlyForecast.hourly[3].dt).ToLocalTime().ToString("H:mm");

            p_graduceNow = Math.Round(_currentWeather.main.temp - 273.15).ToString() + "°";
            p_opacityNow = _hourlyForecast.hourly[0].weather[0].description;
            p_feelsLikeNow = Math.Round(_currentWeather.main.feels_like - 273.15).ToString() + "°";

            p_opacityPlusOne = _hourlyForecast.hourly[1].weather[0].description;
            p_opacityPlusThree = _hourlyForecast.hourly[2].weather[0].description;
            p_opacityPlusOne = _hourlyForecast.hourly[3].weather[0].description;

            p_graducePlusTwoHour = Math.Round(_hourlyForecast.hourly[1].temp - 273.15).ToString() + "°";
            p_graducePlusOneHour = Math.Round(_hourlyForecast.hourly[2].temp - 273.15).ToString() + "°";
            p_graducePlusThreeHour = Math.Round(_hourlyForecast.hourly[3].temp - 273.15).ToString() + "°";

            p_feelsLikeOne = Math.Round(_hourlyForecast.hourly[1].feels_like - 273.15).ToString() + "°";
            p_feelsLikeTwo = Math.Round(_hourlyForecast.hourly[2].feels_like - 273.15).ToString() + "°";
            p_feelsLikeThree = Math.Round(_hourlyForecast.hourly[3].feels_like - 273.15).ToString() + "°";


            dragComm = new BindableCommand(_ => DragWindow());
            closeComm = new BindableCommand(_ => CloseWindow());
            maximizeComm = new BindableCommand(_ => MaximizeWindow());
            minimizeComm = new BindableCommand(_ => MinimizeWindow());
            showWeatherComm = new BindableCommand(_ => showWeatherPage());
            showSettingsComm = new BindableCommand(_ => showSettingsPage());

            _themeService = new ThemeService();
            _themeService.ThemeChanged += OnThemeChanged;
            _currentTheme = _themeService.GetCurrentTheme();
            SetThemeProperties();
            primaryWindow.WeatherSettingsPageFrame.Content = new WeatherPage(_hourlyForecast, _currentWeather);
            hourlyForecast = _hourlyForecast;
            currentWeather = _currentWeather;
            p_citySet = _currentWeather.name;
        }

        public BindableCommand dragComm { get; set; }
        public BindableCommand closeComm { get; set; }
        public BindableCommand maximizeComm { get; set; }
        public BindableCommand minimizeComm { get; set; }
        public BindableCommand showWeatherComm { get; set; }
        public BindableCommand showSettingsComm { get; set; }

        //Метод для перетаскивания окна
        private void DragWindow()
        {
            try
            {
                primaryWindow.DragMove();
            }
            catch (Exception)
            {
                //throw;
            }
        }

        private void showWeatherPage()
        {
            p_pageFrameContent = null;
            p_pageFrameContent = new WeatherPage(hourlyForecast, currentWeather);

            //primaryWindow.WeatherSettingsPageFrame.Content = null;
            //primaryWindow.WeatherSettingsPageFrame.Content = new WeatherPage();

        }

        private void showSettingsPage()
        {
            p_pageFrameContent = null;
            p_pageFrameContent = new SettingsPage();

            //primaryWindow.WeatherSettingsPageFrame.Content = null;
            //primaryWindow.WeatherSettingsPageFrame.Content = new SettingsPage();
        }

        private void CloseWindow()
        {
            try
            {
                primaryWindow.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        //окно на фуллскрин
        private void MaximizeWindow()
        {
            try
            {   
                if (primaryWindow.WindowState == WindowState.Normal)
                {
                    primaryWindow.WindowState = WindowState.Maximized;
                }
                else
                {
                    primaryWindow.WindowState = WindowState.Normal;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        // сворачивание окна
        private void MinimizeWindow()
        {
            try
            {
                primaryWindow.WindowState = WindowState.Minimized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void SetThemeProperties()
        {
            /* Применение изменений темы */
            CloseWindowBtnStyleKey = _currentTheme.CloseWindowBtnStyleKey;
            MaximizeWindowBtnStyleKey = _currentTheme.MaximizeWindowBtnStyleKey;
            MinimizeWindowBtnStyleKey = _currentTheme.MinimizeWindowBtnStyleKey;
            MainWindowCurrCityTbStyleKey = _currentTheme.MainWindowCurrCityTbStyleKey;
            CurrCityTbxStyleKey = _currentTheme.CurrCityTbxStyleKey;
            WhatWeatherBtnStyleKey = _currentTheme.WhatWeatherBtnStyleKey;
            WhatWeatherBtnLabelStyleKey = _currentTheme.WhatWeatherBtnLabelStyleKey;
            WindowBackgroundStyleKey = _currentTheme.WindowBackgroundStyleKey;
            ChangePageBtnStyleKey = _currentTheme.ChangePageBtnStyleKey;
            CurrCityTbStyleKey = _currentTheme.CurrCityTbStyleKey;
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            /* Изменение темы */
            _currentTheme = _themeService.GetCurrentTheme();
            SetThemeProperties();
        }

    }
}
