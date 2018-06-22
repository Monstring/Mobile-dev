using System;

namespace EventReminderConsole
{
    public class Reminder
    {
        public string Name;
        public DateTime Date;

        //this is a contructor
        public Reminder(string name , string date)
        {
            this.Name = name;
            if (DateTime.TryParse(date, out this.Date) == false) {
                throw new ArgumentException($"{date} is not a valid date");
            }

        }

        //this is a constructor
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
