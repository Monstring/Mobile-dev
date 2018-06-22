using System;
using System.Collections.Generic;

namespace EventReminderConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("\n>");
                string input = Console.ReadLine();
                string[] tokens = input.Split(' ');
                string command = tokens[0].ToLower();

                if (command.StartsWith("add"))
                {
                    Console.WriteLine($"you've added {tokens[1]} on {tokens[2]}");
                    AddReminder(tokens[1], tokens[2]);
                }
                else if (command == "list")
                {
                    ListReminders();
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
        static List<Reminder> eventList = new List<Reminder>();
        private static void AddReminder(string name, string date) {
            Reminder newEvent = new Reminder(name, date);
            eventList.Add(newEvent);
        }

        private static void ListReminders() {
            for (int i = 0; i < eventList.Count; i++)
            {
                Reminder e = eventList[i];
                Console.WriteLine((i + 1) + "-" + e.ToString());
            }
        }
    }


}
