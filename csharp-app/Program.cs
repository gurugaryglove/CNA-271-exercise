using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("WELCOME TO Belgium Campus\n");
        Console.WriteLine("=== Student Registration ===\n");

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Surname: ");
        string surname = Console.ReadLine();

        Console.Write("Gender: ");
        string gender = Console.ReadLine();

        Console.Write("Age: ");
        string age = Console.ReadLine();

        Console.WriteLine("\n--- Registration Details ---");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Surname: {surname}");
        Console.WriteLine($"Gender: {gender}");
        Console.WriteLine($"Age: {age}");

        Console.WriteLine("\nGood Bye thank you for registering");
    }
}
