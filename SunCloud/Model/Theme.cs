using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SunCloud.Model
{
    internal class Theme
    {
        public string Name { get; set; }
        public Style CloseWindowBtnStyleKey { get; set; }
        public Style MaximizeWindowBtnStyleKey { get; set; }
        public Style MinimizeWindowBtnStyleKey { get; set; }
        public Style MainWindowCurrCityTbStyleKey { get; set; }
        public Style CurrCityTbxStyleKey { get; set; }
        public Style WhatWeatherBtnStyleKey { get; set; }
        public Style WhatWeatherBtnLabelStyleKey { get; set; }
        public Style WindowBackgroundStyleKey { get; set; }
        public Style ChangePageBtnStyleKey { get; set; }
        public Style ChangePageBtnLabelStyleKey { get; set; }
        public Style CurrCityTbStyleKey { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
