using System.Windows;
using System.Windows.Controls;
using LanguageApp.Properties;

namespace LanguageApp
{
    public partial class SettingsWindow : Window
    {
        public SettingsWindow()
        {
            InitializeComponent();
            ThemeToggle.IsChecked = Settings.Default.IsDarkTheme;
        }

        private void ThemeToggle_Checked(object sender, RoutedEventArgs e)
        {
            Settings.Default.IsDarkTheme = true;
            Settings.Default.Save();
            App.ApplyTheme(true);
        }

        private void ThemeToggle_Unchecked(object sender, RoutedEventArgs e)
        {
            Settings.Default.IsDarkTheme = false;
            Settings.Default.Save();
            App.ApplyTheme(false);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            new MainMenu().Show();
            this.Close();
        }
    }
}
