﻿using System;
using Microsoft.EntityFrameworkCore;

namespace CodingEventsDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        private readonly string _connectionString;

        
        public ApplicationDbContext()
        {
        }

        //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S
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;database=coding_events;user=coding_events;password=Aaradhya@77");
        }
    }
}
