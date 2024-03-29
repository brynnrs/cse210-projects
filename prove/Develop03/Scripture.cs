using System.Globalization;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private List<int> numberDeck; 

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
        numberDeck = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            numberDeck.Add(i);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        if(numberToHide >= numberDeck.Count){
            for(int i = 0; i< _words.Count; i++)
            {
                _words[i].Hide();
            }
        }
        else{
            Random randomGenerator = new Random();

            for (int i = 0; i < numberToHide; i++)
            {
                int wordToHideIndex = numberDeck[randomGenerator.Next(numberDeck.Count)];
                numberDeck.Remove(wordToHideIndex);
                _words[wordToHideIndex].Hide();
            }

        }
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