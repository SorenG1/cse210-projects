using System;
using System.Collections.Generic;

public class Scripture
{
    // Private variables to store the reference and words
    private Reference _reference;
    private List<Word> _words;

    // Constructor to create a scripture with reference and text
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split the text into individual words and create Word objects
        string[] wordList = text.Split(' ');
        foreach (string wordText in wordList)
        {
            Word newWord = new Word(wordText);
            _words.Add(newWord);
        }
    }

    // Method to hide a few random words
    public void HideRandomWords(int numberToHide)
    {
        Random randomPicker = new Random();
        
        for (int i = 0; i < numberToHide; i++)
        {
            // Pick a random word index
            int randomIndex = randomPicker.Next(_words.Count);
            
            // Hide the word at that index
            _words[randomIndex].Hide();
        }
    }

    // Method to get the display text for the whole scripture
    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " ";
        
        // Add each word to the display text
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        
        return displayText;
    }

    // Check if all words are hidden
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                // Found a word that's not hidden
                return false;
            }
        }

        // All words are hidden
        return true;
    }
}
