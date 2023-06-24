using System;
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
using System.Windows.Shapes;
using SunCloud.View.Pages;
using SunCloud.ViewModel;
using WeatherLib;
using HourlyForecastModel;
using ApiModels;

namespace SunCloud.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для PrimaryWindow.xaml
    /// </summary>
    public partial class PrimaryWindow : Window
    {
        public PrimaryWindow(HourlyForecastObject _hourlyForecast, CurrentWeather _currentWeather)
        {
            InitializeComponent();
            DataContext = new PrimaryViewModel(_hourlyForecast, _currentWeather);
            //WeatherSettingsPageFrame.Content = new WeatherPage();
        }
    }
}
