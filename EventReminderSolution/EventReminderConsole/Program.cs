using System;
using System.Collections.Generic;

namespace EventReminderConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Event> eventList = new List<Event>();
            while (true)
            {
                Console.Write("\n>");
                string input = Console.ReadLine();

                string[] tokens = input.Split(' ');

                string command = tokens[0].ToLower();
                if (command.StartsWith("add"))
                {
                    Console.WriteLine($"you've added {tokens[1]} on {tokens[2]}");

                    Event newEvent = new Event(tokens[1], tokens[2]);
                        
                    eventList.Add(newEvent);
                }
                else if (command == "list")
                {
                    for (int i = 0; i < eventList.Count; i++)
                    {
                        Event e = eventList[i];
                       
                        Console.WriteLine((i+1) + "-" + e.ToString());

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

    public class Event
    {
        public string Name;
        public DateTime Date;

        public Event(string name , string date)
        {
            this.Name = name;
            this.Date = DateTime.Parse(date);
        }

        public Event(string name, DateTime date)
        {
            this.Name = name;
            this.Date = date;
        }

        public override string ToString()
        {
            return Name + " " + Date.ToShortDateString(); 
        }
    }


}
