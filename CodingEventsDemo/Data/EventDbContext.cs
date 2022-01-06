using System;
using CodingEventsDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace CodingEventsDemo.Data
{
    public class EventDbContext : DbContext
    {
        public DbSet<Event> Events {get; set;}

        public EventDbContext(DbContextOptions<EventDbContext> options) : base(options)
        {
        }

        //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S
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseMySql("server=localhost;database=coding_events;user=coding_events;password=Aaradhya@77");
        //}
    }
}
