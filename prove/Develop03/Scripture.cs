using System.Globalization;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;

        _words = new List<Word>();
        string [] splitWords = text.Split(" ");

        foreach (string w in splitWords)
        {
            Word aWord = new Word(w);
            _words.Add(aWord);
        } 
    }

    public void HideRandomWords(int numberToHide)
    {

    }

    public string GetDisplayText()
    {
        return "";
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }
}