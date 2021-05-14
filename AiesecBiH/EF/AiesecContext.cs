using System;
using System.Collections.Generic;
using System.Text;
using AiesecBiH.Database;
using Microsoft.EntityFrameworkCore;

namespace AiesecBiH.EF
{
    public class AiesecContext: DbContext
    {
        public AiesecContext(DbContextOptions<AiesecContext> options):base(options)
        {
        }
        public DbSet<City> Cities { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<FileModel> FileModels { get; set; }
        public DbSet<FunctionalField> FunctionalFields { get; set; }
        public DbSet<LocalCommittee> LocalCommittees { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Task>()
                .Property(x => x.Priority)
                .HasConversion<int>();
        }
    }
}
