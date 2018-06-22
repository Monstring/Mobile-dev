using System;

namespace EventReminderConsole
{
    public class Reminder
    {
        public string Name;
        public DateTime Date;

        public Reminder(string name , string date)
        {
            this.Name = name;
            this.Date = DateTime.Parse(date);
        }

        public Reminder(string name, DateTime date)
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
