using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace golosovanie
{
    internal class Election
    {
        private string _electionName;
        public string ElectionName
        {
            get { return _electionName; }
            set { _electionName = value; }
        }
        public Dictionary<string, int> Options { get; } = new Dictionary<string, int>();
        public Dictionary<string, int> Votes { get; } = new Dictionary<string, int>();

        public Election()
        {
            Options = new Dictionary<string, int>();
            Votes = new Dictionary<string, int>();
        }

        public void AddOption(string option)
        {
            Options[option] = 0;
        }

        public void DisplayOptions()
        {
            Console.WriteLine("***Options***:");
            foreach (var option in Options.Keys)
            {
                Console.WriteLine(option);
            }
        }

        public void Vote(string option)
        {
            if (Options.ContainsKey(option))
            {
                Options[option]++;
                Console.WriteLine($"Your vote for '{option}' has been added.");
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }

        public void DisplayResults()
        {
            Console.WriteLine($"Election Results for '{ElectionName}':");
            foreach (var option in Options.Keys)
            {
                Console.WriteLine($"{option}: {Options[option]} votes");
            }
        }
    }
}
