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
using SunCloud.Model;
using SunCloud.ViewModel.HelpTool;
using WeatherLib;
using ApiModels;

namespace SunCloud.ViewModel
{
    internal class MainViewModel : BindingTool
    {
        private string _Foreground;

        private Style _closeWindowBtnStyleKey;
        private Style _maximizeWindowBtnStyleKey;
        private Style _minimizeWindowBtnStyleKey;
        private Style _mainWindowCurrCityTbStyleKey;
        private Style _currCityTbxStyleKey;
        private Style _whatWeatherBtnStyleKey;
        private Style _whatWeatherBtnLabelStyleKey;
        private Style _windowBackgroundStyleKey;
        private Theme _currentTheme;
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

        //private ApiLib _apiDriver = new ApiLib("007886a3de40c94ad9ba25b0fa3c8297");



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

            _themeService = new ThemeService();
            _themeService.ThemeChanged += OnThemeChanged;
            _currentTheme = _themeService.GetCurrentTheme();
            SetThemeProperties();
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
            //CurrentWeather currWeather = _apiDriver.GetCurrentWeather(_Text);
            try
            {
                //MessageBox.Show($"{currWeather.name}\n{string.Join(" ", currWeather.weather)}");
                primary_win.Show();
                mainWindow.Close();
            }
            catch (NullReferenceException)
            {

                MessageBox.Show("ТЫ ЧОРТ");
            }

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
            //Mess
            if (!string.IsNullOrWhiteSpace(_Text))
            {
                p_visibilityMode = "Visible";
            }
            else
            {
                p_visibilityMode = "Collapsed"; 
            }
        }

        private void CurrCityTbx_GotFocus()
        {
            // если юзер нажимает на кнопку, очищаем хинт
            if (p_Text == "Ваш город")
            {
                //_Text = "";
                p_Text = string.Empty;
                p_visibilityMode = "Visible";
            }
        }

        private void CurrCityTbx_LostFocus()
        {
            // если текстбокс пустой, показываем хинт
            if (string.IsNullOrWhiteSpace(p_Text))
            {
                p_Text = "Ваш город";
                p_Foreground = "#FFFFFF";
            }
        }

        private void BtnClearTextBox_Click()
        {
            // очищаем текстбокс по кнопке
            p_Text = string.Empty;
            p_visibilityMode = "Collapsed";
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
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            /* Изменение темы */
            _currentTheme = _themeService.GetCurrentTheme();
            SetThemeProperties();
        }
    }
}
