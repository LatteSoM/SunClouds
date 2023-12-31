﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ApiModels;
using SunCloud.ViewModel;
using WeatherLib;
using HourlyForecastModel;

namespace SunCloud.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для WeatherPage.xaml
    /// </summary>
    public partial class WeatherPage : Page
    {
        public WeatherPage(HourlyForecastObject _hourlyForecast, CurrentWeather _currentWeather)
        {
            InitializeComponent();
            DataContext = new WeatherPageViewModel(_hourlyForecast, _currentWeather);
        }
    }
}
