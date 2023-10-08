using golosovanie;
using System;
using static System.Collections.Specialized.BitVector32;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Create a new election:");
        Console.WriteLine("Enter the name of the election:");
        string electionName = Console.ReadLine();

        Election election = new Election();
        election.ElectionName = electionName;

        Console.WriteLine($"Election '{electionName}' has been created.");
        Console.WriteLine("Enter options for the election (one option per line and string value). Enter 'done' to finish.");

        while (true)
        {
            string option = Console.ReadLine();
            if (option.ToLower() == "done")
            {
                break;
            }

            election.AddOption(option);
        }

        Console.WriteLine("Options have been set. Let voters cast their votes.");

        while (true)
        {
            Console.WriteLine("Enter your vote (type 'exit' to see the results):");
            string vote = Console.ReadLine();

            if (vote.ToLower() == "exit")
            {
                break;
            }

            election.Vote(vote);
        }

        election.DisplayResults();
    }
}
