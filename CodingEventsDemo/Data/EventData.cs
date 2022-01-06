using System;
using System.Collections.Generic;
using CodingEventsDemo.Models;

namespace CodingEventsDemo.Data
{
    public class EventData
    {
        public EventData()
        {
        }
        //Store Events
        private static Dictionary<int, Event> Events = new Dictionary<int, Event>();

        //add Events
        public static void Add (Event newEvent)
        {
            Events.Add(newEvent.Id, newEvent);
        }

        //retreieve all events
        public static IEnumerable<Event> GetAll()
        {
            return Events.Values;
        }

        //retrieve single
        public static Event GetById(int Id)
        {

            return Events[Id];
        }

        //remove an event

        public static void Remove(int Id)
        {
            Events.Remove(Id);
        }

    }
}
