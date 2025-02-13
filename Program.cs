using System;

class Program
{
    static void DisplayMenu()
    {
        Console.WriteLine("**************");
        Console.WriteLine("\nMenu:\n");
        Console.WriteLine("1 - New Game");
        Console.WriteLine("2 - Load Game");
        Console.WriteLine("3 - Options");
        Console.WriteLine("4 - Quit");
        Console.WriteLine("\n**************");
    }

    static void Main()
    {
        while (true)
        {
            DisplayMenu();
            Console.Write("\nEnter your choice: ");
            
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int choice))
            {
                Console.WriteLine("Invalid input! Please enter a number between 1 and 4.\n");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nStarting a New Game...\n");
                    break;
                case 2:
                    Console.WriteLine("\nLoading Game...\n");
                    break;
                case 3:
                    Console.WriteLine("\nOpening Options...\n");
                    break;
                case 4:
                    Console.WriteLine("\nQuitting... Goodbye!\n");
                    return;
                default:
                    Console.WriteLine("\nInvalid choice! Please enter a number between 1 and 4.\n");
                    break;
            }
        }
    }
}

