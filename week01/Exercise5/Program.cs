using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Welcome to the program!");
        
        Console.Write("\nPlease enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Please enter your number: ");
        string number = Console.ReadLine();
        Console.Write(name + ", the sqaure of your number is " + (int.Parse(number) * int.Parse(number)) + ".\n");
    }
}