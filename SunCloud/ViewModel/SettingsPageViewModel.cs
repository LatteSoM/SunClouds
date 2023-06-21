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

namespace SunCloud.ViewModel
{
    internal class SettingsPageViewModel : BindingTool
    {
        private Style _mainWindowCurrCityTbStyleKey;
        private Style _whatWeatherBtnStyleKey;
        private Style _whatWeatherBtnLabelStyleKey;
        private Theme _currentTheme;
        private readonly ThemeService _themeService;
        public Style MainWindowCurrCityTbStyleKey
        {
            get { return _mainWindowCurrCityTbStyleKey; }
            set
            {
                _mainWindowCurrCityTbStyleKey = value;
                onPropertyChanged(nameof(MainWindowCurrCityTbStyleKey));
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
        public SettingsPageViewModel()
        {
            _themeService = new ThemeService();
            _themeService.ThemeChanged += OnThemeChanged;
            _currentTheme = _themeService.GetCurrentTheme();
            SetThemeProperties();
        }
        private void SetThemeProperties()
        {
            /* Применение изменений темы */
            MainWindowCurrCityTbStyleKey = _currentTheme.MainWindowCurrCityTbStyleKey;
            WhatWeatherBtnStyleKey = _currentTheme.WhatWeatherBtnStyleKey;
            WhatWeatherBtnLabelStyleKey = _currentTheme.WhatWeatherBtnLabelStyleKey;
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            /* Изменение темы */
            _currentTheme = _themeService.GetCurrentTheme();
            SetThemeProperties();
        }
    }
}
