using System;
using System.Collections.Generic;

namespace EventReminderConsole
{
    public class ReminderManager {
        private List<Reminder> EventList;
        public ReminderManager()
        {
            EventList = new List<Reminder>();
        }
        public void AddReminder(string name, string date)
        {
            Reminder newEvent = new Reminder(name, date);
            EventList.Add(newEvent);
            Console.WriteLine($"you've added {name} on {date}");
        }

        public void ListReminders()
        {
            for (int i = 0; i < EventList.Count; i++)
            {
                Reminder e = EventList[i];
                Console.WriteLine((i + 1) + "-" + e.ToString());
            }
        }
    }

}
