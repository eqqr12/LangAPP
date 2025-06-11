using System.Collections.Generic;
using System.Windows;

namespace LanguageApp
{
    public partial class ResultsWindow : Window
    {
        public ResultsWindow(List<TestResult> results)
        {
            InitializeComponent();
            ResultsList.ItemsSource = results;
        }
    }
}
