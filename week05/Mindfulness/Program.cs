using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option (1–4): ");
            
            switch (Console.ReadLine())
            {
                case "1":
                    new BreathingActivity().StartActivity();
                    break;
                case "2":
                    new ReflectionActivity().StartActivity();
                    break;
                case "3":
                    new ListingActivity().StartActivity();
                    break;
                case "4":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    Thread.Sleep(1000);
                    break;
            }
        }
    }
}
