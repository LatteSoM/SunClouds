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
using HourlyForecastModel;
using ApiModels;

namespace SunCloud.ViewModel
{
    public class PrimaryViewModel : BindingTool
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

        public PrimaryWindow primaryWindow = Application.Current.Windows.OfType<PrimaryWindow>().FirstOrDefault();

        public HourlyForecastObject hourlyForecast;
        public CurrentWeather currWeather;

        public PrimaryViewModel(HourlyForecastObject _hourlyForecast, CurrentWeather _currWeather) 
        {
            dragComm = new BindableCommand(_ => DragWindow());
            closeComm = new BindableCommand(_ => CloseWindow());
            maximizeComm = new BindableCommand(_ => MaximizeWindow());
            minimizeComm = new BindableCommand(_ => MinimizeWindow());

            _themeService = new ThemeService();
            _themeService.ThemeChanged += OnThemeChanged;
            _currentTheme = _themeService.GetCurrentTheme();
            SetThemeProperties();
            primaryWindow.WeatherSettingsPageFrame.Content = new WeatherPage(_hourlyForecast, _currWeather);
            hourlyForecast = _hourlyForecast;
            currWeather = _currWeather;
        }

        public BindableCommand dragComm { get; set; }
        public BindableCommand closeComm { get; set; }
        public BindableCommand maximizeComm { get; set; }
        public BindableCommand minimizeComm { get; set; }
        public BindableCommand showWeatherComm { get; set; }
        public BindableCommand showSettingsComm { get; set; }

        public PrimaryWindow primaryWindow = Application.Current.Windows.OfType<PrimaryWindow>().FirstOrDefault();

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
            p_pageFrameContent = new WeatherPage(hourlyForecast, currWeather);

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
