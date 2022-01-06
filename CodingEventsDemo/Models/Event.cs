using System;
using System.Diagnostics;

namespace CodingEventsDemo.Models
{
    public class Event
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ContactEmail { get; set; }
        public EventType Type { get; set; }
        public int Id { get; set; }

        public Event()
        {
        }
        public Event(string name, string description, string contactEmail)
        {
            Name = name;
            Description = description;
            ContactEmail = contactEmail;

        }

        public override string ToString()
        {
            return Name;
        }
    }
}
