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
<<<<<<< HEAD
            var test = new MainWindow();
=======
            var test = new MainWindow(); // англ → укр
>>>>>>> adaf28d (second commit)
            test.Show();
            this.Close();
        }

        private void UkrToEng_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
            var test = new MainWindow(reverse: true);
=======
            var test = new MainWindow(reverse: true); // укр → англ
>>>>>>> adaf28d (second commit)
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
<<<<<<< HEAD
            TestsButton.Visibility = Visibility.Collapsed;
            MistakesButton.Visibility = Visibility.Collapsed;
            ThemesButton.Visibility = Visibility.Collapsed;
=======
            //панель тестів
            TestsButton.Visibility = Visibility.Collapsed;
            MistakesButton.Visibility = Visibility.Collapsed;
            ThemesButton.Visibility = Visibility.Collapsed;
            SettingsButton.Visibility = Visibility.Collapsed;

>>>>>>> adaf28d (second commit)
            TestButtonsPanel.Visibility = Visibility.Visible;
        }

        private void Themes_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
            TestsButton.Visibility = Visibility.Collapsed;
            MistakesButton.Visibility = Visibility.Collapsed;
            ThemesButton.Visibility = Visibility.Collapsed;
=======
            //панель тем
            TestsButton.Visibility = Visibility.Collapsed;
            MistakesButton.Visibility = Visibility.Collapsed;
            ThemesButton.Visibility = Visibility.Collapsed;
            SettingsButton.Visibility = Visibility.Collapsed;

>>>>>>> adaf28d (second commit)
            ThemePanel.Visibility = Visibility.Visible;
        }

        private void BackToMain_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
            TestsButton.Visibility = Visibility.Visible;
            MistakesButton.Visibility = Visibility.Visible;
            ThemesButton.Visibility = Visibility.Visible;
=======
            //головне меню
            TestsButton.Visibility = Visibility.Visible;
            MistakesButton.Visibility = Visibility.Visible;
            ThemesButton.Visibility = Visibility.Visible;
            SettingsButton.Visibility = Visibility.Visible;

>>>>>>> adaf28d (second commit)
            TestButtonsPanel.Visibility = Visibility.Collapsed;
            ThemePanel.Visibility = Visibility.Collapsed;
        }

        private void Theme_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
=======
            //тема
>>>>>>> adaf28d (second commit)
            var button = sender as System.Windows.Controls.Button;
            string topic = button.Content.ToString();

            var theoryWindow = new ThemeWindow(topic);
            theoryWindow.Show();
            this.Close();
        }
<<<<<<< HEAD
=======

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            //налаштування
            var settings = new SettingsWindow();
            settings.Show();
            this.Close();
        }
>>>>>>> adaf28d (second commit)
    }
}
