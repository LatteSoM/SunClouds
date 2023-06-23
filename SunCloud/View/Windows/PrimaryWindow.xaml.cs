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
using System.Windows.Shapes;
using ApiModels;
using HourlyForecastModel;
using SunCloud.View.Pages;
using SunCloud.ViewModel;
using WeatherLib;


namespace SunCloud.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для PrimaryWindow.xaml
    /// </summary>
    public partial class PrimaryWindow : Window
    {
        public PrimaryWindow(HourlyForecastObject _hourlyForecast, CurrentWeather _currWeather)
        {
            InitializeComponent();
            DataContext = new PrimaryViewModel(_hourlyForecast, _currWeather);
            //WeatherSettingsPageFrame.Content = new WeatherPage();
        }
    }
}
        //Метод для перетаскивания окна
//        private void DragWindow(object sender, MouseButtonEventArgs e)
//        {
//            try
//            {
//                DragMove();
//            }
//            catch (Exception)
//            {
//                //throw;
//            }
//        }

//        private void CloseWindow(object sender, MouseButtonEventArgs e)
//        {
//            try
//            {
//                Close();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//                //throw;
//            }
//        }

//        //окно на фуллскрин. не доделан возврат к прошлому размеру по повторному нажатию. мне лень
//        private void MaximizeWindow(object sender, MouseButtonEventArgs e)
//        {
//            try
//            {
//                this.WindowState = WindowState.Maximized;
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//                //throw;
//            }
//        }

//        // сворачивание окна
//        private void MinimizeWindow(object sender, MouseButtonEventArgs e)
//        {
//            try
//            {
//                this.WindowState = WindowState.Minimized;
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//                //throw;
//            }
//        }
//    }
//}
