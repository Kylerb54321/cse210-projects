using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding.";
        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit:");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int? _verseEnd;

    public Reference(string book, int chapter, int verseStart)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = null;
    }

    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }

    public override string ToString()
    {
        if (_verseEnd.HasValue && _verseEnd != _verseStart)
        {
            return $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verseStart}";
        }
    }
}
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

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int count)
    {
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();
        if (visibleWords.Count == 0) return;

        Random rand = new Random();
        var wordsToHide = visibleWords.OrderBy(x => rand.Next()).Take(count);

        foreach (var word in wordsToHide)
        {
            word.Hide();
        }
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }

    public string GetDisplayText()
    {
        string wordsText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference}\n{wordsText}";
    }
}
