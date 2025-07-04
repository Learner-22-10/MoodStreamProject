using System;

namespace MoodStreamConsole
{
    public class Song
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Welcome to Mode Stream Console !");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("What is your name ? ");
            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hi " + name + " Have fun listening to your mood based music !");
            string mood = " ";
            while (mood.ToLower() != "exit")
            {
                Console.WriteLine("What is your mood today ?");
                List<string> moods = new List<string> { "happy", "sad", "angry", "sleepy" };
                for (int i = 0; i < moods.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {moods[i]}");
                }
                mood = Console.ReadLine();


                Dictionary<string, string> moodSongs = new Dictionary<string, string>
            {
                {"happy", "plaing fevicol se"},
                {"sad", "playing heartbreak anniversary" },
                {"angry", "narudu bathuku natana" },
                {"sleepy", "adhire hrudayam" }
            };

                if (moodSongs.ContainsKey(mood.ToLower()))
                {
                    Console.WriteLine(moodSongs[mood.ToLower()]);
                }
                else if(mood.ToLower() == "exit")
                {
                    Console.WriteLine("Good bye !, See you later ");
                }
                else
                {
                    Console.WriteLine("Please enter a valid mood from the list ");
                }
            }
        }
    }
}