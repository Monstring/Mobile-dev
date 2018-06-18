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

            List<string> eventList = new List<string>();


            while (true)
            {

                Console.Write("\n>");
                string input = Console.ReadLine();

                string[] tokens = input.Split(' ');

                string command = tokens[0].ToLower();
                if (command.StartsWith("add"))
                {
                    Console.WriteLine($"you've added {tokens[1]} on {tokens[2]}");
                    eventList.Add(string.Format("{0} {1}", tokens[1], tokens[2]));
                }
                else if (command == "list")
                {
                    for (int i = 0; i < eventList.Count; i++)
                    {
                        Console.WriteLine((i+1)+"-"+eventList[i]);

                    }
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
