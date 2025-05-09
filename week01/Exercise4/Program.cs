using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int UserInput;

        do
        {
            Console.Write("Enter a number (or 0 to stop): ");
            UserInput = int.Parse(Console.ReadLine());

            if (UserInput != 0)
            {
                numbers.Add(UserInput);
            }
        } while (UserInput != 0);
        
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum of the numbers is: {sum}");

        if(numbers.Count > 0)
        {
            float average = (float)sum / numbers.Count;
            Console.WriteLine($"The average of the numbers is: {average}");
        }
        if (numbers.Count == 0)
        {
            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            Console.Write($"The maximum is: {max}");
        }
    }
}