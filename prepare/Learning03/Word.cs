public class Word
{
    public string _text;
    public bool IsHidden;

    public word(string text)
    {
        Text = text;
        IsHidden = false;
    }
    public string GetDisplayText()
    {
        return IsHidden ? new string ('_', Text.Length) : Text;
    }
    public void Hide()
    {
        IsHidden = true;
    }
    public void Show()
    {
        IsShown = true;
    }
    
}