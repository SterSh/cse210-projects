public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;
    private Random _random = new Random();

    public Scripture(string scripture, Reference reference)
    {
        _reference = reference;

        string[] words = scripture.Split(" ");

        foreach (string word in words)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        List<Word> remainingWords = new List<Word>();

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                remainingWords.Add(word);
            }
        }

        int wordsToHide = Math.Min(remainingWords.Count, numberToHide);

        for (int i = 0; i < wordsToHide; i++)
        {
            int number = _random.Next(0, remainingWords.Count);
            remainingWords[number].Hide();
            remainingWords.RemoveAt(number);
        }
    }

    public void ShowRandomWord()
    {
        List<Word> hiddenWords = new List<Word>();

        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                hiddenWords.Add(word);
            }
        }

        if (hiddenWords.Count > 0)
        {
            int index = _random.Next(0, hiddenWords.Count);
            hiddenWords[index].Show();
            hiddenWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string scriptureText = "";

        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }

        string completeText = referenceText + " " + scriptureText;

        return completeText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
