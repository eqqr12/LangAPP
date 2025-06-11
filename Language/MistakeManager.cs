public static class MistakeManager
{
    private static readonly List<WordPair> _mistakes = new();

    public static void AddMistake(WordPair pair)
    {
        if (!_mistakes.Any(m => m.Native == pair.Native && m.Foreign == pair.Foreign))
            _mistakes.Add(pair);
    }

    public static void RemoveMistake(WordPair pair)
    {
        _mistakes.RemoveAll(m => m.Native == pair.Native && m.Foreign == pair.Foreign);
    }

    public static List<WordPair> GetMistakes()
    {
        return _mistakes.ToList();
    }
}