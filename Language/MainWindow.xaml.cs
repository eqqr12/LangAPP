using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;

namespace LanguageApp
{
    public partial class MainWindow : Window
    {
        private List<WordPair> _words;
        private int _currentIndex = 0;
        private int _correctCount = 0;
        private int _wrongCount = 0;

        public MainWindow()
        {
            InitializeComponent();
            StartTest();
        }
        private string Stem(string word)
        {
            word = word.ToLower().Trim();

            string[] endings = { "ти", "тися", "ють", "ати", "ити", "атися", "еться", "ий", "ій", "ею", "ою", "ого", "у", "ю", "е", "а", "і", "о", "є", "ї", "ь", "ю", "ем", "ам", "ом", "еві", "ені", "ене", "ені", "ами", "ями" };

            foreach (var ending in endings)
            {
                if (word.EndsWith(ending) && word.Length > ending.Length + 2)
                {
                    return word.Substring(0, word.Length - ending.Length);
                }
            }

            return word;
        }

        private bool _reverse; // true = укр → англ, false = англ → укр

        public MainWindow(bool reverse = false)
        {
            InitializeComponent();
            _reverse = reverse;
            StartTest();
        }

        private List<TestResult> _results = new();


        private void StartTest()
        {
            var allWords = WordService.GetWords();

            if (_reverse)
            {
                //укр → англ
                allWords = allWords.Select(w => new WordPair
                {
                    Native = w.Foreign,
                    Foreign = w.Native
                }).ToList();
            }

            //видаляємо дублікати за словом
            allWords = allWords
                .GroupBy(w => w.Native.Trim().ToLower())
                .Select(g => g.First())
                .ToList();

            _words = allWords.OrderBy(_ => Guid.NewGuid()).Take(20).ToList();

            _currentIndex = 0;
            _correctCount = 0;
            _wrongCount = 0;
            _results.Clear();

            RepeatButton.Visibility = Visibility.Collapsed;
            TranslationTextBox.Visibility = Visibility.Visible;
            CheckButton.Visibility = Visibility.Visible;
            DisplayNextWord();
        }

        private void DisplayNextWord()
        {
            if (_currentIndex < _words.Count)
            {
                WordTextBlock.Text = _words[_currentIndex].Native;
                TranslationTextBox.Clear();
                ResultTextBlock.Text = "";
                TranslationTextBox.Focus();
            }
            else
            {
                ShowFinalResult();
            }
        }

        private async void Check_Click(object sender, RoutedEventArgs e)
        {
            if (_currentIndex >= _words.Count) return;

            CheckButton.IsEnabled = false;

            string userInput = TranslationTextBox.Text.Trim().ToLower();
            string correctRaw = _words[_currentIndex].Foreign.ToLower();

            var correctAnswers = correctRaw
                .Split(new[] { ';', ',', '/' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(a => a.Trim().ToLower())
                .ToList();

            if (string.IsNullOrWhiteSpace(userInput))
            {
                ResultTextBlock.Text = $"❌ Неправильно. Правильно: {correctRaw}";
                _wrongCount++;
                MistakeManager.AddMistake(_words[_currentIndex]);
                _results.Add(new TestResult
                {
                    Native = _words[_currentIndex].Native,
                    CorrectAnswer = _words[_currentIndex].Foreign,
                    UserAnswer = userInput,
                    IsCorrect = false
                });

                await Task.Delay(1500);
                _currentIndex++;
                DisplayNextWord();
                CheckButton.IsEnabled = true;
                return;
            }

            string userStem = Stem(userInput);
            bool isCorrect = correctAnswers.Any(ans =>
                ans == userInput || Stem(ans) == userStem
            );

            if (isCorrect)
            {
                ResultTextBlock.Text = "✅ Правильно!";
                _correctCount++;
            }
            else
            {
                ResultTextBlock.Text = $"❌ Неправильно. Правильно: {correctRaw}";
                _wrongCount++;
                MistakeManager.AddMistake(_words[_currentIndex]);
            }

            _results.Add(new TestResult
            {
                Native = _words[_currentIndex].Native,
                CorrectAnswer = _words[_currentIndex].Foreign,
                UserAnswer = userInput,
                IsCorrect = isCorrect
            });

            await Task.Delay(1500);
            _currentIndex++;
            DisplayNextWord();
            CheckButton.IsEnabled = true;
        }

        private void ShowFinalResult()
        {
            WordTextBlock.Text = "Результат:";
            TranslationTextBox.Visibility = Visibility.Collapsed;
            CheckButton.Visibility = Visibility.Collapsed;
            ResultTextBlock.Text = $"Правильних: {_correctCount} | Неправильних: {_wrongCount}";
            RepeatButton.Visibility = Visibility.Visible;
            ShowResultsButton.Visibility = Visibility.Visible;
        }

        private void ShowResults_Click(object sender, RoutedEventArgs e)
        {
            ResultsGrid.ItemsSource = _results;
            ResultsGrid.Visibility = Visibility.Visible;
            ShowResultsButton.Visibility = Visibility.Collapsed;
        }


        private void Repeat_Click(object sender, RoutedEventArgs e)
        {
            StartTest();
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            var menu = new MainMenu();
            menu.Show();
            this.Close();
        }
    }
}
