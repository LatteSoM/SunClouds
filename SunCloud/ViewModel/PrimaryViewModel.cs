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

namespace SunCloud.ViewModel
{
    internal class PrimaryViewModel : BindingTool
    {
        public PrimaryViewModel() 
        {
            dragComm = new BindableCommand(_ => DragWindow());
            closeComm = new BindableCommand(_ => CloseWindow());
            maximizeComm = new BindableCommand(_ => MaximizeWindow());
            minimizeComm = new BindableCommand(_ => MinimizeWindow());
        }

        public BindableCommand dragComm { get; set; }
        public BindableCommand closeComm { get; set; }
        public BindableCommand maximizeComm { get; set; }
        public BindableCommand minimizeComm { get; set; }

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

        //окно на фуллскрин. не доделан возврат к прошлому размеру по повторному нажатию. мне лень
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
    }
}
