using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBotPOE
{
    class TaskClass
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Reminder { get; set; }
        public bool IsCompleted { get; set; }

        public override string ToString()
        {
            return $"Title: {Name}\nDescription: {Description} (Remind on {Reminder.ToShortDateString()}, Completed: {(IsCompleted ? "Yes" : "No")})";

        }
    }
}
