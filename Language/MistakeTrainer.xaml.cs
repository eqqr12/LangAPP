using System.Windows;
<<<<<<< HEAD
using LanguageApp;

public partial class MistakeTrainer : Window
{
    private List<MistakeItem> _items;
    private int _index = 0;

    public MistakeTrainer()
    {
        InitializeComponent();

        _items = MistakeManager.GetMistakes()
            .Select(pair => new MistakeItem { Pair = pair })
            .ToList();

        if (_items.Count == 0)
        {
            ShowCompletionPanel();
            return;
        }

        DisplayCurrent();
    }

    private void DisplayCurrent()
    {
        if (_items.Count == 0)
        {
            ShowCompletionPanel();
            return;
        }

        var item = _items[_index];
        CurrentWord.Text = item.Pair.Native;
        AnswerBox.Text = "";
        Feedback.Text = item.Feedback;
        AnswerBox.IsEnabled = !item.IsChecked;
        CheckButton.IsEnabled = !item.IsChecked;
    }

    private async void Check_Click(object sender, RoutedEventArgs e)
    {
        var item = _items[_index];

        if (item.IsChecked)
            return;

        string user = AnswerBox.Text.Trim().ToLower();
        string correct = item.Pair.Foreign.ToLower();

        var correctAnswers = correct
            .Split(new[] { ';', ',', '/' }, System.StringSplitOptions.RemoveEmptyEntries)
            .Select(a => a.Trim().ToLower())
            .ToList();

        string userStem = Stem(user);

        bool isCorrect = correctAnswers.Any(ans =>
            ans == user ||
            ans.Contains(user) ||
            user.Contains(ans) ||
            Stem(ans) == userStem ||
            Stem(ans).Contains(userStem) ||
            userStem.Contains(Stem(ans))
        );

        item.IsChecked = true;
        item.IsCorrect = isCorrect;

        if (isCorrect)
        {
            Feedback.Text = "✅ Правильно!";
            await Task.Delay(1500);

            MistakeManager.RemoveMistake(item.Pair);
            _items.RemoveAt(_index);

            if (_index >= _items.Count) _index = 0;
        }
        else
        {
            item.Feedback = $"❌ Неправильно. Правильно: {correct}";
            Feedback.Text = item.Feedback;
            await Task.Delay(1500);
            _index = (_index + 1) % _items.Count;
        }

        DisplayCurrent();
    }

    private void Next_Click(object sender, RoutedEventArgs e)
    {
        if (_items.Count == 0) return;
        _index = (_index + 1) % _items.Count;
        DisplayCurrent();
    }

    private void Prev_Click(object sender, RoutedEventArgs e)
    {
        if (_items.Count == 0) return;
        _index = (_index - 1 + _items.Count) % _items.Count;
        DisplayCurrent();
    }

    private void Menu_Click(object sender, RoutedEventArgs e)
    {
        var menu = new MainMenu();
        menu.Show();
        this.Close();
    }

    private void ShowCompletionPanel()
    {
        TrainerPanel.Visibility = Visibility.Collapsed;
        CompletionPanel.Visibility = Visibility.Visible;
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
}

public class MistakeItem
{
    public WordPair Pair { get; set; }
    public bool IsChecked { get; set; } = false;
    public bool IsCorrect { get; set; } = false;
    public string Feedback { get; set; } = "";
=======
using System.Windows.Media;

namespace LanguageApp
{
    public partial class MistakeTrainer : Window
    {
        public class MistakeItem
        {
            public WordPair Pair { get; set; }
            public bool IsChecked { get; set; } = false;
            public bool IsCorrect { get; set; } = false;
            public string Feedback { get; set; } = "";
        }

        private List<MistakeItem> _items;
        private int _index = 0;

        public MistakeTrainer()
        {
            InitializeComponent();

            _items = MistakeManager.GetMistakes()
                .Select(pair => new MistakeItem { Pair = pair })
                .ToList();

            if (_items.Count == 0)
            {
                ShowCompletionPanel();
                return;
            }

            DisplayCurrent();
        }

        private void DisplayCurrent()
        {
            if (_items.Count == 0)
            {
                ShowCompletionPanel();
                return;
            }

            var item = _items[_index];
            CurrentWord.Text = item.Pair.Native;
            AnswerBox.Text = "";
            Feedback.Text = item.Feedback;
            AnswerBox.IsEnabled = !item.IsChecked;
            CheckButton.IsEnabled = !item.IsChecked;
        }

        private async void Check_Click(object sender, RoutedEventArgs e)
        {
            var item = _items[_index];

            if (item.IsChecked)
                return;

            string user = AnswerBox.Text.Trim().ToLower();
            string correct = item.Pair.Foreign.ToLower();

            var correctAnswers = correct
                .Split(new[] { ';', ',', '/' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(a => a.Trim().ToLower())
                .ToList();

            string userStem = Stem(user);

            bool isCorrect = correctAnswers.Any(ans =>
                ans == user ||
                ans.Contains(user) ||
                user.Contains(ans) ||
                Stem(ans) == userStem ||
                Stem(ans).Contains(userStem) ||
                userStem.Contains(Stem(ans))
            );

            item.IsChecked = true;
            item.IsCorrect = isCorrect;

            if (isCorrect)
            {
                Feedback.Text = "✅ Правильно!";
                MainPanel.Background = new SolidColorBrush(Colors.ForestGreen);
                await Task.Delay(1500);

                MistakeManager.RemoveMistake(item.Pair);
                _items.RemoveAt(_index);

                if (_index >= _items.Count) _index = 0;
            }
            else
            {
                item.Feedback = $"❌ Неправильно. Правильно: {correct}";
                Feedback.Text = item.Feedback;
                MainPanel.Background = new SolidColorBrush(Colors.IndianRed);
                await Task.Delay(1500);
                _index = (_index + 1) % _items.Count;
            }

            MainPanel.Background = (Brush)Application.Current.Resources["BackgroundColor"];

            DisplayCurrent();
        }


        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (_items.Count == 0) return;
            _index = (_index + 1) % _items.Count;
            DisplayCurrent();
        }

        private void Prev_Click(object sender, RoutedEventArgs e)
        {
            if (_items.Count == 0) return;
            _index = (_index - 1 + _items.Count) % _items.Count;
            DisplayCurrent();
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            var menu = new MainMenu();
            menu.Show();
            this.Close();
        }

        private void ShowCompletionPanel()
        {
            CompletionPanel.Visibility = Visibility.Visible;
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
    }
>>>>>>> adaf28d (second commit)
}