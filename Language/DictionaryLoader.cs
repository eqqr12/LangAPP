using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace LanguageApp
{
    public static class DictionaryLoader
    {
        public static List<WordPair> LoadFromCsv(string filePath)
        {
            var list = new List<WordPair>();

            foreach (var line in File.ReadLines(filePath))
            {
<<<<<<< HEAD
                // ігноруємо порожні рядки
=======
>>>>>>> adaf28d (second commit)
                if (string.IsNullOrWhiteSpace(line)) continue;

                var parts = line.Split(',');

                if (parts.Length >= 2)
                {
                    string eng = parts[0].Trim();
                    string ukr = parts[1].Trim();

<<<<<<< HEAD
                    // базова перевірка, чи обидва слова мають зміст
=======
>>>>>>> adaf28d (second commit)
                    if (!string.IsNullOrWhiteSpace(eng) && !string.IsNullOrWhiteSpace(ukr))
                    {
                        list.Add(new WordPair
                        {
                            Native = eng,
                            Foreign = ukr
                        });
                    }
                }
            }
<<<<<<< HEAD

=======
>>>>>>> adaf28d (second commit)
            return list;
        }
    }
}
