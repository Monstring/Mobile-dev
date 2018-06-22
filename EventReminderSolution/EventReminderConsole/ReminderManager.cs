using System;
using System.Collections.Generic;

namespace EventReminderConsole
{
    public class ReminderManager {
        private List<Reminder> Reminders;
        public ReminderManager()
        {
            Reminders = new List<Reminder>();
        }
        public void AddReminder(string name, string date)
        {
            name = name.Trim();
            for (int i = 0; i < Reminders.Count; i++)
            {
                Reminder r = Reminders[i];
                if (Reminders[i].Name.ToLower() == name.ToLower()) {
                    Console.WriteLine("You can't add duplicate names");
                    return;
                }
            }
            try
            {
                Reminder newEvent = new Reminder(name, date);
                Reminders.Add(newEvent);
                Console.WriteLine($"you've added {name} on {date}");
            }catch(ArgumentException e)
            {
                Console.WriteLine("Error! " + e.Message);
            }
        }

        public void ListReminders()
        {
            for (int i = 0; i < Reminders.Count; i++)
            {
                Reminder e = Reminders[i];
                Console.WriteLine((i + 1) + "-" + e.ToString());
            }
        }
    }
}
