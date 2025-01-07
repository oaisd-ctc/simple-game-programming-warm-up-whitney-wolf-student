using System;

public class Program 
{
    static int a = 0;
    static int b = 0;
    public static void Main(string[] args)
    {
        Introduction();

        for (int round = 1; round <= 10; round++)
        {
            PlayRound(round);
        }

        Final();
    }

    public static void Introduction()
    {
        Console.WriteLine("Dice Game");
        Console.WriteLine("In this game, you and a computer rival will play 10 rounds where you will each roll a 6-sided dice, and the player with the highest dice value will win the round. The player who wins the most rounds wins the game. Good luck!");
        Console.WriteLine("Press any key to start...");
        Console.ReadKey();
    }

    public static void PlayRound(int roundNumber)
    {
        Console.WriteLine($"\nRound {roundNumber}");

        Random rnd = new Random();
        int Computer = rnd.Next(1, 7);
        Console.WriteLine("Rival has rolled a " + Computer);

        Console.WriteLine("Press any key to roll your dice...");
        Console.ReadKey();
        int You = rnd.Next(1, 7);
        Console.WriteLine("You have rolled a " + You);

        Score(Computer, You);
    }


    public static void Score(int Computer, int You)
    {
        if (Computer > You)
        {
            Console.WriteLine("The Rival has won this round.");
            a++;
        }
        else if (You > Computer)
        {
            Console.WriteLine("You have won this round.");
            b++;
        }
        else
        {
            Console.WriteLine("It's a tie this round.");
        }

        Console.WriteLine("The Score is now - You: " + b + ". Rival: " + a + ".");
    }

    public static void Final()
    {
        Console.WriteLine();
        Console.WriteLine("Game over.");
        Console.WriteLine("The Score is now - You: " + b + ". Rival: " + a + ".");
        if (a > b)
        {
            Console.WriteLine("You lost!");
        }
        else if (a == b)
        {
            Console.WriteLine("You tied!");
        }
        else
        {
            Console.WriteLine("You won!");
        }
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Dice Game was closed.");
    }
}
