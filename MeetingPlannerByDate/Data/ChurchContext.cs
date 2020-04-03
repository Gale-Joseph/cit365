using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetingPlanner.Models;
using Microsoft.EntityFrameworkCore;


namespace MeetingPlanner.Data
{
    public class ChurchContext : DbContext
    {
        public ChurchContext(DbContextOptions<ChurchContext> options) : base(options)
        {

        }

        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Speaker> Speakers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Meeting>().ToTable("Meeting");
            modelBuilder.Entity<Speaker>().ToTable("Speaker");
           
        }
    }
}
