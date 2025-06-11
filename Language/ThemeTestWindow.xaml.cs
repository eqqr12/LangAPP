using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace LanguageApp
{
    public partial class ThemeTestWindow : Window
    {
        private class Question
        {
            public string Text { get; set; }
            public List<string> Options { get; set; }
            public int CorrectIndex { get; set; }
        }

        private List<Question> _questions;
        private int _currentIndex = 0;
        private int _score = 0;

        public ThemeTestWindow(string topic)
        {
            InitializeComponent();
            _questions = GetQuestions(topic);
            ShowQuestion();
        }

        private List<Question> Random3(List<Question> all)
        {
            return all.OrderBy(_ => Guid.NewGuid()).Take(3).ToList();
        }

        private List<Question> GetQuestions(string topic)
        {
            if (topic.ToLower().Contains("множина"))
            {
                var all = new List<Question>
        {
            new Question { Text = "Як утворюється множина слова 'box'?", Options = new() { "boxs", "boxies", "boxes", "boxen" }, CorrectIndex = 2 },
            new Question { Text = "Правильна множина слова 'baby'?", Options = new() { "babyes", "babys", "babies", "babes" }, CorrectIndex = 2 },
            new Question { Text = "Множина слова 'man' — це?", Options = new() { "mans", "men", "mens", "manes" }, CorrectIndex = 1 },
            new Question { Text = "Множина слова 'knife'?", Options = new() { "knifes", "knive", "knives", "knifes'" }, CorrectIndex = 2 },
            new Question { Text = "Яка з форм неправильна?", Options = new() { "dogs", "cats", "mices", "horses" }, CorrectIndex = 2 },
            new Question { Text = "Що з переліченого незмінне в множині?", Options = new() { "deer", "dog", "foot", "man" }, CorrectIndex = 0 },
            new Question { Text = "Як утворюється множина слова 'bus'?", Options = new() { "buses", "buss", "busses", "buzz" }, CorrectIndex = 0 },
            new Question { Text = "Слово з однаковою формою в однині та множині?", Options = new() { "fish", "books", "boy", "man" }, CorrectIndex = 0 },
            new Question { Text = "Множина слова 'person'?", Options = new() { "people", "persons", "peoples", "persones" }, CorrectIndex = 0 },
            new Question { Text = "Множина слова 'hero'?", Options = new() { "heros", "heroes", "heroen", "heroies" }, CorrectIndex = 1 },
            new Question { Text = "Множина слова 'tomato'?", Options = new() { "tomatos", "tomatoes", "tomatoen", "tomats" }, CorrectIndex = 1 },
            new Question { Text = "Множина слова 'child'?", Options = new() { "childs", "children", "childes", "childer" }, CorrectIndex = 1 }
        };

                return Random3(all);
            }

            if (topic.ToLower().Contains("час"))
            {
                var all = new List<Question>
        {
            new Question { Text = "Який час: 'I am eating'?", Options = new() { "Present Simple", "Present Continuous", "Present Perfect", "Past Simple" }, CorrectIndex = 1 },
            new Question { Text = "Що означає 'I had gone'?", Options = new() { "Past Perfect", "Past Simple", "Future Perfect", "Present Perfect" }, CorrectIndex = 0 },
            new Question { Text = "Для чого використовується Present Perfect?", Options = new() { "Для дії в минулому", "Для нещодавно завершеної дії", "Для майбутнього", "Для звички" }, CorrectIndex = 1 },
            new Question { Text = "Формула Present Simple?", Options = new() { "Subject + V", "Subject + was/were + Ving", "Subject + have/has + V3", "Subject + will + V" }, CorrectIndex = 0 },
            new Question { Text = "Який час в реченні: 'He will be working tomorrow'?", Options = new() { "Future Simple", "Future Perfect", "Future Continuous", "Present Continuous" }, CorrectIndex = 2 },
            new Question { Text = "В якому часі 'I go to school every day'?", Options = new() { "Present Simple", "Present Perfect", "Past Simple", "Future Simple" }, CorrectIndex = 0 },
            new Question { Text = "Як утворити Past Simple для правильного дієслова?", Options = new() { "додати -s", "додати -ed", "додати -ing", "додати had" }, CorrectIndex = 1 },
            new Question { Text = "Що таке continuous?", Options = new() { "Минулий", "Простий", "Тривалий", "Майбутній" }, CorrectIndex = 2 },
            new Question { Text = "Що означає 'has been done'?", Options = new() { "Past Simple", "Present Perfect Passive", "Future Perfect", "Past Perfect" }, CorrectIndex = 1 },
            new Question { Text = "В якому часі 'They had finished work'?", Options = new() { "Past Perfect", "Present Simple", "Future Simple", "Present Perfect" }, CorrectIndex = 0 },
            new Question { Text = "Which tense uses 'will have + V3'?", Options = new() { "Present Perfect", "Future Perfect", "Past Perfect", "Present Simple" }, CorrectIndex = 1 },
            new Question { Text = "Речення: 'I will study' — це:", Options = new() { "Future Simple", "Present Simple", "Past Continuous", "Future Perfect" }, CorrectIndex = 0 }
        };

                return Random3(all);
            }

            if (topic.ToLower().Contains("модаль"))
            {
                var all = new List<Question>
        {
            new Question { Text = "Що означає модальне дієслово 'must'?", Options = new() { "Дозвіл", "Обов'язок", "Ймовірність", "Порада" }, CorrectIndex = 1 },
            new Question { Text = "Яке з цих слів є модальним?", Options = new() { "like", "go", "can", "run" }, CorrectIndex = 2 },
            new Question { Text = "Як перекладається 'may'?", Options = new() { "мабуть", "можливо", "може", "повинен" }, CorrectIndex = 2 },
            new Question { Text = "Модальне 'should' — це:", Options = new() { "можливість", "необхідність", "порада", "дозвіл" }, CorrectIndex = 2 },
            new Question { Text = "'Can' вживається для вираження:", Options = new() { "дозволу та можливості", "заборони", "майбутнього", "обов’язку" }, CorrectIndex = 0 },
            new Question { Text = "'Mustn't' означає:", Options = new() { "не потрібно", "не можеш", "не можна", "не вміє" }, CorrectIndex = 2 },
            new Question { Text = "'Could' — це форма модального дієслова для:", Options = new() { "теперішнього", "майбутнього", "минулого", "заперечення" }, CorrectIndex = 2 },
            new Question { Text = "Що таке 'shall'?", Options = new() { "ввічлива порада", "запитання", "майбутнє зобов'язання", "наказ" }, CorrectIndex = 2 },
            new Question { Text = "Яке з модальних дієслів найввічливіше?", Options = new() { "can", "must", "might", "could" }, CorrectIndex = 3 },
            new Question { Text = "'Ought to' — це:", Options = new() { "синонім до should", "майбутнє", "дозвіл", "сумнів" }, CorrectIndex = 0 },
            new Question { Text = "Яке з речень містить модальне дієслово?", Options = new() { "I run fast", "I can swim", "She is tall", "We went to school" }, CorrectIndex = 1 },
            new Question { Text = "Модальне 'may' вживається для:", Options = new() { "дозволу та ймовірності", "обов'язку", "впевненості", "відмови" }, CorrectIndex = 0 }
        };

                return Random3(all);
            }

            return new List<Question>();
        }
        private void ShowQuestion()
        {
            if (_currentIndex >= _questions.Count)
            {
                MessageBox.Show($"Тест завершено! Правильних відповідей: {_score}/{_questions.Count}", "Результат");
                var menu = new MainMenu();
                menu.Show();
                this.Close();
                return;
            }

            var q = _questions[_currentIndex];
            QuestionText.Text = q.Text;
            AnswerPanel.Children.Clear();

            for (int i = 0; i < q.Options.Count; i++)
            {
                var radio = new RadioButton
                {
                    Content = q.Options[i],
                    Tag = i,
                    GroupName = "Answers",
                    FontSize = 16,
                    Margin = new Thickness(5)
                };
                AnswerPanel.Children.Add(radio);
            }
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            ((Button)sender).IsEnabled = false;

            var selected = AnswerPanel.Children.OfType<RadioButton>().FirstOrDefault(r => r.IsChecked == true);
            if (selected != null)
            {
                int selectedIndex = (int)selected.Tag;
                if (selectedIndex == _questions[_currentIndex].CorrectIndex)
                    _score++;
            }

            var fadeOut = new DoubleAnimation(1, 0, TimeSpan.FromMilliseconds(400));
            fadeOut.Completed += (s, _) =>
            {
                _currentIndex++;

                if (_currentIndex >= _questions.Count)
                {
                    ShowFinalResult();
                    return;
                }

                ShowQuestion();

                var fadeIn = new DoubleAnimation(0, 1, TimeSpan.FromMilliseconds(400));
                MainPanel.BeginAnimation(OpacityProperty, fadeIn);
                ((Button)sender).IsEnabled = true;
            };

            MainPanel.BeginAnimation(OpacityProperty, fadeOut);
        }

        private void ShowFinalResult()
        {
            MainPanel.Visibility = Visibility.Collapsed;
            ResultPanel.Visibility = Visibility.Visible;

            string verdict = "";

            double ratio = (double)_score / _questions.Count;
            if (ratio == 1)
                verdict = "✅ Відмінно!";
            else if (ratio >= 0.66)
                verdict = "👍 Добре!";
            else
                verdict = "📘 Ще попрацюй.";

            ResultText.Text = $"{verdict}\nПравильних: {_score} із {_questions.Count}";
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            var menu = new MainMenu();
            menu.Show();
            this.Close();
        }

    }
}
