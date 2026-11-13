public class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    // There is no 0 verse so use it as a check
    private int _verseEnd = 0;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verse;
    }

    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }

    public string GetDisplayText()
    {
        string displayText;

        if (_verseEnd != 0)
        {
            displayText = _book + " " + _chapter + ":" + _verseStart + "-" + _verseEnd;
        }
        else
        {
            displayText = _book + " " + _chapter + ":" + _verseStart;
        }

        return displayText;
    }
}