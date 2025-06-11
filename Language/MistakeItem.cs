using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageApp
{
    public class MistakeItem
    {
        public WordPair Pair { get; set; }
        public bool IsChecked { get; set; } = false;
        public bool IsCorrect { get; set; } = false;
        public string Feedback { get; set; } = "";
    }

}
