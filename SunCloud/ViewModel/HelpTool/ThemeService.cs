using SunCloud.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Threading;
using Timer = System.Timers.Timer;
using System.Windows;

namespace SunCloud.ViewModel.HelpTool
{
    internal class ThemeService
    {
        private readonly List<Theme> _themes;
        private readonly Timer _timer;
        private int _currentThemeIndex;
        public ThemeService()
        {
            _themes = new List<Theme>()
            {
                new Theme()
                {
                    Name = "MorningEvening",
                    CloseWindowBtnStyleKey = (Style)App.Current.Resources["CloseWindowBtnMorningEvening"],
                    MaximizeWindowBtnStyleKey = (Style)App.Current.Resources["MaximizeWindowBtnMorningEvening"],
                    MinimizeWindowBtnStyleKey = (Style)App.Current.Resources["MinimizeWindowBtnMorningEvening"],
                    MainWindowCurrCityTbStyleKey = (Style)App.Current.Resources["MainWindowCurrCityTbMorningEvening"],
                    CurrCityTbxStyleKey = (Style)App.Current.Resources["CurrCityTbxMorningEvening"],
                    WhatWeatherBtnStyleKey = (Style)App.Current.Resources["WhatWeatherBtnMorningEvening"],
                    WhatWeatherBtnLabelStyleKey = (Style)App.Current.Resources["WhatWeatherBtnLabelMorningEvening"],
                    WindowBackgroundStyleKey = (Style)App.Current.Resources["MorningEveningWindowBackground"],
                    ChangePageBtnStyleKey = (Style)App.Current.Resources["ChangePageBtnMorningEvening"],
                    ChangePageBtnLabelStyleKey = (Style)App.Current.Resources["ChangePageBtnLabelMorningEvening"],
                    CurrCityTbStyleKey = (Style)App.Current.Resources["CurrCityTbMorningEvening"]
                },
                new Theme()
                {
                    Name = "Day",
                    CloseWindowBtnStyleKey = (Style)App.Current.Resources["CloseWindowBtn"],
                    MaximizeWindowBtnStyleKey = (Style)App.Current.Resources["MaximizeWindowBtn"],
                    MinimizeWindowBtnStyleKey = (Style)App.Current.Resources["MinimizeWindowBtn"],
                    MainWindowCurrCityTbStyleKey = (Style)App.Current.Resources["MainWindowCurrCityTb"],
                    CurrCityTbxStyleKey = (Style)App.Current.Resources["CurrCityTbx"],
                    WhatWeatherBtnStyleKey = (Style)App.Current.Resources["WhatWeatherBtn"],
                    WhatWeatherBtnLabelStyleKey = (Style)App.Current.Resources["WhatWeatherBtnLabel"],
                    WindowBackgroundStyleKey = (Style)App.Current.Resources["DayWindowBackground"],
                    ChangePageBtnStyleKey = (Style)App.Current.Resources["ChangePageBtn"],
                    ChangePageBtnLabelStyleKey = (Style)App.Current.Resources["ChangePageBtnLabel"],
                    CurrCityTbStyleKey = (Style)App.Current.Resources["CurrCityTb"]
                },
                new Theme()
                {
                    Name = "Night",
                    CloseWindowBtnStyleKey = (Style)App.Current.Resources["CloseWindowBtnNight"],
                    MaximizeWindowBtnStyleKey = (Style)App.Current.Resources["MaximizeWindowBtnNight"],
                    MinimizeWindowBtnStyleKey = (Style)App.Current.Resources["MinimizeWindowBtnNight"],
                    MainWindowCurrCityTbStyleKey = (Style)App.Current.Resources["MainWindowCurrCityTbNight"],
                    CurrCityTbxStyleKey = (Style)App.Current.Resources["CurrCityTbxNight"],
                    WhatWeatherBtnStyleKey = (Style)App.Current.Resources["WhatWeatherBtnNight"],
                    WhatWeatherBtnLabelStyleKey = (Style)App.Current.Resources["WhatWeatherBtnLabelNight"],
                    WindowBackgroundStyleKey = (Style)App.Current.Resources["NightWindowBackground"],
                    ChangePageBtnStyleKey = (Style)App.Current.Resources["ChangePageBtnNight"],
                    ChangePageBtnLabelStyleKey = (Style)App.Current.Resources["ChangePageBtnLabelNight"],
                    CurrCityTbStyleKey = (Style)App.Current.Resources["CurrCityTbNight"]
                },
            };
            _currentThemeIndex = GetCurrentThemeIndex();
            _timer = new Timer(60000);
            _timer.Elapsed += OnTimerElapsed;
            _timer.Start();
        }

        public event EventHandler ThemeChanged;

        public Theme GetCurrentTheme()
        {
            return _themes[_currentThemeIndex];
        }

        private int GetCurrentThemeIndex()
        {
            var now = DateTime.Now;
            if (now.Hour >= 4 && now.Hour < 11 || now.Hour >= 17 && now.Hour < 23)
            {
                return 0;
            }
            if (now.Hour >= 12 && now.Hour < 16)
            {
                return 1;
            }
            return 2;
        }

        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            var newThemeIndex = GetCurrentThemeIndex();
            if (_currentThemeIndex != newThemeIndex)
            {
                _currentThemeIndex = newThemeIndex;
                ThemeChanged?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
