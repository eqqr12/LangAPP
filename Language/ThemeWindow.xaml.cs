using System.Windows;

namespace LanguageApp
{
    public partial class ThemeWindow : Window
    {
        public ThemeWindow(string topic)
        {
            InitializeComponent();
            ShowTheory(topic);
        }

        private void ShowTheory(string topic)
        {
            switch (topic.ToLower())
            {
                case "множина іменників":
                    TheoryText.Text = "📘 Множина іменників (Plural Nouns)\n\n" +
                        "Множина іменників в англійській мові вказує на те, що об’єктів більше одного. Найчастіше її утворюють додаванням -s або -es до іменника в однині. Проте існує низка винятків і особливих випадків.\n\n" +

                        "🔹 1. Стандартне утворення множини:\n" +
                        "   Додаємо -s:\n" +
                        "   - dog → dogs\n" +
                        "   - book → books\n" +
                        "   - car → cars\n\n" +

                        "🔹 2. Додаємо -es, якщо слово закінчується на:\n" +
                        "   -s, -ss, -sh, -ch, -x, -z, -o:\n" +
                        "   - bus → buses\n" +
                        "   - box → boxes\n" +
                        "   - tomato → tomatoes\n" +
                        "   - church → churches\n\n" +

                        "🔹 3. Заміна -y на -ies:\n" +
                        "   Якщо перед -y стоїть приголосна:\n" +
                        "   - baby → babies\n" +
                        "   - party → parties\n\n" +
                        "   Якщо перед -y стоїть голосна, додається просто -s:\n" +
                        "   - toy → toys\n" +
                        "   - key → keys\n\n" +

                        "🔹 4. Заміна -f або -fe на -ves:\n" +
                        "   - knife → knives\n" +
                        "   - wife → wives\n" +
                        "   - leaf → leaves\n\n" +

                        "🔹 5. Неправильні множини:\n" +
                        "   Ці форми необхідно вивчити напам’ять:\n" +
                        "   - man → men\n" +
                        "   - woman → women\n" +
                        "   - child → children\n" +
                        "   - tooth → teeth\n" +
                        "   - foot → feet\n" +
                        "   - mouse → mice\n" +
                        "   - person → people\n\n" +

                        "🔹 6. Незмінні форми:\n" +
                        "   Деякі слова мають однакову форму в однині та множині:\n" +
                        "   - sheep → sheep\n" +
                        "   - deer → deer\n" +
                        "   - series → series\n" +
                        "   - species → species\n\n" +

                        "🔹 7. Множина складених іменників:\n" +
                        "   - mother-in-law → mothers-in-law\n" +
                        "   - passer-by → passers-by\n\n" +

                        "🧠 Порада: завжди перевіряйте множину іменника у словнику, якщо не впевнені.";
                    break;

                case "часи дієслів":
                    TheoryText.Text = "📘 Часи дієслів (Verb Tenses)\n\n" +
                        "Англійська мова має 12 основних дієслівних часів, які поділяються на 3 основні часові категорії: Present (теперішній), Past (минулий) та Future (майбутній). Кожна з них включає чотири аспекти: Simple, Continuous, Perfect, Perfect Continuous.\n\n" +

                        "🔸 PRESENT TENSES (Теперішній час):\n" +
                        "• Present Simple: I work.\n" +
                        "   → Дії, що повторюються: I go to school every day.\n" +
                        "• Present Continuous: I am working.\n" +
                        "   → Дії, що відбуваються саме зараз: I am writing now.\n" +
                        "• Present Perfect: I have worked.\n" +
                        "   → Дії, що вже відбулись, але мають значення зараз: I have already eaten.\n" +
                        "• Present Perfect Continuous: I have been working.\n" +
                        "   → Дії, що почались у минулому і тривають донині: I have been studying for 3 hours.\n\n" +

                        "🔸 PAST TENSES (Минулий час):\n" +
                        "• Past Simple: I worked.\n" +
                        "   → Завершені дії в минулому: I visited Paris last year.\n" +
                        "• Past Continuous: I was working.\n" +
                        "   → Дії, що тривали в певний момент у минулому: I was reading when she called.\n" +
                        "• Past Perfect: I had worked.\n" +
                        "   → Дії, що завершились до іншої минулої події: I had left before the rain started.\n" +
                        "• Past Perfect Continuous: I had been working.\n" +
                        "   → Тривалість дії до певного моменту в минулому: I had been waiting for an hour before the bus came.\n\n" +

                        "🔸 FUTURE TENSES (Майбутній час):\n" +
                        "• Future Simple: I will work.\n" +
                        "   → Обіцянки, передбачення: I will call you tomorrow.\n" +
                        "• Future Continuous: I will be working.\n" +
                        "   → Дія у процесі в майбутньому: This time tomorrow I will be flying.\n" +
                        "• Future Perfect: I will have worked.\n" +
                        "   → Завершення дії до певного моменту в майбутньому: By 5 p.m. I will have finished.\n" +
                        "• Future Perfect Continuous: I will have been working.\n" +
                        "   → Тривалість дії до моменту в майбутньому: By next month I will have been working here for 5 years.\n\n" +
                        "🧠 Порада: не намагайтеся вивчити всі часи одразу — почніть із Simple та розширюйте знання поступово.";
                    break;

                case "модальні дієслова":
                    TheoryText.Text = "📘 Модальні дієслова (Modal Verbs)\n\n" +
                        "Модальні дієслова (can, must, should тощо) використовуються для вираження можливості, обов'язку, дозволу, ймовірності та інших відтінків значення.\n" +
                        "Вони завжди вживаються з основною формою дієслова (без 'to').\n\n" +

                        "🔸 Основні модальні дієслова:\n" +
                        "• can — можливість, вміння: I can swim.\n" +
                        "• could — минула можливість або ввічлива форма: Could you help me?\n" +
                        "• may — дозвіл або ймовірність: You may go now.\n" +
                        "• might — слабка ймовірність: It might rain.\n" +
                        "• must — необхідність, сильний обов'язок: You must stop.\n" +
                        "• shall — пропозиція або обіцянка: Shall we begin?\n" +
                        "• should — порада або слабкий обов'язок: You should rest.\n" +
                        "• will — майбутність, воля: I will call you.\n" +
                        "• would — ввічливість, умовність: I would like a cup of tea.\n\n" +

                        "🔸 Особливості використання:\n" +
                        "• модальні дієслова не змінюються за особами:\n" +
                        "   I can / He can (НЕ 'He cans')\n" +
                        "• після них дієслово без to: can go, should stay\n" +
                        "• для минулого часто вживають конструкції:\n" +
                        "   should have done, could have gone, might have said\n\n";
                    break;

                default:
                    TheoryText.Text = "❗ Теорія для цієї теми ще не додана.";
                    break;
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            var menu = new MainMenu();
            menu.Show();
            this.Close();
        }
    }
}
