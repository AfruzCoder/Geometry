
using System.Runtime.CompilerServices;

bool isCantinue = true;

do
{
    Console.Clear();
    Console.WriteLine("Welcome to my project");
    Console.WriteLine("1.Calculation");
    Console.WriteLine("2.Draw");
    Console.Write("Enter your command:(i: 1,2): ");
    int commandFirst = Convert.ToInt32(Console.ReadLine);

    if (commandFirst == 1)
    {
        Console.Clear();
        Console.WriteLine("===Calculation===");
        Console.WriteLine("1.kub is volume");
        Console.WriteLine("2.circle face");
        Console.WriteLine("Enter your command for calculation:(i: 1,2): ");
        int commandSecond = Convert.ToInt32(Console.ReadLine());

        if (commandSecond == 1)
        {
            Console.WriteLine("");

        }
        else if (commandSecond == 2) ;
        {
            Console.WriteLine("");
        }

    }
    else
    {

    }
    Console.WriteLine("Is cantinue: ");
    string commandCantinue = Console.ReadLine();

    if (commandCantinue.ToLower().Contains("no") is true)
    {
        isCantinue = false;
    }
} while (isCantinue is true);
