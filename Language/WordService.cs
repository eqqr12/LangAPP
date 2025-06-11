using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;

namespace LanguageApp
{
    public static class WordService
    {
        public static List<WordPair> GetWords()
        {
            string path = "dictionary.csv";

            if (!File.Exists(path))
            {
                MessageBox.Show($"Файл не знайдено за шляхом:\n{Path.GetFullPath(path)}", "Файл не знайдено", MessageBoxButton.OK, MessageBoxImage.Error);
                return new List<WordPair>();
            }

            var allWords = DictionaryLoader.LoadFromCsv(path);

            if (allWords.Count == 0)
            {
                MessageBox.Show("Файл знайдено, але не вдалося зчитати жодного слова.", "Порожній список", MessageBoxButton.OK, MessageBoxImage.Warning);
                return new List<WordPair>();
            }

            //аидалення дублікату
            var distinctWords = allWords
                .GroupBy(w => w.Native.Trim().ToLower())
                .Select(g => g.First())
                .ToList();

            var random = new Random();
            return distinctWords.OrderBy(_ => random.Next()).Take(20).ToList();
        }
    }
}
