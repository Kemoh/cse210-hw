using System.ComponentModel.DataAnnotations;

public class Reference
{
    // Declare member variables:
    private string _book; // Holds the name of the book
    private int _chapter; // Holds the chapter number
    private int _verse; // Holds the strating verse num
    private int _endVerse; // Holds the end verse num

    // Declare the constructors:
    // Constructor for a Single Verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        // _endVerse = null; // No end verse for a single verse reference
    }

    // Constructor for number of verses
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;

    }

    // Declare methods:
    public string GetDisplayText()
    {
        if (_endVerse > _verse)
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}";
        }
       
    }
}