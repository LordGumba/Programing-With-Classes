using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference reference;
    private List<Word> words;
    private List<Word> hiddenWords;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        this.words = text.Split(' ').Select(word => new Word(word)).ToList();
        this.hiddenWords = new List<Word>();
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(reference.ToString());
        foreach (Word word in words)
        {
            if (word.IsHidden)
                Console.Write("***** ");
            else
                Console.Write(word.Text + " ");
        }
        Console.WriteLine();
    }

    public bool HideRandomWord()
    {
        List<Word> visibleWords = words.Except(hiddenWords).ToList();
        if (visibleWords.Count == 0)
            return false;

        Random random = new Random();
        int index = random.Next(visibleWords.Count);
        Word wordToHide = visibleWords[index];
        wordToHide.IsHidden = true;
        hiddenWords.Add(wordToHide);
        return true;
    }

    public bool AllWordsHidden()
    {
        return words.All(word => word.IsHidden);
    }
}