using System.Windows;
using System.Windows.Media;
using LanguageApp.Properties;

namespace LanguageApp
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            ApplyTheme(Settings.Default.IsDarkTheme);
        }

        public static void ApplyTheme(bool isDark)
        {
            if (isDark)
            {
                Current.Resources["BackgroundColor"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3A3A3A"));
                Current.Resources["ForegroundColor"] = new SolidColorBrush(Colors.White);
                Current.Resources["ButtonColor"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2A2A2A"));
            }
            else
            {
                Current.Resources["BackgroundColor"] = new SolidColorBrush(Colors.White);
                Current.Resources["ForegroundColor"] = new SolidColorBrush(Colors.Black);
                Current.Resources["ButtonColor"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#007ACC"));
            }
        }
    }
}
