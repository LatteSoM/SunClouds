using SunCloud.View.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows;
using SunCloud.ViewModel.HelpTools;

namespace SunCloud.ViewModel
{
    internal class MainViewModel : BindingTool
    {
        private string _Foreground;

        public string p_Foreground
        {
            get { return _Foreground; }
            set
            {
                _Foreground = value;
                onPropertyChanged();
            }
        }
        private string _Text;

        public string p_Text
        {
            get { return _Text; }
            set
            {
                _Text = value;
                onPropertyChanged();
            }
        }

        private string _visibilityMode;

        public string p_visibilityMode
        {
            get { return _visibilityMode; }
            set
            {
                _visibilityMode = value;
                onPropertyChanged();
            }
        }



        public MainViewModel()
        {
            closeComm = new BindableCommand(_ => CloseWindow());
            minimizeComm = new BindableCommand(_ => MinimizeWindow());
            maximizeComm = new BindableCommand(_ => MaximizeWindow());
            whatCurrWeatherComm = new BindableCommand(_ => WhatWeatherBtn_Click());
            clearComm = new BindableCommand(_ => BtnClearTextBox_Click());
            dragComm = new BindableCommand(_ => DragWindow());
            textChangedComm = new BindableCommand(_ => CurrCityTbx_TextChanged());
            gotFocusComm = new BindableCommand(_ => CurrCityTbx_GotFocus());
            lostFocusComm = new BindableCommand(_ => CurrCityTbx_LostFocus());

            _Foreground = "#FFFFFF";
            _Text = "Ваш город";
            //CurrCityTbx.GotFocus += CurrCityTbx_GotFocus;
            //CurrCityTbx.LostFocus += CurrCityTbx_LostFocus;
        }

        public BindableCommand closeComm { get; set; }
        public BindableCommand minimizeComm { get; set; }
        public BindableCommand maximizeComm { get; set; }
        public BindableCommand whatCurrWeatherComm { get; set; }
        public BindableCommand dragComm { get; set; }
        public BindableCommand clearComm { get; set; }
        public BindableCommand gotFocusComm { get; set; }
        public BindableCommand lostFocusComm { get; set; }
        public BindableCommand textChangedComm { get; set; }

        public MainWindow mainWindow = Application.Current.MainWindow as MainWindow;

        // переход на окно с инфой о погоде в городе
        private void WhatWeatherBtn_Click()
        {
            PrimaryWindow primary_win = new PrimaryWindow();
            primary_win.Show();

        }

        //Метод для перетаскивания окна
        private void DragWindow()
        {
            try
            {
                
                mainWindow.DragMove();
            }
            catch (Exception)
            {
                //throw;
            }
        }

        private void CloseWindow()
        {
            try
            {
                mainWindow.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        //окно на фуллскрин.
        private void MaximizeWindow()
        {
            try
            {
                if (mainWindow.WindowState == WindowState.Maximized)
                {
                    mainWindow.WindowState = WindowState.Normal;
                }
                else
                {
                    mainWindow.WindowState = WindowState.Maximized;
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
                mainWindow.WindowState = WindowState.Minimized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void CurrCityTbx_TextChanged()
        {
            // показываем или скрываем кнопку очистки, в зависимости от содержимого TextBox
            if (string.IsNullOrWhiteSpace(_Text))
            {
                _visibilityMode = "Collapsed";
            }
            else
            {
                _visibilityMode = "Visible";
            }
        }

        private void CurrCityTbx_GotFocus()
        {
            // если юзер нажимает на кнопку, очищаем хинт
            if (_Text == "Ваш город")
            {
                _Text = string.Empty;
                _visibilityMode = "Visible";
            }
        }

        private void CurrCityTbx_LostFocus()
        {
            // если текстбокс пустой, показываем хинт
            if (string.IsNullOrWhiteSpace(_Text))
            {
                _Text = "Ваш город";
                _Foreground = "#FFFFFF";
            }
        }

        private void BtnClearTextBox_Click()
        {
            // очищаем текстбокс по кнопке
            _Text = string.Empty;
            _visibilityMode = "Collapsed";
        }
    }
}
