using System;
using System.Collections.Generic;

public class ListingActivity : MindfulnessActivity
{
    private static readonly string[] Prompts =
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who have you helped this week?",
        "When have you felt peace recently?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() 
        : base("Listing Activity", 
               "This activity helps you reflect on the good in your life by listing items.") { }

    protected override void PerformActivity()
    {
        Console.WriteLine($"\nPrompt: {GetRandomItem(Prompts)}");
        Console.WriteLine("Start listing items. Press Enter after each one.");
        Countdown(5);

        int count = 0;
        DateTime end = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < end)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items!");
    }

    private string GetRandomItem(string[] items)
    {
        Random rand = new Random();
        return items[rand.Next(items.Length)];
    }
}
