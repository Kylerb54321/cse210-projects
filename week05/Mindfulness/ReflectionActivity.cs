using System;
using System.Collections.Generic;

public class ReflectionActivity : MindfulnessActivity
{
    private static readonly string[] Prompts =
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static readonly string[] Questions =
    {
        "Why was this experience meaningful to you?",
        "How did you get started?",
        "What did you learn about yourself?",
        "What made this time different?",
        "How can you apply this to the future?"
    };

    public ReflectionActivity() 
        : base("Reflection Activity", 
               "This activity helps you reflect on moments of strength and resilience.") { }

    protected override void PerformActivity()
    {
        Console.WriteLine($"\nPrompt: {GetRandomItem(Prompts)}\n");
        DateTime end = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < end)
        {
            Console.WriteLine(GetRandomItem(Questions));
            ShowSpinner(5);
        }
    }

    private string GetRandomItem(string[] items)
    {
        Random rand = new Random();
        return items[rand.Next(items.Length)];
    }
}
