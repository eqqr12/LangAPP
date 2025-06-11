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
                if (string.IsNullOrWhiteSpace(line)) continue;

                var parts = line.Split(',');

                if (parts.Length >= 2)
                {
                    string eng = parts[0].Trim();
                    string ukr = parts[1].Trim();

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
            return list;
        }
    }
}
