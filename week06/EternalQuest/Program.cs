using System;

class Program
{
    static void Main()
    {
        GoalManager manager = new();
        string file = "goals.txt";

        while (true)
        {
            Console.WriteLine("\nEternal Quest Menu:");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Quit");
            Console.Write("Choose an option: ");

            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.Write("Enter goal type (simple, eternal, checklist): ");
                string type = Console.ReadLine()?.ToLower();
                Console.Write("Name: "); string name = Console.ReadLine();
                Console.Write("Description: "); string desc = Console.ReadLine();
                Console.Write("Points: "); int pts = int.Parse(Console.ReadLine());

                switch (type)
                {
                    case "simple":
                        manager.AddGoal(new SimpleGoal(name, desc, pts));
                        break;
                    case "eternal":
                        manager.AddGoal(new EternalGoal(name, desc, pts));
                        break;
                    case "checklist":
                        Console.Write("Target Count: "); int count = int.Parse(Console.ReadLine());
                        Console.Write("Bonus Points: "); int bonus = int.Parse(Console.ReadLine());
                        manager.AddGoal(new ChecklistGoal(name, desc, pts, count, bonus));
                        break;
                }
            }
            else if (input == "2")
                manager.DisplayGoals();
            else if (input == "3")
            {
                manager.DisplayGoals();
                Console.Write("Which goal number? ");
                if (int.TryParse(Console.ReadLine(), out int index)) manager.RecordEvent(index - 1);
            }
            else if (input == "4")
                manager.ShowScore();
            else if (input == "5")
                manager.SaveGoals(file);
            else if (input == "6")
                manager.LoadGoals(file);
            else if (input == "7")
                break;
        }
    }
}
