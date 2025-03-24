using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;


public class Scripture
{
    // Declare member variables:
    private Reference _reference;
    private List<Word> _words;

    // Create Constructor:
    public Scripture(Reference reference, string text)
    {
        // Store the reference:
        _reference = reference;

        // Store words as word objects
        //Declare an empty list:
        _words = new List<Word>();
        // Split the text into words
        string[] wordsArray = text.Split(' ');
        // loop through the words array
        foreach (string word in wordsArray)
        {
            // Create an instance of the word object
            Word wordobj = new Word(word);
            // Append wordobj to the words array list
            _words.Add(wordobj);
        }
    }

    // Write a method to hide random words:
    public void HideRandomWords(int numberToHide)
    {
        // Create an instance of the Random class:
        Random random = new Random();
        // Create an empty list to hold random words
        List<Word> visibleWords = new List<Word>();
        // Loop thrugh each word:
        foreach (Word word in _words)
        {
            // Check if the word is not hidden:
            if (!word.IsHidden())
            {
                // add word to the list:
                visibleWords.Add(word);
            }
        }
        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            // Ensure we don't hide the word twice
            visibleWords.RemoveAt(index); 
        }
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        // Create an empty list to store word display text:
        List<String> wordTexts = new List<string>();
        //Loop through _words and display text:
        foreach (Word word in _words)
        {
            string displayText = word.GetDisplayText();
            wordTexts.Add(displayText);
        }
        //Manually join the words into a single string with spaces:
        string scriptureText = "";

        for (int i = 0; i < wordTexts.Count; i++)
        {
            // Append word
            scriptureText += wordTexts[i];

            if (i < wordTexts.Count - 1)
            {
                scriptureText += " ";
            }
        }
        return $"{referenceText} {scriptureText}";
    }


    public bool IsCompletelyHidden()
    {
        // Assume the _words is a list object:
        bool isAllHidden = true;
        //Loop through eacn word in the _words:
        foreach (Word word in _words)
        {
            // Check if the current word is not hidden:
            if (!word.IsHidden())
            {
                // If word is not hidden, set
                //  isAllHidden to false and braak
                //  out of the loop:
                isAllHidden = false;
                // No need to check further if we
                //  already found a visible word
                break;
            }
            
        }
        return isAllHidden;
    }
}