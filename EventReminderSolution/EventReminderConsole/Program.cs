using System;

namespace EventReminderConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ReminderManager reminderManager = new ReminderManager();
            while (true)
            {
                Console.Write("\n>");
                string input = Console.ReadLine();
                string[] tokens = input.Split(' ');
                string command = tokens[0].ToLower();

                if (command.StartsWith("add"))
                {
                    reminderManager.AddReminder(tokens[1], tokens[2]);
                }
                else if (command == "list")
                {
                    reminderManager.ListReminders();
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
