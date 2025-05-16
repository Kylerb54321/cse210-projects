using System;

public class Entry
{
    public string Date { get; }
    public string PromptText { get; }
    public string EntryText { get; }

    public Entry(string date, string promptText, string entryText)
    {
        Date = date;
        PromptText = promptText;
        EntryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {PromptText}");
        Console.WriteLine($"Entry: {EntryText}");
        Console.WriteLine();
    }

    public string ToFileFormat()
    {
        return $"{Date}|{PromptText}|{EntryText}";
    }

    public static Entry FromFileFormat(string line)
    {
        string[] parts = line.Split('|');
        if (parts.Length == 3)
        {
            return new Entry(parts[0], parts[1], parts[2]);
        }
        else
        {
            return null;
        }
    }
}
