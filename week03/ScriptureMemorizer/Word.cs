public class Word
{
    // Declare member variables:
    private string _text;
    private bool _IsHidden;

    // Declare Constructor:
    public Word(string text)
    {
        // Initialize the _text with the passed-in text parameter:
        _text = text;
        // At the start of the program, the word is visible:
        _IsHidden = false;
    }

    // Declare methods of the Word class:
    // This method is used to hide a word:
    public void Hide()
    {
        _IsHidden = true;

    }

    // This method is used to show a hidden word:
    public void Show()
    {
        _IsHidden = false;

    }

    // This method is use to show the state of the word (whether it is hidden or not):
    public bool IsHidden()
    {
        // returns true or faalse
        return _IsHidden;
    }

    // This method is use to check the value of the 
    // IsHidden method above:
    public string GetDisplayText()
    {
        // Write conditions:
        if (_IsHidden)
        {
            // If the condtion is "true", returns a string of underscores with the same length as the original word:
            return new string('_', _text.Length);
        }
        else
        {
            // If the condition is false, it rewturns the original word:
            return _text;
        }
    }
}


