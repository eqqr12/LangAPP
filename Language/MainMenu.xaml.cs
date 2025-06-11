using System.Windows;

namespace LanguageApp
{
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void EngToUkr_Click(object sender, RoutedEventArgs e)
        {
            var test = new MainWindow(); // англ → укр
            test.Show();
            this.Close();
        }

        private void UkrToEng_Click(object sender, RoutedEventArgs e)
        {
            var test = new MainWindow(reverse: true); // укр → англ
            test.Show();
            this.Close();
        }

        private void Mistakes_Click(object sender, RoutedEventArgs e)
        {
            var mistakes = new MistakeTrainer();
            mistakes.Show();
            this.Close();
        }

        private void Tests_Click(object sender, RoutedEventArgs e)
        {
            //панель тестів
            TestsButton.Visibility = Visibility.Collapsed;
            MistakesButton.Visibility = Visibility.Collapsed;
            ThemesButton.Visibility = Visibility.Collapsed;
            SettingsButton.Visibility = Visibility.Collapsed;

            TestButtonsPanel.Visibility = Visibility.Visible;
        }

        private void Themes_Click(object sender, RoutedEventArgs e)
        {
            //панель тем
            TestsButton.Visibility = Visibility.Collapsed;
            MistakesButton.Visibility = Visibility.Collapsed;
            ThemesButton.Visibility = Visibility.Collapsed;
            SettingsButton.Visibility = Visibility.Collapsed;

            ThemePanel.Visibility = Visibility.Visible;
        }

        private void BackToMain_Click(object sender, RoutedEventArgs e)
        {
            //головне меню
            TestsButton.Visibility = Visibility.Visible;
            MistakesButton.Visibility = Visibility.Visible;
            ThemesButton.Visibility = Visibility.Visible;
            SettingsButton.Visibility = Visibility.Visible;

            TestButtonsPanel.Visibility = Visibility.Collapsed;
            ThemePanel.Visibility = Visibility.Collapsed;
        }

        private void Theme_Click(object sender, RoutedEventArgs e)
        {
            //тема
            var button = sender as System.Windows.Controls.Button;
            string topic = button.Content.ToString();

            var theoryWindow = new ThemeWindow(topic);
            theoryWindow.Show();
            this.Close();
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            //налаштування
            var settings = new SettingsWindow();
            settings.Show();
            this.Close();
        }
    }
}
