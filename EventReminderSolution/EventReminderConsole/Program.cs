using System;
using System.Collections.Generic;

namespace EventReminderConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //kld code

            //make a list of strings 
            //List<string> list = new List<string>();

            //list.Add("apple");
            //list.Add("orange");

            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            //kld code end 

            List<string> list = new List<string>();


            while (true)
            {

                Console.WriteLine("\nEnter a command");
                string input = Console.ReadLine();
                Console.WriteLine("You've selected "+ input);

                string[] tokens = input.Split(' ');

                string command = tokens[0].ToLower();
                if (command.StartsWith("add"))
                {
                    Console.WriteLine($"you've added {tokens[1]} on {tokens[2]}");                    
                }
                else if (command == "list")
                {
                    Console.WriteLine("Bringing up the list");
                }
                else if (command == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("learn to type");
                }
            }
            Console.WriteLine("Closing program");
            Console.ReadLine();
        }
    }
}
