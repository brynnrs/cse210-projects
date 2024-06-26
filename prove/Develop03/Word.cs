public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }
    
    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        if (_isHidden == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetDisplayText()
    {
        string underscores = "";

        if (_isHidden == false)
        {
            return _text;
        }
        else
        {
            for (int i = 0; i <_text.Length; i++)
            {
                underscores += "_";
            }
            return underscores;
        }
    }
}